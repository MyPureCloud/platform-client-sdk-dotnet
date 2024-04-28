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
    /// InboundDomain
    /// </summary>
    [DataContract]
    public partial class InboundDomain :  IEquatable<InboundDomain>
    {
        /// <summary>
        /// Mx Record Status
        /// </summary>
        /// <value>Mx Record Status</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MxRecordStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Valid for "VALID"
            /// </summary>
            [EnumMember(Value = "VALID")]
            Valid,
            
            /// <summary>
            /// Enum Invalid for "INVALID"
            /// </summary>
            [EnumMember(Value = "INVALID")]
            Invalid,
            
            /// <summary>
            /// Enum NotAvailable for "NOT_AVAILABLE"
            /// </summary>
            [EnumMember(Value = "NOT_AVAILABLE")]
            NotAvailable
        }
        /// <summary>
        /// Mx Record Status
        /// </summary>
        /// <value>Mx Record Status</value>
        [DataMember(Name="mxRecordStatus", EmitDefaultValue=false)]
        public MxRecordStatusEnum? MxRecordStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundDomain" /> class.
        /// </summary>
        /// <param name="Id">Unique Id of the domain such as: example.com.</param>
        /// <param name="Name">Name.</param>
        /// <param name="MxRecordStatus">Mx Record Status.</param>
        /// <param name="SubDomain">Indicates if this a PureCloud sub-domain.  If true, then the appropriate DNS records are created for sending/receiving email..</param>
        /// <param name="MailFromSettings">The DNS settings if the inbound domain is using a custom Mail From. These settings can only be used on InboundDomains where subDomain is false..</param>
        /// <param name="CustomSMTPServer">The custom SMTP server integration to use when sending outbound emails from this domain..</param>
        /// <param name="ImapSettings">The IMAP server integration and settings to use for processing inbound emails..</param>
        public InboundDomain(string Id = null, string Name = null, MxRecordStatusEnum? MxRecordStatus = null, bool? SubDomain = null, MailFromResult MailFromSettings = null, DomainEntityRef CustomSMTPServer = null, ImapSettings ImapSettings = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.MxRecordStatus = MxRecordStatus;
            this.SubDomain = SubDomain;
            this.MailFromSettings = MailFromSettings;
            this.CustomSMTPServer = CustomSMTPServer;
            this.ImapSettings = ImapSettings;
            
        }
        


        /// <summary>
        /// Unique Id of the domain such as: example.com
        /// </summary>
        /// <value>Unique Id of the domain such as: example.com</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// Indicates if this a PureCloud sub-domain.  If true, then the appropriate DNS records are created for sending/receiving email.
        /// </summary>
        /// <value>Indicates if this a PureCloud sub-domain.  If true, then the appropriate DNS records are created for sending/receiving email.</value>
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
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InboundDomain {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MxRecordStatus: ").Append(MxRecordStatus).Append("\n");
            sb.Append("  SubDomain: ").Append(SubDomain).Append("\n");
            sb.Append("  MailFromSettings: ").Append(MailFromSettings).Append("\n");
            sb.Append("  CustomSMTPServer: ").Append(CustomSMTPServer).Append("\n");
            sb.Append("  ImapSettings: ").Append(ImapSettings).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as InboundDomain);
        }

        /// <summary>
        /// Returns true if InboundDomain instances are equal
        /// </summary>
        /// <param name="other">Instance of InboundDomain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboundDomain other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.MxRecordStatus == other.MxRecordStatus ||
                    this.MxRecordStatus != null &&
                    this.MxRecordStatus.Equals(other.MxRecordStatus)
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
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.MxRecordStatus != null)
                    hash = hash * 59 + this.MxRecordStatus.GetHashCode();

                if (this.SubDomain != null)
                    hash = hash * 59 + this.SubDomain.GetHashCode();

                if (this.MailFromSettings != null)
                    hash = hash * 59 + this.MailFromSettings.GetHashCode();

                if (this.CustomSMTPServer != null)
                    hash = hash * 59 + this.CustomSMTPServer.GetHashCode();

                if (this.ImapSettings != null)
                    hash = hash * 59 + this.ImapSettings.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
