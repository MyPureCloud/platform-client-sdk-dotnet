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
    /// SelfScheduleManagementUnitSettingsRequest
    /// </summary>
    [DataContract]
    public partial class SelfScheduleManagementUnitSettingsRequest :  IEquatable<SelfScheduleManagementUnitSettingsRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SelfScheduleManagementUnitSettingsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SelfScheduleManagementUnitSettingsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SelfScheduleManagementUnitSettingsRequest" /> class.
        /// </summary>
        /// <param name="Enabled">Whether agent self-scheduling is enabled for this management unit.</param>
        /// <param name="CheckWorkPlanConstraints">Whether self-scheduling is further restricted by work plan constraints.</param>
        /// <param name="MinimumMinutesBeforeEarliestScheduleChange">The minimum number of minutes before the new activity start time to which the agent is allowed to self-schedule.</param>
        /// <param name="MovableActivityCategories">Movable activity categories enabled for self-scheduling.</param>
        /// <param name="MovableActivityCodeIds">Movable activity codes enabled for self-scheduling.</param>
        /// <param name="Metadata">Version metadata for this management unit&#39;s self-scheduling settings (required).</param>
        public SelfScheduleManagementUnitSettingsRequest(bool? Enabled = null, bool? CheckWorkPlanConstraints = null, int? MinimumMinutesBeforeEarliestScheduleChange = null, SetWrapperActivityCategory MovableActivityCategories = null, SetWrapperString MovableActivityCodeIds = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Enabled = Enabled;
            this.CheckWorkPlanConstraints = CheckWorkPlanConstraints;
            this.MinimumMinutesBeforeEarliestScheduleChange = MinimumMinutesBeforeEarliestScheduleChange;
            this.MovableActivityCategories = MovableActivityCategories;
            this.MovableActivityCodeIds = MovableActivityCodeIds;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// Whether agent self-scheduling is enabled for this management unit
        /// </summary>
        /// <value>Whether agent self-scheduling is enabled for this management unit</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Whether self-scheduling is further restricted by work plan constraints
        /// </summary>
        /// <value>Whether self-scheduling is further restricted by work plan constraints</value>
        [DataMember(Name="checkWorkPlanConstraints", EmitDefaultValue=false)]
        public bool? CheckWorkPlanConstraints { get; set; }



        /// <summary>
        /// The minimum number of minutes before the new activity start time to which the agent is allowed to self-schedule
        /// </summary>
        /// <value>The minimum number of minutes before the new activity start time to which the agent is allowed to self-schedule</value>
        [DataMember(Name="minimumMinutesBeforeEarliestScheduleChange", EmitDefaultValue=false)]
        public int? MinimumMinutesBeforeEarliestScheduleChange { get; set; }



        /// <summary>
        /// Movable activity categories enabled for self-scheduling
        /// </summary>
        /// <value>Movable activity categories enabled for self-scheduling</value>
        [DataMember(Name="movableActivityCategories", EmitDefaultValue=false)]
        public SetWrapperActivityCategory MovableActivityCategories { get; set; }



        /// <summary>
        /// Movable activity codes enabled for self-scheduling
        /// </summary>
        /// <value>Movable activity codes enabled for self-scheduling</value>
        [DataMember(Name="movableActivityCodeIds", EmitDefaultValue=false)]
        public SetWrapperString MovableActivityCodeIds { get; set; }



        /// <summary>
        /// Version metadata for this management unit&#39;s self-scheduling settings
        /// </summary>
        /// <value>Version metadata for this management unit&#39;s self-scheduling settings</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelfScheduleManagementUnitSettingsRequest {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  CheckWorkPlanConstraints: ").Append(CheckWorkPlanConstraints).Append("\n");
            sb.Append("  MinimumMinutesBeforeEarliestScheduleChange: ").Append(MinimumMinutesBeforeEarliestScheduleChange).Append("\n");
            sb.Append("  MovableActivityCategories: ").Append(MovableActivityCategories).Append("\n");
            sb.Append("  MovableActivityCodeIds: ").Append(MovableActivityCodeIds).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as SelfScheduleManagementUnitSettingsRequest);
        }

        /// <summary>
        /// Returns true if SelfScheduleManagementUnitSettingsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SelfScheduleManagementUnitSettingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelfScheduleManagementUnitSettingsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.CheckWorkPlanConstraints == other.CheckWorkPlanConstraints ||
                    this.CheckWorkPlanConstraints != null &&
                    this.CheckWorkPlanConstraints.Equals(other.CheckWorkPlanConstraints)
                ) &&
                (
                    this.MinimumMinutesBeforeEarliestScheduleChange == other.MinimumMinutesBeforeEarliestScheduleChange ||
                    this.MinimumMinutesBeforeEarliestScheduleChange != null &&
                    this.MinimumMinutesBeforeEarliestScheduleChange.Equals(other.MinimumMinutesBeforeEarliestScheduleChange)
                ) &&
                (
                    this.MovableActivityCategories == other.MovableActivityCategories ||
                    this.MovableActivityCategories != null &&
                    this.MovableActivityCategories.Equals(other.MovableActivityCategories)
                ) &&
                (
                    this.MovableActivityCodeIds == other.MovableActivityCodeIds ||
                    this.MovableActivityCodeIds != null &&
                    this.MovableActivityCodeIds.Equals(other.MovableActivityCodeIds)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.CheckWorkPlanConstraints != null)
                    hash = hash * 59 + this.CheckWorkPlanConstraints.GetHashCode();

                if (this.MinimumMinutesBeforeEarliestScheduleChange != null)
                    hash = hash * 59 + this.MinimumMinutesBeforeEarliestScheduleChange.GetHashCode();

                if (this.MovableActivityCategories != null)
                    hash = hash * 59 + this.MovableActivityCategories.GetHashCode();

                if (this.MovableActivityCodeIds != null)
                    hash = hash * 59 + this.MovableActivityCodeIds.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
