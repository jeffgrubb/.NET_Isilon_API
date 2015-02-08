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
    public class Quota
    {
        // Enables the SMB shares using the quota directory to see the quota threshold as the share size.
        [DataMember(Name = "container", EmitDefaultValue = false)]
        public bool Container;

        // True if the quota provides enforcement, otherwise an accounting quota
        [DataMember(Name = "enforced", EmitDefaultValue = false)]
        public bool Enforced;

        // ID of the quota
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id;

        // True if the quota governs snapshot data as well as head data.
        [DataMember(Name = "include_snapshots", EmitDefaultValue = false)]
        public bool IncludeSnapshots;

        // True if the quota for a user or group is linked and controlled by a parent default-* quota.
        // Linked quotas cannot be modified until they are unlinked.
        [DataMember(Name = "linked", EmitDefaultValue = false)]
        public object _Linked;

        public bool Linked
        {
            get { if (_Linked != null) return (bool)_Linked; throw new Exception("Linked was null"); }
        }

        // Specifies a summary of the notifications: 
        // Custom indicates that one or more notification rules are available from the notifications sub-resource
        [DataMember(Name = "notifications", EmitDefaultValue = false)]
        public object Notifications; // Default = no notifications? Will this return an array if multiple notifications?

        // OneFS path
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path;

        [DataMember(Name = "persona", EmitDefaultValue = false)] // not sure, not in documentation
        public object Persona;

        // True if accounting is accurage on the quota. 
        // If false, this quota is waiting on the completion of a QuotaScan job.
        [DataMember(Name = "ready", EmitDefaultValue = false)]
        public bool Ready;

        [DataMember(Name = "thresholds", EmitDefaultValue = false)]
        public Thresholds Thresholds;

        // True if the thresholds apply to the data plus file system overhead that is required to store the data
        // (such as physical useage)
        [DataMember(Name = "thresholds_include_overhead", EmitDefaultValue = false)]
        public bool ThresholdsIncludeOverhead;

        // Type of quota - User, group, directory
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type;

        [DataMember(Name = "useage", EmitDefaultValue = false)]
        public Useage _Useage; 
    }
}
