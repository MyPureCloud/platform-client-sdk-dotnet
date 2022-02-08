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
    /// TwitterIntegration
    /// </summary>
    [DataContract]
    public partial class TwitterIntegration :  IEquatable<TwitterIntegration>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of twitter account to be used for the integration
        /// </summary>
        /// <value>The type of twitter account to be used for the integration</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TierEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Premium for "premium"
            /// </summary>
            [EnumMember(Value = "premium")]
            Premium,
            
            /// <summary>
            /// Enum Enterprise for "enterprise"
            /// </summary>
            [EnumMember(Value = "enterprise")]
            Enterprise
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Status of asynchronous create operation
        /// </summary>
        /// <value>Status of asynchronous create operation</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CreateStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Initiated for "Initiated"
            /// </summary>
            [EnumMember(Value = "Initiated")]
            Initiated,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of twitter account to be used for the integration
        /// </summary>
        /// <value>The type of twitter account to be used for the integration</value>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public TierEnum? Tier { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Status of asynchronous create operation
        /// </summary>
        /// <value>Status of asynchronous create operation</value>
        [DataMember(Name="createStatus", EmitDefaultValue=false)]
        public CreateStatusEnum? CreateStatus { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterIntegration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TwitterIntegration() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterIntegration" /> class.
        /// </summary>
        /// <param name="Name">The name of the Twitter Integration (required).</param>
        /// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
        /// <param name="AccessTokenKey">The Access Token Key from Twitter messenger (required).</param>
        /// <param name="ConsumerKey">The Consumer Key from Twitter messenger (required).</param>
        /// <param name="Username">The Username from Twitter.</param>
        /// <param name="UserId">The UserId from Twitter.</param>
        /// <param name="Status">The status of the Twitter Integration.</param>
        /// <param name="Tier">The type of twitter account to be used for the integration (required).</param>
        /// <param name="EnvName">The Twitter environment name, e.g.: env-beta (required for premium tier).</param>
        /// <param name="DateCreated">Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">Date this Integration was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="CreatedBy">User reference that created this Integration.</param>
        /// <param name="ModifiedBy">User reference that last modified this Integration.</param>
        /// <param name="Version">Version number required for updates. (required).</param>
        public TwitterIntegration(string Name = null, SupportedContentReference SupportedContent = null, string AccessTokenKey = null, string ConsumerKey = null, string Username = null, string UserId = null, string Status = null, TierEnum? Tier = null, string EnvName = null, DateTime? DateCreated = null, DateTime? DateModified = null, DomainEntityRef CreatedBy = null, DomainEntityRef ModifiedBy = null, int? Version = null)
        {
            this.Name = Name;
            this.SupportedContent = SupportedContent;
            this.AccessTokenKey = AccessTokenKey;
            this.ConsumerKey = ConsumerKey;
            this.Username = Username;
            this.UserId = UserId;
            this.Status = Status;
            this.Tier = Tier;
            this.EnvName = EnvName;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.CreatedBy = CreatedBy;
            this.ModifiedBy = ModifiedBy;
            this.Version = Version;
            
        }
        
        
        
        /// <summary>
        /// A unique Integration Id
        /// </summary>
        /// <value>A unique Integration Id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The name of the Twitter Integration
        /// </summary>
        /// <value>The name of the Twitter Integration</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Defines the SupportedContent profile configured for an integration
        /// </summary>
        /// <value>Defines the SupportedContent profile configured for an integration</value>
        [DataMember(Name="supportedContent", EmitDefaultValue=false)]
        public SupportedContentReference SupportedContent { get; set; }
        
        
        
        /// <summary>
        /// The Access Token Key from Twitter messenger
        /// </summary>
        /// <value>The Access Token Key from Twitter messenger</value>
        [DataMember(Name="accessTokenKey", EmitDefaultValue=false)]
        public string AccessTokenKey { get; set; }
        
        
        
        /// <summary>
        /// The Consumer Key from Twitter messenger
        /// </summary>
        /// <value>The Consumer Key from Twitter messenger</value>
        [DataMember(Name="consumerKey", EmitDefaultValue=false)]
        public string ConsumerKey { get; set; }
        
        
        
        /// <summary>
        /// The Username from Twitter
        /// </summary>
        /// <value>The Username from Twitter</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
        
        
        
        /// <summary>
        /// The UserId from Twitter
        /// </summary>
        /// <value>The UserId from Twitter</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        
        
        
        /// <summary>
        /// The status of the Twitter Integration
        /// </summary>
        /// <value>The status of the Twitter Integration</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        
        
        
        
        
        /// <summary>
        /// The Twitter environment name, e.g.: env-beta (required for premium tier)
        /// </summary>
        /// <value>The Twitter environment name, e.g.: env-beta (required for premium tier)</value>
        [DataMember(Name="envName", EmitDefaultValue=false)]
        public string EnvName { get; set; }
        
        
        
        /// <summary>
        /// The recipient associated to the Twitter Integration. This recipient is used to associate a flow to an integration
        /// </summary>
        /// <value>The recipient associated to the Twitter Integration. This recipient is used to associate a flow to an integration</value>
        [DataMember(Name="recipient", EmitDefaultValue=false)]
        public DomainEntityRef Recipient { get; private set; }
        
        
        
        /// <summary>
        /// Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        
        
        
        /// <summary>
        /// Date this Integration was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date this Integration was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        
        
        
        /// <summary>
        /// User reference that created this Integration
        /// </summary>
        /// <value>User reference that created this Integration</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public DomainEntityRef CreatedBy { get; set; }
        
        
        
        /// <summary>
        /// User reference that last modified this Integration
        /// </summary>
        /// <value>User reference that last modified this Integration</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public DomainEntityRef ModifiedBy { get; set; }
        
        
        
        /// <summary>
        /// Version number required for updates.
        /// </summary>
        /// <value>Version number required for updates.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        
        
        /// <summary>
        /// Error information returned, if createStatus is set to Error
        /// </summary>
        /// <value>Error information returned, if createStatus is set to Error</value>
        [DataMember(Name="createError", EmitDefaultValue=false)]
        public ErrorBody CreateError { get; private set; }
        
        
        
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
            sb.Append("class TwitterIntegration {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
            sb.Append("  AccessTokenKey: ").Append(AccessTokenKey).Append("\n");
            sb.Append("  ConsumerKey: ").Append(ConsumerKey).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  EnvName: ").Append(EnvName).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  CreateStatus: ").Append(CreateStatus).Append("\n");
            sb.Append("  CreateError: ").Append(CreateError).Append("\n");
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
            return this.Equals(obj as TwitterIntegration);
        }

        /// <summary>
        /// Returns true if TwitterIntegration instances are equal
        /// </summary>
        /// <param name="other">Instance of TwitterIntegration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TwitterIntegration other)
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
                    this.AccessTokenKey == other.AccessTokenKey ||
                    this.AccessTokenKey != null &&
                    this.AccessTokenKey.Equals(other.AccessTokenKey)
                ) &&
                (
                    this.ConsumerKey == other.ConsumerKey ||
                    this.ConsumerKey != null &&
                    this.ConsumerKey.Equals(other.ConsumerKey)
                ) &&
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Tier == other.Tier ||
                    this.Tier != null &&
                    this.Tier.Equals(other.Tier)
                ) &&
                (
                    this.EnvName == other.EnvName ||
                    this.EnvName != null &&
                    this.EnvName.Equals(other.EnvName)
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
                    this.CreateStatus == other.CreateStatus ||
                    this.CreateStatus != null &&
                    this.CreateStatus.Equals(other.CreateStatus)
                ) &&
                (
                    this.CreateError == other.CreateError ||
                    this.CreateError != null &&
                    this.CreateError.Equals(other.CreateError)
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
                
                if (this.AccessTokenKey != null)
                    hash = hash * 59 + this.AccessTokenKey.GetHashCode();
                
                if (this.ConsumerKey != null)
                    hash = hash * 59 + this.ConsumerKey.GetHashCode();
                
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Tier != null)
                    hash = hash * 59 + this.Tier.GetHashCode();
                
                if (this.EnvName != null)
                    hash = hash * 59 + this.EnvName.GetHashCode();
                
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
                
                if (this.CreateStatus != null)
                    hash = hash * 59 + this.CreateStatus.GetHashCode();
                
                if (this.CreateError != null)
                    hash = hash * 59 + this.CreateError.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
