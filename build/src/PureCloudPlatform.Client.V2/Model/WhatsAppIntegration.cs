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
    /// WhatsAppIntegration
    /// </summary>
    [DataContract]
    public partial class WhatsAppIntegration :  IEquatable<WhatsAppIntegration>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The status of the WhatsApp Integration
        /// </summary>
        /// <value>The status of the WhatsApp Integration</value>
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
        /// The status code of WhatsApp Integration activation process
        /// </summary>
        /// <value>The status code of WhatsApp Integration activation process</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActivationStatusCodeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Codesent for "CodeSent"
            /// </summary>
            [EnumMember(Value = "CodeSent")]
            Codesent,
            
            /// <summary>
            /// Enum Waitrequired for "WaitRequired"
            /// </summary>
            [EnumMember(Value = "WaitRequired")]
            Waitrequired,
            
            /// <summary>
            /// Enum Activationfailed for "ActivationFailed"
            /// </summary>
            [EnumMember(Value = "ActivationFailed")]
            Activationfailed,
            
            /// <summary>
            /// Enum Codeconfirmed for "CodeConfirmed"
            /// </summary>
            [EnumMember(Value = "CodeConfirmed")]
            Codeconfirmed,
            
            /// <summary>
            /// Enum Confirmationfailed for "ConfirmationFailed"
            /// </summary>
            [EnumMember(Value = "ConfirmationFailed")]
            Confirmationfailed,
            
            /// <summary>
            /// Enum Resendcode for "ResendCode"
            /// </summary>
            [EnumMember(Value = "ResendCode")]
            Resendcode
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
        /// The status of the WhatsApp Integration
        /// </summary>
        /// <value>The status of the WhatsApp Integration</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The status code of WhatsApp Integration activation process
        /// </summary>
        /// <value>The status code of WhatsApp Integration activation process</value>
        [DataMember(Name="activationStatusCode", EmitDefaultValue=false)]
        public ActivationStatusCodeEnum? ActivationStatusCode { get; set; }
        
        
        
        
        
        /// <summary>
        /// Status of asynchronous create operation
        /// </summary>
        /// <value>Status of asynchronous create operation</value>
        [DataMember(Name="createStatus", EmitDefaultValue=false)]
        public CreateStatusEnum? CreateStatus { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppIntegration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WhatsAppIntegration() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppIntegration" /> class.
        /// </summary>
        /// <param name="Name">The name of the WhatsApp integration. (required).</param>
        /// <param name="PhoneNumber">The phone number associated to the whatsApp integration. (required).</param>
        /// <param name="Status">The status of the WhatsApp Integration.</param>
        /// <param name="Recipient">The recipient associated to the WhatsApp Integration. This recipient is used to associate a flow to an integration.</param>
        /// <param name="DateCreated">Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">Date this Integration was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="CreatedBy">User reference that created this Integration.</param>
        /// <param name="ModifiedBy">User reference that last modified this Integration.</param>
        /// <param name="Version">Version number required for updates. (required).</param>
        /// <param name="ActivationErrorInfo">The error information of WhatsApp Integration activation process.</param>
        /// <param name="CreateError">Error information returned, if createStatus is set to Error.</param>
        public WhatsAppIntegration(string Name = null, string PhoneNumber = null, StatusEnum? Status = null, DomainEntityRef Recipient = null, DateTime? DateCreated = null, DateTime? DateModified = null, DomainEntityRef CreatedBy = null, DomainEntityRef ModifiedBy = null, int? Version = null, ErrorBody ActivationErrorInfo = null, ErrorBody CreateError = null)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Status = Status;
            this.Recipient = Recipient;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.CreatedBy = CreatedBy;
            this.ModifiedBy = ModifiedBy;
            this.Version = Version;
            this.ActivationErrorInfo = ActivationErrorInfo;
            this.CreateError = CreateError;
            
        }
        
        
        
        /// <summary>
        /// A unique Integration Id.
        /// </summary>
        /// <value>A unique Integration Id.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The name of the WhatsApp integration.
        /// </summary>
        /// <value>The name of the WhatsApp integration.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The phone number associated to the whatsApp integration.
        /// </summary>
        /// <value>The phone number associated to the whatsApp integration.</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
        
        
        
        
        
        /// <summary>
        /// The recipient associated to the WhatsApp Integration. This recipient is used to associate a flow to an integration
        /// </summary>
        /// <value>The recipient associated to the WhatsApp Integration. This recipient is used to associate a flow to an integration</value>
        [DataMember(Name="recipient", EmitDefaultValue=false)]
        public DomainEntityRef Recipient { get; set; }
        
        
        
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
        /// Version number required for updates.
        /// </summary>
        /// <value>Version number required for updates.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        
        
        /// <summary>
        /// The error information of WhatsApp Integration activation process
        /// </summary>
        /// <value>The error information of WhatsApp Integration activation process</value>
        [DataMember(Name="activationErrorInfo", EmitDefaultValue=false)]
        public ErrorBody ActivationErrorInfo { get; set; }
        
        
        
        
        
        /// <summary>
        /// Error information returned, if createStatus is set to Error
        /// </summary>
        /// <value>Error information returned, if createStatus is set to Error</value>
        [DataMember(Name="createError", EmitDefaultValue=false)]
        public ErrorBody CreateError { get; set; }
        
        
        
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
            sb.Append("class WhatsAppIntegration {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ActivationStatusCode: ").Append(ActivationStatusCode).Append("\n");
            sb.Append("  ActivationErrorInfo: ").Append(ActivationErrorInfo).Append("\n");
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
            return this.Equals(obj as WhatsAppIntegration);
        }

        /// <summary>
        /// Returns true if WhatsAppIntegration instances are equal
        /// </summary>
        /// <param name="other">Instance of WhatsAppIntegration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhatsAppIntegration other)
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
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.ActivationStatusCode == other.ActivationStatusCode ||
                    this.ActivationStatusCode != null &&
                    this.ActivationStatusCode.Equals(other.ActivationStatusCode)
                ) &&
                (
                    this.ActivationErrorInfo == other.ActivationErrorInfo ||
                    this.ActivationErrorInfo != null &&
                    this.ActivationErrorInfo.Equals(other.ActivationErrorInfo)
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
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
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
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.ActivationStatusCode != null)
                    hash = hash * 59 + this.ActivationStatusCode.GetHashCode();
                
                if (this.ActivationErrorInfo != null)
                    hash = hash * 59 + this.ActivationErrorInfo.GetHashCode();
                
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
