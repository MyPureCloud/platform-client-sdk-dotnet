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
    /// WfmShifttradingAddTradeJobEventShiftTradeTarget
    /// </summary>
    [DataContract]
    public partial class WfmShifttradingAddTradeJobEventShiftTradeTarget :  IEquatable<WfmShifttradingAddTradeJobEventShiftTradeTarget>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmShifttradingAddTradeJobEventShiftTradeTarget" /> class.
        /// </summary>
        /// <param name="User">User.</param>
        public WfmShifttradingAddTradeJobEventShiftTradeTarget(WfmShifttradingAddTradeJobEventUserReference User = null)
        {
            this.User = User;
            
        }
        


        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public WfmShifttradingAddTradeJobEventUserReference User { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmShifttradingAddTradeJobEventShiftTradeTarget {\n");

            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as WfmShifttradingAddTradeJobEventShiftTradeTarget);
        }

        /// <summary>
        /// Returns true if WfmShifttradingAddTradeJobEventShiftTradeTarget instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmShifttradingAddTradeJobEventShiftTradeTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmShifttradingAddTradeJobEventShiftTradeTarget other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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

                return hash;
            }
        }
    }

}
