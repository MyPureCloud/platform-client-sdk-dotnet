using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CapacityPlanStaffingGroupMetricChangeResponse
	/// </summary>
	[DataContract]
	public partial class CapacityPlanStaffingGroupMetricChangeResponse : IEquatable<CapacityPlanStaffingGroupMetricChangeResponse>
	{
		/// <summary>
		/// The metric which is going to be modified for the selected staffing groups
		/// </summary>
		/// <value>The metric which is going to be modified for the selected staffing groups</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum MetricEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Startingweeklyfulltimeequivalentcount for "StartingWeeklyFullTimeEquivalentCount"
			/// </summary>
			[EnumMember(Value = "StartingWeeklyFullTimeEquivalentCount")]
			Startingweeklyfulltimeequivalentcount,

			/// <summary>
			/// Enum Newhiresfulltimeequivalentcount for "NewHiresFullTimeEquivalentCount"
			/// </summary>
			[EnumMember(Value = "NewHiresFullTimeEquivalentCount")]
			Newhiresfulltimeequivalentcount,

			/// <summary>
			/// Enum Attritionpercentage for "AttritionPercentage"
			/// </summary>
			[EnumMember(Value = "AttritionPercentage")]
			Attritionpercentage,

			/// <summary>
			/// Enum Shrinkagepercentage for "ShrinkagePercentage"
			/// </summary>
			[EnumMember(Value = "ShrinkagePercentage")]
			Shrinkagepercentage,

			/// <summary>
			/// Enum Transfersfulltimeequivalentcount for "TransfersFullTimeEquivalentCount"
			/// </summary>
			[EnumMember(Value = "TransfersFullTimeEquivalentCount")]
			Transfersfulltimeequivalentcount,

			/// <summary>
			/// Enum Extratimeundertimefulltimeequivalentcount for "ExtraTimeUnderTimeFullTimeEquivalentCount"
			/// </summary>
			[EnumMember(Value = "ExtraTimeUnderTimeFullTimeEquivalentCount")]
			Extratimeundertimefulltimeequivalentcount
		}
		/// <summary>
		/// The metric which is going to be modified for the selected staffing groups
		/// </summary>
		/// <value>The metric which is going to be modified for the selected staffing groups</value>
		[DataMember(Name = "metric", EmitDefaultValue = false)]
		public MetricEnum? Metric { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="CapacityPlanStaffingGroupMetricChangeResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CapacityPlanStaffingGroupMetricChangeResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CapacityPlanStaffingGroupMetricChangeResponse" /> class.
		/// </summary>
		/// <param name="NumberOfWeeks">The number of weeks to which the metric change applies (required).</param>
		/// <param name="WeekStartNumber">The start number of the week (starting from 1) to which the metric change applies, related to numberOfWeeks (required).</param>
		/// <param name="Value">The value of the metric (required).</param>
		/// <param name="Metric">The metric which is going to be modified for the selected staffing groups (required).</param>
		/// <param name="Notes">Notes about the staffing groups metric changes.</param>
		/// <param name="StaffingGroups">The staffing groups affected by the metric change (required).</param>
		/// <param name="CreatedBy">The user who created the metric change (required).</param>
		/// <param name="CreatedDate">The date the entity was created, in ISO-8601 format (required).</param>
		/// <param name="Version">The version of the capacity plan (required).</param>
		public CapacityPlanStaffingGroupMetricChangeResponse(int? NumberOfWeeks = null, int? WeekStartNumber = null, double? Value = null, MetricEnum? Metric = null, string Notes = null, List<StaffingGroupReference> StaffingGroups = null, UserReference CreatedBy = null, DateTime? CreatedDate = null, int? Version = null)
		{
			this.NumberOfWeeks = NumberOfWeeks;
			this.WeekStartNumber = WeekStartNumber;
			this.Value = Value;
			this.Metric = Metric;
			this.Notes = Notes;
			this.StaffingGroups = StaffingGroups;
			this.CreatedBy = CreatedBy;
			this.CreatedDate = CreatedDate;
			this.Version = Version;

		}



		/// <summary>
		/// The number of weeks to which the metric change applies
		/// </summary>
		/// <value>The number of weeks to which the metric change applies</value>
		[DataMember(Name = "numberOfWeeks", EmitDefaultValue = false)]
		public int? NumberOfWeeks { get; set; }



		/// <summary>
		/// The start number of the week (starting from 1) to which the metric change applies, related to numberOfWeeks
		/// </summary>
		/// <value>The start number of the week (starting from 1) to which the metric change applies, related to numberOfWeeks</value>
		[DataMember(Name = "weekStartNumber", EmitDefaultValue = false)]
		public int? WeekStartNumber { get; set; }



		/// <summary>
		/// The value of the metric
		/// </summary>
		/// <value>The value of the metric</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public double? Value { get; set; }





		/// <summary>
		/// Notes about the staffing groups metric changes
		/// </summary>
		/// <value>Notes about the staffing groups metric changes</value>
		[DataMember(Name = "notes", EmitDefaultValue = false)]
		public string Notes { get; set; }



		/// <summary>
		/// The staffing groups affected by the metric change
		/// </summary>
		/// <value>The staffing groups affected by the metric change</value>
		[DataMember(Name = "staffingGroups", EmitDefaultValue = false)]
		public List<StaffingGroupReference> StaffingGroups { get; set; }



		/// <summary>
		/// The user who created the metric change
		/// </summary>
		/// <value>The user who created the metric change</value>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public UserReference CreatedBy { get; set; }



		/// <summary>
		/// The date the entity was created, in ISO-8601 format
		/// </summary>
		/// <value>The date the entity was created, in ISO-8601 format</value>
		[DataMember(Name = "createdDate", EmitDefaultValue = false)]
		public DateTime? CreatedDate { get; set; }



		/// <summary>
		/// The version of the capacity plan
		/// </summary>
		/// <value>The version of the capacity plan</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public int? Version { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CapacityPlanStaffingGroupMetricChangeResponse {\n");

			sb.Append("  NumberOfWeeks: ").Append(NumberOfWeeks).Append("\n");
			sb.Append("  WeekStartNumber: ").Append(WeekStartNumber).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
			sb.Append("  Metric: ").Append(Metric).Append("\n");
			sb.Append("  Notes: ").Append(Notes).Append("\n");
			sb.Append("  StaffingGroups: ").Append(StaffingGroups).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
			sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
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
			return this.Equals(obj as CapacityPlanStaffingGroupMetricChangeResponse);
		}

		/// <summary>
		/// Returns true if CapacityPlanStaffingGroupMetricChangeResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of CapacityPlanStaffingGroupMetricChangeResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CapacityPlanStaffingGroupMetricChangeResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.NumberOfWeeks == other.NumberOfWeeks ||
					this.NumberOfWeeks != null &&
					this.NumberOfWeeks.Equals(other.NumberOfWeeks)
				) &&
				(
					this.WeekStartNumber == other.WeekStartNumber ||
					this.WeekStartNumber != null &&
					this.WeekStartNumber.Equals(other.WeekStartNumber)
				) &&
				(
					this.Value == other.Value ||
					this.Value != null &&
					this.Value.Equals(other.Value)
				) &&
				(
					this.Metric == other.Metric ||
					this.Metric != null &&
					this.Metric.Equals(other.Metric)
				) &&
				(
					this.Notes == other.Notes ||
					this.Notes != null &&
					this.Notes.Equals(other.Notes)
				) &&
				(
					this.StaffingGroups == other.StaffingGroups ||
					this.StaffingGroups != null &&
					this.StaffingGroups.SequenceEqual(other.StaffingGroups)
				) &&
				(
					this.CreatedBy == other.CreatedBy ||
					this.CreatedBy != null &&
					this.CreatedBy.Equals(other.CreatedBy)
				) &&
				(
					this.CreatedDate == other.CreatedDate ||
					this.CreatedDate != null &&
					this.CreatedDate.Equals(other.CreatedDate)
				) &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
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
				if (this.NumberOfWeeks != null)
					hash = hash * 59 + this.NumberOfWeeks.GetHashCode();

				if (this.WeekStartNumber != null)
					hash = hash * 59 + this.WeekStartNumber.GetHashCode();

				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				if (this.Metric != null)
					hash = hash * 59 + this.Metric.GetHashCode();

				if (this.Notes != null)
					hash = hash * 59 + this.Notes.GetHashCode();

				if (this.StaffingGroups != null)
					hash = hash * 59 + this.StaffingGroups.GetHashCode();

				if (this.CreatedBy != null)
					hash = hash * 59 + this.CreatedBy.GetHashCode();

				if (this.CreatedDate != null)
					hash = hash * 59 + this.CreatedDate.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				return hash;
			}
		}
	}

}
