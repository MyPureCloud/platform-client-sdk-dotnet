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
    /// SingleWorkdayAverageValues
    /// </summary>
    [DataContract]
    public partial class SingleWorkdayAverageValues :  IEquatable<SingleWorkdayAverageValues>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleWorkdayAverageValues" /> class.
        /// </summary>
        /// <param name="Division">The targeted division for the metrics.</param>
        /// <param name="User">The targeted user for the metrics.</param>
        /// <param name="Results">The metric value averages.</param>
        public SingleWorkdayAverageValues(Division Division = null, UserReference User = null, List<WorkdayValuesMetricItem> Results = null)
        {
            this.Division = Division;
            this.User = User;
            this.Results = Results;
            
        }
        
        
        
        /// <summary>
        /// The targeted workday for average value query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The targeted workday for average value query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateWorkday", EmitDefaultValue=false)]
        public String DateWorkday { get; private set; }
        
        
        
        /// <summary>
        /// The targeted division for the metrics
        /// </summary>
        /// <value>The targeted division for the metrics</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public Division Division { get; set; }
        
        
        
        /// <summary>
        /// The targeted user for the metrics
        /// </summary>
        /// <value>The targeted user for the metrics</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }
        
        
        
        /// <summary>
        /// The time zone used for aggregating metric values
        /// </summary>
        /// <value>The time zone used for aggregating metric values</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; private set; }
        
        
        
        /// <summary>
        /// The metric value averages
        /// </summary>
        /// <value>The metric value averages</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<WorkdayValuesMetricItem> Results { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SingleWorkdayAverageValues {\n");
            
            sb.Append("  DateWorkday: ").Append(DateWorkday).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(obj as SingleWorkdayAverageValues);
        }

        /// <summary>
        /// Returns true if SingleWorkdayAverageValues instances are equal
        /// </summary>
        /// <param name="other">Instance of SingleWorkdayAverageValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SingleWorkdayAverageValues other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateWorkday == other.DateWorkday ||
                    this.DateWorkday != null &&
                    this.DateWorkday.Equals(other.DateWorkday)
                ) &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
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
                
                if (this.DateWorkday != null)
                    hash = hash * 59 + this.DateWorkday.GetHashCode();
                
                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();
                
                return hash;
            }
        }
    }

}
