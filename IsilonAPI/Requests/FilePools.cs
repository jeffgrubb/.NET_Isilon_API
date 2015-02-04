using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsilonAPI.Models.FilePools;


namespace IsilonAPI.Requests
{
    public class FilePools : Core
    {
        public FilePools(IsilonService service)
            : base(service)
        {

        }

        public string GetDefaultPolicy()
        {
            return Get<string>("/platform/1/filepool/default-policy");
        }

        public void GetPolicies()
        {

        }

        public void GetPolicy(string policyName)
        {

        }

        public void CreateFilePool()
        {

        }

        public void ModifyFilePool()
        {

        }

        public void DeleteFilePool()
        {

        }
    }
}
