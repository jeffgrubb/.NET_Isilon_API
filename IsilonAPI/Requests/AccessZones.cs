using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsilonAPI.Models.AccessZones;

namespace IsilonAPI.Requests
{
    public class AccessZones : Core
    {
        public AccessZones(string Username, string Password, string IsilonUrl, bool IgnoreInvalidCerts)
            : base(Username, Password, IsilonUrl, IgnoreInvalidCerts)
        {

        }

        public string GetAccessZonesSummary()
        {
            RequestResult res = RunResult("/platform/1/zones-summary");
            return (string)res.Content;
        }
    }
}
