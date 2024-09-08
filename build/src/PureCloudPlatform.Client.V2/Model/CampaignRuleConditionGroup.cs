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
    /// CampaignRuleConditionGroup
    /// </summary>
    [DataContract]
    public partial class CampaignRuleConditionGroup :  IEquatable<CampaignRuleConditionGroup>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleConditionGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignRuleConditionGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleConditionGroup" /> class.
        /// </summary>
        /// <param name="MatchAnyConditions">Whether or not this condition group should be evaluated as true if any of sub conditions is matched (required).</param>
        /// <param name="Conditions">The parameters for the CampaignRuleCondition. (required).</param>
        public CampaignRuleConditionGroup(bool? MatchAnyConditions = null, List<CampaignRuleCondition> Conditions = null)
        {
            this.MatchAnyConditions = MatchAnyConditions;
            this.Conditions = Conditions;
            
        }
        


        /// <summary>
        /// Whether or not this condition group should be evaluated as true if any of sub conditions is matched
        /// </summary>
        /// <value>Whether or not this condition group should be evaluated as true if any of sub conditions is matched</value>
        [DataMember(Name="matchAnyConditions", EmitDefaultValue=false)]
        public bool? MatchAnyConditions { get; set; }



        /// <summary>
        /// The parameters for the CampaignRuleCondition.
        /// </summary>
        /// <value>The parameters for the CampaignRuleCondition.</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public List<CampaignRuleCondition> Conditions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignRuleConditionGroup {\n");

            sb.Append("  MatchAnyConditions: ").Append(MatchAnyConditions).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
            return this.Equals(obj as CampaignRuleConditionGroup);
        }

        /// <summary>
        /// Returns true if CampaignRuleConditionGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignRuleConditionGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRuleConditionGroup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MatchAnyConditions == other.MatchAnyConditions ||
                    this.MatchAnyConditions != null &&
                    this.MatchAnyConditions.Equals(other.MatchAnyConditions)
                ) &&
                (
                    this.Conditions == other.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.SequenceEqual(other.Conditions)
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
                if (this.MatchAnyConditions != null)
                    hash = hash * 59 + this.MatchAnyConditions.GetHashCode();

                if (this.Conditions != null)
                    hash = hash * 59 + this.Conditions.GetHashCode();

                return hash;
            }
        }
    }

}
