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
    /// CaseQueryJobFilter
    /// </summary>
    [DataContract]
    public partial class CaseQueryJobFilter :  IEquatable<CaseQueryJobFilter>
    {
        /// <summary>
        /// Filter operator.
        /// </summary>
        /// <value>Filter operator.</value>
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
            /// Enum Eq for "EQ"
            /// </summary>
            [EnumMember(Value = "EQ")]
            Eq,
            
            /// <summary>
            /// Enum Neq for "NEQ"
            /// </summary>
            [EnumMember(Value = "NEQ")]
            Neq,
            
            /// <summary>
            /// Enum Gt for "GT"
            /// </summary>
            [EnumMember(Value = "GT")]
            Gt,
            
            /// <summary>
            /// Enum Lt for "LT"
            /// </summary>
            [EnumMember(Value = "LT")]
            Lt,
            
            /// <summary>
            /// Enum Gte for "GTE"
            /// </summary>
            [EnumMember(Value = "GTE")]
            Gte,
            
            /// <summary>
            /// Enum Lte for "LTE"
            /// </summary>
            [EnumMember(Value = "LTE")]
            Lte,
            
            /// <summary>
            /// Enum In for "IN"
            /// </summary>
            [EnumMember(Value = "IN")]
            In,
            
            /// <summary>
            /// Enum Contains for "CONTAINS"
            /// </summary>
            [EnumMember(Value = "CONTAINS")]
            Contains,
            
            /// <summary>
            /// Enum Between for "BETWEEN"
            /// </summary>
            [EnumMember(Value = "BETWEEN")]
            Between,
            
            /// <summary>
            /// Enum BeginsWith for "BEGINS_WITH"
            /// </summary>
            [EnumMember(Value = "BEGINS_WITH")]
            BeginsWith
        }
        /// <summary>
        /// Filter operator.
        /// </summary>
        /// <value>Filter operator.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseQueryJobFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CaseQueryJobFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseQueryJobFilter" /> class.
        /// </summary>
        /// <param name="Name">Attribute name. Valid filter names are: &#39;caseplanId&#39;, &#39;ownerId&#39;, &#39;status&#39;, &#39;priority&#39;, &#39;dateDue&#39;, &#39;externalContactId&#39;, &#39;customerIntentId&#39;, &#39;dateCreated&#39;, &#39;divisionId&#39;, &#39;reference&#39;. (required).</param>
        /// <param name="Operator">Filter operator. (required).</param>
        /// <param name="Values">List of values to be used in the filter. (required).</param>
        public CaseQueryJobFilter(string Name = null, OperatorEnum? Operator = null, List<string> Values = null)
        {
            this.Name = Name;
            this.Operator = Operator;
            this.Values = Values;
            
        }
        


        /// <summary>
        /// Attribute name. Valid filter names are: &#39;caseplanId&#39;, &#39;ownerId&#39;, &#39;status&#39;, &#39;priority&#39;, &#39;dateDue&#39;, &#39;externalContactId&#39;, &#39;customerIntentId&#39;, &#39;dateCreated&#39;, &#39;divisionId&#39;, &#39;reference&#39;.
        /// </summary>
        /// <value>Attribute name. Valid filter names are: &#39;caseplanId&#39;, &#39;ownerId&#39;, &#39;status&#39;, &#39;priority&#39;, &#39;dateDue&#39;, &#39;externalContactId&#39;, &#39;customerIntentId&#39;, &#39;dateCreated&#39;, &#39;divisionId&#39;, &#39;reference&#39;.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// List of values to be used in the filter.
        /// </summary>
        /// <value>List of values to be used in the filter.</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseQueryJobFilter {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(obj as CaseQueryJobFilter);
        }

        /// <summary>
        /// Returns true if CaseQueryJobFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of CaseQueryJobFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseQueryJobFilter other)
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
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
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

                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();

                return hash;
            }
        }
    }

}
