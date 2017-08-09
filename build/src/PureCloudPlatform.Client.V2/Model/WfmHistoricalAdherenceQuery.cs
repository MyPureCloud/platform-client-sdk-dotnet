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
    /// Query to request a historical adherence report from Workforce Management Service
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalAdherenceQuery :  IEquatable<WfmHistoricalAdherenceQuery>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WfmHistoricalAdherenceQuery() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceQuery" /> class.
        /// </summary>
        
        
        /// <param name="StartDate">Beginning of the date range to query in ISO-8601 format (required).</param>
        
        
        
        /// <param name="EndDate">End of the date range to query in ISO-8601 format (required).</param>
        
        
        
        /// <param name="TimeZone">The time zone to use for returned results in olson format (See https://www.ibm.com/developerworks/aix/library/au-aix-posix/).</param>
        
        
        
        /// <param name="UserIds">The userIds to report on (required).</param>
        
        
        
        /// <param name="IncludeExceptions">IncludeExceptions.</param>
        
        
        public WfmHistoricalAdherenceQuery(DateTime? StartDate = null, DateTime? EndDate = null, string TimeZone = null, List<string> UserIds = null, bool? IncludeExceptions = null)
        {
            
            
            
            // to ensure "StartDate" is required (not null)
            if (StartDate == null)
            {
                throw new InvalidDataException("StartDate is a required property for WfmHistoricalAdherenceQuery and cannot be null");
            }
            else
            {
                this.StartDate = StartDate;
            }
            
            
            
            
            
            // to ensure "EndDate" is required (not null)
            if (EndDate == null)
            {
                throw new InvalidDataException("EndDate is a required property for WfmHistoricalAdherenceQuery and cannot be null");
            }
            else
            {
                this.EndDate = EndDate;
            }
            
            
            
            
            
            
            
            
            
            // to ensure "UserIds" is required (not null)
            if (UserIds == null)
            {
                throw new InvalidDataException("UserIds is a required property for WfmHistoricalAdherenceQuery and cannot be null");
            }
            else
            {
                this.UserIds = UserIds;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.TimeZone = TimeZone;
            
            
            
            
            
            
            
            
            
            
            
            
this.IncludeExceptions = IncludeExceptions;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Beginning of the date range to query in ISO-8601 format
        /// </summary>
        /// <value>Beginning of the date range to query in ISO-8601 format</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
        
        
        
        /// <summary>
        /// End of the date range to query in ISO-8601 format
        /// </summary>
        /// <value>End of the date range to query in ISO-8601 format</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }
        
        
        
        /// <summary>
        /// The time zone to use for returned results in olson format (See https://www.ibm.com/developerworks/aix/library/au-aix-posix/)
        /// </summary>
        /// <value>The time zone to use for returned results in olson format (See https://www.ibm.com/developerworks/aix/library/au-aix-posix/)</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }
        
        
        
        /// <summary>
        /// The userIds to report on
        /// </summary>
        /// <value>The userIds to report on</value>
        [DataMember(Name="userIds", EmitDefaultValue=false)]
        public List<string> UserIds { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets IncludeExceptions
        /// </summary>
        [DataMember(Name="includeExceptions", EmitDefaultValue=false)]
        public bool? IncludeExceptions { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalAdherenceQuery {\n");
            
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
            
            sb.Append("  IncludeExceptions: ").Append(IncludeExceptions).Append("\n");
            
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
            return this.Equals(obj as WfmHistoricalAdherenceQuery);
        }

        /// <summary>
        /// Returns true if WfmHistoricalAdherenceQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalAdherenceQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalAdherenceQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) &&
                (
                    this.UserIds == other.UserIds ||
                    this.UserIds != null &&
                    this.UserIds.SequenceEqual(other.UserIds)
                ) &&
                (
                    this.IncludeExceptions == other.IncludeExceptions ||
                    this.IncludeExceptions != null &&
                    this.IncludeExceptions.Equals(other.IncludeExceptions)
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
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                
                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                
                if (this.UserIds != null)
                    hash = hash * 59 + this.UserIds.GetHashCode();
                
                if (this.IncludeExceptions != null)
                    hash = hash * 59 + this.IncludeExceptions.GetHashCode();
                
                return hash;
            }
        }
    }

}
