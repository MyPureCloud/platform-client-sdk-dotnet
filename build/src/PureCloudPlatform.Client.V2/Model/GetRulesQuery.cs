using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// GetRulesQuery
	/// </summary>
	[DataContract]
	public partial class GetRulesQuery : IEquatable<GetRulesQuery>
	{
		/// <summary>
		/// The rule type of the alerts the query will return
		/// </summary>
		/// <value>The rule type of the alerts the query will return</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum RuleTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Conversation for "Conversation"
			/// </summary>
			[EnumMember(Value = "Conversation")]
			Conversation,

			/// <summary>
			/// Enum Presence for "Presence"
			/// </summary>
			[EnumMember(Value = "Presence")]
			Presence,

			/// <summary>
			/// Enum All for "All"
			/// </summary>
			[EnumMember(Value = "All")]
			All
		}
		/// <summary>
		/// The type of query being performed.
		/// </summary>
		/// <value>The type of query being performed.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum QueryTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Info for "Info"
			/// </summary>
			[EnumMember(Value = "Info")]
			Info,

			/// <summary>
			/// Enum Count for "Count"
			/// </summary>
			[EnumMember(Value = "Count")]
			Count
		}
		/// <summary>
		/// The state of the rule the query will return.  The accepted choices are Enabled, Disabled, or All
		/// </summary>
		/// <value>The state of the rule the query will return.  The accepted choices are Enabled, Disabled, or All</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum EnabledTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Enabled for "Enabled"
			/// </summary>
			[EnumMember(Value = "Enabled")]
			Enabled,

			/// <summary>
			/// Enum Disabled for "Disabled"
			/// </summary>
			[EnumMember(Value = "Disabled")]
			Disabled,

			/// <summary>
			/// Enum All for "All"
			/// </summary>
			[EnumMember(Value = "All")]
			All
		}
		/// <summary>
		/// The field to sort responses by.  The accepted choices are Name and DateStart
		/// </summary>
		/// <value>The field to sort responses by.  The accepted choices are Name and DateStart</value>
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
			/// Enum Name for "Name"
			/// </summary>
			[EnumMember(Value = "Name")]
			Name,

			/// <summary>
			/// Enum Datecreated for "DateCreated"
			/// </summary>
			[EnumMember(Value = "DateCreated")]
			Datecreated
		}
		/// <summary>
		/// The order in which response will be sorted.  The accepted choices are Asc and Desc
		/// </summary>
		/// <value>The order in which response will be sorted.  The accepted choices are Asc and Desc</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SortOrderEnum
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
		/// Specifies how strict the name search needs to be. Expected values are Exact and Contains if querying by name.
		/// </summary>
		/// <value>Specifies how strict the name search needs to be. Expected values are Exact and Contains if querying by name.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum NameSearchTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Exact for "Exact"
			/// </summary>
			[EnumMember(Value = "Exact")]
			Exact,

			/// <summary>
			/// Enum Contains for "Contains"
			/// </summary>
			[EnumMember(Value = "Contains")]
			Contains,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown
		}
		/// <summary>
		/// The rule type of the alerts the query will return
		/// </summary>
		/// <value>The rule type of the alerts the query will return</value>
		[DataMember(Name = "ruleType", EmitDefaultValue = false)]
		public RuleTypeEnum? RuleType { get; set; }
		/// <summary>
		/// The type of query being performed.
		/// </summary>
		/// <value>The type of query being performed.</value>
		[DataMember(Name = "queryType", EmitDefaultValue = false)]
		public QueryTypeEnum? QueryType { get; set; }
		/// <summary>
		/// The state of the rule the query will return.  The accepted choices are Enabled, Disabled, or All
		/// </summary>
		/// <value>The state of the rule the query will return.  The accepted choices are Enabled, Disabled, or All</value>
		[DataMember(Name = "enabledType", EmitDefaultValue = false)]
		public EnabledTypeEnum? EnabledType { get; set; }
		/// <summary>
		/// The field to sort responses by.  The accepted choices are Name and DateStart
		/// </summary>
		/// <value>The field to sort responses by.  The accepted choices are Name and DateStart</value>
		[DataMember(Name = "sortBy", EmitDefaultValue = false)]
		public SortByEnum? SortBy { get; set; }
		/// <summary>
		/// The order in which response will be sorted.  The accepted choices are Asc and Desc
		/// </summary>
		/// <value>The order in which response will be sorted.  The accepted choices are Asc and Desc</value>
		[DataMember(Name = "sortOrder", EmitDefaultValue = false)]
		public SortOrderEnum? SortOrder { get; set; }
		/// <summary>
		/// Specifies how strict the name search needs to be. Expected values are Exact and Contains if querying by name.
		/// </summary>
		/// <value>Specifies how strict the name search needs to be. Expected values are Exact and Contains if querying by name.</value>
		[DataMember(Name = "nameSearchType", EmitDefaultValue = false)]
		public NameSearchTypeEnum? NameSearchType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="GetRulesQuery" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected GetRulesQuery() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="GetRulesQuery" /> class.
		/// </summary>
		/// <param name="RuleType">The rule type of the alerts the query will return (required).</param>
		/// <param name="QueryType">The type of query being performed. (required).</param>
		/// <param name="EnabledType">The state of the rule the query will return.  The accepted choices are Enabled, Disabled, or All.</param>
		/// <param name="PageNumber">The page number of the queried response.</param>
		/// <param name="PageSize">The number of entities to return of the queried response.  The max is 25.</param>
		/// <param name="SortBy">The field to sort responses by.  The accepted choices are Name and DateStart.</param>
		/// <param name="SortOrder">The order in which response will be sorted.  The accepted choices are Asc and Desc.</param>
		/// <param name="RuleName">The name of the rule being queries..</param>
		/// <param name="NameSearchType">Specifies how strict the name search needs to be. Expected values are Exact and Contains if querying by name..</param>
		public GetRulesQuery(RuleTypeEnum? RuleType = null, QueryTypeEnum? QueryType = null, EnabledTypeEnum? EnabledType = null, int? PageNumber = null, int? PageSize = null, SortByEnum? SortBy = null, SortOrderEnum? SortOrder = null, string RuleName = null, NameSearchTypeEnum? NameSearchType = null)
		{
			this.RuleType = RuleType;
			this.QueryType = QueryType;
			this.EnabledType = EnabledType;
			this.PageNumber = PageNumber;
			this.PageSize = PageSize;
			this.SortBy = SortBy;
			this.SortOrder = SortOrder;
			this.RuleName = RuleName;
			this.NameSearchType = NameSearchType;

		}









		/// <summary>
		/// The page number of the queried response
		/// </summary>
		/// <value>The page number of the queried response</value>
		[DataMember(Name = "pageNumber", EmitDefaultValue = false)]
		public int? PageNumber { get; set; }



		/// <summary>
		/// The number of entities to return of the queried response.  The max is 25
		/// </summary>
		/// <value>The number of entities to return of the queried response.  The max is 25</value>
		[DataMember(Name = "pageSize", EmitDefaultValue = false)]
		public int? PageSize { get; set; }







		/// <summary>
		/// The name of the rule being queries.
		/// </summary>
		/// <value>The name of the rule being queries.</value>
		[DataMember(Name = "ruleName", EmitDefaultValue = false)]
		public string RuleName { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetRulesQuery {\n");

			sb.Append("  RuleType: ").Append(RuleType).Append("\n");
			sb.Append("  QueryType: ").Append(QueryType).Append("\n");
			sb.Append("  EnabledType: ").Append(EnabledType).Append("\n");
			sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
			sb.Append("  PageSize: ").Append(PageSize).Append("\n");
			sb.Append("  SortBy: ").Append(SortBy).Append("\n");
			sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
			sb.Append("  RuleName: ").Append(RuleName).Append("\n");
			sb.Append("  NameSearchType: ").Append(NameSearchType).Append("\n");
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
			return this.Equals(obj as GetRulesQuery);
		}

		/// <summary>
		/// Returns true if GetRulesQuery instances are equal
		/// </summary>
		/// <param name="other">Instance of GetRulesQuery to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(GetRulesQuery other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.RuleType == other.RuleType ||
					this.RuleType != null &&
					this.RuleType.Equals(other.RuleType)
				) &&
				(
					this.QueryType == other.QueryType ||
					this.QueryType != null &&
					this.QueryType.Equals(other.QueryType)
				) &&
				(
					this.EnabledType == other.EnabledType ||
					this.EnabledType != null &&
					this.EnabledType.Equals(other.EnabledType)
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
				) &&
				(
					this.SortOrder == other.SortOrder ||
					this.SortOrder != null &&
					this.SortOrder.Equals(other.SortOrder)
				) &&
				(
					this.RuleName == other.RuleName ||
					this.RuleName != null &&
					this.RuleName.Equals(other.RuleName)
				) &&
				(
					this.NameSearchType == other.NameSearchType ||
					this.NameSearchType != null &&
					this.NameSearchType.Equals(other.NameSearchType)
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
				if (this.RuleType != null)
					hash = hash * 59 + this.RuleType.GetHashCode();

				if (this.QueryType != null)
					hash = hash * 59 + this.QueryType.GetHashCode();

				if (this.EnabledType != null)
					hash = hash * 59 + this.EnabledType.GetHashCode();

				if (this.PageNumber != null)
					hash = hash * 59 + this.PageNumber.GetHashCode();

				if (this.PageSize != null)
					hash = hash * 59 + this.PageSize.GetHashCode();

				if (this.SortBy != null)
					hash = hash * 59 + this.SortBy.GetHashCode();

				if (this.SortOrder != null)
					hash = hash * 59 + this.SortOrder.GetHashCode();

				if (this.RuleName != null)
					hash = hash * 59 + this.RuleName.GetHashCode();

				if (this.NameSearchType != null)
					hash = hash * 59 + this.NameSearchType.GetHashCode();

				return hash;
			}
		}
	}

}
