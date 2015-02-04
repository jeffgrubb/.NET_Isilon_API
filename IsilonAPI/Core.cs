/*-------------------------------------------------------------------------------
 * Name:        .NET_Isilon_API
 * Purpose:     Automate Isilon OneFS configuration by using REST API
 *
 * Author:      Jeff Grubb
 *              Associate Systems Engineer, EMC
 *              jeffrey.grubb@emc.com
 *
 * Version:     0.5
 *
 * Created:     2/1/2015
 * 
 * Licence:     Open to distribute and modify.  This example code is unsupported
 *              by both EMC and the author.  IF YOU HAVE PROBLEMS WITH THIS
 *              SOFTWARE, THERE IS NO ONE PROVIDING TECHNICAL SUPPORT FOR
 *              RESOLVING ISSUES. USE CODE AS IS!
 *
 *              THIS CODE IS NOT AFFILIATED WITH EMC CORPORATION.
 *-------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Net;
using System.IO;

namespace IsilonAPI
{
    public abstract class Core
    {
        protected string Username;
        protected string Password;
        protected string IsilonUrl;

        // public string AuthToken -- todo, Basic/Token authentication

        public Core(string username, string password, string isilonUrl, bool IgnoreInvalidCerts)
        {
            Username = username;
            Password = password;
            IsilonUrl = isilonUrl;

            // If we are to ignore invalid certifications.. Mainly used for non-production systems.
            if(IgnoreInvalidCerts)
            {
                ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(ValidateRemoteCertificate);
            }
        }

        // callback used to validate the certificate in an SSL conversation
        private static bool ValidateRemoteCertificate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors policyErrors)
        {
            // This is a hack. Please don't use for production systems.
            return true;
        }


        protected RequestResult RunResult(string resource)
        {
            return RunResult(resource, "GET", "", null, null, null);
        }

        protected RequestResult RunResult(string resource, Type responseType)
        {
            return RunResult(resource, "GET", "", null, null, responseType);
        }

        protected RequestResult RunResult(string resource, string requestMethod, object body = null, Type bodyType = null)
        {
            return RunResult(resource, requestMethod, "application/json", body, bodyType, null);
        }

        protected RequestResult RunResult(string resource, string requestMethod, string requestContentType, object body = null, Type bodyType = null, Type responseType = null)
        {
            // Create a web request object pointing to the Isilon server and Resource String
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(IsilonUrl + resource);
            request.Method = requestMethod;
            if(requestContentType != "")
            {
                request.ContentType = requestContentType;
            }

            // Add the Authroization header for Basic authentication
            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes(Username + ":" + Password)));

            // Is the request to include a json object?
            if(body != null)
            {
                if (bodyType == null) throw new Exception("bug check - bodyType == null");

                DataContractJsonSerializer serializer = new DataContractJsonSerializer(bodyType);
                serializer.WriteObject(request.GetRequestStream(), body);
            }

            // Send the request to the Isilon cluster and get there response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            object content = null;

            // If the request should be serialized into a .NET object, do so according to the class specified as responseType
            if (responseType != null)
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(responseType);
                
                // Mainly for debug purposes at this point.. Read to a string, then write that string to a Stream in memory
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string responseString = reader.ReadToEnd();

                MemoryStream ms = new MemoryStream();
                ms.Write(System.Text.Encoding.UTF8.GetBytes(responseString), 0, responseString.Length);
                ms.Seek(0, SeekOrigin.Begin);

                // Create our .NET object
                content = serializer.ReadObject(ms);
                ms.Close();
            }
            else
            {
                // No specific class was specified so, create a string.. Mainly for debug/dev purposes at this point
                StreamReader reader = new StreamReader(response.GetResponseStream());
                content = (object)reader.ReadToEnd();
            }

            return new RequestResult()
            {
                Content = content,
                HttpStatusCode = response.StatusCode
            };
        }
    }
}
