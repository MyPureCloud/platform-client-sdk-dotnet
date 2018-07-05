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
    /// CampaignInteractions
    /// </summary>
    [DataContract]
    public partial class CampaignInteractions :  IEquatable<CampaignInteractions>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignInteractions" /> class.
        /// </summary>
        /// <param name="Campaign">Campaign.</param>
        /// <param name="PendingInteractions">PendingInteractions.</param>
        /// <param name="ProceedingInteractions">ProceedingInteractions.</param>
        /// <param name="PreviewingInteractions">PreviewingInteractions.</param>
        /// <param name="InteractingInteractions">InteractingInteractions.</param>
        /// <param name="ScheduledInteractions">ScheduledInteractions.</param>
        public CampaignInteractions(UriReference Campaign = null, List<CampaignInteraction> PendingInteractions = null, List<CampaignInteraction> ProceedingInteractions = null, List<CampaignInteraction> PreviewingInteractions = null, List<CampaignInteraction> InteractingInteractions = null, List<CampaignInteraction> ScheduledInteractions = null)
        {
            this.Campaign = Campaign;
            this.PendingInteractions = PendingInteractions;
            this.ProceedingInteractions = ProceedingInteractions;
            this.PreviewingInteractions = PreviewingInteractions;
            this.InteractingInteractions = InteractingInteractions;
            this.ScheduledInteractions = ScheduledInteractions;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Campaign
        /// </summary>
        [DataMember(Name="campaign", EmitDefaultValue=false)]
        public UriReference Campaign { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PendingInteractions
        /// </summary>
        [DataMember(Name="pendingInteractions", EmitDefaultValue=false)]
        public List<CampaignInteraction> PendingInteractions { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ProceedingInteractions
        /// </summary>
        [DataMember(Name="proceedingInteractions", EmitDefaultValue=false)]
        public List<CampaignInteraction> ProceedingInteractions { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PreviewingInteractions
        /// </summary>
        [DataMember(Name="previewingInteractions", EmitDefaultValue=false)]
        public List<CampaignInteraction> PreviewingInteractions { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets InteractingInteractions
        /// </summary>
        [DataMember(Name="interactingInteractions", EmitDefaultValue=false)]
        public List<CampaignInteraction> InteractingInteractions { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ScheduledInteractions
        /// </summary>
        [DataMember(Name="scheduledInteractions", EmitDefaultValue=false)]
        public List<CampaignInteraction> ScheduledInteractions { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignInteractions {\n");
            
            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
            sb.Append("  PendingInteractions: ").Append(PendingInteractions).Append("\n");
            sb.Append("  ProceedingInteractions: ").Append(ProceedingInteractions).Append("\n");
            sb.Append("  PreviewingInteractions: ").Append(PreviewingInteractions).Append("\n");
            sb.Append("  InteractingInteractions: ").Append(InteractingInteractions).Append("\n");
            sb.Append("  ScheduledInteractions: ").Append(ScheduledInteractions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CampaignInteractions);
        }

        /// <summary>
        /// Returns true if CampaignInteractions instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignInteractions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignInteractions other)
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
                    this.PendingInteractions == other.PendingInteractions ||
                    this.PendingInteractions != null &&
                    this.PendingInteractions.SequenceEqual(other.PendingInteractions)
                ) &&
                (
                    this.ProceedingInteractions == other.ProceedingInteractions ||
                    this.ProceedingInteractions != null &&
                    this.ProceedingInteractions.SequenceEqual(other.ProceedingInteractions)
                ) &&
                (
                    this.PreviewingInteractions == other.PreviewingInteractions ||
                    this.PreviewingInteractions != null &&
                    this.PreviewingInteractions.SequenceEqual(other.PreviewingInteractions)
                ) &&
                (
                    this.InteractingInteractions == other.InteractingInteractions ||
                    this.InteractingInteractions != null &&
                    this.InteractingInteractions.SequenceEqual(other.InteractingInteractions)
                ) &&
                (
                    this.ScheduledInteractions == other.ScheduledInteractions ||
                    this.ScheduledInteractions != null &&
                    this.ScheduledInteractions.SequenceEqual(other.ScheduledInteractions)
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
                
                if (this.PendingInteractions != null)
                    hash = hash * 59 + this.PendingInteractions.GetHashCode();
                
                if (this.ProceedingInteractions != null)
                    hash = hash * 59 + this.ProceedingInteractions.GetHashCode();
                
                if (this.PreviewingInteractions != null)
                    hash = hash * 59 + this.PreviewingInteractions.GetHashCode();
                
                if (this.InteractingInteractions != null)
                    hash = hash * 59 + this.InteractingInteractions.GetHashCode();
                
                if (this.ScheduledInteractions != null)
                    hash = hash * 59 + this.ScheduledInteractions.GetHashCode();
                
                return hash;
            }
        }
    }

}
