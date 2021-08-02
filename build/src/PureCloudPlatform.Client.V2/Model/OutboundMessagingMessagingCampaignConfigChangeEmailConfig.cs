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
    /// OutboundMessagingMessagingCampaignConfigChangeEmailConfig
    /// </summary>
    [DataContract]
    public partial class OutboundMessagingMessagingCampaignConfigChangeEmailConfig :  IEquatable<OutboundMessagingMessagingCampaignConfigChangeEmailConfig>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundMessagingMessagingCampaignConfigChangeEmailConfig" /> class.
        /// </summary>
        /// <param name="EmailColumns">EmailColumns.</param>
        /// <param name="ContentTemplate">ContentTemplate.</param>
        /// <param name="FromAddress">FromAddress.</param>
        /// <param name="ReplyToAddress">ReplyToAddress.</param>
        public OutboundMessagingMessagingCampaignConfigChangeEmailConfig(List<string> EmailColumns = null, OutboundMessagingMessagingCampaignConfigChangeResponseRef ContentTemplate = null, OutboundMessagingMessagingCampaignConfigChangeFromEmailAddress FromAddress = null, OutboundMessagingMessagingCampaignConfigChangeReplyToEmailAddress ReplyToAddress = null)
        {
            this.EmailColumns = EmailColumns;
            this.ContentTemplate = ContentTemplate;
            this.FromAddress = FromAddress;
            this.ReplyToAddress = ReplyToAddress;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets EmailColumns
        /// </summary>
        [DataMember(Name="emailColumns", EmitDefaultValue=false)]
        public List<string> EmailColumns { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ContentTemplate
        /// </summary>
        [DataMember(Name="contentTemplate", EmitDefaultValue=false)]
        public OutboundMessagingMessagingCampaignConfigChangeResponseRef ContentTemplate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets FromAddress
        /// </summary>
        [DataMember(Name="fromAddress", EmitDefaultValue=false)]
        public OutboundMessagingMessagingCampaignConfigChangeFromEmailAddress FromAddress { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ReplyToAddress
        /// </summary>
        [DataMember(Name="replyToAddress", EmitDefaultValue=false)]
        public OutboundMessagingMessagingCampaignConfigChangeReplyToEmailAddress ReplyToAddress { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutboundMessagingMessagingCampaignConfigChangeEmailConfig {\n");
            
            sb.Append("  EmailColumns: ").Append(EmailColumns).Append("\n");
            sb.Append("  ContentTemplate: ").Append(ContentTemplate).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  ReplyToAddress: ").Append(ReplyToAddress).Append("\n");
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
            return this.Equals(obj as OutboundMessagingMessagingCampaignConfigChangeEmailConfig);
        }

        /// <summary>
        /// Returns true if OutboundMessagingMessagingCampaignConfigChangeEmailConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of OutboundMessagingMessagingCampaignConfigChangeEmailConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutboundMessagingMessagingCampaignConfigChangeEmailConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EmailColumns == other.EmailColumns ||
                    this.EmailColumns != null &&
                    this.EmailColumns.SequenceEqual(other.EmailColumns)
                ) &&
                (
                    this.ContentTemplate == other.ContentTemplate ||
                    this.ContentTemplate != null &&
                    this.ContentTemplate.Equals(other.ContentTemplate)
                ) &&
                (
                    this.FromAddress == other.FromAddress ||
                    this.FromAddress != null &&
                    this.FromAddress.Equals(other.FromAddress)
                ) &&
                (
                    this.ReplyToAddress == other.ReplyToAddress ||
                    this.ReplyToAddress != null &&
                    this.ReplyToAddress.Equals(other.ReplyToAddress)
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
                
                if (this.EmailColumns != null)
                    hash = hash * 59 + this.EmailColumns.GetHashCode();
                
                if (this.ContentTemplate != null)
                    hash = hash * 59 + this.ContentTemplate.GetHashCode();
                
                if (this.FromAddress != null)
                    hash = hash * 59 + this.FromAddress.GetHashCode();
                
                if (this.ReplyToAddress != null)
                    hash = hash * 59 + this.ReplyToAddress.GetHashCode();
                
                return hash;
            }
        }
    }

}
