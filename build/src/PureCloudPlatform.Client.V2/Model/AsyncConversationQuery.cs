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
    /// AsyncConversationQuery
    /// </summary>
    [DataContract]
    public partial class AsyncConversationQuery :  IEquatable<AsyncConversationQuery>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Sort the result set in ascending/descending order. Default is ascending
        /// </summary>
        /// <value>Sort the result set in ascending/descending order. Default is ascending</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OrderEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Asc for "asc"
            /// </summary>
            [EnumMember(Value = "asc")]
            Asc,
            
            /// <summary>
            /// Enum Desc for "desc"
            /// </summary>
            [EnumMember(Value = "desc")]
            Desc
        }
        
        
        
        
        /// <summary>
        /// Specify which data element within the result set to use for sorting. The options  to use as a basis for sorting the results: conversationStart, segmentStart, and segmentEnd. If not specified, the default is conversationStart
        /// </summary>
        /// <value>Specify which data element within the result set to use for sorting. The options  to use as a basis for sorting the results: conversationStart, segmentStart, and segmentEnd. If not specified, the default is conversationStart</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OrderByEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Conversationstart for "conversationStart"
            /// </summary>
            [EnumMember(Value = "conversationStart")]
            Conversationstart,
            
            /// <summary>
            /// Enum Conversationend for "conversationEnd"
            /// </summary>
            [EnumMember(Value = "conversationEnd")]
            Conversationend,
            
            /// <summary>
            /// Enum Segmentstart for "segmentStart"
            /// </summary>
            [EnumMember(Value = "segmentStart")]
            Segmentstart,
            
            /// <summary>
            /// Enum Segmentend for "segmentEnd"
            /// </summary>
            [EnumMember(Value = "segmentEnd")]
            Segmentend
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Sort the result set in ascending/descending order. Default is ascending
        /// </summary>
        /// <value>Sort the result set in ascending/descending order. Default is ascending</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public OrderEnum? Order { get; set; }
        
        
        
        /// <summary>
        /// Specify which data element within the result set to use for sorting. The options  to use as a basis for sorting the results: conversationStart, segmentStart, and segmentEnd. If not specified, the default is conversationStart
        /// </summary>
        /// <value>Specify which data element within the result set to use for sorting. The options  to use as a basis for sorting the results: conversationStart, segmentStart, and segmentEnd. If not specified, the default is conversationStart</value>
        [DataMember(Name="orderBy", EmitDefaultValue=false)]
        public OrderByEnum? OrderBy { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncConversationQuery" /> class.
        /// </summary>
        /// <param name="Interval">Specifies the date and time range of data being queried. Results will include conversations that both started on a day touched by the interval AND either started, ended, or any activity during the interval. Conversations that started before the earliest day of the interval will not be searched. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
        /// <param name="ConversationFilters">Filters that target conversation-level data.</param>
        /// <param name="EvaluationFilters">Filters that target quality management evaluation-level data.</param>
        /// <param name="SurveyFilters">Filters that target quality management survey-level data.</param>
        /// <param name="MediaEndpointStatFilters">Filters that target call quality of service data.</param>
        /// <param name="SegmentFilters">Filters that target individual segments within a conversation.</param>
        /// <param name="Order">Sort the result set in ascending/descending order. Default is ascending.</param>
        /// <param name="OrderBy">Specify which data element within the result set to use for sorting. The options  to use as a basis for sorting the results: conversationStart, segmentStart, and segmentEnd. If not specified, the default is conversationStart.</param>
        /// <param name="Limit">Specify number of results to be returned.</param>
        public AsyncConversationQuery(string Interval = null, List<AnalyticsQueryFilter> ConversationFilters = null, List<AnalyticsQueryFilter> EvaluationFilters = null, List<AnalyticsQueryFilter> SurveyFilters = null, List<AnalyticsQueryFilter> MediaEndpointStatFilters = null, List<AnalyticsQueryFilter> SegmentFilters = null, OrderEnum? Order = null, OrderByEnum? OrderBy = null, int? Limit = null)
        {
            this.Interval = Interval;
            this.ConversationFilters = ConversationFilters;
            this.EvaluationFilters = EvaluationFilters;
            this.SurveyFilters = SurveyFilters;
            this.MediaEndpointStatFilters = MediaEndpointStatFilters;
            this.SegmentFilters = SegmentFilters;
            this.Order = Order;
            this.OrderBy = OrderBy;
            this.Limit = Limit;
            
        }
        
        
        
        /// <summary>
        /// Specifies the date and time range of data being queried. Results will include conversations that both started on a day touched by the interval AND either started, ended, or any activity during the interval. Conversations that started before the earliest day of the interval will not be searched. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>Specifies the date and time range of data being queried. Results will include conversations that both started on a day touched by the interval AND either started, ended, or any activity during the interval. Conversations that started before the earliest day of the interval will not be searched. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }
        
        
        
        /// <summary>
        /// Filters that target conversation-level data
        /// </summary>
        /// <value>Filters that target conversation-level data</value>
        [DataMember(Name="conversationFilters", EmitDefaultValue=false)]
        public List<AnalyticsQueryFilter> ConversationFilters { get; set; }
        
        
        
        /// <summary>
        /// Filters that target quality management evaluation-level data
        /// </summary>
        /// <value>Filters that target quality management evaluation-level data</value>
        [DataMember(Name="evaluationFilters", EmitDefaultValue=false)]
        public List<AnalyticsQueryFilter> EvaluationFilters { get; set; }
        
        
        
        /// <summary>
        /// Filters that target quality management survey-level data
        /// </summary>
        /// <value>Filters that target quality management survey-level data</value>
        [DataMember(Name="surveyFilters", EmitDefaultValue=false)]
        public List<AnalyticsQueryFilter> SurveyFilters { get; set; }
        
        
        
        /// <summary>
        /// Filters that target call quality of service data
        /// </summary>
        /// <value>Filters that target call quality of service data</value>
        [DataMember(Name="mediaEndpointStatFilters", EmitDefaultValue=false)]
        public List<AnalyticsQueryFilter> MediaEndpointStatFilters { get; set; }
        
        
        
        /// <summary>
        /// Filters that target individual segments within a conversation
        /// </summary>
        /// <value>Filters that target individual segments within a conversation</value>
        [DataMember(Name="segmentFilters", EmitDefaultValue=false)]
        public List<AnalyticsQueryFilter> SegmentFilters { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Specify number of results to be returned
        /// </summary>
        /// <value>Specify number of results to be returned</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsyncConversationQuery {\n");
            
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  ConversationFilters: ").Append(ConversationFilters).Append("\n");
            sb.Append("  EvaluationFilters: ").Append(EvaluationFilters).Append("\n");
            sb.Append("  SurveyFilters: ").Append(SurveyFilters).Append("\n");
            sb.Append("  MediaEndpointStatFilters: ").Append(MediaEndpointStatFilters).Append("\n");
            sb.Append("  SegmentFilters: ").Append(SegmentFilters).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  OrderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(obj as AsyncConversationQuery);
        }

        /// <summary>
        /// Returns true if AsyncConversationQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of AsyncConversationQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsyncConversationQuery other)
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
                    this.ConversationFilters == other.ConversationFilters ||
                    this.ConversationFilters != null &&
                    this.ConversationFilters.SequenceEqual(other.ConversationFilters)
                ) &&
                (
                    this.EvaluationFilters == other.EvaluationFilters ||
                    this.EvaluationFilters != null &&
                    this.EvaluationFilters.SequenceEqual(other.EvaluationFilters)
                ) &&
                (
                    this.SurveyFilters == other.SurveyFilters ||
                    this.SurveyFilters != null &&
                    this.SurveyFilters.SequenceEqual(other.SurveyFilters)
                ) &&
                (
                    this.MediaEndpointStatFilters == other.MediaEndpointStatFilters ||
                    this.MediaEndpointStatFilters != null &&
                    this.MediaEndpointStatFilters.SequenceEqual(other.MediaEndpointStatFilters)
                ) &&
                (
                    this.SegmentFilters == other.SegmentFilters ||
                    this.SegmentFilters != null &&
                    this.SegmentFilters.SequenceEqual(other.SegmentFilters)
                ) &&
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) &&
                (
                    this.OrderBy == other.OrderBy ||
                    this.OrderBy != null &&
                    this.OrderBy.Equals(other.OrderBy)
                ) &&
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
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
                
                if (this.ConversationFilters != null)
                    hash = hash * 59 + this.ConversationFilters.GetHashCode();
                
                if (this.EvaluationFilters != null)
                    hash = hash * 59 + this.EvaluationFilters.GetHashCode();
                
                if (this.SurveyFilters != null)
                    hash = hash * 59 + this.SurveyFilters.GetHashCode();
                
                if (this.MediaEndpointStatFilters != null)
                    hash = hash * 59 + this.MediaEndpointStatFilters.GetHashCode();
                
                if (this.SegmentFilters != null)
                    hash = hash * 59 + this.SegmentFilters.GetHashCode();
                
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                
                if (this.OrderBy != null)
                    hash = hash * 59 + this.OrderBy.GetHashCode();
                
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                
                return hash;
            }
        }
    }

}
