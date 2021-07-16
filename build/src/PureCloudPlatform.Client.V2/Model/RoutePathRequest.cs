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
    /// Route path configuration
    /// </summary>
    [DataContract]
    public partial class RoutePathRequest :  IEquatable<RoutePathRequest>
    {
        
        
        
        
        
        /// <summary>
        /// The media type of the given queue to associate with the route path
        /// </summary>
        /// <value>The media type of the given queue to associate with the route path</value>
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
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice,
            
            /// <summary>
            /// Enum Chat for "Chat"
            /// </summary>
            [EnumMember(Value = "Chat")]
            Chat,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Callback for "Callback"
            /// </summary>
            [EnumMember(Value = "Callback")]
            Callback,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The media type of the given queue to associate with the route path
        /// </summary>
        /// <value>The media type of the given queue to associate with the route path</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutePathRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoutePathRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutePathRequest" /> class.
        /// </summary>
        /// <param name="QueueId">The ID of the queue to associate with the route path (required).</param>
        /// <param name="MediaType">The media type of the given queue to associate with the route path (required).</param>
        /// <param name="LanguageId">The ID of the language to associate with the route path.</param>
        /// <param name="SkillIds">The set of skill IDs to associate with the route path.</param>
        /// <param name="SourcePlanningGroup">The planning group from which to copy route paths.</param>
        public RoutePathRequest(string QueueId = null, MediaTypeEnum? MediaType = null, string LanguageId = null, List<string> SkillIds = null, SourcePlanningGroupRequest SourcePlanningGroup = null)
        {
            this.QueueId = QueueId;
            this.MediaType = MediaType;
            this.LanguageId = LanguageId;
            this.SkillIds = SkillIds;
            this.SourcePlanningGroup = SourcePlanningGroup;
            
        }
        
        
        
        /// <summary>
        /// The ID of the queue to associate with the route path
        /// </summary>
        /// <value>The ID of the queue to associate with the route path</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }
        
        
        
        
        
        /// <summary>
        /// The ID of the language to associate with the route path
        /// </summary>
        /// <value>The ID of the language to associate with the route path</value>
        [DataMember(Name="languageId", EmitDefaultValue=false)]
        public string LanguageId { get; set; }
        
        
        
        /// <summary>
        /// The set of skill IDs to associate with the route path
        /// </summary>
        /// <value>The set of skill IDs to associate with the route path</value>
        [DataMember(Name="skillIds", EmitDefaultValue=false)]
        public List<string> SkillIds { get; set; }
        
        
        
        /// <summary>
        /// The planning group from which to copy route paths
        /// </summary>
        /// <value>The planning group from which to copy route paths</value>
        [DataMember(Name="sourcePlanningGroup", EmitDefaultValue=false)]
        public SourcePlanningGroupRequest SourcePlanningGroup { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutePathRequest {\n");
            
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
            sb.Append("  SourcePlanningGroup: ").Append(SourcePlanningGroup).Append("\n");
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
            return this.Equals(obj as RoutePathRequest);
        }

        /// <summary>
        /// Returns true if RoutePathRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RoutePathRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutePathRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.LanguageId == other.LanguageId ||
                    this.LanguageId != null &&
                    this.LanguageId.Equals(other.LanguageId)
                ) &&
                (
                    this.SkillIds == other.SkillIds ||
                    this.SkillIds != null &&
                    this.SkillIds.SequenceEqual(other.SkillIds)
                ) &&
                (
                    this.SourcePlanningGroup == other.SourcePlanningGroup ||
                    this.SourcePlanningGroup != null &&
                    this.SourcePlanningGroup.Equals(other.SourcePlanningGroup)
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
                
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                
                if (this.LanguageId != null)
                    hash = hash * 59 + this.LanguageId.GetHashCode();
                
                if (this.SkillIds != null)
                    hash = hash * 59 + this.SkillIds.GetHashCode();
                
                if (this.SourcePlanningGroup != null)
                    hash = hash * 59 + this.SourcePlanningGroup.GetHashCode();
                
                return hash;
            }
        }
    }

}
