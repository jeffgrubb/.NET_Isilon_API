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
    public class Thresholds
    {
        // Three types of quotas.. Advisory, Hard, and Soft.

        // Advisory: Notifications when limit is reached or exceeded
        // Soft: Defines a soft limit for enforcement, with grace period. Notifications after limit is reached
        // Hard: Strict enforcement, no writes beyond limit

        // Specifies the usage bytes at which notifications are sent but writes are not denied

        public bool HasAdvisory() { if (_Advisory == null) return false; return true; }
        
        [DataMember(Name = "advisory")]
        protected object _Advisory;

        public int Advisory
        {
            get { if (_Advisory != null) return (int)_Advisory; throw new Exception("Advisory was null"); }
            set { _Advisory = (object)value; }
        }

        [DataMember(Name = "advisory_exceeded")]
        public bool AdvisoryExceeded;


        [DataMember(Name = "advisory_last_exceeded")]
        protected object _AdvisoryLastExceeded;
        public int AdvisoryLastExceeded
        {
            get { if (_AdvisoryLastExceeded != null) return (int)_AdvisoryLastExceeded; throw new Exception("AdvisoryLastExceeded was null"); }
        }


        public bool HasHard() { if (_Hard == null) return false; return true; }

        [DataMember(Name = "hard")]
        protected object _Hard;

        public int Hard
        {
            get { if (_Hard != null) return (int)_Hard; throw new Exception("Hard was null"); }
            set { _Hard = (object)value; }
        }

        [DataMember(Name = "hard_exceeded")]
        public bool HardExceeded;

        [DataMember(Name = "hard_last_exceeded")]
        protected object _HardLastExceeded;
        public int HardLastExceeded
        {
            get { if (_HardLastExceeded != null) return (int)_HardLastExceeded; throw new Exception("HardLastExceeded was null"); }
        }


        public bool HasSoft() { if (_Soft == null) return false; return true; }

        [DataMember(Name = "soft")]
        protected object _Soft;

        public int Soft
        {
            get { if (_Soft != null) return (int)_Soft; throw new Exception("Soft was null"); }
            set { _Soft = (object)value; }
        }

        [DataMember(Name = "soft_exceeded")]
        public bool SoftExceeded;

        // Grace period, in seconds, between when notifications are sent, and when writes are denied.
        [DataMember(Name = "soft_grace")]
        protected object _SoftGrace;
        public int SoftGrace
        {
            get { if (_SoftGrace != null) return (int)_SoftGrace; throw new Exception("SoftGrace was null"); }
            set { _SoftGrace = value; }
        }

        [DataMember(Name = "soft_last_exceeded")]
        protected object _SoftLastExceeded;
        public int SoftLastExceeded
        {
            get { if (_SoftLastExceeded != null) return (int)_SoftLastExceeded; throw new Exception("SoftLastExceeded was null"); }
        }
    }
}
