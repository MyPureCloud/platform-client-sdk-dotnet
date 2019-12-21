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
    /// WfmBuScheduleRunTopicLocalDate
    /// </summary>
    [DataContract]
    public partial class WfmBuScheduleRunTopicLocalDate :  IEquatable<WfmBuScheduleRunTopicLocalDate>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmBuScheduleRunTopicLocalDate" /> class.
        /// </summary>
        /// <param name="Year">Year.</param>
        /// <param name="Month">Month.</param>
        /// <param name="Day">Day.</param>
        /// <param name="LeapYear">LeapYear.</param>
        public WfmBuScheduleRunTopicLocalDate(int? Year = null, int? Month = null, int? Day = null, bool? LeapYear = null)
        {
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;
            this.LeapYear = LeapYear;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name="month", EmitDefaultValue=false)]
        public int? Month { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name="day", EmitDefaultValue=false)]
        public int? Day { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets LeapYear
        /// </summary>
        [DataMember(Name="leapYear", EmitDefaultValue=false)]
        public bool? LeapYear { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmBuScheduleRunTopicLocalDate {\n");
            
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  LeapYear: ").Append(LeapYear).Append("\n");
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
            return this.Equals(obj as WfmBuScheduleRunTopicLocalDate);
        }

        /// <summary>
        /// Returns true if WfmBuScheduleRunTopicLocalDate instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmBuScheduleRunTopicLocalDate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmBuScheduleRunTopicLocalDate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Year == other.Year ||
                    this.Year != null &&
                    this.Year.Equals(other.Year)
                ) &&
                (
                    this.Month == other.Month ||
                    this.Month != null &&
                    this.Month.Equals(other.Month)
                ) &&
                (
                    this.Day == other.Day ||
                    this.Day != null &&
                    this.Day.Equals(other.Day)
                ) &&
                (
                    this.LeapYear == other.LeapYear ||
                    this.LeapYear != null &&
                    this.LeapYear.Equals(other.LeapYear)
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
                
                if (this.Year != null)
                    hash = hash * 59 + this.Year.GetHashCode();
                
                if (this.Month != null)
                    hash = hash * 59 + this.Month.GetHashCode();
                
                if (this.Day != null)
                    hash = hash * 59 + this.Day.GetHashCode();
                
                if (this.LeapYear != null)
                    hash = hash * 59 + this.LeapYear.GetHashCode();
                
                return hash;
            }
        }
    }

}
