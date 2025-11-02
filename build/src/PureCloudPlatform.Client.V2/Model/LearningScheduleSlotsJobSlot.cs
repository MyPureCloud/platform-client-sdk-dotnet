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
    /// LearningScheduleSlotsJobSlot
    /// </summary>
    [DataContract]
    public partial class LearningScheduleSlotsJobSlot :  IEquatable<LearningScheduleSlotsJobSlot>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningScheduleSlotsJobSlot" /> class.
        /// </summary>
        /// <param name="DateStart">Start date and time of the slot. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Schedule">The schedule information of the slot.</param>
        public LearningScheduleSlotsJobSlot(DateTime? DateStart = null, LearningScheduleSlotsJobSchedule Schedule = null)
        {
            this.DateStart = DateStart;
            this.Schedule = Schedule;
            
        }
        


        /// <summary>
        /// Start date and time of the slot. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Start date and time of the slot. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public DateTime? DateStart { get; set; }



        /// <summary>
        /// The schedule information of the slot
        /// </summary>
        /// <value>The schedule information of the slot</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public LearningScheduleSlotsJobSchedule Schedule { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningScheduleSlotsJobSlot {\n");

            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
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
            return this.Equals(obj as LearningScheduleSlotsJobSlot);
        }

        /// <summary>
        /// Returns true if LearningScheduleSlotsJobSlot instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningScheduleSlotsJobSlot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningScheduleSlotsJobSlot other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
                ) &&
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
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
                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();

                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();

                return hash;
            }
        }
    }

}
