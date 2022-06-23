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
        /// Indicates the delivery status of the message.
        /// </summary>
        /// <value>Indicates the delivery status of the message.</value>
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
            /// Enum Queued for "queued"
            /// </summary>
            [EnumMember(Value = "queued")]
            Queued,
            
            /// <summary>
            /// Enum Sent for "sent"
            /// </summary>
            [EnumMember(Value = "sent")]
            Sent,
            
            /// <summary>
            /// Enum Failed for "failed"
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed,
            
            /// <summary>
            /// Enum Received for "received"
            /// </summary>
            [EnumMember(Value = "received")]
            Received,
            
            /// <summary>
            /// Enum Deliverysuccess for "delivery-success"
            /// </summary>
            [EnumMember(Value = "delivery-success")]
            Deliverysuccess,
            
            /// <summary>
            /// Enum Deliveryfailed for "delivery-failed"
            /// </summary>
            [EnumMember(Value = "delivery-failed")]
            Deliveryfailed,
            
            /// <summary>
            /// Enum Read for "read"
            /// </summary>
            [EnumMember(Value = "read")]
            Read
        }
        /// <summary>
        /// Indicates the delivery status of the message.
        /// </summary>
        /// <value>Indicates the delivery status of the message.</value>
        [DataMember(Name="messageStatus", EmitDefaultValue=false)]
        public MessageStatusEnum? MessageStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationEventTopicMessageDetails" /> class.
        /// </summary>
        /// <param name="MessageId">UUID identifying the message media..</param>
        /// <param name="MessageTime">The time when the message was sent or received..</param>
        /// <param name="MessageStatus">Indicates the delivery status of the message..</param>
        /// <param name="MessageSegmentCount">The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits..</param>
        /// <param name="Media">The media (images, files, etc) associated with this message, if any.</param>
        /// <param name="ErrorInfo">Detailed information about an error response..</param>
        /// <param name="Stickers">A list of stickers included in the message.</param>
        /// <param name="MessageMetadata">MessageMetadata.</param>
        public QueueConversationEventTopicMessageDetails(string MessageId = null, DateTime? MessageTime = null, MessageStatusEnum? MessageStatus = null, int? MessageSegmentCount = null, List<QueueConversationEventTopicMessageMedia> Media = null, QueueConversationEventTopicErrorDetails ErrorInfo = null, List<QueueConversationEventTopicMessageSticker> Stickers = null, QueueConversationEventTopicMessageMetadata MessageMetadata = null)
        {
            this.MessageId = MessageId;
            this.MessageTime = MessageTime;
            this.MessageStatus = MessageStatus;
            this.MessageSegmentCount = MessageSegmentCount;
            this.Media = Media;
            this.ErrorInfo = ErrorInfo;
            this.Stickers = Stickers;
            this.MessageMetadata = MessageMetadata;
            
        }
        


        /// <summary>
        /// UUID identifying the message media.
        /// </summary>
        /// <value>UUID identifying the message media.</value>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; set; }



        /// <summary>
        /// The time when the message was sent or received.
        /// </summary>
        /// <value>The time when the message was sent or received.</value>
        [DataMember(Name="messageTime", EmitDefaultValue=false)]
        public DateTime? MessageTime { get; set; }





        /// <summary>
        /// The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits.
        /// </summary>
        /// <value>The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits.</value>
        [DataMember(Name="messageSegmentCount", EmitDefaultValue=false)]
        public int? MessageSegmentCount { get; set; }



        /// <summary>
        /// The media (images, files, etc) associated with this message, if any
        /// </summary>
        /// <value>The media (images, files, etc) associated with this message, if any</value>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public List<QueueConversationEventTopicMessageMedia> Media { get; set; }



        /// <summary>
        /// Detailed information about an error response.
        /// </summary>
        /// <value>Detailed information about an error response.</value>
        [DataMember(Name="errorInfo", EmitDefaultValue=false)]
        public QueueConversationEventTopicErrorDetails ErrorInfo { get; set; }



        /// <summary>
        /// A list of stickers included in the message
        /// </summary>
        /// <value>A list of stickers included in the message</value>
        [DataMember(Name="stickers", EmitDefaultValue=false)]
        public List<QueueConversationEventTopicMessageSticker> Stickers { get; set; }



        /// <summary>
        /// Gets or Sets MessageMetadata
        /// </summary>
        [DataMember(Name="messageMetadata", EmitDefaultValue=false)]
        public QueueConversationEventTopicMessageMetadata MessageMetadata { get; set; }


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
            sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  Stickers: ").Append(Stickers).Append("\n");
            sb.Append("  MessageMetadata: ").Append(MessageMetadata).Append("\n");
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
                    this.ErrorInfo == other.ErrorInfo ||
                    this.ErrorInfo != null &&
                    this.ErrorInfo.Equals(other.ErrorInfo)
                ) &&
                (
                    this.Stickers == other.Stickers ||
                    this.Stickers != null &&
                    this.Stickers.SequenceEqual(other.Stickers)
                ) &&
                (
                    this.MessageMetadata == other.MessageMetadata ||
                    this.MessageMetadata != null &&
                    this.MessageMetadata.Equals(other.MessageMetadata)
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

                if (this.ErrorInfo != null)
                    hash = hash * 59 + this.ErrorInfo.GetHashCode();

                if (this.Stickers != null)
                    hash = hash * 59 + this.Stickers.GetHashCode();

                if (this.MessageMetadata != null)
                    hash = hash * 59 + this.MessageMetadata.GetHashCode();

                return hash;
            }
        }
    }

}
