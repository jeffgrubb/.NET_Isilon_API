using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace IsilonAPI
{
    public class IsilonService
    {
        public string Username;
        public string Password;
        public string IsilonUrl;
        public bool IgnoreInvalidCerts;

        // public string AuthToken -- todo, Basic/Token authentication

        public IsilonService(string username, string password, string isilonUrl, bool ignoreInvalidCerts)
        {
            Username = username;
            Password = password;
            IsilonUrl = isilonUrl;
            IgnoreInvalidCerts = ignoreInvalidCerts;
        }

        public HttpWebRequest CreateRequest(string resource)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(IsilonUrl + resource);

            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes(Username + ":" + Password)));

            return request;

        }
    }
}
