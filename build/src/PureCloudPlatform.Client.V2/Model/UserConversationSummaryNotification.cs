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
    /// UserConversationSummaryNotification
    /// </summary>
    [DataContract]
    public partial class UserConversationSummaryNotification :  IEquatable<UserConversationSummaryNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserConversationSummaryNotification" /> class.
        /// </summary>
        /// <param name="UserId">UserId.</param>
        /// <param name="Call">Call.</param>
        /// <param name="Callback">Callback.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Chat">Chat.</param>
        /// <param name="SocialExpression">SocialExpression.</param>
        /// <param name="Video">Video.</param>
        public UserConversationSummaryNotification(string UserId = null, UserConversationSummaryNotificationCall Call = null, UserConversationSummaryNotificationMediaSummary Callback = null, UserConversationSummaryNotificationMediaSummary Email = null, UserConversationSummaryNotificationMediaSummary Chat = null, UserConversationSummaryNotificationMediaSummary SocialExpression = null, UserConversationSummaryNotificationMediaSummary Video = null)
        {
            this.UserId = UserId;
            this.Call = Call;
            this.Callback = Callback;
            this.Email = Email;
            this.Chat = Chat;
            this.SocialExpression = SocialExpression;
            this.Video = Video;
        }
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        /// <summary>
        /// Gets or Sets Call
        /// </summary>
        [DataMember(Name="call", EmitDefaultValue=false)]
        public UserConversationSummaryNotificationCall Call { get; set; }
        /// <summary>
        /// Gets or Sets Callback
        /// </summary>
        [DataMember(Name="callback", EmitDefaultValue=false)]
        public UserConversationSummaryNotificationMediaSummary Callback { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public UserConversationSummaryNotificationMediaSummary Email { get; set; }
        /// <summary>
        /// Gets or Sets Chat
        /// </summary>
        [DataMember(Name="chat", EmitDefaultValue=false)]
        public UserConversationSummaryNotificationMediaSummary Chat { get; set; }
        /// <summary>
        /// Gets or Sets SocialExpression
        /// </summary>
        [DataMember(Name="socialExpression", EmitDefaultValue=false)]
        public UserConversationSummaryNotificationMediaSummary SocialExpression { get; set; }
        /// <summary>
        /// Gets or Sets Video
        /// </summary>
        [DataMember(Name="video", EmitDefaultValue=false)]
        public UserConversationSummaryNotificationMediaSummary Video { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserConversationSummaryNotification {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Call: ").Append(Call).Append("\n");
            sb.Append("  Callback: ").Append(Callback).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Chat: ").Append(Chat).Append("\n");
            sb.Append("  SocialExpression: ").Append(SocialExpression).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
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
            return this.Equals(obj as UserConversationSummaryNotification);
        }

        /// <summary>
        /// Returns true if UserConversationSummaryNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of UserConversationSummaryNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserConversationSummaryNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.Call == other.Call ||
                    this.Call != null &&
                    this.Call.Equals(other.Call)
                ) &&
                (
                    this.Callback == other.Callback ||
                    this.Callback != null &&
                    this.Callback.Equals(other.Callback)
                ) &&
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) &&
                (
                    this.Chat == other.Chat ||
                    this.Chat != null &&
                    this.Chat.Equals(other.Chat)
                ) &&
                (
                    this.SocialExpression == other.SocialExpression ||
                    this.SocialExpression != null &&
                    this.SocialExpression.Equals(other.SocialExpression)
                ) &&
                (
                    this.Video == other.Video ||
                    this.Video != null &&
                    this.Video.Equals(other.Video)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Call != null)
                    hash = hash * 59 + this.Call.GetHashCode();
                if (this.Callback != null)
                    hash = hash * 59 + this.Callback.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Chat != null)
                    hash = hash * 59 + this.Chat.GetHashCode();
                if (this.SocialExpression != null)
                    hash = hash * 59 + this.SocialExpression.GetHashCode();
                if (this.Video != null)
                    hash = hash * 59 + this.Video.GetHashCode();
                return hash;
            }
        }
    }

}
