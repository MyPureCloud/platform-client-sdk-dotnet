using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ActivityPlanResponse
    /// </summary>
    [DataContract]
    public partial class ActivityPlanResponse :  IEquatable<ActivityPlanResponse>
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
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The optimization objective of this activity plan
        /// </summary>
        /// <value>The optimization objective of this activity plan</value>
        [DataMember(Name="optimizationObjective", EmitDefaultValue=false)]
        public OptimizationObjectiveEnum? OptimizationObjective { get; set; }
        /// <summary>
        /// The state of this activity plan
        /// </summary>
        /// <value>The state of this activity plan</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityPlanResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanResponse" /> class.
        /// </summary>
        /// <param name="Name">The name of the activity plan (required).</param>
        /// <param name="ManagementUnits">The management units to which this activity plan applies. Empty list or null means this activity plan applies to the entire business unit.</param>
        /// <param name="Description">The description of this activity plan (required).</param>
        /// <param name="ActivityCode">The activity code associated with this activity plan. It is recommended to load and cache the entire list of activity codes rather than look up individual codes (required).</param>
        /// <param name="Type">The type of the activity plan (required).</param>
        /// <param name="InitialSchedulePeriod">The initial schedule period of the activity plan (required).</param>
        /// <param name="LengthMinutes">The length of the activity in minutes (required).</param>
        /// <param name="GroupSettings">Group settings for this activity plan.</param>
        /// <param name="RecurrenceSettings">Recurrence settings for this activity plan.</param>
        /// <param name="AttendeesSearchRule">Attendee search rule for this activity plan.</param>
        /// <param name="Facilitated">Whether the sessions created by this activity plan should be facilitated (required).</param>
        /// <param name="FacilitatorsSearchRule">Facilitator search rule for this activity plan.</param>
        /// <param name="TransitionTimeMinutes">Transition time in minutes between facilitated sessions (required).</param>
        /// <param name="ServiceGoalImpactOverrides">Allowable service goal impact override settings for this activity plan.</param>
        /// <param name="OptimizationObjective">The optimization objective of this activity plan (required).</param>
        /// <param name="FixedAvailability">Fixed availability configuration for this activity plan.</param>
        /// <param name="State">The state of this activity plan (required).</param>
        /// <param name="CountsAsPaidTime">Whether the activity should count as paid time (required).</param>
        /// <param name="CreatedDate">The date the activity plan was created, in ISO-8601 format (required).</param>
        /// <param name="CreatedBy">The user who created this activity plan (required).</param>
        /// <param name="ModifiedDate">The date the activity plan was modified, in ISO-8601 format (required).</param>
        /// <param name="ModifiedBy">The last user to modify this activity plan. The id may be &#39;System&#39; if it was an automated process (required).</param>
        /// <param name="LastRunDate">The date the activity plan was last run, in ISO-8601 format.</param>
        /// <param name="LastRunBy">The last user to run this activity plan.</param>
        public ActivityPlanResponse(string Name = null, List<ManagementUnitReference> ManagementUnits = null, string Description = null, ActivityCodeReference ActivityCode = null, TypeEnum? Type = null, SchedulingPeriod InitialSchedulePeriod = null, int? LengthMinutes = null, GroupSettings GroupSettings = null, RecurrenceSettings RecurrenceSettings = null, UserSearchRule AttendeesSearchRule = null, bool? Facilitated = null, UserSearchRule FacilitatorsSearchRule = null, int? TransitionTimeMinutes = null, ActivityPlanServiceGoalImpactOverrides ServiceGoalImpactOverrides = null, OptimizationObjectiveEnum? OptimizationObjective = null, List<FixedAvailability> FixedAvailability = null, StateEnum? State = null, bool? CountsAsPaidTime = null, DateTime? CreatedDate = null, UserReference CreatedBy = null, DateTime? ModifiedDate = null, UserReference ModifiedBy = null, DateTime? LastRunDate = null, UserReference LastRunBy = null)
        {
            this.Name = Name;
            this.ManagementUnits = ManagementUnits;
            this.Description = Description;
            this.ActivityCode = ActivityCode;
            this.Type = Type;
            this.InitialSchedulePeriod = InitialSchedulePeriod;
            this.LengthMinutes = LengthMinutes;
            this.GroupSettings = GroupSettings;
            this.RecurrenceSettings = RecurrenceSettings;
            this.AttendeesSearchRule = AttendeesSearchRule;
            this.Facilitated = Facilitated;
            this.FacilitatorsSearchRule = FacilitatorsSearchRule;
            this.TransitionTimeMinutes = TransitionTimeMinutes;
            this.ServiceGoalImpactOverrides = ServiceGoalImpactOverrides;
            this.OptimizationObjective = OptimizationObjective;
            this.FixedAvailability = FixedAvailability;
            this.State = State;
            this.CountsAsPaidTime = CountsAsPaidTime;
            this.CreatedDate = CreatedDate;
            this.CreatedBy = CreatedBy;
            this.ModifiedDate = ModifiedDate;
            this.ModifiedBy = ModifiedBy;
            this.LastRunDate = LastRunDate;
            this.LastRunBy = LastRunBy;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the activity plan
        /// </summary>
        /// <value>The name of the activity plan</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The management units to which this activity plan applies. Empty list or null means this activity plan applies to the entire business unit
        /// </summary>
        /// <value>The management units to which this activity plan applies. Empty list or null means this activity plan applies to the entire business unit</value>
        [DataMember(Name="managementUnits", EmitDefaultValue=false)]
        public List<ManagementUnitReference> ManagementUnits { get; set; }



        /// <summary>
        /// The description of this activity plan
        /// </summary>
        /// <value>The description of this activity plan</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The activity code associated with this activity plan. It is recommended to load and cache the entire list of activity codes rather than look up individual codes
        /// </summary>
        /// <value>The activity code associated with this activity plan. It is recommended to load and cache the entire list of activity codes rather than look up individual codes</value>
        [DataMember(Name="activityCode", EmitDefaultValue=false)]
        public ActivityCodeReference ActivityCode { get; set; }





        /// <summary>
        /// The initial schedule period of the activity plan
        /// </summary>
        /// <value>The initial schedule period of the activity plan</value>
        [DataMember(Name="initialSchedulePeriod", EmitDefaultValue=false)]
        public SchedulingPeriod InitialSchedulePeriod { get; set; }



        /// <summary>
        /// The length of the activity in minutes
        /// </summary>
        /// <value>The length of the activity in minutes</value>
        [DataMember(Name="lengthMinutes", EmitDefaultValue=false)]
        public int? LengthMinutes { get; set; }



        /// <summary>
        /// Group settings for this activity plan
        /// </summary>
        /// <value>Group settings for this activity plan</value>
        [DataMember(Name="groupSettings", EmitDefaultValue=false)]
        public GroupSettings GroupSettings { get; set; }



        /// <summary>
        /// Recurrence settings for this activity plan
        /// </summary>
        /// <value>Recurrence settings for this activity plan</value>
        [DataMember(Name="recurrenceSettings", EmitDefaultValue=false)]
        public RecurrenceSettings RecurrenceSettings { get; set; }



        /// <summary>
        /// Attendee search rule for this activity plan
        /// </summary>
        /// <value>Attendee search rule for this activity plan</value>
        [DataMember(Name="attendeesSearchRule", EmitDefaultValue=false)]
        public UserSearchRule AttendeesSearchRule { get; set; }



        /// <summary>
        /// Whether the sessions created by this activity plan should be facilitated
        /// </summary>
        /// <value>Whether the sessions created by this activity plan should be facilitated</value>
        [DataMember(Name="facilitated", EmitDefaultValue=false)]
        public bool? Facilitated { get; set; }



        /// <summary>
        /// Facilitator search rule for this activity plan
        /// </summary>
        /// <value>Facilitator search rule for this activity plan</value>
        [DataMember(Name="facilitatorsSearchRule", EmitDefaultValue=false)]
        public UserSearchRule FacilitatorsSearchRule { get; set; }



        /// <summary>
        /// Transition time in minutes between facilitated sessions
        /// </summary>
        /// <value>Transition time in minutes between facilitated sessions</value>
        [DataMember(Name="transitionTimeMinutes", EmitDefaultValue=false)]
        public int? TransitionTimeMinutes { get; set; }



        /// <summary>
        /// Allowable service goal impact override settings for this activity plan
        /// </summary>
        /// <value>Allowable service goal impact override settings for this activity plan</value>
        [DataMember(Name="serviceGoalImpactOverrides", EmitDefaultValue=false)]
        public ActivityPlanServiceGoalImpactOverrides ServiceGoalImpactOverrides { get; set; }





        /// <summary>
        /// Fixed availability configuration for this activity plan
        /// </summary>
        /// <value>Fixed availability configuration for this activity plan</value>
        [DataMember(Name="fixedAvailability", EmitDefaultValue=false)]
        public List<FixedAvailability> FixedAvailability { get; set; }





        /// <summary>
        /// Whether the activity should count as paid time
        /// </summary>
        /// <value>Whether the activity should count as paid time</value>
        [DataMember(Name="countsAsPaidTime", EmitDefaultValue=false)]
        public bool? CountsAsPaidTime { get; set; }



        /// <summary>
        /// The date the activity plan was created, in ISO-8601 format
        /// </summary>
        /// <value>The date the activity plan was created, in ISO-8601 format</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }



        /// <summary>
        /// The user who created this activity plan
        /// </summary>
        /// <value>The user who created this activity plan</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public UserReference CreatedBy { get; set; }



        /// <summary>
        /// The date the activity plan was modified, in ISO-8601 format
        /// </summary>
        /// <value>The date the activity plan was modified, in ISO-8601 format</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }



        /// <summary>
        /// The last user to modify this activity plan. The id may be &#39;System&#39; if it was an automated process
        /// </summary>
        /// <value>The last user to modify this activity plan. The id may be &#39;System&#39; if it was an automated process</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public UserReference ModifiedBy { get; set; }



        /// <summary>
        /// The date the activity plan was last run, in ISO-8601 format
        /// </summary>
        /// <value>The date the activity plan was last run, in ISO-8601 format</value>
        [DataMember(Name="lastRunDate", EmitDefaultValue=false)]
        public DateTime? LastRunDate { get; set; }



        /// <summary>
        /// The last user to run this activity plan
        /// </summary>
        /// <value>The last user to run this activity plan</value>
        [DataMember(Name="lastRunBy", EmitDefaultValue=false)]
        public UserReference LastRunBy { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityPlanResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ManagementUnits: ").Append(ManagementUnits).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ActivityCode: ").Append(ActivityCode).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  InitialSchedulePeriod: ").Append(InitialSchedulePeriod).Append("\n");
            sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
            sb.Append("  GroupSettings: ").Append(GroupSettings).Append("\n");
            sb.Append("  RecurrenceSettings: ").Append(RecurrenceSettings).Append("\n");
            sb.Append("  AttendeesSearchRule: ").Append(AttendeesSearchRule).Append("\n");
            sb.Append("  Facilitated: ").Append(Facilitated).Append("\n");
            sb.Append("  FacilitatorsSearchRule: ").Append(FacilitatorsSearchRule).Append("\n");
            sb.Append("  TransitionTimeMinutes: ").Append(TransitionTimeMinutes).Append("\n");
            sb.Append("  ServiceGoalImpactOverrides: ").Append(ServiceGoalImpactOverrides).Append("\n");
            sb.Append("  OptimizationObjective: ").Append(OptimizationObjective).Append("\n");
            sb.Append("  FixedAvailability: ").Append(FixedAvailability).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CountsAsPaidTime: ").Append(CountsAsPaidTime).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  LastRunDate: ").Append(LastRunDate).Append("\n");
            sb.Append("  LastRunBy: ").Append(LastRunBy).Append("\n");
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
            return this.Equals(obj as ActivityPlanResponse);
        }

        /// <summary>
        /// Returns true if ActivityPlanResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityPlanResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityPlanResponse other)
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
                    this.InitialSchedulePeriod == other.InitialSchedulePeriod ||
                    this.InitialSchedulePeriod != null &&
                    this.InitialSchedulePeriod.Equals(other.InitialSchedulePeriod)
                ) &&
                (
                    this.LengthMinutes == other.LengthMinutes ||
                    this.LengthMinutes != null &&
                    this.LengthMinutes.Equals(other.LengthMinutes)
                ) &&
                (
                    this.GroupSettings == other.GroupSettings ||
                    this.GroupSettings != null &&
                    this.GroupSettings.Equals(other.GroupSettings)
                ) &&
                (
                    this.RecurrenceSettings == other.RecurrenceSettings ||
                    this.RecurrenceSettings != null &&
                    this.RecurrenceSettings.Equals(other.RecurrenceSettings)
                ) &&
                (
                    this.AttendeesSearchRule == other.AttendeesSearchRule ||
                    this.AttendeesSearchRule != null &&
                    this.AttendeesSearchRule.Equals(other.AttendeesSearchRule)
                ) &&
                (
                    this.Facilitated == other.Facilitated ||
                    this.Facilitated != null &&
                    this.Facilitated.Equals(other.Facilitated)
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
                    this.FixedAvailability == other.FixedAvailability ||
                    this.FixedAvailability != null &&
                    this.FixedAvailability.SequenceEqual(other.FixedAvailability)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.CountsAsPaidTime == other.CountsAsPaidTime ||
                    this.CountsAsPaidTime != null &&
                    this.CountsAsPaidTime.Equals(other.CountsAsPaidTime)
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

                if (this.InitialSchedulePeriod != null)
                    hash = hash * 59 + this.InitialSchedulePeriod.GetHashCode();

                if (this.LengthMinutes != null)
                    hash = hash * 59 + this.LengthMinutes.GetHashCode();

                if (this.GroupSettings != null)
                    hash = hash * 59 + this.GroupSettings.GetHashCode();

                if (this.RecurrenceSettings != null)
                    hash = hash * 59 + this.RecurrenceSettings.GetHashCode();

                if (this.AttendeesSearchRule != null)
                    hash = hash * 59 + this.AttendeesSearchRule.GetHashCode();

                if (this.Facilitated != null)
                    hash = hash * 59 + this.Facilitated.GetHashCode();

                if (this.FacilitatorsSearchRule != null)
                    hash = hash * 59 + this.FacilitatorsSearchRule.GetHashCode();

                if (this.TransitionTimeMinutes != null)
                    hash = hash * 59 + this.TransitionTimeMinutes.GetHashCode();

                if (this.ServiceGoalImpactOverrides != null)
                    hash = hash * 59 + this.ServiceGoalImpactOverrides.GetHashCode();

                if (this.OptimizationObjective != null)
                    hash = hash * 59 + this.OptimizationObjective.GetHashCode();

                if (this.FixedAvailability != null)
                    hash = hash * 59 + this.FixedAvailability.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.CountsAsPaidTime != null)
                    hash = hash * 59 + this.CountsAsPaidTime.GetHashCode();

                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.LastRunDate != null)
                    hash = hash * 59 + this.LastRunDate.GetHashCode();

                if (this.LastRunBy != null)
                    hash = hash * 59 + this.LastRunBy.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
