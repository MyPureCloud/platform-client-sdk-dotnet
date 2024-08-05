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
    /// AdminAgentWorkPlanBiddingPreference
    /// </summary>
    [DataContract]
    public partial class AdminAgentWorkPlanBiddingPreference :  IEquatable<AdminAgentWorkPlanBiddingPreference>
    {
        /// <summary>
        /// The reason why the assigned work plan has been overridden. This must be null without an override work plan
        /// </summary>
        /// <value>The reason why the assigned work plan has been overridden. This must be null without an override work plan</value>
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
        /// The reason why the assigned work plan has been overridden. This must be null without an override work plan
        /// </summary>
        /// <value>The reason why the assigned work plan has been overridden. This must be null without an override work plan</value>
        [DataMember(Name="overrideReason", EmitDefaultValue=false)]
        public OverrideReasonEnum? OverrideReason { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAgentWorkPlanBiddingPreference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdminAgentWorkPlanBiddingPreference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAgentWorkPlanBiddingPreference" /> class.
        /// </summary>
        /// <param name="Agent">The agent to whom this work plan bidding preference applies (required).</param>
        /// <param name="Submitted">Whether the preference is submitted (required).</param>
        /// <param name="AssignedWorkPlan">The work plan assigned to the agent by the bid process.</param>
        /// <param name="OverriddenWorkPlan">The work plan that overrides the assigned work plan for the agent.</param>
        /// <param name="OverrideReason">The reason why the assigned work plan has been overridden. This must be null without an override work plan.</param>
        /// <param name="Priorities">The agent priorities for the list of work plans. The index of the priorities should match with the list of work plans that belong to bid group. It contains null if priority is not set for the work plan.</param>
        public AdminAgentWorkPlanBiddingPreference(UserReference Agent = null, bool? Submitted = null, WorkPlanReference AssignedWorkPlan = null, WorkPlanReference OverriddenWorkPlan = null, OverrideReasonEnum? OverrideReason = null, List<int?> Priorities = null)
        {
            this.Agent = Agent;
            this.Submitted = Submitted;
            this.AssignedWorkPlan = AssignedWorkPlan;
            this.OverriddenWorkPlan = OverriddenWorkPlan;
            this.OverrideReason = OverrideReason;
            this.Priorities = Priorities;
            
        }
        


        /// <summary>
        /// The agent to whom this work plan bidding preference applies
        /// </summary>
        /// <value>The agent to whom this work plan bidding preference applies</value>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public UserReference Agent { get; set; }



        /// <summary>
        /// Whether the preference is submitted
        /// </summary>
        /// <value>Whether the preference is submitted</value>
        [DataMember(Name="submitted", EmitDefaultValue=false)]
        public bool? Submitted { get; set; }



        /// <summary>
        /// The work plan assigned to the agent by the bid process
        /// </summary>
        /// <value>The work plan assigned to the agent by the bid process</value>
        [DataMember(Name="assignedWorkPlan", EmitDefaultValue=false)]
        public WorkPlanReference AssignedWorkPlan { get; set; }



        /// <summary>
        /// The work plan that overrides the assigned work plan for the agent
        /// </summary>
        /// <value>The work plan that overrides the assigned work plan for the agent</value>
        [DataMember(Name="overriddenWorkPlan", EmitDefaultValue=false)]
        public WorkPlanReference OverriddenWorkPlan { get; set; }





        /// <summary>
        /// The agent priorities for the list of work plans. The index of the priorities should match with the list of work plans that belong to bid group. It contains null if priority is not set for the work plan
        /// </summary>
        /// <value>The agent priorities for the list of work plans. The index of the priorities should match with the list of work plans that belong to bid group. It contains null if priority is not set for the work plan</value>
        [DataMember(Name="priorities", EmitDefaultValue=false)]
        public List<int?> Priorities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdminAgentWorkPlanBiddingPreference {\n");

            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  Submitted: ").Append(Submitted).Append("\n");
            sb.Append("  AssignedWorkPlan: ").Append(AssignedWorkPlan).Append("\n");
            sb.Append("  OverriddenWorkPlan: ").Append(OverriddenWorkPlan).Append("\n");
            sb.Append("  OverrideReason: ").Append(OverrideReason).Append("\n");
            sb.Append("  Priorities: ").Append(Priorities).Append("\n");
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
            return this.Equals(obj as AdminAgentWorkPlanBiddingPreference);
        }

        /// <summary>
        /// Returns true if AdminAgentWorkPlanBiddingPreference instances are equal
        /// </summary>
        /// <param name="other">Instance of AdminAgentWorkPlanBiddingPreference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdminAgentWorkPlanBiddingPreference other)
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
                    this.AssignedWorkPlan == other.AssignedWorkPlan ||
                    this.AssignedWorkPlan != null &&
                    this.AssignedWorkPlan.Equals(other.AssignedWorkPlan)
                ) &&
                (
                    this.OverriddenWorkPlan == other.OverriddenWorkPlan ||
                    this.OverriddenWorkPlan != null &&
                    this.OverriddenWorkPlan.Equals(other.OverriddenWorkPlan)
                ) &&
                (
                    this.OverrideReason == other.OverrideReason ||
                    this.OverrideReason != null &&
                    this.OverrideReason.Equals(other.OverrideReason)
                ) &&
                (
                    this.Priorities == other.Priorities ||
                    this.Priorities != null &&
                    this.Priorities.SequenceEqual(other.Priorities)
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

                if (this.AssignedWorkPlan != null)
                    hash = hash * 59 + this.AssignedWorkPlan.GetHashCode();

                if (this.OverriddenWorkPlan != null)
                    hash = hash * 59 + this.OverriddenWorkPlan.GetHashCode();

                if (this.OverrideReason != null)
                    hash = hash * 59 + this.OverrideReason.GetHashCode();

                if (this.Priorities != null)
                    hash = hash * 59 + this.Priorities.GetHashCode();

                return hash;
            }
        }
    }

}
