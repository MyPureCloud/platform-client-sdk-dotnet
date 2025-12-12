using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CreateTimeOffPlanManagementUnitAssociation
	/// </summary>
	[DataContract]
	public partial class CreateTimeOffPlanManagementUnitAssociation : IEquatable<CreateTimeOffPlanManagementUnitAssociation>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="CreateTimeOffPlanManagementUnitAssociation" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CreateTimeOffPlanManagementUnitAssociation() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateTimeOffPlanManagementUnitAssociation" /> class.
		/// </summary>
		/// <param name="ManagementUnitId">The ID of the management unit to which this time-off plan belongs (required).</param>
		/// <param name="StaffingGroupIds">A IDs of staffing groups to which this time-off plan applies. If not defined, the plan is applied to the management unit.</param>
		public CreateTimeOffPlanManagementUnitAssociation(string ManagementUnitId = null, List<string> StaffingGroupIds = null)
		{
			this.ManagementUnitId = ManagementUnitId;
			this.StaffingGroupIds = StaffingGroupIds;

		}



		/// <summary>
		/// The ID of the management unit to which this time-off plan belongs
		/// </summary>
		/// <value>The ID of the management unit to which this time-off plan belongs</value>
		[DataMember(Name = "managementUnitId", EmitDefaultValue = false)]
		public string ManagementUnitId { get; set; }



		/// <summary>
		/// A IDs of staffing groups to which this time-off plan applies. If not defined, the plan is applied to the management unit
		/// </summary>
		/// <value>A IDs of staffing groups to which this time-off plan applies. If not defined, the plan is applied to the management unit</value>
		[DataMember(Name = "staffingGroupIds", EmitDefaultValue = false)]
		public List<string> StaffingGroupIds { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateTimeOffPlanManagementUnitAssociation {\n");

			sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
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
			return this.Equals(obj as CreateTimeOffPlanManagementUnitAssociation);
		}

		/// <summary>
		/// Returns true if CreateTimeOffPlanManagementUnitAssociation instances are equal
		/// </summary>
		/// <param name="other">Instance of CreateTimeOffPlanManagementUnitAssociation to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CreateTimeOffPlanManagementUnitAssociation other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ManagementUnitId == other.ManagementUnitId ||
					this.ManagementUnitId != null &&
					this.ManagementUnitId.Equals(other.ManagementUnitId)
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
				if (this.ManagementUnitId != null)
					hash = hash * 59 + this.ManagementUnitId.GetHashCode();

				if (this.StaffingGroupIds != null)
					hash = hash * 59 + this.StaffingGroupIds.GetHashCode();

				return hash;
			}
		}
	}

}
