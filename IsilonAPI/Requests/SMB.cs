using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsilonAPI.Models.SMB;

namespace IsilonAPI.Requests
{
    public class SMB : Core
    {
        public enum Scope
        {
            User,
            Effective,
            Default,
            None
        };

        public SMB(string Username, string Password, string IsilonUrl, bool IgnoreInvalidCerts)
            : base(Username, Password, IsilonUrl, IgnoreInvalidCerts)
        {

        }

        public Share[] GetSMBShare(string ShareName)
        {
            RequestResult result = RunResult("/platform/1/protocols/smb/shares/" + ShareName, typeof(SharesResponse));
            return ((SharesResponse)result.Content).Shares;
        }

        public SharesSummary GetSMBSharesSummary()
        {
            RequestResult result = RunResult("/platform/1/protocols/smb/shares-summary", typeof(SharesSummaryResponse));
            return ((SharesSummaryResponse)result.Content).Summary;
        }

        public Share[] GetSMBShares(string Sort = null, string Zone = null, Scope scope = Scope.None, bool ResolveNames = false, bool Descending = false, int Limit = -1)
        {
            // Variable to include additional parameters with the request..
            // Things like sorting, specific zones, ascending/descending, and limits will go onto the querystring.
            string Parameters = "";

            string pre = "?";

            if(Sort != null) 
            {
                Parameters += pre + "sort=" + Sort;
                pre = "&";
            }

            if(Zone != null)
            {
                Parameters += pre + "zone=";
                pre = "&";
            }

            if(scope != Scope.None)
            {
                Parameters += pre;
                switch(scope)
                {
                    case Scope.User: Parameters += "user"; break;
                    case Scope.Effective: Parameters += "effective"; break;
                    case Scope.Default: Parameters += "default"; break; // Don't think this is necessary, but whatever.
                }
                pre += "&";
            }

            // The resolve names parameter I believe will do additional ldap/AD queries to figure out more info about the trustee?
            if(ResolveNames)
            {
                Parameters += pre + "resolve_names=true";
                pre += "&";
            }

            if(Descending)
            {
                // The default is ascending, so only if the user specifies descending do i need to do anything
                Parameters += pre + "dir=DESC";
                pre += "&";
            }

            if(Limit != -1)
            {
                Parameters += pre + "limit=" + Limit.ToString();
            }

            // todo - resume

            RequestResult result = RunResult("/platform/1/protocols/smb/shares" + Parameters, typeof(SharesResponse));
            return ((SharesResponse)result.Content).Shares;
        }

        public void CreateShare(string name, string path)
        {
            throw new Exception("CreateShare not yet functioning.");

            Share share = new Share();
            share.Name = name;
            share.Path = path;

            RequestResult result = RunResult("/platform/1/protocols/smb/shares/", "POST", share, typeof(Share));
        }

        public void ModifyShare(Share share)
        {
            throw new Exception("todo");
        }

        public void DeleteShare(string ShareName)
        {
            RequestResult result = RunResult("/platform/1/protocols/smb/shares/" + ShareName, "DELETE");
        }
    }
}
