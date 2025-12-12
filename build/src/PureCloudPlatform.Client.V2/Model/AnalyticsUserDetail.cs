using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AnalyticsUserDetail
	/// </summary>
	[DataContract]
	public partial class AnalyticsUserDetail : IEquatable<AnalyticsUserDetail>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AnalyticsUserDetail" /> class.
		/// </summary>
		/// <param name="UserId">The identifier for the user.</param>
		/// <param name="PrimaryPresence">The presence records for the user.</param>
		/// <param name="RoutingStatus">The ACD routing status records for the user.</param>
		public AnalyticsUserDetail(string UserId = null, List<AnalyticsUserPresenceRecord> PrimaryPresence = null, List<AnalyticsRoutingStatusRecord> RoutingStatus = null)
		{
			this.UserId = UserId;
			this.PrimaryPresence = PrimaryPresence;
			this.RoutingStatus = RoutingStatus;

		}



		/// <summary>
		/// The identifier for the user
		/// </summary>
		/// <value>The identifier for the user</value>
		[DataMember(Name = "userId", EmitDefaultValue = false)]
		public string UserId { get; set; }



		/// <summary>
		/// The presence records for the user
		/// </summary>
		/// <value>The presence records for the user</value>
		[DataMember(Name = "primaryPresence", EmitDefaultValue = false)]
		public List<AnalyticsUserPresenceRecord> PrimaryPresence { get; set; }



		/// <summary>
		/// The ACD routing status records for the user
		/// </summary>
		/// <value>The ACD routing status records for the user</value>
		[DataMember(Name = "routingStatus", EmitDefaultValue = false)]
		public List<AnalyticsRoutingStatusRecord> RoutingStatus { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AnalyticsUserDetail {\n");

			sb.Append("  UserId: ").Append(UserId).Append("\n");
			sb.Append("  PrimaryPresence: ").Append(PrimaryPresence).Append("\n");
			sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
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
			return this.Equals(obj as AnalyticsUserDetail);
		}

		/// <summary>
		/// Returns true if AnalyticsUserDetail instances are equal
		/// </summary>
		/// <param name="other">Instance of AnalyticsUserDetail to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AnalyticsUserDetail other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.UserId == other.UserId ||
					this.UserId != null &&
					this.UserId.Equals(other.UserId)
				) &&
				(
					this.PrimaryPresence == other.PrimaryPresence ||
					this.PrimaryPresence != null &&
					this.PrimaryPresence.SequenceEqual(other.PrimaryPresence)
				) &&
				(
					this.RoutingStatus == other.RoutingStatus ||
					this.RoutingStatus != null &&
					this.RoutingStatus.SequenceEqual(other.RoutingStatus)
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
				if (this.UserId != null)
					hash = hash * 59 + this.UserId.GetHashCode();

				if (this.PrimaryPresence != null)
					hash = hash * 59 + this.PrimaryPresence.GetHashCode();

				if (this.RoutingStatus != null)
					hash = hash * 59 + this.RoutingStatus.GetHashCode();

				return hash;
			}
		}
	}

}
