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
    /// OutboundMessagingMessagingCampaignConfigChangeSmsConfig
    /// </summary>
    [DataContract]
    public partial class OutboundMessagingMessagingCampaignConfigChangeSmsConfig :  IEquatable<OutboundMessagingMessagingCampaignConfigChangeSmsConfig>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundMessagingMessagingCampaignConfigChangeSmsConfig" /> class.
        /// </summary>
        /// <param name="MessageColumn">MessageColumn.</param>
        /// <param name="PhoneColumn">PhoneColumn.</param>
        /// <param name="SenderSmsPhoneNumber">SenderSmsPhoneNumber.</param>
        /// <param name="ContentTemplate">ContentTemplate.</param>
        public OutboundMessagingMessagingCampaignConfigChangeSmsConfig(string MessageColumn = null, string PhoneColumn = null, OutboundMessagingMessagingCampaignConfigChangeSmsPhoneNumberRef SenderSmsPhoneNumber = null, OutboundMessagingMessagingCampaignConfigChangeResponseRef ContentTemplate = null)
        {
            this.MessageColumn = MessageColumn;
            this.PhoneColumn = PhoneColumn;
            this.SenderSmsPhoneNumber = SenderSmsPhoneNumber;
            this.ContentTemplate = ContentTemplate;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets MessageColumn
        /// </summary>
        [DataMember(Name="messageColumn", EmitDefaultValue=false)]
        public string MessageColumn { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PhoneColumn
        /// </summary>
        [DataMember(Name="phoneColumn", EmitDefaultValue=false)]
        public string PhoneColumn { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SenderSmsPhoneNumber
        /// </summary>
        [DataMember(Name="senderSmsPhoneNumber", EmitDefaultValue=false)]
        public OutboundMessagingMessagingCampaignConfigChangeSmsPhoneNumberRef SenderSmsPhoneNumber { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ContentTemplate
        /// </summary>
        [DataMember(Name="contentTemplate", EmitDefaultValue=false)]
        public OutboundMessagingMessagingCampaignConfigChangeResponseRef ContentTemplate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutboundMessagingMessagingCampaignConfigChangeSmsConfig {\n");
            
            sb.Append("  MessageColumn: ").Append(MessageColumn).Append("\n");
            sb.Append("  PhoneColumn: ").Append(PhoneColumn).Append("\n");
            sb.Append("  SenderSmsPhoneNumber: ").Append(SenderSmsPhoneNumber).Append("\n");
            sb.Append("  ContentTemplate: ").Append(ContentTemplate).Append("\n");
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
            return this.Equals(obj as OutboundMessagingMessagingCampaignConfigChangeSmsConfig);
        }

        /// <summary>
        /// Returns true if OutboundMessagingMessagingCampaignConfigChangeSmsConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of OutboundMessagingMessagingCampaignConfigChangeSmsConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutboundMessagingMessagingCampaignConfigChangeSmsConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MessageColumn == other.MessageColumn ||
                    this.MessageColumn != null &&
                    this.MessageColumn.Equals(other.MessageColumn)
                ) &&
                (
                    this.PhoneColumn == other.PhoneColumn ||
                    this.PhoneColumn != null &&
                    this.PhoneColumn.Equals(other.PhoneColumn)
                ) &&
                (
                    this.SenderSmsPhoneNumber == other.SenderSmsPhoneNumber ||
                    this.SenderSmsPhoneNumber != null &&
                    this.SenderSmsPhoneNumber.Equals(other.SenderSmsPhoneNumber)
                ) &&
                (
                    this.ContentTemplate == other.ContentTemplate ||
                    this.ContentTemplate != null &&
                    this.ContentTemplate.Equals(other.ContentTemplate)
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
                
                if (this.MessageColumn != null)
                    hash = hash * 59 + this.MessageColumn.GetHashCode();
                
                if (this.PhoneColumn != null)
                    hash = hash * 59 + this.PhoneColumn.GetHashCode();
                
                if (this.SenderSmsPhoneNumber != null)
                    hash = hash * 59 + this.SenderSmsPhoneNumber.GetHashCode();
                
                if (this.ContentTemplate != null)
                    hash = hash * 59 + this.ContentTemplate.GetHashCode();
                
                return hash;
            }
        }
    }

}
