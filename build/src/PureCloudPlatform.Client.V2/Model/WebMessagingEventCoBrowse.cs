using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// A Cobrowse event.
	/// </summary>
	[DataContract]
	public partial class WebMessagingEventCoBrowse : IEquatable<WebMessagingEventCoBrowse>
	{
		/// <summary>
		/// Describes the type of Cobrowse event.
		/// </summary>
		/// <value>Describes the type of Cobrowse event.</value>
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
			/// Enum Offering for "Offering"
			/// </summary>
			[EnumMember(Value = "Offering")]
			Offering,

			/// <summary>
			/// Enum Offeringexpired for "OfferingExpired"
			/// </summary>
			[EnumMember(Value = "OfferingExpired")]
			Offeringexpired,

			/// <summary>
			/// Enum Offeringaccepted for "OfferingAccepted"
			/// </summary>
			[EnumMember(Value = "OfferingAccepted")]
			Offeringaccepted,

			/// <summary>
			/// Enum Offeringrejected for "OfferingRejected"
			/// </summary>
			[EnumMember(Value = "OfferingRejected")]
			Offeringrejected
		}
		/// <summary>
		/// Describes the type of Cobrowse event.
		/// </summary>
		/// <value>Describes the type of Cobrowse event.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="WebMessagingEventCoBrowse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected WebMessagingEventCoBrowse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="WebMessagingEventCoBrowse" /> class.
		/// </summary>
		/// <param name="Type">Describes the type of Cobrowse event. (required).</param>
		/// <param name="SessionId">The Cobrowse session ID..</param>
		/// <param name="SessionJoinToken">The Cobrowse session join token..</param>
		public WebMessagingEventCoBrowse(TypeEnum? Type = null, string SessionId = null, string SessionJoinToken = null)
		{
			this.Type = Type;
			this.SessionId = SessionId;
			this.SessionJoinToken = SessionJoinToken;

		}





		/// <summary>
		/// The Cobrowse session ID.
		/// </summary>
		/// <value>The Cobrowse session ID.</value>
		[DataMember(Name = "sessionId", EmitDefaultValue = false)]
		public string SessionId { get; set; }



		/// <summary>
		/// The Cobrowse session join token.
		/// </summary>
		/// <value>The Cobrowse session join token.</value>
		[DataMember(Name = "sessionJoinToken", EmitDefaultValue = false)]
		public string SessionJoinToken { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WebMessagingEventCoBrowse {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  SessionId: ").Append(SessionId).Append("\n");
			sb.Append("  SessionJoinToken: ").Append(SessionJoinToken).Append("\n");
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
			return this.Equals(obj as WebMessagingEventCoBrowse);
		}

		/// <summary>
		/// Returns true if WebMessagingEventCoBrowse instances are equal
		/// </summary>
		/// <param name="other">Instance of WebMessagingEventCoBrowse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WebMessagingEventCoBrowse other)
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
					this.SessionId == other.SessionId ||
					this.SessionId != null &&
					this.SessionId.Equals(other.SessionId)
				) &&
				(
					this.SessionJoinToken == other.SessionJoinToken ||
					this.SessionJoinToken != null &&
					this.SessionJoinToken.Equals(other.SessionJoinToken)
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

				if (this.SessionId != null)
					hash = hash * 59 + this.SessionId.GetHashCode();

				if (this.SessionJoinToken != null)
					hash = hash * 59 + this.SessionJoinToken.GetHashCode();

				return hash;
			}
		}
	}

}
