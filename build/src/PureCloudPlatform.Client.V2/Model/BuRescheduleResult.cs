using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// BuRescheduleResult
    /// </summary>
    [DataContract]
    public partial class BuRescheduleResult :  IEquatable<BuRescheduleResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuRescheduleResult" /> class.
        /// </summary>
        /// <param name="GenerationResults">The generation results.  Note the result will always be delivered via the downloadUrl; however the schema is included for documentation.</param>
        /// <param name="GenerationResultsDownloadUrl">The download URL from which to fetch the generation results for the rescheduling run.</param>
        /// <param name="HeadcountForecast">The headcount forecast.  Note the result will always be delivered via the downloadUrl; however the schema is included for documentation.</param>
        /// <param name="HeadcountForecastDownloadUrl">The download URL from which to fetch the headcount forecast for the rescheduling run.</param>
        /// <param name="AgentSchedules">List of download links for agent schedules produced by the rescheduling run.</param>
        public BuRescheduleResult(ScheduleGenerationResult GenerationResults = null, string GenerationResultsDownloadUrl = null, BuHeadcountForecast HeadcountForecast = null, string HeadcountForecastDownloadUrl = null, List<BuRescheduleAgentScheduleResult> AgentSchedules = null)
        {
            this.GenerationResults = GenerationResults;
            this.GenerationResultsDownloadUrl = GenerationResultsDownloadUrl;
            this.HeadcountForecast = HeadcountForecast;
            this.HeadcountForecastDownloadUrl = HeadcountForecastDownloadUrl;
            this.AgentSchedules = AgentSchedules;
            
        }
        


        /// <summary>
        /// The generation results.  Note the result will always be delivered via the downloadUrl; however the schema is included for documentation
        /// </summary>
        /// <value>The generation results.  Note the result will always be delivered via the downloadUrl; however the schema is included for documentation</value>
        [DataMember(Name="generationResults", EmitDefaultValue=false)]
        public ScheduleGenerationResult GenerationResults { get; set; }



        /// <summary>
        /// The download URL from which to fetch the generation results for the rescheduling run
        /// </summary>
        /// <value>The download URL from which to fetch the generation results for the rescheduling run</value>
        [DataMember(Name="generationResultsDownloadUrl", EmitDefaultValue=false)]
        public string GenerationResultsDownloadUrl { get; set; }



        /// <summary>
        /// The headcount forecast.  Note the result will always be delivered via the downloadUrl; however the schema is included for documentation
        /// </summary>
        /// <value>The headcount forecast.  Note the result will always be delivered via the downloadUrl; however the schema is included for documentation</value>
        [DataMember(Name="headcountForecast", EmitDefaultValue=false)]
        public BuHeadcountForecast HeadcountForecast { get; set; }



        /// <summary>
        /// The download URL from which to fetch the headcount forecast for the rescheduling run
        /// </summary>
        /// <value>The download URL from which to fetch the headcount forecast for the rescheduling run</value>
        [DataMember(Name="headcountForecastDownloadUrl", EmitDefaultValue=false)]
        public string HeadcountForecastDownloadUrl { get; set; }



        /// <summary>
        /// List of download links for agent schedules produced by the rescheduling run
        /// </summary>
        /// <value>List of download links for agent schedules produced by the rescheduling run</value>
        [DataMember(Name="agentSchedules", EmitDefaultValue=false)]
        public List<BuRescheduleAgentScheduleResult> AgentSchedules { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuRescheduleResult {\n");

            sb.Append("  GenerationResults: ").Append(GenerationResults).Append("\n");
            sb.Append("  GenerationResultsDownloadUrl: ").Append(GenerationResultsDownloadUrl).Append("\n");
            sb.Append("  HeadcountForecast: ").Append(HeadcountForecast).Append("\n");
            sb.Append("  HeadcountForecastDownloadUrl: ").Append(HeadcountForecastDownloadUrl).Append("\n");
            sb.Append("  AgentSchedules: ").Append(AgentSchedules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BuRescheduleResult);
        }

        /// <summary>
        /// Returns true if BuRescheduleResult instances are equal
        /// </summary>
        /// <param name="other">Instance of BuRescheduleResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuRescheduleResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.GenerationResults == other.GenerationResults ||
                    this.GenerationResults != null &&
                    this.GenerationResults.Equals(other.GenerationResults)
                ) &&
                (
                    this.GenerationResultsDownloadUrl == other.GenerationResultsDownloadUrl ||
                    this.GenerationResultsDownloadUrl != null &&
                    this.GenerationResultsDownloadUrl.Equals(other.GenerationResultsDownloadUrl)
                ) &&
                (
                    this.HeadcountForecast == other.HeadcountForecast ||
                    this.HeadcountForecast != null &&
                    this.HeadcountForecast.Equals(other.HeadcountForecast)
                ) &&
                (
                    this.HeadcountForecastDownloadUrl == other.HeadcountForecastDownloadUrl ||
                    this.HeadcountForecastDownloadUrl != null &&
                    this.HeadcountForecastDownloadUrl.Equals(other.HeadcountForecastDownloadUrl)
                ) &&
                (
                    this.AgentSchedules == other.AgentSchedules ||
                    this.AgentSchedules != null &&
                    this.AgentSchedules.SequenceEqual(other.AgentSchedules)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.GenerationResults != null)
                    hash = hash * 59 + this.GenerationResults.GetHashCode();

                if (this.GenerationResultsDownloadUrl != null)
                    hash = hash * 59 + this.GenerationResultsDownloadUrl.GetHashCode();

                if (this.HeadcountForecast != null)
                    hash = hash * 59 + this.HeadcountForecast.GetHashCode();

                if (this.HeadcountForecastDownloadUrl != null)
                    hash = hash * 59 + this.HeadcountForecastDownloadUrl.GetHashCode();

                if (this.AgentSchedules != null)
                    hash = hash * 59 + this.AgentSchedules.GetHashCode();

                return hash;
            }
        }
    }

}
