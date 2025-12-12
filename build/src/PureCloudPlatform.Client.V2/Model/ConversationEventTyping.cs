using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// A Typing event.
	/// </summary>
	[DataContract]
	public partial class ConversationEventTyping : IEquatable<ConversationEventTyping>
	{
		/// <summary>
		/// Describes the type of Typing event.
		/// </summary>
		/// <value>Describes the type of Typing event.</value>
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
		/// Describes the type of Typing event.
		/// </summary>
		/// <value>Describes the type of Typing event.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationEventTyping" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ConversationEventTyping() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationEventTyping" /> class.
		/// </summary>
		/// <param name="Type">Describes the type of Typing event. (required).</param>
		/// <param name="Duration">The duration of the Typing event in milliseconds..</param>
		public ConversationEventTyping(TypeEnum? Type = null, long? Duration = null)
		{
			this.Type = Type;
			this.Duration = Duration;

		}





		/// <summary>
		/// The duration of the Typing event in milliseconds.
		/// </summary>
		/// <value>The duration of the Typing event in milliseconds.</value>
		[DataMember(Name = "duration", EmitDefaultValue = false)]
		public long? Duration { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationEventTyping {\n");

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
			return this.Equals(obj as ConversationEventTyping);
		}

		/// <summary>
		/// Returns true if ConversationEventTyping instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationEventTyping to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationEventTyping other)
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
