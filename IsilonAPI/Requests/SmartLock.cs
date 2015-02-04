using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsilonAPI.Requests
{
    public class SmartLock : Core
    {
        public SmartLock(string Username, string Password, string IsilonUrl, bool IgnoreInvalidCerts)
            : base(Username, Password, IsilonUrl, IgnoreInvalidCerts)
        {

        }

        public void GetSmartLockDomains()
        {

        }

        public void GetSmartLockDomain(string domain)
        {

        }

        public void CreateSmartLockDomain()
        {

        }

        public void ModifySmartLockDomain()
        {

        }

        // Not in the documentation, will this work?
        public void DeleteSmartLockDomain()
        {

        }
    }
}
