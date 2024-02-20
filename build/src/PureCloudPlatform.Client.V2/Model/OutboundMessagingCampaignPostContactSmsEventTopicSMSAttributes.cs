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
    /// OutboundMessagingCampaignPostContactSmsEventTopicSMSAttributes
    /// </summary>
    [DataContract]
    public partial class OutboundMessagingCampaignPostContactSmsEventTopicSMSAttributes :  IEquatable<OutboundMessagingCampaignPostContactSmsEventTopicSMSAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundMessagingCampaignPostContactSmsEventTopicSMSAttributes" /> class.
        /// </summary>
        /// <param name="ContactPhoneNumber">ContactPhoneNumber.</param>
        /// <param name="ContactPhoneNumberColumnName">ContactPhoneNumberColumnName.</param>
        /// <param name="ConfiguredSenderPhoneNumber">ConfiguredSenderPhoneNumber.</param>
        /// <param name="SenderPhoneNumber">SenderPhoneNumber.</param>
        public OutboundMessagingCampaignPostContactSmsEventTopicSMSAttributes(string ContactPhoneNumber = null, string ContactPhoneNumberColumnName = null, string ConfiguredSenderPhoneNumber = null, string SenderPhoneNumber = null)
        {
            this.ContactPhoneNumber = ContactPhoneNumber;
            this.ContactPhoneNumberColumnName = ContactPhoneNumberColumnName;
            this.ConfiguredSenderPhoneNumber = ConfiguredSenderPhoneNumber;
            this.SenderPhoneNumber = SenderPhoneNumber;
            
        }
        


        /// <summary>
        /// Gets or Sets ContactPhoneNumber
        /// </summary>
        [DataMember(Name="contactPhoneNumber", EmitDefaultValue=false)]
        public string ContactPhoneNumber { get; set; }



        /// <summary>
        /// Gets or Sets ContactPhoneNumberColumnName
        /// </summary>
        [DataMember(Name="contactPhoneNumberColumnName", EmitDefaultValue=false)]
        public string ContactPhoneNumberColumnName { get; set; }



        /// <summary>
        /// Gets or Sets ConfiguredSenderPhoneNumber
        /// </summary>
        [DataMember(Name="configuredSenderPhoneNumber", EmitDefaultValue=false)]
        public string ConfiguredSenderPhoneNumber { get; set; }



        /// <summary>
        /// Gets or Sets SenderPhoneNumber
        /// </summary>
        [DataMember(Name="senderPhoneNumber", EmitDefaultValue=false)]
        public string SenderPhoneNumber { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutboundMessagingCampaignPostContactSmsEventTopicSMSAttributes {\n");

            sb.Append("  ContactPhoneNumber: ").Append(ContactPhoneNumber).Append("\n");
            sb.Append("  ContactPhoneNumberColumnName: ").Append(ContactPhoneNumberColumnName).Append("\n");
            sb.Append("  ConfiguredSenderPhoneNumber: ").Append(ConfiguredSenderPhoneNumber).Append("\n");
            sb.Append("  SenderPhoneNumber: ").Append(SenderPhoneNumber).Append("\n");
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
            return this.Equals(obj as OutboundMessagingCampaignPostContactSmsEventTopicSMSAttributes);
        }

        /// <summary>
        /// Returns true if OutboundMessagingCampaignPostContactSmsEventTopicSMSAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of OutboundMessagingCampaignPostContactSmsEventTopicSMSAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutboundMessagingCampaignPostContactSmsEventTopicSMSAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContactPhoneNumber == other.ContactPhoneNumber ||
                    this.ContactPhoneNumber != null &&
                    this.ContactPhoneNumber.Equals(other.ContactPhoneNumber)
                ) &&
                (
                    this.ContactPhoneNumberColumnName == other.ContactPhoneNumberColumnName ||
                    this.ContactPhoneNumberColumnName != null &&
                    this.ContactPhoneNumberColumnName.Equals(other.ContactPhoneNumberColumnName)
                ) &&
                (
                    this.ConfiguredSenderPhoneNumber == other.ConfiguredSenderPhoneNumber ||
                    this.ConfiguredSenderPhoneNumber != null &&
                    this.ConfiguredSenderPhoneNumber.Equals(other.ConfiguredSenderPhoneNumber)
                ) &&
                (
                    this.SenderPhoneNumber == other.SenderPhoneNumber ||
                    this.SenderPhoneNumber != null &&
                    this.SenderPhoneNumber.Equals(other.SenderPhoneNumber)
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
                if (this.ContactPhoneNumber != null)
                    hash = hash * 59 + this.ContactPhoneNumber.GetHashCode();

                if (this.ContactPhoneNumberColumnName != null)
                    hash = hash * 59 + this.ContactPhoneNumberColumnName.GetHashCode();

                if (this.ConfiguredSenderPhoneNumber != null)
                    hash = hash * 59 + this.ConfiguredSenderPhoneNumber.GetHashCode();

                if (this.SenderPhoneNumber != null)
                    hash = hash * 59 + this.SenderPhoneNumber.GetHashCode();

                return hash;
            }
        }
    }

}
