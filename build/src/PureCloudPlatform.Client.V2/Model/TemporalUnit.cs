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
    /// TemporalUnit
    /// </summary>
    [DataContract]
    public partial class TemporalUnit :  IEquatable<TemporalUnit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemporalUnit" /> class.
        /// </summary>
        /// <param name="DurationEstimated">DurationEstimated.</param>
        /// <param name="Duration">Duration.</param>
        /// <param name="TimeBased">TimeBased.</param>
        /// <param name="DateBased">DateBased.</param>
        public TemporalUnit(bool? DurationEstimated = null, Duration Duration = null, bool? TimeBased = null, bool? DateBased = null)
        {
            this.DurationEstimated = DurationEstimated;
            this.Duration = Duration;
            this.TimeBased = TimeBased;
            this.DateBased = DateBased;
            
        }
        


        /// <summary>
        /// Gets or Sets DurationEstimated
        /// </summary>
        [DataMember(Name="durationEstimated", EmitDefaultValue=false)]
        public bool? DurationEstimated { get; set; }



        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public Duration Duration { get; set; }



        /// <summary>
        /// Gets or Sets TimeBased
        /// </summary>
        [DataMember(Name="timeBased", EmitDefaultValue=false)]
        public bool? TimeBased { get; set; }



        /// <summary>
        /// Gets or Sets DateBased
        /// </summary>
        [DataMember(Name="dateBased", EmitDefaultValue=false)]
        public bool? DateBased { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemporalUnit {\n");

            sb.Append("  DurationEstimated: ").Append(DurationEstimated).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  TimeBased: ").Append(TimeBased).Append("\n");
            sb.Append("  DateBased: ").Append(DateBased).Append("\n");
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
            return this.Equals(obj as TemporalUnit);
        }

        /// <summary>
        /// Returns true if TemporalUnit instances are equal
        /// </summary>
        /// <param name="other">Instance of TemporalUnit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemporalUnit other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DurationEstimated == other.DurationEstimated ||
                    this.DurationEstimated != null &&
                    this.DurationEstimated.Equals(other.DurationEstimated)
                ) &&
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) &&
                (
                    this.TimeBased == other.TimeBased ||
                    this.TimeBased != null &&
                    this.TimeBased.Equals(other.TimeBased)
                ) &&
                (
                    this.DateBased == other.DateBased ||
                    this.DateBased != null &&
                    this.DateBased.Equals(other.DateBased)
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
                if (this.DurationEstimated != null)
                    hash = hash * 59 + this.DurationEstimated.GetHashCode();

                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();

                if (this.TimeBased != null)
                    hash = hash * 59 + this.TimeBased.GetHashCode();

                if (this.DateBased != null)
                    hash = hash * 59 + this.DateBased.GetHashCode();

                return hash;
            }
        }
    }

}
