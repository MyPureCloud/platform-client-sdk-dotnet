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
    /// WfmBuScheduleTopicBuScheduleMetadata
    /// </summary>
    [DataContract]
    public partial class WfmBuScheduleTopicBuScheduleMetadata :  IEquatable<WfmBuScheduleTopicBuScheduleMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmBuScheduleTopicBuScheduleMetadata" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="WeekDate">WeekDate.</param>
        /// <param name="WeekCount">WeekCount.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Published">Published.</param>
        /// <param name="ShortTermForecast">ShortTermForecast.</param>
        /// <param name="ManagementUnits">ManagementUnits.</param>
        /// <param name="GenerationResults">GenerationResults.</param>
        /// <param name="Metadata">Metadata.</param>
        public WfmBuScheduleTopicBuScheduleMetadata(string Id = null, DateTime? WeekDate = null, int? WeekCount = null, string Description = null, bool? Published = null, WfmBuScheduleTopicBuShortTermForecastReference ShortTermForecast = null, List<WfmBuScheduleTopicBuManagementUnitScheduleSummary> ManagementUnits = null, WfmBuScheduleTopicBuScheduleGenerationResultSummary GenerationResults = null, WfmBuScheduleTopicWfmVersionedEntityMetadata Metadata = null)
        {
            this.Id = Id;
            this.WeekDate = WeekDate;
            this.WeekCount = WeekCount;
            this.Description = Description;
            this.Published = Published;
            this.ShortTermForecast = ShortTermForecast;
            this.ManagementUnits = ManagementUnits;
            this.GenerationResults = GenerationResults;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets WeekDate
        /// </summary>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public DateTime? WeekDate { get; set; }



        /// <summary>
        /// Gets or Sets WeekCount
        /// </summary>
        [DataMember(Name="weekCount", EmitDefaultValue=false)]
        public int? WeekCount { get; set; }



        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Gets or Sets Published
        /// </summary>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }



        /// <summary>
        /// Gets or Sets ShortTermForecast
        /// </summary>
        [DataMember(Name="shortTermForecast", EmitDefaultValue=false)]
        public WfmBuScheduleTopicBuShortTermForecastReference ShortTermForecast { get; set; }



        /// <summary>
        /// Gets or Sets ManagementUnits
        /// </summary>
        [DataMember(Name="managementUnits", EmitDefaultValue=false)]
        public List<WfmBuScheduleTopicBuManagementUnitScheduleSummary> ManagementUnits { get; set; }



        /// <summary>
        /// Gets or Sets GenerationResults
        /// </summary>
        [DataMember(Name="generationResults", EmitDefaultValue=false)]
        public WfmBuScheduleTopicBuScheduleGenerationResultSummary GenerationResults { get; set; }



        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmBuScheduleTopicWfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmBuScheduleTopicBuScheduleMetadata {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
            sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  ShortTermForecast: ").Append(ShortTermForecast).Append("\n");
            sb.Append("  ManagementUnits: ").Append(ManagementUnits).Append("\n");
            sb.Append("  GenerationResults: ").Append(GenerationResults).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as WfmBuScheduleTopicBuScheduleMetadata);
        }

        /// <summary>
        /// Returns true if WfmBuScheduleTopicBuScheduleMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmBuScheduleTopicBuScheduleMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmBuScheduleTopicBuScheduleMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.WeekDate == other.WeekDate ||
                    this.WeekDate != null &&
                    this.WeekDate.Equals(other.WeekDate)
                ) &&
                (
                    this.WeekCount == other.WeekCount ||
                    this.WeekCount != null &&
                    this.WeekCount.Equals(other.WeekCount)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) &&
                (
                    this.ShortTermForecast == other.ShortTermForecast ||
                    this.ShortTermForecast != null &&
                    this.ShortTermForecast.Equals(other.ShortTermForecast)
                ) &&
                (
                    this.ManagementUnits == other.ManagementUnits ||
                    this.ManagementUnits != null &&
                    this.ManagementUnits.SequenceEqual(other.ManagementUnits)
                ) &&
                (
                    this.GenerationResults == other.GenerationResults ||
                    this.GenerationResults != null &&
                    this.GenerationResults.Equals(other.GenerationResults)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.WeekDate != null)
                    hash = hash * 59 + this.WeekDate.GetHashCode();

                if (this.WeekCount != null)
                    hash = hash * 59 + this.WeekCount.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();

                if (this.ShortTermForecast != null)
                    hash = hash * 59 + this.ShortTermForecast.GetHashCode();

                if (this.ManagementUnits != null)
                    hash = hash * 59 + this.ManagementUnits.GetHashCode();

                if (this.GenerationResults != null)
                    hash = hash * 59 + this.GenerationResults.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
