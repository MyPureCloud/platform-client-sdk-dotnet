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
    /// AuditQueryEntity
    /// </summary>
    [DataContract]
    public partial class AuditQueryEntity :  IEquatable<AuditQueryEntity>
    {
        
        
        /// <summary>
        /// Name of the Entity
        /// </summary>
        /// <value>Name of the Entity</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NameEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Document for "Document"
            /// </summary>
            [EnumMember(Value = "Document")]
            Document,
            
            /// <summary>
            /// Enum Queue for "Queue"
            /// </summary>
            [EnumMember(Value = "Queue")]
            Queue,
            
            /// <summary>
            /// Enum Recording for "Recording"
            /// </summary>
            [EnumMember(Value = "Recording")]
            Recording,
            
            /// <summary>
            /// Enum Role for "Role"
            /// </summary>
            [EnumMember(Value = "Role")]
            Role,
            
            /// <summary>
            /// Enum Voicemailuserpolicy for "VoicemailUserPolicy"
            /// </summary>
            [EnumMember(Value = "VoicemailUserPolicy")]
            Voicemailuserpolicy,
            
            /// <summary>
            /// Enum Wrapupcode for "WrapupCode"
            /// </summary>
            [EnumMember(Value = "WrapupCode")]
            Wrapupcode,
            
            /// <summary>
            /// Enum Accesstoken for "AccessToken"
            /// </summary>
            [EnumMember(Value = "AccessToken")]
            Accesstoken,
            
            /// <summary>
            /// Enum Oauthclient for "OAuthClient"
            /// </summary>
            [EnumMember(Value = "OAuthClient")]
            Oauthclient,
            
            /// <summary>
            /// Enum Oauthclientauthorization for "OAuthClientAuthorization"
            /// </summary>
            [EnumMember(Value = "OAuthClientAuthorization")]
            Oauthclientauthorization,
            
            /// <summary>
            /// Enum Authorganization for "AuthOrganization"
            /// </summary>
            [EnumMember(Value = "AuthOrganization")]
            Authorganization,
            
            /// <summary>
            /// Enum Authuser for "AuthUser"
            /// </summary>
            [EnumMember(Value = "AuthUser")]
            Authuser,
            
            /// <summary>
            /// Enum Bulkactions for "BulkActions"
            /// </summary>
            [EnumMember(Value = "BulkActions")]
            Bulkactions,
            
            /// <summary>
            /// Enum Feedback for "Feedback"
            /// </summary>
            [EnumMember(Value = "Feedback")]
            Feedback,
            
            /// <summary>
            /// Enum Topic for "Topic"
            /// </summary>
            [EnumMember(Value = "Topic")]
            Topic,
            
            /// <summary>
            /// Enum Program for "Program"
            /// </summary>
            [EnumMember(Value = "Program")]
            Program,
            
            /// <summary>
            /// Enum Segment for "Segment"
            /// </summary>
            [EnumMember(Value = "Segment")]
            Segment,
            
            /// <summary>
            /// Enum Outcome for "Outcome"
            /// </summary>
            [EnumMember(Value = "Outcome")]
            Outcome,
            
            /// <summary>
            /// Enum Clickstreamsettings for "ClickstreamSettings"
            /// </summary>
            [EnumMember(Value = "ClickstreamSettings")]
            Clickstreamsettings
        }
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Create for "Create"
            /// </summary>
            [EnumMember(Value = "Create")]
            Create,
            
            /// <summary>
            /// Enum View for "View"
            /// </summary>
            [EnumMember(Value = "View")]
            View,
            
            /// <summary>
            /// Enum Update for "Update"
            /// </summary>
            [EnumMember(Value = "Update")]
            Update,
            
            /// <summary>
            /// Enum Delete for "Delete"
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete,
            
            /// <summary>
            /// Enum Download for "Download"
            /// </summary>
            [EnumMember(Value = "Download")]
            Download,
            
            /// <summary>
            /// Enum Memberadd for "MemberAdd"
            /// </summary>
            [EnumMember(Value = "MemberAdd")]
            Memberadd,
            
            /// <summary>
            /// Enum Memberupdate for "MemberUpdate"
            /// </summary>
            [EnumMember(Value = "MemberUpdate")]
            Memberupdate,
            
            /// <summary>
            /// Enum Memberremove for "MemberRemove"
            /// </summary>
            [EnumMember(Value = "MemberRemove")]
            Memberremove,
            
            /// <summary>
            /// Enum Read for "Read"
            /// </summary>
            [EnumMember(Value = "Read")]
            Read,
            
            /// <summary>
            /// Enum Applyprotection for "ApplyProtection"
            /// </summary>
            [EnumMember(Value = "ApplyProtection")]
            Applyprotection,
            
            /// <summary>
            /// Enum Revokeprotection for "RevokeProtection"
            /// </summary>
            [EnumMember(Value = "RevokeProtection")]
            Revokeprotection,
            
            /// <summary>
            /// Enum Updateretention for "UpdateRetention"
            /// </summary>
            [EnumMember(Value = "UpdateRetention")]
            Updateretention,
            
            /// <summary>
            /// Enum Readall for "ReadAll"
            /// </summary>
            [EnumMember(Value = "ReadAll")]
            Readall,
            
            /// <summary>
            /// Enum Execute for "Execute"
            /// </summary>
            [EnumMember(Value = "Execute")]
            Execute,
            
            /// <summary>
            /// Enum Publish for "Publish"
            /// </summary>
            [EnumMember(Value = "Publish")]
            Publish,
            
            /// <summary>
            /// Enum Authorize for "Authorize"
            /// </summary>
            [EnumMember(Value = "Authorize")]
            Authorize,
            
            /// <summary>
            /// Enum Deauthorize for "Deauthorize"
            /// </summary>
            [EnumMember(Value = "Deauthorize")]
            Deauthorize,
            
            /// <summary>
            /// Enum Authenticate for "Authenticate"
            /// </summary>
            [EnumMember(Value = "Authenticate")]
            Authenticate,
            
            /// <summary>
            /// Enum Changepassword for "ChangePassword"
            /// </summary>
            [EnumMember(Value = "ChangePassword")]
            Changepassword
        }
        
        
        
        
        
        /// <summary>
        /// Name of the Entity
        /// </summary>
        /// <value>Name of the Entity</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public NameEnum? Name { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditQueryEntity" /> class.
        /// </summary>
        /// <param name="Name">Name of the Entity.</param>
        /// <param name="Actions">List of Actions.</param>
        public AuditQueryEntity(NameEnum? Name = null, List<ActionsEnum> Actions = null)
        {
            this.Name = Name;
            this.Actions = Actions;
            
        }
        
        
        
        
        
        /// <summary>
        /// List of Actions
        /// </summary>
        /// <value>List of Actions</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionsEnum> Actions { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditQueryEntity {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
            return this.Equals(obj as AuditQueryEntity);
        }

        /// <summary>
        /// Returns true if AuditQueryEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditQueryEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditQueryEntity other)
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
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
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
                
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                
                return hash;
            }
        }
    }

}
