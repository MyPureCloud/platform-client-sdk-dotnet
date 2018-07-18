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
    /// Information to create a schedule for a week in management unit using imported data
    /// </summary>
    [DataContract]
    public partial class ImportWeekScheduleRequest :  IEquatable<ImportWeekScheduleRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportWeekScheduleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImportWeekScheduleRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportWeekScheduleRequest" /> class.
        /// </summary>
        /// <param name="Description">Description for the schedule (required).</param>
        /// <param name="UserSchedules">User schedules.</param>
        /// <param name="Published">Whether the schedule is published.</param>
        /// <param name="ShortTermForecastId">Short term forecast that should be associated with this schedule.</param>
        /// <param name="PartialUploadIds">IDs of partial uploads of user schedules to import week schedule. It is applicable only for large schedules where activity count in schedule is greater than 17500.</param>
        public ImportWeekScheduleRequest(string Description = null, Dictionary<string, UserSchedule> UserSchedules = null, bool? Published = null, string ShortTermForecastId = null, List<string> PartialUploadIds = null)
        {
            this.Description = Description;
            this.UserSchedules = UserSchedules;
            this.Published = Published;
            this.ShortTermForecastId = ShortTermForecastId;
            this.PartialUploadIds = PartialUploadIds;
            
        }
        
        
        
        /// <summary>
        /// Description for the schedule
        /// </summary>
        /// <value>Description for the schedule</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// User schedules
        /// </summary>
        /// <value>User schedules</value>
        [DataMember(Name="userSchedules", EmitDefaultValue=false)]
        public Dictionary<string, UserSchedule> UserSchedules { get; set; }
        
        
        
        /// <summary>
        /// Whether the schedule is published
        /// </summary>
        /// <value>Whether the schedule is published</value>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }
        
        
        
        /// <summary>
        /// Short term forecast that should be associated with this schedule
        /// </summary>
        /// <value>Short term forecast that should be associated with this schedule</value>
        [DataMember(Name="shortTermForecastId", EmitDefaultValue=false)]
        public string ShortTermForecastId { get; set; }
        
        
        
        /// <summary>
        /// IDs of partial uploads of user schedules to import week schedule. It is applicable only for large schedules where activity count in schedule is greater than 17500
        /// </summary>
        /// <value>IDs of partial uploads of user schedules to import week schedule. It is applicable only for large schedules where activity count in schedule is greater than 17500</value>
        [DataMember(Name="partialUploadIds", EmitDefaultValue=false)]
        public List<string> PartialUploadIds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportWeekScheduleRequest {\n");
            
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UserSchedules: ").Append(UserSchedules).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  ShortTermForecastId: ").Append(ShortTermForecastId).Append("\n");
            sb.Append("  PartialUploadIds: ").Append(PartialUploadIds).Append("\n");
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
            return this.Equals(obj as ImportWeekScheduleRequest);
        }

        /// <summary>
        /// Returns true if ImportWeekScheduleRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportWeekScheduleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportWeekScheduleRequest other)
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
                    this.UserSchedules == other.UserSchedules ||
                    this.UserSchedules != null &&
                    this.UserSchedules.SequenceEqual(other.UserSchedules)
                ) &&
                (
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) &&
                (
                    this.ShortTermForecastId == other.ShortTermForecastId ||
                    this.ShortTermForecastId != null &&
                    this.ShortTermForecastId.Equals(other.ShortTermForecastId)
                ) &&
                (
                    this.PartialUploadIds == other.PartialUploadIds ||
                    this.PartialUploadIds != null &&
                    this.PartialUploadIds.SequenceEqual(other.PartialUploadIds)
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
                
                if (this.UserSchedules != null)
                    hash = hash * 59 + this.UserSchedules.GetHashCode();
                
                if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();
                
                if (this.ShortTermForecastId != null)
                    hash = hash * 59 + this.ShortTermForecastId.GetHashCode();
                
                if (this.PartialUploadIds != null)
                    hash = hash * 59 + this.PartialUploadIds.GetHashCode();
                
                return hash;
            }
        }
    }

}
