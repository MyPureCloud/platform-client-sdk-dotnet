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
    /// ShiftTradeWeekSummaryResponseItem
    /// </summary>
    [DataContract]
    public partial class ShiftTradeWeekSummaryResponseItem :  IEquatable<ShiftTradeWeekSummaryResponseItem>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradeWeekSummaryResponseItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShiftTradeWeekSummaryResponseItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradeWeekSummaryResponseItem" /> class.
        /// </summary>
        /// <param name="WeekDate">The schedule week date in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="InitiatingMatchedCount">The number of trades in the &#39;Matched&#39; state with the initiating shift in the given week (required).</param>
        /// <param name="CrossWeekReceivingMatchedCount">The number of cross-week trades in the &#39;Matched&#39; state with the receiving shift for the given week (required).</param>
        public ShiftTradeWeekSummaryResponseItem(String WeekDate = null, int? InitiatingMatchedCount = null, int? CrossWeekReceivingMatchedCount = null)
        {
            this.WeekDate = WeekDate;
            this.InitiatingMatchedCount = InitiatingMatchedCount;
            this.CrossWeekReceivingMatchedCount = CrossWeekReceivingMatchedCount;
            
        }
        


        /// <summary>
        /// The schedule week date in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The schedule week date in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public String WeekDate { get; set; }



        /// <summary>
        /// The number of trades in the &#39;Matched&#39; state with the initiating shift in the given week
        /// </summary>
        /// <value>The number of trades in the &#39;Matched&#39; state with the initiating shift in the given week</value>
        [DataMember(Name="initiatingMatchedCount", EmitDefaultValue=false)]
        public int? InitiatingMatchedCount { get; set; }



        /// <summary>
        /// The number of cross-week trades in the &#39;Matched&#39; state with the receiving shift for the given week
        /// </summary>
        /// <value>The number of cross-week trades in the &#39;Matched&#39; state with the receiving shift for the given week</value>
        [DataMember(Name="crossWeekReceivingMatchedCount", EmitDefaultValue=false)]
        public int? CrossWeekReceivingMatchedCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShiftTradeWeekSummaryResponseItem {\n");

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
            return this.Equals(obj as ShiftTradeWeekSummaryResponseItem);
        }

        /// <summary>
        /// Returns true if ShiftTradeWeekSummaryResponseItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ShiftTradeWeekSummaryResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShiftTradeWeekSummaryResponseItem other)
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
