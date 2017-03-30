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
    /// AnalyticsProperty
    /// </summary>
    [DataContract]
    public partial class AnalyticsProperty :  IEquatable<AnalyticsProperty>
    {
        /// <summary>
        /// Indicates what the data type is (e.g. integer vs string) and therefore how to evaluate what would constitute a match
        /// </summary>
        /// <value>Indicates what the data type is (e.g. integer vs string) and therefore how to evaluate what would constitute a match</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PropertyTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Bool for "bool"
            /// </summary>
            [EnumMember(Value = "bool")]
            Bool,
            
            /// <summary>
            /// Enum Integer for "integer"
            /// </summary>
            [EnumMember(Value = "integer")]
            Integer,
            
            /// <summary>
            /// Enum Real for "real"
            /// </summary>
            [EnumMember(Value = "real")]
            Real,
            
            /// <summary>
            /// Enum Date for "date"
            /// </summary>
            [EnumMember(Value = "date")]
            Date,
            
            /// <summary>
            /// Enum String for "string"
            /// </summary>
            [EnumMember(Value = "string")]
            String,
            
            /// <summary>
            /// Enum Uuid for "uuid"
            /// </summary>
            [EnumMember(Value = "uuid")]
            Uuid
        }
        /// <summary>
        /// Indicates what the data type is (e.g. integer vs string) and therefore how to evaluate what would constitute a match
        /// </summary>
        /// <value>Indicates what the data type is (e.g. integer vs string) and therefore how to evaluate what would constitute a match</value>
        [DataMember(Name="propertyType", EmitDefaultValue=false)]
        public PropertyTypeEnum? PropertyType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsProperty" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnalyticsProperty() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsProperty" /> class.
        /// </summary>
        /// <param name="PropertyType">Indicates what the data type is (e.g. integer vs string) and therefore how to evaluate what would constitute a match (required).</param>
        /// <param name="Property">User-defined rather than intrinsic system-observed values. These are tagged onto segments by other components within PureCloud or by API users directly.  This is the name of the user-defined property. (required).</param>
        /// <param name="Value">What property value to match against (required).</param>
        public AnalyticsProperty(PropertyTypeEnum? PropertyType = null, string Property = null, string Value = null)
        {
            // to ensure "PropertyType" is required (not null)
            if (PropertyType == null)
            {
                throw new InvalidDataException("PropertyType is a required property for AnalyticsProperty and cannot be null");
            }
            else
            {
                this.PropertyType = PropertyType;
            }
            // to ensure "Property" is required (not null)
            if (Property == null)
            {
                throw new InvalidDataException("Property is a required property for AnalyticsProperty and cannot be null");
            }
            else
            {
                this.Property = Property;
            }
            // to ensure "Value" is required (not null)
            if (Value == null)
            {
                throw new InvalidDataException("Value is a required property for AnalyticsProperty and cannot be null");
            }
            else
            {
                this.Value = Value;
            }
        }
        
        /// <summary>
        /// User-defined rather than intrinsic system-observed values. These are tagged onto segments by other components within PureCloud or by API users directly.  This is the name of the user-defined property.
        /// </summary>
        /// <value>User-defined rather than intrinsic system-observed values. These are tagged onto segments by other components within PureCloud or by API users directly.  This is the name of the user-defined property.</value>
        [DataMember(Name="property", EmitDefaultValue=false)]
        public string Property { get; set; }
        /// <summary>
        /// What property value to match against
        /// </summary>
        /// <value>What property value to match against</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsProperty {\n");
            sb.Append("  PropertyType: ").Append(PropertyType).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as AnalyticsProperty);
        }

        /// <summary>
        /// Returns true if AnalyticsProperty instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsProperty other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PropertyType == other.PropertyType ||
                    this.PropertyType != null &&
                    this.PropertyType.Equals(other.PropertyType)
                ) &&
                (
                    this.Property == other.Property ||
                    this.Property != null &&
                    this.Property.Equals(other.Property)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.PropertyType != null)
                    hash = hash * 59 + this.PropertyType.GetHashCode();
                if (this.Property != null)
                    hash = hash * 59 + this.Property.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }
    }

}
