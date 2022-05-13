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
    /// DncListCreate
    /// </summary>
    [DataContract]
    public partial class DncListCreate :  IEquatable<DncListCreate>
    {
        /// <summary>
        /// The type of the DncList.
        /// </summary>
        /// <value>The type of the DncList.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DncSourceTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Rds for "rds"
            /// </summary>
            [EnumMember(Value = "rds")]
            Rds,
            
            /// <summary>
            /// Enum Dnccom for "dnc.com"
            /// </summary>
            [EnumMember(Value = "dnc.com")]
            Dnccom,
            
            /// <summary>
            /// Enum Gryphon for "gryphon"
            /// </summary>
            [EnumMember(Value = "gryphon")]
            Gryphon
        }
        /// <summary>
        /// The contact method. Required if dncSourceType is rds.
        /// </summary>
        /// <value>The contact method. Required if dncSourceType is rds.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ContactMethodEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Phone for "Phone"
            /// </summary>
            [EnumMember(Value = "Phone")]
            Phone
        }
        /// <summary>
        /// The type of the DncList.
        /// </summary>
        /// <value>The type of the DncList.</value>
        [DataMember(Name="dncSourceType", EmitDefaultValue=false)]
        public DncSourceTypeEnum? DncSourceType { get; set; }
        /// <summary>
        /// The contact method. Required if dncSourceType is rds.
        /// </summary>
        /// <value>The contact method. Required if dncSourceType is rds.</value>
        [DataMember(Name="contactMethod", EmitDefaultValue=false)]
        public ContactMethodEnum? ContactMethod { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DncListCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DncListCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DncListCreate" /> class.
        /// </summary>
        /// <param name="Name">The name of the DncList. (required).</param>
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        /// <param name="DncSourceType">The type of the DncList. (required).</param>
        /// <param name="ContactMethod">The contact method. Required if dncSourceType is rds..</param>
        /// <param name="LoginId">A dnc.com loginId. Required if the dncSourceType is dnc.com..</param>
        /// <param name="DncCodes">The list of dnc.com codes to be treated as DNC. Required if the dncSourceType is dnc.com..</param>
        /// <param name="LicenseId">A gryphon license number. Required if the dncSourceType is gryphon..</param>
        /// <param name="Division">The division this DncList belongs to..</param>
        public DncListCreate(string Name = null, int? Version = null, DncSourceTypeEnum? DncSourceType = null, ContactMethodEnum? ContactMethod = null, string LoginId = null, List<string> DncCodes = null, string LicenseId = null, DomainEntityRef Division = null)
        {
            this.Name = Name;
            this.Version = Version;
            this.DncSourceType = DncSourceType;
            this.ContactMethod = ContactMethod;
            this.LoginId = LoginId;
            this.DncCodes = DncCodes;
            this.LicenseId = LicenseId;
            this.Division = Division;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the DncList.
        /// </summary>
        /// <value>The name of the DncList.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// Required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>Required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



        /// <summary>
        /// The status of the import process
        /// </summary>
        /// <value>The status of the import process</value>
        [DataMember(Name="importStatus", EmitDefaultValue=false)]
        public ImportStatus ImportStatus { get; private set; }



        /// <summary>
        /// The total number of phone numbers in the DncList.
        /// </summary>
        /// <value>The total number of phone numbers in the DncList.</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; private set; }







        /// <summary>
        /// A dnc.com loginId. Required if the dncSourceType is dnc.com.
        /// </summary>
        /// <value>A dnc.com loginId. Required if the dncSourceType is dnc.com.</value>
        [DataMember(Name="loginId", EmitDefaultValue=false)]
        public string LoginId { get; set; }



        /// <summary>
        /// The list of dnc.com codes to be treated as DNC. Required if the dncSourceType is dnc.com.
        /// </summary>
        /// <value>The list of dnc.com codes to be treated as DNC. Required if the dncSourceType is dnc.com.</value>
        [DataMember(Name="dncCodes", EmitDefaultValue=false)]
        public List<string> DncCodes { get; set; }



        /// <summary>
        /// A gryphon license number. Required if the dncSourceType is gryphon.
        /// </summary>
        /// <value>A gryphon license number. Required if the dncSourceType is gryphon.</value>
        [DataMember(Name="licenseId", EmitDefaultValue=false)]
        public string LicenseId { get; set; }



        /// <summary>
        /// The division this DncList belongs to.
        /// </summary>
        /// <value>The division this DncList belongs to.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public DomainEntityRef Division { get; set; }



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
            sb.Append("class DncListCreate {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ImportStatus: ").Append(ImportStatus).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  DncSourceType: ").Append(DncSourceType).Append("\n");
            sb.Append("  ContactMethod: ").Append(ContactMethod).Append("\n");
            sb.Append("  LoginId: ").Append(LoginId).Append("\n");
            sb.Append("  DncCodes: ").Append(DncCodes).Append("\n");
            sb.Append("  LicenseId: ").Append(LicenseId).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
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
            return this.Equals(obj as DncListCreate);
        }

        /// <summary>
        /// Returns true if DncListCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of DncListCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DncListCreate other)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.ImportStatus == other.ImportStatus ||
                    this.ImportStatus != null &&
                    this.ImportStatus.Equals(other.ImportStatus)
                ) &&
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) &&
                (
                    this.DncSourceType == other.DncSourceType ||
                    this.DncSourceType != null &&
                    this.DncSourceType.Equals(other.DncSourceType)
                ) &&
                (
                    this.ContactMethod == other.ContactMethod ||
                    this.ContactMethod != null &&
                    this.ContactMethod.Equals(other.ContactMethod)
                ) &&
                (
                    this.LoginId == other.LoginId ||
                    this.LoginId != null &&
                    this.LoginId.Equals(other.LoginId)
                ) &&
                (
                    this.DncCodes == other.DncCodes ||
                    this.DncCodes != null &&
                    this.DncCodes.SequenceEqual(other.DncCodes)
                ) &&
                (
                    this.LicenseId == other.LicenseId ||
                    this.LicenseId != null &&
                    this.LicenseId.Equals(other.LicenseId)
                ) &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
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

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.ImportStatus != null)
                    hash = hash * 59 + this.ImportStatus.GetHashCode();

                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();

                if (this.DncSourceType != null)
                    hash = hash * 59 + this.DncSourceType.GetHashCode();

                if (this.ContactMethod != null)
                    hash = hash * 59 + this.ContactMethod.GetHashCode();

                if (this.LoginId != null)
                    hash = hash * 59 + this.LoginId.GetHashCode();

                if (this.DncCodes != null)
                    hash = hash * 59 + this.DncCodes.GetHashCode();

                if (this.LicenseId != null)
                    hash = hash * 59 + this.LicenseId.GetHashCode();

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
