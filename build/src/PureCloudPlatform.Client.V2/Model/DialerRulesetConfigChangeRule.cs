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
    /// DialerRulesetConfigChangeRule
    /// </summary>
    [DataContract]
    public partial class DialerRulesetConfigChangeRule :  IEquatable<DialerRulesetConfigChangeRule>
    {
        /// <summary>
        /// The category of the rule
        /// </summary>
        /// <value>The category of the rule</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Precall for "DIALER_PRECALL"
            /// </summary>
            [EnumMember(Value = "DIALER_PRECALL")]
            Precall,
            
            /// <summary>
            /// Enum Wrapup for "DIALER_WRAPUP"
            /// </summary>
            [EnumMember(Value = "DIALER_WRAPUP")]
            Wrapup
        }
        /// <summary>
        /// The category of the rule
        /// </summary>
        /// <value>The category of the rule</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerRulesetConfigChangeRule" /> class.
        /// </summary>
        /// <param name="Conditions">The list of rule conditions; all must evaluate to true to trigger the rule actions.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        /// <param name="Id">The identifier of the rule.</param>
        /// <param name="Name">The name of the rule.</param>
        /// <param name="Order">The ranked order of the rule; rules are processed from lowest number to highest.</param>
        /// <param name="Category">The category of the rule.</param>
        /// <param name="Actions">The list of rule actions to be taken if the conditions are true.</param>
        /// <param name="GetAdditionalProperties">GetAdditionalProperties.</param>
        public DialerRulesetConfigChangeRule(List<DialerRulesetConfigChangeCondition> Conditions = null, Dictionary<string, Object> AdditionalProperties = null, string Id = null, string Name = null, long? Order = null, CategoryEnum? Category = null, List<DialerRulesetConfigChangeAction> Actions = null, Dictionary<string, Object> GetAdditionalProperties = null)
        {
            this.Conditions = Conditions;
            this.AdditionalProperties = AdditionalProperties;
            this.Id = Id;
            this.Name = Name;
            this.Order = Order;
            this.Category = Category;
            this.Actions = Actions;
            this.GetAdditionalProperties = GetAdditionalProperties;
            
        }
        


        /// <summary>
        /// The list of rule conditions; all must evaluate to true to trigger the rule actions
        /// </summary>
        /// <value>The list of rule conditions; all must evaluate to true to trigger the rule actions</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public List<DialerRulesetConfigChangeCondition> Conditions { get; set; }



        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, Object> AdditionalProperties { get; set; }



        /// <summary>
        /// The identifier of the rule
        /// </summary>
        /// <value>The identifier of the rule</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The name of the rule
        /// </summary>
        /// <value>The name of the rule</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The ranked order of the rule; rules are processed from lowest number to highest
        /// </summary>
        /// <value>The ranked order of the rule; rules are processed from lowest number to highest</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public long? Order { get; set; }





        /// <summary>
        /// The list of rule actions to be taken if the conditions are true
        /// </summary>
        /// <value>The list of rule actions to be taken if the conditions are true</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<DialerRulesetConfigChangeAction> Actions { get; set; }



        /// <summary>
        /// Gets or Sets GetAdditionalProperties
        /// </summary>
        [DataMember(Name="getAdditionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, Object> GetAdditionalProperties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerRulesetConfigChangeRule {\n");

            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  GetAdditionalProperties: ").Append(GetAdditionalProperties).Append("\n");
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
            return this.Equals(obj as DialerRulesetConfigChangeRule);
        }

        /// <summary>
        /// Returns true if DialerRulesetConfigChangeRule instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerRulesetConfigChangeRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerRulesetConfigChangeRule other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Conditions == other.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.SequenceEqual(other.Conditions)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) &&
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) &&
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) &&
                (
                    this.GetAdditionalProperties == other.GetAdditionalProperties ||
                    this.GetAdditionalProperties != null &&
                    this.GetAdditionalProperties.SequenceEqual(other.GetAdditionalProperties)
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
                if (this.Conditions != null)
                    hash = hash * 59 + this.Conditions.GetHashCode();

                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();

                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();

                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();

                if (this.GetAdditionalProperties != null)
                    hash = hash * 59 + this.GetAdditionalProperties.GetHashCode();

                return hash;
            }
        }
    }

}
