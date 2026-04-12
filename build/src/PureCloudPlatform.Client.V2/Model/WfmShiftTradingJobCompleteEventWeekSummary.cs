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
    /// WfmShiftTradingJobCompleteEventWeekSummary
    /// </summary>
    [DataContract]
    public partial class WfmShiftTradingJobCompleteEventWeekSummary :  IEquatable<WfmShiftTradingJobCompleteEventWeekSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmShiftTradingJobCompleteEventWeekSummary" /> class.
        /// </summary>
        /// <param name="WeekDate">WeekDate.</param>
        /// <param name="InitiatingMatchedCount">InitiatingMatchedCount.</param>
        /// <param name="CrossWeekReceivingMatchedCount">CrossWeekReceivingMatchedCount.</param>
        public WfmShiftTradingJobCompleteEventWeekSummary(string WeekDate = null, long? InitiatingMatchedCount = null, long? CrossWeekReceivingMatchedCount = null)
        {
            this.WeekDate = WeekDate;
            this.InitiatingMatchedCount = InitiatingMatchedCount;
            this.CrossWeekReceivingMatchedCount = CrossWeekReceivingMatchedCount;
            
        }
        


        /// <summary>
        /// Gets or Sets WeekDate
        /// </summary>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public string WeekDate { get; set; }



        /// <summary>
        /// Gets or Sets InitiatingMatchedCount
        /// </summary>
        [DataMember(Name="initiatingMatchedCount", EmitDefaultValue=false)]
        public long? InitiatingMatchedCount { get; set; }



        /// <summary>
        /// Gets or Sets CrossWeekReceivingMatchedCount
        /// </summary>
        [DataMember(Name="crossWeekReceivingMatchedCount", EmitDefaultValue=false)]
        public long? CrossWeekReceivingMatchedCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmShiftTradingJobCompleteEventWeekSummary {\n");

            sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
            sb.Append("  InitiatingMatchedCount: ").Append(InitiatingMatchedCount).Append("\n");
            sb.Append("  CrossWeekReceivingMatchedCount: ").Append(CrossWeekReceivingMatchedCount).Append("\n");
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
            return this.Equals(obj as WfmShiftTradingJobCompleteEventWeekSummary);
        }

        /// <summary>
        /// Returns true if WfmShiftTradingJobCompleteEventWeekSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmShiftTradingJobCompleteEventWeekSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmShiftTradingJobCompleteEventWeekSummary other)
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
                    this.InitiatingMatchedCount == other.InitiatingMatchedCount ||
                    this.InitiatingMatchedCount != null &&
                    this.InitiatingMatchedCount.Equals(other.InitiatingMatchedCount)
                ) &&
                (
                    this.CrossWeekReceivingMatchedCount == other.CrossWeekReceivingMatchedCount ||
                    this.CrossWeekReceivingMatchedCount != null &&
                    this.CrossWeekReceivingMatchedCount.Equals(other.CrossWeekReceivingMatchedCount)
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

                if (this.InitiatingMatchedCount != null)
                    hash = hash * 59 + this.InitiatingMatchedCount.GetHashCode();

                if (this.CrossWeekReceivingMatchedCount != null)
                    hash = hash * 59 + this.CrossWeekReceivingMatchedCount.GetHashCode();

                return hash;
            }
        }
    }

}
