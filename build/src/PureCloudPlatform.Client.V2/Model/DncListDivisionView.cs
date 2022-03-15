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
    /// DncListDivisionView
    /// </summary>
    [DataContract]
    public partial class DncListDivisionView :  IEquatable<DncListDivisionView>
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
        /// Initializes a new instance of the <see cref="DncListDivisionView" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Division">The division to which this entity belongs..</param>
        /// <param name="ContactMethod">The contact method. Required if dncSourceType is rds..</param>
        public DncListDivisionView(string Name = null, Division Division = null, ContactMethodEnum? ContactMethod = null)
        {
            this.Name = Name;
            this.Division = Division;
            this.ContactMethod = ContactMethod;
            
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
        /// The division to which this entity belongs.
        /// </summary>
        /// <value>The division to which this entity belongs.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public Division Division { get; set; }
        
        
        
        /// <summary>
        /// The status of the import process.
        /// </summary>
        /// <value>The status of the import process.</value>
        [DataMember(Name="importStatus", EmitDefaultValue=false)]
        public ImportStatus ImportStatus { get; private set; }
        
        
        
        /// <summary>
        /// The number of contacts in the DncList.
        /// </summary>
        /// <value>The number of contacts in the DncList.</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; private set; }
        
        
        
        
        
        
        
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
            sb.Append("class DncListDivisionView {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  ImportStatus: ").Append(ImportStatus).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  DncSourceType: ").Append(DncSourceType).Append("\n");
            sb.Append("  ContactMethod: ").Append(ContactMethod).Append("\n");
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
            return this.Equals(obj as DncListDivisionView);
        }

        /// <summary>
        /// Returns true if DncListDivisionView instances are equal
        /// </summary>
        /// <param name="other">Instance of DncListDivisionView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DncListDivisionView other)
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
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
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
                
                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();
                
                if (this.ImportStatus != null)
                    hash = hash * 59 + this.ImportStatus.GetHashCode();
                
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                
                if (this.DncSourceType != null)
                    hash = hash * 59 + this.DncSourceType.GetHashCode();
                
                if (this.ContactMethod != null)
                    hash = hash * 59 + this.ContactMethod.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
