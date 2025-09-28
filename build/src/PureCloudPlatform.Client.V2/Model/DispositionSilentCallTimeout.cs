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
    /// DispositionSilentCallTimeout
    /// </summary>
    [DataContract]
    public partial class DispositionSilentCallTimeout :  IEquatable<DispositionSilentCallTimeout>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DispositionSilentCallTimeout" /> class.
        /// </summary>
        /// <param name="TimeoutMs">Configured silent call timeout value..</param>
        /// <param name="TimerStartTime">Timer start time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="TimerEndTime">Timer end time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public DispositionSilentCallTimeout(int? TimeoutMs = null, DateTime? TimerStartTime = null, DateTime? TimerEndTime = null)
        {
            this.TimeoutMs = TimeoutMs;
            this.TimerStartTime = TimerStartTime;
            this.TimerEndTime = TimerEndTime;
            
        }
        


        /// <summary>
        /// Configured silent call timeout value.
        /// </summary>
        /// <value>Configured silent call timeout value.</value>
        [DataMember(Name="timeoutMs", EmitDefaultValue=false)]
        public int? TimeoutMs { get; set; }



        /// <summary>
        /// Timer start time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timer start time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="timerStartTime", EmitDefaultValue=false)]
        public DateTime? TimerStartTime { get; set; }



        /// <summary>
        /// Timer end time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timer end time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="timerEndTime", EmitDefaultValue=false)]
        public DateTime? TimerEndTime { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DispositionSilentCallTimeout {\n");

            sb.Append("  TimeoutMs: ").Append(TimeoutMs).Append("\n");
            sb.Append("  TimerStartTime: ").Append(TimerStartTime).Append("\n");
            sb.Append("  TimerEndTime: ").Append(TimerEndTime).Append("\n");
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
            return this.Equals(obj as DispositionSilentCallTimeout);
        }

        /// <summary>
        /// Returns true if DispositionSilentCallTimeout instances are equal
        /// </summary>
        /// <param name="other">Instance of DispositionSilentCallTimeout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DispositionSilentCallTimeout other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TimeoutMs == other.TimeoutMs ||
                    this.TimeoutMs != null &&
                    this.TimeoutMs.Equals(other.TimeoutMs)
                ) &&
                (
                    this.TimerStartTime == other.TimerStartTime ||
                    this.TimerStartTime != null &&
                    this.TimerStartTime.Equals(other.TimerStartTime)
                ) &&
                (
                    this.TimerEndTime == other.TimerEndTime ||
                    this.TimerEndTime != null &&
                    this.TimerEndTime.Equals(other.TimerEndTime)
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
                if (this.TimeoutMs != null)
                    hash = hash * 59 + this.TimeoutMs.GetHashCode();

                if (this.TimerStartTime != null)
                    hash = hash * 59 + this.TimerStartTime.GetHashCode();

                if (this.TimerEndTime != null)
                    hash = hash * 59 + this.TimerEndTime.GetHashCode();

                return hash;
            }
        }
    }

}
