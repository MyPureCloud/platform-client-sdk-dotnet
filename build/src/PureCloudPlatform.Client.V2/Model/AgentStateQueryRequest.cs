using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AgentStateQueryRequest
	/// </summary>
	[DataContract]
	public partial class AgentStateQueryRequest : IEquatable<AgentStateQueryRequest>
	{
		/// <summary>
		/// Search user order dimension names; default to userName
		/// </summary>
		/// <value>Search user order dimension names; default to userName</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum UserOrderByEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Username for "userName"
			/// </summary>
			[EnumMember(Value = "userName")]
			Username,

			/// <summary>
			/// Enum Segmentstart for "segmentStart"
			/// </summary>
			[EnumMember(Value = "segmentStart")]
			Segmentstart,

			/// <summary>
			/// Enum Sessionstart for "sessionStart"
			/// </summary>
			[EnumMember(Value = "sessionStart")]
			Sessionstart,

			/// <summary>
			/// Enum Presencedate for "presenceDate"
			/// </summary>
			[EnumMember(Value = "presenceDate")]
			Presencedate,

			/// <summary>
			/// Enum Routingstatusdate for "routingStatusDate"
			/// </summary>
			[EnumMember(Value = "routingStatusDate")]
			Routingstatusdate,

			/// <summary>
			/// Enum Systempresence for "systemPresence"
			/// </summary>
			[EnumMember(Value = "systemPresence")]
			Systempresence,

			/// <summary>
			/// Enum Routingstatus for "routingStatus"
			/// </summary>
			[EnumMember(Value = "routingStatus")]
			Routingstatus,

			/// <summary>
			/// Enum Organizationpresenceid for "organizationPresenceId"
			/// </summary>
			[EnumMember(Value = "organizationPresenceId")]
			Organizationpresenceid
		}
		/// <summary>
		/// Search user order direction; default to asc
		/// </summary>
		/// <value>Search user order direction; default to asc</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum UserOrderEnum
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
			Desc
		}
		/// <summary>
		/// Search session order dimension names; default to segmentStart
		/// </summary>
		/// <value>Search session order dimension names; default to segmentStart</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SessionOrderByEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Segmentstart for "segmentStart"
			/// </summary>
			[EnumMember(Value = "segmentStart")]
			Segmentstart,

			/// <summary>
			/// Enum Sessionstart for "sessionStart"
			/// </summary>
			[EnumMember(Value = "sessionStart")]
			Sessionstart
		}
		/// <summary>
		/// Search session order direction; default to asc
		/// </summary>
		/// <value>Search session order direction; default to asc</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SessionOrderEnum
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
			Desc
		}
		/// <summary>
		/// Search user order dimension names; default to userName
		/// </summary>
		/// <value>Search user order dimension names; default to userName</value>
		[DataMember(Name = "userOrderBy", EmitDefaultValue = false)]
		public UserOrderByEnum? UserOrderBy { get; set; }
		/// <summary>
		/// Search user order direction; default to asc
		/// </summary>
		/// <value>Search user order direction; default to asc</value>
		[DataMember(Name = "userOrder", EmitDefaultValue = false)]
		public UserOrderEnum? UserOrder { get; set; }
		/// <summary>
		/// Search session order dimension names; default to segmentStart
		/// </summary>
		/// <value>Search session order dimension names; default to segmentStart</value>
		[DataMember(Name = "sessionOrderBy", EmitDefaultValue = false)]
		public SessionOrderByEnum? SessionOrderBy { get; set; }
		/// <summary>
		/// Search session order direction; default to asc
		/// </summary>
		/// <value>Search session order direction; default to asc</value>
		[DataMember(Name = "sessionOrder", EmitDefaultValue = false)]
		public SessionOrderEnum? SessionOrder { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="AgentStateQueryRequest" /> class.
		/// </summary>
		/// <param name="UserFilter">Filters that target user-level data.</param>
		/// <param name="SessionFilter">Filters that target session-level data.</param>
		/// <param name="UserOrderBy">Search user order dimension names; default to userName.</param>
		/// <param name="UserOrder">Search user order direction; default to asc.</param>
		/// <param name="SessionOrderBy">Search session order dimension names; default to segmentStart.</param>
		/// <param name="SessionOrder">Search session order direction; default to asc.</param>
		public AgentStateQueryRequest(AgentStateUserFilter UserFilter = null, AgentStateSessionFilter SessionFilter = null, UserOrderByEnum? UserOrderBy = null, UserOrderEnum? UserOrder = null, SessionOrderByEnum? SessionOrderBy = null, SessionOrderEnum? SessionOrder = null)
		{
			this.UserFilter = UserFilter;
			this.SessionFilter = SessionFilter;
			this.UserOrderBy = UserOrderBy;
			this.UserOrder = UserOrder;
			this.SessionOrderBy = SessionOrderBy;
			this.SessionOrder = SessionOrder;

		}



		/// <summary>
		/// Filters that target user-level data
		/// </summary>
		/// <value>Filters that target user-level data</value>
		[DataMember(Name = "userFilter", EmitDefaultValue = false)]
		public AgentStateUserFilter UserFilter { get; set; }



		/// <summary>
		/// Filters that target session-level data
		/// </summary>
		/// <value>Filters that target session-level data</value>
		[DataMember(Name = "sessionFilter", EmitDefaultValue = false)]
		public AgentStateSessionFilter SessionFilter { get; set; }










		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AgentStateQueryRequest {\n");

			sb.Append("  UserFilter: ").Append(UserFilter).Append("\n");
			sb.Append("  SessionFilter: ").Append(SessionFilter).Append("\n");
			sb.Append("  UserOrderBy: ").Append(UserOrderBy).Append("\n");
			sb.Append("  UserOrder: ").Append(UserOrder).Append("\n");
			sb.Append("  SessionOrderBy: ").Append(SessionOrderBy).Append("\n");
			sb.Append("  SessionOrder: ").Append(SessionOrder).Append("\n");
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
			return this.Equals(obj as AgentStateQueryRequest);
		}

		/// <summary>
		/// Returns true if AgentStateQueryRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of AgentStateQueryRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AgentStateQueryRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.UserFilter == other.UserFilter ||
					this.UserFilter != null &&
					this.UserFilter.Equals(other.UserFilter)
				) &&
				(
					this.SessionFilter == other.SessionFilter ||
					this.SessionFilter != null &&
					this.SessionFilter.Equals(other.SessionFilter)
				) &&
				(
					this.UserOrderBy == other.UserOrderBy ||
					this.UserOrderBy != null &&
					this.UserOrderBy.Equals(other.UserOrderBy)
				) &&
				(
					this.UserOrder == other.UserOrder ||
					this.UserOrder != null &&
					this.UserOrder.Equals(other.UserOrder)
				) &&
				(
					this.SessionOrderBy == other.SessionOrderBy ||
					this.SessionOrderBy != null &&
					this.SessionOrderBy.Equals(other.SessionOrderBy)
				) &&
				(
					this.SessionOrder == other.SessionOrder ||
					this.SessionOrder != null &&
					this.SessionOrder.Equals(other.SessionOrder)
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
				if (this.UserFilter != null)
					hash = hash * 59 + this.UserFilter.GetHashCode();

				if (this.SessionFilter != null)
					hash = hash * 59 + this.SessionFilter.GetHashCode();

				if (this.UserOrderBy != null)
					hash = hash * 59 + this.UserOrderBy.GetHashCode();

				if (this.UserOrder != null)
					hash = hash * 59 + this.UserOrder.GetHashCode();

				if (this.SessionOrderBy != null)
					hash = hash * 59 + this.SessionOrderBy.GetHashCode();

				if (this.SessionOrder != null)
					hash = hash * 59 + this.SessionOrder.GetHashCode();

				return hash;
			}
		}
	}

}
