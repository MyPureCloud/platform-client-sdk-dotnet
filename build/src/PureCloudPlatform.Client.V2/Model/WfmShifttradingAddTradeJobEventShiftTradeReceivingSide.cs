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
    /// WfmShifttradingAddTradeJobEventShiftTradeReceivingSide
    /// </summary>
    [DataContract]
    public partial class WfmShifttradingAddTradeJobEventShiftTradeReceivingSide :  IEquatable<WfmShifttradingAddTradeJobEventShiftTradeReceivingSide>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmShifttradingAddTradeJobEventShiftTradeReceivingSide" /> class.
        /// </summary>
        /// <param name="User">User.</param>
        /// <param name="Shift">Shift.</param>
        public WfmShifttradingAddTradeJobEventShiftTradeReceivingSide(WfmShifttradingAddTradeJobEventUserReference User = null, WfmShifttradingAddTradeJobEventShiftTradeShift Shift = null)
        {
            this.User = User;
            this.Shift = Shift;
            
        }
        


        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public WfmShifttradingAddTradeJobEventUserReference User { get; set; }



        /// <summary>
        /// Gets or Sets Shift
        /// </summary>
        [DataMember(Name="shift", EmitDefaultValue=false)]
        public WfmShifttradingAddTradeJobEventShiftTradeShift Shift { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmShifttradingAddTradeJobEventShiftTradeReceivingSide {\n");

            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as WfmShifttradingAddTradeJobEventShiftTradeReceivingSide);
        }

        /// <summary>
        /// Returns true if WfmShifttradingAddTradeJobEventShiftTradeReceivingSide instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmShifttradingAddTradeJobEventShiftTradeReceivingSide to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmShifttradingAddTradeJobEventShiftTradeReceivingSide other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Shift != null)
                    hash = hash * 59 + this.Shift.GetHashCode();

                return hash;
            }
        }
    }

}
