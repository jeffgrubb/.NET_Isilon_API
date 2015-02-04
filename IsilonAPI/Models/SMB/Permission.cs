using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using IsilonAPI.Models.AccessPoints;

namespace IsilonAPI.Models.SMB
{
    [DataContract]
    public class Permission
    {
        [DataMember(Name = "trustee")]
        public Trustee Trustee;

        [DataMember(Name = "permission")]
        public string _Permission;

        [DataMember(Name = "permission_type")]
        public string PermissionType;
    }
}
