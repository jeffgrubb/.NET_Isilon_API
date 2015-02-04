using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace IsilonAPI.Models.FilePools
{
    [DataContract]
    public class DefaultPolicy
    {
        [DataMember(Name = "default-policy")]
        public object defaultPolicy;

        [DataMember(Name = "actions")]
        public object[] actions;

        [DataMember(Name = "action_param")]
        public object ActionParam;

        [DataMember(Name = "action_type")]
        public object ActionType;
    }
}
