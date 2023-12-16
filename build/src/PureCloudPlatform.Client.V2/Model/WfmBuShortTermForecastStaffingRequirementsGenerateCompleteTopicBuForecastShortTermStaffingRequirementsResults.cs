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
    /// WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsResults
    /// </summary>
    [DataContract]
    public partial class WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsResults :  IEquatable<WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsResults>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsResults" /> class.
        /// </summary>
        /// <param name="WeekNumber">WeekNumber.</param>
        /// <param name="DownloadUrl">DownloadUrl.</param>
        /// <param name="DownloadUrlExpirationDate">DownloadUrlExpirationDate.</param>
        public WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsResults(int? WeekNumber = null, string DownloadUrl = null, DateTime? DownloadUrlExpirationDate = null)
        {
            this.WeekNumber = WeekNumber;
            this.DownloadUrl = DownloadUrl;
            this.DownloadUrlExpirationDate = DownloadUrlExpirationDate;
            
        }
        


        /// <summary>
        /// Gets or Sets WeekNumber
        /// </summary>
        [DataMember(Name="weekNumber", EmitDefaultValue=false)]
        public int? WeekNumber { get; set; }



        /// <summary>
        /// Gets or Sets DownloadUrl
        /// </summary>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }



        /// <summary>
        /// Gets or Sets DownloadUrlExpirationDate
        /// </summary>
        [DataMember(Name="downloadUrlExpirationDate", EmitDefaultValue=false)]
        public DateTime? DownloadUrlExpirationDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsResults {\n");

            sb.Append("  WeekNumber: ").Append(WeekNumber).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  DownloadUrlExpirationDate: ").Append(DownloadUrlExpirationDate).Append("\n");
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
            return this.Equals(obj as WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsResults);
        }

        /// <summary>
        /// Returns true if WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsResults instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuForecastShortTermStaffingRequirementsResults other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WeekNumber == other.WeekNumber ||
                    this.WeekNumber != null &&
                    this.WeekNumber.Equals(other.WeekNumber)
                ) &&
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
                ) &&
                (
                    this.DownloadUrlExpirationDate == other.DownloadUrlExpirationDate ||
                    this.DownloadUrlExpirationDate != null &&
                    this.DownloadUrlExpirationDate.Equals(other.DownloadUrlExpirationDate)
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
                if (this.WeekNumber != null)
                    hash = hash * 59 + this.WeekNumber.GetHashCode();

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                if (this.DownloadUrlExpirationDate != null)
                    hash = hash * 59 + this.DownloadUrlExpirationDate.GetHashCode();

                return hash;
            }
        }
    }

}
