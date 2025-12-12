using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Metadata information about a message.
	/// </summary>
	[DataContract]
	public partial class ConversationMessageMetadata : IEquatable<ConversationMessageMetadata>
	{
		/// <summary>
		/// Message type.
		/// </summary>
		/// <value>Message type.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Text for "Text"
			/// </summary>
			[EnumMember(Value = "Text")]
			Text,

			/// <summary>
			/// Enum Structured for "Structured"
			/// </summary>
			[EnumMember(Value = "Structured")]
			Structured,

			/// <summary>
			/// Enum Receipt for "Receipt"
			/// </summary>
			[EnumMember(Value = "Receipt")]
			Receipt,

			/// <summary>
			/// Enum Event for "Event"
			/// </summary>
			[EnumMember(Value = "Event")]
			Event,

			/// <summary>
			/// Enum Message for "Message"
			/// </summary>
			[EnumMember(Value = "Message")]
			Message,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown
		}
		/// <summary>
		/// Message type.
		/// </summary>
		/// <value>Message type.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationMessageMetadata" /> class.
		/// </summary>
		/// <param name="Type">Message type..</param>
		/// <param name="Events">List of events metadata.</param>
		/// <param name="Content">List of message content.</param>
		public ConversationMessageMetadata(TypeEnum? Type = null, List<ConversationMessageMetadataEvent> Events = null, List<ConversationMessageMetadataContent> Content = null)
		{
			this.Type = Type;
			this.Events = Events;
			this.Content = Content;

		}





		/// <summary>
		/// List of events metadata
		/// </summary>
		/// <value>List of events metadata</value>
		[DataMember(Name = "events", EmitDefaultValue = false)]
		public List<ConversationMessageMetadataEvent> Events { get; set; }



		/// <summary>
		/// List of message content
		/// </summary>
		/// <value>List of message content</value>
		[DataMember(Name = "content", EmitDefaultValue = false)]
		public List<ConversationMessageMetadataContent> Content { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationMessageMetadata {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Events: ").Append(Events).Append("\n");
			sb.Append("  Content: ").Append(Content).Append("\n");
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
			return this.Equals(obj as ConversationMessageMetadata);
		}

		/// <summary>
		/// Returns true if ConversationMessageMetadata instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationMessageMetadata to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationMessageMetadata other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Events == other.Events ||
					this.Events != null &&
					this.Events.SequenceEqual(other.Events)
				) &&
				(
					this.Content == other.Content ||
					this.Content != null &&
					this.Content.SequenceEqual(other.Content)
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
				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Events != null)
					hash = hash * 59 + this.Events.GetHashCode();

				if (this.Content != null)
					hash = hash * 59 + this.Content.GetHashCode();

				return hash;
			}
		}
	}

}
