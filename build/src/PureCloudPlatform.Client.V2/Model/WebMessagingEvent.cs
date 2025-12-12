using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Message event element.  Examples include: system messages, typing indicators, cobrowse offerings.
	/// </summary>
	[DataContract]
	public partial class WebMessagingEvent : IEquatable<WebMessagingEvent>
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
			/// Enum Cobrowse for "CoBrowse"
			/// </summary>
			[EnumMember(Value = "CoBrowse")]
			Cobrowse,

			/// <summary>
			/// Enum Presence for "Presence"
			/// </summary>
			[EnumMember(Value = "Presence")]
			Presence
		}
		/// <summary>
		/// Type of this event element
		/// </summary>
		/// <value>Type of this event element</value>
		[DataMember(Name = "eventType", EmitDefaultValue = false)]
		public EventTypeEnum? EventType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="WebMessagingEvent" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected WebMessagingEvent() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="WebMessagingEvent" /> class.
		/// </summary>
		/// <param name="EventType">Type of this event element (required).</param>
		/// <param name="CoBrowse">Cobrowse event..</param>
		/// <param name="Presence">Presence event..</param>
		public WebMessagingEvent(EventTypeEnum? EventType = null, WebMessagingEventCoBrowse CoBrowse = null, WebMessagingEventPresence Presence = null)
		{
			this.EventType = EventType;
			this.CoBrowse = CoBrowse;
			this.Presence = Presence;

		}





		/// <summary>
		/// Cobrowse event.
		/// </summary>
		/// <value>Cobrowse event.</value>
		[DataMember(Name = "coBrowse", EmitDefaultValue = false)]
		public WebMessagingEventCoBrowse CoBrowse { get; set; }



		/// <summary>
		/// Presence event.
		/// </summary>
		/// <value>Presence event.</value>
		[DataMember(Name = "presence", EmitDefaultValue = false)]
		public WebMessagingEventPresence Presence { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WebMessagingEvent {\n");

			sb.Append("  EventType: ").Append(EventType).Append("\n");
			sb.Append("  CoBrowse: ").Append(CoBrowse).Append("\n");
			sb.Append("  Presence: ").Append(Presence).Append("\n");
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
			return this.Equals(obj as WebMessagingEvent);
		}

		/// <summary>
		/// Returns true if WebMessagingEvent instances are equal
		/// </summary>
		/// <param name="other">Instance of WebMessagingEvent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WebMessagingEvent other)
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
					this.CoBrowse == other.CoBrowse ||
					this.CoBrowse != null &&
					this.CoBrowse.Equals(other.CoBrowse)
				) &&
				(
					this.Presence == other.Presence ||
					this.Presence != null &&
					this.Presence.Equals(other.Presence)
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

				if (this.CoBrowse != null)
					hash = hash * 59 + this.CoBrowse.GetHashCode();

				if (this.Presence != null)
					hash = hash * 59 + this.Presence.GetHashCode();

				return hash;
			}
		}
	}

}
