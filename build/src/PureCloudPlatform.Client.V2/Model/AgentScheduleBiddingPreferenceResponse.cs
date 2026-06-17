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
    /// AgentScheduleBiddingPreferenceResponse
    /// </summary>
    [DataContract]
    public partial class AgentScheduleBiddingPreferenceResponse :  IEquatable<AgentScheduleBiddingPreferenceResponse>
    {
        /// <summary>
        /// The reason why the assigned schedule set has been overridden. This must be null without an override schedule set
        /// </summary>
        /// <value>The reason why the assigned schedule set has been overridden. This must be null without an override schedule set</value>
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
        /// The reason why the assigned schedule set has been overridden. This must be null without an override schedule set
        /// </summary>
        /// <value>The reason why the assigned schedule set has been overridden. This must be null without an override schedule set</value>
        [DataMember(Name="overrideReason", EmitDefaultValue=false)]
        public OverrideReasonEnum? OverrideReason { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentScheduleBiddingPreferenceResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentScheduleBiddingPreferenceResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentScheduleBiddingPreferenceResponse" /> class.
        /// </summary>
        /// <param name="Submitted">Whether the preference is submitted (required).</param>
        /// <param name="AssignedScheduleSetId">The schedule set assigned to the agent by the bid process. Will be set after bid is processed.</param>
        /// <param name="OverriddenScheduleSetId">The schedule set that overrides the assigned schedule set for the agent.</param>
        /// <param name="OverrideReason">The reason why the assigned schedule set has been overridden. This must be null without an override schedule set.</param>
        /// <param name="AgentScheduleBidPreferences">The schedule bidding preferences (required).</param>
        public AgentScheduleBiddingPreferenceResponse(bool? Submitted = null, string AssignedScheduleSetId = null, string OverriddenScheduleSetId = null, OverrideReasonEnum? OverrideReason = null, List<AgentScheduleBiddingPreferencePriority> AgentScheduleBidPreferences = null)
        {
            this.Submitted = Submitted;
            this.AssignedScheduleSetId = AssignedScheduleSetId;
            this.OverriddenScheduleSetId = OverriddenScheduleSetId;
            this.OverrideReason = OverrideReason;
            this.AgentScheduleBidPreferences = AgentScheduleBidPreferences;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Whether the preference is submitted
        /// </summary>
        /// <value>Whether the preference is submitted</value>
        [DataMember(Name="submitted", EmitDefaultValue=false)]
        public bool? Submitted { get; set; }



        /// <summary>
        /// The schedule set assigned to the agent by the bid process. Will be set after bid is processed
        /// </summary>
        /// <value>The schedule set assigned to the agent by the bid process. Will be set after bid is processed</value>
        [DataMember(Name="assignedScheduleSetId", EmitDefaultValue=false)]
        public string AssignedScheduleSetId { get; set; }



        /// <summary>
        /// The schedule set that overrides the assigned schedule set for the agent
        /// </summary>
        /// <value>The schedule set that overrides the assigned schedule set for the agent</value>
        [DataMember(Name="overriddenScheduleSetId", EmitDefaultValue=false)]
        public string OverriddenScheduleSetId { get; set; }





        /// <summary>
        /// The schedule bidding preferences
        /// </summary>
        /// <value>The schedule bidding preferences</value>
        [DataMember(Name="agentScheduleBidPreferences", EmitDefaultValue=false)]
        public List<AgentScheduleBiddingPreferencePriority> AgentScheduleBidPreferences { get; set; }



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
            sb.Append("class AgentScheduleBiddingPreferenceResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Submitted: ").Append(Submitted).Append("\n");
            sb.Append("  AssignedScheduleSetId: ").Append(AssignedScheduleSetId).Append("\n");
            sb.Append("  OverriddenScheduleSetId: ").Append(OverriddenScheduleSetId).Append("\n");
            sb.Append("  OverrideReason: ").Append(OverrideReason).Append("\n");
            sb.Append("  AgentScheduleBidPreferences: ").Append(AgentScheduleBidPreferences).Append("\n");
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
            return this.Equals(obj as AgentScheduleBiddingPreferenceResponse);
        }

        /// <summary>
        /// Returns true if AgentScheduleBiddingPreferenceResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentScheduleBiddingPreferenceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentScheduleBiddingPreferenceResponse other)
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
                    this.AgentScheduleBidPreferences == other.AgentScheduleBidPreferences ||
                    this.AgentScheduleBidPreferences != null &&
                    this.AgentScheduleBidPreferences.SequenceEqual(other.AgentScheduleBidPreferences)
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

                if (this.Submitted != null)
                    hash = hash * 59 + this.Submitted.GetHashCode();

                if (this.AssignedScheduleSetId != null)
                    hash = hash * 59 + this.AssignedScheduleSetId.GetHashCode();

                if (this.OverriddenScheduleSetId != null)
                    hash = hash * 59 + this.OverriddenScheduleSetId.GetHashCode();

                if (this.OverrideReason != null)
                    hash = hash * 59 + this.OverrideReason.GetHashCode();

                if (this.AgentScheduleBidPreferences != null)
                    hash = hash * 59 + this.AgentScheduleBidPreferences.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
