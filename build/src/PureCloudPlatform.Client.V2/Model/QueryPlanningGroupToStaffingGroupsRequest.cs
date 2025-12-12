using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// QueryPlanningGroupToStaffingGroupsRequest
	/// </summary>
	[DataContract]
	public partial class QueryPlanningGroupToStaffingGroupsRequest : IEquatable<QueryPlanningGroupToStaffingGroupsRequest>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="QueryPlanningGroupToStaffingGroupsRequest" /> class.
		/// </summary>
		/// <param name="PlanningGroupIds">The list of planning group IDs to request capacity group associations.</param>
		/// <param name="StaffingGroupIds">The list of staffing group IDs to request capacity group associations.</param>
		public QueryPlanningGroupToStaffingGroupsRequest(List<string> PlanningGroupIds = null, List<string> StaffingGroupIds = null)
		{
			this.PlanningGroupIds = PlanningGroupIds;
			this.StaffingGroupIds = StaffingGroupIds;

		}



		/// <summary>
		/// The list of planning group IDs to request capacity group associations
		/// </summary>
		/// <value>The list of planning group IDs to request capacity group associations</value>
		[DataMember(Name = "planningGroupIds", EmitDefaultValue = false)]
		public List<string> PlanningGroupIds { get; set; }



		/// <summary>
		/// The list of staffing group IDs to request capacity group associations
		/// </summary>
		/// <value>The list of staffing group IDs to request capacity group associations</value>
		[DataMember(Name = "staffingGroupIds", EmitDefaultValue = false)]
		public List<string> StaffingGroupIds { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class QueryPlanningGroupToStaffingGroupsRequest {\n");

			sb.Append("  PlanningGroupIds: ").Append(PlanningGroupIds).Append("\n");
			sb.Append("  StaffingGroupIds: ").Append(StaffingGroupIds).Append("\n");
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
			return this.Equals(obj as QueryPlanningGroupToStaffingGroupsRequest);
		}

		/// <summary>
		/// Returns true if QueryPlanningGroupToStaffingGroupsRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of QueryPlanningGroupToStaffingGroupsRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(QueryPlanningGroupToStaffingGroupsRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.PlanningGroupIds == other.PlanningGroupIds ||
					this.PlanningGroupIds != null &&
					this.PlanningGroupIds.SequenceEqual(other.PlanningGroupIds)
				) &&
				(
					this.StaffingGroupIds == other.StaffingGroupIds ||
					this.StaffingGroupIds != null &&
					this.StaffingGroupIds.SequenceEqual(other.StaffingGroupIds)
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
				if (this.PlanningGroupIds != null)
					hash = hash * 59 + this.PlanningGroupIds.GetHashCode();

				if (this.StaffingGroupIds != null)
					hash = hash * 59 + this.StaffingGroupIds.GetHashCode();

				return hash;
			}
		}
	}

}
