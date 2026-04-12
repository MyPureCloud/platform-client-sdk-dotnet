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
    /// WfmShiftTradingJobCompleteEventTradeSide
    /// </summary>
    [DataContract]
    public partial class WfmShiftTradingJobCompleteEventTradeSide :  IEquatable<WfmShiftTradingJobCompleteEventTradeSide>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmShiftTradingJobCompleteEventTradeSide" /> class.
        /// </summary>
        /// <param name="UserId">UserId.</param>
        /// <param name="Shift">Shift.</param>
        public WfmShiftTradingJobCompleteEventTradeSide(string UserId = null, WfmShiftTradingJobCompleteEventTradeShift Shift = null)
        {
            this.UserId = UserId;
            this.Shift = Shift;
            
        }
        


        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// Gets or Sets Shift
        /// </summary>
        [DataMember(Name="shift", EmitDefaultValue=false)]
        public WfmShiftTradingJobCompleteEventTradeShift Shift { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmShiftTradingJobCompleteEventTradeSide {\n");

            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Shift: ").Append(Shift).Append("\n");
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
            return this.Equals(obj as WfmShiftTradingJobCompleteEventTradeSide);
        }

        /// <summary>
        /// Returns true if WfmShiftTradingJobCompleteEventTradeSide instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmShiftTradingJobCompleteEventTradeSide to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmShiftTradingJobCompleteEventTradeSide other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.Shift == other.Shift ||
                    this.Shift != null &&
                    this.Shift.Equals(other.Shift)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.Shift != null)
                    hash = hash * 59 + this.Shift.GetHashCode();

                return hash;
            }
        }
    }

}
