using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace IsilonAPI.Models.SmartQuotas
{
    [DataContract]
    public class Useage
    {
        [DataMember(Name = "inodes", EmitDefaultValue = false)]
        public int INodes;

        [DataMember(Name = "logical", EmitDefaultValue = false)]
        public int Logical;
        
        [DataMember(Name = "physical", EmitDefaultValue = false)]
        public int Physical;
    }
}
