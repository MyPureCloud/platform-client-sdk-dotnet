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
    /// GenericSAML
    /// </summary>
    [DataContract]
    public partial class GenericSAML :  IEquatable<GenericSAML>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets NameIdentifierFormat
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NameIdentifierFormatEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Urnoasisnamestcsaml11nameidformatunspecified for "urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified"
            /// </summary>
            [EnumMember(Value = "urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified")]
            Urnoasisnamestcsaml11nameidformatunspecified,
            
            /// <summary>
            /// Enum Urnoasisnamestcsaml11nameidformatemailaddress for "urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress"
            /// </summary>
            [EnumMember(Value = "urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress")]
            Urnoasisnamestcsaml11nameidformatemailaddress,
            
            /// <summary>
            /// Enum Urnoasisnamestcsaml11nameidformatx509subjectname for "urn:oasis:names:tc:SAML:1.1:nameid-format:X509SubjectName"
            /// </summary>
            [EnumMember(Value = "urn:oasis:names:tc:SAML:1.1:nameid-format:X509SubjectName")]
            Urnoasisnamestcsaml11nameidformatx509subjectname,
            
            /// <summary>
            /// Enum Urnoasisnamestcsaml11nameidformatwindowsdomainqualifiedname for "urn:oasis:names:tc:SAML:1.1:nameid-format:WindowsDomainQualifiedName"
            /// </summary>
            [EnumMember(Value = "urn:oasis:names:tc:SAML:1.1:nameid-format:WindowsDomainQualifiedName")]
            Urnoasisnamestcsaml11nameidformatwindowsdomainqualifiedname,
            
            /// <summary>
            /// Enum Urnoasisnamestcsaml20nameidformatkerberos for "urn:oasis:names:tc:SAML:2.0:nameid-format:kerberos"
            /// </summary>
            [EnumMember(Value = "urn:oasis:names:tc:SAML:2.0:nameid-format:kerberos")]
            Urnoasisnamestcsaml20nameidformatkerberos,
            
            /// <summary>
            /// Enum Urnoasisnamestcsaml20nameidformatentity for "urn:oasis:names:tc:SAML:2.0:nameid-format:entity"
            /// </summary>
            [EnumMember(Value = "urn:oasis:names:tc:SAML:2.0:nameid-format:entity")]
            Urnoasisnamestcsaml20nameidformatentity,
            
            /// <summary>
            /// Enum Urnoasisnamestcsaml20nameidformatpersistent for "urn:oasis:names:tc:SAML:2.0:nameid-format:persistent"
            /// </summary>
            [EnumMember(Value = "urn:oasis:names:tc:SAML:2.0:nameid-format:persistent")]
            Urnoasisnamestcsaml20nameidformatpersistent,
            
            /// <summary>
            /// Enum Urnoasisnamestcsaml20nameidformattransient for "urn:oasis:names:tc:SAML:2.0:nameid-format:transient"
            /// </summary>
            [EnumMember(Value = "urn:oasis:names:tc:SAML:2.0:nameid-format:transient")]
            Urnoasisnamestcsaml20nameidformattransient
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets NameIdentifierFormat
        /// </summary>
        [DataMember(Name="nameIdentifierFormat", EmitDefaultValue=false)]
        public NameIdentifierFormatEnum? NameIdentifierFormat { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericSAML" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Disabled">Disabled.</param>
        /// <param name="IssuerURI">IssuerURI.</param>
        /// <param name="SsoTargetURI">SsoTargetURI.</param>
        /// <param name="SloURI">SloURI.</param>
        /// <param name="SloBinding">SloBinding.</param>
        /// <param name="Certificate">Certificate.</param>
        /// <param name="Certificates">Certificates.</param>
        /// <param name="RelyingPartyIdentifier">RelyingPartyIdentifier.</param>
        /// <param name="LogoImageData">LogoImageData.</param>
        /// <param name="EndpointCompression">EndpointCompression.</param>
        /// <param name="NameIdentifierFormat">NameIdentifierFormat.</param>
        public GenericSAML(string Name = null, bool? Disabled = null, string IssuerURI = null, string SsoTargetURI = null, string SloURI = null, string SloBinding = null, string Certificate = null, List<string> Certificates = null, string RelyingPartyIdentifier = null, string LogoImageData = null, bool? EndpointCompression = null, NameIdentifierFormatEnum? NameIdentifierFormat = null)
        {
            this.Name = Name;
            this.Disabled = Disabled;
            this.IssuerURI = IssuerURI;
            this.SsoTargetURI = SsoTargetURI;
            this.SloURI = SloURI;
            this.SloBinding = SloBinding;
            this.Certificate = Certificate;
            this.Certificates = Certificates;
            this.RelyingPartyIdentifier = RelyingPartyIdentifier;
            this.LogoImageData = LogoImageData;
            this.EndpointCompression = EndpointCompression;
            this.NameIdentifierFormat = NameIdentifierFormat;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Disabled
        /// </summary>
        [DataMember(Name="disabled", EmitDefaultValue=false)]
        public bool? Disabled { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets IssuerURI
        /// </summary>
        [DataMember(Name="issuerURI", EmitDefaultValue=false)]
        public string IssuerURI { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SsoTargetURI
        /// </summary>
        [DataMember(Name="ssoTargetURI", EmitDefaultValue=false)]
        public string SsoTargetURI { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SloURI
        /// </summary>
        [DataMember(Name="sloURI", EmitDefaultValue=false)]
        public string SloURI { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SloBinding
        /// </summary>
        [DataMember(Name="sloBinding", EmitDefaultValue=false)]
        public string SloBinding { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Certificate
        /// </summary>
        [DataMember(Name="certificate", EmitDefaultValue=false)]
        public string Certificate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Certificates
        /// </summary>
        [DataMember(Name="certificates", EmitDefaultValue=false)]
        public List<string> Certificates { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RelyingPartyIdentifier
        /// </summary>
        [DataMember(Name="relyingPartyIdentifier", EmitDefaultValue=false)]
        public string RelyingPartyIdentifier { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets LogoImageData
        /// </summary>
        [DataMember(Name="logoImageData", EmitDefaultValue=false)]
        public string LogoImageData { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EndpointCompression
        /// </summary>
        [DataMember(Name="endpointCompression", EmitDefaultValue=false)]
        public bool? EndpointCompression { get; set; }
        
        
        
        
        
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
            sb.Append("class GenericSAML {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  IssuerURI: ").Append(IssuerURI).Append("\n");
            sb.Append("  SsoTargetURI: ").Append(SsoTargetURI).Append("\n");
            sb.Append("  SloURI: ").Append(SloURI).Append("\n");
            sb.Append("  SloBinding: ").Append(SloBinding).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  Certificates: ").Append(Certificates).Append("\n");
            sb.Append("  RelyingPartyIdentifier: ").Append(RelyingPartyIdentifier).Append("\n");
            sb.Append("  LogoImageData: ").Append(LogoImageData).Append("\n");
            sb.Append("  EndpointCompression: ").Append(EndpointCompression).Append("\n");
            sb.Append("  NameIdentifierFormat: ").Append(NameIdentifierFormat).Append("\n");
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
            return this.Equals(obj as GenericSAML);
        }

        /// <summary>
        /// Returns true if GenericSAML instances are equal
        /// </summary>
        /// <param name="other">Instance of GenericSAML to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenericSAML other)
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
                    this.Disabled == other.Disabled ||
                    this.Disabled != null &&
                    this.Disabled.Equals(other.Disabled)
                ) &&
                (
                    this.IssuerURI == other.IssuerURI ||
                    this.IssuerURI != null &&
                    this.IssuerURI.Equals(other.IssuerURI)
                ) &&
                (
                    this.SsoTargetURI == other.SsoTargetURI ||
                    this.SsoTargetURI != null &&
                    this.SsoTargetURI.Equals(other.SsoTargetURI)
                ) &&
                (
                    this.SloURI == other.SloURI ||
                    this.SloURI != null &&
                    this.SloURI.Equals(other.SloURI)
                ) &&
                (
                    this.SloBinding == other.SloBinding ||
                    this.SloBinding != null &&
                    this.SloBinding.Equals(other.SloBinding)
                ) &&
                (
                    this.Certificate == other.Certificate ||
                    this.Certificate != null &&
                    this.Certificate.Equals(other.Certificate)
                ) &&
                (
                    this.Certificates == other.Certificates ||
                    this.Certificates != null &&
                    this.Certificates.SequenceEqual(other.Certificates)
                ) &&
                (
                    this.RelyingPartyIdentifier == other.RelyingPartyIdentifier ||
                    this.RelyingPartyIdentifier != null &&
                    this.RelyingPartyIdentifier.Equals(other.RelyingPartyIdentifier)
                ) &&
                (
                    this.LogoImageData == other.LogoImageData ||
                    this.LogoImageData != null &&
                    this.LogoImageData.Equals(other.LogoImageData)
                ) &&
                (
                    this.EndpointCompression == other.EndpointCompression ||
                    this.EndpointCompression != null &&
                    this.EndpointCompression.Equals(other.EndpointCompression)
                ) &&
                (
                    this.NameIdentifierFormat == other.NameIdentifierFormat ||
                    this.NameIdentifierFormat != null &&
                    this.NameIdentifierFormat.Equals(other.NameIdentifierFormat)
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
                
                if (this.Disabled != null)
                    hash = hash * 59 + this.Disabled.GetHashCode();
                
                if (this.IssuerURI != null)
                    hash = hash * 59 + this.IssuerURI.GetHashCode();
                
                if (this.SsoTargetURI != null)
                    hash = hash * 59 + this.SsoTargetURI.GetHashCode();
                
                if (this.SloURI != null)
                    hash = hash * 59 + this.SloURI.GetHashCode();
                
                if (this.SloBinding != null)
                    hash = hash * 59 + this.SloBinding.GetHashCode();
                
                if (this.Certificate != null)
                    hash = hash * 59 + this.Certificate.GetHashCode();
                
                if (this.Certificates != null)
                    hash = hash * 59 + this.Certificates.GetHashCode();
                
                if (this.RelyingPartyIdentifier != null)
                    hash = hash * 59 + this.RelyingPartyIdentifier.GetHashCode();
                
                if (this.LogoImageData != null)
                    hash = hash * 59 + this.LogoImageData.GetHashCode();
                
                if (this.EndpointCompression != null)
                    hash = hash * 59 + this.EndpointCompression.GetHashCode();
                
                if (this.NameIdentifierFormat != null)
                    hash = hash * 59 + this.NameIdentifierFormat.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
