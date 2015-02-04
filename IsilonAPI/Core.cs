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
        protected IsilonService _Service;

        // public string AuthToken -- todo, Basic/Token authentication

        public Core(IsilonService service)
        {
            _Service = service;

            // If we are to ignore invalid certifications.. Mainly used for non-production systems.
            if(_Service.IgnoreInvalidCerts)
            {
                ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(ValidateRemoteCertificate);
            }
        }

        // callback used to validate the certificate in an SSL conversation
        private static bool ValidateRemoteCertificate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors policyErrors)
        {
            // Dont use for production systems
            return true;
        }

        protected T Get<T>(string resource)
        {
            // Create a web request object pointing to the Isilon server and Resource String
            HttpWebRequest request = _Service.CreateRequest(resource);

            // Send the request to the Isilon cluster and get there response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            object content = default(T);

            if(typeof(T) == typeof(string))
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                content = reader.ReadToEnd();
            }
            else
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                content = serializer.ReadObject(response.GetResponseStream());
            }

            response.Close();
            return (T)content;
        }

        protected void Put<T>(string resource, T body)
        {
            // Create a web request object pointing to the Isilon server and Resource String
            HttpWebRequest request = _Service.CreateRequest(resource);
            request.Method = "PUT";

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            serializer.WriteObject(request.GetRequestStream(), (T)body);
            
            // Send the request to the Isilon cluster and get there response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            response.Close();
        }

        protected void Post<T>(string resource, T body)
        {
            // Create a web request object pointing to the Isilon server and Resource String
            HttpWebRequest request = _Service.CreateRequest(resource);
            request.Method = "POST";

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            serializer.WriteObject(request.GetRequestStream(), (T)body);

            // Send the request to the Isilon cluster and get there response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            response.Close();
        }

        protected void Delete(string resource)
        {
            // Create a web request object pointing to the Isilon server and Resource String
            HttpWebRequest request = _Service.CreateRequest(resource);
            request.Method = "DELETE";

            // Send the request to the Isilon cluster and get there response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            response.Close();
        }
    }
}
