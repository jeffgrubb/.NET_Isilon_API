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
    public class DeduplicationReports
    {
        [DataMember(Name = "resume")]
        public string Resume;

        [DataMember(Name = "dedupe_percent")]
        public int dedupe_percent;

        [DataMember(Name = "elapsed_time")]
        public int ElapsedTime;

        [DataMember(Name = "id")]
        public string Id;

        [DataMember(Name = "job_id")]
        public string JobId;

        [DataMember(Name = "job_type")]
        public string JobType;

        [DataMember(Name = "reports")]
        public DeduplicationReport[] reports;
    }
}
