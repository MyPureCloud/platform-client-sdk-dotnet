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
    /// An outbound-messaging messaging campaign email address
    /// </summary>
    [DataContract]
    public partial class OutboundMessagingMessagingCampaignConfigChangeReplyToEmailAddress :  IEquatable<OutboundMessagingMessagingCampaignConfigChangeReplyToEmailAddress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundMessagingMessagingCampaignConfigChangeReplyToEmailAddress" /> class.
        /// </summary>
        /// <param name="Domain">A UriReference for a resource.</param>
        /// <param name="Route">A UriReference for a resource.</param>
        public OutboundMessagingMessagingCampaignConfigChangeReplyToEmailAddress(OutboundMessagingMessagingCampaignConfigChangeUriReference Domain = null, OutboundMessagingMessagingCampaignConfigChangeUriReference Route = null)
        {
            this.Domain = Domain;
            this.Route = Route;
            
        }
        


        /// <summary>
        /// A UriReference for a resource
        /// </summary>
        /// <value>A UriReference for a resource</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public OutboundMessagingMessagingCampaignConfigChangeUriReference Domain { get; set; }



        /// <summary>
        /// A UriReference for a resource
        /// </summary>
        /// <value>A UriReference for a resource</value>
        [DataMember(Name="route", EmitDefaultValue=false)]
        public OutboundMessagingMessagingCampaignConfigChangeUriReference Route { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutboundMessagingMessagingCampaignConfigChangeReplyToEmailAddress {\n");

            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Route: ").Append(Route).Append("\n");
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
            return this.Equals(obj as OutboundMessagingMessagingCampaignConfigChangeReplyToEmailAddress);
        }

        /// <summary>
        /// Returns true if OutboundMessagingMessagingCampaignConfigChangeReplyToEmailAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of OutboundMessagingMessagingCampaignConfigChangeReplyToEmailAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutboundMessagingMessagingCampaignConfigChangeReplyToEmailAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) &&
                (
                    this.Route == other.Route ||
                    this.Route != null &&
                    this.Route.Equals(other.Route)
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
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();

                if (this.Route != null)
                    hash = hash * 59 + this.Route.GetHashCode();

                return hash;
            }
        }
    }

}
