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
    /// Represents an unassigned or assigned DID in a DID Pool.
    /// </summary>
    [DataContract]
    public partial class DIDNumber :  IEquatable<DIDNumber>
    {
        /// <summary>
        /// The type of the entity that owns this DID.  If the DID is unassigned, this will be NULL.
        /// </summary>
        /// <value>The type of the entity that owns this DID.  If the DID is unassigned, this will be NULL.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OwnerTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum User for "USER"
            /// </summary>
            [EnumMember(Value = "USER")]
            User,
            
            /// <summary>
            /// Enum Phone for "PHONE"
            /// </summary>
            [EnumMember(Value = "PHONE")]
            Phone,
            
            /// <summary>
            /// Enum IvrConfig for "IVR_CONFIG"
            /// </summary>
            [EnumMember(Value = "IVR_CONFIG")]
            IvrConfig,
            
            /// <summary>
            /// Enum Group for "GROUP"
            /// </summary>
            [EnumMember(Value = "GROUP")]
            Group
        }
        /// <summary>
        /// The type of the entity that owns this DID.  If the DID is unassigned, this will be NULL.
        /// </summary>
        /// <value>The type of the entity that owns this DID.  If the DID is unassigned, this will be NULL.</value>
        [DataMember(Name="ownerType", EmitDefaultValue=false)]
        public OwnerTypeEnum? OwnerType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DIDNumber" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Number">The number of the DID formatted as E164..</param>
        /// <param name="Assigned">True if this DID is assigned to an entity.  False otherwise..</param>
        /// <param name="DidPool">A Uri reference to the DID Pool this DID is a part of..</param>
        /// <param name="Owner">A Uri reference to the owner of this DID.  The owner's type can be found in ownerType.  If the DID is unassigned, this will be NULL..</param>
        /// <param name="OwnerType">The type of the entity that owns this DID.  If the DID is unassigned, this will be NULL..</param>
        public DIDNumber(string Name = null, string Number = null, bool? Assigned = null, AddressableEntityRef DidPool = null, DomainEntityRef Owner = null, OwnerTypeEnum? OwnerType = null)
        {
            this.Name = Name;
            this.Number = Number;
            this.Assigned = Assigned;
            this.DidPool = DidPool;
            this.Owner = Owner;
            this.OwnerType = OwnerType;
            
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
        /// The number of the DID formatted as E164.
        /// </summary>
        /// <value>The number of the DID formatted as E164.</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }



        /// <summary>
        /// True if this DID is assigned to an entity.  False otherwise.
        /// </summary>
        /// <value>True if this DID is assigned to an entity.  False otherwise.</value>
        [DataMember(Name="assigned", EmitDefaultValue=false)]
        public bool? Assigned { get; set; }



        /// <summary>
        /// A Uri reference to the DID Pool this DID is a part of.
        /// </summary>
        /// <value>A Uri reference to the DID Pool this DID is a part of.</value>
        [DataMember(Name="didPool", EmitDefaultValue=false)]
        public AddressableEntityRef DidPool { get; set; }



        /// <summary>
        /// A Uri reference to the owner of this DID.  The owner's type can be found in ownerType.  If the DID is unassigned, this will be NULL.
        /// </summary>
        /// <value>A Uri reference to the owner of this DID.  The owner's type can be found in ownerType.  If the DID is unassigned, this will be NULL.</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public DomainEntityRef Owner { get; set; }





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
            sb.Append("class DIDNumber {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Assigned: ").Append(Assigned).Append("\n");
            sb.Append("  DidPool: ").Append(DidPool).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
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
            return this.Equals(obj as DIDNumber);
        }

        /// <summary>
        /// Returns true if DIDNumber instances are equal
        /// </summary>
        /// <param name="other">Instance of DIDNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DIDNumber other)
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
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) &&
                (
                    this.Assigned == other.Assigned ||
                    this.Assigned != null &&
                    this.Assigned.Equals(other.Assigned)
                ) &&
                (
                    this.DidPool == other.DidPool ||
                    this.DidPool != null &&
                    this.DidPool.Equals(other.DidPool)
                ) &&
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) &&
                (
                    this.OwnerType == other.OwnerType ||
                    this.OwnerType != null &&
                    this.OwnerType.Equals(other.OwnerType)
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

                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();

                if (this.Assigned != null)
                    hash = hash * 59 + this.Assigned.GetHashCode();

                if (this.DidPool != null)
                    hash = hash * 59 + this.DidPool.GetHashCode();

                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();

                if (this.OwnerType != null)
                    hash = hash * 59 + this.OwnerType.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
