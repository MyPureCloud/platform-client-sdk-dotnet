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
    /// MailFromResult
    /// </summary>
    [DataContract]
    public partial class MailFromResult :  IEquatable<MailFromResult>
    {
        
        
        /// <summary>
        /// The verification status.
        /// </summary>
        /// <value>The verification status.</value>
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
            /// Enum Failed for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            Failed,
            
            /// <summary>
            /// Enum Pending for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            Pending,
            
            /// <summary>
            /// Enum Verified for "VERIFIED"
            /// </summary>
            [EnumMember(Value = "VERIFIED")]
            Verified,
            
            /// <summary>
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown
        }
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The verification status.
        /// </summary>
        /// <value>The verification status.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MailFromResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MailFromResult() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MailFromResult" /> class.
        /// </summary>
        /// <param name="Status">The verification status..</param>
        /// <param name="Records">The list of DNS records that pertain that need to exist for verification..</param>
        /// <param name="MailFromDomain">The custom MAIL FROM domain. (required).</param>
        public MailFromResult(StatusEnum? Status = null, List<Record> Records = null, string MailFromDomain = null)
        {
            this.Status = Status;
            this.Records = Records;
            this.MailFromDomain = MailFromDomain;
            
        }
        
        
        
        
        
        /// <summary>
        /// The list of DNS records that pertain that need to exist for verification.
        /// </summary>
        /// <value>The list of DNS records that pertain that need to exist for verification.</value>
        [DataMember(Name="records", EmitDefaultValue=false)]
        public List<Record> Records { get; set; }
        
        
        
        /// <summary>
        /// The custom MAIL FROM domain.
        /// </summary>
        /// <value>The custom MAIL FROM domain.</value>
        [DataMember(Name="mailFromDomain", EmitDefaultValue=false)]
        public string MailFromDomain { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailFromResult {\n");
            
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
            sb.Append("  MailFromDomain: ").Append(MailFromDomain).Append("\n");
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
            return this.Equals(obj as MailFromResult);
        }

        /// <summary>
        /// Returns true if MailFromResult instances are equal
        /// </summary>
        /// <param name="other">Instance of MailFromResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailFromResult other)
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
                    this.Records == other.Records ||
                    this.Records != null &&
                    this.Records.SequenceEqual(other.Records)
                ) &&
                (
                    this.MailFromDomain == other.MailFromDomain ||
                    this.MailFromDomain != null &&
                    this.MailFromDomain.Equals(other.MailFromDomain)
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
                
                if (this.Records != null)
                    hash = hash * 59 + this.Records.GetHashCode();
                
                if (this.MailFromDomain != null)
                    hash = hash * 59 + this.MailFromDomain.GetHashCode();
                
                return hash;
            }
        }
    }

}
