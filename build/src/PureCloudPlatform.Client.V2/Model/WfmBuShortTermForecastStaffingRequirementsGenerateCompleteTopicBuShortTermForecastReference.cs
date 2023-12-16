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
    /// WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference
    /// </summary>
    [DataContract]
    public partial class WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference :  IEquatable<WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="WeekDate">WeekDate.</param>
        /// <param name="Description">Description.</param>
        public WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference(string Id = null, string WeekDate = null, string Description = null)
        {
            this.Id = Id;
            this.WeekDate = WeekDate;
            this.Description = Description;
            
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
        public string WeekDate { get; set; }



        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference);
        }

        /// <summary>
        /// Returns true if WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmBuShortTermForecastStaffingRequirementsGenerateCompleteTopicBuShortTermForecastReference other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                return hash;
            }
        }
    }

}
