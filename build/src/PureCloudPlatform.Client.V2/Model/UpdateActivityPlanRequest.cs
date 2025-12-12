using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UpdateActivityPlanRequest
	/// </summary>
	[DataContract]
	public partial class UpdateActivityPlanRequest : IEquatable<UpdateActivityPlanRequest>
	{
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
		/// Initializes a new instance of the <see cref="UpdateActivityPlanRequest" /> class.
		/// </summary>
		/// <param name="Name">The name of the activity plan.</param>
		/// <param name="Description">The description of the activity plan.</param>
		/// <param name="GroupSettings">Group settings for the activity plan.</param>
		/// <param name="AttendeesSearchRule">Attendee search rule for this activity plan.</param>
		/// <param name="FacilitatorsSearchRule">Facilitator search rule for this activity plan.</param>
		/// <param name="TransitionTimeMinutes">Transition time in minutes between facilitated sessions.</param>
		/// <param name="ServiceGoalImpactOverrides">Allowable service goal impact override settings for this activity plan.</param>
		/// <param name="OptimizationObjective">The optimization objective of this activity plan.</param>
		/// <param name="State">The state of this activity plan.</param>
		/// <param name="FixedAvailability">Fixed availability configuration for the activity plan.</param>
		public UpdateActivityPlanRequest(string Name = null, string Description = null, ValueWrapperGroupSettings GroupSettings = null, ValueWrapperUserSearchRule AttendeesSearchRule = null, ValueWrapperUserSearchRule FacilitatorsSearchRule = null, int? TransitionTimeMinutes = null, ValueWrapperActivityPlanServiceGoalImpactOverrides ServiceGoalImpactOverrides = null, OptimizationObjectiveEnum? OptimizationObjective = null, StateEnum? State = null, ListWrapperFixedAvailability FixedAvailability = null)
		{
			this.Name = Name;
			this.Description = Description;
			this.GroupSettings = GroupSettings;
			this.AttendeesSearchRule = AttendeesSearchRule;
			this.FacilitatorsSearchRule = FacilitatorsSearchRule;
			this.TransitionTimeMinutes = TransitionTimeMinutes;
			this.ServiceGoalImpactOverrides = ServiceGoalImpactOverrides;
			this.OptimizationObjective = OptimizationObjective;
			this.State = State;
			this.FixedAvailability = FixedAvailability;

		}



		/// <summary>
		/// The name of the activity plan
		/// </summary>
		/// <value>The name of the activity plan</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The description of the activity plan
		/// </summary>
		/// <value>The description of the activity plan</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// Group settings for the activity plan
		/// </summary>
		/// <value>Group settings for the activity plan</value>
		[DataMember(Name = "groupSettings", EmitDefaultValue = false)]
		public ValueWrapperGroupSettings GroupSettings { get; set; }



		/// <summary>
		/// Attendee search rule for this activity plan
		/// </summary>
		/// <value>Attendee search rule for this activity plan</value>
		[DataMember(Name = "attendeesSearchRule", EmitDefaultValue = false)]
		public ValueWrapperUserSearchRule AttendeesSearchRule { get; set; }



		/// <summary>
		/// Facilitator search rule for this activity plan
		/// </summary>
		/// <value>Facilitator search rule for this activity plan</value>
		[DataMember(Name = "facilitatorsSearchRule", EmitDefaultValue = false)]
		public ValueWrapperUserSearchRule FacilitatorsSearchRule { get; set; }



		/// <summary>
		/// Transition time in minutes between facilitated sessions
		/// </summary>
		/// <value>Transition time in minutes between facilitated sessions</value>
		[DataMember(Name = "transitionTimeMinutes", EmitDefaultValue = false)]
		public int? TransitionTimeMinutes { get; set; }



		/// <summary>
		/// Allowable service goal impact override settings for this activity plan
		/// </summary>
		/// <value>Allowable service goal impact override settings for this activity plan</value>
		[DataMember(Name = "serviceGoalImpactOverrides", EmitDefaultValue = false)]
		public ValueWrapperActivityPlanServiceGoalImpactOverrides ServiceGoalImpactOverrides { get; set; }







		/// <summary>
		/// Fixed availability configuration for the activity plan
		/// </summary>
		/// <value>Fixed availability configuration for the activity plan</value>
		[DataMember(Name = "fixedAvailability", EmitDefaultValue = false)]
		public ListWrapperFixedAvailability FixedAvailability { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateActivityPlanRequest {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  GroupSettings: ").Append(GroupSettings).Append("\n");
			sb.Append("  AttendeesSearchRule: ").Append(AttendeesSearchRule).Append("\n");
			sb.Append("  FacilitatorsSearchRule: ").Append(FacilitatorsSearchRule).Append("\n");
			sb.Append("  TransitionTimeMinutes: ").Append(TransitionTimeMinutes).Append("\n");
			sb.Append("  ServiceGoalImpactOverrides: ").Append(ServiceGoalImpactOverrides).Append("\n");
			sb.Append("  OptimizationObjective: ").Append(OptimizationObjective).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  FixedAvailability: ").Append(FixedAvailability).Append("\n");
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
			return this.Equals(obj as UpdateActivityPlanRequest);
		}

		/// <summary>
		/// Returns true if UpdateActivityPlanRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of UpdateActivityPlanRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UpdateActivityPlanRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
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
					this.GroupSettings == other.GroupSettings ||
					this.GroupSettings != null &&
					this.GroupSettings.Equals(other.GroupSettings)
				) &&
				(
					this.AttendeesSearchRule == other.AttendeesSearchRule ||
					this.AttendeesSearchRule != null &&
					this.AttendeesSearchRule.Equals(other.AttendeesSearchRule)
				) &&
				(
					this.FacilitatorsSearchRule == other.FacilitatorsSearchRule ||
					this.FacilitatorsSearchRule != null &&
					this.FacilitatorsSearchRule.Equals(other.FacilitatorsSearchRule)
				) &&
				(
					this.TransitionTimeMinutes == other.TransitionTimeMinutes ||
					this.TransitionTimeMinutes != null &&
					this.TransitionTimeMinutes.Equals(other.TransitionTimeMinutes)
				) &&
				(
					this.ServiceGoalImpactOverrides == other.ServiceGoalImpactOverrides ||
					this.ServiceGoalImpactOverrides != null &&
					this.ServiceGoalImpactOverrides.Equals(other.ServiceGoalImpactOverrides)
				) &&
				(
					this.OptimizationObjective == other.OptimizationObjective ||
					this.OptimizationObjective != null &&
					this.OptimizationObjective.Equals(other.OptimizationObjective)
				) &&
				(
					this.State == other.State ||
					this.State != null &&
					this.State.Equals(other.State)
				) &&
				(
					this.FixedAvailability == other.FixedAvailability ||
					this.FixedAvailability != null &&
					this.FixedAvailability.Equals(other.FixedAvailability)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.GroupSettings != null)
					hash = hash * 59 + this.GroupSettings.GetHashCode();

				if (this.AttendeesSearchRule != null)
					hash = hash * 59 + this.AttendeesSearchRule.GetHashCode();

				if (this.FacilitatorsSearchRule != null)
					hash = hash * 59 + this.FacilitatorsSearchRule.GetHashCode();

				if (this.TransitionTimeMinutes != null)
					hash = hash * 59 + this.TransitionTimeMinutes.GetHashCode();

				if (this.ServiceGoalImpactOverrides != null)
					hash = hash * 59 + this.ServiceGoalImpactOverrides.GetHashCode();

				if (this.OptimizationObjective != null)
					hash = hash * 59 + this.OptimizationObjective.GetHashCode();

				if (this.State != null)
					hash = hash * 59 + this.State.GetHashCode();

				if (this.FixedAvailability != null)
					hash = hash * 59 + this.FixedAvailability.GetHashCode();

				return hash;
			}
		}
	}

}
