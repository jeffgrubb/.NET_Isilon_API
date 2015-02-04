using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace IsilonAPI.Models.AccessPoints
{
    public class AccessControlList
    {
        [DataMember(Name = "trustee")]
        public Trustee Trustee;

        [DataMember(Name = "accesstype")]
        public string AccessType;

        [DataMember(Name = "accessrights")]
        public string[] AccessRights;

        [DataMember(Name = "op", EmitDefaultValue=false)]
        public string Operation;
    }
}
