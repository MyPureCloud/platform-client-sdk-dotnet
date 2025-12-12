using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// IgnoredMinedEntity
	/// </summary>
	[DataContract]
	public partial class IgnoredMinedEntity : IEquatable<IgnoredMinedEntity>
	{
		/// <summary>
		/// Type of participant
		/// </summary>
		/// <value>Type of participant</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ParticipantEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Customer for "Customer"
			/// </summary>
			[EnumMember(Value = "Customer")]
			Customer,

			/// <summary>
			/// Enum Agent for "Agent"
			/// </summary>
			[EnumMember(Value = "Agent")]
			Agent,

			/// <summary>
			/// Enum Both for "Both"
			/// </summary>
			[EnumMember(Value = "Both")]
			Both
		}
		/// <summary>
		/// Media Type for the entity (Optional)
		/// </summary>
		/// <value>Media Type for the entity (Optional)</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum MediaTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Chat for "Chat"
			/// </summary>
			[EnumMember(Value = "Chat")]
			Chat,

			/// <summary>
			/// Enum Call for "Call"
			/// </summary>
			[EnumMember(Value = "Call")]
			Call,

			/// <summary>
			/// Enum Message for "Message"
			/// </summary>
			[EnumMember(Value = "Message")]
			Message,

			/// <summary>
			/// Enum Email for "Email"
			/// </summary>
			[EnumMember(Value = "Email")]
			Email
		}
		/// <summary>
		/// Type of participant
		/// </summary>
		/// <value>Type of participant</value>
		[DataMember(Name = "participant", EmitDefaultValue = false)]
		public ParticipantEnum? Participant { get; set; }
		/// <summary>
		/// Media Type for the entity (Optional)
		/// </summary>
		/// <value>Media Type for the entity (Optional)</value>
		[DataMember(Name = "mediaType", EmitDefaultValue = false)]
		public MediaTypeEnum? MediaType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="IgnoredMinedEntity" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected IgnoredMinedEntity() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="IgnoredMinedEntity" /> class.
		/// </summary>
		/// <param name="Id">Unique identifier for the ignored entity (required).</param>
		/// <param name="Text">Text of the ignored entity (required).</param>
		/// <param name="Participant">Type of participant (required).</param>
		/// <param name="DateCreated">Date when the ignored entity was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		/// <param name="DateModified">Date when the ignored entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		/// <param name="MediaType">Media Type for the entity (Optional).</param>
		public IgnoredMinedEntity(string Id = null, string Text = null, ParticipantEnum? Participant = null, DateTime? DateCreated = null, DateTime? DateModified = null, MediaTypeEnum? MediaType = null)
		{
			this.Id = Id;
			this.Text = Text;
			this.Participant = Participant;
			this.DateCreated = DateCreated;
			this.DateModified = DateModified;
			this.MediaType = MediaType;

		}



		/// <summary>
		/// Unique identifier for the ignored entity
		/// </summary>
		/// <value>Unique identifier for the ignored entity</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Text of the ignored entity
		/// </summary>
		/// <value>Text of the ignored entity</value>
		[DataMember(Name = "text", EmitDefaultValue = false)]
		public string Text { get; set; }





		/// <summary>
		/// Date when the ignored entity was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date when the ignored entity was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }



		/// <summary>
		/// Date when the ignored entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date when the ignored entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class IgnoredMinedEntity {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Text: ").Append(Text).Append("\n");
			sb.Append("  Participant: ").Append(Participant).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  MediaType: ").Append(MediaType).Append("\n");
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
			return this.Equals(obj as IgnoredMinedEntity);
		}

		/// <summary>
		/// Returns true if IgnoredMinedEntity instances are equal
		/// </summary>
		/// <param name="other">Instance of IgnoredMinedEntity to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(IgnoredMinedEntity other)
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
					this.Text == other.Text ||
					this.Text != null &&
					this.Text.Equals(other.Text)
				) &&
				(
					this.Participant == other.Participant ||
					this.Participant != null &&
					this.Participant.Equals(other.Participant)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.MediaType == other.MediaType ||
					this.MediaType != null &&
					this.MediaType.Equals(other.MediaType)
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

				if (this.Text != null)
					hash = hash * 59 + this.Text.GetHashCode();

				if (this.Participant != null)
					hash = hash * 59 + this.Participant.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.MediaType != null)
					hash = hash * 59 + this.MediaType.GetHashCode();

				return hash;
			}
		}
	}

}
