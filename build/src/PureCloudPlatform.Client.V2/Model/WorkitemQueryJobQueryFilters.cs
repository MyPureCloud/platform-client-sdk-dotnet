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
    /// WorkitemQueryJobQueryFilters
    /// </summary>
    [DataContract]
    public partial class WorkitemQueryJobQueryFilters :  IEquatable<WorkitemQueryJobQueryFilters>
    {
        /// <summary>
        /// Name of the attribute to filter.
        /// </summary>
        /// <value>Name of the attribute to filter.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NameEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Customfields for "customFields"
            /// </summary>
            [EnumMember(Value = "customFields")]
            Customfields
        }
        /// <summary>
        /// Query filter logical operator to join criteria.
        /// </summary>
        /// <value>Query filter logical operator to join criteria.</value>
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
        /// Name of the attribute to filter.
        /// </summary>
        /// <value>Name of the attribute to filter.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public NameEnum? Name { get; set; }
        /// <summary>
        /// Query filter logical operator to join criteria.
        /// </summary>
        /// <value>Query filter logical operator to join criteria.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemQueryJobQueryFilters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkitemQueryJobQueryFilters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemQueryJobQueryFilters" /> class.
        /// </summary>
        /// <param name="Name">Name of the attribute to filter. (required).</param>
        /// <param name="Operator">Query filter logical operator to join criteria..</param>
        /// <param name="Criteria">Query filter criteria. (required).</param>
        public WorkitemQueryJobQueryFilters(NameEnum? Name = null, OperatorEnum? Operator = null, List<WorkitemQueryJobQueryFiltersCriteria> Criteria = null)
        {
            this.Name = Name;
            this.Operator = Operator;
            this.Criteria = Criteria;
            
        }
        






        /// <summary>
        /// Query filter criteria.
        /// </summary>
        /// <value>Query filter criteria.</value>
        [DataMember(Name="criteria", EmitDefaultValue=false)]
        public List<WorkitemQueryJobQueryFiltersCriteria> Criteria { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemQueryJobQueryFilters {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
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
            return this.Equals(obj as WorkitemQueryJobQueryFilters);
        }

        /// <summary>
        /// Returns true if WorkitemQueryJobQueryFilters instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkitemQueryJobQueryFilters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkitemQueryJobQueryFilters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) &&
                (
                    this.Criteria == other.Criteria ||
                    this.Criteria != null &&
                    this.Criteria.SequenceEqual(other.Criteria)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Criteria != null)
                    hash = hash * 59 + this.Criteria.GetHashCode();

                return hash;
            }
        }
    }

}
