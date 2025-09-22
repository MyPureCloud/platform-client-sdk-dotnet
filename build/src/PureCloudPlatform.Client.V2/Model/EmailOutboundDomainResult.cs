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
    /// EmailOutboundDomainResult
    /// </summary>
    [DataContract]
    public partial class EmailOutboundDomainResult :  IEquatable<EmailOutboundDomainResult>
    {
        /// <summary>
        /// Gets or Sets SenderStatus
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SenderStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Requestreceived for "RequestReceived"
            /// </summary>
            [EnumMember(Value = "RequestReceived")]
            Requestreceived,
            
            /// <summary>
            /// Enum Provisionrequestsentvendor for "ProvisionRequestSentVendor"
            /// </summary>
            [EnumMember(Value = "ProvisionRequestSentVendor")]
            Provisionrequestsentvendor,
            
            /// <summary>
            /// Enum Provisioned for "Provisioned"
            /// </summary>
            [EnumMember(Value = "Provisioned")]
            Provisioned,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Deprovisioned for "Deprovisioned"
            /// </summary>
            [EnumMember(Value = "Deprovisioned")]
            Deprovisioned
        }
        /// <summary>
        /// Gets or Sets SenderType
        /// </summary>
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
        /// Gets or Sets SenderStatus
        /// </summary>
        [DataMember(Name="senderStatus", EmitDefaultValue=false)]
        public SenderStatusEnum? SenderStatus { get; set; }
        /// <summary>
        /// Gets or Sets SenderType
        /// </summary>
        [DataMember(Name="senderType", EmitDefaultValue=false)]
        public SenderTypeEnum? SenderType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailOutboundDomainResult" /> class.
        /// </summary>
        /// <param name="DnsCnameBounceRecord">DnsCnameBounceRecord.</param>
        /// <param name="DnsTxtSendingRecord">DnsTxtSendingRecord.</param>
        /// <param name="DomainName">DomainName.</param>
        /// <param name="SenderStatus">SenderStatus.</param>
        /// <param name="SenderType">SenderType.</param>
        /// <param name="EmailSetting">The email settings associated with this domain..</param>
        public EmailOutboundDomainResult(DnsRecordEntry DnsCnameBounceRecord = null, DnsRecordEntry DnsTxtSendingRecord = null, string DomainName = null, SenderStatusEnum? SenderStatus = null, SenderTypeEnum? SenderType = null, EmailSetting EmailSetting = null)
        {
            this.DnsCnameBounceRecord = DnsCnameBounceRecord;
            this.DnsTxtSendingRecord = DnsTxtSendingRecord;
            this.DomainName = DomainName;
            this.SenderStatus = SenderStatus;
            this.SenderType = SenderType;
            this.EmailSetting = EmailSetting;
            
        }
        


        /// <summary>
        /// Gets or Sets DnsCnameBounceRecord
        /// </summary>
        [DataMember(Name="dnsCnameBounceRecord", EmitDefaultValue=false)]
        public DnsRecordEntry DnsCnameBounceRecord { get; set; }



        /// <summary>
        /// Gets or Sets DnsTxtSendingRecord
        /// </summary>
        [DataMember(Name="dnsTxtSendingRecord", EmitDefaultValue=false)]
        public DnsRecordEntry DnsTxtSendingRecord { get; set; }



        /// <summary>
        /// Gets or Sets DomainName
        /// </summary>
        [DataMember(Name="domainName", EmitDefaultValue=false)]
        public string DomainName { get; set; }







        /// <summary>
        /// The email settings associated with this domain.
        /// </summary>
        /// <value>The email settings associated with this domain.</value>
        [DataMember(Name="emailSetting", EmitDefaultValue=false)]
        public EmailSetting EmailSetting { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailOutboundDomainResult {\n");

            sb.Append("  DnsCnameBounceRecord: ").Append(DnsCnameBounceRecord).Append("\n");
            sb.Append("  DnsTxtSendingRecord: ").Append(DnsTxtSendingRecord).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  SenderStatus: ").Append(SenderStatus).Append("\n");
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
            return this.Equals(obj as EmailOutboundDomainResult);
        }

        /// <summary>
        /// Returns true if EmailOutboundDomainResult instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailOutboundDomainResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailOutboundDomainResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DnsCnameBounceRecord == other.DnsCnameBounceRecord ||
                    this.DnsCnameBounceRecord != null &&
                    this.DnsCnameBounceRecord.Equals(other.DnsCnameBounceRecord)
                ) &&
                (
                    this.DnsTxtSendingRecord == other.DnsTxtSendingRecord ||
                    this.DnsTxtSendingRecord != null &&
                    this.DnsTxtSendingRecord.Equals(other.DnsTxtSendingRecord)
                ) &&
                (
                    this.DomainName == other.DomainName ||
                    this.DomainName != null &&
                    this.DomainName.Equals(other.DomainName)
                ) &&
                (
                    this.SenderStatus == other.SenderStatus ||
                    this.SenderStatus != null &&
                    this.SenderStatus.Equals(other.SenderStatus)
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
                if (this.DnsCnameBounceRecord != null)
                    hash = hash * 59 + this.DnsCnameBounceRecord.GetHashCode();

                if (this.DnsTxtSendingRecord != null)
                    hash = hash * 59 + this.DnsTxtSendingRecord.GetHashCode();

                if (this.DomainName != null)
                    hash = hash * 59 + this.DomainName.GetHashCode();

                if (this.SenderStatus != null)
                    hash = hash * 59 + this.SenderStatus.GetHashCode();

                if (this.SenderType != null)
                    hash = hash * 59 + this.SenderType.GetHashCode();

                if (this.EmailSetting != null)
                    hash = hash * 59 + this.EmailSetting.GetHashCode();

                return hash;
            }
        }
    }

}
