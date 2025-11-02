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
    /// ConversationSchemaData
    /// </summary>
    [DataContract]
    public partial class ConversationSchemaData :  IEquatable<ConversationSchemaData>
    {
        /// <summary>
        /// Operator to apply for multiple attributes, default: MatchAll
        /// </summary>
        /// <value>Operator to apply for multiple attributes, default: MatchAll</value>
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
            /// Enum Matchany for "MatchAny"
            /// </summary>
            [EnumMember(Value = "MatchAny")]
            Matchany,
            
            /// <summary>
            /// Enum Matchall for "MatchAll"
            /// </summary>
            [EnumMember(Value = "MatchAll")]
            Matchall
        }
        /// <summary>
        /// Operator to apply for multiple attributes, default: MatchAll
        /// </summary>
        /// <value>Operator to apply for multiple attributes, default: MatchAll</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSchemaData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationSchemaData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSchemaData" /> class.
        /// </summary>
        /// <param name="Schema">Schema that defines attributes. (required).</param>
        /// <param name="Attributes">Attributes to use for filtering; number of elements: min: 1, max: 5. (required).</param>
        /// <param name="Operator">Operator to apply for multiple attributes, default: MatchAll.</param>
        public ConversationSchemaData(ConversationSchemaReference Schema = null, List<ConversationSchemaAttribute> Attributes = null, OperatorEnum? Operator = null)
        {
            this.Schema = Schema;
            this.Attributes = Attributes;
            this.Operator = Operator;
            
        }
        


        /// <summary>
        /// Schema that defines attributes.
        /// </summary>
        /// <value>Schema that defines attributes.</value>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public ConversationSchemaReference Schema { get; set; }



        /// <summary>
        /// Attributes to use for filtering; number of elements: min: 1, max: 5.
        /// </summary>
        /// <value>Attributes to use for filtering; number of elements: min: 1, max: 5.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<ConversationSchemaAttribute> Attributes { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationSchemaData {\n");

            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(obj as ConversationSchemaData);
        }

        /// <summary>
        /// Returns true if ConversationSchemaData instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationSchemaData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationSchemaData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Schema == other.Schema ||
                    this.Schema != null &&
                    this.Schema.Equals(other.Schema)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
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
                if (this.Schema != null)
                    hash = hash * 59 + this.Schema.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                return hash;
            }
        }
    }

}
