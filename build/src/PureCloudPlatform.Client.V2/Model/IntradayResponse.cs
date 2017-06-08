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
    /// IntradayResponse
    /// </summary>
    [DataContract]
    public partial class IntradayResponse :  IEquatable<IntradayResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// If not null, the reason there was no data for the request
        /// </summary>
        /// <value>If not null, the reason there was no data for the request</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NoDataReasonEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Noweekdata for "NoWeekData"
            /// </summary>
            [EnumMember(Value = "NoWeekData")]
            Noweekdata,
            
            /// <summary>
            /// Enum Nopublishedschedule for "NoPublishedSchedule"
            /// </summary>
            [EnumMember(Value = "NoPublishedSchedule")]
            Nopublishedschedule,
            
            /// <summary>
            /// Enum Nosourceforecast for "NoSourceForecast"
            /// </summary>
            [EnumMember(Value = "NoSourceForecast")]
            Nosourceforecast
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// If not null, the reason there was no data for the request
        /// </summary>
        /// <value>If not null, the reason there was no data for the request</value>
        [DataMember(Name="noDataReason", EmitDefaultValue=false)]
        public NoDataReasonEnum? NoDataReason { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntradayResponse" /> class.
        /// </summary>
        
        
        /// <param name="StartDate">The start of the date range for which this data applies.  This is also the start reference point for the intervals represented in the various arrays. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="EndDate">The end of the date range for which this data applies. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="IntervalLengthMinutes">The aggregation period in minutes, which determines the interval duration of the returned data.</param>
        
        
        
        /// <param name="NumberOfIntervals">The total number of time intervals represented by this data.</param>
        
        
        
        /// <param name="Metrics">The metrics to which this data corresponds.</param>
        
        
        
        /// <param name="NoDataReason">If not null, the reason there was no data for the request.</param>
        
        
        
        /// <param name="QueueIds">The IDs of the queues this data corresponds to.</param>
        
        
        
        /// <param name="IntradayDataGroupings">Intraday data grouped by a single media type and set of queue IDs.</param>
        
        
        public IntradayResponse(DateTime? StartDate = null, DateTime? EndDate = null, int? IntervalLengthMinutes = null, int? NumberOfIntervals = null, List<IntradayMetric> Metrics = null, NoDataReasonEnum? NoDataReason = null, List<string> QueueIds = null, List<IntradayDataGroup> IntradayDataGroupings = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.StartDate = StartDate;
            
            
            
            
            
            
            
            
this.EndDate = EndDate;
            
            
            
            
            
            
            
            
this.IntervalLengthMinutes = IntervalLengthMinutes;
            
            
            
            
            
            
            
            
this.NumberOfIntervals = NumberOfIntervals;
            
            
            
            
            
            
            
            
this.Metrics = Metrics;
            
            
            
            
            
            
            
            
this.NoDataReason = NoDataReason;
            
            
            
            
            
            
            
            
this.QueueIds = QueueIds;
            
            
            
            
            
            
            
            
this.IntradayDataGroupings = IntradayDataGroupings;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The start of the date range for which this data applies.  This is also the start reference point for the intervals represented in the various arrays. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The start of the date range for which this data applies.  This is also the start reference point for the intervals represented in the various arrays. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
        
        
        
        /// <summary>
        /// The end of the date range for which this data applies. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The end of the date range for which this data applies. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }
        
        
        
        /// <summary>
        /// The aggregation period in minutes, which determines the interval duration of the returned data
        /// </summary>
        /// <value>The aggregation period in minutes, which determines the interval duration of the returned data</value>
        [DataMember(Name="intervalLengthMinutes", EmitDefaultValue=false)]
        public int? IntervalLengthMinutes { get; set; }
        
        
        
        /// <summary>
        /// The total number of time intervals represented by this data
        /// </summary>
        /// <value>The total number of time intervals represented by this data</value>
        [DataMember(Name="numberOfIntervals", EmitDefaultValue=false)]
        public int? NumberOfIntervals { get; set; }
        
        
        
        /// <summary>
        /// The metrics to which this data corresponds
        /// </summary>
        /// <value>The metrics to which this data corresponds</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<IntradayMetric> Metrics { get; set; }
        
        
        
        
        
        /// <summary>
        /// The IDs of the queues this data corresponds to
        /// </summary>
        /// <value>The IDs of the queues this data corresponds to</value>
        [DataMember(Name="queueIds", EmitDefaultValue=false)]
        public List<string> QueueIds { get; set; }
        
        
        
        /// <summary>
        /// Intraday data grouped by a single media type and set of queue IDs
        /// </summary>
        /// <value>Intraday data grouped by a single media type and set of queue IDs</value>
        [DataMember(Name="intradayDataGroupings", EmitDefaultValue=false)]
        public List<IntradayDataGroup> IntradayDataGroupings { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntradayResponse {\n");
            
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            
            sb.Append("  IntervalLengthMinutes: ").Append(IntervalLengthMinutes).Append("\n");
            
            sb.Append("  NumberOfIntervals: ").Append(NumberOfIntervals).Append("\n");
            
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            
            sb.Append("  NoDataReason: ").Append(NoDataReason).Append("\n");
            
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
            return this.Equals(obj as IntradayResponse);
        }

        /// <summary>
        /// Returns true if IntradayResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of IntradayResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntradayResponse other)
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
                    this.NoDataReason == other.NoDataReason ||
                    this.NoDataReason != null &&
                    this.NoDataReason.Equals(other.NoDataReason)
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
                
                if (this.NoDataReason != null)
                    hash = hash * 59 + this.NoDataReason.GetHashCode();
                
                if (this.QueueIds != null)
                    hash = hash * 59 + this.QueueIds.GetHashCode();
                
                if (this.IntradayDataGroupings != null)
                    hash = hash * 59 + this.IntradayDataGroupings.GetHashCode();
                
                return hash;
            }
        }
    }

}
