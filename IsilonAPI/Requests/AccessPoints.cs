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
        public AccessPoints(IsilonService service)
            : base(service)
        {

        }

        public AccessPoint[] GetAccessPoints()
        {
            AccessPointsResponse res = Get<AccessPointsResponse>("/namespace");
            return res.AccessPoints;
        }

        public void CreateAccessPoint(string Name, string AbsolutePath)
        {
            AccessPoint point = new AccessPoint();
            point.Path = AbsolutePath;

            Put<AccessPoint>("/namespace/" + Name, point);
        }

        public void DeleteAccessPoint(string Name)
        {
            Delete("/namespace/" + Name);
        }
    }
}
