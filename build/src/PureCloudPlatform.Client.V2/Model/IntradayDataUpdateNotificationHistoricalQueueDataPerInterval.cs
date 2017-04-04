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
    /// IntradayDataUpdateNotificationHistoricalQueueDataPerInterval
    /// </summary>
    [DataContract]
    public partial class IntradayDataUpdateNotificationHistoricalQueueDataPerInterval :  IEquatable<IntradayDataUpdateNotificationHistoricalQueueDataPerInterval>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntradayDataUpdateNotificationHistoricalQueueDataPerInterval" /> class.
        /// </summary>
        /// <param name="Offered">Offered.</param>
        /// <param name="Completed">Completed.</param>
        /// <param name="Answered">Answered.</param>
        /// <param name="Abandoned">Abandoned.</param>
        /// <param name="AverageTalkTimeSeconds">AverageTalkTimeSeconds.</param>
        /// <param name="AverageAfterCallWorkSeconds">AverageAfterCallWorkSeconds.</param>
        /// <param name="ServiceLevelPercent">ServiceLevelPercent.</param>
        /// <param name="AverageSpeedOfAnswerSeconds">AverageSpeedOfAnswerSeconds.</param>
        public IntradayDataUpdateNotificationHistoricalQueueDataPerInterval(int? Offered = null, int? Completed = null, int? Answered = null, int? Abandoned = null, double? AverageTalkTimeSeconds = null, double? AverageAfterCallWorkSeconds = null, double? ServiceLevelPercent = null, double? AverageSpeedOfAnswerSeconds = null)
        {
            this.Offered = Offered;
            this.Completed = Completed;
            this.Answered = Answered;
            this.Abandoned = Abandoned;
            this.AverageTalkTimeSeconds = AverageTalkTimeSeconds;
            this.AverageAfterCallWorkSeconds = AverageAfterCallWorkSeconds;
            this.ServiceLevelPercent = ServiceLevelPercent;
            this.AverageSpeedOfAnswerSeconds = AverageSpeedOfAnswerSeconds;
        }
        
        /// <summary>
        /// Gets or Sets Offered
        /// </summary>
        [DataMember(Name="offered", EmitDefaultValue=false)]
        public int? Offered { get; set; }
        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name="completed", EmitDefaultValue=false)]
        public int? Completed { get; set; }
        /// <summary>
        /// Gets or Sets Answered
        /// </summary>
        [DataMember(Name="answered", EmitDefaultValue=false)]
        public int? Answered { get; set; }
        /// <summary>
        /// Gets or Sets Abandoned
        /// </summary>
        [DataMember(Name="abandoned", EmitDefaultValue=false)]
        public int? Abandoned { get; set; }
        /// <summary>
        /// Gets or Sets AverageTalkTimeSeconds
        /// </summary>
        [DataMember(Name="averageTalkTimeSeconds", EmitDefaultValue=false)]
        public double? AverageTalkTimeSeconds { get; set; }
        /// <summary>
        /// Gets or Sets AverageAfterCallWorkSeconds
        /// </summary>
        [DataMember(Name="averageAfterCallWorkSeconds", EmitDefaultValue=false)]
        public double? AverageAfterCallWorkSeconds { get; set; }
        /// <summary>
        /// Gets or Sets ServiceLevelPercent
        /// </summary>
        [DataMember(Name="serviceLevelPercent", EmitDefaultValue=false)]
        public double? ServiceLevelPercent { get; set; }
        /// <summary>
        /// Gets or Sets AverageSpeedOfAnswerSeconds
        /// </summary>
        [DataMember(Name="averageSpeedOfAnswerSeconds", EmitDefaultValue=false)]
        public double? AverageSpeedOfAnswerSeconds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntradayDataUpdateNotificationHistoricalQueueDataPerInterval {\n");
            sb.Append("  Offered: ").Append(Offered).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  Answered: ").Append(Answered).Append("\n");
            sb.Append("  Abandoned: ").Append(Abandoned).Append("\n");
            sb.Append("  AverageTalkTimeSeconds: ").Append(AverageTalkTimeSeconds).Append("\n");
            sb.Append("  AverageAfterCallWorkSeconds: ").Append(AverageAfterCallWorkSeconds).Append("\n");
            sb.Append("  ServiceLevelPercent: ").Append(ServiceLevelPercent).Append("\n");
            sb.Append("  AverageSpeedOfAnswerSeconds: ").Append(AverageSpeedOfAnswerSeconds).Append("\n");
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
            return this.Equals(obj as IntradayDataUpdateNotificationHistoricalQueueDataPerInterval);
        }

        /// <summary>
        /// Returns true if IntradayDataUpdateNotificationHistoricalQueueDataPerInterval instances are equal
        /// </summary>
        /// <param name="other">Instance of IntradayDataUpdateNotificationHistoricalQueueDataPerInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntradayDataUpdateNotificationHistoricalQueueDataPerInterval other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Offered == other.Offered ||
                    this.Offered != null &&
                    this.Offered.Equals(other.Offered)
                ) &&
                (
                    this.Completed == other.Completed ||
                    this.Completed != null &&
                    this.Completed.Equals(other.Completed)
                ) &&
                (
                    this.Answered == other.Answered ||
                    this.Answered != null &&
                    this.Answered.Equals(other.Answered)
                ) &&
                (
                    this.Abandoned == other.Abandoned ||
                    this.Abandoned != null &&
                    this.Abandoned.Equals(other.Abandoned)
                ) &&
                (
                    this.AverageTalkTimeSeconds == other.AverageTalkTimeSeconds ||
                    this.AverageTalkTimeSeconds != null &&
                    this.AverageTalkTimeSeconds.Equals(other.AverageTalkTimeSeconds)
                ) &&
                (
                    this.AverageAfterCallWorkSeconds == other.AverageAfterCallWorkSeconds ||
                    this.AverageAfterCallWorkSeconds != null &&
                    this.AverageAfterCallWorkSeconds.Equals(other.AverageAfterCallWorkSeconds)
                ) &&
                (
                    this.ServiceLevelPercent == other.ServiceLevelPercent ||
                    this.ServiceLevelPercent != null &&
                    this.ServiceLevelPercent.Equals(other.ServiceLevelPercent)
                ) &&
                (
                    this.AverageSpeedOfAnswerSeconds == other.AverageSpeedOfAnswerSeconds ||
                    this.AverageSpeedOfAnswerSeconds != null &&
                    this.AverageSpeedOfAnswerSeconds.Equals(other.AverageSpeedOfAnswerSeconds)
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
                if (this.Offered != null)
                    hash = hash * 59 + this.Offered.GetHashCode();
                if (this.Completed != null)
                    hash = hash * 59 + this.Completed.GetHashCode();
                if (this.Answered != null)
                    hash = hash * 59 + this.Answered.GetHashCode();
                if (this.Abandoned != null)
                    hash = hash * 59 + this.Abandoned.GetHashCode();
                if (this.AverageTalkTimeSeconds != null)
                    hash = hash * 59 + this.AverageTalkTimeSeconds.GetHashCode();
                if (this.AverageAfterCallWorkSeconds != null)
                    hash = hash * 59 + this.AverageAfterCallWorkSeconds.GetHashCode();
                if (this.ServiceLevelPercent != null)
                    hash = hash * 59 + this.ServiceLevelPercent.GetHashCode();
                if (this.AverageSpeedOfAnswerSeconds != null)
                    hash = hash * 59 + this.AverageSpeedOfAnswerSeconds.GetHashCode();
                return hash;
            }
        }
    }

}
