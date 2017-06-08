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
    /// A certificate authority represents an organization that has issued a digital certificate for making secure connections with an edge device.
    /// </summary>
    [DataContract]
    public partial class DomainCertificateAuthority :  IEquatable<DomainCertificateAuthority>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "inactive"
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Deleted for "deleted"
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The certificate authorities type.  Managed certificate authorities are generated and maintained by Interactive Intelligence.  These are read-only and not modifiable by clients.  Remote authorities are customer managed.
        /// </summary>
        /// <value>The certificate authorities type.  Managed certificate authorities are generated and maintained by Interactive Intelligence.  These are read-only and not modifiable by clients.  Remote authorities are customer managed.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Managed for "MANAGED"
            /// </summary>
            [EnumMember(Value = "MANAGED")]
            Managed,
            
            /// <summary>
            /// Enum Remote for "REMOTE"
            /// </summary>
            [EnumMember(Value = "REMOTE")]
            Remote
        }
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ServicesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sip for "SIP"
            /// </summary>
            [EnumMember(Value = "SIP")]
            Sip,
            
            /// <summary>
            /// Enum Provision for "PROVISION"
            /// </summary>
            [EnumMember(Value = "PROVISION")]
            Provision,
            
            /// <summary>
            /// Enum ProvisionPhone for "PROVISION_PHONE"
            /// </summary>
            [EnumMember(Value = "PROVISION_PHONE")]
            ProvisionPhone
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The certificate authorities type.  Managed certificate authorities are generated and maintained by Interactive Intelligence.  These are read-only and not modifiable by clients.  Remote authorities are customer managed.
        /// </summary>
        /// <value>The certificate authorities type.  Managed certificate authorities are generated and maintained by Interactive Intelligence.  These are read-only and not modifiable by clients.  Remote authorities are customer managed.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainCertificateAuthority" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DomainCertificateAuthority() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainCertificateAuthority" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Name">The name of the entity. (required).</param>
        
        
        
        /// <param name="Description">Description.</param>
        
        
        
        /// <param name="Version">Version.</param>
        
        
        
        /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="ModifiedBy">ModifiedBy.</param>
        
        
        
        /// <param name="CreatedBy">CreatedBy.</param>
        
        
        
        /// <param name="State">State.</param>
        
        
        
        /// <param name="ModifiedByApp">ModifiedByApp.</param>
        
        
        
        /// <param name="CreatedByApp">CreatedByApp.</param>
        
        
        
        /// <param name="Certificate">The authorities signed X509 PEM encoded certificate. (required).</param>
        
        
        
        /// <param name="Type">The certificate authorities type.  Managed certificate authorities are generated and maintained by Interactive Intelligence.  These are read-only and not modifiable by clients.  Remote authorities are customer managed. (required).</param>
        
        
        
        /// <param name="Services">The service(s) that the authority can be used to authenticate. (required).</param>
        
        
        
        /// <param name="CertificateDetails">The details of the parsed certificate(s)..</param>
        
        
        
        
        public DomainCertificateAuthority(string Name = null, string Description = null, int? Version = null, DateTime? DateCreated = null, DateTime? DateModified = null, string ModifiedBy = null, string CreatedBy = null, StateEnum? State = null, string ModifiedByApp = null, string CreatedByApp = null, string Certificate = null, TypeEnum? Type = null, List<ServicesEnum> Services = null, List<CertificateDetails> CertificateDetails = null)
        {
            
            
            
            
            
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for DomainCertificateAuthority and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            // to ensure "Certificate" is required (not null)
            if (Certificate == null)
            {
                throw new InvalidDataException("Certificate is a required property for DomainCertificateAuthority and cannot be null");
            }
            else
            {
                this.Certificate = Certificate;
            }
            
            
            
            
            
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for DomainCertificateAuthority and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            
            
            
            
            
            // to ensure "Services" is required (not null)
            if (Services == null)
            {
                throw new InvalidDataException("Services is a required property for DomainCertificateAuthority and cannot be null");
            }
            else
            {
                this.Services = Services;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Description = Description;
            
            
            
            
            
            
            
            
this.Version = Version;
            
            
            
            
            
            
            
            
this.DateCreated = DateCreated;
            
            
            
            
            
            
            
            
this.DateModified = DateModified;
            
            
            
            
            
            
            
            
this.ModifiedBy = ModifiedBy;
            
            
            
            
            
            
            
            
this.CreatedBy = CreatedBy;
            
            
            
            
            
            
            
            
this.State = State;
            
            
            
            
            
            
            
            
this.ModifiedByApp = ModifiedByApp;
            
            
            
            
            
            
            
            
this.CreatedByApp = CreatedByApp;
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.CertificateDetails = CertificateDetails;
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The name of the entity.
        /// </summary>
        /// <value>The name of the entity.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ModifiedByApp
        /// </summary>
        [DataMember(Name="modifiedByApp", EmitDefaultValue=false)]
        public string ModifiedByApp { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CreatedByApp
        /// </summary>
        [DataMember(Name="createdByApp", EmitDefaultValue=false)]
        public string CreatedByApp { get; set; }
        
        
        
        /// <summary>
        /// The authorities signed X509 PEM encoded certificate.
        /// </summary>
        /// <value>The authorities signed X509 PEM encoded certificate.</value>
        [DataMember(Name="certificate", EmitDefaultValue=false)]
        public string Certificate { get; set; }
        
        
        
        
        
        /// <summary>
        /// The service(s) that the authority can be used to authenticate.
        /// </summary>
        /// <value>The service(s) that the authority can be used to authenticate.</value>
        [DataMember(Name="services", EmitDefaultValue=false)]
        public List<ServicesEnum> Services { get; set; }
        
        
        
        /// <summary>
        /// The details of the parsed certificate(s).
        /// </summary>
        /// <value>The details of the parsed certificate(s).</value>
        [DataMember(Name="certificateDetails", EmitDefaultValue=false)]
        public List<CertificateDetails> CertificateDetails { get; set; }
        
        
        
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
            sb.Append("class DomainCertificateAuthority {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  Description: ").Append(Description).Append("\n");
            
            sb.Append("  Version: ").Append(Version).Append("\n");
            
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            
            sb.Append("  State: ").Append(State).Append("\n");
            
            sb.Append("  ModifiedByApp: ").Append(ModifiedByApp).Append("\n");
            
            sb.Append("  CreatedByApp: ").Append(CreatedByApp).Append("\n");
            
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            
            sb.Append("  Services: ").Append(Services).Append("\n");
            
            sb.Append("  CertificateDetails: ").Append(CertificateDetails).Append("\n");
            
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as DomainCertificateAuthority);
        }

        /// <summary>
        /// Returns true if DomainCertificateAuthority instances are equal
        /// </summary>
        /// <param name="other">Instance of DomainCertificateAuthority to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainCertificateAuthority other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.ModifiedByApp == other.ModifiedByApp ||
                    this.ModifiedByApp != null &&
                    this.ModifiedByApp.Equals(other.ModifiedByApp)
                ) &&
                (
                    this.CreatedByApp == other.CreatedByApp ||
                    this.CreatedByApp != null &&
                    this.CreatedByApp.Equals(other.CreatedByApp)
                ) &&
                (
                    this.Certificate == other.Certificate ||
                    this.Certificate != null &&
                    this.Certificate.Equals(other.Certificate)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Services == other.Services ||
                    this.Services != null &&
                    this.Services.SequenceEqual(other.Services)
                ) &&
                (
                    this.CertificateDetails == other.CertificateDetails ||
                    this.CertificateDetails != null &&
                    this.CertificateDetails.SequenceEqual(other.CertificateDetails)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.ModifiedByApp != null)
                    hash = hash * 59 + this.ModifiedByApp.GetHashCode();
                
                if (this.CreatedByApp != null)
                    hash = hash * 59 + this.CreatedByApp.GetHashCode();
                
                if (this.Certificate != null)
                    hash = hash * 59 + this.Certificate.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Services != null)
                    hash = hash * 59 + this.Services.GetHashCode();
                
                if (this.CertificateDetails != null)
                    hash = hash * 59 + this.CertificateDetails.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
