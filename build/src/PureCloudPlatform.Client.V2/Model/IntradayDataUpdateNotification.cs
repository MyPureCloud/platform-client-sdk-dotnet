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
    /// IntradayDataUpdateNotification
    /// </summary>
    [DataContract]
    public partial class IntradayDataUpdateNotification :  IEquatable<IntradayDataUpdateNotification>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntradayDataUpdateNotification" /> class.
        /// </summary>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="IntervalLengthMinutes">IntervalLengthMinutes.</param>
        /// <param name="NumberOfIntervals">NumberOfIntervals.</param>
        /// <param name="Metrics">Metrics.</param>
        /// <param name="QueueIds">QueueIds.</param>
        /// <param name="IntradayDataGroupings">IntradayDataGroupings.</param>
        public IntradayDataUpdateNotification(IntradayDataUpdateNotificationStartDate StartDate = null, IntradayDataUpdateNotificationDateTime EndDate = null, int? IntervalLengthMinutes = null, int? NumberOfIntervals = null, List<IntradayDataUpdateNotificationMetrics> Metrics = null, List<string> QueueIds = null, List<IntradayDataUpdateNotificationIntradayDataGroupings> IntradayDataGroupings = null)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.IntervalLengthMinutes = IntervalLengthMinutes;
            this.NumberOfIntervals = NumberOfIntervals;
            this.Metrics = Metrics;
            this.QueueIds = QueueIds;
            this.IntradayDataGroupings = IntradayDataGroupings;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public IntradayDataUpdateNotificationStartDate StartDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public IntradayDataUpdateNotificationDateTime EndDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets IntervalLengthMinutes
        /// </summary>
        [DataMember(Name="intervalLengthMinutes", EmitDefaultValue=false)]
        public int? IntervalLengthMinutes { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets NumberOfIntervals
        /// </summary>
        [DataMember(Name="numberOfIntervals", EmitDefaultValue=false)]
        public int? NumberOfIntervals { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Metrics
        /// </summary>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<IntradayDataUpdateNotificationMetrics> Metrics { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets QueueIds
        /// </summary>
        [DataMember(Name="queueIds", EmitDefaultValue=false)]
        public List<string> QueueIds { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets IntradayDataGroupings
        /// </summary>
        [DataMember(Name="intradayDataGroupings", EmitDefaultValue=false)]
        public List<IntradayDataUpdateNotificationIntradayDataGroupings> IntradayDataGroupings { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntradayDataUpdateNotification {\n");
            
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  IntervalLengthMinutes: ").Append(IntervalLengthMinutes).Append("\n");
            sb.Append("  NumberOfIntervals: ").Append(NumberOfIntervals).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  QueueIds: ").Append(QueueIds).Append("\n");
            sb.Append("  IntradayDataGroupings: ").Append(IntradayDataGroupings).Append("\n");
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
            return this.Equals(obj as IntradayDataUpdateNotification);
        }

        /// <summary>
        /// Returns true if IntradayDataUpdateNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of IntradayDataUpdateNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntradayDataUpdateNotification other)
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
                    this.IntervalLengthMinutes == other.IntervalLengthMinutes ||
                    this.IntervalLengthMinutes != null &&
                    this.IntervalLengthMinutes.Equals(other.IntervalLengthMinutes)
                ) &&
                (
                    this.NumberOfIntervals == other.NumberOfIntervals ||
                    this.NumberOfIntervals != null &&
                    this.NumberOfIntervals.Equals(other.NumberOfIntervals)
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
                    this.IntradayDataGroupings == other.IntradayDataGroupings ||
                    this.IntradayDataGroupings != null &&
                    this.IntradayDataGroupings.SequenceEqual(other.IntradayDataGroupings)
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
                
                if (this.IntervalLengthMinutes != null)
                    hash = hash * 59 + this.IntervalLengthMinutes.GetHashCode();
                
                if (this.NumberOfIntervals != null)
                    hash = hash * 59 + this.NumberOfIntervals.GetHashCode();
                
                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();
                
                if (this.QueueIds != null)
                    hash = hash * 59 + this.QueueIds.GetHashCode();
                
                if (this.IntradayDataGroupings != null)
                    hash = hash * 59 + this.IntradayDataGroupings.GetHashCode();
                
                return hash;
            }
        }
    }

}
