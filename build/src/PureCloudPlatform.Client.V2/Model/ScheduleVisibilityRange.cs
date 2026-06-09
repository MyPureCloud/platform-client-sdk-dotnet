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
    /// ScheduleVisibilityRange
    /// </summary>
    [DataContract]
    public partial class ScheduleVisibilityRange :  IEquatable<ScheduleVisibilityRange>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleVisibilityRange" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleVisibilityRange() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleVisibilityRange" /> class.
        /// </summary>
        /// <param name="EndDate">The schedule visibility end time in ISO-8601, the schedule is visible up to (but not including) that exact time) (required).</param>
        /// <param name="EndBusinessUnitDate">The schedule visibility end date interpreted in the business unit time zone in yyyy-MM-dd format, the schedule is visible up to (but not including) that exact date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        public ScheduleVisibilityRange(DateTime? EndDate = null, String EndBusinessUnitDate = null)
        {
            this.EndDate = EndDate;
            this.EndBusinessUnitDate = EndBusinessUnitDate;
            
        }
        


        /// <summary>
        /// The schedule visibility end time in ISO-8601, the schedule is visible up to (but not including) that exact time)
        /// </summary>
        /// <value>The schedule visibility end time in ISO-8601, the schedule is visible up to (but not including) that exact time)</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }



        /// <summary>
        /// The schedule visibility end date interpreted in the business unit time zone in yyyy-MM-dd format, the schedule is visible up to (but not including) that exact date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The schedule visibility end date interpreted in the business unit time zone in yyyy-MM-dd format, the schedule is visible up to (but not including) that exact date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="endBusinessUnitDate", EmitDefaultValue=false)]
        public String EndBusinessUnitDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleVisibilityRange {\n");

            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  EndBusinessUnitDate: ").Append(EndBusinessUnitDate).Append("\n");
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
            return this.Equals(obj as ScheduleVisibilityRange);
        }

        /// <summary>
        /// Returns true if ScheduleVisibilityRange instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduleVisibilityRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleVisibilityRange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) &&
                (
                    this.EndBusinessUnitDate == other.EndBusinessUnitDate ||
                    this.EndBusinessUnitDate != null &&
                    this.EndBusinessUnitDate.Equals(other.EndBusinessUnitDate)
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
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();

                if (this.EndBusinessUnitDate != null)
                    hash = hash * 59 + this.EndBusinessUnitDate.GetHashCode();

                return hash;
            }
        }
    }

}
