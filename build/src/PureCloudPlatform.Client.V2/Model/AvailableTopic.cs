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
    /// AvailableTopic
    /// </summary>
    [DataContract]
    public partial class AvailableTopic :  IEquatable<AvailableTopic>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Visibility of this topic (Public or Preview)
        /// </summary>
        /// <value>Visibility of this topic (Public or Preview)</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum VisibilityEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Public for "Public"
            /// </summary>
            [EnumMember(Value = "Public")]
            Public,
            
            /// <summary>
            /// Enum Preview for "Preview"
            /// </summary>
            [EnumMember(Value = "Preview")]
            Preview
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Transports
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TransportsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum All for "All"
            /// </summary>
            [EnumMember(Value = "All")]
            All,
            
            /// <summary>
            /// Enum Websocket for "Websocket"
            /// </summary>
            [EnumMember(Value = "Websocket")]
            Websocket,
            
            /// <summary>
            /// Enum Eventbridge for "EventBridge"
            /// </summary>
            [EnumMember(Value = "EventBridge")]
            Eventbridge
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Visibility of this topic (Public or Preview)
        /// </summary>
        /// <value>Visibility of this topic (Public or Preview)</value>
        [DataMember(Name="visibility", EmitDefaultValue=false)]
        public VisibilityEnum? Visibility { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableTopic" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="Id">Id.</param>
        /// <param name="PermissionDetails">Full detailed permissions required to subscribe to the topic.</param>
        /// <param name="RequiresPermissions">Permissions required to subscribe to the topic.</param>
        /// <param name="RequiresDivisionPermissions">True if the subscribing user must belong to the same division as the topic object ID.</param>
        /// <param name="RequiresAnyValidator">If multiple permissions are required for this topic, such as both requiresCurrentUser and requiresDivisionPermissions, then true here indicates that meeting any one condition will satisfy the requirements; false indicates all conditions must be met..</param>
        /// <param name="Enforced">Whether or not the permissions on this topic are enforced.</param>
        /// <param name="Visibility">Visibility of this topic (Public or Preview).</param>
        /// <param name="Schema">Schema.</param>
        /// <param name="RequiresCurrentUser">True if the topic user ID is required to match the subscribing user ID.</param>
        /// <param name="RequiresCurrentUserOrPermission">True if permissions are only required when the topic user ID does not match the subscribing user ID.</param>
        /// <param name="Transports">Transports that support events for the topic.</param>
        /// <param name="PublicApiTemplateUriPaths">PublicApiTemplateUriPaths.</param>
        /// <param name="TopicParameters">Parameters in the topic name that can be substituted, in the order they appear in the topic name.</param>
        public AvailableTopic(string Description = null, string Id = null, List<PermissionDetails> PermissionDetails = null, List<string> RequiresPermissions = null, bool? RequiresDivisionPermissions = null, bool? RequiresAnyValidator = null, bool? Enforced = null, VisibilityEnum? Visibility = null, Dictionary<string, Object> Schema = null, bool? RequiresCurrentUser = null, bool? RequiresCurrentUserOrPermission = null, List<TransportsEnum> Transports = null, List<string> PublicApiTemplateUriPaths = null, List<string> TopicParameters = null)
        {
            this.Description = Description;
            this.Id = Id;
            this.PermissionDetails = PermissionDetails;
            this.RequiresPermissions = RequiresPermissions;
            this.RequiresDivisionPermissions = RequiresDivisionPermissions;
            this.RequiresAnyValidator = RequiresAnyValidator;
            this.Enforced = Enforced;
            this.Visibility = Visibility;
            this.Schema = Schema;
            this.RequiresCurrentUser = RequiresCurrentUser;
            this.RequiresCurrentUserOrPermission = RequiresCurrentUserOrPermission;
            this.Transports = Transports;
            this.PublicApiTemplateUriPaths = PublicApiTemplateUriPaths;
            this.TopicParameters = TopicParameters;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Full detailed permissions required to subscribe to the topic
        /// </summary>
        /// <value>Full detailed permissions required to subscribe to the topic</value>
        [DataMember(Name="permissionDetails", EmitDefaultValue=false)]
        public List<PermissionDetails> PermissionDetails { get; set; }
        
        
        
        /// <summary>
        /// Permissions required to subscribe to the topic
        /// </summary>
        /// <value>Permissions required to subscribe to the topic</value>
        [DataMember(Name="requiresPermissions", EmitDefaultValue=false)]
        public List<string> RequiresPermissions { get; set; }
        
        
        
        /// <summary>
        /// True if the subscribing user must belong to the same division as the topic object ID
        /// </summary>
        /// <value>True if the subscribing user must belong to the same division as the topic object ID</value>
        [DataMember(Name="requiresDivisionPermissions", EmitDefaultValue=false)]
        public bool? RequiresDivisionPermissions { get; set; }
        
        
        
        /// <summary>
        /// If multiple permissions are required for this topic, such as both requiresCurrentUser and requiresDivisionPermissions, then true here indicates that meeting any one condition will satisfy the requirements; false indicates all conditions must be met.
        /// </summary>
        /// <value>If multiple permissions are required for this topic, such as both requiresCurrentUser and requiresDivisionPermissions, then true here indicates that meeting any one condition will satisfy the requirements; false indicates all conditions must be met.</value>
        [DataMember(Name="requiresAnyValidator", EmitDefaultValue=false)]
        public bool? RequiresAnyValidator { get; set; }
        
        
        
        /// <summary>
        /// Whether or not the permissions on this topic are enforced
        /// </summary>
        /// <value>Whether or not the permissions on this topic are enforced</value>
        [DataMember(Name="enforced", EmitDefaultValue=false)]
        public bool? Enforced { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public Dictionary<string, Object> Schema { get; set; }
        
        
        
        /// <summary>
        /// True if the topic user ID is required to match the subscribing user ID
        /// </summary>
        /// <value>True if the topic user ID is required to match the subscribing user ID</value>
        [DataMember(Name="requiresCurrentUser", EmitDefaultValue=false)]
        public bool? RequiresCurrentUser { get; set; }
        
        
        
        /// <summary>
        /// True if permissions are only required when the topic user ID does not match the subscribing user ID
        /// </summary>
        /// <value>True if permissions are only required when the topic user ID does not match the subscribing user ID</value>
        [DataMember(Name="requiresCurrentUserOrPermission", EmitDefaultValue=false)]
        public bool? RequiresCurrentUserOrPermission { get; set; }
        
        
        
        /// <summary>
        /// Transports that support events for the topic
        /// </summary>
        /// <value>Transports that support events for the topic</value>
        [DataMember(Name="transports", EmitDefaultValue=false)]
        public List<TransportsEnum> Transports { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PublicApiTemplateUriPaths
        /// </summary>
        [DataMember(Name="publicApiTemplateUriPaths", EmitDefaultValue=false)]
        public List<string> PublicApiTemplateUriPaths { get; set; }
        
        
        
        /// <summary>
        /// Parameters in the topic name that can be substituted, in the order they appear in the topic name
        /// </summary>
        /// <value>Parameters in the topic name that can be substituted, in the order they appear in the topic name</value>
        [DataMember(Name="topicParameters", EmitDefaultValue=false)]
        public List<string> TopicParameters { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailableTopic {\n");
            
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PermissionDetails: ").Append(PermissionDetails).Append("\n");
            sb.Append("  RequiresPermissions: ").Append(RequiresPermissions).Append("\n");
            sb.Append("  RequiresDivisionPermissions: ").Append(RequiresDivisionPermissions).Append("\n");
            sb.Append("  RequiresAnyValidator: ").Append(RequiresAnyValidator).Append("\n");
            sb.Append("  Enforced: ").Append(Enforced).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  RequiresCurrentUser: ").Append(RequiresCurrentUser).Append("\n");
            sb.Append("  RequiresCurrentUserOrPermission: ").Append(RequiresCurrentUserOrPermission).Append("\n");
            sb.Append("  Transports: ").Append(Transports).Append("\n");
            sb.Append("  PublicApiTemplateUriPaths: ").Append(PublicApiTemplateUriPaths).Append("\n");
            sb.Append("  TopicParameters: ").Append(TopicParameters).Append("\n");
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
            return this.Equals(obj as AvailableTopic);
        }

        /// <summary>
        /// Returns true if AvailableTopic instances are equal
        /// </summary>
        /// <param name="other">Instance of AvailableTopic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailableTopic other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.PermissionDetails == other.PermissionDetails ||
                    this.PermissionDetails != null &&
                    this.PermissionDetails.SequenceEqual(other.PermissionDetails)
                ) &&
                (
                    this.RequiresPermissions == other.RequiresPermissions ||
                    this.RequiresPermissions != null &&
                    this.RequiresPermissions.SequenceEqual(other.RequiresPermissions)
                ) &&
                (
                    this.RequiresDivisionPermissions == other.RequiresDivisionPermissions ||
                    this.RequiresDivisionPermissions != null &&
                    this.RequiresDivisionPermissions.Equals(other.RequiresDivisionPermissions)
                ) &&
                (
                    this.RequiresAnyValidator == other.RequiresAnyValidator ||
                    this.RequiresAnyValidator != null &&
                    this.RequiresAnyValidator.Equals(other.RequiresAnyValidator)
                ) &&
                (
                    this.Enforced == other.Enforced ||
                    this.Enforced != null &&
                    this.Enforced.Equals(other.Enforced)
                ) &&
                (
                    this.Visibility == other.Visibility ||
                    this.Visibility != null &&
                    this.Visibility.Equals(other.Visibility)
                ) &&
                (
                    this.Schema == other.Schema ||
                    this.Schema != null &&
                    this.Schema.SequenceEqual(other.Schema)
                ) &&
                (
                    this.RequiresCurrentUser == other.RequiresCurrentUser ||
                    this.RequiresCurrentUser != null &&
                    this.RequiresCurrentUser.Equals(other.RequiresCurrentUser)
                ) &&
                (
                    this.RequiresCurrentUserOrPermission == other.RequiresCurrentUserOrPermission ||
                    this.RequiresCurrentUserOrPermission != null &&
                    this.RequiresCurrentUserOrPermission.Equals(other.RequiresCurrentUserOrPermission)
                ) &&
                (
                    this.Transports == other.Transports ||
                    this.Transports != null &&
                    this.Transports.SequenceEqual(other.Transports)
                ) &&
                (
                    this.PublicApiTemplateUriPaths == other.PublicApiTemplateUriPaths ||
                    this.PublicApiTemplateUriPaths != null &&
                    this.PublicApiTemplateUriPaths.SequenceEqual(other.PublicApiTemplateUriPaths)
                ) &&
                (
                    this.TopicParameters == other.TopicParameters ||
                    this.TopicParameters != null &&
                    this.TopicParameters.SequenceEqual(other.TopicParameters)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.PermissionDetails != null)
                    hash = hash * 59 + this.PermissionDetails.GetHashCode();
                
                if (this.RequiresPermissions != null)
                    hash = hash * 59 + this.RequiresPermissions.GetHashCode();
                
                if (this.RequiresDivisionPermissions != null)
                    hash = hash * 59 + this.RequiresDivisionPermissions.GetHashCode();
                
                if (this.RequiresAnyValidator != null)
                    hash = hash * 59 + this.RequiresAnyValidator.GetHashCode();
                
                if (this.Enforced != null)
                    hash = hash * 59 + this.Enforced.GetHashCode();
                
                if (this.Visibility != null)
                    hash = hash * 59 + this.Visibility.GetHashCode();
                
                if (this.Schema != null)
                    hash = hash * 59 + this.Schema.GetHashCode();
                
                if (this.RequiresCurrentUser != null)
                    hash = hash * 59 + this.RequiresCurrentUser.GetHashCode();
                
                if (this.RequiresCurrentUserOrPermission != null)
                    hash = hash * 59 + this.RequiresCurrentUserOrPermission.GetHashCode();
                
                if (this.Transports != null)
                    hash = hash * 59 + this.Transports.GetHashCode();
                
                if (this.PublicApiTemplateUriPaths != null)
                    hash = hash * 59 + this.PublicApiTemplateUriPaths.GetHashCode();
                
                if (this.TopicParameters != null)
                    hash = hash * 59 + this.TopicParameters.GetHashCode();
                
                return hash;
            }
        }
    }

}
