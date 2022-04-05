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
    /// UpdateScheduleUploadSchema
    /// </summary>
    [DataContract]
    public partial class UpdateScheduleUploadSchema :  IEquatable<UpdateScheduleUploadSchema>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateScheduleUploadSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateScheduleUploadSchema() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateScheduleUploadSchema" /> class.
        /// </summary>
        /// <param name="Description">The description to set for the schedule.</param>
        /// <param name="Published">Whether to publish the schedule. Note: a schedule cannot be un-published unless another schedule is published over it.</param>
        /// <param name="ShortTermForecast">The short term forecast to associate with the schedule.</param>
        /// <param name="HeadcountForecast">The headcount forecast to associate with the schedule.</param>
        /// <param name="AgentSchedules">Individual agent schedules.</param>
        /// <param name="Metadata">Version metadata for this schedule (required).</param>
        public UpdateScheduleUploadSchema(string Description = null, bool? Published = null, BuShortTermForecastReference ShortTermForecast = null, BuHeadcountForecast HeadcountForecast = null, List<BuUpdateAgentScheduleUploadSchema> AgentSchedules = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Description = Description;
            this.Published = Published;
            this.ShortTermForecast = ShortTermForecast;
            this.HeadcountForecast = HeadcountForecast;
            this.AgentSchedules = AgentSchedules;
            this.Metadata = Metadata;
            
        }
        
        
        
        /// <summary>
        /// The description to set for the schedule
        /// </summary>
        /// <value>The description to set for the schedule</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Whether to publish the schedule. Note: a schedule cannot be un-published unless another schedule is published over it
        /// </summary>
        /// <value>Whether to publish the schedule. Note: a schedule cannot be un-published unless another schedule is published over it</value>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }
        
        
        
        /// <summary>
        /// The short term forecast to associate with the schedule
        /// </summary>
        /// <value>The short term forecast to associate with the schedule</value>
        [DataMember(Name="shortTermForecast", EmitDefaultValue=false)]
        public BuShortTermForecastReference ShortTermForecast { get; set; }
        
        
        
        /// <summary>
        /// The headcount forecast to associate with the schedule
        /// </summary>
        /// <value>The headcount forecast to associate with the schedule</value>
        [DataMember(Name="headcountForecast", EmitDefaultValue=false)]
        public BuHeadcountForecast HeadcountForecast { get; set; }
        
        
        
        /// <summary>
        /// Individual agent schedules
        /// </summary>
        /// <value>Individual agent schedules</value>
        [DataMember(Name="agentSchedules", EmitDefaultValue=false)]
        public List<BuUpdateAgentScheduleUploadSchema> AgentSchedules { get; set; }
        
        
        
        /// <summary>
        /// Version metadata for this schedule
        /// </summary>
        /// <value>Version metadata for this schedule</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateScheduleUploadSchema {\n");
            
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  ShortTermForecast: ").Append(ShortTermForecast).Append("\n");
            sb.Append("  HeadcountForecast: ").Append(HeadcountForecast).Append("\n");
            sb.Append("  AgentSchedules: ").Append(AgentSchedules).Append("\n");
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
            return this.Equals(obj as UpdateScheduleUploadSchema);
        }

        /// <summary>
        /// Returns true if UpdateScheduleUploadSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateScheduleUploadSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateScheduleUploadSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) &&
                (
                    this.ShortTermForecast == other.ShortTermForecast ||
                    this.ShortTermForecast != null &&
                    this.ShortTermForecast.Equals(other.ShortTermForecast)
                ) &&
                (
                    this.HeadcountForecast == other.HeadcountForecast ||
                    this.HeadcountForecast != null &&
                    this.HeadcountForecast.Equals(other.HeadcountForecast)
                ) &&
                (
                    this.AgentSchedules == other.AgentSchedules ||
                    this.AgentSchedules != null &&
                    this.AgentSchedules.SequenceEqual(other.AgentSchedules)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();
                
                if (this.ShortTermForecast != null)
                    hash = hash * 59 + this.ShortTermForecast.GetHashCode();
                
                if (this.HeadcountForecast != null)
                    hash = hash * 59 + this.HeadcountForecast.GetHashCode();
                
                if (this.AgentSchedules != null)
                    hash = hash * 59 + this.AgentSchedules.GetHashCode();
                
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                
                return hash;
            }
        }
    }

}
