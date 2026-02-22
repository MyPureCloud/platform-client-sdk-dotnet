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
    /// Represents the DMARC verification result for an email domain
    /// </summary>
    [DataContract]
    public partial class DmarcResult :  IEquatable<DmarcResult>
    {
        /// <summary>
        /// The DMARC status of this domain
        /// </summary>
        /// <value>The DMARC status of this domain</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Notpresent for "NotPresent"
            /// </summary>
            [EnumMember(Value = "NotPresent")]
            Notpresent,
            
            /// <summary>
            /// Enum Invalid for "Invalid"
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid,
            
            /// <summary>
            /// Enum Valid for "Valid"
            /// </summary>
            [EnumMember(Value = "Valid")]
            Valid
        }
        /// <summary>
        /// The DMARC policy that was detected in the associated DNS record, if one is present
        /// </summary>
        /// <value>The DMARC policy that was detected in the associated DNS record, if one is present</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DetectedPolicyEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "unknown"
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown,
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None,
            
            /// <summary>
            /// Enum Quarantine for "quarantine"
            /// </summary>
            [EnumMember(Value = "quarantine")]
            Quarantine,
            
            /// <summary>
            /// Enum Reject for "reject"
            /// </summary>
            [EnumMember(Value = "reject")]
            Reject
        }
        /// <summary>
        /// The DMARC status of this domain
        /// </summary>
        /// <value>The DMARC status of this domain</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; private set; }
        /// <summary>
        /// The DMARC policy that was detected in the associated DNS record, if one is present
        /// </summary>
        /// <value>The DMARC policy that was detected in the associated DNS record, if one is present</value>
        [DataMember(Name="detectedPolicy", EmitDefaultValue=false)]
        public DetectedPolicyEnum? DetectedPolicy { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DmarcResult" /> class.
        /// </summary>
        public DmarcResult()
        {
            
        }
        






        /// <summary>
        /// The date of the most recent check of the domain&#39;s DMARC DNS record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date of the most recent check of the domain&#39;s DMARC DNS record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateChecked", EmitDefaultValue=false)]
        public DateTime? DateChecked { get; private set; }



        /// <summary>
        /// The minimum DMARC DNS record that Genesys Cloud recommends
        /// </summary>
        /// <value>The minimum DMARC DNS record that Genesys Cloud recommends</value>
        [DataMember(Name="records", EmitDefaultValue=false)]
        public List<Record> Records { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DmarcResult {\n");

            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DetectedPolicy: ").Append(DetectedPolicy).Append("\n");
            sb.Append("  DateChecked: ").Append(DateChecked).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
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
            return this.Equals(obj as DmarcResult);
        }

        /// <summary>
        /// Returns true if DmarcResult instances are equal
        /// </summary>
        /// <param name="other">Instance of DmarcResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DmarcResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.DetectedPolicy == other.DetectedPolicy ||
                    this.DetectedPolicy != null &&
                    this.DetectedPolicy.Equals(other.DetectedPolicy)
                ) &&
                (
                    this.DateChecked == other.DateChecked ||
                    this.DateChecked != null &&
                    this.DateChecked.Equals(other.DateChecked)
                ) &&
                (
                    this.Records == other.Records ||
                    this.Records != null &&
                    this.Records.SequenceEqual(other.Records)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.DetectedPolicy != null)
                    hash = hash * 59 + this.DetectedPolicy.GetHashCode();

                if (this.DateChecked != null)
                    hash = hash * 59 + this.DateChecked.GetHashCode();

                if (this.Records != null)
                    hash = hash * 59 + this.Records.GetHashCode();

                return hash;
            }
        }
    }

}
