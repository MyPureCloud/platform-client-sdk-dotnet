using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// MeetingIdRecord
	/// </summary>
	[DataContract]
	public partial class MeetingIdRecord : IEquatable<MeetingIdRecord>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="MeetingIdRecord" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected MeetingIdRecord() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="MeetingIdRecord" /> class.
		/// </summary>
		/// <param name="Ephemeral">Boolean flag for ephemeral status of the created record (required).</param>
		/// <param name="ConferenceId">The conferenceId used to generate a meetingId.</param>
		/// <param name="DateExpired">Instant at which the meetingId record will no longer be considered active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		public MeetingIdRecord(bool? Ephemeral = null, string ConferenceId = null, DateTime? DateExpired = null)
		{
			this.Ephemeral = Ephemeral;
			this.ConferenceId = ConferenceId;
			this.DateExpired = DateExpired;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Boolean flag for ephemeral status of the created record
		/// </summary>
		/// <value>Boolean flag for ephemeral status of the created record</value>
		[DataMember(Name = "ephemeral", EmitDefaultValue = false)]
		public bool? Ephemeral { get; set; }



		/// <summary>
		/// The conferenceId used to generate a meetingId
		/// </summary>
		/// <value>The conferenceId used to generate a meetingId</value>
		[DataMember(Name = "conferenceId", EmitDefaultValue = false)]
		public string ConferenceId { get; set; }



		/// <summary>
		/// Instant at which the meetingId record will no longer be considered active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Instant at which the meetingId record will no longer be considered active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateExpired", EmitDefaultValue = false)]
		public DateTime? DateExpired { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MeetingIdRecord {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Ephemeral: ").Append(Ephemeral).Append("\n");
			sb.Append("  ConferenceId: ").Append(ConferenceId).Append("\n");
			sb.Append("  DateExpired: ").Append(DateExpired).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as MeetingIdRecord);
		}

		/// <summary>
		/// Returns true if MeetingIdRecord instances are equal
		/// </summary>
		/// <param name="other">Instance of MeetingIdRecord to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MeetingIdRecord other)
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
					this.Ephemeral == other.Ephemeral ||
					this.Ephemeral != null &&
					this.Ephemeral.Equals(other.Ephemeral)
				) &&
				(
					this.ConferenceId == other.ConferenceId ||
					this.ConferenceId != null &&
					this.ConferenceId.Equals(other.ConferenceId)
				) &&
				(
					this.DateExpired == other.DateExpired ||
					this.DateExpired != null &&
					this.DateExpired.Equals(other.DateExpired)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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

				if (this.Ephemeral != null)
					hash = hash * 59 + this.Ephemeral.GetHashCode();

				if (this.ConferenceId != null)
					hash = hash * 59 + this.ConferenceId.GetHashCode();

				if (this.DateExpired != null)
					hash = hash * 59 + this.DateExpired.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
