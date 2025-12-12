using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UsersRulesLockedCriteriaSettingsCriteria
	/// </summary>
	[DataContract]
	public partial class UsersRulesLockedCriteriaSettingsCriteria : IEquatable<UsersRulesLockedCriteriaSettingsCriteria>
	{
		/// <summary>
		/// The operator for this criteria
		/// </summary>
		/// <value>The operator for this criteria</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum OperatorEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Or for "Or"
			/// </summary>
			[EnumMember(Value = "Or")]
			Or
		}
		/// <summary>
		/// The operator for this criteria
		/// </summary>
		/// <value>The operator for this criteria</value>
		[DataMember(Name = "operator", EmitDefaultValue = false)]
		public OperatorEnum? Operator { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="UsersRulesLockedCriteriaSettingsCriteria" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UsersRulesLockedCriteriaSettingsCriteria() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UsersRulesLockedCriteriaSettingsCriteria" /> class.
		/// </summary>
		/// <param name="Operator">The operator for this criteria (required).</param>
		/// <param name="Group">The user selection groups for this criteria (required).</param>
		public UsersRulesLockedCriteriaSettingsCriteria(OperatorEnum? Operator = null, List<UsersRulesLockedCriteriaSettingsGroup> Group = null)
		{
			this.Operator = Operator;
			this.Group = Group;

		}





		/// <summary>
		/// The user selection groups for this criteria
		/// </summary>
		/// <value>The user selection groups for this criteria</value>
		[DataMember(Name = "group", EmitDefaultValue = false)]
		public List<UsersRulesLockedCriteriaSettingsGroup> Group { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UsersRulesLockedCriteriaSettingsCriteria {\n");

			sb.Append("  Operator: ").Append(Operator).Append("\n");
			sb.Append("  Group: ").Append(Group).Append("\n");
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
			return this.Equals(obj as UsersRulesLockedCriteriaSettingsCriteria);
		}

		/// <summary>
		/// Returns true if UsersRulesLockedCriteriaSettingsCriteria instances are equal
		/// </summary>
		/// <param name="other">Instance of UsersRulesLockedCriteriaSettingsCriteria to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UsersRulesLockedCriteriaSettingsCriteria other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Operator == other.Operator ||
					this.Operator != null &&
					this.Operator.Equals(other.Operator)
				) &&
				(
					this.Group == other.Group ||
					this.Group != null &&
					this.Group.SequenceEqual(other.Group)
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
				if (this.Operator != null)
					hash = hash * 59 + this.Operator.GetHashCode();

				if (this.Group != null)
					hash = hash * 59 + this.Group.GetHashCode();

				return hash;
			}
		}
	}

}
