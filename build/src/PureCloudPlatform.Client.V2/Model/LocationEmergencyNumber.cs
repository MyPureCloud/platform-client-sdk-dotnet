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
    /// LocationEmergencyNumber
    /// </summary>
    [DataContract]
    public partial class LocationEmergencyNumber :  IEquatable<LocationEmergencyNumber>
    {
        /// <summary>
        /// The type of emergency number.
        /// </summary>
        /// <value>The type of emergency number.</value>
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
            /// Enum Default for "default"
            /// </summary>
            [EnumMember(Value = "default")]
            Default,
            
            /// <summary>
            /// Enum Elin for "elin"
            /// </summary>
            [EnumMember(Value = "elin")]
            Elin
        }
        /// <summary>
        /// The type of emergency number.
        /// </summary>
        /// <value>The type of emergency number.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationEmergencyNumber" /> class.
        /// </summary>
        /// <param name="E164">E164.</param>
        /// <param name="Number">Number.</param>
        /// <param name="Type">The type of emergency number..</param>
        public LocationEmergencyNumber(string E164 = null, string Number = null, TypeEnum? Type = null)
        {
            this.E164 = E164;
            this.Number = Number;
            this.Type = Type;
            
        }
        


        /// <summary>
        /// Gets or Sets E164
        /// </summary>
        [DataMember(Name="e164", EmitDefaultValue=false)]
        public string E164 { get; set; }



        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationEmergencyNumber {\n");

            sb.Append("  E164: ").Append(E164).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as LocationEmergencyNumber);
        }

        /// <summary>
        /// Returns true if LocationEmergencyNumber instances are equal
        /// </summary>
        /// <param name="other">Instance of LocationEmergencyNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationEmergencyNumber other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.E164 == other.E164 ||
                    this.E164 != null &&
                    this.E164.Equals(other.E164)
                ) &&
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.E164 != null)
                    hash = hash * 59 + this.E164.GetHashCode();

                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                return hash;
            }
        }
    }

}
