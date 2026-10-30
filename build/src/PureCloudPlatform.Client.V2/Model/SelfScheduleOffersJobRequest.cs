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
    /// SelfScheduleOffersJobRequest
    /// </summary>
    [DataContract]
    public partial class SelfScheduleOffersJobRequest :  IEquatable<SelfScheduleOffersJobRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SelfScheduleOffersJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SelfScheduleOffersJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SelfScheduleOffersJobRequest" /> class.
        /// </summary>
        /// <param name="ShiftId">The ID of the shift that the user wants to self-schedule (required).</param>
        /// <param name="Schedule">A reference to the associated schedule to which this shift belongs (required).</param>
        public SelfScheduleOffersJobRequest(string ShiftId = null, BuScheduleReference Schedule = null)
        {
            this.ShiftId = ShiftId;
            this.Schedule = Schedule;
            
        }
        


        /// <summary>
        /// The ID of the shift that the user wants to self-schedule
        /// </summary>
        /// <value>The ID of the shift that the user wants to self-schedule</value>
        [DataMember(Name="shiftId", EmitDefaultValue=false)]
        public string ShiftId { get; set; }



        /// <summary>
        /// A reference to the associated schedule to which this shift belongs
        /// </summary>
        /// <value>A reference to the associated schedule to which this shift belongs</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public BuScheduleReference Schedule { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelfScheduleOffersJobRequest {\n");

            sb.Append("  ShiftId: ").Append(ShiftId).Append("\n");
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
            return this.Equals(obj as SelfScheduleOffersJobRequest);
        }

        /// <summary>
        /// Returns true if SelfScheduleOffersJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SelfScheduleOffersJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelfScheduleOffersJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ShiftId == other.ShiftId ||
                    this.ShiftId != null &&
                    this.ShiftId.Equals(other.ShiftId)
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
                if (this.ShiftId != null)
                    hash = hash * 59 + this.ShiftId.GetHashCode();

                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();

                return hash;
            }
        }
    }

}
