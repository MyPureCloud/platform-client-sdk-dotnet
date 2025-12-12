using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// A Video event.
	/// </summary>
	[DataContract]
	public partial class ConversationEventVideo : IEquatable<ConversationEventVideo>
	{
		/// <summary>
		/// Describes the type of Video event.
		/// </summary>
		/// <value>Describes the type of Video event.</value>
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
		/// Describes the type of Video event.
		/// </summary>
		/// <value>Describes the type of Video event.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationEventVideo" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ConversationEventVideo() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationEventVideo" /> class.
		/// </summary>
		/// <param name="Type">Describes the type of Video event. (required).</param>
		/// <param name="OfferingId">The Video offering ID..</param>
		/// <param name="Jwt">The Video offering JWT token..</param>
		public ConversationEventVideo(TypeEnum? Type = null, string OfferingId = null, string Jwt = null)
		{
			this.Type = Type;
			this.OfferingId = OfferingId;
			this.Jwt = Jwt;

		}





		/// <summary>
		/// The Video offering ID.
		/// </summary>
		/// <value>The Video offering ID.</value>
		[DataMember(Name = "offeringId", EmitDefaultValue = false)]
		public string OfferingId { get; set; }



		/// <summary>
		/// The Video offering JWT token.
		/// </summary>
		/// <value>The Video offering JWT token.</value>
		[DataMember(Name = "jwt", EmitDefaultValue = false)]
		public string Jwt { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationEventVideo {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  OfferingId: ").Append(OfferingId).Append("\n");
			sb.Append("  Jwt: ").Append(Jwt).Append("\n");
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
			return this.Equals(obj as ConversationEventVideo);
		}

		/// <summary>
		/// Returns true if ConversationEventVideo instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationEventVideo to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationEventVideo other)
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
					this.OfferingId == other.OfferingId ||
					this.OfferingId != null &&
					this.OfferingId.Equals(other.OfferingId)
				) &&
				(
					this.Jwt == other.Jwt ||
					this.Jwt != null &&
					this.Jwt.Equals(other.Jwt)
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

				if (this.OfferingId != null)
					hash = hash * 59 + this.OfferingId.GetHashCode();

				if (this.Jwt != null)
					hash = hash * 59 + this.Jwt.GetHashCode();

				return hash;
			}
		}
	}

}
