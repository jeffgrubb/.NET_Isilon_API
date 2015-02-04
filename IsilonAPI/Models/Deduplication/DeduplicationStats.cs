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
    public class DeduplicationStats
    {
        [DataMember(Name = "block_size")]
        public int BlockSize;

        [DataMember(Name = "estimated_physical_blocks")]
        public int EstimatedPhysicalBlocks;

        [DataMember(Name = "estimated_saved_blocks")]
        public int EstimatedSavedBlocks;

        [DataMember(Name = "logical_blocks")]
        public int LogicalBlocks;

        [DataMember(Name = "saved_logical_blocks")]
        public int SavedLogicalBlocks;

        [DataMember(Name = "total_blocks")]
        public int TotalBlocks;

        [DataMember(Name = "used_blocks")]
        public int UsedBlocks;
    }
}
