using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TeamActivityQuery
	/// </summary>
	[DataContract]
	public partial class TeamActivityQuery : IEquatable<TeamActivityQuery>
	{
		/// <summary>
		/// Gets or Sets GroupBy
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum GroupByEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Teamid for "teamId"
			/// </summary>
			[EnumMember(Value = "teamId")]
			Teamid
		}
		/// <summary>
		/// Sort the result set in ascending/descending order. Default is ascending
		/// </summary>
		/// <value>Sort the result set in ascending/descending order. Default is ascending</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum OrderEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Asc for "asc"
			/// </summary>
			[EnumMember(Value = "asc")]
			Asc,

			/// <summary>
			/// Enum Desc for "desc"
			/// </summary>
			[EnumMember(Value = "desc")]
			Desc,

			/// <summary>
			/// Enum Unordered for "unordered"
			/// </summary>
			[EnumMember(Value = "unordered")]
			Unordered
		}
		/// <summary>
		/// Sort the result set in ascending/descending order. Default is ascending
		/// </summary>
		/// <value>Sort the result set in ascending/descending order. Default is ascending</value>
		[DataMember(Name = "order", EmitDefaultValue = false)]
		public OrderEnum? Order { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="TeamActivityQuery" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected TeamActivityQuery() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="TeamActivityQuery" /> class.
		/// </summary>
		/// <param name="Metrics">List of requested metrics (required).</param>
		/// <param name="GroupBy">Dimension(s) to group by (required).</param>
		/// <param name="Filter">Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters.</param>
		/// <param name="Order">Sort the result set in ascending/descending order. Default is ascending.</param>
		public TeamActivityQuery(List<TeamActivityQueryMetric> Metrics = null, List<GroupByEnum> GroupBy = null, TeamActivityQueryFilter Filter = null, OrderEnum? Order = null)
		{
			this.Metrics = Metrics;
			this.GroupBy = GroupBy;
			this.Filter = Filter;
			this.Order = Order;

		}



		/// <summary>
		/// List of requested metrics
		/// </summary>
		/// <value>List of requested metrics</value>
		[DataMember(Name = "metrics", EmitDefaultValue = false)]
		public List<TeamActivityQueryMetric> Metrics { get; set; }



		/// <summary>
		/// Dimension(s) to group by
		/// </summary>
		/// <value>Dimension(s) to group by</value>
		[DataMember(Name = "groupBy", EmitDefaultValue = false)]
		public List<GroupByEnum> GroupBy { get; set; }



		/// <summary>
		/// Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters
		/// </summary>
		/// <value>Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters</value>
		[DataMember(Name = "filter", EmitDefaultValue = false)]
		public TeamActivityQueryFilter Filter { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TeamActivityQuery {\n");

			sb.Append("  Metrics: ").Append(Metrics).Append("\n");
			sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
			sb.Append("  Filter: ").Append(Filter).Append("\n");
			sb.Append("  Order: ").Append(Order).Append("\n");
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
			return this.Equals(obj as TeamActivityQuery);
		}

		/// <summary>
		/// Returns true if TeamActivityQuery instances are equal
		/// </summary>
		/// <param name="other">Instance of TeamActivityQuery to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TeamActivityQuery other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Metrics == other.Metrics ||
					this.Metrics != null &&
					this.Metrics.SequenceEqual(other.Metrics)
				) &&
				(
					this.GroupBy == other.GroupBy ||
					this.GroupBy != null &&
					this.GroupBy.SequenceEqual(other.GroupBy)
				) &&
				(
					this.Filter == other.Filter ||
					this.Filter != null &&
					this.Filter.Equals(other.Filter)
				) &&
				(
					this.Order == other.Order ||
					this.Order != null &&
					this.Order.Equals(other.Order)
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
				if (this.Metrics != null)
					hash = hash * 59 + this.Metrics.GetHashCode();

				if (this.GroupBy != null)
					hash = hash * 59 + this.GroupBy.GetHashCode();

				if (this.Filter != null)
					hash = hash * 59 + this.Filter.GetHashCode();

				if (this.Order != null)
					hash = hash * 59 + this.Order.GetHashCode();

				return hash;
			}
		}
	}

}
