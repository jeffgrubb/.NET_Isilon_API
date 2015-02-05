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
    public class StatisticsKeys
    {
        [DataMember(Name = "aggregation_type")]
        public string AggregationType;

        [DataMember(Name = "base_name")]
        public string BaseName;

        [DataMember(Name = "default_cache_time")]
        private object _DefaultCacheTime;

        // Necessary since a null value has been spotted as a return for an int.
        public int DefaultCacheTime
        {
            get
            {
                if (_DefaultCacheTime != null)
                {
                    return (int)_DefaultCacheTime;
                }
                else throw new Exception("Was null");
            }
        }

        [DataMember(Name = "description")]
        public string Description;

        [DataMember(Name = "key")]
        public string Key;

        [DataMember(Name = "policies")]
        public Policy[] Policies;

        [DataMember(Name = "policy_cache_time")]
        private object _PolicyCacheTime;

        // Necessary since a null value has been spotted as a return for an int.
        public int PolicyCacheTime
        {
            get
            {
                if (_PolicyCacheTime != null)
                {
                    return (int)_PolicyCacheTime;
                }
                else throw new Exception("Was null");
            }
        }
              
        [DataMember(Name = "real_name")]
        public string RealName;

        [DataMember(Name = "Scope")]
        public string Scope;

        [DataMember(Name = "Type")]
        public string Type;

        [DataMember(Name = "units")]
        public string Units;

        [DataMember(Name = "value")]
        public object Value;
    }
}
