using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsilonAPI.Models.SmartQuotas;

namespace IsilonAPI.Requests
{
    public class SmartQuotas : Core
    {
        public SmartQuotas(IsilonService service)
            : base(service)
        {

        }

        public string GetQuotaSummary()
        {
            return Get<string>("/platform/1/quota/quotas-summary");
        }

        public string GetQuotasRaw()
        {
            return Get<string>("/platform/1/quota/quotas");
        }

        public Quota[] GetQuotas()
        {
            QuotasResponse resp = Get<QuotasResponse>("/platform/1/quota/quotas");

            return resp.Quotas;
        }
    }
}
