using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace IsilonAPI.Models.AccessPoints
{
    [DataContract]
    public class CreateACLRequest
    {
        [DataMember(Name = "authoritative")]
        public string authoritative = "acl";

        [DataMember(Name = "acl")]
        public AccessControlList[] acl;
    }
}
