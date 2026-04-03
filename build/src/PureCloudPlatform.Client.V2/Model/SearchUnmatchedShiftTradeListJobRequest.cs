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
    /// SearchUnmatchedShiftTradeListJobRequest
    /// </summary>
    [DataContract]
    public partial class SearchUnmatchedShiftTradeListJobRequest :  IEquatable<SearchUnmatchedShiftTradeListJobRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchUnmatchedShiftTradeListJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchUnmatchedShiftTradeListJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchUnmatchedShiftTradeListJobRequest" /> class.
        /// </summary>
        /// <param name="ManagementUnitIds">The IDs of management units from which to query shift trades (required).</param>
        /// <param name="WeekDates">The start week dates in which to query shift trades in the business unit time zone (yyyy-MM-dd format) (required).</param>
        /// <param name="ReceivingSchedule">Associated schedule information for the receiving user (required).</param>
        /// <param name="ReceivingShiftIds">The IDs of shifts that the receiving user would potentially be willing to trade. If empty, only returns one-sided trades.</param>
        public SearchUnmatchedShiftTradeListJobRequest(List<string> ManagementUnitIds = null, List<String> WeekDates = null, ReceivingScheduleLookup ReceivingSchedule = null, List<string> ReceivingShiftIds = null)
        {
            this.ManagementUnitIds = ManagementUnitIds;
            this.WeekDates = WeekDates;
            this.ReceivingSchedule = ReceivingSchedule;
            this.ReceivingShiftIds = ReceivingShiftIds;
            
        }
        


        /// <summary>
        /// The IDs of management units from which to query shift trades
        /// </summary>
        /// <value>The IDs of management units from which to query shift trades</value>
        [DataMember(Name="managementUnitIds", EmitDefaultValue=false)]
        public List<string> ManagementUnitIds { get; set; }



        /// <summary>
        /// The start week dates in which to query shift trades in the business unit time zone (yyyy-MM-dd format)
        /// </summary>
        /// <value>The start week dates in which to query shift trades in the business unit time zone (yyyy-MM-dd format)</value>
        [DataMember(Name="weekDates", EmitDefaultValue=false)]
        public List<String> WeekDates { get; set; }



        /// <summary>
        /// Associated schedule information for the receiving user
        /// </summary>
        /// <value>Associated schedule information for the receiving user</value>
        [DataMember(Name="receivingSchedule", EmitDefaultValue=false)]
        public ReceivingScheduleLookup ReceivingSchedule { get; set; }



        /// <summary>
        /// The IDs of shifts that the receiving user would potentially be willing to trade. If empty, only returns one-sided trades
        /// </summary>
        /// <value>The IDs of shifts that the receiving user would potentially be willing to trade. If empty, only returns one-sided trades</value>
        [DataMember(Name="receivingShiftIds", EmitDefaultValue=false)]
        public List<string> ReceivingShiftIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchUnmatchedShiftTradeListJobRequest {\n");

            sb.Append("  ManagementUnitIds: ").Append(ManagementUnitIds).Append("\n");
            sb.Append("  WeekDates: ").Append(WeekDates).Append("\n");
            sb.Append("  ReceivingSchedule: ").Append(ReceivingSchedule).Append("\n");
            sb.Append("  ReceivingShiftIds: ").Append(ReceivingShiftIds).Append("\n");
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
            return this.Equals(obj as SearchUnmatchedShiftTradeListJobRequest);
        }

        /// <summary>
        /// Returns true if SearchUnmatchedShiftTradeListJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchUnmatchedShiftTradeListJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchUnmatchedShiftTradeListJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ManagementUnitIds == other.ManagementUnitIds ||
                    this.ManagementUnitIds != null &&
                    this.ManagementUnitIds.SequenceEqual(other.ManagementUnitIds)
                ) &&
                (
                    this.WeekDates == other.WeekDates ||
                    this.WeekDates != null &&
                    this.WeekDates.SequenceEqual(other.WeekDates)
                ) &&
                (
                    this.ReceivingSchedule == other.ReceivingSchedule ||
                    this.ReceivingSchedule != null &&
                    this.ReceivingSchedule.Equals(other.ReceivingSchedule)
                ) &&
                (
                    this.ReceivingShiftIds == other.ReceivingShiftIds ||
                    this.ReceivingShiftIds != null &&
                    this.ReceivingShiftIds.SequenceEqual(other.ReceivingShiftIds)
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
                if (this.ManagementUnitIds != null)
                    hash = hash * 59 + this.ManagementUnitIds.GetHashCode();

                if (this.WeekDates != null)
                    hash = hash * 59 + this.WeekDates.GetHashCode();

                if (this.ReceivingSchedule != null)
                    hash = hash * 59 + this.ReceivingSchedule.GetHashCode();

                if (this.ReceivingShiftIds != null)
                    hash = hash * 59 + this.ReceivingShiftIds.GetHashCode();

                return hash;
            }
        }
    }

}
