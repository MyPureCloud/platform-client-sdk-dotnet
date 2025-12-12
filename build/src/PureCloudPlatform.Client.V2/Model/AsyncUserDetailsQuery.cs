using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AsyncUserDetailsQuery
	/// </summary>
	[DataContract]
	public partial class AsyncUserDetailsQuery : IEquatable<AsyncUserDetailsQuery>
	{
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
		/// Initializes a new instance of the <see cref="AsyncUserDetailsQuery" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AsyncUserDetailsQuery() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AsyncUserDetailsQuery" /> class.
		/// </summary>
		/// <param name="Interval">Specifies the date and time range of data being queried. Conversations MUST have started within this time range to potentially be included within the result set. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
		/// <param name="UserFilters">Filters that target the users to retrieve data for.</param>
		/// <param name="PresenceFilters">Filters that target system and organization presence-level data.</param>
		/// <param name="RoutingStatusFilters">Filters that target agent routing status-level data.</param>
		/// <param name="Order">Sort the result set in ascending/descending order. Default is ascending.</param>
		/// <param name="Limit">Specify number of results to be returned.</param>
		public AsyncUserDetailsQuery(string Interval = null, List<UserDetailQueryFilter> UserFilters = null, List<PresenceDetailQueryFilter> PresenceFilters = null, List<RoutingStatusDetailQueryFilter> RoutingStatusFilters = null, OrderEnum? Order = null, int? Limit = null)
		{
			this.Interval = Interval;
			this.UserFilters = UserFilters;
			this.PresenceFilters = PresenceFilters;
			this.RoutingStatusFilters = RoutingStatusFilters;
			this.Order = Order;
			this.Limit = Limit;

		}



		/// <summary>
		/// Specifies the date and time range of data being queried. Conversations MUST have started within this time range to potentially be included within the result set. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
		/// </summary>
		/// <value>Specifies the date and time range of data being queried. Conversations MUST have started within this time range to potentially be included within the result set. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
		[DataMember(Name = "interval", EmitDefaultValue = false)]
		public string Interval { get; set; }



		/// <summary>
		/// Filters that target the users to retrieve data for
		/// </summary>
		/// <value>Filters that target the users to retrieve data for</value>
		[DataMember(Name = "userFilters", EmitDefaultValue = false)]
		public List<UserDetailQueryFilter> UserFilters { get; set; }



		/// <summary>
		/// Filters that target system and organization presence-level data
		/// </summary>
		/// <value>Filters that target system and organization presence-level data</value>
		[DataMember(Name = "presenceFilters", EmitDefaultValue = false)]
		public List<PresenceDetailQueryFilter> PresenceFilters { get; set; }



		/// <summary>
		/// Filters that target agent routing status-level data
		/// </summary>
		/// <value>Filters that target agent routing status-level data</value>
		[DataMember(Name = "routingStatusFilters", EmitDefaultValue = false)]
		public List<RoutingStatusDetailQueryFilter> RoutingStatusFilters { get; set; }





		/// <summary>
		/// Specify number of results to be returned
		/// </summary>
		/// <value>Specify number of results to be returned</value>
		[DataMember(Name = "limit", EmitDefaultValue = false)]
		public int? Limit { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AsyncUserDetailsQuery {\n");

			sb.Append("  Interval: ").Append(Interval).Append("\n");
			sb.Append("  UserFilters: ").Append(UserFilters).Append("\n");
			sb.Append("  PresenceFilters: ").Append(PresenceFilters).Append("\n");
			sb.Append("  RoutingStatusFilters: ").Append(RoutingStatusFilters).Append("\n");
			sb.Append("  Order: ").Append(Order).Append("\n");
			sb.Append("  Limit: ").Append(Limit).Append("\n");
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
			return this.Equals(obj as AsyncUserDetailsQuery);
		}

		/// <summary>
		/// Returns true if AsyncUserDetailsQuery instances are equal
		/// </summary>
		/// <param name="other">Instance of AsyncUserDetailsQuery to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AsyncUserDetailsQuery other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Interval == other.Interval ||
					this.Interval != null &&
					this.Interval.Equals(other.Interval)
				) &&
				(
					this.UserFilters == other.UserFilters ||
					this.UserFilters != null &&
					this.UserFilters.SequenceEqual(other.UserFilters)
				) &&
				(
					this.PresenceFilters == other.PresenceFilters ||
					this.PresenceFilters != null &&
					this.PresenceFilters.SequenceEqual(other.PresenceFilters)
				) &&
				(
					this.RoutingStatusFilters == other.RoutingStatusFilters ||
					this.RoutingStatusFilters != null &&
					this.RoutingStatusFilters.SequenceEqual(other.RoutingStatusFilters)
				) &&
				(
					this.Order == other.Order ||
					this.Order != null &&
					this.Order.Equals(other.Order)
				) &&
				(
					this.Limit == other.Limit ||
					this.Limit != null &&
					this.Limit.Equals(other.Limit)
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
				if (this.Interval != null)
					hash = hash * 59 + this.Interval.GetHashCode();

				if (this.UserFilters != null)
					hash = hash * 59 + this.UserFilters.GetHashCode();

				if (this.PresenceFilters != null)
					hash = hash * 59 + this.PresenceFilters.GetHashCode();

				if (this.RoutingStatusFilters != null)
					hash = hash * 59 + this.RoutingStatusFilters.GetHashCode();

				if (this.Order != null)
					hash = hash * 59 + this.Order.GetHashCode();

				if (this.Limit != null)
					hash = hash * 59 + this.Limit.GetHashCode();

				return hash;
			}
		}
	}

}
