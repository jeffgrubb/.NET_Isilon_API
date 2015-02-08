using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsilonAPI.Models.ClusterStatistics;

namespace IsilonAPI.Requests
{
    public class ClusterStatistics : Core
    {
        public enum Scope
        {
            Node,
            Cluster
        }

        public ClusterStatistics(IsilonService service)
            : base(service)
        {

        }

        // 0 for local node, nodeID for other nodes in the cluster
        public Statistic GetNodeStatistic(string key, string nodeID = null)
        {
            string queryString = "/platform/1/statistics/keys?key=\"" + key + "\"";

            if (nodeID != null)
            {
                queryString += "?devid=" + nodeID;
            }

            Statistic stat = Get<Statistic>(queryString);

            return stat;
        }

        public Statistic GetClusterStatistic(string key)
        {
            string queryString = "/platform/1/statistics/keys?key=\"" + key + "\"&devid=all";

            Statistic stat = Get<Statistic>(queryString);

            return stat;
        }

        public string GetStatisticsKeysRaw()
        {
            return Get<string>("/platform/1/statistics/keys");
        }

        public List<string> GetStatisticsKeys()
        {
            StatisticsResults stat = Get<StatisticsResults>("/platform/1/statistics/keys");

            List<string> ret = new List<string>();

            foreach (StatisticsKeys s in stat.Statistics)
            {
                ret.Add(s.Key);
            }

            return ret;
        }

        public Protocol[] GetProtocols()
        {
            ProtocolsResults stat = Get<ProtocolsResults>("/platform/1/statistics/protocols");

            return stat.Protocols;
        }
    }
}
