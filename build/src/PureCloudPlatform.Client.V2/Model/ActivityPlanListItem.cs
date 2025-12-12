using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ActivityPlanListItem
	/// </summary>
	[DataContract]
	public partial class ActivityPlanListItem : IEquatable<ActivityPlanListItem>
	{
		/// <summary>
		/// The type of the activity plan
		/// </summary>
		/// <value>The type of the activity plan</value>
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
			/// Enum Individual for "Individual"
			/// </summary>
			[EnumMember(Value = "Individual")]
			Individual,

			/// <summary>
			/// Enum Group for "Group"
			/// </summary>
			[EnumMember(Value = "Group")]
			Group
		}
		/// <summary>
		/// The optimization objective of this activity plan
		/// </summary>
		/// <value>The optimization objective of this activity plan</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum OptimizationObjectiveEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Favorservicegoals for "FavorServiceGoals"
			/// </summary>
			[EnumMember(Value = "FavorServiceGoals")]
			Favorservicegoals,

			/// <summary>
			/// Enum Favorschedulingall for "FavorSchedulingAll"
			/// </summary>
			[EnumMember(Value = "FavorSchedulingAll")]
			Favorschedulingall
		}
		/// <summary>
		/// The state of this activity plan
		/// </summary>
		/// <value>The state of this activity plan</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StateEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Active for "Active"
			/// </summary>
			[EnumMember(Value = "Active")]
			Active,

			/// <summary>
			/// Enum Inactive for "Inactive"
			/// </summary>
			[EnumMember(Value = "Inactive")]
			Inactive
		}
		/// <summary>
		/// The type of the activity plan
		/// </summary>
		/// <value>The type of the activity plan</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// The optimization objective of this activity plan
		/// </summary>
		/// <value>The optimization objective of this activity plan</value>
		[DataMember(Name = "optimizationObjective", EmitDefaultValue = false)]
		public OptimizationObjectiveEnum? OptimizationObjective { get; set; }
		/// <summary>
		/// The state of this activity plan
		/// </summary>
		/// <value>The state of this activity plan</value>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public StateEnum? State { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ActivityPlanListItem" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ActivityPlanListItem() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ActivityPlanListItem" /> class.
		/// </summary>
		/// <param name="Name">The name of the activity plan (required).</param>
		/// <param name="ManagementUnits">The management units to which this activity plan applies. Empty list or null means this activity plan applies to all management units in the business unit.</param>
		/// <param name="Description">The description of this activity plan (required).</param>
		/// <param name="ActivityCode">The activity code to which this activity plan applies. Note: It is recommended to load and cache the entire list of activity codes rather than look up individual codes (required).</param>
		/// <param name="Type">The type of the activity plan (required).</param>
		/// <param name="OptimizationObjective">The optimization objective of this activity plan (required).</param>
		/// <param name="RecurrenceSettings">Recurrence settings for this activity plan.</param>
		/// <param name="State">The state of this activity plan (required).</param>
		/// <param name="LastRunDate">The date on which the activity plan was last manually run, in ISO-8601 format.</param>
		/// <param name="LastRunBy">The last user to run this activity plan.</param>
		/// <param name="CreatedDate">The date the activity plan was created, in ISO-8601 format (required).</param>
		/// <param name="CreatedBy">The user who created this activity plan (required).</param>
		/// <param name="ModifiedDate">The date the activity plan was modified, in ISO-8601 format (required).</param>
		/// <param name="ModifiedBy">The last user to modify this activity plan. The id may be &#39;System&#39; if it was an automated process (required).</param>
		public ActivityPlanListItem(string Name = null, List<ManagementUnitReference> ManagementUnits = null, string Description = null, ActivityCodeReference ActivityCode = null, TypeEnum? Type = null, OptimizationObjectiveEnum? OptimizationObjective = null, RecurrenceSettings RecurrenceSettings = null, StateEnum? State = null, DateTime? LastRunDate = null, UserReference LastRunBy = null, DateTime? CreatedDate = null, UserReference CreatedBy = null, DateTime? ModifiedDate = null, UserReference ModifiedBy = null)
		{
			this.Name = Name;
			this.ManagementUnits = ManagementUnits;
			this.Description = Description;
			this.ActivityCode = ActivityCode;
			this.Type = Type;
			this.OptimizationObjective = OptimizationObjective;
			this.RecurrenceSettings = RecurrenceSettings;
			this.State = State;
			this.LastRunDate = LastRunDate;
			this.LastRunBy = LastRunBy;
			this.CreatedDate = CreatedDate;
			this.CreatedBy = CreatedBy;
			this.ModifiedDate = ModifiedDate;
			this.ModifiedBy = ModifiedBy;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The name of the activity plan
		/// </summary>
		/// <value>The name of the activity plan</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The management units to which this activity plan applies. Empty list or null means this activity plan applies to all management units in the business unit
		/// </summary>
		/// <value>The management units to which this activity plan applies. Empty list or null means this activity plan applies to all management units in the business unit</value>
		[DataMember(Name = "managementUnits", EmitDefaultValue = false)]
		public List<ManagementUnitReference> ManagementUnits { get; set; }



		/// <summary>
		/// The description of this activity plan
		/// </summary>
		/// <value>The description of this activity plan</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// The activity code to which this activity plan applies. Note: It is recommended to load and cache the entire list of activity codes rather than look up individual codes
		/// </summary>
		/// <value>The activity code to which this activity plan applies. Note: It is recommended to load and cache the entire list of activity codes rather than look up individual codes</value>
		[DataMember(Name = "activityCode", EmitDefaultValue = false)]
		public ActivityCodeReference ActivityCode { get; set; }







		/// <summary>
		/// Recurrence settings for this activity plan
		/// </summary>
		/// <value>Recurrence settings for this activity plan</value>
		[DataMember(Name = "recurrenceSettings", EmitDefaultValue = false)]
		public RecurrenceSettings RecurrenceSettings { get; set; }





		/// <summary>
		/// The date on which the activity plan was last manually run, in ISO-8601 format
		/// </summary>
		/// <value>The date on which the activity plan was last manually run, in ISO-8601 format</value>
		[DataMember(Name = "lastRunDate", EmitDefaultValue = false)]
		public DateTime? LastRunDate { get; set; }



		/// <summary>
		/// The last user to run this activity plan
		/// </summary>
		/// <value>The last user to run this activity plan</value>
		[DataMember(Name = "lastRunBy", EmitDefaultValue = false)]
		public UserReference LastRunBy { get; set; }



		/// <summary>
		/// The date the activity plan was created, in ISO-8601 format
		/// </summary>
		/// <value>The date the activity plan was created, in ISO-8601 format</value>
		[DataMember(Name = "createdDate", EmitDefaultValue = false)]
		public DateTime? CreatedDate { get; set; }



		/// <summary>
		/// The user who created this activity plan
		/// </summary>
		/// <value>The user who created this activity plan</value>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public UserReference CreatedBy { get; set; }



		/// <summary>
		/// The date the activity plan was modified, in ISO-8601 format
		/// </summary>
		/// <value>The date the activity plan was modified, in ISO-8601 format</value>
		[DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
		public DateTime? ModifiedDate { get; set; }



		/// <summary>
		/// The last user to modify this activity plan. The id may be &#39;System&#39; if it was an automated process
		/// </summary>
		/// <value>The last user to modify this activity plan. The id may be &#39;System&#39; if it was an automated process</value>
		[DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
		public UserReference ModifiedBy { get; set; }



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
			sb.Append("class ActivityPlanListItem {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  ManagementUnits: ").Append(ManagementUnits).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  ActivityCode: ").Append(ActivityCode).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  OptimizationObjective: ").Append(OptimizationObjective).Append("\n");
			sb.Append("  RecurrenceSettings: ").Append(RecurrenceSettings).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  LastRunDate: ").Append(LastRunDate).Append("\n");
			sb.Append("  LastRunBy: ").Append(LastRunBy).Append("\n");
			sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
			sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
			sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
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
			return this.Equals(obj as ActivityPlanListItem);
		}

		/// <summary>
		/// Returns true if ActivityPlanListItem instances are equal
		/// </summary>
		/// <param name="other">Instance of ActivityPlanListItem to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ActivityPlanListItem other)
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
					this.ManagementUnits == other.ManagementUnits ||
					this.ManagementUnits != null &&
					this.ManagementUnits.SequenceEqual(other.ManagementUnits)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.ActivityCode == other.ActivityCode ||
					this.ActivityCode != null &&
					this.ActivityCode.Equals(other.ActivityCode)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.OptimizationObjective == other.OptimizationObjective ||
					this.OptimizationObjective != null &&
					this.OptimizationObjective.Equals(other.OptimizationObjective)
				) &&
				(
					this.RecurrenceSettings == other.RecurrenceSettings ||
					this.RecurrenceSettings != null &&
					this.RecurrenceSettings.Equals(other.RecurrenceSettings)
				) &&
				(
					this.State == other.State ||
					this.State != null &&
					this.State.Equals(other.State)
				) &&
				(
					this.LastRunDate == other.LastRunDate ||
					this.LastRunDate != null &&
					this.LastRunDate.Equals(other.LastRunDate)
				) &&
				(
					this.LastRunBy == other.LastRunBy ||
					this.LastRunBy != null &&
					this.LastRunBy.Equals(other.LastRunBy)
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

				if (this.ManagementUnits != null)
					hash = hash * 59 + this.ManagementUnits.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.ActivityCode != null)
					hash = hash * 59 + this.ActivityCode.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.OptimizationObjective != null)
					hash = hash * 59 + this.OptimizationObjective.GetHashCode();

				if (this.RecurrenceSettings != null)
					hash = hash * 59 + this.RecurrenceSettings.GetHashCode();

				if (this.State != null)
					hash = hash * 59 + this.State.GetHashCode();

				if (this.LastRunDate != null)
					hash = hash * 59 + this.LastRunDate.GetHashCode();

				if (this.LastRunBy != null)
					hash = hash * 59 + this.LastRunBy.GetHashCode();

				if (this.CreatedDate != null)
					hash = hash * 59 + this.CreatedDate.GetHashCode();

				if (this.CreatedBy != null)
					hash = hash * 59 + this.CreatedBy.GetHashCode();

				if (this.ModifiedDate != null)
					hash = hash * 59 + this.ModifiedDate.GetHashCode();

				if (this.ModifiedBy != null)
					hash = hash * 59 + this.ModifiedBy.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
