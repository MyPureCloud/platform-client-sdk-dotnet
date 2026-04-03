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
    /// BulkUpdateShiftTradeListJobRequest
    /// </summary>
    [DataContract]
    public partial class BulkUpdateShiftTradeListJobRequest :  IEquatable<BulkUpdateShiftTradeListJobRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateShiftTradeListJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkUpdateShiftTradeListJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateShiftTradeListJobRequest" /> class.
        /// </summary>
        /// <param name="ManagementUnitIds">The IDs of the management units from which to update shift trades (required).</param>
        /// <param name="WeekDates">The start week dates in which the shift trades being updated occur in the business unit time zone (yyyy-MM-dd format) (required).</param>
        /// <param name="Entities">The shift trades that are being updated (required).</param>
        public BulkUpdateShiftTradeListJobRequest(List<string> ManagementUnitIds = null, List<String> WeekDates = null, List<BulkUpdateShiftTradeStateRequestItem> Entities = null)
        {
            this.ManagementUnitIds = ManagementUnitIds;
            this.WeekDates = WeekDates;
            this.Entities = Entities;
            
        }
        


        /// <summary>
        /// The IDs of the management units from which to update shift trades
        /// </summary>
        /// <value>The IDs of the management units from which to update shift trades</value>
        [DataMember(Name="managementUnitIds", EmitDefaultValue=false)]
        public List<string> ManagementUnitIds { get; set; }



        /// <summary>
        /// The start week dates in which the shift trades being updated occur in the business unit time zone (yyyy-MM-dd format)
        /// </summary>
        /// <value>The start week dates in which the shift trades being updated occur in the business unit time zone (yyyy-MM-dd format)</value>
        [DataMember(Name="weekDates", EmitDefaultValue=false)]
        public List<String> WeekDates { get; set; }



        /// <summary>
        /// The shift trades that are being updated
        /// </summary>
        /// <value>The shift trades that are being updated</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<BulkUpdateShiftTradeStateRequestItem> Entities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkUpdateShiftTradeListJobRequest {\n");

            sb.Append("  ManagementUnitIds: ").Append(ManagementUnitIds).Append("\n");
            sb.Append("  WeekDates: ").Append(WeekDates).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
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
            return this.Equals(obj as BulkUpdateShiftTradeListJobRequest);
        }

        /// <summary>
        /// Returns true if BulkUpdateShiftTradeListJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkUpdateShiftTradeListJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkUpdateShiftTradeListJobRequest other)
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
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
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

                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                return hash;
            }
        }
    }

}
