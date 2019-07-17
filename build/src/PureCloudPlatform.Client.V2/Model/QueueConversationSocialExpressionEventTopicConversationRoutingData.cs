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
    /// QueueConversationSocialExpressionEventTopicConversationRoutingData
    /// </summary>
    [DataContract]
    public partial class QueueConversationSocialExpressionEventTopicConversationRoutingData :  IEquatable<QueueConversationSocialExpressionEventTopicConversationRoutingData>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationSocialExpressionEventTopicConversationRoutingData" /> class.
        /// </summary>
        /// <param name="Queue">Queue.</param>
        /// <param name="Language">Language.</param>
        /// <param name="Priority">Priority.</param>
        /// <param name="Skills">Skills.</param>
        /// <param name="ScoredAgents">ScoredAgents.</param>
        public QueueConversationSocialExpressionEventTopicConversationRoutingData(QueueConversationSocialExpressionEventTopicUriReference Queue = null, QueueConversationSocialExpressionEventTopicUriReference Language = null, int? Priority = null, List<QueueConversationSocialExpressionEventTopicUriReference> Skills = null, List<QueueConversationSocialExpressionEventTopicScoredAgent> ScoredAgents = null)
        {
            this.Queue = Queue;
            this.Language = Language;
            this.Priority = Priority;
            this.Skills = Skills;
            this.ScoredAgents = ScoredAgents;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public QueueConversationSocialExpressionEventTopicUriReference Queue { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public QueueConversationSocialExpressionEventTopicUriReference Language { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Skills
        /// </summary>
        [DataMember(Name="skills", EmitDefaultValue=false)]
        public List<QueueConversationSocialExpressionEventTopicUriReference> Skills { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ScoredAgents
        /// </summary>
        [DataMember(Name="scoredAgents", EmitDefaultValue=false)]
        public List<QueueConversationSocialExpressionEventTopicScoredAgent> ScoredAgents { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueConversationSocialExpressionEventTopicConversationRoutingData {\n");
            
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Skills: ").Append(Skills).Append("\n");
            sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
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
            return this.Equals(obj as QueueConversationSocialExpressionEventTopicConversationRoutingData);
        }

        /// <summary>
        /// Returns true if QueueConversationSocialExpressionEventTopicConversationRoutingData instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueConversationSocialExpressionEventTopicConversationRoutingData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueConversationSocialExpressionEventTopicConversationRoutingData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) &&
                (
                    this.Skills == other.Skills ||
                    this.Skills != null &&
                    this.Skills.SequenceEqual(other.Skills)
                ) &&
                (
                    this.ScoredAgents == other.ScoredAgents ||
                    this.ScoredAgents != null &&
                    this.ScoredAgents.SequenceEqual(other.ScoredAgents)
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
                
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
                
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                
                if (this.Skills != null)
                    hash = hash * 59 + this.Skills.GetHashCode();
                
                if (this.ScoredAgents != null)
                    hash = hash * 59 + this.ScoredAgents.GetHashCode();
                
                return hash;
            }
        }
    }

}
