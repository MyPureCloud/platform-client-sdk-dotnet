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
    /// LearningAssignmentAggregateParam
    /// </summary>
    [DataContract]
    public partial class LearningAssignmentAggregateParam :  IEquatable<LearningAssignmentAggregateParam>
    {
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Metrics
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MetricsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Nactivities for "nActivities"
            /// </summary>
            [EnumMember(Value = "nActivities")]
            Nactivities,
            
            /// <summary>
            /// Enum Nplannedactivities for "nPlannedActivities"
            /// </summary>
            [EnumMember(Value = "nPlannedActivities")]
            Nplannedactivities,
            
            /// <summary>
            /// Enum Ninprogressactivities for "nInProgressActivities"
            /// </summary>
            [EnumMember(Value = "nInProgressActivities")]
            Ninprogressactivities,
            
            /// <summary>
            /// Enum Ncompleteactivities for "nCompleteActivities"
            /// </summary>
            [EnumMember(Value = "nCompleteActivities")]
            Ncompleteactivities,
            
            /// <summary>
            /// Enum Noverdueactivities for "nOverdueActivities"
            /// </summary>
            [EnumMember(Value = "nOverdueActivities")]
            Noverdueactivities,
            
            /// <summary>
            /// Enum Npassedactivities for "nPassedActivities"
            /// </summary>
            [EnumMember(Value = "nPassedActivities")]
            Npassedactivities,
            
            /// <summary>
            /// Enum Nfailedactivities for "nFailedActivities"
            /// </summary>
            [EnumMember(Value = "nFailedActivities")]
            Nfailedactivities,
            
            /// <summary>
            /// Enum Oactivityscore for "oActivityScore"
            /// </summary>
            [EnumMember(Value = "oActivityScore")]
            Oactivityscore
        }
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets GroupBy
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum GroupByEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Attendeeid for "attendeeId"
            /// </summary>
            [EnumMember(Value = "attendeeId")]
            Attendeeid
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningAssignmentAggregateParam" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LearningAssignmentAggregateParam() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningAssignmentAggregateParam" /> class.
        /// </summary>
        /// <param name="Interval">Specifies the range of due dates to be used for filtering. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
        /// <param name="Metrics">The list of metrics to be returned. If omitted, all metrics are returned..</param>
        /// <param name="GroupBy">Specifies if the aggregated data is combined into a single set of metrics (groupBy is empty or not specified), or contains an element per attendeeId (groupBy is \&quot;attendeeId\&quot;).</param>
        /// <param name="Filter">The filter applied to the data.  This is ANDed with the interval parameter.  (required).</param>
        public LearningAssignmentAggregateParam(string Interval = null, List<MetricsEnum> Metrics = null, List<GroupByEnum> GroupBy = null, LearningAssignmentAggregateQueryRequestFilter Filter = null)
        {
            this.Interval = Interval;
            this.Metrics = Metrics;
            this.GroupBy = GroupBy;
            this.Filter = Filter;
            
        }
        
        
        
        /// <summary>
        /// Specifies the range of due dates to be used for filtering. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>Specifies the range of due dates to be used for filtering. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }
        
        
        
        /// <summary>
        /// The list of metrics to be returned. If omitted, all metrics are returned.
        /// </summary>
        /// <value>The list of metrics to be returned. If omitted, all metrics are returned.</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<MetricsEnum> Metrics { get; set; }
        
        
        
        /// <summary>
        /// Specifies if the aggregated data is combined into a single set of metrics (groupBy is empty or not specified), or contains an element per attendeeId (groupBy is \&quot;attendeeId\&quot;)
        /// </summary>
        /// <value>Specifies if the aggregated data is combined into a single set of metrics (groupBy is empty or not specified), or contains an element per attendeeId (groupBy is \&quot;attendeeId\&quot;)</value>
        [DataMember(Name="groupBy", EmitDefaultValue=false)]
        public List<GroupByEnum> GroupBy { get; set; }
        
        
        
        /// <summary>
        /// The filter applied to the data.  This is ANDed with the interval parameter. 
        /// </summary>
        /// <value>The filter applied to the data.  This is ANDed with the interval parameter. </value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public LearningAssignmentAggregateQueryRequestFilter Filter { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningAssignmentAggregateParam {\n");
            
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
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
            return this.Equals(obj as LearningAssignmentAggregateParam);
        }

        /// <summary>
        /// Returns true if LearningAssignmentAggregateParam instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningAssignmentAggregateParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningAssignmentAggregateParam other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) &&
                (
                    this.Metrics == other.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(other.Metrics)
                ) &&
                (
                    this.GroupBy == other.GroupBy ||
                    this.GroupBy != null &&
                    this.GroupBy.SequenceEqual(other.GroupBy)
                ) &&
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
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
                
                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();
                
                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();
                
                if (this.GroupBy != null)
                    hash = hash * 59 + this.GroupBy.GetHashCode();
                
                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();
                
                return hash;
            }
        }
    }

}
