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
    public partial class OutboundMessagingMessagingCampaignConfigChangeFromEmailAddress :  IEquatable<OutboundMessagingMessagingCampaignConfigChangeFromEmailAddress>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundMessagingMessagingCampaignConfigChangeFromEmailAddress" /> class.
        /// </summary>
        /// <param name="FriendlyName">The friendly name of the email address..</param>
        /// <param name="LocalPart">The local part of the email address..</param>
        /// <param name="Domain">A UriReference for a resource.</param>
        public OutboundMessagingMessagingCampaignConfigChangeFromEmailAddress(string FriendlyName = null, string LocalPart = null, OutboundMessagingMessagingCampaignConfigChangeUriReference Domain = null)
        {
            this.FriendlyName = FriendlyName;
            this.LocalPart = LocalPart;
            this.Domain = Domain;
            
        }
        
        
        
        /// <summary>
        /// The friendly name of the email address.
        /// </summary>
        /// <value>The friendly name of the email address.</value>
        [DataMember(Name="friendlyName", EmitDefaultValue=false)]
        public string FriendlyName { get; set; }
        
        
        
        /// <summary>
        /// The local part of the email address.
        /// </summary>
        /// <value>The local part of the email address.</value>
        [DataMember(Name="localPart", EmitDefaultValue=false)]
        public string LocalPart { get; set; }
        
        
        
        /// <summary>
        /// A UriReference for a resource
        /// </summary>
        /// <value>A UriReference for a resource</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public OutboundMessagingMessagingCampaignConfigChangeUriReference Domain { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutboundMessagingMessagingCampaignConfigChangeFromEmailAddress {\n");
            
            sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
            sb.Append("  LocalPart: ").Append(LocalPart).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
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
            return this.Equals(obj as OutboundMessagingMessagingCampaignConfigChangeFromEmailAddress);
        }

        /// <summary>
        /// Returns true if OutboundMessagingMessagingCampaignConfigChangeFromEmailAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of OutboundMessagingMessagingCampaignConfigChangeFromEmailAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutboundMessagingMessagingCampaignConfigChangeFromEmailAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FriendlyName == other.FriendlyName ||
                    this.FriendlyName != null &&
                    this.FriendlyName.Equals(other.FriendlyName)
                ) &&
                (
                    this.LocalPart == other.LocalPart ||
                    this.LocalPart != null &&
                    this.LocalPart.Equals(other.LocalPart)
                ) &&
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
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
                
                if (this.FriendlyName != null)
                    hash = hash * 59 + this.FriendlyName.GetHashCode();
                
                if (this.LocalPart != null)
                    hash = hash * 59 + this.LocalPart.GetHashCode();
                
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();
                
                return hash;
            }
        }
    }

}
