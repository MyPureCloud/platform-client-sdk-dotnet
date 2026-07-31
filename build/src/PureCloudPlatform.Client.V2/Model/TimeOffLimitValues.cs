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
    /// TimeOffLimitValues
    /// </summary>
    [DataContract]
    public partial class TimeOffLimitValues :  IEquatable<TimeOffLimitValues>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffLimitValues" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimeOffLimitValues() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffLimitValues" /> class.
        /// </summary>
        /// <param name="LimitMinutes">Time-off limit values in minutes per granularity interval (required).</param>
        /// <param name="AllocatedMinutes">Allocated time-off minutes per granularity interval (required).</param>
        /// <param name="WaitlistedMinutes">Waitlisted time-off minutes per granularity interval (required).</param>
        /// <param name="WaitlistedRequests">The current number of waitlisted time-off requests per granularity interval (required).</param>
        public TimeOffLimitValues(List<int?> LimitMinutes = null, List<int?> AllocatedMinutes = null, List<int?> WaitlistedMinutes = null, List<int?> WaitlistedRequests = null)
        {
            this.LimitMinutes = LimitMinutes;
            this.AllocatedMinutes = AllocatedMinutes;
            this.WaitlistedMinutes = WaitlistedMinutes;
            this.WaitlistedRequests = WaitlistedRequests;
            
        }
        


        /// <summary>
        /// Time-off limit values in minutes per granularity interval
        /// </summary>
        /// <value>Time-off limit values in minutes per granularity interval</value>
        [DataMember(Name="limitMinutes", EmitDefaultValue=false)]
        public List<int?> LimitMinutes { get; set; }



        /// <summary>
        /// Allocated time-off minutes per granularity interval
        /// </summary>
        /// <value>Allocated time-off minutes per granularity interval</value>
        [DataMember(Name="allocatedMinutes", EmitDefaultValue=false)]
        public List<int?> AllocatedMinutes { get; set; }



        /// <summary>
        /// Waitlisted time-off minutes per granularity interval
        /// </summary>
        /// <value>Waitlisted time-off minutes per granularity interval</value>
        [DataMember(Name="waitlistedMinutes", EmitDefaultValue=false)]
        public List<int?> WaitlistedMinutes { get; set; }



        /// <summary>
        /// The current number of waitlisted time-off requests per granularity interval
        /// </summary>
        /// <value>The current number of waitlisted time-off requests per granularity interval</value>
        [DataMember(Name="waitlistedRequests", EmitDefaultValue=false)]
        public List<int?> WaitlistedRequests { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeOffLimitValues {\n");

            sb.Append("  LimitMinutes: ").Append(LimitMinutes).Append("\n");
            sb.Append("  AllocatedMinutes: ").Append(AllocatedMinutes).Append("\n");
            sb.Append("  WaitlistedMinutes: ").Append(WaitlistedMinutes).Append("\n");
            sb.Append("  WaitlistedRequests: ").Append(WaitlistedRequests).Append("\n");
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
            return this.Equals(obj as TimeOffLimitValues);
        }

        /// <summary>
        /// Returns true if TimeOffLimitValues instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeOffLimitValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeOffLimitValues other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.LimitMinutes == other.LimitMinutes ||
                    this.LimitMinutes != null &&
                    this.LimitMinutes.SequenceEqual(other.LimitMinutes)
                ) &&
                (
                    this.AllocatedMinutes == other.AllocatedMinutes ||
                    this.AllocatedMinutes != null &&
                    this.AllocatedMinutes.SequenceEqual(other.AllocatedMinutes)
                ) &&
                (
                    this.WaitlistedMinutes == other.WaitlistedMinutes ||
                    this.WaitlistedMinutes != null &&
                    this.WaitlistedMinutes.SequenceEqual(other.WaitlistedMinutes)
                ) &&
                (
                    this.WaitlistedRequests == other.WaitlistedRequests ||
                    this.WaitlistedRequests != null &&
                    this.WaitlistedRequests.SequenceEqual(other.WaitlistedRequests)
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
                if (this.LimitMinutes != null)
                    hash = hash * 59 + this.LimitMinutes.GetHashCode();

                if (this.AllocatedMinutes != null)
                    hash = hash * 59 + this.AllocatedMinutes.GetHashCode();

                if (this.WaitlistedMinutes != null)
                    hash = hash * 59 + this.WaitlistedMinutes.GetHashCode();

                if (this.WaitlistedRequests != null)
                    hash = hash * 59 + this.WaitlistedRequests.GetHashCode();

                return hash;
            }
        }
    }

}
