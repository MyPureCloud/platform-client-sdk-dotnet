using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BuForecastStaffingRequirementsResultResponse
	/// </summary>
	[DataContract]
	public partial class BuForecastStaffingRequirementsResultResponse : IEquatable<BuForecastStaffingRequirementsResultResponse>
	{
		/// <summary>
		/// The state of the staffing requirements generation
		/// </summary>
		/// <value>The state of the staffing requirements generation</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StateEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Processing for "Processing"
			/// </summary>
			[EnumMember(Value = "Processing")]
			Processing,

			/// <summary>
			/// Enum Complete for "Complete"
			/// </summary>
			[EnumMember(Value = "Complete")]
			Complete,

			/// <summary>
			/// Enum Error for "Error"
			/// </summary>
			[EnumMember(Value = "Error")]
			Error
		}
		/// <summary>
		/// The state of the staffing requirements generation
		/// </summary>
		/// <value>The state of the staffing requirements generation</value>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public StateEnum? State { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="BuForecastStaffingRequirementsResultResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected BuForecastStaffingRequirementsResultResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="BuForecastStaffingRequirementsResultResponse" /> class.
		/// </summary>
		/// <param name="BusinessUnitId">The ID of the business unit to which the forecast staffing requirements belongs (required).</param>
		/// <param name="Forecast">The forecast reference (required).</param>
		/// <param name="ReferenceStartDate">The reference start date for interval-based data for this forecast as an ISO-8601 string (required).</param>
		/// <param name="WeekCount">The number of weeks in this forecast (required).</param>
		/// <param name="IntervalLengthMinutes">The period/interval in minutes for which to aggregate the data (required).</param>
		/// <param name="State">The state of the staffing requirements generation (required).</param>
		/// <param name="Results">The forecast staffing requirement results, Will be populated when state &#x3D;&#x3D; &#39;Complete&#39;.</param>
		public BuForecastStaffingRequirementsResultResponse(string BusinessUnitId = null, BuShortTermForecastReference Forecast = null, DateTime? ReferenceStartDate = null, int? WeekCount = null, int? IntervalLengthMinutes = null, StateEnum? State = null, List<BuForecastStaffingRequirementsResult> Results = null)
		{
			this.BusinessUnitId = BusinessUnitId;
			this.Forecast = Forecast;
			this.ReferenceStartDate = ReferenceStartDate;
			this.WeekCount = WeekCount;
			this.IntervalLengthMinutes = IntervalLengthMinutes;
			this.State = State;
			this.Results = Results;

		}



		/// <summary>
		/// The ID of the business unit to which the forecast staffing requirements belongs
		/// </summary>
		/// <value>The ID of the business unit to which the forecast staffing requirements belongs</value>
		[DataMember(Name = "businessUnitId", EmitDefaultValue = false)]
		public string BusinessUnitId { get; set; }



		/// <summary>
		/// The forecast reference
		/// </summary>
		/// <value>The forecast reference</value>
		[DataMember(Name = "forecast", EmitDefaultValue = false)]
		public BuShortTermForecastReference Forecast { get; set; }



		/// <summary>
		/// The reference start date for interval-based data for this forecast as an ISO-8601 string
		/// </summary>
		/// <value>The reference start date for interval-based data for this forecast as an ISO-8601 string</value>
		[DataMember(Name = "referenceStartDate", EmitDefaultValue = false)]
		public DateTime? ReferenceStartDate { get; set; }



		/// <summary>
		/// The number of weeks in this forecast
		/// </summary>
		/// <value>The number of weeks in this forecast</value>
		[DataMember(Name = "weekCount", EmitDefaultValue = false)]
		public int? WeekCount { get; set; }



		/// <summary>
		/// The period/interval in minutes for which to aggregate the data
		/// </summary>
		/// <value>The period/interval in minutes for which to aggregate the data</value>
		[DataMember(Name = "intervalLengthMinutes", EmitDefaultValue = false)]
		public int? IntervalLengthMinutes { get; set; }





		/// <summary>
		/// The forecast staffing requirement results, Will be populated when state &#x3D;&#x3D; &#39;Complete&#39;
		/// </summary>
		/// <value>The forecast staffing requirement results, Will be populated when state &#x3D;&#x3D; &#39;Complete&#39;</value>
		[DataMember(Name = "results", EmitDefaultValue = false)]
		public List<BuForecastStaffingRequirementsResult> Results { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BuForecastStaffingRequirementsResultResponse {\n");

			sb.Append("  BusinessUnitId: ").Append(BusinessUnitId).Append("\n");
			sb.Append("  Forecast: ").Append(Forecast).Append("\n");
			sb.Append("  ReferenceStartDate: ").Append(ReferenceStartDate).Append("\n");
			sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
			sb.Append("  IntervalLengthMinutes: ").Append(IntervalLengthMinutes).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  Results: ").Append(Results).Append("\n");
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
			return this.Equals(obj as BuForecastStaffingRequirementsResultResponse);
		}

		/// <summary>
		/// Returns true if BuForecastStaffingRequirementsResultResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of BuForecastStaffingRequirementsResultResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BuForecastStaffingRequirementsResultResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.BusinessUnitId == other.BusinessUnitId ||
					this.BusinessUnitId != null &&
					this.BusinessUnitId.Equals(other.BusinessUnitId)
				) &&
				(
					this.Forecast == other.Forecast ||
					this.Forecast != null &&
					this.Forecast.Equals(other.Forecast)
				) &&
				(
					this.ReferenceStartDate == other.ReferenceStartDate ||
					this.ReferenceStartDate != null &&
					this.ReferenceStartDate.Equals(other.ReferenceStartDate)
				) &&
				(
					this.WeekCount == other.WeekCount ||
					this.WeekCount != null &&
					this.WeekCount.Equals(other.WeekCount)
				) &&
				(
					this.IntervalLengthMinutes == other.IntervalLengthMinutes ||
					this.IntervalLengthMinutes != null &&
					this.IntervalLengthMinutes.Equals(other.IntervalLengthMinutes)
				) &&
				(
					this.State == other.State ||
					this.State != null &&
					this.State.Equals(other.State)
				) &&
				(
					this.Results == other.Results ||
					this.Results != null &&
					this.Results.SequenceEqual(other.Results)
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
				if (this.BusinessUnitId != null)
					hash = hash * 59 + this.BusinessUnitId.GetHashCode();

				if (this.Forecast != null)
					hash = hash * 59 + this.Forecast.GetHashCode();

				if (this.ReferenceStartDate != null)
					hash = hash * 59 + this.ReferenceStartDate.GetHashCode();

				if (this.WeekCount != null)
					hash = hash * 59 + this.WeekCount.GetHashCode();

				if (this.IntervalLengthMinutes != null)
					hash = hash * 59 + this.IntervalLengthMinutes.GetHashCode();

				if (this.State != null)
					hash = hash * 59 + this.State.GetHashCode();

				if (this.Results != null)
					hash = hash * 59 + this.Results.GetHashCode();

				return hash;
			}
		}
	}

}
