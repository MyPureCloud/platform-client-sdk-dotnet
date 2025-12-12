using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AgentMuScheduleQuery
	/// </summary>
	[DataContract]
	public partial class AgentMuScheduleQuery : IEquatable<AgentMuScheduleQuery>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="AgentMuScheduleQuery" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AgentMuScheduleQuery() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AgentMuScheduleQuery" /> class.
		/// </summary>
		/// <param name="StartDate">The start date for the range to query the schedule&#39;s for the agent&#39;s management unit. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		/// <param name="EndDate">The end date for the range to query the schedule&#39;s for the agent&#39;s management unit. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		public AgentMuScheduleQuery(DateTime? StartDate = null, DateTime? EndDate = null)
		{
			this.StartDate = StartDate;
			this.EndDate = EndDate;

		}



		/// <summary>
		/// The start date for the range to query the schedule&#39;s for the agent&#39;s management unit. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The start date for the range to query the schedule&#39;s for the agent&#39;s management unit. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "startDate", EmitDefaultValue = false)]
		public DateTime? StartDate { get; set; }



		/// <summary>
		/// The end date for the range to query the schedule&#39;s for the agent&#39;s management unit. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The end date for the range to query the schedule&#39;s for the agent&#39;s management unit. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "endDate", EmitDefaultValue = false)]
		public DateTime? EndDate { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AgentMuScheduleQuery {\n");

			sb.Append("  StartDate: ").Append(StartDate).Append("\n");
			sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
			return this.Equals(obj as AgentMuScheduleQuery);
		}

		/// <summary>
		/// Returns true if AgentMuScheduleQuery instances are equal
		/// </summary>
		/// <param name="other">Instance of AgentMuScheduleQuery to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AgentMuScheduleQuery other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.StartDate == other.StartDate ||
					this.StartDate != null &&
					this.StartDate.Equals(other.StartDate)
				) &&
				(
					this.EndDate == other.EndDate ||
					this.EndDate != null &&
					this.EndDate.Equals(other.EndDate)
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
				if (this.StartDate != null)
					hash = hash * 59 + this.StartDate.GetHashCode();

				if (this.EndDate != null)
					hash = hash * 59 + this.EndDate.GetHashCode();

				return hash;
			}
		}
	}

}
