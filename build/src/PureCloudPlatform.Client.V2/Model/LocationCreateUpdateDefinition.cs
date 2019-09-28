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
    /// LocationCreateUpdateDefinition
    /// </summary>
    [DataContract]
    public partial class LocationCreateUpdateDefinition :  IEquatable<LocationCreateUpdateDefinition>
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
        /// Initializes a new instance of the <see cref="LocationCreateUpdateDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LocationCreateUpdateDefinition() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationCreateUpdateDefinition" /> class.
        /// </summary>
        /// <param name="Name">The name of the Location. (required).</param>
        /// <param name="Address">Address.</param>
        /// <param name="EmergencyNumber">EmergencyNumber.</param>
        /// <param name="Version">Version.</param>
        /// <param name="State">Current activity status of the location..</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="ContactUser">The user id of the location contact.</param>
        /// <param name="Path">Path.</param>
        /// <param name="AddressVerified">AddressVerified.</param>
        public LocationCreateUpdateDefinition(string Name = null, LocationAddress Address = null, LocationEmergencyNumber EmergencyNumber = null, int? Version = null, StateEnum? State = null, string Notes = null, string ContactUser = null, List<string> Path = null, bool? AddressVerified = null)
        {
            this.Name = Name;
            this.Address = Address;
            this.EmergencyNumber = EmergencyNumber;
            this.Version = Version;
            this.State = State;
            this.Notes = Notes;
            this.ContactUser = ContactUser;
            this.Path = Path;
            this.AddressVerified = AddressVerified;
            
        }
        
        
        
        /// <summary>
        /// The name of the Location.
        /// </summary>
        /// <value>The name of the Location.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public LocationAddress Address { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EmergencyNumber
        /// </summary>
        [DataMember(Name="emergencyNumber", EmitDefaultValue=false)]
        public LocationEmergencyNumber EmergencyNumber { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }
        
        
        
        /// <summary>
        /// The user id of the location contact
        /// </summary>
        /// <value>The user id of the location contact</value>
        [DataMember(Name="contactUser", EmitDefaultValue=false)]
        public string ContactUser { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public List<string> Path { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AddressVerified
        /// </summary>
        [DataMember(Name="addressVerified", EmitDefaultValue=false)]
        public bool? AddressVerified { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationCreateUpdateDefinition {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  EmergencyNumber: ").Append(EmergencyNumber).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  ContactUser: ").Append(ContactUser).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  AddressVerified: ").Append(AddressVerified).Append("\n");
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
            return this.Equals(obj as LocationCreateUpdateDefinition);
        }

        /// <summary>
        /// Returns true if LocationCreateUpdateDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of LocationCreateUpdateDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationCreateUpdateDefinition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.EmergencyNumber == other.EmergencyNumber ||
                    this.EmergencyNumber != null &&
                    this.EmergencyNumber.Equals(other.EmergencyNumber)
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
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) &&
                (
                    this.ContactUser == other.ContactUser ||
                    this.ContactUser != null &&
                    this.ContactUser.Equals(other.ContactUser)
                ) &&
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.SequenceEqual(other.Path)
                ) &&
                (
                    this.AddressVerified == other.AddressVerified ||
                    this.AddressVerified != null &&
                    this.AddressVerified.Equals(other.AddressVerified)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.EmergencyNumber != null)
                    hash = hash * 59 + this.EmergencyNumber.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                
                if (this.ContactUser != null)
                    hash = hash * 59 + this.ContactUser.GetHashCode();
                
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                
                if (this.AddressVerified != null)
                    hash = hash * 59 + this.AddressVerified.GetHashCode();
                
                return hash;
            }
        }
    }

}
