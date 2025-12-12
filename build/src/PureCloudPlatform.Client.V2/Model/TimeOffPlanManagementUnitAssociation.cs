using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TimeOffPlanManagementUnitAssociation
	/// </summary>
	[DataContract]
	public partial class TimeOffPlanManagementUnitAssociation : IEquatable<TimeOffPlanManagementUnitAssociation>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="TimeOffPlanManagementUnitAssociation" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected TimeOffPlanManagementUnitAssociation() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="TimeOffPlanManagementUnitAssociation" /> class.
		/// </summary>
		/// <param name="ManagementUnit">Management unit to which this time-off plan belongs (required).</param>
		/// <param name="StaffingGroups">Staffing groups to which this time-off plan applies. If not defined, the plan applies to the management unit.</param>
		public TimeOffPlanManagementUnitAssociation(ManagementUnitReference ManagementUnit = null, List<StaffingGroupReference> StaffingGroups = null)
		{
			this.ManagementUnit = ManagementUnit;
			this.StaffingGroups = StaffingGroups;

		}



		/// <summary>
		/// Management unit to which this time-off plan belongs
		/// </summary>
		/// <value>Management unit to which this time-off plan belongs</value>
		[DataMember(Name = "managementUnit", EmitDefaultValue = false)]
		public ManagementUnitReference ManagementUnit { get; set; }



		/// <summary>
		/// Staffing groups to which this time-off plan applies. If not defined, the plan applies to the management unit
		/// </summary>
		/// <value>Staffing groups to which this time-off plan applies. If not defined, the plan applies to the management unit</value>
		[DataMember(Name = "staffingGroups", EmitDefaultValue = false)]
		public List<StaffingGroupReference> StaffingGroups { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TimeOffPlanManagementUnitAssociation {\n");

			sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
			sb.Append("  StaffingGroups: ").Append(StaffingGroups).Append("\n");
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
			return this.Equals(obj as TimeOffPlanManagementUnitAssociation);
		}

		/// <summary>
		/// Returns true if TimeOffPlanManagementUnitAssociation instances are equal
		/// </summary>
		/// <param name="other">Instance of TimeOffPlanManagementUnitAssociation to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TimeOffPlanManagementUnitAssociation other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ManagementUnit == other.ManagementUnit ||
					this.ManagementUnit != null &&
					this.ManagementUnit.Equals(other.ManagementUnit)
				) &&
				(
					this.StaffingGroups == other.StaffingGroups ||
					this.StaffingGroups != null &&
					this.StaffingGroups.SequenceEqual(other.StaffingGroups)
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
				if (this.ManagementUnit != null)
					hash = hash * 59 + this.ManagementUnit.GetHashCode();

				if (this.StaffingGroups != null)
					hash = hash * 59 + this.StaffingGroups.GetHashCode();

				return hash;
			}
		}
	}

}
