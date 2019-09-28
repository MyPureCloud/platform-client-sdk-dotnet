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
    /// LocationDefinition
    /// </summary>
    [DataContract]
    public partial class LocationDefinition :  IEquatable<LocationDefinition>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Current activity status of the location.
        /// </summary>
        /// <value>Current activity status of the location.</value>
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
            /// Enum Deleted for "deleted"
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Current activity status of the location.
        /// </summary>
        /// <value>Current activity status of the location.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LocationDefinition() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationDefinition" /> class.
        /// </summary>
        /// <param name="Name">The name of the Location. (required).</param>
        /// <param name="ContactUser">Site contact for the location.</param>
        /// <param name="EmergencyNumber">EmergencyNumber.</param>
        /// <param name="Address">Address.</param>
        /// <param name="AddressVerified">AddressVerified.</param>
        /// <param name="State">Current activity status of the location..</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="Version">Version.</param>
        /// <param name="Path">A list of ancestor IDs in order.</param>
        /// <param name="ProfileImage">Profile image set for the location.</param>
        /// <param name="FloorplanImage">FloorplanImage.</param>
        public LocationDefinition(string Name = null, AddressableEntityRef ContactUser = null, LocationEmergencyNumber EmergencyNumber = null, LocationAddress Address = null, bool? AddressVerified = null, StateEnum? State = null, string Notes = null, int? Version = null, List<string> Path = null, List<LocationImage> ProfileImage = null, List<LocationImage> FloorplanImage = null)
        {
            this.Name = Name;
            this.ContactUser = ContactUser;
            this.EmergencyNumber = EmergencyNumber;
            this.Address = Address;
            this.AddressVerified = AddressVerified;
            this.State = State;
            this.Notes = Notes;
            this.Version = Version;
            this.Path = Path;
            this.ProfileImage = ProfileImage;
            this.FloorplanImage = FloorplanImage;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The name of the Location.
        /// </summary>
        /// <value>The name of the Location.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Site contact for the location
        /// </summary>
        /// <value>Site contact for the location</value>
        [DataMember(Name="contactUser", EmitDefaultValue=false)]
        public AddressableEntityRef ContactUser { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EmergencyNumber
        /// </summary>
        [DataMember(Name="emergencyNumber", EmitDefaultValue=false)]
        public LocationEmergencyNumber EmergencyNumber { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public LocationAddress Address { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AddressVerified
        /// </summary>
        [DataMember(Name="addressVerified", EmitDefaultValue=false)]
        public bool? AddressVerified { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// A list of ancestor IDs in order
        /// </summary>
        /// <value>A list of ancestor IDs in order</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public List<string> Path { get; set; }
        
        
        
        /// <summary>
        /// Profile image set for the location
        /// </summary>
        /// <value>Profile image set for the location</value>
        [DataMember(Name="profileImage", EmitDefaultValue=false)]
        public List<LocationImage> ProfileImage { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets FloorplanImage
        /// </summary>
        [DataMember(Name="floorplanImage", EmitDefaultValue=false)]
        public List<LocationImage> FloorplanImage { get; set; }
        
        
        
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
            sb.Append("class LocationDefinition {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContactUser: ").Append(ContactUser).Append("\n");
            sb.Append("  EmergencyNumber: ").Append(EmergencyNumber).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AddressVerified: ").Append(AddressVerified).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  ProfileImage: ").Append(ProfileImage).Append("\n");
            sb.Append("  FloorplanImage: ").Append(FloorplanImage).Append("\n");
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
            return this.Equals(obj as LocationDefinition);
        }

        /// <summary>
        /// Returns true if LocationDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of LocationDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationDefinition other)
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
                    this.ContactUser == other.ContactUser ||
                    this.ContactUser != null &&
                    this.ContactUser.Equals(other.ContactUser)
                ) &&
                (
                    this.EmergencyNumber == other.EmergencyNumber ||
                    this.EmergencyNumber != null &&
                    this.EmergencyNumber.Equals(other.EmergencyNumber)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.AddressVerified == other.AddressVerified ||
                    this.AddressVerified != null &&
                    this.AddressVerified.Equals(other.AddressVerified)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.SequenceEqual(other.Path)
                ) &&
                (
                    this.ProfileImage == other.ProfileImage ||
                    this.ProfileImage != null &&
                    this.ProfileImage.SequenceEqual(other.ProfileImage)
                ) &&
                (
                    this.FloorplanImage == other.FloorplanImage ||
                    this.FloorplanImage != null &&
                    this.FloorplanImage.SequenceEqual(other.FloorplanImage)
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
                
                if (this.ContactUser != null)
                    hash = hash * 59 + this.ContactUser.GetHashCode();
                
                if (this.EmergencyNumber != null)
                    hash = hash * 59 + this.EmergencyNumber.GetHashCode();
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.AddressVerified != null)
                    hash = hash * 59 + this.AddressVerified.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                
                if (this.ProfileImage != null)
                    hash = hash * 59 + this.ProfileImage.GetHashCode();
                
                if (this.FloorplanImage != null)
                    hash = hash * 59 + this.FloorplanImage.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
