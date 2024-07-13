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
    /// AvailabilityRange
    /// </summary>
    [DataContract]
    public partial class AvailabilityRange :  IEquatable<AvailabilityRange>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailabilityRange" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AvailabilityRange() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailabilityRange" /> class.
        /// </summary>
        /// <param name="EarliestStartMinutesFromMidnight">The earliest time of day the activity can be scheduled to begin, in minutes from midnight in the configured time zone of the business unit (required).</param>
        /// <param name="LatestEndMinutesFromMidnight">The latest time of day the activity can be scheduled to end, in minutes from midnight in the configured time zone of the business unit (required).</param>
        public AvailabilityRange(int? EarliestStartMinutesFromMidnight = null, int? LatestEndMinutesFromMidnight = null)
        {
            this.EarliestStartMinutesFromMidnight = EarliestStartMinutesFromMidnight;
            this.LatestEndMinutesFromMidnight = LatestEndMinutesFromMidnight;
            
        }
        


        /// <summary>
        /// The earliest time of day the activity can be scheduled to begin, in minutes from midnight in the configured time zone of the business unit
        /// </summary>
        /// <value>The earliest time of day the activity can be scheduled to begin, in minutes from midnight in the configured time zone of the business unit</value>
        [DataMember(Name="earliestStartMinutesFromMidnight", EmitDefaultValue=false)]
        public int? EarliestStartMinutesFromMidnight { get; set; }



        /// <summary>
        /// The latest time of day the activity can be scheduled to end, in minutes from midnight in the configured time zone of the business unit
        /// </summary>
        /// <value>The latest time of day the activity can be scheduled to end, in minutes from midnight in the configured time zone of the business unit</value>
        [DataMember(Name="latestEndMinutesFromMidnight", EmitDefaultValue=false)]
        public int? LatestEndMinutesFromMidnight { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailabilityRange {\n");

            sb.Append("  EarliestStartMinutesFromMidnight: ").Append(EarliestStartMinutesFromMidnight).Append("\n");
            sb.Append("  LatestEndMinutesFromMidnight: ").Append(LatestEndMinutesFromMidnight).Append("\n");
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
            return this.Equals(obj as AvailabilityRange);
        }

        /// <summary>
        /// Returns true if AvailabilityRange instances are equal
        /// </summary>
        /// <param name="other">Instance of AvailabilityRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailabilityRange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EarliestStartMinutesFromMidnight == other.EarliestStartMinutesFromMidnight ||
                    this.EarliestStartMinutesFromMidnight != null &&
                    this.EarliestStartMinutesFromMidnight.Equals(other.EarliestStartMinutesFromMidnight)
                ) &&
                (
                    this.LatestEndMinutesFromMidnight == other.LatestEndMinutesFromMidnight ||
                    this.LatestEndMinutesFromMidnight != null &&
                    this.LatestEndMinutesFromMidnight.Equals(other.LatestEndMinutesFromMidnight)
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
                if (this.EarliestStartMinutesFromMidnight != null)
                    hash = hash * 59 + this.EarliestStartMinutesFromMidnight.GetHashCode();

                if (this.LatestEndMinutesFromMidnight != null)
                    hash = hash * 59 + this.LatestEndMinutesFromMidnight.GetHashCode();

                return hash;
            }
        }
    }

}
