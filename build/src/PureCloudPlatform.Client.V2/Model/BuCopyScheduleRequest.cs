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
    /// BuCopyScheduleRequest
    /// </summary>
    [DataContract]
    public partial class BuCopyScheduleRequest :  IEquatable<BuCopyScheduleRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuCopyScheduleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuCopyScheduleRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuCopyScheduleRequest" /> class.
        /// </summary>
        /// <param name="Description">The description for the new schedule (required).</param>
        /// <param name="WeekDate">The start weekDate for the new copy of the schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        public BuCopyScheduleRequest(string Description = null, DateTime? WeekDate = null)
        {
            this.Description = Description;
            this.WeekDate = WeekDate;
            
        }
        
        
        
        /// <summary>
        /// The description for the new schedule
        /// </summary>
        /// <value>The description for the new schedule</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// The start weekDate for the new copy of the schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The start weekDate for the new copy of the schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public DateTime? WeekDate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuCopyScheduleRequest {\n");
            
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
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
            return this.Equals(obj as BuCopyScheduleRequest);
        }

        /// <summary>
        /// Returns true if BuCopyScheduleRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BuCopyScheduleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuCopyScheduleRequest other)
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
                    this.WeekDate == other.WeekDate ||
                    this.WeekDate != null &&
                    this.WeekDate.Equals(other.WeekDate)
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
                
                if (this.WeekDate != null)
                    hash = hash * 59 + this.WeekDate.GetHashCode();
                
                return hash;
            }
        }
    }

}
