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
    public class Trustee
    {
        // todo - userID/GroupID?

        [DataMember(Name = "name")]
        public string UserName;

        [DataMember(Name = "type")]
        public string UserType;
    }
}
