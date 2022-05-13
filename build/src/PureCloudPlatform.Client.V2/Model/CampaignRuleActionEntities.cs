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
    /// CampaignRuleActionEntities
    /// </summary>
    [DataContract]
    public partial class CampaignRuleActionEntities :  IEquatable<CampaignRuleActionEntities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleActionEntities" /> class.
        /// </summary>
        /// <param name="Campaigns">The list of campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a campaign..</param>
        /// <param name="Sequences">The list of sequences for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a sequence..</param>
        /// <param name="UseTriggeringEntity">If true, the CampaignRuleAction will apply to the same entity that triggered the CampaignRuleCondition..</param>
        public CampaignRuleActionEntities(List<DomainEntityRef> Campaigns = null, List<DomainEntityRef> Sequences = null, bool? UseTriggeringEntity = null)
        {
            this.Campaigns = Campaigns;
            this.Sequences = Sequences;
            this.UseTriggeringEntity = UseTriggeringEntity;
            
        }
        


        /// <summary>
        /// The list of campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a campaign.
        /// </summary>
        /// <value>The list of campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a campaign.</value>
        [DataMember(Name="campaigns", EmitDefaultValue=false)]
        public List<DomainEntityRef> Campaigns { get; set; }



        /// <summary>
        /// The list of sequences for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a sequence.
        /// </summary>
        /// <value>The list of sequences for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a sequence.</value>
        [DataMember(Name="sequences", EmitDefaultValue=false)]
        public List<DomainEntityRef> Sequences { get; set; }



        /// <summary>
        /// If true, the CampaignRuleAction will apply to the same entity that triggered the CampaignRuleCondition.
        /// </summary>
        /// <value>If true, the CampaignRuleAction will apply to the same entity that triggered the CampaignRuleCondition.</value>
        [DataMember(Name="useTriggeringEntity", EmitDefaultValue=false)]
        public bool? UseTriggeringEntity { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignRuleActionEntities {\n");

            sb.Append("  Campaigns: ").Append(Campaigns).Append("\n");
            sb.Append("  Sequences: ").Append(Sequences).Append("\n");
            sb.Append("  UseTriggeringEntity: ").Append(UseTriggeringEntity).Append("\n");
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
            return this.Equals(obj as CampaignRuleActionEntities);
        }

        /// <summary>
        /// Returns true if CampaignRuleActionEntities instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignRuleActionEntities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRuleActionEntities other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Campaigns == other.Campaigns ||
                    this.Campaigns != null &&
                    this.Campaigns.SequenceEqual(other.Campaigns)
                ) &&
                (
                    this.Sequences == other.Sequences ||
                    this.Sequences != null &&
                    this.Sequences.SequenceEqual(other.Sequences)
                ) &&
                (
                    this.UseTriggeringEntity == other.UseTriggeringEntity ||
                    this.UseTriggeringEntity != null &&
                    this.UseTriggeringEntity.Equals(other.UseTriggeringEntity)
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
                if (this.Campaigns != null)
                    hash = hash * 59 + this.Campaigns.GetHashCode();

                if (this.Sequences != null)
                    hash = hash * 59 + this.Sequences.GetHashCode();

                if (this.UseTriggeringEntity != null)
                    hash = hash * 59 + this.UseTriggeringEntity.GetHashCode();

                return hash;
            }
        }
    }

}
