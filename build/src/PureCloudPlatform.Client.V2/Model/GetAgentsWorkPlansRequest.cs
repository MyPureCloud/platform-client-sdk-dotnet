using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// GetAgentsWorkPlansRequest
	/// </summary>
	[DataContract]
	public partial class GetAgentsWorkPlansRequest : IEquatable<GetAgentsWorkPlansRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="GetAgentsWorkPlansRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected GetAgentsWorkPlansRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="GetAgentsWorkPlansRequest" /> class.
		/// </summary>
		/// <param name="AgentIds">The list of agent IDs (required).</param>
		/// <param name="StartDate">The start of a date in yyyy-MM-dd format. Response contains values rolled back to nearest BU start day of week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
		/// <param name="WeekCount">The number of weeks to query (required).</param>
		public GetAgentsWorkPlansRequest(List<string> AgentIds = null, String StartDate = null, int? WeekCount = null)
		{
			this.AgentIds = AgentIds;
			this.StartDate = StartDate;
			this.WeekCount = WeekCount;

		}



		/// <summary>
		/// The list of agent IDs
		/// </summary>
		/// <value>The list of agent IDs</value>
		[DataMember(Name = "agentIds", EmitDefaultValue = false)]
		public List<string> AgentIds { get; set; }



		/// <summary>
		/// The start of a date in yyyy-MM-dd format. Response contains values rolled back to nearest BU start day of week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The start of a date in yyyy-MM-dd format. Response contains values rolled back to nearest BU start day of week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "startDate", EmitDefaultValue = false)]
		public String StartDate { get; set; }



		/// <summary>
		/// The number of weeks to query
		/// </summary>
		/// <value>The number of weeks to query</value>
		[DataMember(Name = "weekCount", EmitDefaultValue = false)]
		public int? WeekCount { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetAgentsWorkPlansRequest {\n");

			sb.Append("  AgentIds: ").Append(AgentIds).Append("\n");
			sb.Append("  StartDate: ").Append(StartDate).Append("\n");
			sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
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
			return this.Equals(obj as GetAgentsWorkPlansRequest);
		}

		/// <summary>
		/// Returns true if GetAgentsWorkPlansRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of GetAgentsWorkPlansRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(GetAgentsWorkPlansRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.AgentIds == other.AgentIds ||
					this.AgentIds != null &&
					this.AgentIds.SequenceEqual(other.AgentIds)
				) &&
				(
					this.StartDate == other.StartDate ||
					this.StartDate != null &&
					this.StartDate.Equals(other.StartDate)
				) &&
				(
					this.WeekCount == other.WeekCount ||
					this.WeekCount != null &&
					this.WeekCount.Equals(other.WeekCount)
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
				if (this.AgentIds != null)
					hash = hash * 59 + this.AgentIds.GetHashCode();

				if (this.StartDate != null)
					hash = hash * 59 + this.StartDate.GetHashCode();

				if (this.WeekCount != null)
					hash = hash * 59 + this.WeekCount.GetHashCode();

				return hash;
			}
		}
	}

}
