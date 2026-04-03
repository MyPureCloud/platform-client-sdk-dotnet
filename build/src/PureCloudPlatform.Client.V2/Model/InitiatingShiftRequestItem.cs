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
    /// InitiatingShiftRequestItem
    /// </summary>
    [DataContract]
    public partial class InitiatingShiftRequestItem :  IEquatable<InitiatingShiftRequestItem>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="InitiatingShiftRequestItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InitiatingShiftRequestItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiatingShiftRequestItem" /> class.
        /// </summary>
        /// <param name="Id">The ID of the shift that the initiating user wants to give up in this trade (required).</param>
        /// <param name="Schedule">A reference to the associated schedule to which this initiating shift belongs (required).</param>
        /// <param name="WeekDate">The start week date of this schedule in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        public InitiatingShiftRequestItem(string Id = null, BuScheduleReference Schedule = null, String WeekDate = null)
        {
            this.Id = Id;
            this.Schedule = Schedule;
            this.WeekDate = WeekDate;
            
        }
        


        /// <summary>
        /// The ID of the shift that the initiating user wants to give up in this trade
        /// </summary>
        /// <value>The ID of the shift that the initiating user wants to give up in this trade</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// A reference to the associated schedule to which this initiating shift belongs
        /// </summary>
        /// <value>A reference to the associated schedule to which this initiating shift belongs</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public BuScheduleReference Schedule { get; set; }



        /// <summary>
        /// The start week date of this schedule in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The start week date of this schedule in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public String WeekDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitiatingShiftRequestItem {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
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
            return this.Equals(obj as InitiatingShiftRequestItem);
        }

        /// <summary>
        /// Returns true if InitiatingShiftRequestItem instances are equal
        /// </summary>
        /// <param name="other">Instance of InitiatingShiftRequestItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitiatingShiftRequestItem other)
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
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();

                if (this.WeekDate != null)
                    hash = hash * 59 + this.WeekDate.GetHashCode();

                return hash;
            }
        }
    }

}
