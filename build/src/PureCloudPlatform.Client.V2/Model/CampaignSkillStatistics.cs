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
    /// CampaignSkillStatistics
    /// </summary>
    [DataContract]
    public partial class CampaignSkillStatistics :  IEquatable<CampaignSkillStatistics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSkillStatistics" /> class.
        /// </summary>
        public CampaignSkillStatistics()
        {
            
        }
        


        /// <summary>
        /// Number of available skill combinations for the campaign
        /// </summary>
        /// <value>Number of available skill combinations for the campaign</value>
        [DataMember(Name="skillCombinations", EmitDefaultValue=false)]
        public int? SkillCombinations { get; private set; }



        /// <summary>
        /// Number of eligible agents with skills for campaign
        /// </summary>
        /// <value>Number of eligible agents with skills for campaign</value>
        [DataMember(Name="eligibleSkilledAgents", EmitDefaultValue=false)]
        public int? EligibleSkilledAgents { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignSkillStatistics {\n");

            sb.Append("  SkillCombinations: ").Append(SkillCombinations).Append("\n");
            sb.Append("  EligibleSkilledAgents: ").Append(EligibleSkilledAgents).Append("\n");
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
            return this.Equals(obj as CampaignSkillStatistics);
        }

        /// <summary>
        /// Returns true if CampaignSkillStatistics instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignSkillStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignSkillStatistics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SkillCombinations == other.SkillCombinations ||
                    this.SkillCombinations != null &&
                    this.SkillCombinations.Equals(other.SkillCombinations)
                ) &&
                (
                    this.EligibleSkilledAgents == other.EligibleSkilledAgents ||
                    this.EligibleSkilledAgents != null &&
                    this.EligibleSkilledAgents.Equals(other.EligibleSkilledAgents)
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
                if (this.SkillCombinations != null)
                    hash = hash * 59 + this.SkillCombinations.GetHashCode();

                if (this.EligibleSkilledAgents != null)
                    hash = hash * 59 + this.EligibleSkilledAgents.GetHashCode();

                return hash;
            }
        }
    }

}
