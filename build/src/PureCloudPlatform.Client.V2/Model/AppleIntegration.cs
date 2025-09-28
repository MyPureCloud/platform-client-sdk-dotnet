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
    /// AppleIntegration
    /// </summary>
    [DataContract]
    public partial class AppleIntegration :  IEquatable<AppleIntegration>
    {
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
        /// Status of asynchronous create operation
        /// </summary>
        /// <value>Status of asynchronous create operation</value>
        [DataMember(Name="createStatus", EmitDefaultValue=false)]
        public CreateStatusEnum? CreateStatus { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppleIntegration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppleIntegration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppleIntegration" /> class.
        /// </summary>
        /// <param name="Name">The name of the Apple messaging integration. (required).</param>
        /// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
        /// <param name="MessagingSetting">MessagingSetting.</param>
        /// <param name="MessagesForBusinessId">The Apple Messages for Business Id for the Apple messaging integration. (required).</param>
        /// <param name="BusinessName">The name of the business..</param>
        /// <param name="LogoUrl">The url of the businesses logo..</param>
        /// <param name="Status">The status of the Apple Integration.</param>
        /// <param name="DateCreated">Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">Date this Integration was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="CreatedBy">User reference that created this Integration.</param>
        /// <param name="ModifiedBy">User reference that last modified this Integration.</param>
        public AppleIntegration(string Name = null, SupportedContentReference SupportedContent = null, MessagingSettingReference MessagingSetting = null, string MessagesForBusinessId = null, string BusinessName = null, string LogoUrl = null, string Status = null, DateTime? DateCreated = null, DateTime? DateModified = null, DomainEntityRef CreatedBy = null, DomainEntityRef ModifiedBy = null)
        {
            this.Name = Name;
            this.SupportedContent = SupportedContent;
            this.MessagingSetting = MessagingSetting;
            this.MessagesForBusinessId = MessagesForBusinessId;
            this.BusinessName = BusinessName;
            this.LogoUrl = LogoUrl;
            this.Status = Status;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.CreatedBy = CreatedBy;
            this.ModifiedBy = ModifiedBy;
            
        }
        


        /// <summary>
        /// A unique integration Id.
        /// </summary>
        /// <value>A unique integration Id.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the Apple messaging integration.
        /// </summary>
        /// <value>The name of the Apple messaging integration.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



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
        /// The Apple Messages for Business Id for the Apple messaging integration.
        /// </summary>
        /// <value>The Apple Messages for Business Id for the Apple messaging integration.</value>
        [DataMember(Name="messagesForBusinessId", EmitDefaultValue=false)]
        public string MessagesForBusinessId { get; set; }



        /// <summary>
        /// The name of the business.
        /// </summary>
        /// <value>The name of the business.</value>
        [DataMember(Name="businessName", EmitDefaultValue=false)]
        public string BusinessName { get; set; }



        /// <summary>
        /// The url of the businesses logo.
        /// </summary>
        /// <value>The url of the businesses logo.</value>
        [DataMember(Name="logoUrl", EmitDefaultValue=false)]
        public string LogoUrl { get; set; }



        /// <summary>
        /// The status of the Apple Integration
        /// </summary>
        /// <value>The status of the Apple Integration</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }



        /// <summary>
        /// The recipient associated to the Apple messaging Integration. This recipient is used to associate a flow to an integration
        /// </summary>
        /// <value>The recipient associated to the Apple messaging Integration. This recipient is used to associate a flow to an integration</value>
        [DataMember(Name="recipient", EmitDefaultValue=false)]
        public DomainEntityRef Recipient { get; private set; }



        /// <summary>
        /// Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// Date this Integration was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date this Integration was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
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
        /// Error information returned, if createStatus is set to Error
        /// </summary>
        /// <value>Error information returned, if createStatus is set to Error</value>
        [DataMember(Name="createError", EmitDefaultValue=false)]
        public ErrorBody CreateError { get; private set; }



        /// <summary>
        /// The configuration to control identity resolution.
        /// </summary>
        /// <value>The configuration to control identity resolution.</value>
        [DataMember(Name="identityResolution", EmitDefaultValue=false)]
        public IdentityResolutionConfig IdentityResolution { get; private set; }



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
            sb.Append("class AppleIntegration {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
            sb.Append("  MessagingSetting: ").Append(MessagingSetting).Append("\n");
            sb.Append("  MessagesForBusinessId: ").Append(MessagesForBusinessId).Append("\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  CreateStatus: ").Append(CreateStatus).Append("\n");
            sb.Append("  CreateError: ").Append(CreateError).Append("\n");
            sb.Append("  IdentityResolution: ").Append(IdentityResolution).Append("\n");
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
            return this.Equals(obj as AppleIntegration);
        }

        /// <summary>
        /// Returns true if AppleIntegration instances are equal
        /// </summary>
        /// <param name="other">Instance of AppleIntegration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppleIntegration other)
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
                    this.MessagesForBusinessId == other.MessagesForBusinessId ||
                    this.MessagesForBusinessId != null &&
                    this.MessagesForBusinessId.Equals(other.MessagesForBusinessId)
                ) &&
                (
                    this.BusinessName == other.BusinessName ||
                    this.BusinessName != null &&
                    this.BusinessName.Equals(other.BusinessName)
                ) &&
                (
                    this.LogoUrl == other.LogoUrl ||
                    this.LogoUrl != null &&
                    this.LogoUrl.Equals(other.LogoUrl)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                    this.IdentityResolution == other.IdentityResolution ||
                    this.IdentityResolution != null &&
                    this.IdentityResolution.Equals(other.IdentityResolution)
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

                if (this.MessagesForBusinessId != null)
                    hash = hash * 59 + this.MessagesForBusinessId.GetHashCode();

                if (this.BusinessName != null)
                    hash = hash * 59 + this.BusinessName.GetHashCode();

                if (this.LogoUrl != null)
                    hash = hash * 59 + this.LogoUrl.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

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

                if (this.CreateStatus != null)
                    hash = hash * 59 + this.CreateStatus.GetHashCode();

                if (this.CreateError != null)
                    hash = hash * 59 + this.CreateError.GetHashCode();

                if (this.IdentityResolution != null)
                    hash = hash * 59 + this.IdentityResolution.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
