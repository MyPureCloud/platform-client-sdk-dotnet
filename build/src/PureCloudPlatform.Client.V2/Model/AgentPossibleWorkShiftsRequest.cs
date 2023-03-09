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
    /// AgentPossibleWorkShiftsRequest
    /// </summary>
    [DataContract]
    public partial class AgentPossibleWorkShiftsRequest :  IEquatable<AgentPossibleWorkShiftsRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPossibleWorkShiftsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentPossibleWorkShiftsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPossibleWorkShiftsRequest" /> class.
        /// </summary>
        /// <param name="WeekStartDate">Start date of requested effective work plan, day of week will be in line with business unit start day of week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="WeekCount">Number of weeks for which to return possible work shifts (required).</param>
        public AgentPossibleWorkShiftsRequest(String WeekStartDate = null, int? WeekCount = null)
        {
            this.WeekStartDate = WeekStartDate;
            this.WeekCount = WeekCount;
            
        }
        


        /// <summary>
        /// Start date of requested effective work plan, day of week will be in line with business unit start day of week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Start date of requested effective work plan, day of week will be in line with business unit start day of week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="weekStartDate", EmitDefaultValue=false)]
        public String WeekStartDate { get; set; }



        /// <summary>
        /// Number of weeks for which to return possible work shifts
        /// </summary>
        /// <value>Number of weeks for which to return possible work shifts</value>
        [DataMember(Name="weekCount", EmitDefaultValue=false)]
        public int? WeekCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentPossibleWorkShiftsRequest {\n");

            sb.Append("  WeekStartDate: ").Append(WeekStartDate).Append("\n");
            sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
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
            return this.Equals(obj as AgentPossibleWorkShiftsRequest);
        }

        /// <summary>
        /// Returns true if AgentPossibleWorkShiftsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentPossibleWorkShiftsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentPossibleWorkShiftsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WeekStartDate == other.WeekStartDate ||
                    this.WeekStartDate != null &&
                    this.WeekStartDate.Equals(other.WeekStartDate)
                ) &&
                (
                    this.WeekCount == other.WeekCount ||
                    this.WeekCount != null &&
                    this.WeekCount.Equals(other.WeekCount)
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
                if (this.WeekStartDate != null)
                    hash = hash * 59 + this.WeekStartDate.GetHashCode();

                if (this.WeekCount != null)
                    hash = hash * 59 + this.WeekCount.GetHashCode();

                return hash;
            }
        }
    }

}
