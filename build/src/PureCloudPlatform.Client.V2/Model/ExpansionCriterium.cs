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
    /// ExpansionCriterium
    /// </summary>
    [DataContract]
    public partial class ExpansionCriterium :  IEquatable<ExpansionCriterium>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Seconds for "TIMEOUT_SECONDS"
            /// </summary>
            [EnumMember(Value = "TIMEOUT_SECONDS")]
            Seconds
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpansionCriterium" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Threshold">Threshold.</param>
        public ExpansionCriterium(TypeEnum? Type = null, double? Threshold = null)
        {
            this.Type = Type;
            this.Threshold = Threshold;
        }
        
        /// <summary>
        /// Gets or Sets Threshold
        /// </summary>
        [DataMember(Name="threshold", EmitDefaultValue=false)]
        public double? Threshold { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpansionCriterium {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ExpansionCriterium);
        }

        /// <summary>
        /// Returns true if ExpansionCriterium instances are equal
        /// </summary>
        /// <param name="other">Instance of ExpansionCriterium to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpansionCriterium other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Threshold == other.Threshold ||
                    this.Threshold != null &&
                    this.Threshold.Equals(other.Threshold)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Threshold != null)
                    hash = hash * 59 + this.Threshold.GetHashCode();
                return hash;
            }
        }
    }

}
