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
    /// WorkitemQueryJobQueryFiltersCriteria
    /// </summary>
    [DataContract]
    public partial class WorkitemQueryJobQueryFiltersCriteria :  IEquatable<WorkitemQueryJobQueryFiltersCriteria>
    {
        /// <summary>
        /// Query filter logical operator to join predicates.
        /// </summary>
        /// <value>Query filter logical operator to join predicates.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum And for "AND"
            /// </summary>
            [EnumMember(Value = "AND")]
            And,
            
            /// <summary>
            /// Enum Or for "OR"
            /// </summary>
            [EnumMember(Value = "OR")]
            Or
        }
        /// <summary>
        /// Query filter logical operator to join predicates.
        /// </summary>
        /// <value>Query filter logical operator to join predicates.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemQueryJobQueryFiltersCriteria" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkitemQueryJobQueryFiltersCriteria() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemQueryJobQueryFiltersCriteria" /> class.
        /// </summary>
        /// <param name="Operator">Query filter logical operator to join predicates..</param>
        /// <param name="Predicates">Query filter predicate. (required).</param>
        public WorkitemQueryJobQueryFiltersCriteria(OperatorEnum? Operator = null, List<WorkitemQueryJobQueryFiltersPredicate> Predicates = null)
        {
            this.Operator = Operator;
            this.Predicates = Predicates;
            
        }
        




        /// <summary>
        /// Query filter predicate.
        /// </summary>
        /// <value>Query filter predicate.</value>
        [DataMember(Name="predicates", EmitDefaultValue=false)]
        public List<WorkitemQueryJobQueryFiltersPredicate> Predicates { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemQueryJobQueryFiltersCriteria {\n");

            sb.Append("  Operator: ").Append(Operator).Append("\n");
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
            return this.Equals(obj as WorkitemQueryJobQueryFiltersCriteria);
        }

        /// <summary>
        /// Returns true if WorkitemQueryJobQueryFiltersCriteria instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkitemQueryJobQueryFiltersCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkitemQueryJobQueryFiltersCriteria other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
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
                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Predicates != null)
                    hash = hash * 59 + this.Predicates.GetHashCode();

                return hash;
            }
        }
    }

}
