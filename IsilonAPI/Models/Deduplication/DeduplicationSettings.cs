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
    public class DeduplicationSettings
    {
        [DataMember(Name = "assess_paths", EmitDefaultValue = false)]
        public string[] AssessPaths;

        [DataMember(Name = "dedupe_schedule", EmitDefaultValue = false)]
        public string DedupeSchedule;

        [DataMember(Name = "paths", EmitDefaultValue = false)]
        public string[] Paths;
    }
}
