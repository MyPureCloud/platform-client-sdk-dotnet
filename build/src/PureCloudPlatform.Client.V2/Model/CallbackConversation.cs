using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CallbackConversation
	/// </summary>
	[DataContract]
	public partial class CallbackConversation : IEquatable<CallbackConversation>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CallbackConversation" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Participants">The list of participants involved in the conversation..</param>
		/// <param name="OtherMediaUris">The list of other media channels involved in the conversation..</param>
		/// <param name="RecentTransfers">The list of the most recent 20 transfer commands applied to this conversation..</param>
		/// <param name="UtilizationLabelId">An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level.</param>
		/// <param name="InactivityTimeout">The time in the future, after which this conversation would be considered inactive. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="Divisions">Identifiers of divisions associated with this conversation..</param>
		public CallbackConversation(string Name = null, List<CallbackMediaParticipant> Participants = null, List<string> OtherMediaUris = null, List<TransferResponse> RecentTransfers = null, string UtilizationLabelId = null, DateTime? InactivityTimeout = null, List<ConversationDivisionMembership> Divisions = null)
		{
			this.Name = Name;
			this.Participants = Participants;
			this.OtherMediaUris = OtherMediaUris;
			this.RecentTransfers = RecentTransfers;
			this.UtilizationLabelId = UtilizationLabelId;
			this.InactivityTimeout = InactivityTimeout;
			this.Divisions = Divisions;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The list of participants involved in the conversation.
		/// </summary>
		/// <value>The list of participants involved in the conversation.</value>
		[DataMember(Name = "participants", EmitDefaultValue = false)]
		public List<CallbackMediaParticipant> Participants { get; set; }



		/// <summary>
		/// The list of other media channels involved in the conversation.
		/// </summary>
		/// <value>The list of other media channels involved in the conversation.</value>
		[DataMember(Name = "otherMediaUris", EmitDefaultValue = false)]
		public List<string> OtherMediaUris { get; set; }



		/// <summary>
		/// The list of the most recent 20 transfer commands applied to this conversation.
		/// </summary>
		/// <value>The list of the most recent 20 transfer commands applied to this conversation.</value>
		[DataMember(Name = "recentTransfers", EmitDefaultValue = false)]
		public List<TransferResponse> RecentTransfers { get; set; }



		/// <summary>
		/// An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level
		/// </summary>
		/// <value>An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level</value>
		[DataMember(Name = "utilizationLabelId", EmitDefaultValue = false)]
		public string UtilizationLabelId { get; set; }



		/// <summary>
		/// The time in the future, after which this conversation would be considered inactive. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The time in the future, after which this conversation would be considered inactive. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "inactivityTimeout", EmitDefaultValue = false)]
		public DateTime? InactivityTimeout { get; set; }



		/// <summary>
		/// Identifiers of divisions associated with this conversation.
		/// </summary>
		/// <value>Identifiers of divisions associated with this conversation.</value>
		[DataMember(Name = "divisions", EmitDefaultValue = false)]
		public List<ConversationDivisionMembership> Divisions { get; set; }



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
			sb.Append("class CallbackConversation {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Participants: ").Append(Participants).Append("\n");
			sb.Append("  OtherMediaUris: ").Append(OtherMediaUris).Append("\n");
			sb.Append("  RecentTransfers: ").Append(RecentTransfers).Append("\n");
			sb.Append("  UtilizationLabelId: ").Append(UtilizationLabelId).Append("\n");
			sb.Append("  InactivityTimeout: ").Append(InactivityTimeout).Append("\n");
			sb.Append("  Divisions: ").Append(Divisions).Append("\n");
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
			return this.Equals(obj as CallbackConversation);
		}

		/// <summary>
		/// Returns true if CallbackConversation instances are equal
		/// </summary>
		/// <param name="other">Instance of CallbackConversation to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CallbackConversation other)
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
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Participants == other.Participants ||
					this.Participants != null &&
					this.Participants.SequenceEqual(other.Participants)
				) &&
				(
					this.OtherMediaUris == other.OtherMediaUris ||
					this.OtherMediaUris != null &&
					this.OtherMediaUris.SequenceEqual(other.OtherMediaUris)
				) &&
				(
					this.RecentTransfers == other.RecentTransfers ||
					this.RecentTransfers != null &&
					this.RecentTransfers.SequenceEqual(other.RecentTransfers)
				) &&
				(
					this.UtilizationLabelId == other.UtilizationLabelId ||
					this.UtilizationLabelId != null &&
					this.UtilizationLabelId.Equals(other.UtilizationLabelId)
				) &&
				(
					this.InactivityTimeout == other.InactivityTimeout ||
					this.InactivityTimeout != null &&
					this.InactivityTimeout.Equals(other.InactivityTimeout)
				) &&
				(
					this.Divisions == other.Divisions ||
					this.Divisions != null &&
					this.Divisions.SequenceEqual(other.Divisions)
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

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Participants != null)
					hash = hash * 59 + this.Participants.GetHashCode();

				if (this.OtherMediaUris != null)
					hash = hash * 59 + this.OtherMediaUris.GetHashCode();

				if (this.RecentTransfers != null)
					hash = hash * 59 + this.RecentTransfers.GetHashCode();

				if (this.UtilizationLabelId != null)
					hash = hash * 59 + this.UtilizationLabelId.GetHashCode();

				if (this.InactivityTimeout != null)
					hash = hash * 59 + this.InactivityTimeout.GetHashCode();

				if (this.Divisions != null)
					hash = hash * 59 + this.Divisions.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
