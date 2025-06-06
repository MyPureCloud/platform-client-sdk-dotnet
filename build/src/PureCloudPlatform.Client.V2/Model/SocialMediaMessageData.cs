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
    /// SocialMediaMessageData
    /// </summary>
    [DataContract]
    public partial class SocialMediaMessageData :  IEquatable<SocialMediaMessageData>
    {
        /// <summary>
        /// The direction of the message.
        /// </summary>
        /// <value>The direction of the message.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Inbound for "inbound"
            /// </summary>
            [EnumMember(Value = "inbound")]
            Inbound,
            
            /// <summary>
            /// Enum Outbound for "outbound"
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound
        }
        /// <summary>
        /// Type of text messenger.
        /// </summary>
        /// <value>Type of text messenger.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MessengerTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sms for "sms"
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms,
            
            /// <summary>
            /// Enum Facebook for "facebook"
            /// </summary>
            [EnumMember(Value = "facebook")]
            Facebook,
            
            /// <summary>
            /// Enum Twitter for "twitter"
            /// </summary>
            [EnumMember(Value = "twitter")]
            Twitter,
            
            /// <summary>
            /// Enum Whatsapp for "whatsapp"
            /// </summary>
            [EnumMember(Value = "whatsapp")]
            Whatsapp,
            
            /// <summary>
            /// Enum Webmessaging for "webmessaging"
            /// </summary>
            [EnumMember(Value = "webmessaging")]
            Webmessaging,
            
            /// <summary>
            /// Enum Instagram for "instagram"
            /// </summary>
            [EnumMember(Value = "instagram")]
            Instagram,
            
            /// <summary>
            /// Enum Open for "open"
            /// </summary>
            [EnumMember(Value = "open")]
            Open,
            
            /// <summary>
            /// Enum Apple for "apple"
            /// </summary>
            [EnumMember(Value = "apple")]
            Apple
        }
        /// <summary>
        /// The status of the message.
        /// </summary>
        /// <value>The status of the message.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
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
            Read,
            
            /// <summary>
            /// Enum Removed for "removed"
            /// </summary>
            [EnumMember(Value = "removed")]
            Removed,
            
            /// <summary>
            /// Enum Published for "published"
            /// </summary>
            [EnumMember(Value = "published")]
            Published
        }
        /// <summary>
        /// The direction of the message.
        /// </summary>
        /// <value>The direction of the message.</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Type of text messenger.
        /// </summary>
        /// <value>Type of text messenger.</value>
        [DataMember(Name="messengerType", EmitDefaultValue=false)]
        public MessengerTypeEnum? MessengerType { get; set; }
        /// <summary>
        /// The status of the message.
        /// </summary>
        /// <value>The status of the message.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialMediaMessageData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SocialMediaMessageData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialMediaMessageData" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ProviderMessageId">The unique identifier of the message from provider.</param>
        /// <param name="Timestamp">The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="FromAddress">The sender of the text message..</param>
        /// <param name="ToAddress">The recipient of the text message..</param>
        /// <param name="Direction">The direction of the message..</param>
        /// <param name="MessengerType">Type of text messenger..</param>
        /// <param name="Status">The status of the message. (required).</param>
        /// <param name="CreatedBy">User who sent this message..</param>
        /// <param name="ConversationId">The id of the conversation of this message..</param>
        public SocialMediaMessageData(string Name = null, string ProviderMessageId = null, DateTime? Timestamp = null, string FromAddress = null, string ToAddress = null, DirectionEnum? Direction = null, MessengerTypeEnum? MessengerType = null, StatusEnum? Status = null, User CreatedBy = null, string ConversationId = null)
        {
            this.Name = Name;
            this.ProviderMessageId = ProviderMessageId;
            this.Timestamp = Timestamp;
            this.FromAddress = FromAddress;
            this.ToAddress = ToAddress;
            this.Direction = Direction;
            this.MessengerType = MessengerType;
            this.Status = Status;
            this.CreatedBy = CreatedBy;
            this.ConversationId = ConversationId;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The unique identifier of the message from provider
        /// </summary>
        /// <value>The unique identifier of the message from provider</value>
        [DataMember(Name="providerMessageId", EmitDefaultValue=false)]
        public string ProviderMessageId { get; set; }



        /// <summary>
        /// The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }



        /// <summary>
        /// The sender of the text message.
        /// </summary>
        /// <value>The sender of the text message.</value>
        [DataMember(Name="fromAddress", EmitDefaultValue=false)]
        public string FromAddress { get; set; }



        /// <summary>
        /// The recipient of the text message.
        /// </summary>
        /// <value>The recipient of the text message.</value>
        [DataMember(Name="toAddress", EmitDefaultValue=false)]
        public string ToAddress { get; set; }









        /// <summary>
        /// The message into normalized format
        /// </summary>
        /// <value>The message into normalized format</value>
        [DataMember(Name="normalizedMessage", EmitDefaultValue=false)]
        public ConversationNormalizedMessage NormalizedMessage { get; private set; }



        /// <summary>
        /// The delivery event associated with this message in normalized format, if the message direction was outbound
        /// </summary>
        /// <value>The delivery event associated with this message in normalized format, if the message direction was outbound</value>
        [DataMember(Name="normalizedReceipts", EmitDefaultValue=false)]
        public List<ConversationNormalizedMessage> NormalizedReceipts { get; private set; }



        /// <summary>
        /// User who sent this message.
        /// </summary>
        /// <value>User who sent this message.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public User CreatedBy { get; set; }



        /// <summary>
        /// The id of the conversation of this message.
        /// </summary>
        /// <value>The id of the conversation of this message.</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SocialMediaMessageData {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProviderMessageId: ").Append(ProviderMessageId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  MessengerType: ").Append(MessengerType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  NormalizedMessage: ").Append(NormalizedMessage).Append("\n");
            sb.Append("  NormalizedReceipts: ").Append(NormalizedReceipts).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as SocialMediaMessageData);
        }

        /// <summary>
        /// Returns true if SocialMediaMessageData instances are equal
        /// </summary>
        /// <param name="other">Instance of SocialMediaMessageData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SocialMediaMessageData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ProviderMessageId == other.ProviderMessageId ||
                    this.ProviderMessageId != null &&
                    this.ProviderMessageId.Equals(other.ProviderMessageId)
                ) &&
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) &&
                (
                    this.FromAddress == other.FromAddress ||
                    this.FromAddress != null &&
                    this.FromAddress.Equals(other.FromAddress)
                ) &&
                (
                    this.ToAddress == other.ToAddress ||
                    this.ToAddress != null &&
                    this.ToAddress.Equals(other.ToAddress)
                ) &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) &&
                (
                    this.MessengerType == other.MessengerType ||
                    this.MessengerType != null &&
                    this.MessengerType.Equals(other.MessengerType)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.NormalizedMessage == other.NormalizedMessage ||
                    this.NormalizedMessage != null &&
                    this.NormalizedMessage.Equals(other.NormalizedMessage)
                ) &&
                (
                    this.NormalizedReceipts == other.NormalizedReceipts ||
                    this.NormalizedReceipts != null &&
                    this.NormalizedReceipts.SequenceEqual(other.NormalizedReceipts)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.ProviderMessageId != null)
                    hash = hash * 59 + this.ProviderMessageId.GetHashCode();

                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();

                if (this.FromAddress != null)
                    hash = hash * 59 + this.FromAddress.GetHashCode();

                if (this.ToAddress != null)
                    hash = hash * 59 + this.ToAddress.GetHashCode();

                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();

                if (this.MessengerType != null)
                    hash = hash * 59 + this.MessengerType.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.NormalizedMessage != null)
                    hash = hash * 59 + this.NormalizedMessage.GetHashCode();

                if (this.NormalizedReceipts != null)
                    hash = hash * 59 + this.NormalizedReceipts.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
