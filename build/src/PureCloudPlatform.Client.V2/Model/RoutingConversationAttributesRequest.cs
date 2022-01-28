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
    /// RoutingConversationAttributesRequest
    /// </summary>
    [DataContract]
    public partial class RoutingConversationAttributesRequest :  IEquatable<RoutingConversationAttributesRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingConversationAttributesRequest" /> class.
        /// </summary>
        /// <param name="Priority">Priority for the conversation.  Each point of priority is equivalent to one minute of time in queue.  Range:[-25000000, 25000000].  To reset, specify 0..</param>
        /// <param name="SkillIds">Skill requirements for the conversation.  To remove all skill requirements, specify an empty list, i.e. []..</param>
        /// <param name="LanguageId">Language requirement for the conversation.  To remove the language requirement, specify an empty string, i.e., \&quot;\&quot;..</param>
        /// <param name="RequestScoredAgents">RequestScoredAgents.</param>
        public RoutingConversationAttributesRequest(int? Priority = null, List<string> SkillIds = null, string LanguageId = null, List<RequestScoredAgent> RequestScoredAgents = null)
        {
            this.Priority = Priority;
            this.SkillIds = SkillIds;
            this.LanguageId = LanguageId;
            this.RequestScoredAgents = RequestScoredAgents;
            
        }
        
        
        
        /// <summary>
        /// Priority for the conversation.  Each point of priority is equivalent to one minute of time in queue.  Range:[-25000000, 25000000].  To reset, specify 0.
        /// </summary>
        /// <value>Priority for the conversation.  Each point of priority is equivalent to one minute of time in queue.  Range:[-25000000, 25000000].  To reset, specify 0.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }
        
        
        
        /// <summary>
        /// Skill requirements for the conversation.  To remove all skill requirements, specify an empty list, i.e. [].
        /// </summary>
        /// <value>Skill requirements for the conversation.  To remove all skill requirements, specify an empty list, i.e. [].</value>
        [DataMember(Name="skillIds", EmitDefaultValue=false)]
        public List<string> SkillIds { get; set; }
        
        
        
        /// <summary>
        /// Language requirement for the conversation.  To remove the language requirement, specify an empty string, i.e., \&quot;\&quot;.
        /// </summary>
        /// <value>Language requirement for the conversation.  To remove the language requirement, specify an empty string, i.e., \&quot;\&quot;.</value>
        [DataMember(Name="languageId", EmitDefaultValue=false)]
        public string LanguageId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RequestScoredAgents
        /// </summary>
        [DataMember(Name="requestScoredAgents", EmitDefaultValue=false)]
        public List<RequestScoredAgent> RequestScoredAgents { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutingConversationAttributesRequest {\n");
            
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  RequestScoredAgents: ").Append(RequestScoredAgents).Append("\n");
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
            return this.Equals(obj as RoutingConversationAttributesRequest);
        }

        /// <summary>
        /// Returns true if RoutingConversationAttributesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RoutingConversationAttributesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutingConversationAttributesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) &&
                (
                    this.SkillIds == other.SkillIds ||
                    this.SkillIds != null &&
                    this.SkillIds.SequenceEqual(other.SkillIds)
                ) &&
                (
                    this.LanguageId == other.LanguageId ||
                    this.LanguageId != null &&
                    this.LanguageId.Equals(other.LanguageId)
                ) &&
                (
                    this.RequestScoredAgents == other.RequestScoredAgents ||
                    this.RequestScoredAgents != null &&
                    this.RequestScoredAgents.SequenceEqual(other.RequestScoredAgents)
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
                
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                
                if (this.SkillIds != null)
                    hash = hash * 59 + this.SkillIds.GetHashCode();
                
                if (this.LanguageId != null)
                    hash = hash * 59 + this.LanguageId.GetHashCode();
                
                if (this.RequestScoredAgents != null)
                    hash = hash * 59 + this.RequestScoredAgents.GetHashCode();
                
                return hash;
            }
        }
    }

}
