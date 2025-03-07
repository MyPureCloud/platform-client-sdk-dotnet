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
    /// JourneyAsyncAggregationQuery
    /// </summary>
    [DataContract]
    public partial class JourneyAsyncAggregationQuery :  IEquatable<JourneyAsyncAggregationQuery>
    {
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
            /// Enum Containsallcondition for "containsAllCondition"
            /// </summary>
            [EnumMember(Value = "containsAllCondition")]
            Containsallcondition,
            
            /// <summary>
            /// Enum Containsanycondition for "containsAnyCondition"
            /// </summary>
            [EnumMember(Value = "containsAnyCondition")]
            Containsanycondition,
            
            /// <summary>
            /// Enum Endswithcondition for "endsWithCondition"
            /// </summary>
            [EnumMember(Value = "endsWithCondition")]
            Endswithcondition,
            
            /// <summary>
            /// Enum Equalcondition for "equalCondition"
            /// </summary>
            [EnumMember(Value = "equalCondition")]
            Equalcondition,
            
            /// <summary>
            /// Enum Journeyactionid for "journeyActionId"
            /// </summary>
            [EnumMember(Value = "journeyActionId")]
            Journeyactionid,
            
            /// <summary>
            /// Enum Journeyactionmapid for "journeyActionMapId"
            /// </summary>
            [EnumMember(Value = "journeyActionMapId")]
            Journeyactionmapid,
            
            /// <summary>
            /// Enum Journeyactionmapversion for "journeyActionMapVersion"
            /// </summary>
            [EnumMember(Value = "journeyActionMapVersion")]
            Journeyactionmapversion,
            
            /// <summary>
            /// Enum Journeyactionmediatype for "journeyActionMediaType"
            /// </summary>
            [EnumMember(Value = "journeyActionMediaType")]
            Journeyactionmediatype,
            
            /// <summary>
            /// Enum Journeyactiontargetid for "journeyActionTargetId"
            /// </summary>
            [EnumMember(Value = "journeyActionTargetId")]
            Journeyactiontargetid,
            
            /// <summary>
            /// Enum Journeyactiontemplateid for "journeyActionTemplateId"
            /// </summary>
            [EnumMember(Value = "journeyActionTemplateId")]
            Journeyactiontemplateid,
            
            /// <summary>
            /// Enum Journeyblockingactionmapid for "journeyBlockingActionMapId"
            /// </summary>
            [EnumMember(Value = "journeyBlockingActionMapId")]
            Journeyblockingactionmapid,
            
            /// <summary>
            /// Enum Journeyblockingemergencyschedulegroupid for "journeyBlockingEmergencyScheduleGroupId"
            /// </summary>
            [EnumMember(Value = "journeyBlockingEmergencyScheduleGroupId")]
            Journeyblockingemergencyschedulegroupid,
            
            /// <summary>
            /// Enum Journeyblockingreason for "journeyBlockingReason"
            /// </summary>
            [EnumMember(Value = "journeyBlockingReason")]
            Journeyblockingreason,
            
            /// <summary>
            /// Enum Journeyblockingschedulegroupid for "journeyBlockingScheduleGroupId"
            /// </summary>
            [EnumMember(Value = "journeyBlockingScheduleGroupId")]
            Journeyblockingschedulegroupid,
            
            /// <summary>
            /// Enum Journeydevicecategory for "journeyDeviceCategory"
            /// </summary>
            [EnumMember(Value = "journeyDeviceCategory")]
            Journeydevicecategory,
            
            /// <summary>
            /// Enum Journeydevicetype for "journeyDeviceType"
            /// </summary>
            [EnumMember(Value = "journeyDeviceType")]
            Journeydevicetype,
            
            /// <summary>
            /// Enum Journeyfrequencycapreason for "journeyFrequencyCapReason"
            /// </summary>
            [EnumMember(Value = "journeyFrequencyCapReason")]
            Journeyfrequencycapreason,
            
            /// <summary>
            /// Enum Journeyipgeolocationcountry for "journeyIpGeolocationCountry"
            /// </summary>
            [EnumMember(Value = "journeyIpGeolocationCountry")]
            Journeyipgeolocationcountry,
            
            /// <summary>
            /// Enum Journeyoutcomeid for "journeyOutcomeId"
            /// </summary>
            [EnumMember(Value = "journeyOutcomeId")]
            Journeyoutcomeid,
            
            /// <summary>
            /// Enum Journeysegmentid for "journeySegmentId"
            /// </summary>
            [EnumMember(Value = "journeySegmentId")]
            Journeysegmentid,
            
            /// <summary>
            /// Enum Journeysegmentscope for "journeySegmentScope"
            /// </summary>
            [EnumMember(Value = "journeySegmentScope")]
            Journeysegmentscope,
            
            /// <summary>
            /// Enum Journeysessionid for "journeySessionId"
            /// </summary>
            [EnumMember(Value = "journeySessionId")]
            Journeysessionid,
            
            /// <summary>
            /// Enum Journeysessionsegmentid for "journeySessionSegmentId"
            /// </summary>
            [EnumMember(Value = "journeySessionSegmentId")]
            Journeysessionsegmentid,
            
            /// <summary>
            /// Enum Journeysessiontype for "journeySessionType"
            /// </summary>
            [EnumMember(Value = "journeySessionType")]
            Journeysessiontype,
            
            /// <summary>
            /// Enum Notcontainsallcondition for "notContainsAllCondition"
            /// </summary>
            [EnumMember(Value = "notContainsAllCondition")]
            Notcontainsallcondition,
            
            /// <summary>
            /// Enum Notcontainsanycondition for "notContainsAnyCondition"
            /// </summary>
            [EnumMember(Value = "notContainsAnyCondition")]
            Notcontainsanycondition,
            
            /// <summary>
            /// Enum Notequalcondition for "notEqualCondition"
            /// </summary>
            [EnumMember(Value = "notEqualCondition")]
            Notequalcondition,
            
            /// <summary>
            /// Enum Startswithcondition for "startsWithCondition"
            /// </summary>
            [EnumMember(Value = "startsWithCondition")]
            Startswithcondition,
            
            /// <summary>
            /// Enum Touchpointactionmapid for "touchpointActionMapId"
            /// </summary>
            [EnumMember(Value = "touchpointActionMapId")]
            Touchpointactionmapid,
            
            /// <summary>
            /// Enum Touchpointagentid for "touchpointAgentId"
            /// </summary>
            [EnumMember(Value = "touchpointAgentId")]
            Touchpointagentid,
            
            /// <summary>
            /// Enum Touchpointattributionscope for "touchpointAttributionScope"
            /// </summary>
            [EnumMember(Value = "touchpointAttributionScope")]
            Touchpointattributionscope,
            
            /// <summary>
            /// Enum Touchpointchannelmessagetype for "touchpointChannelMessageType"
            /// </summary>
            [EnumMember(Value = "touchpointChannelMessageType")]
            Touchpointchannelmessagetype,
            
            /// <summary>
            /// Enum Touchpointchannelplatform for "touchpointChannelPlatform"
            /// </summary>
            [EnumMember(Value = "touchpointChannelPlatform")]
            Touchpointchannelplatform,
            
            /// <summary>
            /// Enum Touchpointchanneltype for "touchpointChannelType"
            /// </summary>
            [EnumMember(Value = "touchpointChannelType")]
            Touchpointchanneltype,
            
            /// <summary>
            /// Enum Touchpointconversationid for "touchpointConversationId"
            /// </summary>
            [EnumMember(Value = "touchpointConversationId")]
            Touchpointconversationid,
            
            /// <summary>
            /// Enum Touchpointinteractiontype for "touchpointInteractionType"
            /// </summary>
            [EnumMember(Value = "touchpointInteractionType")]
            Touchpointinteractiontype,
            
            /// <summary>
            /// Enum Touchpointqueueid for "touchpointQueueId"
            /// </summary>
            [EnumMember(Value = "touchpointQueueId")]
            Touchpointqueueid,
            
            /// <summary>
            /// Enum Touchpointrequestedrouting for "touchpointRequestedRouting"
            /// </summary>
            [EnumMember(Value = "touchpointRequestedRouting")]
            Touchpointrequestedrouting,
            
            /// <summary>
            /// Enum Touchpointusedrouting for "touchpointUsedRouting"
            /// </summary>
            [EnumMember(Value = "touchpointUsedRouting")]
            Touchpointusedrouting,
            
            /// <summary>
            /// Enum Touchpointwrapupcode for "touchpointWrapupCode"
            /// </summary>
            [EnumMember(Value = "touchpointWrapupCode")]
            Touchpointwrapupcode
        }
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
            /// Enum Ndistinctjourneyactions for "nDistinctJourneyActions"
            /// </summary>
            [EnumMember(Value = "nDistinctJourneyActions")]
            Ndistinctjourneyactions,
            
            /// <summary>
            /// Enum Ndistinctjourneysessions for "nDistinctJourneySessions"
            /// </summary>
            [EnumMember(Value = "nDistinctJourneySessions")]
            Ndistinctjourneysessions,
            
            /// <summary>
            /// Enum Njourneyactionsblocked for "nJourneyActionsBlocked"
            /// </summary>
            [EnumMember(Value = "nJourneyActionsBlocked")]
            Njourneyactionsblocked,
            
            /// <summary>
            /// Enum Njourneyoutcomesachieved for "nJourneyOutcomesAchieved"
            /// </summary>
            [EnumMember(Value = "nJourneyOutcomesAchieved")]
            Njourneyoutcomesachieved,
            
            /// <summary>
            /// Enum Njourneyoutcomesattributed for "nJourneyOutcomesAttributed"
            /// </summary>
            [EnumMember(Value = "nJourneyOutcomesAttributed")]
            Njourneyoutcomesattributed,
            
            /// <summary>
            /// Enum Njourneysegmentsassigned for "nJourneySegmentsAssigned"
            /// </summary>
            [EnumMember(Value = "nJourneySegmentsAssigned")]
            Njourneysegmentsassigned,
            
            /// <summary>
            /// Enum Njourneysessions for "nJourneySessions"
            /// </summary>
            [EnumMember(Value = "nJourneySessions")]
            Njourneysessions,
            
            /// <summary>
            /// Enum Nwebactionsabandoned for "nWebActionsAbandoned"
            /// </summary>
            [EnumMember(Value = "nWebActionsAbandoned")]
            Nwebactionsabandoned,
            
            /// <summary>
            /// Enum Nwebactionsaccepted for "nWebActionsAccepted"
            /// </summary>
            [EnumMember(Value = "nWebActionsAccepted")]
            Nwebactionsaccepted,
            
            /// <summary>
            /// Enum Nwebactionsengaged for "nWebActionsEngaged"
            /// </summary>
            [EnumMember(Value = "nWebActionsEngaged")]
            Nwebactionsengaged,
            
            /// <summary>
            /// Enum Nwebactionserrored for "nWebActionsErrored"
            /// </summary>
            [EnumMember(Value = "nWebActionsErrored")]
            Nwebactionserrored,
            
            /// <summary>
            /// Enum Nwebactionsfrequencycapreached for "nWebActionsFrequencyCapReached"
            /// </summary>
            [EnumMember(Value = "nWebActionsFrequencyCapReached")]
            Nwebactionsfrequencycapreached,
            
            /// <summary>
            /// Enum Nwebactionsignored for "nWebActionsIgnored"
            /// </summary>
            [EnumMember(Value = "nWebActionsIgnored")]
            Nwebactionsignored,
            
            /// <summary>
            /// Enum Nwebactionsoffered for "nWebActionsOffered"
            /// </summary>
            [EnumMember(Value = "nWebActionsOffered")]
            Nwebactionsoffered,
            
            /// <summary>
            /// Enum Nwebactionsofferedoutsideschedule for "nWebActionsOfferedOutsideSchedule"
            /// </summary>
            [EnumMember(Value = "nWebActionsOfferedOutsideSchedule")]
            Nwebactionsofferedoutsideschedule,
            
            /// <summary>
            /// Enum Nwebactionsqualified for "nWebActionsQualified"
            /// </summary>
            [EnumMember(Value = "nWebActionsQualified")]
            Nwebactionsqualified,
            
            /// <summary>
            /// Enum Nwebactionsqualifiedoutsideschedule for "nWebActionsQualifiedOutsideSchedule"
            /// </summary>
            [EnumMember(Value = "nWebActionsQualifiedOutsideSchedule")]
            Nwebactionsqualifiedoutsideschedule,
            
            /// <summary>
            /// Enum Nwebactionsrejected for "nWebActionsRejected"
            /// </summary>
            [EnumMember(Value = "nWebActionsRejected")]
            Nwebactionsrejected,
            
            /// <summary>
            /// Enum Nwebactionsstarted for "nWebActionsStarted"
            /// </summary>
            [EnumMember(Value = "nWebActionsStarted")]
            Nwebactionsstarted,
            
            /// <summary>
            /// Enum Nwebactionstimedout for "nWebActionsTimedout"
            /// </summary>
            [EnumMember(Value = "nWebActionsTimedout")]
            Nwebactionstimedout,
            
            /// <summary>
            /// Enum Ojourneyoutcometouchpointvalue for "oJourneyOutcomeTouchpointValue"
            /// </summary>
            [EnumMember(Value = "oJourneyOutcomeTouchpointValue")]
            Ojourneyoutcometouchpointvalue,
            
            /// <summary>
            /// Enum Ojourneyoutcomevalue for "oJourneyOutcomeValue"
            /// </summary>
            [EnumMember(Value = "oJourneyOutcomeValue")]
            Ojourneyoutcomevalue
        }
        /// <summary>
        /// Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.
        /// </summary>
        /// <value>Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AlternateTimeDimensionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Eventtime for "eventTime"
            /// </summary>
            [EnumMember(Value = "eventTime")]
            Eventtime
        }
        /// <summary>
        /// Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.
        /// </summary>
        /// <value>Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.</value>
        [DataMember(Name="alternateTimeDimension", EmitDefaultValue=false)]
        public AlternateTimeDimensionEnum? AlternateTimeDimension { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyAsyncAggregationQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JourneyAsyncAggregationQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyAsyncAggregationQuery" /> class.
        /// </summary>
        /// <param name="Interval">Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
        /// <param name="Granularity">Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H.</param>
        /// <param name="TimeZone">Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London.</param>
        /// <param name="GroupBy">Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group..</param>
        /// <param name="Filter">Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters.</param>
        /// <param name="Metrics">Behaves like a SQL SELECT clause. Only named metrics will be retrieved. (required).</param>
        /// <param name="FlattenMultivaluedDimensions">Flattens any multivalued dimensions used in response groups (e.g. [&#39;a&#39;,&#39;b&#39;,&#39;c&#39;]-&gt;&#39;a,b,c&#39;).</param>
        /// <param name="Views">Custom derived metric views.</param>
        /// <param name="AlternateTimeDimension">Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \&quot;eventTime\&quot; uses the actual time of the data event..</param>
        /// <param name="PageSize">The number of results per page.</param>
        public JourneyAsyncAggregationQuery(string Interval = null, string Granularity = null, string TimeZone = null, List<GroupByEnum> GroupBy = null, JourneyAggregateQueryFilter Filter = null, List<MetricsEnum> Metrics = null, bool? FlattenMultivaluedDimensions = null, List<JourneyAggregationView> Views = null, AlternateTimeDimensionEnum? AlternateTimeDimension = null, int? PageSize = null)
        {
            this.Interval = Interval;
            this.Granularity = Granularity;
            this.TimeZone = TimeZone;
            this.GroupBy = GroupBy;
            this.Filter = Filter;
            this.Metrics = Metrics;
            this.FlattenMultivaluedDimensions = FlattenMultivaluedDimensions;
            this.Views = Views;
            this.AlternateTimeDimension = AlternateTimeDimension;
            this.PageSize = PageSize;
            
        }
        


        /// <summary>
        /// Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }



        /// <summary>
        /// Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
        /// </summary>
        /// <value>Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
        [DataMember(Name="granularity", EmitDefaultValue=false)]
        public string Granularity { get; set; }



        /// <summary>
        /// Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London
        /// </summary>
        /// <value>Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }



        /// <summary>
        /// Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group.
        /// </summary>
        /// <value>Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group.</value>
        [DataMember(Name="groupBy", EmitDefaultValue=false)]
        public List<GroupByEnum> GroupBy { get; set; }



        /// <summary>
        /// Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters
        /// </summary>
        /// <value>Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public JourneyAggregateQueryFilter Filter { get; set; }



        /// <summary>
        /// Behaves like a SQL SELECT clause. Only named metrics will be retrieved.
        /// </summary>
        /// <value>Behaves like a SQL SELECT clause. Only named metrics will be retrieved.</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<MetricsEnum> Metrics { get; set; }



        /// <summary>
        /// Flattens any multivalued dimensions used in response groups (e.g. [&#39;a&#39;,&#39;b&#39;,&#39;c&#39;]-&gt;&#39;a,b,c&#39;)
        /// </summary>
        /// <value>Flattens any multivalued dimensions used in response groups (e.g. [&#39;a&#39;,&#39;b&#39;,&#39;c&#39;]-&gt;&#39;a,b,c&#39;)</value>
        [DataMember(Name="flattenMultivaluedDimensions", EmitDefaultValue=false)]
        public bool? FlattenMultivaluedDimensions { get; set; }



        /// <summary>
        /// Custom derived metric views
        /// </summary>
        /// <value>Custom derived metric views</value>
        [DataMember(Name="views", EmitDefaultValue=false)]
        public List<JourneyAggregationView> Views { get; set; }





        /// <summary>
        /// The number of results per page
        /// </summary>
        /// <value>The number of results per page</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyAsyncAggregationQuery {\n");

            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  FlattenMultivaluedDimensions: ").Append(FlattenMultivaluedDimensions).Append("\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
            sb.Append("  AlternateTimeDimension: ").Append(AlternateTimeDimension).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
            return this.Equals(obj as JourneyAsyncAggregationQuery);
        }

        /// <summary>
        /// Returns true if JourneyAsyncAggregationQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyAsyncAggregationQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyAsyncAggregationQuery other)
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
                    this.Granularity == other.Granularity ||
                    this.Granularity != null &&
                    this.Granularity.Equals(other.Granularity)
                ) &&
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
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
                ) &&
                (
                    this.Metrics == other.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(other.Metrics)
                ) &&
                (
                    this.FlattenMultivaluedDimensions == other.FlattenMultivaluedDimensions ||
                    this.FlattenMultivaluedDimensions != null &&
                    this.FlattenMultivaluedDimensions.Equals(other.FlattenMultivaluedDimensions)
                ) &&
                (
                    this.Views == other.Views ||
                    this.Views != null &&
                    this.Views.SequenceEqual(other.Views)
                ) &&
                (
                    this.AlternateTimeDimension == other.AlternateTimeDimension ||
                    this.AlternateTimeDimension != null &&
                    this.AlternateTimeDimension.Equals(other.AlternateTimeDimension)
                ) &&
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
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

                if (this.Granularity != null)
                    hash = hash * 59 + this.Granularity.GetHashCode();

                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();

                if (this.GroupBy != null)
                    hash = hash * 59 + this.GroupBy.GetHashCode();

                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();

                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();

                if (this.FlattenMultivaluedDimensions != null)
                    hash = hash * 59 + this.FlattenMultivaluedDimensions.GetHashCode();

                if (this.Views != null)
                    hash = hash * 59 + this.Views.GetHashCode();

                if (this.AlternateTimeDimension != null)
                    hash = hash * 59 + this.AlternateTimeDimension.GetHashCode();

                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();

                return hash;
            }
        }
    }

}
