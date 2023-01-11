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
    /// HistoricalShrinkageResult
    /// </summary>
    [DataContract]
    public partial class HistoricalShrinkageResult :  IEquatable<HistoricalShrinkageResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricalShrinkageResult" /> class.
        /// </summary>
        /// <param name="StartDate">Beginning of the date range that was queried, in ISO-8601 format.</param>
        /// <param name="EndDate">End of the date range that was queried, in ISO-8601 format. If it was not set, end date will be set to the queried time.</param>
        /// <param name="TotalScheduledDurationSeconds">Total duration in seconds for which agents in the management unit are scheduled.</param>
        /// <param name="TotalLoggedInDurationSeconds">Total duration in seconds for which agents in the management unit are actually logged-in.</param>
        /// <param name="AggregatedShrinkage">Aggregated shrinkage data for all the activity categories.</param>
        /// <param name="ShrinkageForActivityCategories">Shrinkage for activity categories.</param>
        /// <param name="BusinessUnitIds">List of all business units of all the agents in response.</param>
        public HistoricalShrinkageResult(DateTime? StartDate = null, DateTime? EndDate = null, int? TotalScheduledDurationSeconds = null, int? TotalLoggedInDurationSeconds = null, HistoricalShrinkageAggregateResponse AggregatedShrinkage = null, List<HistoricalShrinkageActivityCategoryResponse> ShrinkageForActivityCategories = null, List<string> BusinessUnitIds = null)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.TotalScheduledDurationSeconds = TotalScheduledDurationSeconds;
            this.TotalLoggedInDurationSeconds = TotalLoggedInDurationSeconds;
            this.AggregatedShrinkage = AggregatedShrinkage;
            this.ShrinkageForActivityCategories = ShrinkageForActivityCategories;
            this.BusinessUnitIds = BusinessUnitIds;
            
        }
        


        /// <summary>
        /// Beginning of the date range that was queried, in ISO-8601 format
        /// </summary>
        /// <value>Beginning of the date range that was queried, in ISO-8601 format</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// End of the date range that was queried, in ISO-8601 format. If it was not set, end date will be set to the queried time
        /// </summary>
        /// <value>End of the date range that was queried, in ISO-8601 format. If it was not set, end date will be set to the queried time</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }



        /// <summary>
        /// Total duration in seconds for which agents in the management unit are scheduled
        /// </summary>
        /// <value>Total duration in seconds for which agents in the management unit are scheduled</value>
        [DataMember(Name="totalScheduledDurationSeconds", EmitDefaultValue=false)]
        public int? TotalScheduledDurationSeconds { get; set; }



        /// <summary>
        /// Total duration in seconds for which agents in the management unit are actually logged-in
        /// </summary>
        /// <value>Total duration in seconds for which agents in the management unit are actually logged-in</value>
        [DataMember(Name="totalLoggedInDurationSeconds", EmitDefaultValue=false)]
        public int? TotalLoggedInDurationSeconds { get; set; }



        /// <summary>
        /// Aggregated shrinkage data for all the activity categories
        /// </summary>
        /// <value>Aggregated shrinkage data for all the activity categories</value>
        [DataMember(Name="aggregatedShrinkage", EmitDefaultValue=false)]
        public HistoricalShrinkageAggregateResponse AggregatedShrinkage { get; set; }



        /// <summary>
        /// Shrinkage for activity categories
        /// </summary>
        /// <value>Shrinkage for activity categories</value>
        [DataMember(Name="shrinkageForActivityCategories", EmitDefaultValue=false)]
        public List<HistoricalShrinkageActivityCategoryResponse> ShrinkageForActivityCategories { get; set; }



        /// <summary>
        /// List of all business units of all the agents in response
        /// </summary>
        /// <value>List of all business units of all the agents in response</value>
        [DataMember(Name="businessUnitIds", EmitDefaultValue=false)]
        public List<string> BusinessUnitIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricalShrinkageResult {\n");

            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  TotalScheduledDurationSeconds: ").Append(TotalScheduledDurationSeconds).Append("\n");
            sb.Append("  TotalLoggedInDurationSeconds: ").Append(TotalLoggedInDurationSeconds).Append("\n");
            sb.Append("  AggregatedShrinkage: ").Append(AggregatedShrinkage).Append("\n");
            sb.Append("  ShrinkageForActivityCategories: ").Append(ShrinkageForActivityCategories).Append("\n");
            sb.Append("  BusinessUnitIds: ").Append(BusinessUnitIds).Append("\n");
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
            return this.Equals(obj as HistoricalShrinkageResult);
        }

        /// <summary>
        /// Returns true if HistoricalShrinkageResult instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoricalShrinkageResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricalShrinkageResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) &&
                (
                    this.TotalScheduledDurationSeconds == other.TotalScheduledDurationSeconds ||
                    this.TotalScheduledDurationSeconds != null &&
                    this.TotalScheduledDurationSeconds.Equals(other.TotalScheduledDurationSeconds)
                ) &&
                (
                    this.TotalLoggedInDurationSeconds == other.TotalLoggedInDurationSeconds ||
                    this.TotalLoggedInDurationSeconds != null &&
                    this.TotalLoggedInDurationSeconds.Equals(other.TotalLoggedInDurationSeconds)
                ) &&
                (
                    this.AggregatedShrinkage == other.AggregatedShrinkage ||
                    this.AggregatedShrinkage != null &&
                    this.AggregatedShrinkage.Equals(other.AggregatedShrinkage)
                ) &&
                (
                    this.ShrinkageForActivityCategories == other.ShrinkageForActivityCategories ||
                    this.ShrinkageForActivityCategories != null &&
                    this.ShrinkageForActivityCategories.SequenceEqual(other.ShrinkageForActivityCategories)
                ) &&
                (
                    this.BusinessUnitIds == other.BusinessUnitIds ||
                    this.BusinessUnitIds != null &&
                    this.BusinessUnitIds.SequenceEqual(other.BusinessUnitIds)
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
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();

                if (this.TotalScheduledDurationSeconds != null)
                    hash = hash * 59 + this.TotalScheduledDurationSeconds.GetHashCode();

                if (this.TotalLoggedInDurationSeconds != null)
                    hash = hash * 59 + this.TotalLoggedInDurationSeconds.GetHashCode();

                if (this.AggregatedShrinkage != null)
                    hash = hash * 59 + this.AggregatedShrinkage.GetHashCode();

                if (this.ShrinkageForActivityCategories != null)
                    hash = hash * 59 + this.ShrinkageForActivityCategories.GetHashCode();

                if (this.BusinessUnitIds != null)
                    hash = hash * 59 + this.BusinessUnitIds.GetHashCode();

                return hash;
            }
        }
    }

}
