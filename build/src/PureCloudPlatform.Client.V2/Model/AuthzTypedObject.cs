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
    /// AuthzTypedObject
    /// </summary>
    [DataContract]
    public partial class AuthzTypedObject :  IEquatable<AuthzTypedObject>
    {
        
        
        
        
        
        /// <summary>
        /// The type of the object.
        /// </summary>
        /// <value>The type of the object.</value>
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
            /// Enum Queue for "QUEUE"
            /// </summary>
            [EnumMember(Value = "QUEUE")]
            Queue,
            
            /// <summary>
            /// Enum Campaign for "CAMPAIGN"
            /// </summary>
            [EnumMember(Value = "CAMPAIGN")]
            Campaign,
            
            /// <summary>
            /// Enum Contactlist for "CONTACTLIST"
            /// </summary>
            [EnumMember(Value = "CONTACTLIST")]
            Contactlist,
            
            /// <summary>
            /// Enum Dnclist for "DNCLIST"
            /// </summary>
            [EnumMember(Value = "DNCLIST")]
            Dnclist,
            
            /// <summary>
            /// Enum Managementunit for "MANAGEMENTUNIT"
            /// </summary>
            [EnumMember(Value = "MANAGEMENTUNIT")]
            Managementunit,
            
            /// <summary>
            /// Enum Flow for "FLOW"
            /// </summary>
            [EnumMember(Value = "FLOW")]
            Flow,
            
            /// <summary>
            /// Enum User for "USER"
            /// </summary>
            [EnumMember(Value = "USER")]
            User
        }
        
        
        
        
        
        
        
        /// <summary>
        /// The type of the object.
        /// </summary>
        /// <value>The type of the object.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzTypedObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthzTypedObject() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzTypedObject" /> class.
        /// </summary>
        
        
        /// <param name="Id">The identifier associated with the object. (required).</param>
        
        
        
        /// <param name="Type">The type of the object. (required).</param>
        
        
        public AuthzTypedObject(string Id = null, TypeEnum? Type = null)
        {
            
            
            
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for AuthzTypedObject and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            
            
            
            
            
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for AuthzTypedObject and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            
            
            
            
            
            
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The identifier associated with the object.
        /// </summary>
        /// <value>The identifier associated with the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthzTypedObject {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            
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
            return this.Equals(obj as AuthzTypedObject);
        }

        /// <summary>
        /// Returns true if AuthzTypedObject instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthzTypedObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthzTypedObject other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                return hash;
            }
        }
    }

}
