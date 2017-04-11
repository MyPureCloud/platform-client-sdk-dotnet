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
    /// IntradayQueryDataCommand
    /// </summary>
    [DataContract]
    public partial class IntradayQueryDataCommand :  IEquatable<IntradayQueryDataCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntradayQueryDataCommand" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IntradayQueryDataCommand() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntradayQueryDataCommand" /> class.
        /// </summary>
        /// <param name="StartDate">Start date of the requested date range in ISO-8601 format (required).</param>
        /// <param name="EndDate">End date of the requested date range in ISO-8601 format.  Must be within the same 7 day schedule week as defined by the management unit&#39;s start day of week (required).</param>
        /// <param name="Metrics">The metrics to validate (required).</param>
        /// <param name="QueueIds">The queue IDs for which to fetch data.  Omitting or passing an empty list will return all available queues.</param>
        /// <param name="IntervalLengthMinutes">The period/interval for which to aggregate the data.  Optional, defaults to 15.</param>
        public IntradayQueryDataCommand(DateTime? StartDate = null, DateTime? EndDate = null, List<IntradayMetric> Metrics = null, List<string> QueueIds = null, int? IntervalLengthMinutes = null)
        {
            // to ensure "StartDate" is required (not null)
            if (StartDate == null)
            {
                throw new InvalidDataException("StartDate is a required property for IntradayQueryDataCommand and cannot be null");
            }
            else
            {
                this.StartDate = StartDate;
            }
            // to ensure "EndDate" is required (not null)
            if (EndDate == null)
            {
                throw new InvalidDataException("EndDate is a required property for IntradayQueryDataCommand and cannot be null");
            }
            else
            {
                this.EndDate = EndDate;
            }
            // to ensure "Metrics" is required (not null)
            if (Metrics == null)
            {
                throw new InvalidDataException("Metrics is a required property for IntradayQueryDataCommand and cannot be null");
            }
            else
            {
                this.Metrics = Metrics;
            }
            this.QueueIds = QueueIds;
            this.IntervalLengthMinutes = IntervalLengthMinutes;
        }
        
        /// <summary>
        /// Start date of the requested date range in ISO-8601 format
        /// </summary>
        /// <value>Start date of the requested date range in ISO-8601 format</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// End date of the requested date range in ISO-8601 format.  Must be within the same 7 day schedule week as defined by the management unit&#39;s start day of week
        /// </summary>
        /// <value>End date of the requested date range in ISO-8601 format.  Must be within the same 7 day schedule week as defined by the management unit&#39;s start day of week</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// The metrics to validate
        /// </summary>
        /// <value>The metrics to validate</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<IntradayMetric> Metrics { get; set; }
        /// <summary>
        /// The queue IDs for which to fetch data.  Omitting or passing an empty list will return all available queues
        /// </summary>
        /// <value>The queue IDs for which to fetch data.  Omitting or passing an empty list will return all available queues</value>
        [DataMember(Name="queueIds", EmitDefaultValue=false)]
        public List<string> QueueIds { get; set; }
        /// <summary>
        /// The period/interval for which to aggregate the data.  Optional, defaults to 15
        /// </summary>
        /// <value>The period/interval for which to aggregate the data.  Optional, defaults to 15</value>
        [DataMember(Name="intervalLengthMinutes", EmitDefaultValue=false)]
        public int? IntervalLengthMinutes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntradayQueryDataCommand {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  QueueIds: ").Append(QueueIds).Append("\n");
            sb.Append("  IntervalLengthMinutes: ").Append(IntervalLengthMinutes).Append("\n");
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
            return this.Equals(obj as IntradayQueryDataCommand);
        }

        /// <summary>
        /// Returns true if IntradayQueryDataCommand instances are equal
        /// </summary>
        /// <param name="other">Instance of IntradayQueryDataCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntradayQueryDataCommand other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) &&
                (
                    this.Metrics == other.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(other.Metrics)
                ) &&
                (
                    this.QueueIds == other.QueueIds ||
                    this.QueueIds != null &&
                    this.QueueIds.SequenceEqual(other.QueueIds)
                ) &&
                (
                    this.IntervalLengthMinutes == other.IntervalLengthMinutes ||
                    this.IntervalLengthMinutes != null &&
                    this.IntervalLengthMinutes.Equals(other.IntervalLengthMinutes)
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
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();
                if (this.QueueIds != null)
                    hash = hash * 59 + this.QueueIds.GetHashCode();
                if (this.IntervalLengthMinutes != null)
                    hash = hash * 59 + this.IntervalLengthMinutes.GetHashCode();
                return hash;
            }
        }
    }

}
