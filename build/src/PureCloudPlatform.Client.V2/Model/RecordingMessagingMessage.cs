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
    /// RecordingMessagingMessage
    /// </summary>
    [DataContract]
    public partial class RecordingMessagingMessage :  IEquatable<RecordingMessagingMessage>
    {
        /// <summary>
        /// Indicates the content type for this message
        /// </summary>
        /// <value>Indicates the content type for this message</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ContentTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Quickreply for "QuickReply"
            /// </summary>
            [EnumMember(Value = "QuickReply")]
            Quickreply,
            
            /// <summary>
            /// Enum Story for "Story"
            /// </summary>
            [EnumMember(Value = "Story")]
            Story,
            
            /// <summary>
            /// Enum Card for "Card"
            /// </summary>
            [EnumMember(Value = "Card")]
            Card,
            
            /// <summary>
            /// Enum Carousel for "Carousel"
            /// </summary>
            [EnumMember(Value = "Carousel")]
            Carousel,
            
            /// <summary>
            /// Enum Attachment for "Attachment"
            /// </summary>
            [EnumMember(Value = "Attachment")]
            Attachment,
            
            /// <summary>
            /// Enum Location for "Location"
            /// </summary>
            [EnumMember(Value = "Location")]
            Location,
            
            /// <summary>
            /// Enum Notification for "Notification"
            /// </summary>
            [EnumMember(Value = "Notification")]
            Notification,
            
            /// <summary>
            /// Enum Generictemplate for "GenericTemplate"
            /// </summary>
            [EnumMember(Value = "GenericTemplate")]
            Generictemplate,
            
            /// <summary>
            /// Enum Listtemplate for "ListTemplate"
            /// </summary>
            [EnumMember(Value = "ListTemplate")]
            Listtemplate,
            
            /// <summary>
            /// Enum Postback for "Postback"
            /// </summary>
            [EnumMember(Value = "Postback")]
            Postback,
            
            /// <summary>
            /// Enum Reactions for "Reactions"
            /// </summary>
            [EnumMember(Value = "Reactions")]
            Reactions,
            
            /// <summary>
            /// Enum Mention for "Mention"
            /// </summary>
            [EnumMember(Value = "Mention")]
            Mention,
            
            /// <summary>
            /// Enum Buttonresponse for "ButtonResponse"
            /// </summary>
            [EnumMember(Value = "ButtonResponse")]
            Buttonresponse,
            
            /// <summary>
            /// Enum Datepicker for "DatePicker"
            /// </summary>
            [EnumMember(Value = "DatePicker")]
            Datepicker,
            
            /// <summary>
            /// Enum Listpicker for "ListPicker"
            /// </summary>
            [EnumMember(Value = "ListPicker")]
            Listpicker,
            
            /// <summary>
            /// Enum Interactiveapplication for "InteractiveApplication"
            /// </summary>
            [EnumMember(Value = "InteractiveApplication")]
            Interactiveapplication,
            
            /// <summary>
            /// Enum Paymentrequest for "PaymentRequest"
            /// </summary>
            [EnumMember(Value = "PaymentRequest")]
            Paymentrequest,
            
            /// <summary>
            /// Enum Paymentresponse for "PaymentResponse"
            /// </summary>
            [EnumMember(Value = "PaymentResponse")]
            Paymentresponse,
            
            /// <summary>
            /// Enum Form for "Form"
            /// </summary>
            [EnumMember(Value = "Form")]
            Form,
            
            /// <summary>
            /// Enum Richlink for "RichLink"
            /// </summary>
            [EnumMember(Value = "RichLink")]
            Richlink,
            
            /// <summary>
            /// Enum Roadsideassistance for "RoadsideAssistance"
            /// </summary>
            [EnumMember(Value = "RoadsideAssistance")]
            Roadsideassistance
        }
        /// <summary>
        /// For social media messages, the visibility of the message in the originating social platform
        /// </summary>
        /// <value>For social media messages, the visibility of the message in the originating social platform</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SocialVisibilityEnum
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
            /// Enum Private for "Private"
            /// </summary>
            [EnumMember(Value = "Private")]
            Private
        }
        /// <summary>
        /// Indicates the content type for this message
        /// </summary>
        /// <value>Indicates the content type for this message</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public ContentTypeEnum? ContentType { get; set; }
        /// <summary>
        /// For social media messages, the visibility of the message in the originating social platform
        /// </summary>
        /// <value>For social media messages, the visibility of the message in the originating social platform</value>
        [DataMember(Name="socialVisibility", EmitDefaultValue=false)]
        public SocialVisibilityEnum? SocialVisibility { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingMessagingMessage" /> class.
        /// </summary>
        /// <param name="From">The message sender session id..</param>
        /// <param name="FromUser">The user who sent this message..</param>
        /// <param name="FromExternalContact">The PureCloud external contact sender details..</param>
        /// <param name="To">The message recipient..</param>
        /// <param name="Timestamp">The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Id">A globally unique identifier for this communication..</param>
        /// <param name="Status">Status of the message.</param>
        /// <param name="Purpose">A well known string that specifies the purpose or type of the participant on this communication..</param>
        /// <param name="ParticipantId">A globally unique identifier for the participant on this communication..</param>
        /// <param name="Queue">A globally unique identifier for the queue involved in this communication..</param>
        /// <param name="Workflow">A globally unique identifier for the workflow involved in this communication..</param>
        /// <param name="MessageText">The content of this message..</param>
        /// <param name="MessageMediaAttachments">List of media objects attached  with this message..</param>
        /// <param name="MessageStickerAttachments">List of message stickers attached with this message..</param>
        /// <param name="QuickReplies">List of quick reply options offered with this message..</param>
        /// <param name="ButtonResponse">Button Response selected by user for this message..</param>
        /// <param name="ButtonResponses">List of Button Response selected by user for this message..</param>
        /// <param name="Story">Ephemeral story content..</param>
        /// <param name="Cards">List of cards offered for this message.</param>
        /// <param name="NotificationTemplate">Template notification content..</param>
        /// <param name="DatePicker">DatePicker content object..</param>
        /// <param name="ListPicker">ListPicker content object..</param>
        /// <param name="ContentType">Indicates the content type for this message.</param>
        /// <param name="SocialVisibility">For social media messages, the visibility of the message in the originating social platform.</param>
        /// <param name="Events">List of event elements.</param>
        /// <param name="InteractiveApplication">InteractiveApplication content..</param>
        /// <param name="PaymentRequest">Payment request content..</param>
        /// <param name="PaymentResponse">Payment response content..</param>
        /// <param name="Form">Form content..</param>
        /// <param name="RoadsideAssistance">Roadside Assistance content..</param>
        /// <param name="MessageReceipts">List of message receipts.</param>
        public RecordingMessagingMessage(string From = null, User FromUser = null, ExternalContact FromExternalContact = null, string To = null, DateTime? Timestamp = null, string Id = null, string Status = null, string Purpose = null, string ParticipantId = null, AddressableEntityRef Queue = null, AddressableEntityRef Workflow = null, string MessageText = null, List<MessageMediaAttachment> MessageMediaAttachments = null, List<MessageStickerAttachment> MessageStickerAttachments = null, List<QuickReply> QuickReplies = null, ButtonResponse ButtonResponse = null, List<ButtonResponse> ButtonResponses = null, RecordingContentStory Story = null, List<Card> Cards = null, RecordingNotificationTemplate NotificationTemplate = null, DatePicker DatePicker = null, ListPicker ListPicker = null, ContentTypeEnum? ContentType = null, SocialVisibilityEnum? SocialVisibility = null, List<ConversationMessageEvent> Events = null, InteractiveApplication InteractiveApplication = null, PaymentRequest PaymentRequest = null, PaymentResponse PaymentResponse = null, RecordingForm Form = null, RecordingRoadsideAssistance RoadsideAssistance = null, List<RecordingMessageReceipt> MessageReceipts = null)
        {
            this.From = From;
            this.FromUser = FromUser;
            this.FromExternalContact = FromExternalContact;
            this.To = To;
            this.Timestamp = Timestamp;
            this.Id = Id;
            this.Status = Status;
            this.Purpose = Purpose;
            this.ParticipantId = ParticipantId;
            this.Queue = Queue;
            this.Workflow = Workflow;
            this.MessageText = MessageText;
            this.MessageMediaAttachments = MessageMediaAttachments;
            this.MessageStickerAttachments = MessageStickerAttachments;
            this.QuickReplies = QuickReplies;
            this.ButtonResponse = ButtonResponse;
            this.ButtonResponses = ButtonResponses;
            this.Story = Story;
            this.Cards = Cards;
            this.NotificationTemplate = NotificationTemplate;
            this.DatePicker = DatePicker;
            this.ListPicker = ListPicker;
            this.ContentType = ContentType;
            this.SocialVisibility = SocialVisibility;
            this.Events = Events;
            this.InteractiveApplication = InteractiveApplication;
            this.PaymentRequest = PaymentRequest;
            this.PaymentResponse = PaymentResponse;
            this.Form = Form;
            this.RoadsideAssistance = RoadsideAssistance;
            this.MessageReceipts = MessageReceipts;
            
        }
        


        /// <summary>
        /// The message sender session id.
        /// </summary>
        /// <value>The message sender session id.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }



        /// <summary>
        /// The user who sent this message.
        /// </summary>
        /// <value>The user who sent this message.</value>
        [DataMember(Name="fromUser", EmitDefaultValue=false)]
        public User FromUser { get; set; }



        /// <summary>
        /// The PureCloud external contact sender details.
        /// </summary>
        /// <value>The PureCloud external contact sender details.</value>
        [DataMember(Name="fromExternalContact", EmitDefaultValue=false)]
        public ExternalContact FromExternalContact { get; set; }



        /// <summary>
        /// The message recipient.
        /// </summary>
        /// <value>The message recipient.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }



        /// <summary>
        /// The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time when the message was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }



        /// <summary>
        /// A globally unique identifier for this communication.
        /// </summary>
        /// <value>A globally unique identifier for this communication.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Status of the message
        /// </summary>
        /// <value>Status of the message</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }



        /// <summary>
        /// A well known string that specifies the purpose or type of the participant on this communication.
        /// </summary>
        /// <value>A well known string that specifies the purpose or type of the participant on this communication.</value>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public string Purpose { get; set; }



        /// <summary>
        /// A globally unique identifier for the participant on this communication.
        /// </summary>
        /// <value>A globally unique identifier for the participant on this communication.</value>
        [DataMember(Name="participantId", EmitDefaultValue=false)]
        public string ParticipantId { get; set; }



        /// <summary>
        /// A globally unique identifier for the queue involved in this communication.
        /// </summary>
        /// <value>A globally unique identifier for the queue involved in this communication.</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public AddressableEntityRef Queue { get; set; }



        /// <summary>
        /// A globally unique identifier for the workflow involved in this communication.
        /// </summary>
        /// <value>A globally unique identifier for the workflow involved in this communication.</value>
        [DataMember(Name="workflow", EmitDefaultValue=false)]
        public AddressableEntityRef Workflow { get; set; }



        /// <summary>
        /// The content of this message.
        /// </summary>
        /// <value>The content of this message.</value>
        [DataMember(Name="messageText", EmitDefaultValue=false)]
        public string MessageText { get; set; }



        /// <summary>
        /// List of media objects attached  with this message.
        /// </summary>
        /// <value>List of media objects attached  with this message.</value>
        [DataMember(Name="messageMediaAttachments", EmitDefaultValue=false)]
        public List<MessageMediaAttachment> MessageMediaAttachments { get; set; }



        /// <summary>
        /// List of message stickers attached with this message.
        /// </summary>
        /// <value>List of message stickers attached with this message.</value>
        [DataMember(Name="messageStickerAttachments", EmitDefaultValue=false)]
        public List<MessageStickerAttachment> MessageStickerAttachments { get; set; }



        /// <summary>
        /// List of quick reply options offered with this message.
        /// </summary>
        /// <value>List of quick reply options offered with this message.</value>
        [DataMember(Name="quickReplies", EmitDefaultValue=false)]
        public List<QuickReply> QuickReplies { get; set; }



        /// <summary>
        /// Button Response selected by user for this message.
        /// </summary>
        /// <value>Button Response selected by user for this message.</value>
        [DataMember(Name="buttonResponse", EmitDefaultValue=false)]
        public ButtonResponse ButtonResponse { get; set; }



        /// <summary>
        /// List of Button Response selected by user for this message.
        /// </summary>
        /// <value>List of Button Response selected by user for this message.</value>
        [DataMember(Name="buttonResponses", EmitDefaultValue=false)]
        public List<ButtonResponse> ButtonResponses { get; set; }



        /// <summary>
        /// Ephemeral story content.
        /// </summary>
        /// <value>Ephemeral story content.</value>
        [DataMember(Name="story", EmitDefaultValue=false)]
        public RecordingContentStory Story { get; set; }



        /// <summary>
        /// List of cards offered for this message
        /// </summary>
        /// <value>List of cards offered for this message</value>
        [DataMember(Name="cards", EmitDefaultValue=false)]
        public List<Card> Cards { get; set; }



        /// <summary>
        /// Template notification content.
        /// </summary>
        /// <value>Template notification content.</value>
        [DataMember(Name="notificationTemplate", EmitDefaultValue=false)]
        public RecordingNotificationTemplate NotificationTemplate { get; set; }



        /// <summary>
        /// DatePicker content object.
        /// </summary>
        /// <value>DatePicker content object.</value>
        [DataMember(Name="datePicker", EmitDefaultValue=false)]
        public DatePicker DatePicker { get; set; }



        /// <summary>
        /// ListPicker content object.
        /// </summary>
        /// <value>ListPicker content object.</value>
        [DataMember(Name="listPicker", EmitDefaultValue=false)]
        public ListPicker ListPicker { get; set; }







        /// <summary>
        /// List of event elements
        /// </summary>
        /// <value>List of event elements</value>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<ConversationMessageEvent> Events { get; set; }



        /// <summary>
        /// InteractiveApplication content.
        /// </summary>
        /// <value>InteractiveApplication content.</value>
        [DataMember(Name="interactiveApplication", EmitDefaultValue=false)]
        public InteractiveApplication InteractiveApplication { get; set; }



        /// <summary>
        /// Payment request content.
        /// </summary>
        /// <value>Payment request content.</value>
        [DataMember(Name="paymentRequest", EmitDefaultValue=false)]
        public PaymentRequest PaymentRequest { get; set; }



        /// <summary>
        /// Payment response content.
        /// </summary>
        /// <value>Payment response content.</value>
        [DataMember(Name="paymentResponse", EmitDefaultValue=false)]
        public PaymentResponse PaymentResponse { get; set; }



        /// <summary>
        /// Form content.
        /// </summary>
        /// <value>Form content.</value>
        [DataMember(Name="form", EmitDefaultValue=false)]
        public RecordingForm Form { get; set; }



        /// <summary>
        /// Roadside Assistance content.
        /// </summary>
        /// <value>Roadside Assistance content.</value>
        [DataMember(Name="roadsideAssistance", EmitDefaultValue=false)]
        public RecordingRoadsideAssistance RoadsideAssistance { get; set; }



        /// <summary>
        /// List of message receipts
        /// </summary>
        /// <value>List of message receipts</value>
        [DataMember(Name="messageReceipts", EmitDefaultValue=false)]
        public List<RecordingMessageReceipt> MessageReceipts { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingMessagingMessage {\n");

            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  FromUser: ").Append(FromUser).Append("\n");
            sb.Append("  FromExternalContact: ").Append(FromExternalContact).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  Workflow: ").Append(Workflow).Append("\n");
            sb.Append("  MessageText: ").Append(MessageText).Append("\n");
            sb.Append("  MessageMediaAttachments: ").Append(MessageMediaAttachments).Append("\n");
            sb.Append("  MessageStickerAttachments: ").Append(MessageStickerAttachments).Append("\n");
            sb.Append("  QuickReplies: ").Append(QuickReplies).Append("\n");
            sb.Append("  ButtonResponse: ").Append(ButtonResponse).Append("\n");
            sb.Append("  ButtonResponses: ").Append(ButtonResponses).Append("\n");
            sb.Append("  Story: ").Append(Story).Append("\n");
            sb.Append("  Cards: ").Append(Cards).Append("\n");
            sb.Append("  NotificationTemplate: ").Append(NotificationTemplate).Append("\n");
            sb.Append("  DatePicker: ").Append(DatePicker).Append("\n");
            sb.Append("  ListPicker: ").Append(ListPicker).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  SocialVisibility: ").Append(SocialVisibility).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  InteractiveApplication: ").Append(InteractiveApplication).Append("\n");
            sb.Append("  PaymentRequest: ").Append(PaymentRequest).Append("\n");
            sb.Append("  PaymentResponse: ").Append(PaymentResponse).Append("\n");
            sb.Append("  Form: ").Append(Form).Append("\n");
            sb.Append("  RoadsideAssistance: ").Append(RoadsideAssistance).Append("\n");
            sb.Append("  MessageReceipts: ").Append(MessageReceipts).Append("\n");
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
            return this.Equals(obj as RecordingMessagingMessage);
        }

        /// <summary>
        /// Returns true if RecordingMessagingMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingMessagingMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingMessagingMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) &&
                (
                    this.FromUser == other.FromUser ||
                    this.FromUser != null &&
                    this.FromUser.Equals(other.FromUser)
                ) &&
                (
                    this.FromExternalContact == other.FromExternalContact ||
                    this.FromExternalContact != null &&
                    this.FromExternalContact.Equals(other.FromExternalContact)
                ) &&
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) &&
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Purpose == other.Purpose ||
                    this.Purpose != null &&
                    this.Purpose.Equals(other.Purpose)
                ) &&
                (
                    this.ParticipantId == other.ParticipantId ||
                    this.ParticipantId != null &&
                    this.ParticipantId.Equals(other.ParticipantId)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.Workflow == other.Workflow ||
                    this.Workflow != null &&
                    this.Workflow.Equals(other.Workflow)
                ) &&
                (
                    this.MessageText == other.MessageText ||
                    this.MessageText != null &&
                    this.MessageText.Equals(other.MessageText)
                ) &&
                (
                    this.MessageMediaAttachments == other.MessageMediaAttachments ||
                    this.MessageMediaAttachments != null &&
                    this.MessageMediaAttachments.SequenceEqual(other.MessageMediaAttachments)
                ) &&
                (
                    this.MessageStickerAttachments == other.MessageStickerAttachments ||
                    this.MessageStickerAttachments != null &&
                    this.MessageStickerAttachments.SequenceEqual(other.MessageStickerAttachments)
                ) &&
                (
                    this.QuickReplies == other.QuickReplies ||
                    this.QuickReplies != null &&
                    this.QuickReplies.SequenceEqual(other.QuickReplies)
                ) &&
                (
                    this.ButtonResponse == other.ButtonResponse ||
                    this.ButtonResponse != null &&
                    this.ButtonResponse.Equals(other.ButtonResponse)
                ) &&
                (
                    this.ButtonResponses == other.ButtonResponses ||
                    this.ButtonResponses != null &&
                    this.ButtonResponses.SequenceEqual(other.ButtonResponses)
                ) &&
                (
                    this.Story == other.Story ||
                    this.Story != null &&
                    this.Story.Equals(other.Story)
                ) &&
                (
                    this.Cards == other.Cards ||
                    this.Cards != null &&
                    this.Cards.SequenceEqual(other.Cards)
                ) &&
                (
                    this.NotificationTemplate == other.NotificationTemplate ||
                    this.NotificationTemplate != null &&
                    this.NotificationTemplate.Equals(other.NotificationTemplate)
                ) &&
                (
                    this.DatePicker == other.DatePicker ||
                    this.DatePicker != null &&
                    this.DatePicker.Equals(other.DatePicker)
                ) &&
                (
                    this.ListPicker == other.ListPicker ||
                    this.ListPicker != null &&
                    this.ListPicker.Equals(other.ListPicker)
                ) &&
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) &&
                (
                    this.SocialVisibility == other.SocialVisibility ||
                    this.SocialVisibility != null &&
                    this.SocialVisibility.Equals(other.SocialVisibility)
                ) &&
                (
                    this.Events == other.Events ||
                    this.Events != null &&
                    this.Events.SequenceEqual(other.Events)
                ) &&
                (
                    this.InteractiveApplication == other.InteractiveApplication ||
                    this.InteractiveApplication != null &&
                    this.InteractiveApplication.Equals(other.InteractiveApplication)
                ) &&
                (
                    this.PaymentRequest == other.PaymentRequest ||
                    this.PaymentRequest != null &&
                    this.PaymentRequest.Equals(other.PaymentRequest)
                ) &&
                (
                    this.PaymentResponse == other.PaymentResponse ||
                    this.PaymentResponse != null &&
                    this.PaymentResponse.Equals(other.PaymentResponse)
                ) &&
                (
                    this.Form == other.Form ||
                    this.Form != null &&
                    this.Form.Equals(other.Form)
                ) &&
                (
                    this.RoadsideAssistance == other.RoadsideAssistance ||
                    this.RoadsideAssistance != null &&
                    this.RoadsideAssistance.Equals(other.RoadsideAssistance)
                ) &&
                (
                    this.MessageReceipts == other.MessageReceipts ||
                    this.MessageReceipts != null &&
                    this.MessageReceipts.SequenceEqual(other.MessageReceipts)
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
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();

                if (this.FromUser != null)
                    hash = hash * 59 + this.FromUser.GetHashCode();

                if (this.FromExternalContact != null)
                    hash = hash * 59 + this.FromExternalContact.GetHashCode();

                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();

                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Purpose != null)
                    hash = hash * 59 + this.Purpose.GetHashCode();

                if (this.ParticipantId != null)
                    hash = hash * 59 + this.ParticipantId.GetHashCode();

                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();

                if (this.Workflow != null)
                    hash = hash * 59 + this.Workflow.GetHashCode();

                if (this.MessageText != null)
                    hash = hash * 59 + this.MessageText.GetHashCode();

                if (this.MessageMediaAttachments != null)
                    hash = hash * 59 + this.MessageMediaAttachments.GetHashCode();

                if (this.MessageStickerAttachments != null)
                    hash = hash * 59 + this.MessageStickerAttachments.GetHashCode();

                if (this.QuickReplies != null)
                    hash = hash * 59 + this.QuickReplies.GetHashCode();

                if (this.ButtonResponse != null)
                    hash = hash * 59 + this.ButtonResponse.GetHashCode();

                if (this.ButtonResponses != null)
                    hash = hash * 59 + this.ButtonResponses.GetHashCode();

                if (this.Story != null)
                    hash = hash * 59 + this.Story.GetHashCode();

                if (this.Cards != null)
                    hash = hash * 59 + this.Cards.GetHashCode();

                if (this.NotificationTemplate != null)
                    hash = hash * 59 + this.NotificationTemplate.GetHashCode();

                if (this.DatePicker != null)
                    hash = hash * 59 + this.DatePicker.GetHashCode();

                if (this.ListPicker != null)
                    hash = hash * 59 + this.ListPicker.GetHashCode();

                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();

                if (this.SocialVisibility != null)
                    hash = hash * 59 + this.SocialVisibility.GetHashCode();

                if (this.Events != null)
                    hash = hash * 59 + this.Events.GetHashCode();

                if (this.InteractiveApplication != null)
                    hash = hash * 59 + this.InteractiveApplication.GetHashCode();

                if (this.PaymentRequest != null)
                    hash = hash * 59 + this.PaymentRequest.GetHashCode();

                if (this.PaymentResponse != null)
                    hash = hash * 59 + this.PaymentResponse.GetHashCode();

                if (this.Form != null)
                    hash = hash * 59 + this.Form.GetHashCode();

                if (this.RoadsideAssistance != null)
                    hash = hash * 59 + this.RoadsideAssistance.GetHashCode();

                if (this.MessageReceipts != null)
                    hash = hash * 59 + this.MessageReceipts.GetHashCode();

                return hash;
            }
        }
    }

}
