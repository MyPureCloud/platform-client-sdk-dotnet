using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Users rule dependent response
	/// </summary>
	[DataContract]
	public partial class UsersRulesDependent : IEquatable<UsersRulesDependent>
	{
		/// <summary>
		/// The type of the dependent
		/// </summary>
		/// <value>The type of the dependent</value>
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
		/// The type of the dependent
		/// </summary>
		/// <value>The type of the dependent</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; private set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="UsersRulesDependent" /> class.
		/// </summary>
		public UsersRulesDependent()
		{

		}



		/// <summary>
		/// The id of the rule
		/// </summary>
		/// <value>The id of the rule</value>
		[DataMember(Name = "ruleId", EmitDefaultValue = false)]
		public string RuleId { get; private set; }



		/// <summary>
		/// The type id of the dependent
		/// </summary>
		/// <value>The type id of the dependent</value>
		[DataMember(Name = "typeId", EmitDefaultValue = false)]
		public string TypeId { get; private set; }





		/// <summary>
		/// The date/time the dependent was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date/time the dependent was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "createdDate", EmitDefaultValue = false)]
		public DateTime? CreatedDate { get; private set; }



		/// <summary>
		/// The user who created the dependent
		/// </summary>
		/// <value>The user who created the dependent</value>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public UserReference CreatedBy { get; private set; }



		/// <summary>
		/// Information on the last run of the dependent
		/// </summary>
		/// <value>Information on the last run of the dependent</value>
		[DataMember(Name = "lastRun", EmitDefaultValue = false)]
		public UsersRulesLastRunMetadata LastRun { get; private set; }



		/// <summary>
		/// The number of times the rule has run
		/// </summary>
		/// <value>The number of times the rule has run</value>
		[DataMember(Name = "recentRunCount", EmitDefaultValue = false)]
		public long? RecentRunCount { get; private set; }



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
			sb.Append("class UsersRulesDependent {\n");

			sb.Append("  RuleId: ").Append(RuleId).Append("\n");
			sb.Append("  TypeId: ").Append(TypeId).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
			sb.Append("  LastRun: ").Append(LastRun).Append("\n");
			sb.Append("  RecentRunCount: ").Append(RecentRunCount).Append("\n");
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
			return this.Equals(obj as UsersRulesDependent);
		}

		/// <summary>
		/// Returns true if UsersRulesDependent instances are equal
		/// </summary>
		/// <param name="other">Instance of UsersRulesDependent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UsersRulesDependent other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.RuleId == other.RuleId ||
					this.RuleId != null &&
					this.RuleId.Equals(other.RuleId)
				) &&
				(
					this.TypeId == other.TypeId ||
					this.TypeId != null &&
					this.TypeId.Equals(other.TypeId)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
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
				if (this.RuleId != null)
					hash = hash * 59 + this.RuleId.GetHashCode();

				if (this.TypeId != null)
					hash = hash * 59 + this.TypeId.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.CreatedDate != null)
					hash = hash * 59 + this.CreatedDate.GetHashCode();

				if (this.CreatedBy != null)
					hash = hash * 59 + this.CreatedBy.GetHashCode();

				if (this.LastRun != null)
					hash = hash * 59 + this.LastRun.GetHashCode();

				if (this.RecentRunCount != null)
					hash = hash * 59 + this.RecentRunCount.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
