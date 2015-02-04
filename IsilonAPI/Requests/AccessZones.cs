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
        public AccessZones(IsilonService service)
            : base(service)
        {

        }

        public string GetAccessZonesSummary()
        {
            return Get<string>("/platform/1/zones-summary");
        }
    }
}
