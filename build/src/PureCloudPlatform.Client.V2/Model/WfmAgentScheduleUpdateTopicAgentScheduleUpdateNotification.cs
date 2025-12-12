using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification
	/// </summary>
	[DataContract]
	public partial class WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification : IEquatable<WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification" /> class.
		/// </summary>
		/// <param name="User">User.</param>
		/// <param name="StartDate">StartDate.</param>
		/// <param name="EndDate">EndDate.</param>
		/// <param name="Updates">Updates.</param>
		public WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification(WfmAgentScheduleUpdateTopicUserReference User = null, DateTime? StartDate = null, DateTime? EndDate = null, List<WfmAgentScheduleUpdateTopicAgentScheduleShiftUpdate> Updates = null)
		{
			this.User = User;
			this.StartDate = StartDate;
			this.EndDate = EndDate;
			this.Updates = Updates;

		}



		/// <summary>
		/// Gets or Sets User
		/// </summary>
		[DataMember(Name = "user", EmitDefaultValue = false)]
		public WfmAgentScheduleUpdateTopicUserReference User { get; set; }



		/// <summary>
		/// Gets or Sets StartDate
		/// </summary>
		[DataMember(Name = "startDate", EmitDefaultValue = false)]
		public DateTime? StartDate { get; set; }



		/// <summary>
		/// Gets or Sets EndDate
		/// </summary>
		[DataMember(Name = "endDate", EmitDefaultValue = false)]
		public DateTime? EndDate { get; set; }



		/// <summary>
		/// Gets or Sets Updates
		/// </summary>
		[DataMember(Name = "updates", EmitDefaultValue = false)]
		public List<WfmAgentScheduleUpdateTopicAgentScheduleShiftUpdate> Updates { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification {\n");

			sb.Append("  User: ").Append(User).Append("\n");
			sb.Append("  StartDate: ").Append(StartDate).Append("\n");
			sb.Append("  EndDate: ").Append(EndDate).Append("\n");
			sb.Append("  Updates: ").Append(Updates).Append("\n");
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
			return this.Equals(obj as WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification);
		}

		/// <summary>
		/// Returns true if WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification instances are equal
		/// </summary>
		/// <param name="other">Instance of WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WfmAgentScheduleUpdateTopicAgentScheduleUpdateNotification other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.User == other.User ||
					this.User != null &&
					this.User.Equals(other.User)
				) &&
				(
					this.StartDate == other.StartDate ||
					this.StartDate != null &&
					this.StartDate.Equals(other.StartDate)
				) &&
				(
					this.EndDate == other.EndDate ||
					this.EndDate != null &&
					this.EndDate.Equals(other.EndDate)
				) &&
				(
					this.Updates == other.Updates ||
					this.Updates != null &&
					this.Updates.SequenceEqual(other.Updates)
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
				if (this.User != null)
					hash = hash * 59 + this.User.GetHashCode();

				if (this.StartDate != null)
					hash = hash * 59 + this.StartDate.GetHashCode();

				if (this.EndDate != null)
					hash = hash * 59 + this.EndDate.GetHashCode();

				if (this.Updates != null)
					hash = hash * 59 + this.Updates.GetHashCode();

				return hash;
			}
		}
	}

}
