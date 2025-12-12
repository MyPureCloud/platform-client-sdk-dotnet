using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CapacityPlanStaffingGroupAllocationsResponse
	/// </summary>
	[DataContract]
	public partial class CapacityPlanStaffingGroupAllocationsResponse : IEquatable<CapacityPlanStaffingGroupAllocationsResponse>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="CapacityPlanStaffingGroupAllocationsResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CapacityPlanStaffingGroupAllocationsResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CapacityPlanStaffingGroupAllocationsResponse" /> class.
		/// </summary>
		/// <param name="CapacityPlan">The capacity plan to which the staffing groups belong (required).</param>
		/// <param name="FullTimeEquivalentWeeklyHours">The weekly hours used to calculate full time equivalent agents (required).</param>
		/// <param name="DownloadUrl">The URL to download the staffing group allocations (required).</param>
		/// <param name="DownloadTemplate">Staffing groups allocation results always come through downloadUrl, the schema included here is just for documentation.</param>
		public CapacityPlanStaffingGroupAllocationsResponse(CapacityPlanReference CapacityPlan = null, double? FullTimeEquivalentWeeklyHours = null, string DownloadUrl = null, StaffingGroupAllocationsResponseTemplate DownloadTemplate = null)
		{
			this.CapacityPlan = CapacityPlan;
			this.FullTimeEquivalentWeeklyHours = FullTimeEquivalentWeeklyHours;
			this.DownloadUrl = DownloadUrl;
			this.DownloadTemplate = DownloadTemplate;

		}



		/// <summary>
		/// The capacity plan to which the staffing groups belong
		/// </summary>
		/// <value>The capacity plan to which the staffing groups belong</value>
		[DataMember(Name = "capacityPlan", EmitDefaultValue = false)]
		public CapacityPlanReference CapacityPlan { get; set; }



		/// <summary>
		/// The weekly hours used to calculate full time equivalent agents
		/// </summary>
		/// <value>The weekly hours used to calculate full time equivalent agents</value>
		[DataMember(Name = "fullTimeEquivalentWeeklyHours", EmitDefaultValue = false)]
		public double? FullTimeEquivalentWeeklyHours { get; set; }



		/// <summary>
		/// The URL to download the staffing group allocations
		/// </summary>
		/// <value>The URL to download the staffing group allocations</value>
		[DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
		public string DownloadUrl { get; set; }



		/// <summary>
		/// Staffing groups allocation results always come through downloadUrl, the schema included here is just for documentation
		/// </summary>
		/// <value>Staffing groups allocation results always come through downloadUrl, the schema included here is just for documentation</value>
		[DataMember(Name = "downloadTemplate", EmitDefaultValue = false)]
		public StaffingGroupAllocationsResponseTemplate DownloadTemplate { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CapacityPlanStaffingGroupAllocationsResponse {\n");

			sb.Append("  CapacityPlan: ").Append(CapacityPlan).Append("\n");
			sb.Append("  FullTimeEquivalentWeeklyHours: ").Append(FullTimeEquivalentWeeklyHours).Append("\n");
			sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
			sb.Append("  DownloadTemplate: ").Append(DownloadTemplate).Append("\n");
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
			return this.Equals(obj as CapacityPlanStaffingGroupAllocationsResponse);
		}

		/// <summary>
		/// Returns true if CapacityPlanStaffingGroupAllocationsResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of CapacityPlanStaffingGroupAllocationsResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CapacityPlanStaffingGroupAllocationsResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.CapacityPlan == other.CapacityPlan ||
					this.CapacityPlan != null &&
					this.CapacityPlan.Equals(other.CapacityPlan)
				) &&
				(
					this.FullTimeEquivalentWeeklyHours == other.FullTimeEquivalentWeeklyHours ||
					this.FullTimeEquivalentWeeklyHours != null &&
					this.FullTimeEquivalentWeeklyHours.Equals(other.FullTimeEquivalentWeeklyHours)
				) &&
				(
					this.DownloadUrl == other.DownloadUrl ||
					this.DownloadUrl != null &&
					this.DownloadUrl.Equals(other.DownloadUrl)
				) &&
				(
					this.DownloadTemplate == other.DownloadTemplate ||
					this.DownloadTemplate != null &&
					this.DownloadTemplate.Equals(other.DownloadTemplate)
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
				if (this.CapacityPlan != null)
					hash = hash * 59 + this.CapacityPlan.GetHashCode();

				if (this.FullTimeEquivalentWeeklyHours != null)
					hash = hash * 59 + this.FullTimeEquivalentWeeklyHours.GetHashCode();

				if (this.DownloadUrl != null)
					hash = hash * 59 + this.DownloadUrl.GetHashCode();

				if (this.DownloadTemplate != null)
					hash = hash * 59 + this.DownloadTemplate.GetHashCode();

				return hash;
			}
		}
	}

}
