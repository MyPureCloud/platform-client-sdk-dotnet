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
    /// DialerCampaignSkillCombinationStatsEventCampaignSkillCombinationStats
    /// </summary>
    [DataContract]
    public partial class DialerCampaignSkillCombinationStatsEventCampaignSkillCombinationStats :  IEquatable<DialerCampaignSkillCombinationStatsEventCampaignSkillCombinationStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerCampaignSkillCombinationStatsEventCampaignSkillCombinationStats" /> class.
        /// </summary>
        /// <param name="Campaign">Campaign.</param>
        /// <param name="ContactList">A UriReference for a resource.</param>
        /// <param name="TotalSkillCombinations">The total number of unique skill combinations.</param>
        /// <param name="TotalRemainingContacts">The total number of remaining contacts.</param>
        /// <param name="TotalProcessedContacts">The total number of processed contacts.</param>
        /// <param name="SkillCombinationDetails">Details for each skill combination.</param>
        public DialerCampaignSkillCombinationStatsEventCampaignSkillCombinationStats(DialerCampaignSkillCombinationStatsEventUriReference Campaign = null, DialerCampaignSkillCombinationStatsEventUriReference ContactList = null, long? TotalSkillCombinations = null, long? TotalRemainingContacts = null, long? TotalProcessedContacts = null, List<DialerCampaignSkillCombinationStatsEventSkillCombinationDetailNotification> SkillCombinationDetails = null)
        {
            this.Campaign = Campaign;
            this.ContactList = ContactList;
            this.TotalSkillCombinations = TotalSkillCombinations;
            this.TotalRemainingContacts = TotalRemainingContacts;
            this.TotalProcessedContacts = TotalProcessedContacts;
            this.SkillCombinationDetails = SkillCombinationDetails;
            
        }
        


        /// <summary>
        /// Gets or Sets Campaign
        /// </summary>
        [DataMember(Name="campaign", EmitDefaultValue=false)]
        public DialerCampaignSkillCombinationStatsEventUriReference Campaign { get; set; }



        /// <summary>
        /// A UriReference for a resource
        /// </summary>
        /// <value>A UriReference for a resource</value>
        [DataMember(Name="contactList", EmitDefaultValue=false)]
        public DialerCampaignSkillCombinationStatsEventUriReference ContactList { get; set; }



        /// <summary>
        /// The total number of unique skill combinations
        /// </summary>
        /// <value>The total number of unique skill combinations</value>
        [DataMember(Name="totalSkillCombinations", EmitDefaultValue=false)]
        public long? TotalSkillCombinations { get; set; }



        /// <summary>
        /// The total number of remaining contacts
        /// </summary>
        /// <value>The total number of remaining contacts</value>
        [DataMember(Name="totalRemainingContacts", EmitDefaultValue=false)]
        public long? TotalRemainingContacts { get; set; }



        /// <summary>
        /// The total number of processed contacts
        /// </summary>
        /// <value>The total number of processed contacts</value>
        [DataMember(Name="totalProcessedContacts", EmitDefaultValue=false)]
        public long? TotalProcessedContacts { get; set; }



        /// <summary>
        /// Details for each skill combination
        /// </summary>
        /// <value>Details for each skill combination</value>
        [DataMember(Name="skillCombinationDetails", EmitDefaultValue=false)]
        public List<DialerCampaignSkillCombinationStatsEventSkillCombinationDetailNotification> SkillCombinationDetails { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerCampaignSkillCombinationStatsEventCampaignSkillCombinationStats {\n");

            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
            sb.Append("  ContactList: ").Append(ContactList).Append("\n");
            sb.Append("  TotalSkillCombinations: ").Append(TotalSkillCombinations).Append("\n");
            sb.Append("  TotalRemainingContacts: ").Append(TotalRemainingContacts).Append("\n");
            sb.Append("  TotalProcessedContacts: ").Append(TotalProcessedContacts).Append("\n");
            sb.Append("  SkillCombinationDetails: ").Append(SkillCombinationDetails).Append("\n");
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
            return this.Equals(obj as DialerCampaignSkillCombinationStatsEventCampaignSkillCombinationStats);
        }

        /// <summary>
        /// Returns true if DialerCampaignSkillCombinationStatsEventCampaignSkillCombinationStats instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerCampaignSkillCombinationStatsEventCampaignSkillCombinationStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerCampaignSkillCombinationStatsEventCampaignSkillCombinationStats other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Campaign == other.Campaign ||
                    this.Campaign != null &&
                    this.Campaign.Equals(other.Campaign)
                ) &&
                (
                    this.ContactList == other.ContactList ||
                    this.ContactList != null &&
                    this.ContactList.Equals(other.ContactList)
                ) &&
                (
                    this.TotalSkillCombinations == other.TotalSkillCombinations ||
                    this.TotalSkillCombinations != null &&
                    this.TotalSkillCombinations.Equals(other.TotalSkillCombinations)
                ) &&
                (
                    this.TotalRemainingContacts == other.TotalRemainingContacts ||
                    this.TotalRemainingContacts != null &&
                    this.TotalRemainingContacts.Equals(other.TotalRemainingContacts)
                ) &&
                (
                    this.TotalProcessedContacts == other.TotalProcessedContacts ||
                    this.TotalProcessedContacts != null &&
                    this.TotalProcessedContacts.Equals(other.TotalProcessedContacts)
                ) &&
                (
                    this.SkillCombinationDetails == other.SkillCombinationDetails ||
                    this.SkillCombinationDetails != null &&
                    this.SkillCombinationDetails.SequenceEqual(other.SkillCombinationDetails)
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
                if (this.Campaign != null)
                    hash = hash * 59 + this.Campaign.GetHashCode();

                if (this.ContactList != null)
                    hash = hash * 59 + this.ContactList.GetHashCode();

                if (this.TotalSkillCombinations != null)
                    hash = hash * 59 + this.TotalSkillCombinations.GetHashCode();

                if (this.TotalRemainingContacts != null)
                    hash = hash * 59 + this.TotalRemainingContacts.GetHashCode();

                if (this.TotalProcessedContacts != null)
                    hash = hash * 59 + this.TotalProcessedContacts.GetHashCode();

                if (this.SkillCombinationDetails != null)
                    hash = hash * 59 + this.SkillCombinationDetails.GetHashCode();

                return hash;
            }
        }
    }

}
