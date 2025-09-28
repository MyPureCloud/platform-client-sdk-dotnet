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
    /// RowSearchPredicate
    /// </summary>
    [DataContract]
    public partial class RowSearchPredicate :  IEquatable<RowSearchPredicate>
    {
        /// <summary>
        /// The search operator for this predicate
        /// </summary>
        /// <value>The search operator for this predicate</value>
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
            /// Enum Equals for "Equals"
            /// </summary>
            [EnumMember(Value = "Equals")]
            Equals,
            
            /// <summary>
            /// Enum Startswith for "StartsWith"
            /// </summary>
            [EnumMember(Value = "StartsWith")]
            Startswith,
            
            /// <summary>
            /// Enum Greaterthan for "GreaterThan"
            /// </summary>
            [EnumMember(Value = "GreaterThan")]
            Greaterthan,
            
            /// <summary>
            /// Enum Greaterthanorequals for "GreaterThanOrEquals"
            /// </summary>
            [EnumMember(Value = "GreaterThanOrEquals")]
            Greaterthanorequals,
            
            /// <summary>
            /// Enum Lessthan for "LessThan"
            /// </summary>
            [EnumMember(Value = "LessThan")]
            Lessthan,
            
            /// <summary>
            /// Enum Lessthanorequals for "LessThanOrEquals"
            /// </summary>
            [EnumMember(Value = "LessThanOrEquals")]
            Lessthanorequals,
            
            /// <summary>
            /// Enum Containsitem for "ContainsItem"
            /// </summary>
            [EnumMember(Value = "ContainsItem")]
            Containsitem
        }
        /// <summary>
        /// The special value that will be searched for in rows. Exactly one of 'value' or 'special' can be used.
        /// </summary>
        /// <value>The special value that will be searched for in rows. Exactly one of 'value' or 'special' can be used.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SpecialEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Wildcard for "Wildcard"
            /// </summary>
            [EnumMember(Value = "Wildcard")]
            Wildcard,
            
            /// <summary>
            /// Enum Null for "Null"
            /// </summary>
            [EnumMember(Value = "Null")]
            Null,
            
            /// <summary>
            /// Enum Empty for "Empty"
            /// </summary>
            [EnumMember(Value = "Empty")]
            Empty,
            
            /// <summary>
            /// Enum Currenttime for "CurrentTime"
            /// </summary>
            [EnumMember(Value = "CurrentTime")]
            Currenttime
        }
        /// <summary>
        /// The search operator for this predicate
        /// </summary>
        /// <value>The search operator for this predicate</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// The special value that will be searched for in rows. Exactly one of 'value' or 'special' can be used.
        /// </summary>
        /// <value>The special value that will be searched for in rows. Exactly one of 'value' or 'special' can be used.</value>
        [DataMember(Name="special", EmitDefaultValue=false)]
        public SpecialEnum? Special { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RowSearchPredicate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RowSearchPredicate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RowSearchPredicate" /> class.
        /// </summary>
        /// <param name="ColumnId">The decision table column identifier this predicate applies to (required).</param>
        /// <param name="Operator">The search operator for this predicate (required).</param>
        /// <param name="Value">The value that will be searched for in rows. Exactly one of &#39;value&#39; or &#39;special&#39; can be used..</param>
        /// <param name="Special">The special value that will be searched for in rows. Exactly one of &#39;value&#39; or &#39;special&#39; can be used..</param>
        public RowSearchPredicate(string ColumnId = null, OperatorEnum? Operator = null, string Value = null, SpecialEnum? Special = null)
        {
            this.ColumnId = ColumnId;
            this.Operator = Operator;
            this.Value = Value;
            this.Special = Special;
            
        }
        


        /// <summary>
        /// The decision table column identifier this predicate applies to
        /// </summary>
        /// <value>The decision table column identifier this predicate applies to</value>
        [DataMember(Name="columnId", EmitDefaultValue=false)]
        public string ColumnId { get; set; }





        /// <summary>
        /// The value that will be searched for in rows. Exactly one of &#39;value&#39; or &#39;special&#39; can be used.
        /// </summary>
        /// <value>The value that will be searched for in rows. Exactly one of &#39;value&#39; or &#39;special&#39; can be used.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RowSearchPredicate {\n");

            sb.Append("  ColumnId: ").Append(ColumnId).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Special: ").Append(Special).Append("\n");
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
            return this.Equals(obj as RowSearchPredicate);
        }

        /// <summary>
        /// Returns true if RowSearchPredicate instances are equal
        /// </summary>
        /// <param name="other">Instance of RowSearchPredicate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RowSearchPredicate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ColumnId == other.ColumnId ||
                    this.ColumnId != null &&
                    this.ColumnId.Equals(other.ColumnId)
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
                ) &&
                (
                    this.Special == other.Special ||
                    this.Special != null &&
                    this.Special.Equals(other.Special)
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
                if (this.ColumnId != null)
                    hash = hash * 59 + this.ColumnId.GetHashCode();

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Special != null)
                    hash = hash * 59 + this.Special.GetHashCode();

                return hash;
            }
        }
    }

}
