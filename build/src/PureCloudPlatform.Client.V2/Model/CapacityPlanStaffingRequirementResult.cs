using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CapacityPlanStaffingRequirementResult
	/// </summary>
	[DataContract]
	public partial class CapacityPlanStaffingRequirementResult : IEquatable<CapacityPlanStaffingRequirementResult>
	{
		/// <summary>
		/// The status of the requirement generation of the capacity plan
		/// </summary>
		/// <value>The status of the requirement generation of the capacity plan</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StatusEnum
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
			/// Enum Canceled for "Canceled"
			/// </summary>
			[EnumMember(Value = "Canceled")]
			Canceled,

			/// <summary>
			/// Enum Error for "Error"
			/// </summary>
			[EnumMember(Value = "Error")]
			Error
		}
		/// <summary>
		/// Granularity of the intervals
		/// </summary>
		/// <value>Granularity of the intervals</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum GranularityEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Weekly for "Weekly"
			/// </summary>
			[EnumMember(Value = "Weekly")]
			Weekly
		}
		/// <summary>
		/// The error code when status is 'Failed'
		/// </summary>
		/// <value>The error code when status is 'Failed'</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ErrorCodeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Timedout for "TimedOut"
			/// </summary>
			[EnumMember(Value = "TimedOut")]
			Timedout,

			/// <summary>
			/// Enum Nodata for "NoData"
			/// </summary>
			[EnumMember(Value = "NoData")]
			Nodata,

			/// <summary>
			/// Enum Clientdatainvalid for "ClientDataInvalid"
			/// </summary>
			[EnumMember(Value = "ClientDataInvalid")]
			Clientdatainvalid,

			/// <summary>
			/// Enum Configurationinvalid for "ConfigurationInvalid"
			/// </summary>
			[EnumMember(Value = "ConfigurationInvalid")]
			Configurationinvalid,

			/// <summary>
			/// Enum Requirementsfailed for "RequirementsFailed"
			/// </summary>
			[EnumMember(Value = "RequirementsFailed")]
			Requirementsfailed
		}
		/// <summary>
		/// The status of the requirement generation of the capacity plan
		/// </summary>
		/// <value>The status of the requirement generation of the capacity plan</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// Granularity of the intervals
		/// </summary>
		/// <value>Granularity of the intervals</value>
		[DataMember(Name = "granularity", EmitDefaultValue = false)]
		public GranularityEnum? Granularity { get; set; }
		/// <summary>
		/// The error code when status is 'Failed'
		/// </summary>
		/// <value>The error code when status is 'Failed'</value>
		[DataMember(Name = "errorCode", EmitDefaultValue = false)]
		public ErrorCodeEnum? ErrorCode { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="CapacityPlanStaffingRequirementResult" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CapacityPlanStaffingRequirementResult() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CapacityPlanStaffingRequirementResult" /> class.
		/// </summary>
		/// <param name="BusinessUnit">The business unit to which the capacity plan belongs (required).</param>
		/// <param name="CapacityPlan">The capacity plan for which requirements are generated (required).</param>
		/// <param name="Status">The status of the requirement generation of the capacity plan (required).</param>
		/// <param name="ReferenceBusinessUnitDate">The reference date for interval-based data for the requirements. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
		/// <param name="Granularity">Granularity of the intervals (required).</param>
		/// <param name="ErrorCode">The error code when status is &#39;Failed&#39;.</param>
		/// <param name="DownloadUrl">The URL to get the requirements results for the capacity plan. It will be populated if the status is &#39;Complete&#39;.</param>
		/// <param name="DownloadTemplate">Staffing requirement results always come through downloadUrl, the schema included here is just for documentation.</param>
		public CapacityPlanStaffingRequirementResult(BusinessUnitReference BusinessUnit = null, CapacityPlanReference CapacityPlan = null, StatusEnum? Status = null, String ReferenceBusinessUnitDate = null, GranularityEnum? Granularity = null, ErrorCodeEnum? ErrorCode = null, string DownloadUrl = null, StaffingRequirementResultResponseTemplate DownloadTemplate = null)
		{
			this.BusinessUnit = BusinessUnit;
			this.CapacityPlan = CapacityPlan;
			this.Status = Status;
			this.ReferenceBusinessUnitDate = ReferenceBusinessUnitDate;
			this.Granularity = Granularity;
			this.ErrorCode = ErrorCode;
			this.DownloadUrl = DownloadUrl;
			this.DownloadTemplate = DownloadTemplate;

		}



		/// <summary>
		/// The business unit to which the capacity plan belongs
		/// </summary>
		/// <value>The business unit to which the capacity plan belongs</value>
		[DataMember(Name = "businessUnit", EmitDefaultValue = false)]
		public BusinessUnitReference BusinessUnit { get; set; }



		/// <summary>
		/// The capacity plan for which requirements are generated
		/// </summary>
		/// <value>The capacity plan for which requirements are generated</value>
		[DataMember(Name = "capacityPlan", EmitDefaultValue = false)]
		public CapacityPlanReference CapacityPlan { get; set; }





		/// <summary>
		/// The reference date for interval-based data for the requirements. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The reference date for interval-based data for the requirements. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "referenceBusinessUnitDate", EmitDefaultValue = false)]
		public String ReferenceBusinessUnitDate { get; set; }







		/// <summary>
		/// The URL to get the requirements results for the capacity plan. It will be populated if the status is &#39;Complete&#39;
		/// </summary>
		/// <value>The URL to get the requirements results for the capacity plan. It will be populated if the status is &#39;Complete&#39;</value>
		[DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
		public string DownloadUrl { get; set; }



		/// <summary>
		/// Staffing requirement results always come through downloadUrl, the schema included here is just for documentation
		/// </summary>
		/// <value>Staffing requirement results always come through downloadUrl, the schema included here is just for documentation</value>
		[DataMember(Name = "downloadTemplate", EmitDefaultValue = false)]
		public StaffingRequirementResultResponseTemplate DownloadTemplate { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CapacityPlanStaffingRequirementResult {\n");

			sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
			sb.Append("  CapacityPlan: ").Append(CapacityPlan).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  ReferenceBusinessUnitDate: ").Append(ReferenceBusinessUnitDate).Append("\n");
			sb.Append("  Granularity: ").Append(Granularity).Append("\n");
			sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
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
			return this.Equals(obj as CapacityPlanStaffingRequirementResult);
		}

		/// <summary>
		/// Returns true if CapacityPlanStaffingRequirementResult instances are equal
		/// </summary>
		/// <param name="other">Instance of CapacityPlanStaffingRequirementResult to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CapacityPlanStaffingRequirementResult other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.BusinessUnit == other.BusinessUnit ||
					this.BusinessUnit != null &&
					this.BusinessUnit.Equals(other.BusinessUnit)
				) &&
				(
					this.CapacityPlan == other.CapacityPlan ||
					this.CapacityPlan != null &&
					this.CapacityPlan.Equals(other.CapacityPlan)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.ReferenceBusinessUnitDate == other.ReferenceBusinessUnitDate ||
					this.ReferenceBusinessUnitDate != null &&
					this.ReferenceBusinessUnitDate.Equals(other.ReferenceBusinessUnitDate)
				) &&
				(
					this.Granularity == other.Granularity ||
					this.Granularity != null &&
					this.Granularity.Equals(other.Granularity)
				) &&
				(
					this.ErrorCode == other.ErrorCode ||
					this.ErrorCode != null &&
					this.ErrorCode.Equals(other.ErrorCode)
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
				if (this.BusinessUnit != null)
					hash = hash * 59 + this.BusinessUnit.GetHashCode();

				if (this.CapacityPlan != null)
					hash = hash * 59 + this.CapacityPlan.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.ReferenceBusinessUnitDate != null)
					hash = hash * 59 + this.ReferenceBusinessUnitDate.GetHashCode();

				if (this.Granularity != null)
					hash = hash * 59 + this.Granularity.GetHashCode();

				if (this.ErrorCode != null)
					hash = hash * 59 + this.ErrorCode.GetHashCode();

				if (this.DownloadUrl != null)
					hash = hash * 59 + this.DownloadUrl.GetHashCode();

				if (this.DownloadTemplate != null)
					hash = hash * 59 + this.DownloadTemplate.GetHashCode();

				return hash;
			}
		}
	}

}
