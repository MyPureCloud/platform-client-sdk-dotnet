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
    /// QueueConversationEventTopicMessageDetails
    /// </summary>
    [DataContract]
    public partial class QueueConversationEventTopicMessageDetails :  IEquatable<QueueConversationEventTopicMessageDetails>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets MessageStatus
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MessageStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Queued for "QUEUED"
            /// </summary>
            [EnumMember(Value = "QUEUED")]
            Queued,
            
            /// <summary>
            /// Enum Sent for "SENT"
            /// </summary>
            [EnumMember(Value = "SENT")]
            Sent,
            
            /// <summary>
            /// Enum Failed for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            Failed,
            
            /// <summary>
            /// Enum Received for "RECEIVED"
            /// </summary>
            [EnumMember(Value = "RECEIVED")]
            Received,
            
            /// <summary>
            /// Enum DeliverySuccess for "DELIVERY_SUCCESS"
            /// </summary>
            [EnumMember(Value = "DELIVERY_SUCCESS")]
            DeliverySuccess,
            
            /// <summary>
            /// Enum DeliveryFailed for "DELIVERY_FAILED"
            /// </summary>
            [EnumMember(Value = "DELIVERY_FAILED")]
            DeliveryFailed,
            
            /// <summary>
            /// Enum Read for "READ"
            /// </summary>
            [EnumMember(Value = "READ")]
            Read
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets MessageStatus
        /// </summary>
        [DataMember(Name="messageStatus", EmitDefaultValue=false)]
        public MessageStatusEnum? MessageStatus { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationEventTopicMessageDetails" /> class.
        /// </summary>
        /// <param name="MessageId">MessageId.</param>
        /// <param name="MessageTime">MessageTime.</param>
        /// <param name="MessageStatus">MessageStatus.</param>
        /// <param name="MessageSegmentCount">MessageSegmentCount.</param>
        /// <param name="Media">Media.</param>
        /// <param name="Stickers">Stickers.</param>
        public QueueConversationEventTopicMessageDetails(string MessageId = null, DateTime? MessageTime = null, MessageStatusEnum? MessageStatus = null, int? MessageSegmentCount = null, List<QueueConversationEventTopicMessageMedia> Media = null, List<QueueConversationEventTopicMessageSticker> Stickers = null)
        {
            this.MessageId = MessageId;
            this.MessageTime = MessageTime;
            this.MessageStatus = MessageStatus;
            this.MessageSegmentCount = MessageSegmentCount;
            this.Media = Media;
            this.Stickers = Stickers;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MessageTime
        /// </summary>
        [DataMember(Name="messageTime", EmitDefaultValue=false)]
        public DateTime? MessageTime { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets MessageSegmentCount
        /// </summary>
        [DataMember(Name="messageSegmentCount", EmitDefaultValue=false)]
        public int? MessageSegmentCount { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public List<QueueConversationEventTopicMessageMedia> Media { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Stickers
        /// </summary>
        [DataMember(Name="stickers", EmitDefaultValue=false)]
        public List<QueueConversationEventTopicMessageSticker> Stickers { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueConversationEventTopicMessageDetails {\n");
            
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  MessageTime: ").Append(MessageTime).Append("\n");
            sb.Append("  MessageStatus: ").Append(MessageStatus).Append("\n");
            sb.Append("  MessageSegmentCount: ").Append(MessageSegmentCount).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Stickers: ").Append(Stickers).Append("\n");
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
            return this.Equals(obj as QueueConversationEventTopicMessageDetails);
        }

        /// <summary>
        /// Returns true if QueueConversationEventTopicMessageDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueConversationEventTopicMessageDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueConversationEventTopicMessageDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MessageId == other.MessageId ||
                    this.MessageId != null &&
                    this.MessageId.Equals(other.MessageId)
                ) &&
                (
                    this.MessageTime == other.MessageTime ||
                    this.MessageTime != null &&
                    this.MessageTime.Equals(other.MessageTime)
                ) &&
                (
                    this.MessageStatus == other.MessageStatus ||
                    this.MessageStatus != null &&
                    this.MessageStatus.Equals(other.MessageStatus)
                ) &&
                (
                    this.MessageSegmentCount == other.MessageSegmentCount ||
                    this.MessageSegmentCount != null &&
                    this.MessageSegmentCount.Equals(other.MessageSegmentCount)
                ) &&
                (
                    this.Media == other.Media ||
                    this.Media != null &&
                    this.Media.SequenceEqual(other.Media)
                ) &&
                (
                    this.Stickers == other.Stickers ||
                    this.Stickers != null &&
                    this.Stickers.SequenceEqual(other.Stickers)
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
                
                if (this.MessageId != null)
                    hash = hash * 59 + this.MessageId.GetHashCode();
                
                if (this.MessageTime != null)
                    hash = hash * 59 + this.MessageTime.GetHashCode();
                
                if (this.MessageStatus != null)
                    hash = hash * 59 + this.MessageStatus.GetHashCode();
                
                if (this.MessageSegmentCount != null)
                    hash = hash * 59 + this.MessageSegmentCount.GetHashCode();
                
                if (this.Media != null)
                    hash = hash * 59 + this.Media.GetHashCode();
                
                if (this.Stickers != null)
                    hash = hash * 59 + this.Stickers.GetHashCode();
                
                return hash;
            }
        }
    }

}
