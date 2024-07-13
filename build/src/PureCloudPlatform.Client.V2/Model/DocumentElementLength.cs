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
    /// DocumentElementLength
    /// </summary>
    [DataContract]
    public partial class DocumentElementLength :  IEquatable<DocumentElementLength>
    {
        /// <summary>
        /// The unit of length.
        /// </summary>
        /// <value>The unit of length.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UnitEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Em for "Em"
            /// </summary>
            [EnumMember(Value = "Em")]
            Em,
            
            /// <summary>
            /// Enum Percentage for "Percentage"
            /// </summary>
            [EnumMember(Value = "Percentage")]
            Percentage,
            
            /// <summary>
            /// Enum Px for "Px"
            /// </summary>
            [EnumMember(Value = "Px")]
            Px
        }
        /// <summary>
        /// The unit of length.
        /// </summary>
        /// <value>The unit of length.</value>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public UnitEnum? Unit { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentElementLength" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentElementLength() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentElementLength" /> class.
        /// </summary>
        /// <param name="Value">The length value of the element in the selected unit. (required).</param>
        /// <param name="Unit">The unit of length. (required).</param>
        public DocumentElementLength(float? Value = null, UnitEnum? Unit = null)
        {
            this.Value = Value;
            this.Unit = Unit;
            
        }
        


        /// <summary>
        /// The length value of the element in the selected unit.
        /// </summary>
        /// <value>The length value of the element in the selected unit.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public float? Value { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentElementLength {\n");

            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(obj as DocumentElementLength);
        }

        /// <summary>
        /// Returns true if DocumentElementLength instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentElementLength to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentElementLength other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Unit == other.Unit ||
                    this.Unit != null &&
                    this.Unit.Equals(other.Unit)
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
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Unit != null)
                    hash = hash * 59 + this.Unit.GetHashCode();

                return hash;
            }
        }
    }

}
