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
    /// CampaignOutboundLinesAllocation
    /// </summary>
    [DataContract]
    public partial class CampaignOutboundLinesAllocation :  IEquatable<CampaignOutboundLinesAllocation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignOutboundLinesAllocation" /> class.
        /// </summary>
        /// <param name="Campaign">The Campaign.</param>
        /// <param name="CampaignWeight">The relative weight of the campaign.</param>
        /// <param name="LinesAssigned">The number of lines dynamically assigned to the campaign.</param>
        /// <param name="LegacyWeight">true if relative weight of the campaign is not explicitly specified, false otherwise.</param>
        public CampaignOutboundLinesAllocation(DomainEntityRef Campaign = null, int? CampaignWeight = null, int? LinesAssigned = null, bool? LegacyWeight = null)
        {
            this.Campaign = Campaign;
            this.CampaignWeight = CampaignWeight;
            this.LinesAssigned = LinesAssigned;
            this.LegacyWeight = LegacyWeight;
            
        }
        


        /// <summary>
        /// The Campaign
        /// </summary>
        /// <value>The Campaign</value>
        [DataMember(Name="campaign", EmitDefaultValue=false)]
        public DomainEntityRef Campaign { get; set; }



        /// <summary>
        /// The relative weight of the campaign
        /// </summary>
        /// <value>The relative weight of the campaign</value>
        [DataMember(Name="campaignWeight", EmitDefaultValue=false)]
        public int? CampaignWeight { get; set; }



        /// <summary>
        /// The number of lines dynamically assigned to the campaign
        /// </summary>
        /// <value>The number of lines dynamically assigned to the campaign</value>
        [DataMember(Name="linesAssigned", EmitDefaultValue=false)]
        public int? LinesAssigned { get; set; }



        /// <summary>
        /// true if relative weight of the campaign is not explicitly specified, false otherwise
        /// </summary>
        /// <value>true if relative weight of the campaign is not explicitly specified, false otherwise</value>
        [DataMember(Name="legacyWeight", EmitDefaultValue=false)]
        public bool? LegacyWeight { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignOutboundLinesAllocation {\n");

            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
            sb.Append("  CampaignWeight: ").Append(CampaignWeight).Append("\n");
            sb.Append("  LinesAssigned: ").Append(LinesAssigned).Append("\n");
            sb.Append("  LegacyWeight: ").Append(LegacyWeight).Append("\n");
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
            return this.Equals(obj as CampaignOutboundLinesAllocation);
        }

        /// <summary>
        /// Returns true if CampaignOutboundLinesAllocation instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignOutboundLinesAllocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignOutboundLinesAllocation other)
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
                    this.CampaignWeight == other.CampaignWeight ||
                    this.CampaignWeight != null &&
                    this.CampaignWeight.Equals(other.CampaignWeight)
                ) &&
                (
                    this.LinesAssigned == other.LinesAssigned ||
                    this.LinesAssigned != null &&
                    this.LinesAssigned.Equals(other.LinesAssigned)
                ) &&
                (
                    this.LegacyWeight == other.LegacyWeight ||
                    this.LegacyWeight != null &&
                    this.LegacyWeight.Equals(other.LegacyWeight)
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

                if (this.CampaignWeight != null)
                    hash = hash * 59 + this.CampaignWeight.GetHashCode();

                if (this.LinesAssigned != null)
                    hash = hash * 59 + this.LinesAssigned.GetHashCode();

                if (this.LegacyWeight != null)
                    hash = hash * 59 + this.LegacyWeight.GetHashCode();

                return hash;
            }
        }
    }

}
