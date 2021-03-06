﻿using System;
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

        public SMB(IsilonService service)
            : base(service)
        {

        }

        public Share[] GetSMBShare(string ShareName)
        {
            SharesResponse result = Get<SharesResponse>("/platform/1/protocols/smb/shares/" + ShareName);
            return result.Shares;
        }

        public SharesSummary GetSMBSharesSummary()
        {
            SharesSummaryResponse result = Get<SharesSummaryResponse>("/platform/1/protocols/smb/shares-summary");
            return result.Summary;
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
                pre = "&";
            }

            // The resolve names parameter I believe will do additional ldap/AD queries to figure out more info about the trustee?
            if(ResolveNames)
            {
                Parameters += pre + "resolve_names=true";
                pre = "&";
            }

            if(Descending)
            {
                // The default is ascending, so only if the user specifies descending do i need to do anything
                Parameters += pre + "dir=DESC";
                pre = "&";
            }

            if(Limit != -1)
            {
                Parameters += pre + "limit=" + Limit.ToString();
            }

            // todo - resume

            SharesResponse result = Get<SharesResponse>("/platform/1/protocols/smb/shares" + Parameters);
            return result.Shares;
        }

        public Share CreateShare(string name, string path)
        {
            Share share = new Share();
            share.Name = name;
            share.Path = path;

            Post<Share>("/platform/1/protocols/smb/shares/", share);

            share = GetSMBShare(name)[0];

            return share;
        }

        public string GetIFS()
        {
            return Get<string>("/platform/1/protocols/smb/shares/TestCreate");
        }

        // move to share class?
        public void ModifyShare(Share share)
        {
            Put<Share>("platform/1/protocols/smb/shares", share);
        }

        public void DeleteShare(string ShareName)
        {
            Delete("/platform/1/protocols/smb/shares/" + ShareName);
        }
    }
}
