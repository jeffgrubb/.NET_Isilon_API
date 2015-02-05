using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace IsilonAPI.Models.ClusterStatistics
{
    [DataContract]
    public class Policy
    {
        [DataMember(Name = "interval")]
        public int Interval;

        [DataMember(Name = "persistant")]
        public bool Persistant;

        [DataMember(Name = "retention")]
        public int Retention;
    }
}
