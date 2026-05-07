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
    /// DialerCampaignSkillCombinationStatsEventSkillCombinationDetailNotification
    /// </summary>
    [DataContract]
    public partial class DialerCampaignSkillCombinationStatsEventSkillCombinationDetailNotification :  IEquatable<DialerCampaignSkillCombinationStatsEventSkillCombinationDetailNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerCampaignSkillCombinationStatsEventSkillCombinationDetailNotification" /> class.
        /// </summary>
        /// <param name="SkillCombination">Array of skill identifiers that make up this skill combination.</param>
        /// <param name="TotalCount">The total number of contacts for this skill combination.</param>
        /// <param name="ProcessedCount">The number of processed contacts for this skill combination.</param>
        /// <param name="CompletionPercentage">The completion percentage for this skill combination.</param>
        public DialerCampaignSkillCombinationStatsEventSkillCombinationDetailNotification(List<string> SkillCombination = null, long? TotalCount = null, long? ProcessedCount = null, double? CompletionPercentage = null)
        {
            this.SkillCombination = SkillCombination;
            this.TotalCount = TotalCount;
            this.ProcessedCount = ProcessedCount;
            this.CompletionPercentage = CompletionPercentage;
            
        }
        


        /// <summary>
        /// Array of skill identifiers that make up this skill combination
        /// </summary>
        /// <value>Array of skill identifiers that make up this skill combination</value>
        [DataMember(Name="skillCombination", EmitDefaultValue=false)]
        public List<string> SkillCombination { get; set; }



        /// <summary>
        /// The total number of contacts for this skill combination
        /// </summary>
        /// <value>The total number of contacts for this skill combination</value>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public long? TotalCount { get; set; }



        /// <summary>
        /// The number of processed contacts for this skill combination
        /// </summary>
        /// <value>The number of processed contacts for this skill combination</value>
        [DataMember(Name="processedCount", EmitDefaultValue=false)]
        public long? ProcessedCount { get; set; }



        /// <summary>
        /// The completion percentage for this skill combination
        /// </summary>
        /// <value>The completion percentage for this skill combination</value>
        [DataMember(Name="completionPercentage", EmitDefaultValue=false)]
        public double? CompletionPercentage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerCampaignSkillCombinationStatsEventSkillCombinationDetailNotification {\n");

            sb.Append("  SkillCombination: ").Append(SkillCombination).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  ProcessedCount: ").Append(ProcessedCount).Append("\n");
            sb.Append("  CompletionPercentage: ").Append(CompletionPercentage).Append("\n");
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
            return this.Equals(obj as DialerCampaignSkillCombinationStatsEventSkillCombinationDetailNotification);
        }

        /// <summary>
        /// Returns true if DialerCampaignSkillCombinationStatsEventSkillCombinationDetailNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerCampaignSkillCombinationStatsEventSkillCombinationDetailNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerCampaignSkillCombinationStatsEventSkillCombinationDetailNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SkillCombination == other.SkillCombination ||
                    this.SkillCombination != null &&
                    this.SkillCombination.SequenceEqual(other.SkillCombination)
                ) &&
                (
                    this.TotalCount == other.TotalCount ||
                    this.TotalCount != null &&
                    this.TotalCount.Equals(other.TotalCount)
                ) &&
                (
                    this.ProcessedCount == other.ProcessedCount ||
                    this.ProcessedCount != null &&
                    this.ProcessedCount.Equals(other.ProcessedCount)
                ) &&
                (
                    this.CompletionPercentage == other.CompletionPercentage ||
                    this.CompletionPercentage != null &&
                    this.CompletionPercentage.Equals(other.CompletionPercentage)
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
                if (this.SkillCombination != null)
                    hash = hash * 59 + this.SkillCombination.GetHashCode();

                if (this.TotalCount != null)
                    hash = hash * 59 + this.TotalCount.GetHashCode();

                if (this.ProcessedCount != null)
                    hash = hash * 59 + this.ProcessedCount.GetHashCode();

                if (this.CompletionPercentage != null)
                    hash = hash * 59 + this.CompletionPercentage.GetHashCode();

                return hash;
            }
        }
    }

}
