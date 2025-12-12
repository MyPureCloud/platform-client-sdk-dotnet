using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// V2ConversationMessageTypingEventForWorkflowTopicConversationEventTyping
	/// </summary>
	[DataContract]
	public partial class V2ConversationMessageTypingEventForWorkflowTopicConversationEventTyping : IEquatable<V2ConversationMessageTypingEventForWorkflowTopicConversationEventTyping>
	{
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
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
			/// Enum On for "On"
			/// </summary>
			[EnumMember(Value = "On")]
			On
		}
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="V2ConversationMessageTypingEventForWorkflowTopicConversationEventTyping" /> class.
		/// </summary>
		/// <param name="Type">Type.</param>
		/// <param name="Duration">Duration.</param>
		public V2ConversationMessageTypingEventForWorkflowTopicConversationEventTyping(TypeEnum? Type = null, long? Duration = null)
		{
			this.Type = Type;
			this.Duration = Duration;

		}





		/// <summary>
		/// Gets or Sets Duration
		/// </summary>
		[DataMember(Name = "duration", EmitDefaultValue = false)]
		public long? Duration { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2ConversationMessageTypingEventForWorkflowTopicConversationEventTyping {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Duration: ").Append(Duration).Append("\n");
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
			return this.Equals(obj as V2ConversationMessageTypingEventForWorkflowTopicConversationEventTyping);
		}

		/// <summary>
		/// Returns true if V2ConversationMessageTypingEventForWorkflowTopicConversationEventTyping instances are equal
		/// </summary>
		/// <param name="other">Instance of V2ConversationMessageTypingEventForWorkflowTopicConversationEventTyping to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2ConversationMessageTypingEventForWorkflowTopicConversationEventTyping other)
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
					this.Duration == other.Duration ||
					this.Duration != null &&
					this.Duration.Equals(other.Duration)
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

				if (this.Duration != null)
					hash = hash * 59 + this.Duration.GetHashCode();

				return hash;
			}
		}
	}

}
