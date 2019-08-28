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
    /// SCIM Group Reference
    /// </summary>
    [DataContract]
    public partial class ScimV2GroupReference :  IEquatable<ScimV2GroupReference>
    {
        
        
        
        
        
        /// <summary>
        /// SCIM Resource Type of member
        /// </summary>
        /// <value>SCIM Resource Type of member</value>
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
            /// Enum User for "User"
            /// </summary>
            [EnumMember(Value = "User")]
            User,
            
            /// <summary>
            /// Enum Group for "Group"
            /// </summary>
            [EnumMember(Value = "Group")]
            Group,
            
            /// <summary>
            /// Enum Serviceproviderconfig for "ServiceProviderConfig"
            /// </summary>
            [EnumMember(Value = "ServiceProviderConfig")]
            Serviceproviderconfig
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// SCIM Resource Type of member
        /// </summary>
        /// <value>SCIM Resource Type of member</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimV2GroupReference" /> class.
        /// </summary>
        /// <param name="Meta">Resource SCIM meta.</param>
        /// <param name="Value">The ID of the group member. Can be userId or groupId..</param>
        public ScimV2GroupReference(ScimMetadata Meta = null, string Value = null)
        {
            this.Meta = Meta;
            this.Value = Value;
            
        }
        
        
        
        /// <summary>
        /// Resource SCIM meta
        /// </summary>
        /// <value>Resource SCIM meta</value>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public ScimMetadata Meta { get; set; }
        
        
        
        
        
        /// <summary>
        /// The ID of the group member. Can be userId or groupId.
        /// </summary>
        /// <value>The ID of the group member. Can be userId or groupId.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        
        
        
        /// <summary>
        /// Ref to entity
        /// </summary>
        /// <value>Ref to entity</value>
        [DataMember(Name="$ref", EmitDefaultValue=false)]
        public string _Ref { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimV2GroupReference {\n");
            
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  _Ref: ").Append(_Ref).Append("\n");
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
            return this.Equals(obj as ScimV2GroupReference);
        }

        /// <summary>
        /// Returns true if ScimV2GroupReference instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimV2GroupReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimV2GroupReference other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Meta == other.Meta ||
                    this.Meta != null &&
                    this.Meta.Equals(other.Meta)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this._Ref == other._Ref ||
                    this._Ref != null &&
                    this._Ref.Equals(other._Ref)
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
                
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this._Ref != null)
                    hash = hash * 59 + this._Ref.GetHashCode();
                
                return hash;
            }
        }
    }

}
