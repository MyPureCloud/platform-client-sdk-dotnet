using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AnalyticsParticipantWithoutAttributes
	/// </summary>
	[DataContract]
	public partial class AnalyticsParticipantWithoutAttributes : IEquatable<AnalyticsParticipantWithoutAttributes>
	{
		/// <summary>
		/// Reason for which participant flagged conversation
		/// </summary>
		/// <value>Reason for which participant flagged conversation</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum FlaggedReasonEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum General for "general"
			/// </summary>
			[EnumMember(Value = "general")]
			General
		}
		/// <summary>
		/// The participant's purpose
		/// </summary>
		/// <value>The participant's purpose</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum PurposeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Acd for "acd"
			/// </summary>
			[EnumMember(Value = "acd")]
			Acd,

			/// <summary>
			/// Enum Agent for "agent"
			/// </summary>
			[EnumMember(Value = "agent")]
			Agent,

			/// <summary>
			/// Enum Api for "api"
			/// </summary>
			[EnumMember(Value = "api")]
			Api,

			/// <summary>
			/// Enum Botflow for "botflow"
			/// </summary>
			[EnumMember(Value = "botflow")]
			Botflow,

			/// <summary>
			/// Enum Campaign for "campaign"
			/// </summary>
			[EnumMember(Value = "campaign")]
			Campaign,

			/// <summary>
			/// Enum Customer for "customer"
			/// </summary>
			[EnumMember(Value = "customer")]
			Customer,

			/// <summary>
			/// Enum Dialer for "dialer"
			/// </summary>
			[EnumMember(Value = "dialer")]
			Dialer,

			/// <summary>
			/// Enum External for "external"
			/// </summary>
			[EnumMember(Value = "external")]
			External,

			/// <summary>
			/// Enum Fax for "fax"
			/// </summary>
			[EnumMember(Value = "fax")]
			Fax,

			/// <summary>
			/// Enum Group for "group"
			/// </summary>
			[EnumMember(Value = "group")]
			Group,

			/// <summary>
			/// Enum Inbound for "inbound"
			/// </summary>
			[EnumMember(Value = "inbound")]
			Inbound,

			/// <summary>
			/// Enum Ivr for "ivr"
			/// </summary>
			[EnumMember(Value = "ivr")]
			Ivr,

			/// <summary>
			/// Enum Manual for "manual"
			/// </summary>
			[EnumMember(Value = "manual")]
			Manual,

			/// <summary>
			/// Enum Outbound for "outbound"
			/// </summary>
			[EnumMember(Value = "outbound")]
			Outbound,

			/// <summary>
			/// Enum Station for "station"
			/// </summary>
			[EnumMember(Value = "station")]
			Station,

			/// <summary>
			/// Enum User for "user"
			/// </summary>
			[EnumMember(Value = "user")]
			User,

			/// <summary>
			/// Enum Voicemail for "voicemail"
			/// </summary>
			[EnumMember(Value = "voicemail")]
			Voicemail,

			/// <summary>
			/// Enum Voicesurveyflow for "voicesurveyflow"
			/// </summary>
			[EnumMember(Value = "voicesurveyflow")]
			Voicesurveyflow,

			/// <summary>
			/// Enum Workflow for "workflow"
			/// </summary>
			[EnumMember(Value = "workflow")]
			Workflow
		}
		/// <summary>
		/// Reason for which participant flagged conversation
		/// </summary>
		/// <value>Reason for which participant flagged conversation</value>
		[DataMember(Name = "flaggedReason", EmitDefaultValue = false)]
		public FlaggedReasonEnum? FlaggedReason { get; set; }
		/// <summary>
		/// The participant's purpose
		/// </summary>
		/// <value>The participant's purpose</value>
		[DataMember(Name = "purpose", EmitDefaultValue = false)]
		public PurposeEnum? Purpose { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="AnalyticsParticipantWithoutAttributes" /> class.
		/// </summary>
		/// <param name="ExternalContactId">External contact identifier.</param>
		/// <param name="ExternalOrganizationId">External organization identifier.</param>
		/// <param name="FlaggedReason">Reason for which participant flagged conversation.</param>
		/// <param name="ParticipantId">Unique identifier for the participant.</param>
		/// <param name="ParticipantName">A human readable name identifying the participant.</param>
		/// <param name="Purpose">The participant&#39;s purpose.</param>
		/// <param name="ScreenRecording">Flag determining if a screen recording was started or not.</param>
		/// <param name="TeamId">The team ID the user is a member of.</param>
		/// <param name="UserId">Unique identifier for the user.</param>
		/// <param name="Sessions">List of sessions associated to this participant.</param>
		public AnalyticsParticipantWithoutAttributes(string ExternalContactId = null, string ExternalOrganizationId = null, FlaggedReasonEnum? FlaggedReason = null, string ParticipantId = null, string ParticipantName = null, PurposeEnum? Purpose = null, bool? ScreenRecording = null, string TeamId = null, string UserId = null, List<AnalyticsSession> Sessions = null)
		{
			this.ExternalContactId = ExternalContactId;
			this.ExternalOrganizationId = ExternalOrganizationId;
			this.FlaggedReason = FlaggedReason;
			this.ParticipantId = ParticipantId;
			this.ParticipantName = ParticipantName;
			this.Purpose = Purpose;
			this.ScreenRecording = ScreenRecording;
			this.TeamId = TeamId;
			this.UserId = UserId;
			this.Sessions = Sessions;

		}



		/// <summary>
		/// External contact identifier
		/// </summary>
		/// <value>External contact identifier</value>
		[DataMember(Name = "externalContactId", EmitDefaultValue = false)]
		public string ExternalContactId { get; set; }



		/// <summary>
		/// External organization identifier
		/// </summary>
		/// <value>External organization identifier</value>
		[DataMember(Name = "externalOrganizationId", EmitDefaultValue = false)]
		public string ExternalOrganizationId { get; set; }





		/// <summary>
		/// Unique identifier for the participant
		/// </summary>
		/// <value>Unique identifier for the participant</value>
		[DataMember(Name = "participantId", EmitDefaultValue = false)]
		public string ParticipantId { get; set; }



		/// <summary>
		/// A human readable name identifying the participant
		/// </summary>
		/// <value>A human readable name identifying the participant</value>
		[DataMember(Name = "participantName", EmitDefaultValue = false)]
		public string ParticipantName { get; set; }





		/// <summary>
		/// Flag determining if a screen recording was started or not
		/// </summary>
		/// <value>Flag determining if a screen recording was started or not</value>
		[DataMember(Name = "screenRecording", EmitDefaultValue = false)]
		public bool? ScreenRecording { get; set; }



		/// <summary>
		/// The team ID the user is a member of
		/// </summary>
		/// <value>The team ID the user is a member of</value>
		[DataMember(Name = "teamId", EmitDefaultValue = false)]
		public string TeamId { get; set; }



		/// <summary>
		/// Unique identifier for the user
		/// </summary>
		/// <value>Unique identifier for the user</value>
		[DataMember(Name = "userId", EmitDefaultValue = false)]
		public string UserId { get; set; }



		/// <summary>
		/// List of sessions associated to this participant
		/// </summary>
		/// <value>List of sessions associated to this participant</value>
		[DataMember(Name = "sessions", EmitDefaultValue = false)]
		public List<AnalyticsSession> Sessions { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AnalyticsParticipantWithoutAttributes {\n");

			sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
			sb.Append("  ExternalOrganizationId: ").Append(ExternalOrganizationId).Append("\n");
			sb.Append("  FlaggedReason: ").Append(FlaggedReason).Append("\n");
			sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
			sb.Append("  ParticipantName: ").Append(ParticipantName).Append("\n");
			sb.Append("  Purpose: ").Append(Purpose).Append("\n");
			sb.Append("  ScreenRecording: ").Append(ScreenRecording).Append("\n");
			sb.Append("  TeamId: ").Append(TeamId).Append("\n");
			sb.Append("  UserId: ").Append(UserId).Append("\n");
			sb.Append("  Sessions: ").Append(Sessions).Append("\n");
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
			return this.Equals(obj as AnalyticsParticipantWithoutAttributes);
		}

		/// <summary>
		/// Returns true if AnalyticsParticipantWithoutAttributes instances are equal
		/// </summary>
		/// <param name="other">Instance of AnalyticsParticipantWithoutAttributes to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AnalyticsParticipantWithoutAttributes other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ExternalContactId == other.ExternalContactId ||
					this.ExternalContactId != null &&
					this.ExternalContactId.Equals(other.ExternalContactId)
				) &&
				(
					this.ExternalOrganizationId == other.ExternalOrganizationId ||
					this.ExternalOrganizationId != null &&
					this.ExternalOrganizationId.Equals(other.ExternalOrganizationId)
				) &&
				(
					this.FlaggedReason == other.FlaggedReason ||
					this.FlaggedReason != null &&
					this.FlaggedReason.Equals(other.FlaggedReason)
				) &&
				(
					this.ParticipantId == other.ParticipantId ||
					this.ParticipantId != null &&
					this.ParticipantId.Equals(other.ParticipantId)
				) &&
				(
					this.ParticipantName == other.ParticipantName ||
					this.ParticipantName != null &&
					this.ParticipantName.Equals(other.ParticipantName)
				) &&
				(
					this.Purpose == other.Purpose ||
					this.Purpose != null &&
					this.Purpose.Equals(other.Purpose)
				) &&
				(
					this.ScreenRecording == other.ScreenRecording ||
					this.ScreenRecording != null &&
					this.ScreenRecording.Equals(other.ScreenRecording)
				) &&
				(
					this.TeamId == other.TeamId ||
					this.TeamId != null &&
					this.TeamId.Equals(other.TeamId)
				) &&
				(
					this.UserId == other.UserId ||
					this.UserId != null &&
					this.UserId.Equals(other.UserId)
				) &&
				(
					this.Sessions == other.Sessions ||
					this.Sessions != null &&
					this.Sessions.SequenceEqual(other.Sessions)
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
				if (this.ExternalContactId != null)
					hash = hash * 59 + this.ExternalContactId.GetHashCode();

				if (this.ExternalOrganizationId != null)
					hash = hash * 59 + this.ExternalOrganizationId.GetHashCode();

				if (this.FlaggedReason != null)
					hash = hash * 59 + this.FlaggedReason.GetHashCode();

				if (this.ParticipantId != null)
					hash = hash * 59 + this.ParticipantId.GetHashCode();

				if (this.ParticipantName != null)
					hash = hash * 59 + this.ParticipantName.GetHashCode();

				if (this.Purpose != null)
					hash = hash * 59 + this.Purpose.GetHashCode();

				if (this.ScreenRecording != null)
					hash = hash * 59 + this.ScreenRecording.GetHashCode();

				if (this.TeamId != null)
					hash = hash * 59 + this.TeamId.GetHashCode();

				if (this.UserId != null)
					hash = hash * 59 + this.UserId.GetHashCode();

				if (this.Sessions != null)
					hash = hash * 59 + this.Sessions.GetHashCode();

				return hash;
			}
		}
	}

}
