using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UserExpands
	/// </summary>
	[DataContract]
	public partial class UserExpands : IEquatable<UserExpands>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UserExpands" /> class.
		/// </summary>
		public UserExpands()
		{

		}



		/// <summary>
		/// ACD routing status
		/// </summary>
		/// <value>ACD routing status</value>
		[DataMember(Name = "routingStatus", EmitDefaultValue = false)]
		public RoutingStatus RoutingStatus { get; private set; }



		/// <summary>
		/// Active presence
		/// </summary>
		/// <value>Active presence</value>
		[DataMember(Name = "presence", EmitDefaultValue = false)]
		public UserPresence Presence { get; private set; }



		/// <summary>
		/// Active 3rd party presence
		/// </summary>
		/// <value>Active 3rd party presence</value>
		[DataMember(Name = "integrationPresence", EmitDefaultValue = false)]
		public UserPresence IntegrationPresence { get; private set; }



		/// <summary>
		/// Summary of conversion statistics for conversation types.
		/// </summary>
		/// <value>Summary of conversion statistics for conversation types.</value>
		[DataMember(Name = "conversationSummary", EmitDefaultValue = false)]
		public UserConversationSummary ConversationSummary { get; private set; }



		/// <summary>
		/// Determine if out of office is enabled
		/// </summary>
		/// <value>Determine if out of office is enabled</value>
		[DataMember(Name = "outOfOffice", EmitDefaultValue = false)]
		public OutOfOffice OutOfOffice { get; private set; }



		/// <summary>
		/// Current geolocation position
		/// </summary>
		/// <value>Current geolocation position</value>
		[DataMember(Name = "geolocation", EmitDefaultValue = false)]
		public Geolocation Geolocation { get; private set; }



		/// <summary>
		/// Effective, default, and last station information
		/// </summary>
		/// <value>Effective, default, and last station information</value>
		[DataMember(Name = "station", EmitDefaultValue = false)]
		public UserStations Station { get; private set; }



		/// <summary>
		/// Roles and permissions assigned to the user
		/// </summary>
		/// <value>Roles and permissions assigned to the user</value>
		[DataMember(Name = "authorization", EmitDefaultValue = false)]
		public UserAuthorization Authorization { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserExpands {\n");

			sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
			sb.Append("  Presence: ").Append(Presence).Append("\n");
			sb.Append("  IntegrationPresence: ").Append(IntegrationPresence).Append("\n");
			sb.Append("  ConversationSummary: ").Append(ConversationSummary).Append("\n");
			sb.Append("  OutOfOffice: ").Append(OutOfOffice).Append("\n");
			sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
			sb.Append("  Station: ").Append(Station).Append("\n");
			sb.Append("  Authorization: ").Append(Authorization).Append("\n");
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
			return this.Equals(obj as UserExpands);
		}

		/// <summary>
		/// Returns true if UserExpands instances are equal
		/// </summary>
		/// <param name="other">Instance of UserExpands to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserExpands other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.RoutingStatus == other.RoutingStatus ||
					this.RoutingStatus != null &&
					this.RoutingStatus.Equals(other.RoutingStatus)
				) &&
				(
					this.Presence == other.Presence ||
					this.Presence != null &&
					this.Presence.Equals(other.Presence)
				) &&
				(
					this.IntegrationPresence == other.IntegrationPresence ||
					this.IntegrationPresence != null &&
					this.IntegrationPresence.Equals(other.IntegrationPresence)
				) &&
				(
					this.ConversationSummary == other.ConversationSummary ||
					this.ConversationSummary != null &&
					this.ConversationSummary.Equals(other.ConversationSummary)
				) &&
				(
					this.OutOfOffice == other.OutOfOffice ||
					this.OutOfOffice != null &&
					this.OutOfOffice.Equals(other.OutOfOffice)
				) &&
				(
					this.Geolocation == other.Geolocation ||
					this.Geolocation != null &&
					this.Geolocation.Equals(other.Geolocation)
				) &&
				(
					this.Station == other.Station ||
					this.Station != null &&
					this.Station.Equals(other.Station)
				) &&
				(
					this.Authorization == other.Authorization ||
					this.Authorization != null &&
					this.Authorization.Equals(other.Authorization)
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
				if (this.RoutingStatus != null)
					hash = hash * 59 + this.RoutingStatus.GetHashCode();

				if (this.Presence != null)
					hash = hash * 59 + this.Presence.GetHashCode();

				if (this.IntegrationPresence != null)
					hash = hash * 59 + this.IntegrationPresence.GetHashCode();

				if (this.ConversationSummary != null)
					hash = hash * 59 + this.ConversationSummary.GetHashCode();

				if (this.OutOfOffice != null)
					hash = hash * 59 + this.OutOfOffice.GetHashCode();

				if (this.Geolocation != null)
					hash = hash * 59 + this.Geolocation.GetHashCode();

				if (this.Station != null)
					hash = hash * 59 + this.Station.GetHashCode();

				if (this.Authorization != null)
					hash = hash * 59 + this.Authorization.GetHashCode();

				return hash;
			}
		}
	}

}
