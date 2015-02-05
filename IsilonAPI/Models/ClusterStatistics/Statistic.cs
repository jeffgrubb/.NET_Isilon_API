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
    public class Statistic
    {
        [DataMember(Name = "devid")]
        public int DevId;

        [DataMember(Name = "error")]
        public string Error;

        [DataMember(Name = "error_code")]
        public int ErrorCode;

        [DataMember(Name = "key")]
        public string Key;

        [DataMember(Name = "time")]
        public int Time;

        [DataMember(Name = "value")]
        public object Value;
    }
}
