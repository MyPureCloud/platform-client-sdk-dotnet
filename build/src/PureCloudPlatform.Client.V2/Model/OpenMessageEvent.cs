using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Message event element.
	/// </summary>
	[DataContract]
	public partial class OpenMessageEvent : IEquatable<OpenMessageEvent>
	{
		/// <summary>
		/// Type of this event element
		/// </summary>
		/// <value>Type of this event element</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum EventTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Typing for "Typing"
			/// </summary>
			[EnumMember(Value = "Typing")]
			Typing
		}
		/// <summary>
		/// Type of this event element
		/// </summary>
		/// <value>Type of this event element</value>
		[DataMember(Name = "eventType", EmitDefaultValue = false)]
		public EventTypeEnum? EventType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="OpenMessageEvent" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected OpenMessageEvent() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="OpenMessageEvent" /> class.
		/// </summary>
		/// <param name="EventType">Type of this event element (required).</param>
		/// <param name="Typing">Typing event..</param>
		public OpenMessageEvent(EventTypeEnum? EventType = null, ConversationEventTyping Typing = null)
		{
			this.EventType = EventType;
			this.Typing = Typing;

		}





		/// <summary>
		/// Typing event.
		/// </summary>
		/// <value>Typing event.</value>
		[DataMember(Name = "typing", EmitDefaultValue = false)]
		public ConversationEventTyping Typing { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OpenMessageEvent {\n");

			sb.Append("  EventType: ").Append(EventType).Append("\n");
			sb.Append("  Typing: ").Append(Typing).Append("\n");
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
			return this.Equals(obj as OpenMessageEvent);
		}

		/// <summary>
		/// Returns true if OpenMessageEvent instances are equal
		/// </summary>
		/// <param name="other">Instance of OpenMessageEvent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OpenMessageEvent other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.EventType == other.EventType ||
					this.EventType != null &&
					this.EventType.Equals(other.EventType)
				) &&
				(
					this.Typing == other.Typing ||
					this.Typing != null &&
					this.Typing.Equals(other.Typing)
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
				if (this.EventType != null)
					hash = hash * 59 + this.EventType.GetHashCode();

				if (this.Typing != null)
					hash = hash * 59 + this.Typing.GetHashCode();

				return hash;
			}
		}
	}

}
