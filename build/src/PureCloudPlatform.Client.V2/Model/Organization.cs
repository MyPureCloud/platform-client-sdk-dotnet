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
    /// Organization
    /// </summary>
    [DataContract]
    public partial class Organization :  IEquatable<Organization>
    {
        /// <summary>
        /// The current state. Examples are active, inactive, deleted.
        /// </summary>
        /// <value>The current state. Examples are active, inactive, deleted.</value>
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
        /// The current state. Examples are active, inactive, deleted.
        /// </summary>
        /// <value>The current state. Examples are active, inactive, deleted.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Organization() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="DefaultLanguage">The default language for this organization. Example: &#39;en&#39;.</param>
        /// <param name="DefaultCountryCode">The default country code for this organization. Example: &#39;US&#39;.</param>
        /// <param name="ThirdPartyURI">ThirdPartyURI.</param>
        /// <param name="Domain">Domain.</param>
        /// <param name="Version">The current version of the organization. (required).</param>
        /// <param name="State">The current state. Examples are active, inactive, deleted..</param>
        /// <param name="DefaultSiteId">DefaultSiteId.</param>
        /// <param name="SupportURI">Email address where support tickets are sent to..</param>
        /// <param name="VoicemailEnabled">VoicemailEnabled.</param>
        /// <param name="Features">The state of features available for the organization..</param>
        public Organization(string Name = null, string DefaultLanguage = null, string DefaultCountryCode = null, string ThirdPartyURI = null, string Domain = null, int? Version = null, StateEnum? State = null, string DefaultSiteId = null, string SupportURI = null, bool? VoicemailEnabled = null, Dictionary<string, bool?> Features = null)
        {
            // to ensure "Version" is required (not null)
            if (Version == null)
            {
                throw new InvalidDataException("Version is a required property for Organization and cannot be null");
            }
            else
            {
                this.Version = Version;
            }
            this.Name = Name;
            this.DefaultLanguage = DefaultLanguage;
            this.DefaultCountryCode = DefaultCountryCode;
            this.ThirdPartyURI = ThirdPartyURI;
            this.Domain = Domain;
            this.State = State;
            this.DefaultSiteId = DefaultSiteId;
            this.SupportURI = SupportURI;
            this.VoicemailEnabled = VoicemailEnabled;
            this.Features = Features;
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
        /// The default language for this organization. Example: &#39;en&#39;
        /// </summary>
        /// <value>The default language for this organization. Example: &#39;en&#39;</value>
        [DataMember(Name="defaultLanguage", EmitDefaultValue=false)]
        public string DefaultLanguage { get; set; }
        /// <summary>
        /// The default country code for this organization. Example: &#39;US&#39;
        /// </summary>
        /// <value>The default country code for this organization. Example: &#39;US&#39;</value>
        [DataMember(Name="defaultCountryCode", EmitDefaultValue=false)]
        public string DefaultCountryCode { get; set; }
        /// <summary>
        /// The short name for the organization. This field is globally unique and cannot be changed.
        /// </summary>
        /// <value>The short name for the organization. This field is globally unique and cannot be changed.</value>
        [DataMember(Name="thirdPartyOrgName", EmitDefaultValue=false)]
        public string ThirdPartyOrgName { get; private set; }
        /// <summary>
        /// Gets or Sets ThirdPartyURI
        /// </summary>
        [DataMember(Name="thirdPartyURI", EmitDefaultValue=false)]
        public string ThirdPartyURI { get; set; }
        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }
        /// <summary>
        /// The current version of the organization.
        /// </summary>
        /// <value>The current version of the organization.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        /// <summary>
        /// Gets or Sets DefaultSiteId
        /// </summary>
        [DataMember(Name="defaultSiteId", EmitDefaultValue=false)]
        public string DefaultSiteId { get; set; }
        /// <summary>
        /// Email address where support tickets are sent to.
        /// </summary>
        /// <value>Email address where support tickets are sent to.</value>
        [DataMember(Name="supportURI", EmitDefaultValue=false)]
        public string SupportURI { get; set; }
        /// <summary>
        /// Gets or Sets VoicemailEnabled
        /// </summary>
        [DataMember(Name="voicemailEnabled", EmitDefaultValue=false)]
        public bool? VoicemailEnabled { get; set; }
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        /// <summary>
        /// The state of features available for the organization.
        /// </summary>
        /// <value>The state of features available for the organization.</value>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public Dictionary<string, bool?> Features { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Organization {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DefaultLanguage: ").Append(DefaultLanguage).Append("\n");
            sb.Append("  DefaultCountryCode: ").Append(DefaultCountryCode).Append("\n");
            sb.Append("  ThirdPartyOrgName: ").Append(ThirdPartyOrgName).Append("\n");
            sb.Append("  ThirdPartyURI: ").Append(ThirdPartyURI).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  DefaultSiteId: ").Append(DefaultSiteId).Append("\n");
            sb.Append("  SupportURI: ").Append(SupportURI).Append("\n");
            sb.Append("  VoicemailEnabled: ").Append(VoicemailEnabled).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
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
            return this.Equals(obj as Organization);
        }

        /// <summary>
        /// Returns true if Organization instances are equal
        /// </summary>
        /// <param name="other">Instance of Organization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Organization other)
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
                    this.DefaultLanguage == other.DefaultLanguage ||
                    this.DefaultLanguage != null &&
                    this.DefaultLanguage.Equals(other.DefaultLanguage)
                ) &&
                (
                    this.DefaultCountryCode == other.DefaultCountryCode ||
                    this.DefaultCountryCode != null &&
                    this.DefaultCountryCode.Equals(other.DefaultCountryCode)
                ) &&
                (
                    this.ThirdPartyOrgName == other.ThirdPartyOrgName ||
                    this.ThirdPartyOrgName != null &&
                    this.ThirdPartyOrgName.Equals(other.ThirdPartyOrgName)
                ) &&
                (
                    this.ThirdPartyURI == other.ThirdPartyURI ||
                    this.ThirdPartyURI != null &&
                    this.ThirdPartyURI.Equals(other.ThirdPartyURI)
                ) &&
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.DefaultSiteId == other.DefaultSiteId ||
                    this.DefaultSiteId != null &&
                    this.DefaultSiteId.Equals(other.DefaultSiteId)
                ) &&
                (
                    this.SupportURI == other.SupportURI ||
                    this.SupportURI != null &&
                    this.SupportURI.Equals(other.SupportURI)
                ) &&
                (
                    this.VoicemailEnabled == other.VoicemailEnabled ||
                    this.VoicemailEnabled != null &&
                    this.VoicemailEnabled.Equals(other.VoicemailEnabled)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.Features == other.Features ||
                    this.Features != null &&
                    this.Features.SequenceEqual(other.Features)
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
                if (this.DefaultLanguage != null)
                    hash = hash * 59 + this.DefaultLanguage.GetHashCode();
                if (this.DefaultCountryCode != null)
                    hash = hash * 59 + this.DefaultCountryCode.GetHashCode();
                if (this.ThirdPartyOrgName != null)
                    hash = hash * 59 + this.ThirdPartyOrgName.GetHashCode();
                if (this.ThirdPartyURI != null)
                    hash = hash * 59 + this.ThirdPartyURI.GetHashCode();
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.DefaultSiteId != null)
                    hash = hash * 59 + this.DefaultSiteId.GetHashCode();
                if (this.SupportURI != null)
                    hash = hash * 59 + this.SupportURI.GetHashCode();
                if (this.VoicemailEnabled != null)
                    hash = hash * 59 + this.VoicemailEnabled.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                if (this.Features != null)
                    hash = hash * 59 + this.Features.GetHashCode();
                return hash;
            }
        }
    }

}
