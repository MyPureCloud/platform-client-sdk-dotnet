using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Channel-specific information that describes the message and the message channel/provider.
	/// </summary>
	[DataContract]
	public partial class OpenSocialMediaReactionsChannel : IEquatable<OpenSocialMediaReactionsChannel>
	{
		/// <summary>
		/// The provider type.
		/// </summary>
		/// <value>The provider type.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum PlatformEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Open for "Open"
			/// </summary>
			[EnumMember(Value = "Open")]
			Open
		}
		/// <summary>
		/// Specifies if this message is part of a private or public conversation.
		/// </summary>
		/// <value>Specifies if this message is part of a private or public conversation.</value>
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
			/// Enum Public for "Public"
			/// </summary>
			[EnumMember(Value = "Public")]
			Public
		}
		/// <summary>
		/// The provider type.
		/// </summary>
		/// <value>The provider type.</value>
		[DataMember(Name = "platform", EmitDefaultValue = false)]
		public PlatformEnum? Platform { get; private set; }
		/// <summary>
		/// Specifies if this message is part of a private or public conversation.
		/// </summary>
		/// <value>Specifies if this message is part of a private or public conversation.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="OpenSocialMediaReactionsChannel" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected OpenSocialMediaReactionsChannel() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="OpenSocialMediaReactionsChannel" /> class.
		/// </summary>
		/// <param name="MessageId">Unique provider ID of the message such as a Open message ID. (required).</param>
		/// <param name="Time">Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		public OpenSocialMediaReactionsChannel(string MessageId = null, DateTime? Time = null)
		{
			this.MessageId = MessageId;
			this.Time = Time;

		}



		/// <summary>
		/// The topic ID.
		/// </summary>
		/// <value>The topic ID.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }







		/// <summary>
		/// Unique provider ID of the message such as a Open message ID.
		/// </summary>
		/// <value>Unique provider ID of the message such as a Open message ID.</value>
		[DataMember(Name = "messageId", EmitDefaultValue = false)]
		public string MessageId { get; set; }



		/// <summary>
		/// Information about the recipient the message is sent to.
		/// </summary>
		/// <value>Information about the recipient the message is sent to.</value>
		[DataMember(Name = "to", EmitDefaultValue = false)]
		public OpenSocialMediaRecipient To { get; private set; }



		/// <summary>
		/// Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "time", EmitDefaultValue = false)]
		public DateTime? Time { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OpenSocialMediaReactionsChannel {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Platform: ").Append(Platform).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  MessageId: ").Append(MessageId).Append("\n");
			sb.Append("  To: ").Append(To).Append("\n");
			sb.Append("  Time: ").Append(Time).Append("\n");
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
			return this.Equals(obj as OpenSocialMediaReactionsChannel);
		}

		/// <summary>
		/// Returns true if OpenSocialMediaReactionsChannel instances are equal
		/// </summary>
		/// <param name="other">Instance of OpenSocialMediaReactionsChannel to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OpenSocialMediaReactionsChannel other)
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
					this.Platform == other.Platform ||
					this.Platform != null &&
					this.Platform.Equals(other.Platform)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.MessageId == other.MessageId ||
					this.MessageId != null &&
					this.MessageId.Equals(other.MessageId)
				) &&
				(
					this.To == other.To ||
					this.To != null &&
					this.To.Equals(other.To)
				) &&
				(
					this.Time == other.Time ||
					this.Time != null &&
					this.Time.Equals(other.Time)
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

				if (this.Platform != null)
					hash = hash * 59 + this.Platform.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.MessageId != null)
					hash = hash * 59 + this.MessageId.GetHashCode();

				if (this.To != null)
					hash = hash * 59 + this.To.GetHashCode();

				if (this.Time != null)
					hash = hash * 59 + this.Time.GetHashCode();

				return hash;
			}
		}
	}

}
