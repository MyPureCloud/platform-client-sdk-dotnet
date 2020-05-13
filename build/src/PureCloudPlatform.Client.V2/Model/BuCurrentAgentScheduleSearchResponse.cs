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
    /// BuCurrentAgentScheduleSearchResponse
    /// </summary>
    [DataContract]
    public partial class BuCurrentAgentScheduleSearchResponse :  IEquatable<BuCurrentAgentScheduleSearchResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuCurrentAgentScheduleSearchResponse" /> class.
        /// </summary>
        /// <param name="AgentSchedules">The requested agent schedules.</param>
        /// <param name="BusinessUnitTimeZone">The time zone configured for the business unit to which this schedule applies.</param>
        /// <param name="PublishedSchedules">References to all published week schedules overlapping the start/end date query parameters.</param>
        /// <param name="StartDate">The start date of the schedules. Only populated on notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="EndDate">The end date of the schedules. Only populated on notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Updates">The list of updates for the schedule. Only used in notifications.</param>
        public BuCurrentAgentScheduleSearchResponse(List<BuAgentScheduleSearchResponse> AgentSchedules = null, string BusinessUnitTimeZone = null, List<BuAgentSchedulePublishedScheduleReference> PublishedSchedules = null, DateTime? StartDate = null, DateTime? EndDate = null, List<BuAgentScheduleUpdate> Updates = null)
        {
            this.AgentSchedules = AgentSchedules;
            this.BusinessUnitTimeZone = BusinessUnitTimeZone;
            this.PublishedSchedules = PublishedSchedules;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Updates = Updates;
            
        }
        
        
        
        /// <summary>
        /// The requested agent schedules
        /// </summary>
        /// <value>The requested agent schedules</value>
        [DataMember(Name="agentSchedules", EmitDefaultValue=false)]
        public List<BuAgentScheduleSearchResponse> AgentSchedules { get; set; }
        
        
        
        /// <summary>
        /// The time zone configured for the business unit to which this schedule applies
        /// </summary>
        /// <value>The time zone configured for the business unit to which this schedule applies</value>
        [DataMember(Name="businessUnitTimeZone", EmitDefaultValue=false)]
        public string BusinessUnitTimeZone { get; set; }
        
        
        
        /// <summary>
        /// References to all published week schedules overlapping the start/end date query parameters
        /// </summary>
        /// <value>References to all published week schedules overlapping the start/end date query parameters</value>
        [DataMember(Name="publishedSchedules", EmitDefaultValue=false)]
        public List<BuAgentSchedulePublishedScheduleReference> PublishedSchedules { get; set; }
        
        
        
        /// <summary>
        /// The start date of the schedules. Only populated on notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The start date of the schedules. Only populated on notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
        
        
        
        /// <summary>
        /// The end date of the schedules. Only populated on notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The end date of the schedules. Only populated on notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }
        
        
        
        /// <summary>
        /// The list of updates for the schedule. Only used in notifications
        /// </summary>
        /// <value>The list of updates for the schedule. Only used in notifications</value>
        [DataMember(Name="updates", EmitDefaultValue=false)]
        public List<BuAgentScheduleUpdate> Updates { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuCurrentAgentScheduleSearchResponse {\n");
            
            sb.Append("  AgentSchedules: ").Append(AgentSchedules).Append("\n");
            sb.Append("  BusinessUnitTimeZone: ").Append(BusinessUnitTimeZone).Append("\n");
            sb.Append("  PublishedSchedules: ").Append(PublishedSchedules).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Updates: ").Append(Updates).Append("\n");
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
            return this.Equals(obj as BuCurrentAgentScheduleSearchResponse);
        }

        /// <summary>
        /// Returns true if BuCurrentAgentScheduleSearchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BuCurrentAgentScheduleSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuCurrentAgentScheduleSearchResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AgentSchedules == other.AgentSchedules ||
                    this.AgentSchedules != null &&
                    this.AgentSchedules.SequenceEqual(other.AgentSchedules)
                ) &&
                (
                    this.BusinessUnitTimeZone == other.BusinessUnitTimeZone ||
                    this.BusinessUnitTimeZone != null &&
                    this.BusinessUnitTimeZone.Equals(other.BusinessUnitTimeZone)
                ) &&
                (
                    this.PublishedSchedules == other.PublishedSchedules ||
                    this.PublishedSchedules != null &&
                    this.PublishedSchedules.SequenceEqual(other.PublishedSchedules)
                ) &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) &&
                (
                    this.Updates == other.Updates ||
                    this.Updates != null &&
                    this.Updates.SequenceEqual(other.Updates)
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
                
                if (this.AgentSchedules != null)
                    hash = hash * 59 + this.AgentSchedules.GetHashCode();
                
                if (this.BusinessUnitTimeZone != null)
                    hash = hash * 59 + this.BusinessUnitTimeZone.GetHashCode();
                
                if (this.PublishedSchedules != null)
                    hash = hash * 59 + this.PublishedSchedules.GetHashCode();
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                
                if (this.Updates != null)
                    hash = hash * 59 + this.Updates.GetHashCode();
                
                return hash;
            }
        }
    }

}
