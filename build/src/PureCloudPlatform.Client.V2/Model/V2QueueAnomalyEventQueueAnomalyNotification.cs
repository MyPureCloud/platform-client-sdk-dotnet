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
    /// V2QueueAnomalyEventQueueAnomalyNotification
    /// </summary>
    [DataContract]
    public partial class V2QueueAnomalyEventQueueAnomalyNotification :  IEquatable<V2QueueAnomalyEventQueueAnomalyNotification>
    {
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message,
            
            /// <summary>
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice
        }
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2QueueAnomalyEventQueueAnomalyNotification" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Queue">Queue.</param>
        /// <param name="MediaType">MediaType.</param>
        /// <param name="Division">Division.</param>
        /// <param name="FalsePositive">FalsePositive.</param>
        /// <param name="Metric">Metric.</param>
        /// <param name="DateAnomalyDetected">DateAnomalyDetected.</param>
        /// <param name="DateIntervalStart">DateIntervalStart.</param>
        /// <param name="DateIntervalEnd">DateIntervalEnd.</param>
        /// <param name="ConsensusAnalyses">ConsensusAnalyses.</param>
        /// <param name="AnomalyScorePercent">AnomalyScorePercent.</param>
        /// <param name="DetectedValue">DetectedValue.</param>
        /// <param name="LowerBound">LowerBound.</param>
        /// <param name="UpperBound">UpperBound.</param>
        /// <param name="ExpectedValue">ExpectedValue.</param>
        /// <param name="Deviation">Deviation.</param>
        /// <param name="DateExpires">DateExpires.</param>
        /// <param name="DateModified">DateModified.</param>
        public V2QueueAnomalyEventQueueAnomalyNotification(string Id = null, V2QueueAnomalyEventQueueReference Queue = null, MediaTypeEnum? MediaType = null, V2QueueAnomalyEventDivisionReference Division = null, bool? FalsePositive = null, string Metric = null, DateTime? DateAnomalyDetected = null, DateTime? DateIntervalStart = null, DateTime? DateIntervalEnd = null, List<V2QueueAnomalyEventConsensusAnalysis> ConsensusAnalyses = null, double? AnomalyScorePercent = null, double? DetectedValue = null, double? LowerBound = null, double? UpperBound = null, double? ExpectedValue = null, double? Deviation = null, DateTime? DateExpires = null, DateTime? DateModified = null)
        {
            this.Id = Id;
            this.Queue = Queue;
            this.MediaType = MediaType;
            this.Division = Division;
            this.FalsePositive = FalsePositive;
            this.Metric = Metric;
            this.DateAnomalyDetected = DateAnomalyDetected;
            this.DateIntervalStart = DateIntervalStart;
            this.DateIntervalEnd = DateIntervalEnd;
            this.ConsensusAnalyses = ConsensusAnalyses;
            this.AnomalyScorePercent = AnomalyScorePercent;
            this.DetectedValue = DetectedValue;
            this.LowerBound = LowerBound;
            this.UpperBound = UpperBound;
            this.ExpectedValue = ExpectedValue;
            this.Deviation = Deviation;
            this.DateExpires = DateExpires;
            this.DateModified = DateModified;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public V2QueueAnomalyEventQueueReference Queue { get; set; }





        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public V2QueueAnomalyEventDivisionReference Division { get; set; }



        /// <summary>
        /// Gets or Sets FalsePositive
        /// </summary>
        [DataMember(Name="falsePositive", EmitDefaultValue=false)]
        public bool? FalsePositive { get; set; }



        /// <summary>
        /// Gets or Sets Metric
        /// </summary>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public string Metric { get; set; }



        /// <summary>
        /// Gets or Sets DateAnomalyDetected
        /// </summary>
        [DataMember(Name="dateAnomalyDetected", EmitDefaultValue=false)]
        public DateTime? DateAnomalyDetected { get; set; }



        /// <summary>
        /// Gets or Sets DateIntervalStart
        /// </summary>
        [DataMember(Name="dateIntervalStart", EmitDefaultValue=false)]
        public DateTime? DateIntervalStart { get; set; }



        /// <summary>
        /// Gets or Sets DateIntervalEnd
        /// </summary>
        [DataMember(Name="dateIntervalEnd", EmitDefaultValue=false)]
        public DateTime? DateIntervalEnd { get; set; }



        /// <summary>
        /// Gets or Sets ConsensusAnalyses
        /// </summary>
        [DataMember(Name="consensusAnalyses", EmitDefaultValue=false)]
        public List<V2QueueAnomalyEventConsensusAnalysis> ConsensusAnalyses { get; set; }



        /// <summary>
        /// Gets or Sets AnomalyScorePercent
        /// </summary>
        [DataMember(Name="anomalyScorePercent", EmitDefaultValue=false)]
        public double? AnomalyScorePercent { get; set; }



        /// <summary>
        /// Gets or Sets DetectedValue
        /// </summary>
        [DataMember(Name="detectedValue", EmitDefaultValue=false)]
        public double? DetectedValue { get; set; }



        /// <summary>
        /// Gets or Sets LowerBound
        /// </summary>
        [DataMember(Name="lowerBound", EmitDefaultValue=false)]
        public double? LowerBound { get; set; }



        /// <summary>
        /// Gets or Sets UpperBound
        /// </summary>
        [DataMember(Name="upperBound", EmitDefaultValue=false)]
        public double? UpperBound { get; set; }



        /// <summary>
        /// Gets or Sets ExpectedValue
        /// </summary>
        [DataMember(Name="expectedValue", EmitDefaultValue=false)]
        public double? ExpectedValue { get; set; }



        /// <summary>
        /// Gets or Sets Deviation
        /// </summary>
        [DataMember(Name="deviation", EmitDefaultValue=false)]
        public double? Deviation { get; set; }



        /// <summary>
        /// Gets or Sets DateExpires
        /// </summary>
        [DataMember(Name="dateExpires", EmitDefaultValue=false)]
        public DateTime? DateExpires { get; set; }



        /// <summary>
        /// Gets or Sets DateModified
        /// </summary>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2QueueAnomalyEventQueueAnomalyNotification {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  FalsePositive: ").Append(FalsePositive).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  DateAnomalyDetected: ").Append(DateAnomalyDetected).Append("\n");
            sb.Append("  DateIntervalStart: ").Append(DateIntervalStart).Append("\n");
            sb.Append("  DateIntervalEnd: ").Append(DateIntervalEnd).Append("\n");
            sb.Append("  ConsensusAnalyses: ").Append(ConsensusAnalyses).Append("\n");
            sb.Append("  AnomalyScorePercent: ").Append(AnomalyScorePercent).Append("\n");
            sb.Append("  DetectedValue: ").Append(DetectedValue).Append("\n");
            sb.Append("  LowerBound: ").Append(LowerBound).Append("\n");
            sb.Append("  UpperBound: ").Append(UpperBound).Append("\n");
            sb.Append("  ExpectedValue: ").Append(ExpectedValue).Append("\n");
            sb.Append("  Deviation: ").Append(Deviation).Append("\n");
            sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
            return this.Equals(obj as V2QueueAnomalyEventQueueAnomalyNotification);
        }

        /// <summary>
        /// Returns true if V2QueueAnomalyEventQueueAnomalyNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of V2QueueAnomalyEventQueueAnomalyNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2QueueAnomalyEventQueueAnomalyNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.FalsePositive == other.FalsePositive ||
                    this.FalsePositive != null &&
                    this.FalsePositive.Equals(other.FalsePositive)
                ) &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this.DateAnomalyDetected == other.DateAnomalyDetected ||
                    this.DateAnomalyDetected != null &&
                    this.DateAnomalyDetected.Equals(other.DateAnomalyDetected)
                ) &&
                (
                    this.DateIntervalStart == other.DateIntervalStart ||
                    this.DateIntervalStart != null &&
                    this.DateIntervalStart.Equals(other.DateIntervalStart)
                ) &&
                (
                    this.DateIntervalEnd == other.DateIntervalEnd ||
                    this.DateIntervalEnd != null &&
                    this.DateIntervalEnd.Equals(other.DateIntervalEnd)
                ) &&
                (
                    this.ConsensusAnalyses == other.ConsensusAnalyses ||
                    this.ConsensusAnalyses != null &&
                    this.ConsensusAnalyses.SequenceEqual(other.ConsensusAnalyses)
                ) &&
                (
                    this.AnomalyScorePercent == other.AnomalyScorePercent ||
                    this.AnomalyScorePercent != null &&
                    this.AnomalyScorePercent.Equals(other.AnomalyScorePercent)
                ) &&
                (
                    this.DetectedValue == other.DetectedValue ||
                    this.DetectedValue != null &&
                    this.DetectedValue.Equals(other.DetectedValue)
                ) &&
                (
                    this.LowerBound == other.LowerBound ||
                    this.LowerBound != null &&
                    this.LowerBound.Equals(other.LowerBound)
                ) &&
                (
                    this.UpperBound == other.UpperBound ||
                    this.UpperBound != null &&
                    this.UpperBound.Equals(other.UpperBound)
                ) &&
                (
                    this.ExpectedValue == other.ExpectedValue ||
                    this.ExpectedValue != null &&
                    this.ExpectedValue.Equals(other.ExpectedValue)
                ) &&
                (
                    this.Deviation == other.Deviation ||
                    this.Deviation != null &&
                    this.Deviation.Equals(other.Deviation)
                ) &&
                (
                    this.DateExpires == other.DateExpires ||
                    this.DateExpires != null &&
                    this.DateExpires.Equals(other.DateExpires)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.FalsePositive != null)
                    hash = hash * 59 + this.FalsePositive.GetHashCode();

                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();

                if (this.DateAnomalyDetected != null)
                    hash = hash * 59 + this.DateAnomalyDetected.GetHashCode();

                if (this.DateIntervalStart != null)
                    hash = hash * 59 + this.DateIntervalStart.GetHashCode();

                if (this.DateIntervalEnd != null)
                    hash = hash * 59 + this.DateIntervalEnd.GetHashCode();

                if (this.ConsensusAnalyses != null)
                    hash = hash * 59 + this.ConsensusAnalyses.GetHashCode();

                if (this.AnomalyScorePercent != null)
                    hash = hash * 59 + this.AnomalyScorePercent.GetHashCode();

                if (this.DetectedValue != null)
                    hash = hash * 59 + this.DetectedValue.GetHashCode();

                if (this.LowerBound != null)
                    hash = hash * 59 + this.LowerBound.GetHashCode();

                if (this.UpperBound != null)
                    hash = hash * 59 + this.UpperBound.GetHashCode();

                if (this.ExpectedValue != null)
                    hash = hash * 59 + this.ExpectedValue.GetHashCode();

                if (this.Deviation != null)
                    hash = hash * 59 + this.Deviation.GetHashCode();

                if (this.DateExpires != null)
                    hash = hash * 59 + this.DateExpires.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                return hash;
            }
        }
    }

}
