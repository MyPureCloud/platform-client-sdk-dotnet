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
    /// OutboundBlendingSettings
    /// </summary>
    [DataContract]
    public partial class OutboundBlendingSettings :  IEquatable<OutboundBlendingSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundBlendingSettings" /> class.
        /// </summary>
        /// <param name="Enabled">Whether Enhanced Blending is enabled for the queue..</param>
        /// <param name="CampaignReservationPercentage">The proportion of on-queue agents to reserve for outbound campaign calls. Allowable range 1 - 100 (inclusive)..</param>
        public OutboundBlendingSettings(bool? Enabled = null, int? CampaignReservationPercentage = null)
        {
            this.Enabled = Enabled;
            this.CampaignReservationPercentage = CampaignReservationPercentage;
            
        }
        


        /// <summary>
        /// Whether Enhanced Blending is enabled for the queue.
        /// </summary>
        /// <value>Whether Enhanced Blending is enabled for the queue.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// The proportion of on-queue agents to reserve for outbound campaign calls. Allowable range 1 - 100 (inclusive).
        /// </summary>
        /// <value>The proportion of on-queue agents to reserve for outbound campaign calls. Allowable range 1 - 100 (inclusive).</value>
        [DataMember(Name="campaignReservationPercentage", EmitDefaultValue=false)]
        public int? CampaignReservationPercentage { get; set; }



        /// <summary>
        /// Whether Enhanced Blending is currently active for the queue. Only populated when getting a single queue with expand&#x3D;outboundblendingstatus.
        /// </summary>
        /// <value>Whether Enhanced Blending is currently active for the queue. Only populated when getting a single queue with expand&#x3D;outboundblendingstatus.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutboundBlendingSettings {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  CampaignReservationPercentage: ").Append(CampaignReservationPercentage).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
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
            return this.Equals(obj as OutboundBlendingSettings);
        }

        /// <summary>
        /// Returns true if OutboundBlendingSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of OutboundBlendingSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutboundBlendingSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.CampaignReservationPercentage == other.CampaignReservationPercentage ||
                    this.CampaignReservationPercentage != null &&
                    this.CampaignReservationPercentage.Equals(other.CampaignReservationPercentage)
                ) &&
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.CampaignReservationPercentage != null)
                    hash = hash * 59 + this.CampaignReservationPercentage.GetHashCode();

                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();

                return hash;
            }
        }
    }

}
