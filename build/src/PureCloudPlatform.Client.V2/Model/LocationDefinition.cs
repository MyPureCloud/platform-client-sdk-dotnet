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
        /// Current state of the location entity
        /// </summary>
        /// <value>Current state of the location entity</value>
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
        /// Current state of the location entity
        /// </summary>
        /// <value>Current state of the location entity</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationDefinition" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ContactUser">Site contact for the location entity.</param>
        /// <param name="EmergencyNumber">Emergency number for the location entity.</param>
        /// <param name="Address">Address.</param>
        /// <param name="State">Current state of the location entity.</param>
        /// <param name="Notes">Notes for the location entity.</param>
        /// <param name="Version">Current version of the location entity, value to be supplied should be retrieved by a GET or on create/update response.</param>
        /// <param name="Images">Images.</param>
        public LocationDefinition(string Name = null, AddressableEntityRef ContactUser = null, LocationEmergencyNumber EmergencyNumber = null, LocationAddress Address = null, StateEnum? State = null, string Notes = null, int? Version = null, string Images = null)
        {
            this.Name = Name;
            this.ContactUser = ContactUser;
            this.EmergencyNumber = EmergencyNumber;
            this.Address = Address;
            this.State = State;
            this.Notes = Notes;
            this.Version = Version;
            this.Images = Images;
            
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
        /// Site contact for the location entity
        /// </summary>
        /// <value>Site contact for the location entity</value>
        [DataMember(Name="contactUser", EmitDefaultValue=false)]
        public AddressableEntityRef ContactUser { get; set; }



        /// <summary>
        /// Emergency number for the location entity
        /// </summary>
        /// <value>Emergency number for the location entity</value>
        [DataMember(Name="emergencyNumber", EmitDefaultValue=false)]
        public LocationEmergencyNumber EmergencyNumber { get; set; }



        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public LocationAddress Address { get; set; }





        /// <summary>
        /// Notes for the location entity
        /// </summary>
        /// <value>Notes for the location entity</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }



        /// <summary>
        /// Current version of the location entity, value to be supplied should be retrieved by a GET or on create/update response
        /// </summary>
        /// <value>Current version of the location entity, value to be supplied should be retrieved by a GET or on create/update response</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



        /// <summary>
        /// A list of ancestor IDs in order
        /// </summary>
        /// <value>A list of ancestor IDs in order</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public List<string> Path { get; private set; }



        /// <summary>
        /// Profile image of the location entity, retrieved with ?expand=images query parameter
        /// </summary>
        /// <value>Profile image of the location entity, retrieved with ?expand=images query parameter</value>
        [DataMember(Name="profileImage", EmitDefaultValue=false)]
        public List<LocationImage> ProfileImage { get; private set; }



        /// <summary>
        /// Floorplan images of the location entity, retrieved with ?expand=images query parameter
        /// </summary>
        /// <value>Floorplan images of the location entity, retrieved with ?expand=images query parameter</value>
        [DataMember(Name="floorplanImage", EmitDefaultValue=false)]
        public List<LocationImage> FloorplanImage { get; private set; }



        /// <summary>
        /// Address verification information, retrieve dwith the ?expand=addressVerificationDetails query parameter
        /// </summary>
        /// <value>Address verification information, retrieve dwith the ?expand=addressVerificationDetails query parameter</value>
        [DataMember(Name="addressVerificationDetails", EmitDefaultValue=false)]
        public LocationAddressVerificationDetails AddressVerificationDetails { get; private set; }



        /// <summary>
        /// Boolean field which states if the address has been verified as an actual address
        /// </summary>
        /// <value>Boolean field which states if the address has been verified as an actual address</value>
        [DataMember(Name="addressVerified", EmitDefaultValue=false)]
        public bool? AddressVerified { get; private set; }



        /// <summary>
        /// Boolean field which states if the address has been stored for E911
        /// </summary>
        /// <value>Boolean field which states if the address has been stored for E911</value>
        [DataMember(Name="addressStored", EmitDefaultValue=false)]
        public bool? AddressStored { get; private set; }



        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name="images", EmitDefaultValue=false)]
        public string Images { get; set; }



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
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  ProfileImage: ").Append(ProfileImage).Append("\n");
            sb.Append("  FloorplanImage: ").Append(FloorplanImage).Append("\n");
            sb.Append("  AddressVerificationDetails: ").Append(AddressVerificationDetails).Append("\n");
            sb.Append("  AddressVerified: ").Append(AddressVerified).Append("\n");
            sb.Append("  AddressStored: ").Append(AddressStored).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
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
                    this.AddressVerificationDetails == other.AddressVerificationDetails ||
                    this.AddressVerificationDetails != null &&
                    this.AddressVerificationDetails.Equals(other.AddressVerificationDetails)
                ) &&
                (
                    this.AddressVerified == other.AddressVerified ||
                    this.AddressVerified != null &&
                    this.AddressVerified.Equals(other.AddressVerified)
                ) &&
                (
                    this.AddressStored == other.AddressStored ||
                    this.AddressStored != null &&
                    this.AddressStored.Equals(other.AddressStored)
                ) &&
                (
                    this.Images == other.Images ||
                    this.Images != null &&
                    this.Images.Equals(other.Images)
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

                if (this.AddressVerificationDetails != null)
                    hash = hash * 59 + this.AddressVerificationDetails.GetHashCode();

                if (this.AddressVerified != null)
                    hash = hash * 59 + this.AddressVerified.GetHashCode();

                if (this.AddressStored != null)
                    hash = hash * 59 + this.AddressStored.GetHashCode();

                if (this.Images != null)
                    hash = hash * 59 + this.Images.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
