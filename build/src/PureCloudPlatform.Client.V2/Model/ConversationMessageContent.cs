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
    /// Message content element.
    /// </summary>
    [DataContract]
    public partial class ConversationMessageContent :  IEquatable<ConversationMessageContent>
    {
        /// <summary>
        /// Type of this content element. If contentType = \"Attachment\" only one item is allowed.
        /// </summary>
        /// <value>Type of this content element. If contentType = \"Attachment\" only one item is allowed.</value>
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
            /// Enum Story for "Story"
            /// </summary>
            [EnumMember(Value = "Story")]
            Story,
            
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
            /// Enum Buttonresponse for "ButtonResponse"
            /// </summary>
            [EnumMember(Value = "ButtonResponse")]
            Buttonresponse,
            
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
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Type of this content element. If contentType = \"Attachment\" only one item is allowed.
        /// </summary>
        /// <value>Type of this content element. If contentType = \"Attachment\" only one item is allowed.</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public ContentTypeEnum? ContentType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationMessageContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationMessageContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationMessageContent" /> class.
        /// </summary>
        /// <param name="ContentType">Type of this content element. If contentType = \"Attachment\" only one item is allowed. (required).</param>
        /// <param name="Location">Location content..</param>
        /// <param name="Story">Ephemeral story content..</param>
        /// <param name="Attachment">Attachment content..</param>
        /// <param name="QuickReply">Quick reply content..</param>
        /// <param name="Template">Template notification content..</param>
        /// <param name="ButtonResponse">Button response content..</param>
        /// <param name="Generic">Generic Template Object (Deprecated)..</param>
        /// <param name="Card">Card (Generic Template) Object.</param>
        /// <param name="Carousel">Carousel (Multiple Generic Template) Object.</param>
        public ConversationMessageContent(ContentTypeEnum? ContentType = null, ConversationContentLocation Location = null, ConversationContentStory Story = null, ConversationContentAttachment Attachment = null, ConversationContentQuickReply QuickReply = null, ConversationContentNotificationTemplate Template = null, ConversationContentButtonResponse ButtonResponse = null, ConversationContentGeneric Generic = null, ConversationContentCard Card = null, ConversationContentCarousel Carousel = null)
        {
            this.ContentType = ContentType;
            this.Location = Location;
            this.Story = Story;
            this.Attachment = Attachment;
            this.QuickReply = QuickReply;
            this.Template = Template;
            this.ButtonResponse = ButtonResponse;
            this.Generic = Generic;
            this.Card = Card;
            this.Carousel = Carousel;
            
        }
        




        /// <summary>
        /// Location content.
        /// </summary>
        /// <value>Location content.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public ConversationContentLocation Location { get; set; }



        /// <summary>
        /// Ephemeral story content.
        /// </summary>
        /// <value>Ephemeral story content.</value>
        [DataMember(Name="story", EmitDefaultValue=false)]
        public ConversationContentStory Story { get; set; }



        /// <summary>
        /// Attachment content.
        /// </summary>
        /// <value>Attachment content.</value>
        [DataMember(Name="attachment", EmitDefaultValue=false)]
        public ConversationContentAttachment Attachment { get; set; }



        /// <summary>
        /// Quick reply content.
        /// </summary>
        /// <value>Quick reply content.</value>
        [DataMember(Name="quickReply", EmitDefaultValue=false)]
        public ConversationContentQuickReply QuickReply { get; set; }



        /// <summary>
        /// Template notification content.
        /// </summary>
        /// <value>Template notification content.</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public ConversationContentNotificationTemplate Template { get; set; }



        /// <summary>
        /// Button response content.
        /// </summary>
        /// <value>Button response content.</value>
        [DataMember(Name="buttonResponse", EmitDefaultValue=false)]
        public ConversationContentButtonResponse ButtonResponse { get; set; }



        /// <summary>
        /// Generic Template Object (Deprecated).
        /// </summary>
        /// <value>Generic Template Object (Deprecated).</value>
        [DataMember(Name="generic", EmitDefaultValue=false)]
        public ConversationContentGeneric Generic { get; set; }



        /// <summary>
        /// Card (Generic Template) Object
        /// </summary>
        /// <value>Card (Generic Template) Object</value>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public ConversationContentCard Card { get; set; }



        /// <summary>
        /// Carousel (Multiple Generic Template) Object
        /// </summary>
        /// <value>Carousel (Multiple Generic Template) Object</value>
        [DataMember(Name="carousel", EmitDefaultValue=false)]
        public ConversationContentCarousel Carousel { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationMessageContent {\n");

            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Story: ").Append(Story).Append("\n");
            sb.Append("  Attachment: ").Append(Attachment).Append("\n");
            sb.Append("  QuickReply: ").Append(QuickReply).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  ButtonResponse: ").Append(ButtonResponse).Append("\n");
            sb.Append("  Generic: ").Append(Generic).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  Carousel: ").Append(Carousel).Append("\n");
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
            return this.Equals(obj as ConversationMessageContent);
        }

        /// <summary>
        /// Returns true if ConversationMessageContent instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationMessageContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationMessageContent other)
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
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) &&
                (
                    this.Story == other.Story ||
                    this.Story != null &&
                    this.Story.Equals(other.Story)
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
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
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
                    this.Card == other.Card ||
                    this.Card != null &&
                    this.Card.Equals(other.Card)
                ) &&
                (
                    this.Carousel == other.Carousel ||
                    this.Carousel != null &&
                    this.Carousel.Equals(other.Carousel)
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

                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();

                if (this.Story != null)
                    hash = hash * 59 + this.Story.GetHashCode();

                if (this.Attachment != null)
                    hash = hash * 59 + this.Attachment.GetHashCode();

                if (this.QuickReply != null)
                    hash = hash * 59 + this.QuickReply.GetHashCode();

                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();

                if (this.ButtonResponse != null)
                    hash = hash * 59 + this.ButtonResponse.GetHashCode();

                if (this.Generic != null)
                    hash = hash * 59 + this.Generic.GetHashCode();

                if (this.Card != null)
                    hash = hash * 59 + this.Card.GetHashCode();

                if (this.Carousel != null)
                    hash = hash * 59 + this.Carousel.GetHashCode();

                return hash;
            }
        }
    }

}
