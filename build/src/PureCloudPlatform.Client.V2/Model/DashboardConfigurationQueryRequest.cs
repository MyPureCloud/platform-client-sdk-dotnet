using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DashboardConfigurationQueryRequest
	/// </summary>
	[DataContract]
	public partial class DashboardConfigurationQueryRequest : IEquatable<DashboardConfigurationQueryRequest>
	{
		/// <summary>
		/// The order in which response will be sorted
		/// </summary>
		/// <value>The order in which response will be sorted</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SortByEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Asc for "Asc"
			/// </summary>
			[EnumMember(Value = "Asc")]
			Asc,

			/// <summary>
			/// Enum Desc for "Desc"
			/// </summary>
			[EnumMember(Value = "Desc")]
			Desc
		}
		/// <summary>
		/// The order in which response will be sorted
		/// </summary>
		/// <value>The order in which response will be sorted</value>
		[DataMember(Name = "sortBy", EmitDefaultValue = false)]
		public SortByEnum? SortBy { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="DashboardConfigurationQueryRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected DashboardConfigurationQueryRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="DashboardConfigurationQueryRequest" /> class.
		/// </summary>
		/// <param name="DashboardConfigurationIds">The user supplied dashboard configuration ids (required).</param>
		/// <param name="PageNumber">The page number of the queried response.</param>
		/// <param name="PageSize">The number of entities to return of the queried response. The max is 25.</param>
		/// <param name="SortBy">The order in which response will be sorted.</param>
		public DashboardConfigurationQueryRequest(List<string> DashboardConfigurationIds = null, int? PageNumber = null, int? PageSize = null, SortByEnum? SortBy = null)
		{
			this.DashboardConfigurationIds = DashboardConfigurationIds;
			this.PageNumber = PageNumber;
			this.PageSize = PageSize;
			this.SortBy = SortBy;

		}



		/// <summary>
		/// The user supplied dashboard configuration ids
		/// </summary>
		/// <value>The user supplied dashboard configuration ids</value>
		[DataMember(Name = "dashboardConfigurationIds", EmitDefaultValue = false)]
		public List<string> DashboardConfigurationIds { get; set; }



		/// <summary>
		/// The page number of the queried response
		/// </summary>
		/// <value>The page number of the queried response</value>
		[DataMember(Name = "pageNumber", EmitDefaultValue = false)]
		public int? PageNumber { get; set; }



		/// <summary>
		/// The number of entities to return of the queried response. The max is 25
		/// </summary>
		/// <value>The number of entities to return of the queried response. The max is 25</value>
		[DataMember(Name = "pageSize", EmitDefaultValue = false)]
		public int? PageSize { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DashboardConfigurationQueryRequest {\n");

			sb.Append("  DashboardConfigurationIds: ").Append(DashboardConfigurationIds).Append("\n");
			sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
			sb.Append("  PageSize: ").Append(PageSize).Append("\n");
			sb.Append("  SortBy: ").Append(SortBy).Append("\n");
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
			return this.Equals(obj as DashboardConfigurationQueryRequest);
		}

		/// <summary>
		/// Returns true if DashboardConfigurationQueryRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of DashboardConfigurationQueryRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DashboardConfigurationQueryRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DashboardConfigurationIds == other.DashboardConfigurationIds ||
					this.DashboardConfigurationIds != null &&
					this.DashboardConfigurationIds.SequenceEqual(other.DashboardConfigurationIds)
				) &&
				(
					this.PageNumber == other.PageNumber ||
					this.PageNumber != null &&
					this.PageNumber.Equals(other.PageNumber)
				) &&
				(
					this.PageSize == other.PageSize ||
					this.PageSize != null &&
					this.PageSize.Equals(other.PageSize)
				) &&
				(
					this.SortBy == other.SortBy ||
					this.SortBy != null &&
					this.SortBy.Equals(other.SortBy)
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
				if (this.DashboardConfigurationIds != null)
					hash = hash * 59 + this.DashboardConfigurationIds.GetHashCode();

				if (this.PageNumber != null)
					hash = hash * 59 + this.PageNumber.GetHashCode();

				if (this.PageSize != null)
					hash = hash * 59 + this.PageSize.GetHashCode();

				if (this.SortBy != null)
					hash = hash * 59 + this.SortBy.GetHashCode();

				return hash;
			}
		}
	}

}
