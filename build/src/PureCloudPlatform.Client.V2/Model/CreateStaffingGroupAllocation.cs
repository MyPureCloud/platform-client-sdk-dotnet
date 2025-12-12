using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CreateStaffingGroupAllocation
	/// </summary>
	[DataContract]
	public partial class CreateStaffingGroupAllocation : IEquatable<CreateStaffingGroupAllocation>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="CreateStaffingGroupAllocation" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CreateStaffingGroupAllocation() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateStaffingGroupAllocation" /> class.
		/// </summary>
		/// <param name="StaffingGroupId">The ID of the staffing group used in this capacity plan (required).</param>
		/// <param name="InitialShrinkagePercentage">The shrinkage percentage of the staffing group that can be used for all weeks in the planning period, in the scale of 0 - 100 (required).</param>
		/// <param name="InitialAttritionPercentage">The attrition percentage of the staffing group that can be used for all weeks in the planning period, in the scale of 0 - 100 (required).</param>
		/// <param name="StartingWeeklyFullTimeEquivalentCount">The weekly count of full time equivalent agents in the staffing group that can be used for the first week of the planning period (required).</param>
		public CreateStaffingGroupAllocation(string StaffingGroupId = null, double? InitialShrinkagePercentage = null, double? InitialAttritionPercentage = null, double? StartingWeeklyFullTimeEquivalentCount = null)
		{
			this.StaffingGroupId = StaffingGroupId;
			this.InitialShrinkagePercentage = InitialShrinkagePercentage;
			this.InitialAttritionPercentage = InitialAttritionPercentage;
			this.StartingWeeklyFullTimeEquivalentCount = StartingWeeklyFullTimeEquivalentCount;

		}



		/// <summary>
		/// The ID of the staffing group used in this capacity plan
		/// </summary>
		/// <value>The ID of the staffing group used in this capacity plan</value>
		[DataMember(Name = "staffingGroupId", EmitDefaultValue = false)]
		public string StaffingGroupId { get; set; }



		/// <summary>
		/// The shrinkage percentage of the staffing group that can be used for all weeks in the planning period, in the scale of 0 - 100
		/// </summary>
		/// <value>The shrinkage percentage of the staffing group that can be used for all weeks in the planning period, in the scale of 0 - 100</value>
		[DataMember(Name = "initialShrinkagePercentage", EmitDefaultValue = false)]
		public double? InitialShrinkagePercentage { get; set; }



		/// <summary>
		/// The attrition percentage of the staffing group that can be used for all weeks in the planning period, in the scale of 0 - 100
		/// </summary>
		/// <value>The attrition percentage of the staffing group that can be used for all weeks in the planning period, in the scale of 0 - 100</value>
		[DataMember(Name = "initialAttritionPercentage", EmitDefaultValue = false)]
		public double? InitialAttritionPercentage { get; set; }



		/// <summary>
		/// The weekly count of full time equivalent agents in the staffing group that can be used for the first week of the planning period
		/// </summary>
		/// <value>The weekly count of full time equivalent agents in the staffing group that can be used for the first week of the planning period</value>
		[DataMember(Name = "startingWeeklyFullTimeEquivalentCount", EmitDefaultValue = false)]
		public double? StartingWeeklyFullTimeEquivalentCount { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateStaffingGroupAllocation {\n");

			sb.Append("  StaffingGroupId: ").Append(StaffingGroupId).Append("\n");
			sb.Append("  InitialShrinkagePercentage: ").Append(InitialShrinkagePercentage).Append("\n");
			sb.Append("  InitialAttritionPercentage: ").Append(InitialAttritionPercentage).Append("\n");
			sb.Append("  StartingWeeklyFullTimeEquivalentCount: ").Append(StartingWeeklyFullTimeEquivalentCount).Append("\n");
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
			return this.Equals(obj as CreateStaffingGroupAllocation);
		}

		/// <summary>
		/// Returns true if CreateStaffingGroupAllocation instances are equal
		/// </summary>
		/// <param name="other">Instance of CreateStaffingGroupAllocation to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CreateStaffingGroupAllocation other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.StaffingGroupId == other.StaffingGroupId ||
					this.StaffingGroupId != null &&
					this.StaffingGroupId.Equals(other.StaffingGroupId)
				) &&
				(
					this.InitialShrinkagePercentage == other.InitialShrinkagePercentage ||
					this.InitialShrinkagePercentage != null &&
					this.InitialShrinkagePercentage.Equals(other.InitialShrinkagePercentage)
				) &&
				(
					this.InitialAttritionPercentage == other.InitialAttritionPercentage ||
					this.InitialAttritionPercentage != null &&
					this.InitialAttritionPercentage.Equals(other.InitialAttritionPercentage)
				) &&
				(
					this.StartingWeeklyFullTimeEquivalentCount == other.StartingWeeklyFullTimeEquivalentCount ||
					this.StartingWeeklyFullTimeEquivalentCount != null &&
					this.StartingWeeklyFullTimeEquivalentCount.Equals(other.StartingWeeklyFullTimeEquivalentCount)
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
				if (this.StaffingGroupId != null)
					hash = hash * 59 + this.StaffingGroupId.GetHashCode();

				if (this.InitialShrinkagePercentage != null)
					hash = hash * 59 + this.InitialShrinkagePercentage.GetHashCode();

				if (this.InitialAttritionPercentage != null)
					hash = hash * 59 + this.InitialAttritionPercentage.GetHashCode();

				if (this.StartingWeeklyFullTimeEquivalentCount != null)
					hash = hash * 59 + this.StartingWeeklyFullTimeEquivalentCount.GetHashCode();

				return hash;
			}
		}
	}

}
