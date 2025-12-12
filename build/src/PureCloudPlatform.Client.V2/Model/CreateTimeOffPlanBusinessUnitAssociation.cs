using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CreateTimeOffPlanBusinessUnitAssociation
	/// </summary>
	[DataContract]
	public partial class CreateTimeOffPlanBusinessUnitAssociation : IEquatable<CreateTimeOffPlanBusinessUnitAssociation>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateTimeOffPlanBusinessUnitAssociation" /> class.
		/// </summary>
		/// <param name="ManagementUnitIds">The IDs of management units to which this time-off plan applies. This must not be set if staffingGroupIds is populated.</param>
		/// <param name="StaffingGroupIds">The IDs of staffing groups to which this time-off plan applies. This must not be set if managementUnitIds is populated.</param>
		public CreateTimeOffPlanBusinessUnitAssociation(List<string> ManagementUnitIds = null, List<string> StaffingGroupIds = null)
		{
			this.ManagementUnitIds = ManagementUnitIds;
			this.StaffingGroupIds = StaffingGroupIds;

		}



		/// <summary>
		/// The IDs of management units to which this time-off plan applies. This must not be set if staffingGroupIds is populated
		/// </summary>
		/// <value>The IDs of management units to which this time-off plan applies. This must not be set if staffingGroupIds is populated</value>
		[DataMember(Name = "managementUnitIds", EmitDefaultValue = false)]
		public List<string> ManagementUnitIds { get; set; }



		/// <summary>
		/// The IDs of staffing groups to which this time-off plan applies. This must not be set if managementUnitIds is populated
		/// </summary>
		/// <value>The IDs of staffing groups to which this time-off plan applies. This must not be set if managementUnitIds is populated</value>
		[DataMember(Name = "staffingGroupIds", EmitDefaultValue = false)]
		public List<string> StaffingGroupIds { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateTimeOffPlanBusinessUnitAssociation {\n");

			sb.Append("  ManagementUnitIds: ").Append(ManagementUnitIds).Append("\n");
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
			return this.Equals(obj as CreateTimeOffPlanBusinessUnitAssociation);
		}

		/// <summary>
		/// Returns true if CreateTimeOffPlanBusinessUnitAssociation instances are equal
		/// </summary>
		/// <param name="other">Instance of CreateTimeOffPlanBusinessUnitAssociation to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CreateTimeOffPlanBusinessUnitAssociation other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ManagementUnitIds == other.ManagementUnitIds ||
					this.ManagementUnitIds != null &&
					this.ManagementUnitIds.SequenceEqual(other.ManagementUnitIds)
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
				if (this.ManagementUnitIds != null)
					hash = hash * 59 + this.ManagementUnitIds.GetHashCode();

				if (this.StaffingGroupIds != null)
					hash = hash * 59 + this.StaffingGroupIds.GetHashCode();

				return hash;
			}
		}
	}

}
