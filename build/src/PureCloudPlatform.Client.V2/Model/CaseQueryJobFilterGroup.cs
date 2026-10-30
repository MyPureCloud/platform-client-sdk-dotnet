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
    /// CaseQueryJobFilterGroup
    /// </summary>
    [DataContract]
    public partial class CaseQueryJobFilterGroup :  IEquatable<CaseQueryJobFilterGroup>
    {
        /// <summary>
        /// Boolean operator used to combine the filters within this group.
        /// </summary>
        /// <value>Boolean operator used to combine the filters within this group.</value>
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
        /// Boolean operator used to combine the filters within this group.
        /// </summary>
        /// <value>Boolean operator used to combine the filters within this group.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseQueryJobFilterGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CaseQueryJobFilterGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseQueryJobFilterGroup" /> class.
        /// </summary>
        /// <param name="Operator">Boolean operator used to combine the filters within this group. (required).</param>
        /// <param name="Filters">List of filter objects combined using the group operator. (required).</param>
        public CaseQueryJobFilterGroup(OperatorEnum? Operator = null, List<CaseQueryJobFilter> Filters = null)
        {
            this.Operator = Operator;
            this.Filters = Filters;
            
        }
        




        /// <summary>
        /// List of filter objects combined using the group operator.
        /// </summary>
        /// <value>List of filter objects combined using the group operator.</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<CaseQueryJobFilter> Filters { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseQueryJobFilterGroup {\n");

            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
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
            return this.Equals(obj as CaseQueryJobFilterGroup);
        }

        /// <summary>
        /// Returns true if CaseQueryJobFilterGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of CaseQueryJobFilterGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseQueryJobFilterGroup other)
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
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(other.Filters)
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

                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();

                return hash;
            }
        }
    }

}
