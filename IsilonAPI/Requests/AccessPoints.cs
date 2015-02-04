using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsilonAPI.Models.AccessPoints;

namespace IsilonAPI.Requests
{
    public class AccessPoints : Core
    {
        public AccessPoints(string Username, string Password, string IsilonUrl, bool IgnoreInvalidCerts)
            : base(Username, Password, IsilonUrl, IgnoreInvalidCerts)
        {

        }

        public AccessPoint[] GetAccessPoints()
        {
            RequestResult res = RunResult("/namespace/", typeof(AccessPointsResponse));
            return ((AccessPointsResponse)res.Content).AccessPoints;
        }

        public void CreateAccessPoint(string Name, string AbsolutePath)
        {
            AccessPoint point = new AccessPoint();
            point.Path = AbsolutePath;

            RequestResult res = RunResult("/namespace/" + Name, "PUT", point, typeof(AccessPoint));
        }

        public void DeleteAccessPoint(string Name)
        {
            RequestResult res = RunResult("/namespace/" + Name, "DELETE");
        }
    }
}
