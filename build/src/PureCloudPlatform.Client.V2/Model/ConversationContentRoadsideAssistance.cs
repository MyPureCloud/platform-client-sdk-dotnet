using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// RoadsideAssistance content object.
	/// </summary>
	[DataContract]
	public partial class ConversationContentRoadsideAssistance : IEquatable<ConversationContentRoadsideAssistance>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationContentRoadsideAssistance" /> class.
		/// </summary>
		/// <param name="Text">The Roadside Assistance message text.</param>
		/// <param name="PhoneNumber">Phone number the user provided.</param>
		/// <param name="IsDevicePhoneNumber">If the user provided their own phone number.</param>
		/// <param name="Location">User Location object.</param>
		/// <param name="MessageNumber">The counter of the message.</param>
		public ConversationContentRoadsideAssistance(string Text = null, string PhoneNumber = null, bool? IsDevicePhoneNumber = null, ConversationContentLocation Location = null, long? MessageNumber = null)
		{
			this.Text = Text;
			this.PhoneNumber = PhoneNumber;
			this.IsDevicePhoneNumber = IsDevicePhoneNumber;
			this.Location = Location;
			this.MessageNumber = MessageNumber;

		}



		/// <summary>
		/// The Roadside Assistance message text
		/// </summary>
		/// <value>The Roadside Assistance message text</value>
		[DataMember(Name = "text", EmitDefaultValue = false)]
		public string Text { get; set; }



		/// <summary>
		/// Phone number the user provided
		/// </summary>
		/// <value>Phone number the user provided</value>
		[DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
		public string PhoneNumber { get; set; }



		/// <summary>
		/// If the user provided their own phone number
		/// </summary>
		/// <value>If the user provided their own phone number</value>
		[DataMember(Name = "isDevicePhoneNumber", EmitDefaultValue = false)]
		public bool? IsDevicePhoneNumber { get; set; }



		/// <summary>
		/// User Location object
		/// </summary>
		/// <value>User Location object</value>
		[DataMember(Name = "location", EmitDefaultValue = false)]
		public ConversationContentLocation Location { get; set; }



		/// <summary>
		/// The counter of the message
		/// </summary>
		/// <value>The counter of the message</value>
		[DataMember(Name = "messageNumber", EmitDefaultValue = false)]
		public long? MessageNumber { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationContentRoadsideAssistance {\n");

			sb.Append("  Text: ").Append(Text).Append("\n");
			sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
			sb.Append("  IsDevicePhoneNumber: ").Append(IsDevicePhoneNumber).Append("\n");
			sb.Append("  Location: ").Append(Location).Append("\n");
			sb.Append("  MessageNumber: ").Append(MessageNumber).Append("\n");
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
			return this.Equals(obj as ConversationContentRoadsideAssistance);
		}

		/// <summary>
		/// Returns true if ConversationContentRoadsideAssistance instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationContentRoadsideAssistance to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationContentRoadsideAssistance other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Text == other.Text ||
					this.Text != null &&
					this.Text.Equals(other.Text)
				) &&
				(
					this.PhoneNumber == other.PhoneNumber ||
					this.PhoneNumber != null &&
					this.PhoneNumber.Equals(other.PhoneNumber)
				) &&
				(
					this.IsDevicePhoneNumber == other.IsDevicePhoneNumber ||
					this.IsDevicePhoneNumber != null &&
					this.IsDevicePhoneNumber.Equals(other.IsDevicePhoneNumber)
				) &&
				(
					this.Location == other.Location ||
					this.Location != null &&
					this.Location.Equals(other.Location)
				) &&
				(
					this.MessageNumber == other.MessageNumber ||
					this.MessageNumber != null &&
					this.MessageNumber.Equals(other.MessageNumber)
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
				if (this.Text != null)
					hash = hash * 59 + this.Text.GetHashCode();

				if (this.PhoneNumber != null)
					hash = hash * 59 + this.PhoneNumber.GetHashCode();

				if (this.IsDevicePhoneNumber != null)
					hash = hash * 59 + this.IsDevicePhoneNumber.GetHashCode();

				if (this.Location != null)
					hash = hash * 59 + this.Location.GetHashCode();

				if (this.MessageNumber != null)
					hash = hash * 59 + this.MessageNumber.GetHashCode();

				return hash;
			}
		}
	}

}
