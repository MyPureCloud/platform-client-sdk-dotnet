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
    /// DnsRecordEntry
    /// </summary>
    [DataContract]
    public partial class DnsRecordEntry :  IEquatable<DnsRecordEntry>
    {
        /// <summary>
        /// the current status of the related verification process
        /// </summary>
        /// <value>the current status of the related verification process</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum VerificationStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Verified for "Verified"
            /// </summary>
            [EnumMember(Value = "Verified")]
            Verified,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// the current status of the related verification process
        /// </summary>
        /// <value>the current status of the related verification process</value>
        [DataMember(Name="verificationStatus", EmitDefaultValue=false)]
        public VerificationStatusEnum? VerificationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DnsRecordEntry" /> class.
        /// </summary>
        /// <param name="Host">the hostname of the DNS entry.</param>
        /// <param name="RecordContents">the payload of the DNS entry.</param>
        /// <param name="VerificationStatus">the current status of the related verification process.</param>
        public DnsRecordEntry(string Host = null, string RecordContents = null, VerificationStatusEnum? VerificationStatus = null)
        {
            this.Host = Host;
            this.RecordContents = RecordContents;
            this.VerificationStatus = VerificationStatus;
            
        }
        


        /// <summary>
        /// the hostname of the DNS entry
        /// </summary>
        /// <value>the hostname of the DNS entry</value>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public string Host { get; set; }



        /// <summary>
        /// the payload of the DNS entry
        /// </summary>
        /// <value>the payload of the DNS entry</value>
        [DataMember(Name="recordContents", EmitDefaultValue=false)]
        public string RecordContents { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DnsRecordEntry {\n");

            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  RecordContents: ").Append(RecordContents).Append("\n");
            sb.Append("  VerificationStatus: ").Append(VerificationStatus).Append("\n");
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
            return this.Equals(obj as DnsRecordEntry);
        }

        /// <summary>
        /// Returns true if DnsRecordEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of DnsRecordEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DnsRecordEntry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Host == other.Host ||
                    this.Host != null &&
                    this.Host.Equals(other.Host)
                ) &&
                (
                    this.RecordContents == other.RecordContents ||
                    this.RecordContents != null &&
                    this.RecordContents.Equals(other.RecordContents)
                ) &&
                (
                    this.VerificationStatus == other.VerificationStatus ||
                    this.VerificationStatus != null &&
                    this.VerificationStatus.Equals(other.VerificationStatus)
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
                if (this.Host != null)
                    hash = hash * 59 + this.Host.GetHashCode();

                if (this.RecordContents != null)
                    hash = hash * 59 + this.RecordContents.GetHashCode();

                if (this.VerificationStatus != null)
                    hash = hash * 59 + this.VerificationStatus.GetHashCode();

                return hash;
            }
        }
    }

}
