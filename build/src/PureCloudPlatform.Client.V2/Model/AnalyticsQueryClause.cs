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
    /// AnalyticsQueryClause
    /// </summary>
    [DataContract]
    public partial class AnalyticsQueryClause :  IEquatable<AnalyticsQueryClause>
    {
        /// <summary>
        /// Boolean operation to apply to the provided predicates
        /// </summary>
        /// <value>Boolean operation to apply to the provided predicates</value>
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
            /// Enum And for "and"
            /// </summary>
            [EnumMember(Value = "and")]
            And,
            
            /// <summary>
            /// Enum Or for "or"
            /// </summary>
            [EnumMember(Value = "or")]
            Or
        }
        /// <summary>
        /// Boolean operation to apply to the provided predicates
        /// </summary>
        /// <value>Boolean operation to apply to the provided predicates</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryClause" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnalyticsQueryClause() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryClause" /> class.
        /// </summary>
        /// <param name="Type">Boolean operation to apply to the provided predicates (required).</param>
        /// <param name="Predicates">Like a three-word sentence: (attribute-name) (operator) (target-value). These can be one of three types: dimension, property, metric. (required).</param>
        public AnalyticsQueryClause(TypeEnum? Type = null, List<AnalyticsQueryPredicate> Predicates = null)
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for AnalyticsQueryClause and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "Predicates" is required (not null)
            if (Predicates == null)
            {
                throw new InvalidDataException("Predicates is a required property for AnalyticsQueryClause and cannot be null");
            }
            else
            {
                this.Predicates = Predicates;
            }
        }
        
        /// <summary>
        /// Like a three-word sentence: (attribute-name) (operator) (target-value). These can be one of three types: dimension, property, metric.
        /// </summary>
        /// <value>Like a three-word sentence: (attribute-name) (operator) (target-value). These can be one of three types: dimension, property, metric.</value>
        [DataMember(Name="predicates", EmitDefaultValue=false)]
        public List<AnalyticsQueryPredicate> Predicates { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsQueryClause {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Predicates: ").Append(Predicates).Append("\n");
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
            return this.Equals(obj as AnalyticsQueryClause);
        }

        /// <summary>
        /// Returns true if AnalyticsQueryClause instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsQueryClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsQueryClause other)
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
                    this.Predicates == other.Predicates ||
                    this.Predicates != null &&
                    this.Predicates.SequenceEqual(other.Predicates)
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
                if (this.Predicates != null)
                    hash = hash * 59 + this.Predicates.GetHashCode();
                return hash;
            }
        }
    }

}
