using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Users rule type-specific settings response
	/// </summary>
	[DataContract]
	public partial class UsersRulesRuleSettings : IEquatable<UsersRulesRuleSettings>
	{
		/// <summary>
		/// Gets or Sets AllowedContainers
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum AllowedContainersEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Acdskill for "AcdSkill"
			/// </summary>
			[EnumMember(Value = "AcdSkill")]
			Acdskill,

			/// <summary>
			/// Enum Businessunit for "BusinessUnit"
			/// </summary>
			[EnumMember(Value = "BusinessUnit")]
			Businessunit,

			/// <summary>
			/// Enum Directorygroup for "DirectoryGroup"
			/// </summary>
			[EnumMember(Value = "DirectoryGroup")]
			Directorygroup,

			/// <summary>
			/// Enum Division for "Division"
			/// </summary>
			[EnumMember(Value = "Division")]
			Division,

			/// <summary>
			/// Enum Language for "Language"
			/// </summary>
			[EnumMember(Value = "Language")]
			Language,

			/// <summary>
			/// Enum Location for "Location"
			/// </summary>
			[EnumMember(Value = "Location")]
			Location,

			/// <summary>
			/// Enum Managementunit for "ManagementUnit"
			/// </summary>
			[EnumMember(Value = "ManagementUnit")]
			Managementunit,

			/// <summary>
			/// Enum Queue for "Queue"
			/// </summary>
			[EnumMember(Value = "Queue")]
			Queue,

			/// <summary>
			/// Enum Reportsto for "ReportsTo"
			/// </summary>
			[EnumMember(Value = "ReportsTo")]
			Reportsto,

			/// <summary>
			/// Enum Staffinggroup for "StaffingGroup"
			/// </summary>
			[EnumMember(Value = "StaffingGroup")]
			Staffinggroup,

			/// <summary>
			/// Enum Team for "Team"
			/// </summary>
			[EnumMember(Value = "Team")]
			Team,

			/// <summary>
			/// Enum User for "User"
			/// </summary>
			[EnumMember(Value = "User")]
			User
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="UsersRulesRuleSettings" /> class.
		/// </summary>
		public UsersRulesRuleSettings()
		{

		}



		/// <summary>
		/// The allowed containers for the rule
		/// </summary>
		/// <value>The allowed containers for the rule</value>
		[DataMember(Name = "allowedContainers", EmitDefaultValue = false)]
		public List<AllowedContainersEnum> AllowedContainers { get; private set; }



		/// <summary>
		/// The locked criteria settings for the rule
		/// </summary>
		/// <value>The locked criteria settings for the rule</value>
		[DataMember(Name = "lockedCriteria", EmitDefaultValue = false)]
		public List<UsersRulesLockedCriteriaSettingsCriteria> LockedCriteria { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UsersRulesRuleSettings {\n");

			sb.Append("  AllowedContainers: ").Append(AllowedContainers).Append("\n");
			sb.Append("  LockedCriteria: ").Append(LockedCriteria).Append("\n");
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
			return this.Equals(obj as UsersRulesRuleSettings);
		}

		/// <summary>
		/// Returns true if UsersRulesRuleSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of UsersRulesRuleSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UsersRulesRuleSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.AllowedContainers == other.AllowedContainers ||
					this.AllowedContainers != null &&
					this.AllowedContainers.SequenceEqual(other.AllowedContainers)
				) &&
				(
					this.LockedCriteria == other.LockedCriteria ||
					this.LockedCriteria != null &&
					this.LockedCriteria.SequenceEqual(other.LockedCriteria)
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
				if (this.AllowedContainers != null)
					hash = hash * 59 + this.AllowedContainers.GetHashCode();

				if (this.LockedCriteria != null)
					hash = hash * 59 + this.LockedCriteria.GetHashCode();

				return hash;
			}
		}
	}

}
