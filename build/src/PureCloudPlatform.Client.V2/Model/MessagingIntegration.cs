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
    /// MessagingIntegration
    /// </summary>
    [DataContract]
    public partial class MessagingIntegration :  IEquatable<MessagingIntegration>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The status of the Integration
        /// </summary>
        /// <value>The status of the Integration</value>
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
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "Inactive"
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Starting for "Starting"
            /// </summary>
            [EnumMember(Value = "Starting")]
            Starting,
            
            /// <summary>
            /// Enum Incomplete for "Incomplete"
            /// </summary>
            [EnumMember(Value = "Incomplete")]
            Incomplete,
            
            /// <summary>
            /// Enum Deleting for "Deleting"
            /// </summary>
            [EnumMember(Value = "Deleting")]
            Deleting,
            
            /// <summary>
            /// Enum Deletionfailed for "DeletionFailed"
            /// </summary>
            [EnumMember(Value = "DeletionFailed")]
            Deletionfailed
        }
        
        
        
        
        /// <summary>
        /// The type of Messaging Integration
        /// </summary>
        /// <value>The type of Messaging Integration</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MessengerTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sms for "sms"
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms,
            
            /// <summary>
            /// Enum Facebook for "facebook"
            /// </summary>
            [EnumMember(Value = "facebook")]
            Facebook,
            
            /// <summary>
            /// Enum Twitter for "twitter"
            /// </summary>
            [EnumMember(Value = "twitter")]
            Twitter,
            
            /// <summary>
            /// Enum Line for "line"
            /// </summary>
            [EnumMember(Value = "line")]
            Line,
            
            /// <summary>
            /// Enum Whatsapp for "whatsapp"
            /// </summary>
            [EnumMember(Value = "whatsapp")]
            Whatsapp,
            
            /// <summary>
            /// Enum Webmessaging for "webmessaging"
            /// </summary>
            [EnumMember(Value = "webmessaging")]
            Webmessaging,
            
            /// <summary>
            /// Enum Instagram for "instagram"
            /// </summary>
            [EnumMember(Value = "instagram")]
            Instagram,
            
            /// <summary>
            /// Enum Open for "open"
            /// </summary>
            [EnumMember(Value = "open")]
            Open
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The status of the Integration
        /// </summary>
        /// <value>The status of the Integration</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        /// <summary>
        /// The type of Messaging Integration
        /// </summary>
        /// <value>The type of Messaging Integration</value>
        [DataMember(Name="messengerType", EmitDefaultValue=false)]
        public MessengerTypeEnum? MessengerType { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingIntegration" /> class.
        /// </summary>
        /// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
        /// <param name="MessagingSetting">MessagingSetting.</param>
        public MessagingIntegration(SupportedContentReference SupportedContent = null, MessagingSettingReference MessagingSetting = null)
        {
            this.SupportedContent = SupportedContent;
            this.MessagingSetting = MessagingSetting;
            
        }
        
        
        
        /// <summary>
        /// A unique Integration Id
        /// </summary>
        /// <value>A unique Integration Id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The name of the Integration
        /// </summary>
        /// <value>The name of the Integration</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }
        
        
        
        /// <summary>
        /// Defines the SupportedContent profile configured for an integration
        /// </summary>
        /// <value>Defines the SupportedContent profile configured for an integration</value>
        [DataMember(Name="supportedContent", EmitDefaultValue=false)]
        public SupportedContentReference SupportedContent { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MessagingSetting
        /// </summary>
        [DataMember(Name="messagingSetting", EmitDefaultValue=false)]
        public MessagingSettingReference MessagingSetting { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// The recipient associated to the Integration. This recipient is used to associate a flow to an integration
        /// </summary>
        /// <value>The recipient associated to the Integration. This recipient is used to associate a flow to an integration</value>
        [DataMember(Name="recipient", EmitDefaultValue=false)]
        public DomainEntityRef Recipient { get; private set; }
        
        
        
        /// <summary>
        /// Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
        
        
        
        /// <summary>
        /// Date this Integration was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date this Integration was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }
        
        
        
        /// <summary>
        /// User reference that created this Integration
        /// </summary>
        /// <value>User reference that created this Integration</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public DomainEntityRef CreatedBy { get; private set; }
        
        
        
        /// <summary>
        /// User reference that last modified this Integration
        /// </summary>
        /// <value>User reference that last modified this Integration</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public DomainEntityRef ModifiedBy { get; private set; }
        
        
        
        /// <summary>
        /// Version number required for updates.
        /// </summary>
        /// <value>Version number required for updates.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }
        
        
        
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
            sb.Append("class MessagingIntegration {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
            sb.Append("  MessagingSetting: ").Append(MessagingSetting).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  MessengerType: ").Append(MessengerType).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as MessagingIntegration);
        }

        /// <summary>
        /// Returns true if MessagingIntegration instances are equal
        /// </summary>
        /// <param name="other">Instance of MessagingIntegration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagingIntegration other)
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
                    this.SupportedContent == other.SupportedContent ||
                    this.SupportedContent != null &&
                    this.SupportedContent.Equals(other.SupportedContent)
                ) &&
                (
                    this.MessagingSetting == other.MessagingSetting ||
                    this.MessagingSetting != null &&
                    this.MessagingSetting.Equals(other.MessagingSetting)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.MessengerType == other.MessengerType ||
                    this.MessengerType != null &&
                    this.MessengerType.Equals(other.MessengerType)
                ) &&
                (
                    this.Recipient == other.Recipient ||
                    this.Recipient != null &&
                    this.Recipient.Equals(other.Recipient)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                
                if (this.SupportedContent != null)
                    hash = hash * 59 + this.SupportedContent.GetHashCode();
                
                if (this.MessagingSetting != null)
                    hash = hash * 59 + this.MessagingSetting.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.MessengerType != null)
                    hash = hash * 59 + this.MessengerType.GetHashCode();
                
                if (this.Recipient != null)
                    hash = hash * 59 + this.Recipient.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
