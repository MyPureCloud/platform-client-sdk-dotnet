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
    /// Work plan information
    /// </summary>
    [DataContract]
    public partial class WorkPlanListItemResponse :  IEquatable<WorkPlanListItemResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanListItemResponse" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="AgentCount">Number of agents in this work plan.</param>
        /// <param name="WeeklyMinimumPaidMinutes">Minimum weekly paid time in minutes defined in this work plan.</param>
        /// <param name="WeeklyMaximumPaidMinutes">Maximum weekly paid time in minutes defined in this work plan.</param>
        /// <param name="MaximumDays">Maximum number of days in a week that can be scheduled using this work plan.</param>
        /// <param name="Enabled">Whether the work plan is enabled for scheduling.</param>
        /// <param name="Metadata">Version metadata for this work plan.</param>
        public WorkPlanListItemResponse(string Name = null, int? AgentCount = null, int? WeeklyMinimumPaidMinutes = null, int? WeeklyMaximumPaidMinutes = null, int? MaximumDays = null, bool? Enabled = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Name = Name;
            this.AgentCount = AgentCount;
            this.WeeklyMinimumPaidMinutes = WeeklyMinimumPaidMinutes;
            this.WeeklyMaximumPaidMinutes = WeeklyMaximumPaidMinutes;
            this.MaximumDays = MaximumDays;
            this.Enabled = Enabled;
            this.Metadata = Metadata;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Number of agents in this work plan
        /// </summary>
        /// <value>Number of agents in this work plan</value>
        [DataMember(Name="agentCount", EmitDefaultValue=false)]
        public int? AgentCount { get; set; }
        
        
        
        /// <summary>
        /// Minimum weekly paid time in minutes defined in this work plan
        /// </summary>
        /// <value>Minimum weekly paid time in minutes defined in this work plan</value>
        [DataMember(Name="weeklyMinimumPaidMinutes", EmitDefaultValue=false)]
        public int? WeeklyMinimumPaidMinutes { get; set; }
        
        
        
        /// <summary>
        /// Maximum weekly paid time in minutes defined in this work plan
        /// </summary>
        /// <value>Maximum weekly paid time in minutes defined in this work plan</value>
        [DataMember(Name="weeklyMaximumPaidMinutes", EmitDefaultValue=false)]
        public int? WeeklyMaximumPaidMinutes { get; set; }
        
        
        
        /// <summary>
        /// Maximum number of days in a week that can be scheduled using this work plan
        /// </summary>
        /// <value>Maximum number of days in a week that can be scheduled using this work plan</value>
        [DataMember(Name="maximumDays", EmitDefaultValue=false)]
        public int? MaximumDays { get; set; }
        
        
        
        /// <summary>
        /// Whether the work plan is enabled for scheduling
        /// </summary>
        /// <value>Whether the work plan is enabled for scheduling</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        
        /// <summary>
        /// Version metadata for this work plan
        /// </summary>
        /// <value>Version metadata for this work plan</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }
        
        
        
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
            sb.Append("class WorkPlanListItemResponse {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AgentCount: ").Append(AgentCount).Append("\n");
            sb.Append("  WeeklyMinimumPaidMinutes: ").Append(WeeklyMinimumPaidMinutes).Append("\n");
            sb.Append("  WeeklyMaximumPaidMinutes: ").Append(WeeklyMaximumPaidMinutes).Append("\n");
            sb.Append("  MaximumDays: ").Append(MaximumDays).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as WorkPlanListItemResponse);
        }

        /// <summary>
        /// Returns true if WorkPlanListItemResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkPlanListItemResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkPlanListItemResponse other)
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
                    this.AgentCount == other.AgentCount ||
                    this.AgentCount != null &&
                    this.AgentCount.Equals(other.AgentCount)
                ) &&
                (
                    this.WeeklyMinimumPaidMinutes == other.WeeklyMinimumPaidMinutes ||
                    this.WeeklyMinimumPaidMinutes != null &&
                    this.WeeklyMinimumPaidMinutes.Equals(other.WeeklyMinimumPaidMinutes)
                ) &&
                (
                    this.WeeklyMaximumPaidMinutes == other.WeeklyMaximumPaidMinutes ||
                    this.WeeklyMaximumPaidMinutes != null &&
                    this.WeeklyMaximumPaidMinutes.Equals(other.WeeklyMaximumPaidMinutes)
                ) &&
                (
                    this.MaximumDays == other.MaximumDays ||
                    this.MaximumDays != null &&
                    this.MaximumDays.Equals(other.MaximumDays)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                
                if (this.AgentCount != null)
                    hash = hash * 59 + this.AgentCount.GetHashCode();
                
                if (this.WeeklyMinimumPaidMinutes != null)
                    hash = hash * 59 + this.WeeklyMinimumPaidMinutes.GetHashCode();
                
                if (this.WeeklyMaximumPaidMinutes != null)
                    hash = hash * 59 + this.WeeklyMaximumPaidMinutes.GetHashCode();
                
                if (this.MaximumDays != null)
                    hash = hash * 59 + this.MaximumDays.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
