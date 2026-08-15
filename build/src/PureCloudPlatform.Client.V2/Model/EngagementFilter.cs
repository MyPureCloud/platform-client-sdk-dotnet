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
    /// EngagementFilter
    /// </summary>
    [DataContract]
    public partial class EngagementFilter :  IEquatable<EngagementFilter>
    {
        /// <summary>
        /// The comparison operator for engagement metric filtering.
        /// </summary>
        /// <value>The comparison operator for engagement metric filtering.</value>
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
            /// Enum Equalto for "EqualTo"
            /// </summary>
            [EnumMember(Value = "EqualTo")]
            Equalto,
            
            /// <summary>
            /// Enum Greaterthan for "GreaterThan"
            /// </summary>
            [EnumMember(Value = "GreaterThan")]
            Greaterthan,
            
            /// <summary>
            /// Enum Greaterthanorequalto for "GreaterThanOrEqualTo"
            /// </summary>
            [EnumMember(Value = "GreaterThanOrEqualTo")]
            Greaterthanorequalto,
            
            /// <summary>
            /// Enum Lessthan for "LessThan"
            /// </summary>
            [EnumMember(Value = "LessThan")]
            Lessthan,
            
            /// <summary>
            /// Enum Lessthanorequalto for "LessThanOrEqualTo"
            /// </summary>
            [EnumMember(Value = "LessThanOrEqualTo")]
            Lessthanorequalto,
            
            /// <summary>
            /// Enum Between for "Between"
            /// </summary>
            [EnumMember(Value = "Between")]
            Between
        }
        /// <summary>
        /// The comparison operator for engagement metric filtering.
        /// </summary>
        /// <value>The comparison operator for engagement metric filtering.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EngagementFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EngagementFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EngagementFilter" /> class.
        /// </summary>
        /// <param name="Operator">The comparison operator for engagement metric filtering. (required).</param>
        /// <param name="From">The inclusive lower bound of the engagement metric count. Required when operator is Between, not allowed otherwise..</param>
        /// <param name="To">The inclusive upper bound of the engagement metric count. Required when operator is Between, not allowed otherwise..</param>
        /// <param name="Value">The engagement metric count to compare against. Required for every operator except Between, not allowed for Between..</param>
        public EngagementFilter(OperatorEnum? Operator = null, int? From = null, int? To = null, int? Value = null)
        {
            this.Operator = Operator;
            this.From = From;
            this.To = To;
            this.Value = Value;
            
        }
        




        /// <summary>
        /// The inclusive lower bound of the engagement metric count. Required when operator is Between, not allowed otherwise.
        /// </summary>
        /// <value>The inclusive lower bound of the engagement metric count. Required when operator is Between, not allowed otherwise.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public int? From { get; set; }



        /// <summary>
        /// The inclusive upper bound of the engagement metric count. Required when operator is Between, not allowed otherwise.
        /// </summary>
        /// <value>The inclusive upper bound of the engagement metric count. Required when operator is Between, not allowed otherwise.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public int? To { get; set; }



        /// <summary>
        /// The engagement metric count to compare against. Required for every operator except Between, not allowed for Between.
        /// </summary>
        /// <value>The engagement metric count to compare against. Required for every operator except Between, not allowed for Between.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public int? Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EngagementFilter {\n");

            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
            return this.Equals(obj as EngagementFilter);
        }

        /// <summary>
        /// Returns true if EngagementFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of EngagementFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EngagementFilter other)
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
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) &&
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
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
                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();

                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
