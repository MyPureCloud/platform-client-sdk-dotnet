using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkPlanBidGroupUpdate
	/// </summary>
	[DataContract]
	public partial class WorkPlanBidGroupUpdate : IEquatable<WorkPlanBidGroupUpdate>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkPlanBidGroupUpdate" /> class.
		/// </summary>
		/// <param name="Name">The name of the work plan bid group.</param>
		/// <param name="ManagementUnitId">The management unit ID used for this work plan bid group.</param>
		/// <param name="AgentIds">Agent IDs who participate in this bid group.</param>
		/// <param name="WorkPlans">The list of work plans used in this bid group.</param>
		/// <param name="PlanningGroupIds">The planning group IDs selected in this bid group.</param>
		public WorkPlanBidGroupUpdate(string Name = null, string ManagementUnitId = null, ListWrapperString AgentIds = null, ListWrapperBidGroupWorkPlanRequest WorkPlans = null, ListWrapperString PlanningGroupIds = null)
		{
			this.Name = Name;
			this.ManagementUnitId = ManagementUnitId;
			this.AgentIds = AgentIds;
			this.WorkPlans = WorkPlans;
			this.PlanningGroupIds = PlanningGroupIds;

		}



		/// <summary>
		/// The name of the work plan bid group
		/// </summary>
		/// <value>The name of the work plan bid group</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The management unit ID used for this work plan bid group
		/// </summary>
		/// <value>The management unit ID used for this work plan bid group</value>
		[DataMember(Name = "managementUnitId", EmitDefaultValue = false)]
		public string ManagementUnitId { get; set; }



		/// <summary>
		/// Agent IDs who participate in this bid group
		/// </summary>
		/// <value>Agent IDs who participate in this bid group</value>
		[DataMember(Name = "agentIds", EmitDefaultValue = false)]
		public ListWrapperString AgentIds { get; set; }



		/// <summary>
		/// The list of work plans used in this bid group
		/// </summary>
		/// <value>The list of work plans used in this bid group</value>
		[DataMember(Name = "workPlans", EmitDefaultValue = false)]
		public ListWrapperBidGroupWorkPlanRequest WorkPlans { get; set; }



		/// <summary>
		/// The planning group IDs selected in this bid group
		/// </summary>
		/// <value>The planning group IDs selected in this bid group</value>
		[DataMember(Name = "planningGroupIds", EmitDefaultValue = false)]
		public ListWrapperString PlanningGroupIds { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkPlanBidGroupUpdate {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
			sb.Append("  AgentIds: ").Append(AgentIds).Append("\n");
			sb.Append("  WorkPlans: ").Append(WorkPlans).Append("\n");
			sb.Append("  PlanningGroupIds: ").Append(PlanningGroupIds).Append("\n");
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
			return this.Equals(obj as WorkPlanBidGroupUpdate);
		}

		/// <summary>
		/// Returns true if WorkPlanBidGroupUpdate instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkPlanBidGroupUpdate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkPlanBidGroupUpdate other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.ManagementUnitId == other.ManagementUnitId ||
					this.ManagementUnitId != null &&
					this.ManagementUnitId.Equals(other.ManagementUnitId)
				) &&
				(
					this.AgentIds == other.AgentIds ||
					this.AgentIds != null &&
					this.AgentIds.Equals(other.AgentIds)
				) &&
				(
					this.WorkPlans == other.WorkPlans ||
					this.WorkPlans != null &&
					this.WorkPlans.Equals(other.WorkPlans)
				) &&
				(
					this.PlanningGroupIds == other.PlanningGroupIds ||
					this.PlanningGroupIds != null &&
					this.PlanningGroupIds.Equals(other.PlanningGroupIds)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.ManagementUnitId != null)
					hash = hash * 59 + this.ManagementUnitId.GetHashCode();

				if (this.AgentIds != null)
					hash = hash * 59 + this.AgentIds.GetHashCode();

				if (this.WorkPlans != null)
					hash = hash * 59 + this.WorkPlans.GetHashCode();

				if (this.PlanningGroupIds != null)
					hash = hash * 59 + this.PlanningGroupIds.GetHashCode();

				return hash;
			}
		}
	}

}
