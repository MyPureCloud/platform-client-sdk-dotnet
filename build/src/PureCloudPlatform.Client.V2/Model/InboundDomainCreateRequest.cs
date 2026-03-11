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
    /// InboundDomainCreateRequest
    /// </summary>
    [DataContract]
    public partial class InboundDomainCreateRequest :  IEquatable<InboundDomainCreateRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="InboundDomainCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InboundDomainCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundDomainCreateRequest" /> class.
        /// </summary>
        /// <param name="Id">Unique Id of the domain such as: example.com (required).</param>
        /// <param name="SubDomain">Indicates if this a PureCloud sub-domain. If true, then the appropriate DNS records are created for sending/receiving email..</param>
        /// <param name="MailFromSettings">The DNS settings if the inbound domain is using a custom Mail From. These settings can only be used on InboundDomains where subDomain is false..</param>
        /// <param name="CustomSMTPServer">The custom SMTP server integration to use when sending outbound emails from this domain..</param>
        /// <param name="ImapSettings">The IMAP server integration and settings to use for processing inbound emails..</param>
        /// <param name="GraphApiSettings">The GraphAPI server integration and settings to use for processing inbound and outbound emails..</param>
        /// <param name="EmailSetting">The email settings to associate with this domain..</param>
        public InboundDomainCreateRequest(string Id = null, bool? SubDomain = null, MailFromResult MailFromSettings = null, DomainEntityRef CustomSMTPServer = null, ImapSettings ImapSettings = null, GraphApiSettings GraphApiSettings = null, EmailSettingReference EmailSetting = null)
        {
            this.Id = Id;
            this.SubDomain = SubDomain;
            this.MailFromSettings = MailFromSettings;
            this.CustomSMTPServer = CustomSMTPServer;
            this.ImapSettings = ImapSettings;
            this.GraphApiSettings = GraphApiSettings;
            this.EmailSetting = EmailSetting;
            
        }
        


        /// <summary>
        /// Unique Id of the domain such as: example.com
        /// </summary>
        /// <value>Unique Id of the domain such as: example.com</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Indicates if this a PureCloud sub-domain. If true, then the appropriate DNS records are created for sending/receiving email.
        /// </summary>
        /// <value>Indicates if this a PureCloud sub-domain. If true, then the appropriate DNS records are created for sending/receiving email.</value>
        [DataMember(Name="subDomain", EmitDefaultValue=false)]
        public bool? SubDomain { get; set; }



        /// <summary>
        /// The DNS settings if the inbound domain is using a custom Mail From. These settings can only be used on InboundDomains where subDomain is false.
        /// </summary>
        /// <value>The DNS settings if the inbound domain is using a custom Mail From. These settings can only be used on InboundDomains where subDomain is false.</value>
        [DataMember(Name="mailFromSettings", EmitDefaultValue=false)]
        public MailFromResult MailFromSettings { get; set; }



        /// <summary>
        /// The custom SMTP server integration to use when sending outbound emails from this domain.
        /// </summary>
        /// <value>The custom SMTP server integration to use when sending outbound emails from this domain.</value>
        [DataMember(Name="customSMTPServer", EmitDefaultValue=false)]
        public DomainEntityRef CustomSMTPServer { get; set; }



        /// <summary>
        /// The IMAP server integration and settings to use for processing inbound emails.
        /// </summary>
        /// <value>The IMAP server integration and settings to use for processing inbound emails.</value>
        [DataMember(Name="imapSettings", EmitDefaultValue=false)]
        public ImapSettings ImapSettings { get; set; }



        /// <summary>
        /// The GraphAPI server integration and settings to use for processing inbound and outbound emails.
        /// </summary>
        /// <value>The GraphAPI server integration and settings to use for processing inbound and outbound emails.</value>
        [DataMember(Name="graphApiSettings", EmitDefaultValue=false)]
        public GraphApiSettings GraphApiSettings { get; set; }



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
            sb.Append("class InboundDomainCreateRequest {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SubDomain: ").Append(SubDomain).Append("\n");
            sb.Append("  MailFromSettings: ").Append(MailFromSettings).Append("\n");
            sb.Append("  CustomSMTPServer: ").Append(CustomSMTPServer).Append("\n");
            sb.Append("  ImapSettings: ").Append(ImapSettings).Append("\n");
            sb.Append("  GraphApiSettings: ").Append(GraphApiSettings).Append("\n");
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
            return this.Equals(obj as InboundDomainCreateRequest);
        }

        /// <summary>
        /// Returns true if InboundDomainCreateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of InboundDomainCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboundDomainCreateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.SubDomain == other.SubDomain ||
                    this.SubDomain != null &&
                    this.SubDomain.Equals(other.SubDomain)
                ) &&
                (
                    this.MailFromSettings == other.MailFromSettings ||
                    this.MailFromSettings != null &&
                    this.MailFromSettings.Equals(other.MailFromSettings)
                ) &&
                (
                    this.CustomSMTPServer == other.CustomSMTPServer ||
                    this.CustomSMTPServer != null &&
                    this.CustomSMTPServer.Equals(other.CustomSMTPServer)
                ) &&
                (
                    this.ImapSettings == other.ImapSettings ||
                    this.ImapSettings != null &&
                    this.ImapSettings.Equals(other.ImapSettings)
                ) &&
                (
                    this.GraphApiSettings == other.GraphApiSettings ||
                    this.GraphApiSettings != null &&
                    this.GraphApiSettings.Equals(other.GraphApiSettings)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.SubDomain != null)
                    hash = hash * 59 + this.SubDomain.GetHashCode();

                if (this.MailFromSettings != null)
                    hash = hash * 59 + this.MailFromSettings.GetHashCode();

                if (this.CustomSMTPServer != null)
                    hash = hash * 59 + this.CustomSMTPServer.GetHashCode();

                if (this.ImapSettings != null)
                    hash = hash * 59 + this.ImapSettings.GetHashCode();

                if (this.GraphApiSettings != null)
                    hash = hash * 59 + this.GraphApiSettings.GetHashCode();

                if (this.EmailSetting != null)
                    hash = hash * 59 + this.EmailSetting.GetHashCode();

                return hash;
            }
        }
    }

}
