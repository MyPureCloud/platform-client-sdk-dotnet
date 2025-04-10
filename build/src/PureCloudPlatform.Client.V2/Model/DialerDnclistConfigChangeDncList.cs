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
    /// DialerDnclistConfigChangeDncList
    /// </summary>
    [DataContract]
    public partial class DialerDnclistConfigChangeDncList :  IEquatable<DialerDnclistConfigChangeDncList>
    {
        /// <summary>
        /// the type of dnc list being created, rds (csv file), gryphon, or dnc.com
        /// </summary>
        /// <value>the type of dnc list being created, rds (csv file), gryphon, or dnc.com</value>
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
        /// Gets or Sets ContactMethod
        /// </summary>
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
            /// Enum Email for "EMAIL"
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            Email,
            
            /// <summary>
            /// Enum Phone for "PHONE"
            /// </summary>
            [EnumMember(Value = "PHONE")]
            Phone
        }
        /// <summary>
        /// the type of dnc list being created, rds (csv file), gryphon, or dnc.com
        /// </summary>
        /// <value>the type of dnc list being created, rds (csv file), gryphon, or dnc.com</value>
        [DataMember(Name="dncSourceType", EmitDefaultValue=false)]
        public DncSourceTypeEnum? DncSourceType { get; set; }
        /// <summary>
        /// Gets or Sets ContactMethod
        /// </summary>
        [DataMember(Name="contactMethod", EmitDefaultValue=false)]
        public ContactMethodEnum? ContactMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerDnclistConfigChangeDncList" /> class.
        /// </summary>
        /// <param name="ImportStatus">ImportStatus.</param>
        /// <param name="Size">the number of phone numbers in the do not call list.</param>
        /// <param name="DncSourceType">the type of dnc list being created, rds (csv file), gryphon, or dnc.com.</param>
        /// <param name="LoginId">the loginId if the dncSourceType is dnc.com.</param>
        /// <param name="DncCodes">the list of dnc.com codes to be treated as DNC.</param>
        /// <param name="LicenseId">the license number if the dncSourceType is gryphon.</param>
        /// <param name="ContactMethod">ContactMethod.</param>
        /// <param name="Division">Division.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="Name">The UI-visible name of the object.</param>
        /// <param name="DateCreated">Creation time of the entity.</param>
        /// <param name="DateModified">Last modified time of the entity.</param>
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        public DialerDnclistConfigChangeDncList(DialerDnclistConfigChangeImportStatus ImportStatus = null, long? Size = null, DncSourceTypeEnum? DncSourceType = null, string LoginId = null, List<string> DncCodes = null, string LicenseId = null, ContactMethodEnum? ContactMethod = null, DialerDnclistConfigChangeUriReference Division = null, Dictionary<string, Object> AdditionalProperties = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null)
        {
            this.ImportStatus = ImportStatus;
            this.Size = Size;
            this.DncSourceType = DncSourceType;
            this.LoginId = LoginId;
            this.DncCodes = DncCodes;
            this.LicenseId = LicenseId;
            this.ContactMethod = ContactMethod;
            this.Division = Division;
            this.AdditionalProperties = AdditionalProperties;
            this.Id = Id;
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Version = Version;
            
        }
        


        /// <summary>
        /// Gets or Sets ImportStatus
        /// </summary>
        [DataMember(Name="importStatus", EmitDefaultValue=false)]
        public DialerDnclistConfigChangeImportStatus ImportStatus { get; set; }



        /// <summary>
        /// the number of phone numbers in the do not call list
        /// </summary>
        /// <value>the number of phone numbers in the do not call list</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }





        /// <summary>
        /// the loginId if the dncSourceType is dnc.com
        /// </summary>
        /// <value>the loginId if the dncSourceType is dnc.com</value>
        [DataMember(Name="loginId", EmitDefaultValue=false)]
        public string LoginId { get; set; }



        /// <summary>
        /// the list of dnc.com codes to be treated as DNC
        /// </summary>
        /// <value>the list of dnc.com codes to be treated as DNC</value>
        [DataMember(Name="dncCodes", EmitDefaultValue=false)]
        public List<string> DncCodes { get; set; }



        /// <summary>
        /// the license number if the dncSourceType is gryphon
        /// </summary>
        /// <value>the license number if the dncSourceType is gryphon</value>
        [DataMember(Name="licenseId", EmitDefaultValue=false)]
        public string LicenseId { get; set; }





        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public DialerDnclistConfigChangeUriReference Division { get; set; }



        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, Object> AdditionalProperties { get; set; }



        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The UI-visible name of the object
        /// </summary>
        /// <value>The UI-visible name of the object</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Creation time of the entity
        /// </summary>
        /// <value>Creation time of the entity</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// Last modified time of the entity
        /// </summary>
        /// <value>Last modified time of the entity</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// Required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>Required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerDnclistConfigChangeDncList {\n");

            sb.Append("  ImportStatus: ").Append(ImportStatus).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  DncSourceType: ").Append(DncSourceType).Append("\n");
            sb.Append("  LoginId: ").Append(LoginId).Append("\n");
            sb.Append("  DncCodes: ").Append(DncCodes).Append("\n");
            sb.Append("  LicenseId: ").Append(LicenseId).Append("\n");
            sb.Append("  ContactMethod: ").Append(ContactMethod).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as DialerDnclistConfigChangeDncList);
        }

        /// <summary>
        /// Returns true if DialerDnclistConfigChangeDncList instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerDnclistConfigChangeDncList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerDnclistConfigChangeDncList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.ContactMethod == other.ContactMethod ||
                    this.ContactMethod != null &&
                    this.ContactMethod.Equals(other.ContactMethod)
                ) &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
                ) &&
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
                if (this.ImportStatus != null)
                    hash = hash * 59 + this.ImportStatus.GetHashCode();

                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();

                if (this.DncSourceType != null)
                    hash = hash * 59 + this.DncSourceType.GetHashCode();

                if (this.LoginId != null)
                    hash = hash * 59 + this.LoginId.GetHashCode();

                if (this.DncCodes != null)
                    hash = hash * 59 + this.DncCodes.GetHashCode();

                if (this.LicenseId != null)
                    hash = hash * 59 + this.LicenseId.GetHashCode();

                if (this.ContactMethod != null)
                    hash = hash * 59 + this.ContactMethod.GetHashCode();

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();

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

                return hash;
            }
        }
    }

}
