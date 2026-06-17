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
    /// AdminAgentScheduleBidBiddingPreference
    /// </summary>
    [DataContract]
    public partial class AdminAgentScheduleBidBiddingPreference :  IEquatable<AdminAgentScheduleBidBiddingPreference>
    {
        /// <summary>
        /// The reason the assigned schedule set has been overridden. This must be null if no override schedule is set
        /// </summary>
        /// <value>The reason the assigned schedule set has been overridden. This must be null if no override schedule is set</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OverrideReasonEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unabletobid for "UnableToBid"
            /// </summary>
            [EnumMember(Value = "UnableToBid")]
            Unabletobid,
            
            /// <summary>
            /// Enum Changeofcircumstance for "ChangeOfCircumstance"
            /// </summary>
            [EnumMember(Value = "ChangeOfCircumstance")]
            Changeofcircumstance,
            
            /// <summary>
            /// Enum Newhire for "NewHire"
            /// </summary>
            [EnumMember(Value = "NewHire")]
            Newhire,
            
            /// <summary>
            /// Enum Employeemove for "EmployeeMove"
            /// </summary>
            [EnumMember(Value = "EmployeeMove")]
            Employeemove
        }
        /// <summary>
        /// The reason the assigned schedule set has been overridden. This must be null if no override schedule is set
        /// </summary>
        /// <value>The reason the assigned schedule set has been overridden. This must be null if no override schedule is set</value>
        [DataMember(Name="overrideReason", EmitDefaultValue=false)]
        public OverrideReasonEnum? OverrideReason { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAgentScheduleBidBiddingPreference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdminAgentScheduleBidBiddingPreference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAgentScheduleBidBiddingPreference" /> class.
        /// </summary>
        /// <param name="Agent">The agent to whom this schedule bid preference applies (required).</param>
        /// <param name="Submitted">Indicates whether the preference has been submitted (required).</param>
        /// <param name="AssignedScheduleSetId">The schedule set assigned to the agent by the bid process. This will be set after bid is processed.</param>
        /// <param name="OverriddenScheduleSetId">The schedule set that overrides the assigned schedule set for the agent.</param>
        /// <param name="OverrideReason">The reason the assigned schedule set has been overridden. This must be null if no override schedule is set.</param>
        /// <param name="AgentScheduleBidPreferencePriorities">The agent schedule set preferences (required).</param>
        /// <param name="EndDate">The end date of this scheduling set preference relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        public AdminAgentScheduleBidBiddingPreference(UserReference Agent = null, bool? Submitted = null, string AssignedScheduleSetId = null, string OverriddenScheduleSetId = null, OverrideReasonEnum? OverrideReason = null, List<AgentScheduleBiddingPreferencePriority> AgentScheduleBidPreferencePriorities = null, String EndDate = null)
        {
            this.Agent = Agent;
            this.Submitted = Submitted;
            this.AssignedScheduleSetId = AssignedScheduleSetId;
            this.OverriddenScheduleSetId = OverriddenScheduleSetId;
            this.OverrideReason = OverrideReason;
            this.AgentScheduleBidPreferencePriorities = AgentScheduleBidPreferencePriorities;
            this.EndDate = EndDate;
            
        }
        


        /// <summary>
        /// The agent to whom this schedule bid preference applies
        /// </summary>
        /// <value>The agent to whom this schedule bid preference applies</value>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public UserReference Agent { get; set; }



        /// <summary>
        /// Indicates whether the preference has been submitted
        /// </summary>
        /// <value>Indicates whether the preference has been submitted</value>
        [DataMember(Name="submitted", EmitDefaultValue=false)]
        public bool? Submitted { get; set; }



        /// <summary>
        /// The schedule set assigned to the agent by the bid process. This will be set after bid is processed
        /// </summary>
        /// <value>The schedule set assigned to the agent by the bid process. This will be set after bid is processed</value>
        [DataMember(Name="assignedScheduleSetId", EmitDefaultValue=false)]
        public string AssignedScheduleSetId { get; set; }



        /// <summary>
        /// The schedule set that overrides the assigned schedule set for the agent
        /// </summary>
        /// <value>The schedule set that overrides the assigned schedule set for the agent</value>
        [DataMember(Name="overriddenScheduleSetId", EmitDefaultValue=false)]
        public string OverriddenScheduleSetId { get; set; }





        /// <summary>
        /// The agent schedule set preferences
        /// </summary>
        /// <value>The agent schedule set preferences</value>
        [DataMember(Name="agentScheduleBidPreferencePriorities", EmitDefaultValue=false)]
        public List<AgentScheduleBiddingPreferencePriority> AgentScheduleBidPreferencePriorities { get; set; }



        /// <summary>
        /// The end date of this scheduling set preference relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The end date of this scheduling set preference relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public String EndDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdminAgentScheduleBidBiddingPreference {\n");

            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  Submitted: ").Append(Submitted).Append("\n");
            sb.Append("  AssignedScheduleSetId: ").Append(AssignedScheduleSetId).Append("\n");
            sb.Append("  OverriddenScheduleSetId: ").Append(OverriddenScheduleSetId).Append("\n");
            sb.Append("  OverrideReason: ").Append(OverrideReason).Append("\n");
            sb.Append("  AgentScheduleBidPreferencePriorities: ").Append(AgentScheduleBidPreferencePriorities).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(obj as AdminAgentScheduleBidBiddingPreference);
        }

        /// <summary>
        /// Returns true if AdminAgentScheduleBidBiddingPreference instances are equal
        /// </summary>
        /// <param name="other">Instance of AdminAgentScheduleBidBiddingPreference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdminAgentScheduleBidBiddingPreference other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Agent == other.Agent ||
                    this.Agent != null &&
                    this.Agent.Equals(other.Agent)
                ) &&
                (
                    this.Submitted == other.Submitted ||
                    this.Submitted != null &&
                    this.Submitted.Equals(other.Submitted)
                ) &&
                (
                    this.AssignedScheduleSetId == other.AssignedScheduleSetId ||
                    this.AssignedScheduleSetId != null &&
                    this.AssignedScheduleSetId.Equals(other.AssignedScheduleSetId)
                ) &&
                (
                    this.OverriddenScheduleSetId == other.OverriddenScheduleSetId ||
                    this.OverriddenScheduleSetId != null &&
                    this.OverriddenScheduleSetId.Equals(other.OverriddenScheduleSetId)
                ) &&
                (
                    this.OverrideReason == other.OverrideReason ||
                    this.OverrideReason != null &&
                    this.OverrideReason.Equals(other.OverrideReason)
                ) &&
                (
                    this.AgentScheduleBidPreferencePriorities == other.AgentScheduleBidPreferencePriorities ||
                    this.AgentScheduleBidPreferencePriorities != null &&
                    this.AgentScheduleBidPreferencePriorities.SequenceEqual(other.AgentScheduleBidPreferencePriorities)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
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
                if (this.Agent != null)
                    hash = hash * 59 + this.Agent.GetHashCode();

                if (this.Submitted != null)
                    hash = hash * 59 + this.Submitted.GetHashCode();

                if (this.AssignedScheduleSetId != null)
                    hash = hash * 59 + this.AssignedScheduleSetId.GetHashCode();

                if (this.OverriddenScheduleSetId != null)
                    hash = hash * 59 + this.OverriddenScheduleSetId.GetHashCode();

                if (this.OverrideReason != null)
                    hash = hash * 59 + this.OverrideReason.GetHashCode();

                if (this.AgentScheduleBidPreferencePriorities != null)
                    hash = hash * 59 + this.AgentScheduleBidPreferencePriorities.GetHashCode();

                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();

                return hash;
            }
        }
    }

}
