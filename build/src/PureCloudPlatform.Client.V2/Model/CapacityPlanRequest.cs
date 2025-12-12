using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CapacityPlanRequest
	/// </summary>
	[DataContract]
	public partial class CapacityPlanRequest : IEquatable<CapacityPlanRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="CapacityPlanRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CapacityPlanRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CapacityPlanRequest" /> class.
		/// </summary>
		/// <param name="Name">The name of the capacity plan (required).</param>
		/// <param name="Description">Description of the capacity plan.</param>
		/// <param name="StartBusinessUnitDate">The start date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
		/// <param name="EndBusinessUnitDate">The end date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
		/// <param name="Forecast">The selected forecast for this capacity plan. Null when main forecast is used in the future (required).</param>
		/// <param name="FullTimeEquivalentWeeklyHours">The weekly hours used to calculate full time equivalent agents (required).</param>
		/// <param name="StaffingGroupAllocations">List of staffing group allocations to be used for the capacity plan (required).</param>
		public CapacityPlanRequest(string Name = null, string Description = null, String StartBusinessUnitDate = null, String EndBusinessUnitDate = null, BuShortTermForecastReference Forecast = null, double? FullTimeEquivalentWeeklyHours = null, List<CreateStaffingGroupAllocation> StaffingGroupAllocations = null)
		{
			this.Name = Name;
			this.Description = Description;
			this.StartBusinessUnitDate = StartBusinessUnitDate;
			this.EndBusinessUnitDate = EndBusinessUnitDate;
			this.Forecast = Forecast;
			this.FullTimeEquivalentWeeklyHours = FullTimeEquivalentWeeklyHours;
			this.StaffingGroupAllocations = StaffingGroupAllocations;

		}



		/// <summary>
		/// The name of the capacity plan
		/// </summary>
		/// <value>The name of the capacity plan</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Description of the capacity plan
		/// </summary>
		/// <value>Description of the capacity plan</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// The start date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The start date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "startBusinessUnitDate", EmitDefaultValue = false)]
		public String StartBusinessUnitDate { get; set; }



		/// <summary>
		/// The end date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The end date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "endBusinessUnitDate", EmitDefaultValue = false)]
		public String EndBusinessUnitDate { get; set; }



		/// <summary>
		/// The selected forecast for this capacity plan. Null when main forecast is used in the future
		/// </summary>
		/// <value>The selected forecast for this capacity plan. Null when main forecast is used in the future</value>
		[DataMember(Name = "forecast", EmitDefaultValue = false)]
		public BuShortTermForecastReference Forecast { get; set; }



		/// <summary>
		/// The weekly hours used to calculate full time equivalent agents
		/// </summary>
		/// <value>The weekly hours used to calculate full time equivalent agents</value>
		[DataMember(Name = "fullTimeEquivalentWeeklyHours", EmitDefaultValue = false)]
		public double? FullTimeEquivalentWeeklyHours { get; set; }



		/// <summary>
		/// List of staffing group allocations to be used for the capacity plan
		/// </summary>
		/// <value>List of staffing group allocations to be used for the capacity plan</value>
		[DataMember(Name = "staffingGroupAllocations", EmitDefaultValue = false)]
		public List<CreateStaffingGroupAllocation> StaffingGroupAllocations { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CapacityPlanRequest {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  StartBusinessUnitDate: ").Append(StartBusinessUnitDate).Append("\n");
			sb.Append("  EndBusinessUnitDate: ").Append(EndBusinessUnitDate).Append("\n");
			sb.Append("  Forecast: ").Append(Forecast).Append("\n");
			sb.Append("  FullTimeEquivalentWeeklyHours: ").Append(FullTimeEquivalentWeeklyHours).Append("\n");
			sb.Append("  StaffingGroupAllocations: ").Append(StaffingGroupAllocations).Append("\n");
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
			return this.Equals(obj as CapacityPlanRequest);
		}

		/// <summary>
		/// Returns true if CapacityPlanRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of CapacityPlanRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CapacityPlanRequest other)
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
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.StartBusinessUnitDate == other.StartBusinessUnitDate ||
					this.StartBusinessUnitDate != null &&
					this.StartBusinessUnitDate.Equals(other.StartBusinessUnitDate)
				) &&
				(
					this.EndBusinessUnitDate == other.EndBusinessUnitDate ||
					this.EndBusinessUnitDate != null &&
					this.EndBusinessUnitDate.Equals(other.EndBusinessUnitDate)
				) &&
				(
					this.Forecast == other.Forecast ||
					this.Forecast != null &&
					this.Forecast.Equals(other.Forecast)
				) &&
				(
					this.FullTimeEquivalentWeeklyHours == other.FullTimeEquivalentWeeklyHours ||
					this.FullTimeEquivalentWeeklyHours != null &&
					this.FullTimeEquivalentWeeklyHours.Equals(other.FullTimeEquivalentWeeklyHours)
				) &&
				(
					this.StaffingGroupAllocations == other.StaffingGroupAllocations ||
					this.StaffingGroupAllocations != null &&
					this.StaffingGroupAllocations.SequenceEqual(other.StaffingGroupAllocations)
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

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.StartBusinessUnitDate != null)
					hash = hash * 59 + this.StartBusinessUnitDate.GetHashCode();

				if (this.EndBusinessUnitDate != null)
					hash = hash * 59 + this.EndBusinessUnitDate.GetHashCode();

				if (this.Forecast != null)
					hash = hash * 59 + this.Forecast.GetHashCode();

				if (this.FullTimeEquivalentWeeklyHours != null)
					hash = hash * 59 + this.FullTimeEquivalentWeeklyHours.GetHashCode();

				if (this.StaffingGroupAllocations != null)
					hash = hash * 59 + this.StaffingGroupAllocations.GetHashCode();

				return hash;
			}
		}
	}

}
