using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// List Picker object for presenting multiple sections of selectable items.
	/// </summary>
	[DataContract]
	public partial class ConversationContentListPicker : IEquatable<ConversationContentListPicker>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationContentListPicker" /> class.
		/// </summary>
		/// <param name="Id">Optional unique identifier to help map component replies to form messages where multiple ListPickers can be present..</param>
		/// <param name="Sections">An array of sections in the List Picker..</param>
		/// <param name="ReplyMessage">The reply message after the user has selected the options from the List Picker..</param>
		/// <param name="ReceivedMessage">The message prompt to select options in the List Picker sections..</param>
		public ConversationContentListPicker(string Id = null, List<ConversationContentListPickerSection> Sections = null, ConversationContentReceivedReplyMessage ReplyMessage = null, ConversationContentReceivedReplyMessage ReceivedMessage = null)
		{
			this.Id = Id;
			this.Sections = Sections;
			this.ReplyMessage = ReplyMessage;
			this.ReceivedMessage = ReceivedMessage;

		}



		/// <summary>
		/// Optional unique identifier to help map component replies to form messages where multiple ListPickers can be present.
		/// </summary>
		/// <value>Optional unique identifier to help map component replies to form messages where multiple ListPickers can be present.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// An array of sections in the List Picker.
		/// </summary>
		/// <value>An array of sections in the List Picker.</value>
		[DataMember(Name = "sections", EmitDefaultValue = false)]
		public List<ConversationContentListPickerSection> Sections { get; set; }



		/// <summary>
		/// The reply message after the user has selected the options from the List Picker.
		/// </summary>
		/// <value>The reply message after the user has selected the options from the List Picker.</value>
		[DataMember(Name = "replyMessage", EmitDefaultValue = false)]
		public ConversationContentReceivedReplyMessage ReplyMessage { get; set; }



		/// <summary>
		/// The message prompt to select options in the List Picker sections.
		/// </summary>
		/// <value>The message prompt to select options in the List Picker sections.</value>
		[DataMember(Name = "receivedMessage", EmitDefaultValue = false)]
		public ConversationContentReceivedReplyMessage ReceivedMessage { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationContentListPicker {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Sections: ").Append(Sections).Append("\n");
			sb.Append("  ReplyMessage: ").Append(ReplyMessage).Append("\n");
			sb.Append("  ReceivedMessage: ").Append(ReceivedMessage).Append("\n");
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
			return this.Equals(obj as ConversationContentListPicker);
		}

		/// <summary>
		/// Returns true if ConversationContentListPicker instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationContentListPicker to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationContentListPicker other)
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
					this.Sections == other.Sections ||
					this.Sections != null &&
					this.Sections.SequenceEqual(other.Sections)
				) &&
				(
					this.ReplyMessage == other.ReplyMessage ||
					this.ReplyMessage != null &&
					this.ReplyMessage.Equals(other.ReplyMessage)
				) &&
				(
					this.ReceivedMessage == other.ReceivedMessage ||
					this.ReceivedMessage != null &&
					this.ReceivedMessage.Equals(other.ReceivedMessage)
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

				if (this.Sections != null)
					hash = hash * 59 + this.Sections.GetHashCode();

				if (this.ReplyMessage != null)
					hash = hash * 59 + this.ReplyMessage.GetHashCode();

				if (this.ReceivedMessage != null)
					hash = hash * 59 + this.ReceivedMessage.GetHashCode();

				return hash;
			}
		}
	}

}
