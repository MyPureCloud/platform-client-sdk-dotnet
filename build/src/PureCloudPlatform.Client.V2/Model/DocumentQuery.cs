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
    /// DocumentQuery
    /// </summary>
    [DataContract]
    public partial class DocumentQuery :  IEquatable<DocumentQuery>
    {
        /// <summary>
        /// Specifies how the filter clauses will be applied together.
        /// </summary>
        /// <value>Specifies how the filter clauses will be applied together.</value>
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
            /// Enum Or for "Or"
            /// </summary>
            [EnumMember(Value = "Or")]
            Or,
            
            /// <summary>
            /// Enum And for "And"
            /// </summary>
            [EnumMember(Value = "And")]
            And
        }
        /// <summary>
        /// Specifies how the filter clauses will be applied together.
        /// </summary>
        /// <value>Specifies how the filter clauses will be applied together.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentQuery" /> class.
        /// </summary>
        /// <param name="Clauses">Documents filter clauses/criteria. Limit of 20 clauses. (required).</param>
        /// <param name="Operator">Specifies how the filter clauses will be applied together. (required).</param>
        public DocumentQuery(List<DocumentQueryClause> Clauses = null, OperatorEnum? Operator = null)
        {
            this.Clauses = Clauses;
            this.Operator = Operator;
            
        }
        


        /// <summary>
        /// Documents filter clauses/criteria. Limit of 20 clauses.
        /// </summary>
        /// <value>Documents filter clauses/criteria. Limit of 20 clauses.</value>
        [DataMember(Name="clauses", EmitDefaultValue=false)]
        public List<DocumentQueryClause> Clauses { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentQuery {\n");

            sb.Append("  Clauses: ").Append(Clauses).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
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
            return this.Equals(obj as DocumentQuery);
        }

        /// <summary>
        /// Returns true if DocumentQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Clauses == other.Clauses ||
                    this.Clauses != null &&
                    this.Clauses.SequenceEqual(other.Clauses)
                ) &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
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
                if (this.Clauses != null)
                    hash = hash * 59 + this.Clauses.GetHashCode();

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                return hash;
            }
        }
    }

}
