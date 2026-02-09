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
    /// OutboundDomainPatchRequest
    /// </summary>
    [DataContract]
    public partial class OutboundDomainPatchRequest :  IEquatable<OutboundDomainPatchRequest>
    {
        /// <summary>
        /// Sender Type
        /// </summary>
        /// <value>Sender Type</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SenderTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Emaildomain for "EmailDomain"
            /// </summary>
            [EnumMember(Value = "EmailDomain")]
            Emaildomain,
            
            /// <summary>
            /// Enum Mockemaildomain for "MockEmailDomain"
            /// </summary>
            [EnumMember(Value = "MockEmailDomain")]
            Mockemaildomain,
            
            /// <summary>
            /// Enum Emailsmtpdomain for "EmailSmtpDomain"
            /// </summary>
            [EnumMember(Value = "EmailSmtpDomain")]
            Emailsmtpdomain
        }
        /// <summary>
        /// Sender Type
        /// </summary>
        /// <value>Sender Type</value>
        [DataMember(Name="senderType", EmitDefaultValue=false)]
        public SenderTypeEnum? SenderType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundDomainPatchRequest" /> class.
        /// </summary>
        /// <param name="CustomSMTPServer">The custom SMTP server integration to use when sending outbound emails from this domain..</param>
        /// <param name="SenderType">Sender Type.</param>
        /// <param name="EmailSetting">The email settings to associate with this domain..</param>
        public OutboundDomainPatchRequest(CustomSmtpServerRequest CustomSMTPServer = null, SenderTypeEnum? SenderType = null, EmailSettingReference EmailSetting = null)
        {
            this.CustomSMTPServer = CustomSMTPServer;
            this.SenderType = SenderType;
            this.EmailSetting = EmailSetting;
            
        }
        


        /// <summary>
        /// The custom SMTP server integration to use when sending outbound emails from this domain.
        /// </summary>
        /// <value>The custom SMTP server integration to use when sending outbound emails from this domain.</value>
        [DataMember(Name="customSMTPServer", EmitDefaultValue=false)]
        public CustomSmtpServerRequest CustomSMTPServer { get; set; }





        /// <summary>
        /// The email settings to associate with this domain.
        /// </summary>
        /// <value>The email settings to associate with this domain.</value>
        [DataMember(Name="emailSetting", EmitDefaultValue=false)]
        public EmailSettingReference EmailSetting { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutboundDomainPatchRequest {\n");

            sb.Append("  CustomSMTPServer: ").Append(CustomSMTPServer).Append("\n");
            sb.Append("  SenderType: ").Append(SenderType).Append("\n");
            sb.Append("  EmailSetting: ").Append(EmailSetting).Append("\n");
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
            return this.Equals(obj as OutboundDomainPatchRequest);
        }

        /// <summary>
        /// Returns true if OutboundDomainPatchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of OutboundDomainPatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutboundDomainPatchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CustomSMTPServer == other.CustomSMTPServer ||
                    this.CustomSMTPServer != null &&
                    this.CustomSMTPServer.Equals(other.CustomSMTPServer)
                ) &&
                (
                    this.SenderType == other.SenderType ||
                    this.SenderType != null &&
                    this.SenderType.Equals(other.SenderType)
                ) &&
                (
                    this.EmailSetting == other.EmailSetting ||
                    this.EmailSetting != null &&
                    this.EmailSetting.Equals(other.EmailSetting)
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
                if (this.CustomSMTPServer != null)
                    hash = hash * 59 + this.CustomSMTPServer.GetHashCode();

                if (this.SenderType != null)
                    hash = hash * 59 + this.SenderType.GetHashCode();

                if (this.EmailSetting != null)
                    hash = hash * 59 + this.EmailSetting.GetHashCode();

                return hash;
            }
        }
    }

}
