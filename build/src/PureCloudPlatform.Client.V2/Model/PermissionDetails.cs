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
    /// PermissionDetails
    /// </summary>
    [DataContract]
    public partial class PermissionDetails :  IEquatable<PermissionDetails>
    {
        /// <summary>
        /// The type of permission requirement
        /// </summary>
        /// <value>The type of permission requirement</value>
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
            /// Enum Requirescurrentuser for "requiresCurrentUser"
            /// </summary>
            [EnumMember(Value = "requiresCurrentUser")]
            Requirescurrentuser,
            
            /// <summary>
            /// Enum Requirespermissions for "requiresPermissions"
            /// </summary>
            [EnumMember(Value = "requiresPermissions")]
            Requirespermissions,
            
            /// <summary>
            /// Enum Requiresdivisionpermissions for "requiresDivisionPermissions"
            /// </summary>
            [EnumMember(Value = "requiresDivisionPermissions")]
            Requiresdivisionpermissions,
            
            /// <summary>
            /// Enum Requiresanydivisionpermissions for "requiresAnyDivisionPermissions"
            /// </summary>
            [EnumMember(Value = "requiresAnyDivisionPermissions")]
            Requiresanydivisionpermissions,
            
            /// <summary>
            /// Enum Requiresuserbeconversationparticipant for "requiresUserBeConversationParticipant"
            /// </summary>
            [EnumMember(Value = "requiresUserBeConversationParticipant")]
            Requiresuserbeconversationparticipant
        }
        /// <summary>
        /// The type of permission requirement
        /// </summary>
        /// <value>The type of permission requirement</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionDetails" /> class.
        /// </summary>
        /// <param name="Type">The type of permission requirement.</param>
        /// <param name="Permissions">List of required permissions.</param>
        /// <param name="AllowsCurrentUser">Whether the current user can subscribe, when division permissions are otherwise required.</param>
        /// <param name="Enforced">Whether or not this permission requirement is enforced.</param>
        public PermissionDetails(TypeEnum? Type = null, List<string> Permissions = null, bool? AllowsCurrentUser = null, bool? Enforced = null)
        {
            this.Type = Type;
            this.Permissions = Permissions;
            this.AllowsCurrentUser = AllowsCurrentUser;
            this.Enforced = Enforced;
            
        }
        




        /// <summary>
        /// List of required permissions
        /// </summary>
        /// <value>List of required permissions</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<string> Permissions { get; set; }



        /// <summary>
        /// Whether the current user can subscribe, when division permissions are otherwise required
        /// </summary>
        /// <value>Whether the current user can subscribe, when division permissions are otherwise required</value>
        [DataMember(Name="allowsCurrentUser", EmitDefaultValue=false)]
        public bool? AllowsCurrentUser { get; set; }



        /// <summary>
        /// Whether or not this permission requirement is enforced
        /// </summary>
        /// <value>Whether or not this permission requirement is enforced</value>
        [DataMember(Name="enforced", EmitDefaultValue=false)]
        public bool? Enforced { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionDetails {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  AllowsCurrentUser: ").Append(AllowsCurrentUser).Append("\n");
            sb.Append("  Enforced: ").Append(Enforced).Append("\n");
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
            return this.Equals(obj as PermissionDetails);
        }

        /// <summary>
        /// Returns true if PermissionDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of PermissionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissionDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Permissions == other.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.SequenceEqual(other.Permissions)
                ) &&
                (
                    this.AllowsCurrentUser == other.AllowsCurrentUser ||
                    this.AllowsCurrentUser != null &&
                    this.AllowsCurrentUser.Equals(other.AllowsCurrentUser)
                ) &&
                (
                    this.Enforced == other.Enforced ||
                    this.Enforced != null &&
                    this.Enforced.Equals(other.Enforced)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Permissions != null)
                    hash = hash * 59 + this.Permissions.GetHashCode();

                if (this.AllowsCurrentUser != null)
                    hash = hash * 59 + this.AllowsCurrentUser.GetHashCode();

                if (this.Enforced != null)
                    hash = hash * 59 + this.Enforced.GetHashCode();

                return hash;
            }
        }
    }

}
