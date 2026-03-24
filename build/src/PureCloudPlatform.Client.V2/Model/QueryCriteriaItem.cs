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
    /// A singular item used to query libraries
    /// </summary>
    [DataContract]
    public partial class QueryCriteriaItem :  IEquatable<QueryCriteriaItem>
    {
        /// <summary>
        /// The key to filter on
        /// </summary>
        /// <value>The key to filter on</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum KeyEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Name for "Name"
            /// </summary>
            [EnumMember(Value = "Name")]
            Name,
            
            /// <summary>
            /// Enum Divisionid for "DivisionId"
            /// </summary>
            [EnumMember(Value = "DivisionId")]
            Divisionid,
            
            /// <summary>
            /// Enum Id for "Id"
            /// </summary>
            [EnumMember(Value = "Id")]
            Id,
            
            /// <summary>
            /// Enum Createdby for "CreatedBy"
            /// </summary>
            [EnumMember(Value = "CreatedBy")]
            Createdby
        }
        /// <summary>
        /// The operator for comparison
        /// </summary>
        /// <value>The operator for comparison</value>
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
            /// Enum In for "IN"
            /// </summary>
            [EnumMember(Value = "IN")]
            In,
            
            /// <summary>
            /// Enum Equals for "EQUALS"
            /// </summary>
            [EnumMember(Value = "EQUALS")]
            Equals,
            
            /// <summary>
            /// Enum Notequals for "NOTEQUALS"
            /// </summary>
            [EnumMember(Value = "NOTEQUALS")]
            Notequals,
            
            /// <summary>
            /// Enum BeginsWith for "BEGINS_WITH"
            /// </summary>
            [EnumMember(Value = "BEGINS_WITH")]
            BeginsWith,
            
            /// <summary>
            /// Enum EndsWith for "ENDS_WITH"
            /// </summary>
            [EnumMember(Value = "ENDS_WITH")]
            EndsWith,
            
            /// <summary>
            /// Enum Contains for "CONTAINS"
            /// </summary>
            [EnumMember(Value = "CONTAINS")]
            Contains
        }
        /// <summary>
        /// The key to filter on
        /// </summary>
        /// <value>The key to filter on</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public KeyEnum? Key { get; set; }
        /// <summary>
        /// The operator for comparison
        /// </summary>
        /// <value>The operator for comparison</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryCriteriaItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryCriteriaItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryCriteriaItem" /> class.
        /// </summary>
        /// <param name="Key">The key to filter on (required).</param>
        /// <param name="Operator">The operator for comparison (required).</param>
        /// <param name="Value">The target value to match.</param>
        public QueryCriteriaItem(KeyEnum? Key = null, OperatorEnum? Operator = null, string Value = null)
        {
            this.Key = Key;
            this.Operator = Operator;
            this.Value = Value;
            
        }
        






        /// <summary>
        /// The target value to match
        /// </summary>
        /// <value>The target value to match</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryCriteriaItem {\n");

            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
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
            return this.Equals(obj as QueryCriteriaItem);
        }

        /// <summary>
        /// Returns true if QueryCriteriaItem instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryCriteriaItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryCriteriaItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
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
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
