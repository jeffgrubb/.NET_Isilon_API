using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsilonAPI.Models.Deduplication;

namespace IsilonAPI.Requests
{
    public class Deduplication : Core
    {
        public Deduplication(string Username, string Password, string IsilonUrl, bool IgnoreInvalidCerts)
            : base(Username, Password, IsilonUrl, IgnoreInvalidCerts)
        {

        }

        public DeduplicationStats GetDeduplicationStats()
        {
            DeduplicationStatsResponse result = Get<DeduplicationStatsResponse>("/platform/1/dedupe/dedupe-summary");
            return result.Stats;
        }

        public DeduplicationSettings GetDeduplicationSettings()
        {
            DeduplicationSettingsResponse result = Get<DeduplicationSettingsResponse>("/platform/1/dedupe/settings");
            return result.Settings;
        }

        public void ModifyDeduplicationSettings(DeduplicationSettings settings)
        {
            Put<DeduplicationSettings>("/platform/1/dedupe/settings", settings);
        }

        public DeduplicationReports[] GetDeduplicationReports()
        {
            DeduplicationReportsResponse result = Get<DeduplicationReportsResponse>("/platform/1/dedupe/reports");
            return result.reports;
        }


        // Todo
        /*sort=<string> Order results by this field. The default value is id. begin=<integer> Return only those reports at or after the given time in seconds since UNIX Epoch. end=<integer> Return only those reports at or before the given time in seconds since UNIX Epoch. job_id=<integer> Return only those jobs with a specific identifier. job_type=[Dedupe|DedupeAssessment] Return only those jobs with the specified job type. dir=[ASC|DESC] Directions for the sort order are ascending (ASC) or descending (DESC). The default setting is ASC.
         System configuration API
         Deduplication overview     181
         limit=<integer> Return no more than this many results at one time (see resume). resume=<string> Continue returning results from previous request (cannot be used with other parameters). 
         */
    }
}
