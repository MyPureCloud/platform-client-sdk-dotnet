using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Users rule response
	/// </summary>
	[DataContract]
	public partial class UsersRulesRule : IEquatable<UsersRulesRule>
	{
		/// <summary>
		/// The type of the rule
		/// </summary>
		/// <value>The type of the rule</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Learning for "Learning"
			/// </summary>
			[EnumMember(Value = "Learning")]
			Learning
		}
		/// <summary>
		/// The type of the rule
		/// </summary>
		/// <value>The type of the rule</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; private set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="UsersRulesRule" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		public UsersRulesRule(string Name = null)
		{
			this.Name = Name;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The description of the rule
		/// </summary>
		/// <value>The description of the rule</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; private set; }





		/// <summary>
		/// The criteria of the rule
		/// </summary>
		/// <value>The criteria of the rule</value>
		[DataMember(Name = "criteria", EmitDefaultValue = false)]
		public List<UsersRulesCriteria> Criteria { get; private set; }



		/// <summary>
		/// The date/time the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date/time the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "createdDate", EmitDefaultValue = false)]
		public DateTime? CreatedDate { get; private set; }



		/// <summary>
		/// The user who created the rule
		/// </summary>
		/// <value>The user who created the rule</value>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public UserReference CreatedBy { get; private set; }



		/// <summary>
		/// The date/time the rule was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date/time the rule was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
		public DateTime? ModifiedDate { get; private set; }



		/// <summary>
		/// The last user to modify the rule
		/// </summary>
		/// <value>The last user to modify the rule</value>
		[DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
		public UserReference ModifiedBy { get; private set; }



		/// <summary>
		/// Information on the last run of the rule
		/// </summary>
		/// <value>Information on the last run of the rule</value>
		[DataMember(Name = "lastRun", EmitDefaultValue = false)]
		public UsersRulesLastRunMetadata LastRun { get; private set; }



		/// <summary>
		/// The number of times the rule has run
		/// </summary>
		/// <value>The number of times the rule has run</value>
		[DataMember(Name = "recentRunCount", EmitDefaultValue = false)]
		public long? RecentRunCount { get; private set; }



		/// <summary>
		/// The number of dependents this rule has
		/// </summary>
		/// <value>The number of dependents this rule has</value>
		[DataMember(Name = "dependentCount", EmitDefaultValue = false)]
		public long? DependentCount { get; private set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UsersRulesRule {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Criteria: ").Append(Criteria).Append("\n");
			sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
			sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
			sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
			sb.Append("  LastRun: ").Append(LastRun).Append("\n");
			sb.Append("  RecentRunCount: ").Append(RecentRunCount).Append("\n");
			sb.Append("  DependentCount: ").Append(DependentCount).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as UsersRulesRule);
		}

		/// <summary>
		/// Returns true if UsersRulesRule instances are equal
		/// </summary>
		/// <param name="other">Instance of UsersRulesRule to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UsersRulesRule other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
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
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Criteria == other.Criteria ||
					this.Criteria != null &&
					this.Criteria.SequenceEqual(other.Criteria)
				) &&
				(
					this.CreatedDate == other.CreatedDate ||
					this.CreatedDate != null &&
					this.CreatedDate.Equals(other.CreatedDate)
				) &&
				(
					this.CreatedBy == other.CreatedBy ||
					this.CreatedBy != null &&
					this.CreatedBy.Equals(other.CreatedBy)
				) &&
				(
					this.ModifiedDate == other.ModifiedDate ||
					this.ModifiedDate != null &&
					this.ModifiedDate.Equals(other.ModifiedDate)
				) &&
				(
					this.ModifiedBy == other.ModifiedBy ||
					this.ModifiedBy != null &&
					this.ModifiedBy.Equals(other.ModifiedBy)
				) &&
				(
					this.LastRun == other.LastRun ||
					this.LastRun != null &&
					this.LastRun.Equals(other.LastRun)
				) &&
				(
					this.RecentRunCount == other.RecentRunCount ||
					this.RecentRunCount != null &&
					this.RecentRunCount.Equals(other.RecentRunCount)
				) &&
				(
					this.DependentCount == other.DependentCount ||
					this.DependentCount != null &&
					this.DependentCount.Equals(other.DependentCount)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Criteria != null)
					hash = hash * 59 + this.Criteria.GetHashCode();

				if (this.CreatedDate != null)
					hash = hash * 59 + this.CreatedDate.GetHashCode();

				if (this.CreatedBy != null)
					hash = hash * 59 + this.CreatedBy.GetHashCode();

				if (this.ModifiedDate != null)
					hash = hash * 59 + this.ModifiedDate.GetHashCode();

				if (this.ModifiedBy != null)
					hash = hash * 59 + this.ModifiedBy.GetHashCode();

				if (this.LastRun != null)
					hash = hash * 59 + this.LastRun.GetHashCode();

				if (this.RecentRunCount != null)
					hash = hash * 59 + this.RecentRunCount.GetHashCode();

				if (this.DependentCount != null)
					hash = hash * 59 + this.DependentCount.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
