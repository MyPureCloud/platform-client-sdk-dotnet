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
    /// Message content element. If contentType &#x3D; \&quot;Attachment\&quot; only one item is allowed.
    /// </summary>
    [DataContract]
    public partial class MessageContent :  IEquatable<MessageContent>
    {
        /// <summary>
        /// Type of this content element.
        /// </summary>
        /// <value>Type of this content element.</value>
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
            /// Enum Quickreply for "QuickReply"
            /// </summary>
            [EnumMember(Value = "QuickReply")]
            Quickreply,
            
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
            /// Enum Text for "Text"
            /// </summary>
            [EnumMember(Value = "Text")]
            Text,
            
            /// <summary>
            /// Enum Quickreplyv2 for "QuickReplyV2"
            /// </summary>
            [EnumMember(Value = "QuickReplyV2")]
            Quickreplyv2,
            
            /// <summary>
            /// Enum Datepicker for "DatePicker"
            /// </summary>
            [EnumMember(Value = "DatePicker")]
            Datepicker
        }
        /// <summary>
        /// Type of this content element.
        /// </summary>
        /// <value>Type of this content element.</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public ContentTypeEnum? ContentType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContent" /> class.
        /// </summary>
        /// <param name="ContentType">Type of this content element. (required).</param>
        /// <param name="Attachment">Attachment content..</param>
        /// <param name="QuickReply">Quick reply content..</param>
        /// <param name="ButtonResponse">Button response content..</param>
        /// <param name="Generic">Generic content (Deprecated)..</param>
        /// <param name="List">List content (Deprecated)..</param>
        /// <param name="Template">Template notification content..</param>
        /// <param name="Reactions">A set of reactions to a message..</param>
        /// <param name="Mention">Mention content..</param>
        /// <param name="Postback">Structured message postback (Deprecated)..</param>
        /// <param name="Story">Ephemeral story content..</param>
        /// <param name="Card">Card content.</param>
        /// <param name="Carousel">Carousel content.</param>
        /// <param name="Text">Text content..</param>
        /// <param name="QuickReplyV2">Quick reply V2 content..</param>
        /// <param name="DatePicker">DatePicker content..</param>
        /// <param name="Location">Location content..</param>
        public MessageContent(ContentTypeEnum? ContentType = null, ContentAttachment Attachment = null, ContentQuickReply QuickReply = null, ContentButtonResponse ButtonResponse = null, ContentGeneric Generic = null, ContentList List = null, ContentNotificationTemplate Template = null, List<ContentReaction> Reactions = null, MessagingRecipient Mention = null, ContentPostback Postback = null, ContentStory Story = null, ContentCard Card = null, ContentCarousel Carousel = null, ContentText Text = null, ContentQuickReplyV2 QuickReplyV2 = null, ContentDatePicker DatePicker = null, ContentLocation Location = null)
        {
            this.ContentType = ContentType;
            this.Attachment = Attachment;
            this.QuickReply = QuickReply;
            this.ButtonResponse = ButtonResponse;
            this.Generic = Generic;
            this.List = List;
            this.Template = Template;
            this.Reactions = Reactions;
            this.Mention = Mention;
            this.Postback = Postback;
            this.Story = Story;
            this.Card = Card;
            this.Carousel = Carousel;
            this.Text = Text;
            this.QuickReplyV2 = QuickReplyV2;
            this.DatePicker = DatePicker;
            this.Location = Location;
            
        }
        




        /// <summary>
        /// Attachment content.
        /// </summary>
        /// <value>Attachment content.</value>
        [DataMember(Name="attachment", EmitDefaultValue=false)]
        public ContentAttachment Attachment { get; set; }



        /// <summary>
        /// Quick reply content.
        /// </summary>
        /// <value>Quick reply content.</value>
        [DataMember(Name="quickReply", EmitDefaultValue=false)]
        public ContentQuickReply QuickReply { get; set; }



        /// <summary>
        /// Button response content.
        /// </summary>
        /// <value>Button response content.</value>
        [DataMember(Name="buttonResponse", EmitDefaultValue=false)]
        public ContentButtonResponse ButtonResponse { get; set; }



        /// <summary>
        /// Generic content (Deprecated).
        /// </summary>
        /// <value>Generic content (Deprecated).</value>
        [DataMember(Name="generic", EmitDefaultValue=false)]
        public ContentGeneric Generic { get; set; }



        /// <summary>
        /// List content (Deprecated).
        /// </summary>
        /// <value>List content (Deprecated).</value>
        [DataMember(Name="list", EmitDefaultValue=false)]
        public ContentList List { get; set; }



        /// <summary>
        /// Template notification content.
        /// </summary>
        /// <value>Template notification content.</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public ContentNotificationTemplate Template { get; set; }



        /// <summary>
        /// A set of reactions to a message.
        /// </summary>
        /// <value>A set of reactions to a message.</value>
        [DataMember(Name="reactions", EmitDefaultValue=false)]
        public List<ContentReaction> Reactions { get; set; }



        /// <summary>
        /// Mention content.
        /// </summary>
        /// <value>Mention content.</value>
        [DataMember(Name="mention", EmitDefaultValue=false)]
        public MessagingRecipient Mention { get; set; }



        /// <summary>
        /// Structured message postback (Deprecated).
        /// </summary>
        /// <value>Structured message postback (Deprecated).</value>
        [DataMember(Name="postback", EmitDefaultValue=false)]
        public ContentPostback Postback { get; set; }



        /// <summary>
        /// Ephemeral story content.
        /// </summary>
        /// <value>Ephemeral story content.</value>
        [DataMember(Name="story", EmitDefaultValue=false)]
        public ContentStory Story { get; set; }



        /// <summary>
        /// Card content
        /// </summary>
        /// <value>Card content</value>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public ContentCard Card { get; set; }



        /// <summary>
        /// Carousel content
        /// </summary>
        /// <value>Carousel content</value>
        [DataMember(Name="carousel", EmitDefaultValue=false)]
        public ContentCarousel Carousel { get; set; }



        /// <summary>
        /// Text content.
        /// </summary>
        /// <value>Text content.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public ContentText Text { get; set; }



        /// <summary>
        /// Quick reply V2 content.
        /// </summary>
        /// <value>Quick reply V2 content.</value>
        [DataMember(Name="quickReplyV2", EmitDefaultValue=false)]
        public ContentQuickReplyV2 QuickReplyV2 { get; set; }



        /// <summary>
        /// DatePicker content.
        /// </summary>
        /// <value>DatePicker content.</value>
        [DataMember(Name="datePicker", EmitDefaultValue=false)]
        public ContentDatePicker DatePicker { get; set; }



        /// <summary>
        /// Location content.
        /// </summary>
        /// <value>Location content.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public ContentLocation Location { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageContent {\n");

            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Attachment: ").Append(Attachment).Append("\n");
            sb.Append("  QuickReply: ").Append(QuickReply).Append("\n");
            sb.Append("  ButtonResponse: ").Append(ButtonResponse).Append("\n");
            sb.Append("  Generic: ").Append(Generic).Append("\n");
            sb.Append("  List: ").Append(List).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Reactions: ").Append(Reactions).Append("\n");
            sb.Append("  Mention: ").Append(Mention).Append("\n");
            sb.Append("  Postback: ").Append(Postback).Append("\n");
            sb.Append("  Story: ").Append(Story).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  Carousel: ").Append(Carousel).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  QuickReplyV2: ").Append(QuickReplyV2).Append("\n");
            sb.Append("  DatePicker: ").Append(DatePicker).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(obj as MessageContent);
        }

        /// <summary>
        /// Returns true if MessageContent instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageContent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) &&
                (
                    this.Attachment == other.Attachment ||
                    this.Attachment != null &&
                    this.Attachment.Equals(other.Attachment)
                ) &&
                (
                    this.QuickReply == other.QuickReply ||
                    this.QuickReply != null &&
                    this.QuickReply.Equals(other.QuickReply)
                ) &&
                (
                    this.ButtonResponse == other.ButtonResponse ||
                    this.ButtonResponse != null &&
                    this.ButtonResponse.Equals(other.ButtonResponse)
                ) &&
                (
                    this.Generic == other.Generic ||
                    this.Generic != null &&
                    this.Generic.Equals(other.Generic)
                ) &&
                (
                    this.List == other.List ||
                    this.List != null &&
                    this.List.Equals(other.List)
                ) &&
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) &&
                (
                    this.Reactions == other.Reactions ||
                    this.Reactions != null &&
                    this.Reactions.SequenceEqual(other.Reactions)
                ) &&
                (
                    this.Mention == other.Mention ||
                    this.Mention != null &&
                    this.Mention.Equals(other.Mention)
                ) &&
                (
                    this.Postback == other.Postback ||
                    this.Postback != null &&
                    this.Postback.Equals(other.Postback)
                ) &&
                (
                    this.Story == other.Story ||
                    this.Story != null &&
                    this.Story.Equals(other.Story)
                ) &&
                (
                    this.Card == other.Card ||
                    this.Card != null &&
                    this.Card.Equals(other.Card)
                ) &&
                (
                    this.Carousel == other.Carousel ||
                    this.Carousel != null &&
                    this.Carousel.Equals(other.Carousel)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.QuickReplyV2 == other.QuickReplyV2 ||
                    this.QuickReplyV2 != null &&
                    this.QuickReplyV2.Equals(other.QuickReplyV2)
                ) &&
                (
                    this.DatePicker == other.DatePicker ||
                    this.DatePicker != null &&
                    this.DatePicker.Equals(other.DatePicker)
                ) &&
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
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
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();

                if (this.Attachment != null)
                    hash = hash * 59 + this.Attachment.GetHashCode();

                if (this.QuickReply != null)
                    hash = hash * 59 + this.QuickReply.GetHashCode();

                if (this.ButtonResponse != null)
                    hash = hash * 59 + this.ButtonResponse.GetHashCode();

                if (this.Generic != null)
                    hash = hash * 59 + this.Generic.GetHashCode();

                if (this.List != null)
                    hash = hash * 59 + this.List.GetHashCode();

                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();

                if (this.Reactions != null)
                    hash = hash * 59 + this.Reactions.GetHashCode();

                if (this.Mention != null)
                    hash = hash * 59 + this.Mention.GetHashCode();

                if (this.Postback != null)
                    hash = hash * 59 + this.Postback.GetHashCode();

                if (this.Story != null)
                    hash = hash * 59 + this.Story.GetHashCode();

                if (this.Card != null)
                    hash = hash * 59 + this.Card.GetHashCode();

                if (this.Carousel != null)
                    hash = hash * 59 + this.Carousel.GetHashCode();

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.QuickReplyV2 != null)
                    hash = hash * 59 + this.QuickReplyV2.GetHashCode();

                if (this.DatePicker != null)
                    hash = hash * 59 + this.DatePicker.GetHashCode();

                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();

                return hash;
            }
        }
    }

}
