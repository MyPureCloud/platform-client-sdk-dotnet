using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Message content element. If contentType &#x3D; \&quot;Attachment\&quot; only one item is allowed.
	/// </summary>
	[DataContract]
	public partial class ConversationMessageContent : IEquatable<ConversationMessageContent>
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
			/// Enum Reactions for "Reactions"
			/// </summary>
			[EnumMember(Value = "Reactions")]
			Reactions,

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
			Datepicker,

			/// <summary>
			/// Enum Interactiveapplication for "InteractiveApplication"
			/// </summary>
			[EnumMember(Value = "InteractiveApplication")]
			Interactiveapplication,

			/// <summary>
			/// Enum Listpicker for "ListPicker"
			/// </summary>
			[EnumMember(Value = "ListPicker")]
			Listpicker,

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
			/// Enum Push for "Push"
			/// </summary>
			[EnumMember(Value = "Push")]
			Push,

			/// <summary>
			/// Enum Form for "Form"
			/// </summary>
			[EnumMember(Value = "Form")]
			Form,

			/// <summary>
			/// Enum Roadsideassistance for "RoadsideAssistance"
			/// </summary>
			[EnumMember(Value = "RoadsideAssistance")]
			Roadsideassistance,

			/// <summary>
			/// Enum Richlink for "RichLink"
			/// </summary>
			[EnumMember(Value = "RichLink")]
			Richlink,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown
		}
		/// <summary>
		/// Type of this content element.
		/// </summary>
		/// <value>Type of this content element.</value>
		[DataMember(Name = "contentType", EmitDefaultValue = false)]
		public ContentTypeEnum? ContentType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationMessageContent" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ConversationMessageContent() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationMessageContent" /> class.
		/// </summary>
		/// <param name="ContentType">Type of this content element. (required).</param>
		/// <param name="Location">Location content..</param>
		/// <param name="Attachment">Attachment content..</param>
		/// <param name="QuickReply">Quick reply content..</param>
		/// <param name="ButtonResponse">Button response content..</param>
		/// <param name="Template">Template notification content..</param>
		/// <param name="Story">Ephemeral story content..</param>
		/// <param name="Card">Card content.</param>
		/// <param name="Carousel">Carousel content.</param>
		/// <param name="Text">Text content..</param>
		/// <param name="QuickReplyV2">Quick reply V2 content..</param>
		/// <param name="Reactions">A set of reactions to a message..</param>
		/// <param name="DatePicker">Date picker content..</param>
		/// <param name="InteractiveApplication">InteractiveApplication content..</param>
		/// <param name="ListPicker">List picker content..</param>
		/// <param name="PaymentRequest">Payment request content..</param>
		/// <param name="PaymentResponse">Payment response content..</param>
		/// <param name="Push">Push content..</param>
		/// <param name="Form">Form content..</param>
		public ConversationMessageContent(ContentTypeEnum? ContentType = null, ConversationContentLocation Location = null, ConversationContentAttachment Attachment = null, ConversationContentQuickReply QuickReply = null, ConversationContentButtonResponse ButtonResponse = null, ConversationContentNotificationTemplate Template = null, ConversationContentStory Story = null, ConversationContentCard Card = null, ConversationContentCarousel Carousel = null, ConversationContentText Text = null, ConversationContentQuickReplyV2 QuickReplyV2 = null, List<ConversationContentReaction> Reactions = null, ConversationContentDatePicker DatePicker = null, ConversationContentInteractiveApplication InteractiveApplication = null, ConversationContentListPicker ListPicker = null, ConversationContentPaymentRequest PaymentRequest = null, ConversationContentPaymentResponse PaymentResponse = null, ConversationContentPush Push = null, ConversationContentForm Form = null)
		{
			this.ContentType = ContentType;
			this.Location = Location;
			this.Attachment = Attachment;
			this.QuickReply = QuickReply;
			this.ButtonResponse = ButtonResponse;
			this.Template = Template;
			this.Story = Story;
			this.Card = Card;
			this.Carousel = Carousel;
			this.Text = Text;
			this.QuickReplyV2 = QuickReplyV2;
			this.Reactions = Reactions;
			this.DatePicker = DatePicker;
			this.InteractiveApplication = InteractiveApplication;
			this.ListPicker = ListPicker;
			this.PaymentRequest = PaymentRequest;
			this.PaymentResponse = PaymentResponse;
			this.Push = Push;
			this.Form = Form;

		}





		/// <summary>
		/// Location content.
		/// </summary>
		/// <value>Location content.</value>
		[DataMember(Name = "location", EmitDefaultValue = false)]
		public ConversationContentLocation Location { get; set; }



		/// <summary>
		/// Attachment content.
		/// </summary>
		/// <value>Attachment content.</value>
		[DataMember(Name = "attachment", EmitDefaultValue = false)]
		public ConversationContentAttachment Attachment { get; set; }



		/// <summary>
		/// Quick reply content.
		/// </summary>
		/// <value>Quick reply content.</value>
		[DataMember(Name = "quickReply", EmitDefaultValue = false)]
		public ConversationContentQuickReply QuickReply { get; set; }



		/// <summary>
		/// Button response content.
		/// </summary>
		/// <value>Button response content.</value>
		[DataMember(Name = "buttonResponse", EmitDefaultValue = false)]
		public ConversationContentButtonResponse ButtonResponse { get; set; }



		/// <summary>
		/// Template notification content.
		/// </summary>
		/// <value>Template notification content.</value>
		[DataMember(Name = "template", EmitDefaultValue = false)]
		public ConversationContentNotificationTemplate Template { get; set; }



		/// <summary>
		/// Ephemeral story content.
		/// </summary>
		/// <value>Ephemeral story content.</value>
		[DataMember(Name = "story", EmitDefaultValue = false)]
		public ConversationContentStory Story { get; set; }



		/// <summary>
		/// Card content
		/// </summary>
		/// <value>Card content</value>
		[DataMember(Name = "card", EmitDefaultValue = false)]
		public ConversationContentCard Card { get; set; }



		/// <summary>
		/// Carousel content
		/// </summary>
		/// <value>Carousel content</value>
		[DataMember(Name = "carousel", EmitDefaultValue = false)]
		public ConversationContentCarousel Carousel { get; set; }



		/// <summary>
		/// Text content.
		/// </summary>
		/// <value>Text content.</value>
		[DataMember(Name = "text", EmitDefaultValue = false)]
		public ConversationContentText Text { get; set; }



		/// <summary>
		/// Quick reply V2 content.
		/// </summary>
		/// <value>Quick reply V2 content.</value>
		[DataMember(Name = "quickReplyV2", EmitDefaultValue = false)]
		public ConversationContentQuickReplyV2 QuickReplyV2 { get; set; }



		/// <summary>
		/// A set of reactions to a message.
		/// </summary>
		/// <value>A set of reactions to a message.</value>
		[DataMember(Name = "reactions", EmitDefaultValue = false)]
		public List<ConversationContentReaction> Reactions { get; set; }



		/// <summary>
		/// Date picker content.
		/// </summary>
		/// <value>Date picker content.</value>
		[DataMember(Name = "datePicker", EmitDefaultValue = false)]
		public ConversationContentDatePicker DatePicker { get; set; }



		/// <summary>
		/// InteractiveApplication content.
		/// </summary>
		/// <value>InteractiveApplication content.</value>
		[DataMember(Name = "interactiveApplication", EmitDefaultValue = false)]
		public ConversationContentInteractiveApplication InteractiveApplication { get; set; }



		/// <summary>
		/// List picker content.
		/// </summary>
		/// <value>List picker content.</value>
		[DataMember(Name = "listPicker", EmitDefaultValue = false)]
		public ConversationContentListPicker ListPicker { get; set; }



		/// <summary>
		/// Payment request content.
		/// </summary>
		/// <value>Payment request content.</value>
		[DataMember(Name = "paymentRequest", EmitDefaultValue = false)]
		public ConversationContentPaymentRequest PaymentRequest { get; set; }



		/// <summary>
		/// Payment response content.
		/// </summary>
		/// <value>Payment response content.</value>
		[DataMember(Name = "paymentResponse", EmitDefaultValue = false)]
		public ConversationContentPaymentResponse PaymentResponse { get; set; }



		/// <summary>
		/// Push content.
		/// </summary>
		/// <value>Push content.</value>
		[DataMember(Name = "push", EmitDefaultValue = false)]
		public ConversationContentPush Push { get; set; }



		/// <summary>
		/// Form content.
		/// </summary>
		/// <value>Form content.</value>
		[DataMember(Name = "form", EmitDefaultValue = false)]
		public ConversationContentForm Form { get; set; }


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
			sb.Append("  Attachment: ").Append(Attachment).Append("\n");
			sb.Append("  QuickReply: ").Append(QuickReply).Append("\n");
			sb.Append("  ButtonResponse: ").Append(ButtonResponse).Append("\n");
			sb.Append("  Template: ").Append(Template).Append("\n");
			sb.Append("  Story: ").Append(Story).Append("\n");
			sb.Append("  Card: ").Append(Card).Append("\n");
			sb.Append("  Carousel: ").Append(Carousel).Append("\n");
			sb.Append("  Text: ").Append(Text).Append("\n");
			sb.Append("  QuickReplyV2: ").Append(QuickReplyV2).Append("\n");
			sb.Append("  Reactions: ").Append(Reactions).Append("\n");
			sb.Append("  DatePicker: ").Append(DatePicker).Append("\n");
			sb.Append("  InteractiveApplication: ").Append(InteractiveApplication).Append("\n");
			sb.Append("  ListPicker: ").Append(ListPicker).Append("\n");
			sb.Append("  PaymentRequest: ").Append(PaymentRequest).Append("\n");
			sb.Append("  PaymentResponse: ").Append(PaymentResponse).Append("\n");
			sb.Append("  Push: ").Append(Push).Append("\n");
			sb.Append("  Form: ").Append(Form).Append("\n");
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
					this.Template == other.Template ||
					this.Template != null &&
					this.Template.Equals(other.Template)
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
					this.Reactions == other.Reactions ||
					this.Reactions != null &&
					this.Reactions.SequenceEqual(other.Reactions)
				) &&
				(
					this.DatePicker == other.DatePicker ||
					this.DatePicker != null &&
					this.DatePicker.Equals(other.DatePicker)
				) &&
				(
					this.InteractiveApplication == other.InteractiveApplication ||
					this.InteractiveApplication != null &&
					this.InteractiveApplication.Equals(other.InteractiveApplication)
				) &&
				(
					this.ListPicker == other.ListPicker ||
					this.ListPicker != null &&
					this.ListPicker.Equals(other.ListPicker)
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
					this.Push == other.Push ||
					this.Push != null &&
					this.Push.Equals(other.Push)
				) &&
				(
					this.Form == other.Form ||
					this.Form != null &&
					this.Form.Equals(other.Form)
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

				if (this.Attachment != null)
					hash = hash * 59 + this.Attachment.GetHashCode();

				if (this.QuickReply != null)
					hash = hash * 59 + this.QuickReply.GetHashCode();

				if (this.ButtonResponse != null)
					hash = hash * 59 + this.ButtonResponse.GetHashCode();

				if (this.Template != null)
					hash = hash * 59 + this.Template.GetHashCode();

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

				if (this.Reactions != null)
					hash = hash * 59 + this.Reactions.GetHashCode();

				if (this.DatePicker != null)
					hash = hash * 59 + this.DatePicker.GetHashCode();

				if (this.InteractiveApplication != null)
					hash = hash * 59 + this.InteractiveApplication.GetHashCode();

				if (this.ListPicker != null)
					hash = hash * 59 + this.ListPicker.GetHashCode();

				if (this.PaymentRequest != null)
					hash = hash * 59 + this.PaymentRequest.GetHashCode();

				if (this.PaymentResponse != null)
					hash = hash * 59 + this.PaymentResponse.GetHashCode();

				if (this.Push != null)
					hash = hash * 59 + this.Push.GetHashCode();

				if (this.Form != null)
					hash = hash * 59 + this.Form.GetHashCode();

				return hash;
			}
		}
	}

}
