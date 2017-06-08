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
    /// GroupContact
    /// </summary>
    [DataContract]
    public partial class GroupContact :  IEquatable<GroupContact>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// Contact type of the address
        /// </summary>
        /// <value>Contact type of the address</value>
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
            /// Enum Groupring for "GROUPRING"
            /// </summary>
            [EnumMember(Value = "GROUPRING")]
            Groupring,
            
            /// <summary>
            /// Enum Groupphone for "GROUPPHONE"
            /// </summary>
            [EnumMember(Value = "GROUPPHONE")]
            Groupphone
        }
        
        
        
        
        /// <summary>
        /// Media type of the address
        /// </summary>
        /// <value>Media type of the address</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Phone for "PHONE"
            /// </summary>
            [EnumMember(Value = "PHONE")]
            Phone
        }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Contact type of the address
        /// </summary>
        /// <value>Contact type of the address</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        /// <summary>
        /// Media type of the address
        /// </summary>
        /// <value>Media type of the address</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupContact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupContact() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupContact" /> class.
        /// </summary>
        
        
        /// <param name="Address">Phone number for this contact type (required).</param>
        
        
        
        
        
        /// <param name="Type">Contact type of the address (required).</param>
        
        
        
        /// <param name="MediaType">Media type of the address (required).</param>
        
        
        public GroupContact(string Address = null, TypeEnum? Type = null, MediaTypeEnum? MediaType = null)
        {
            
            
            
            // to ensure "Address" is required (not null)
            if (Address == null)
            {
                throw new InvalidDataException("Address is a required property for GroupContact and cannot be null");
            }
            else
            {
                this.Address = Address;
            }
            
            
            
            
            
            
            
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for GroupContact and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            
            
            
            
            
            // to ensure "MediaType" is required (not null)
            if (MediaType == null)
            {
                throw new InvalidDataException("MediaType is a required property for GroupContact and cannot be null");
            }
            else
            {
                this.MediaType = MediaType;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Phone number for this contact type
        /// </summary>
        /// <value>Phone number for this contact type</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
        
        
        
        /// <summary>
        /// Formatted version of the address property
        /// </summary>
        /// <value>Formatted version of the address property</value>
        [DataMember(Name="display", EmitDefaultValue=false)]
        public string Display { get; private set; }
        
        
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupContact {\n");
            
            sb.Append("  Address: ").Append(Address).Append("\n");
            
            sb.Append("  Display: ").Append(Display).Append("\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            
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
            return this.Equals(obj as GroupContact);
        }

        /// <summary>
        /// Returns true if GroupContact instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupContact other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.Display == other.Display ||
                    this.Display != null &&
                    this.Display.Equals(other.Display)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
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
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.Display != null)
                    hash = hash * 59 + this.Display.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                
                return hash;
            }
        }
    }

}
