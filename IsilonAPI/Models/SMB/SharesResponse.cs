using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace IsilonAPI.Models.SMB
{
    [DataContract]
    public class SharesResponse
    {
        [DataMember(Name = "resume")]
        public string Resume;

        [DataMember(Name = "shares")]
        public Share[] Shares;

        [DataMember(Name = "total")]
        public int Total;
    }
}
