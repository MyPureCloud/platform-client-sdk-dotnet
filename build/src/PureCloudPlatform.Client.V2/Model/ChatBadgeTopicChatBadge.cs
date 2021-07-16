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
    /// ChatBadgeTopicChatBadge
    /// </summary>
    [DataContract]
    public partial class ChatBadgeTopicChatBadge :  IEquatable<ChatBadgeTopicChatBadge>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBadgeTopicChatBadge" /> class.
        /// </summary>
        /// <param name="Entity">Entity.</param>
        /// <param name="UnreadCount">UnreadCount.</param>
        /// <param name="LastUnreadNotificationDate">LastUnreadNotificationDate.</param>
        public ChatBadgeTopicChatBadge(ChatBadgeTopicBadgeEntity Entity = null, int? UnreadCount = null, DateTime? LastUnreadNotificationDate = null)
        {
            this.Entity = Entity;
            this.UnreadCount = UnreadCount;
            this.LastUnreadNotificationDate = LastUnreadNotificationDate;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public ChatBadgeTopicBadgeEntity Entity { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets UnreadCount
        /// </summary>
        [DataMember(Name="unreadCount", EmitDefaultValue=false)]
        public int? UnreadCount { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets LastUnreadNotificationDate
        /// </summary>
        [DataMember(Name="lastUnreadNotificationDate", EmitDefaultValue=false)]
        public DateTime? LastUnreadNotificationDate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatBadgeTopicChatBadge {\n");
            
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  UnreadCount: ").Append(UnreadCount).Append("\n");
            sb.Append("  LastUnreadNotificationDate: ").Append(LastUnreadNotificationDate).Append("\n");
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
            return this.Equals(obj as ChatBadgeTopicChatBadge);
        }

        /// <summary>
        /// Returns true if ChatBadgeTopicChatBadge instances are equal
        /// </summary>
        /// <param name="other">Instance of ChatBadgeTopicChatBadge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatBadgeTopicChatBadge other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
                ) &&
                (
                    this.UnreadCount == other.UnreadCount ||
                    this.UnreadCount != null &&
                    this.UnreadCount.Equals(other.UnreadCount)
                ) &&
                (
                    this.LastUnreadNotificationDate == other.LastUnreadNotificationDate ||
                    this.LastUnreadNotificationDate != null &&
                    this.LastUnreadNotificationDate.Equals(other.LastUnreadNotificationDate)
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
                
                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();
                
                if (this.UnreadCount != null)
                    hash = hash * 59 + this.UnreadCount.GetHashCode();
                
                if (this.LastUnreadNotificationDate != null)
                    hash = hash * 59 + this.LastUnreadNotificationDate.GetHashCode();
                
                return hash;
            }
        }
    }

}
