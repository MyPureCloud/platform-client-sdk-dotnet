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
    /// MatchShiftTradeJobRequest
    /// </summary>
    [DataContract]
    public partial class MatchShiftTradeJobRequest :  IEquatable<MatchShiftTradeJobRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchShiftTradeJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MatchShiftTradeJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchShiftTradeJobRequest" /> class.
        /// </summary>
        /// <param name="WeekDate">The start week date of the initiating shift in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="ReceivingSchedule">Associated schedule information for the receiving user (required).</param>
        /// <param name="ReceivingShiftId">The ID of the shift the receiving user is giving up in trade, if applicable.</param>
        /// <param name="Metadata">Version metadata for the shift trade (required).</param>
        public MatchShiftTradeJobRequest(String WeekDate = null, ReceivingScheduleLookup ReceivingSchedule = null, string ReceivingShiftId = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.WeekDate = WeekDate;
            this.ReceivingSchedule = ReceivingSchedule;
            this.ReceivingShiftId = ReceivingShiftId;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The start week date of the initiating shift in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The start week date of the initiating shift in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public String WeekDate { get; set; }



        /// <summary>
        /// Associated schedule information for the receiving user
        /// </summary>
        /// <value>Associated schedule information for the receiving user</value>
        [DataMember(Name="receivingSchedule", EmitDefaultValue=false)]
        public ReceivingScheduleLookup ReceivingSchedule { get; set; }



        /// <summary>
        /// The ID of the shift the receiving user is giving up in trade, if applicable
        /// </summary>
        /// <value>The ID of the shift the receiving user is giving up in trade, if applicable</value>
        [DataMember(Name="receivingShiftId", EmitDefaultValue=false)]
        public string ReceivingShiftId { get; set; }



        /// <summary>
        /// Version metadata for the shift trade
        /// </summary>
        /// <value>Version metadata for the shift trade</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchShiftTradeJobRequest {\n");

            sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
            sb.Append("  ReceivingSchedule: ").Append(ReceivingSchedule).Append("\n");
            sb.Append("  ReceivingShiftId: ").Append(ReceivingShiftId).Append("\n");
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
            return this.Equals(obj as MatchShiftTradeJobRequest);
        }

        /// <summary>
        /// Returns true if MatchShiftTradeJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of MatchShiftTradeJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchShiftTradeJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WeekDate == other.WeekDate ||
                    this.WeekDate != null &&
                    this.WeekDate.Equals(other.WeekDate)
                ) &&
                (
                    this.ReceivingSchedule == other.ReceivingSchedule ||
                    this.ReceivingSchedule != null &&
                    this.ReceivingSchedule.Equals(other.ReceivingSchedule)
                ) &&
                (
                    this.ReceivingShiftId == other.ReceivingShiftId ||
                    this.ReceivingShiftId != null &&
                    this.ReceivingShiftId.Equals(other.ReceivingShiftId)
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
                if (this.WeekDate != null)
                    hash = hash * 59 + this.WeekDate.GetHashCode();

                if (this.ReceivingSchedule != null)
                    hash = hash * 59 + this.ReceivingSchedule.GetHashCode();

                if (this.ReceivingShiftId != null)
                    hash = hash * 59 + this.ReceivingShiftId.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
