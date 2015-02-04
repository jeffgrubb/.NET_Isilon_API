using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace IsilonAPI.Models.Deduplication
{
    [DataContract]
    public class DeduplicationReport
    {
        [DataMember(Name = "phase")]
        public int Phase;

        [DataMember(Name = "results")]
        public string Results;

        [DataMember(Name = "time")]
        public int Time;
    }
}
