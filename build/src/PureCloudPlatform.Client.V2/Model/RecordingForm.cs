using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// RecordingForm
	/// </summary>
	[DataContract]
	public partial class RecordingForm : IEquatable<RecordingForm>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RecordingForm" /> class.
		/// </summary>
		/// <param name="Introduction">The introduction component, used to give an intro into what the form entails..</param>
		/// <param name="FormPages">Form pages..</param>
		/// <param name="ReceivedMessage">Defines the initial prompt message structure containing title and subtitle fields that are displayed to the end user when a form requires completion..</param>
		/// <param name="ReplyMessage">The reply message after the user has filled out the form received..</param>
		/// <param name="Response">Content of the payload included in the Form response..</param>
		/// <param name="OriginatingMessageId">Reference to the id of the original message..</param>
		/// <param name="CannedResponseId">The id of the canned response which was used to create the form..</param>
		public RecordingForm(RecordingIntroduction Introduction = null, List<RecordingFormPage> FormPages = null, ReceivedReplyMessage ReceivedMessage = null, ReceivedReplyMessage ReplyMessage = null, List<RecordingFormResponseComponent> Response = null, string OriginatingMessageId = null, string CannedResponseId = null)
		{
			this.Introduction = Introduction;
			this.FormPages = FormPages;
			this.ReceivedMessage = ReceivedMessage;
			this.ReplyMessage = ReplyMessage;
			this.Response = Response;
			this.OriginatingMessageId = OriginatingMessageId;
			this.CannedResponseId = CannedResponseId;

		}



		/// <summary>
		/// The introduction component, used to give an intro into what the form entails.
		/// </summary>
		/// <value>The introduction component, used to give an intro into what the form entails.</value>
		[DataMember(Name = "introduction", EmitDefaultValue = false)]
		public RecordingIntroduction Introduction { get; set; }



		/// <summary>
		/// Form pages.
		/// </summary>
		/// <value>Form pages.</value>
		[DataMember(Name = "formPages", EmitDefaultValue = false)]
		public List<RecordingFormPage> FormPages { get; set; }



		/// <summary>
		/// Defines the initial prompt message structure containing title and subtitle fields that are displayed to the end user when a form requires completion.
		/// </summary>
		/// <value>Defines the initial prompt message structure containing title and subtitle fields that are displayed to the end user when a form requires completion.</value>
		[DataMember(Name = "receivedMessage", EmitDefaultValue = false)]
		public ReceivedReplyMessage ReceivedMessage { get; set; }



		/// <summary>
		/// The reply message after the user has filled out the form received.
		/// </summary>
		/// <value>The reply message after the user has filled out the form received.</value>
		[DataMember(Name = "replyMessage", EmitDefaultValue = false)]
		public ReceivedReplyMessage ReplyMessage { get; set; }



		/// <summary>
		/// Content of the payload included in the Form response.
		/// </summary>
		/// <value>Content of the payload included in the Form response.</value>
		[DataMember(Name = "response", EmitDefaultValue = false)]
		public List<RecordingFormResponseComponent> Response { get; set; }



		/// <summary>
		/// Reference to the id of the original message.
		/// </summary>
		/// <value>Reference to the id of the original message.</value>
		[DataMember(Name = "originatingMessageId", EmitDefaultValue = false)]
		public string OriginatingMessageId { get; set; }



		/// <summary>
		/// The id of the canned response which was used to create the form.
		/// </summary>
		/// <value>The id of the canned response which was used to create the form.</value>
		[DataMember(Name = "cannedResponseId", EmitDefaultValue = false)]
		public string CannedResponseId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RecordingForm {\n");

			sb.Append("  Introduction: ").Append(Introduction).Append("\n");
			sb.Append("  FormPages: ").Append(FormPages).Append("\n");
			sb.Append("  ReceivedMessage: ").Append(ReceivedMessage).Append("\n");
			sb.Append("  ReplyMessage: ").Append(ReplyMessage).Append("\n");
			sb.Append("  Response: ").Append(Response).Append("\n");
			sb.Append("  OriginatingMessageId: ").Append(OriginatingMessageId).Append("\n");
			sb.Append("  CannedResponseId: ").Append(CannedResponseId).Append("\n");
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
			return this.Equals(obj as RecordingForm);
		}

		/// <summary>
		/// Returns true if RecordingForm instances are equal
		/// </summary>
		/// <param name="other">Instance of RecordingForm to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RecordingForm other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Introduction == other.Introduction ||
					this.Introduction != null &&
					this.Introduction.Equals(other.Introduction)
				) &&
				(
					this.FormPages == other.FormPages ||
					this.FormPages != null &&
					this.FormPages.SequenceEqual(other.FormPages)
				) &&
				(
					this.ReceivedMessage == other.ReceivedMessage ||
					this.ReceivedMessage != null &&
					this.ReceivedMessage.Equals(other.ReceivedMessage)
				) &&
				(
					this.ReplyMessage == other.ReplyMessage ||
					this.ReplyMessage != null &&
					this.ReplyMessage.Equals(other.ReplyMessage)
				) &&
				(
					this.Response == other.Response ||
					this.Response != null &&
					this.Response.SequenceEqual(other.Response)
				) &&
				(
					this.OriginatingMessageId == other.OriginatingMessageId ||
					this.OriginatingMessageId != null &&
					this.OriginatingMessageId.Equals(other.OriginatingMessageId)
				) &&
				(
					this.CannedResponseId == other.CannedResponseId ||
					this.CannedResponseId != null &&
					this.CannedResponseId.Equals(other.CannedResponseId)
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
				if (this.Introduction != null)
					hash = hash * 59 + this.Introduction.GetHashCode();

				if (this.FormPages != null)
					hash = hash * 59 + this.FormPages.GetHashCode();

				if (this.ReceivedMessage != null)
					hash = hash * 59 + this.ReceivedMessage.GetHashCode();

				if (this.ReplyMessage != null)
					hash = hash * 59 + this.ReplyMessage.GetHashCode();

				if (this.Response != null)
					hash = hash * 59 + this.Response.GetHashCode();

				if (this.OriginatingMessageId != null)
					hash = hash * 59 + this.OriginatingMessageId.GetHashCode();

				if (this.CannedResponseId != null)
					hash = hash * 59 + this.CannedResponseId.GetHashCode();

				return hash;
			}
		}
	}

}
