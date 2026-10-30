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
    /// WfmShifttradingUpdateTradeJobEventShiftTradeInterval
    /// </summary>
    [DataContract]
    public partial class WfmShifttradingUpdateTradeJobEventShiftTradeInterval :  IEquatable<WfmShifttradingUpdateTradeJobEventShiftTradeInterval>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmShifttradingUpdateTradeJobEventShiftTradeInterval" /> class.
        /// </summary>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="EndDate">EndDate.</param>
        public WfmShifttradingUpdateTradeJobEventShiftTradeInterval(DateTime? StartDate = null, DateTime? EndDate = null)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            
        }
        


        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmShifttradingUpdateTradeJobEventShiftTradeInterval {\n");

            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(obj as WfmShifttradingUpdateTradeJobEventShiftTradeInterval);
        }

        /// <summary>
        /// Returns true if WfmShifttradingUpdateTradeJobEventShiftTradeInterval instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmShifttradingUpdateTradeJobEventShiftTradeInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmShifttradingUpdateTradeJobEventShiftTradeInterval other)
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

                return hash;
            }
        }
    }

}
