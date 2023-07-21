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
    /// CommonRuleConditions
    /// </summary>
    [DataContract]
    public partial class CommonRuleConditions :  IEquatable<CommonRuleConditions>
    {
        /// <summary>
        /// the logic operator performed.
        /// </summary>
        /// <value>the logic operator performed.</value>
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
            /// Enum And for "And"
            /// </summary>
            [EnumMember(Value = "And")]
            And,
            
            /// <summary>
            /// Enum Or for "Or"
            /// </summary>
            [EnumMember(Value = "Or")]
            Or,
            
            /// <summary>
            /// Enum Not for "Not"
            /// </summary>
            [EnumMember(Value = "Not")]
            Not
        }
        /// <summary>
        /// the logic operator performed.
        /// </summary>
        /// <value>the logic operator performed.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonRuleConditions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonRuleConditions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonRuleConditions" /> class.
        /// </summary>
        /// <param name="Clauses">The list of predicates groups to be evaluated.</param>
        /// <param name="Predicates">The list of rule metric predicates to be evaluated. (required).</param>
        /// <param name="Type">the logic operator performed. (required).</param>
        /// <param name="Id">The id..</param>
        public CommonRuleConditions(List<CommonRuleConditions> Clauses = null, List<CommonRulePredicate> Predicates = null, TypeEnum? Type = null, string Id = null)
        {
            this.Clauses = Clauses;
            this.Predicates = Predicates;
            this.Type = Type;
            this.Id = Id;
            
        }
        


        /// <summary>
        /// The list of predicates groups to be evaluated
        /// </summary>
        /// <value>The list of predicates groups to be evaluated</value>
        [DataMember(Name="clauses", EmitDefaultValue=false)]
        public List<CommonRuleConditions> Clauses { get; set; }



        /// <summary>
        /// The list of rule metric predicates to be evaluated.
        /// </summary>
        /// <value>The list of rule metric predicates to be evaluated.</value>
        [DataMember(Name="predicates", EmitDefaultValue=false)]
        public List<CommonRulePredicate> Predicates { get; set; }





        /// <summary>
        /// The id.
        /// </summary>
        /// <value>The id.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonRuleConditions {\n");

            sb.Append("  Clauses: ").Append(Clauses).Append("\n");
            sb.Append("  Predicates: ").Append(Predicates).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as CommonRuleConditions);
        }

        /// <summary>
        /// Returns true if CommonRuleConditions instances are equal
        /// </summary>
        /// <param name="other">Instance of CommonRuleConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonRuleConditions other)
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
                    this.Predicates == other.Predicates ||
                    this.Predicates != null &&
                    this.Predicates.SequenceEqual(other.Predicates)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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

                if (this.Predicates != null)
                    hash = hash * 59 + this.Predicates.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                return hash;
            }
        }
    }

}
