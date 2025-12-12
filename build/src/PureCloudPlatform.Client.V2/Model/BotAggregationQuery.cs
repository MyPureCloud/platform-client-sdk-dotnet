using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BotAggregationQuery
	/// </summary>
	[DataContract]
	public partial class BotAggregationQuery : IEquatable<BotAggregationQuery>
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
			/// Enum Askactionid for "askActionId"
			/// </summary>
			[EnumMember(Value = "askActionId")]
			Askactionid,

			/// <summary>
			/// Enum Askactionresult for "askActionResult"
			/// </summary>
			[EnumMember(Value = "askActionResult")]
			Askactionresult,

			/// <summary>
			/// Enum Askactiontype for "askActionType"
			/// </summary>
			[EnumMember(Value = "askActionType")]
			Askactiontype,

			/// <summary>
			/// Enum Botfinalintent for "botFinalIntent"
			/// </summary>
			[EnumMember(Value = "botFinalIntent")]
			Botfinalintent,

			/// <summary>
			/// Enum Botflowsubtype for "botFlowSubType"
			/// </summary>
			[EnumMember(Value = "botFlowSubType")]
			Botflowsubtype,

			/// <summary>
			/// Enum Botflowtype for "botFlowType"
			/// </summary>
			[EnumMember(Value = "botFlowType")]
			Botflowtype,

			/// <summary>
			/// Enum Botid for "botId"
			/// </summary>
			[EnumMember(Value = "botId")]
			Botid,

			/// <summary>
			/// Enum Botintent for "botIntent"
			/// </summary>
			[EnumMember(Value = "botIntent")]
			Botintent,

			/// <summary>
			/// Enum Botname for "botName"
			/// </summary>
			[EnumMember(Value = "botName")]
			Botname,

			/// <summary>
			/// Enum Botproduct for "botProduct"
			/// </summary>
			[EnumMember(Value = "botProduct")]
			Botproduct,

			/// <summary>
			/// Enum Botprovider for "botProvider"
			/// </summary>
			[EnumMember(Value = "botProvider")]
			Botprovider,

			/// <summary>
			/// Enum Botrecognitionfailurereason for "botRecognitionFailureReason"
			/// </summary>
			[EnumMember(Value = "botRecognitionFailureReason")]
			Botrecognitionfailurereason,

			/// <summary>
			/// Enum Botresult for "botResult"
			/// </summary>
			[EnumMember(Value = "botResult")]
			Botresult,

			/// <summary>
			/// Enum Botsessionid for "botSessionId"
			/// </summary>
			[EnumMember(Value = "botSessionId")]
			Botsessionid,

			/// <summary>
			/// Enum Botslot for "botSlot"
			/// </summary>
			[EnumMember(Value = "botSlot")]
			Botslot,

			/// <summary>
			/// Enum Botslotmechanism for "botSlotMechanism"
			/// </summary>
			[EnumMember(Value = "botSlotMechanism")]
			Botslotmechanism,

			/// <summary>
			/// Enum Botversion for "botVersion"
			/// </summary>
			[EnumMember(Value = "botVersion")]
			Botversion,

			/// <summary>
			/// Enum Conversationid for "conversationId"
			/// </summary>
			[EnumMember(Value = "conversationId")]
			Conversationid,

			/// <summary>
			/// Enum Externalcontactid for "externalContactId"
			/// </summary>
			[EnumMember(Value = "externalContactId")]
			Externalcontactid,

			/// <summary>
			/// Enum Intermediateintentname for "intermediateIntentName"
			/// </summary>
			[EnumMember(Value = "intermediateIntentName")]
			Intermediateintentname,

			/// <summary>
			/// Enum Knowledgebaseid for "knowledgeBaseId"
			/// </summary>
			[EnumMember(Value = "knowledgeBaseId")]
			Knowledgebaseid,

			/// <summary>
			/// Enum Languagecode for "languageCode"
			/// </summary>
			[EnumMember(Value = "languageCode")]
			Languagecode,

			/// <summary>
			/// Enum Lastactionid for "lastActionId"
			/// </summary>
			[EnumMember(Value = "lastActionId")]
			Lastactionid,

			/// <summary>
			/// Enum Lastinputactionid for "lastInputActionId"
			/// </summary>
			[EnumMember(Value = "lastInputActionId")]
			Lastinputactionid,

			/// <summary>
			/// Enum Mediatype for "mediaType"
			/// </summary>
			[EnumMember(Value = "mediaType")]
			Mediatype,

			/// <summary>
			/// Enum Messagetype for "messageType"
			/// </summary>
			[EnumMember(Value = "messageType")]
			Messagetype,

			/// <summary>
			/// Enum Previewmode for "previewMode"
			/// </summary>
			[EnumMember(Value = "previewMode")]
			Previewmode,

			/// <summary>
			/// Enum Selfserved for "selfServed"
			/// </summary>
			[EnumMember(Value = "selfServed")]
			Selfserved
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
			/// Enum Nbotsessionturns for "nBotSessionTurns"
			/// </summary>
			[EnumMember(Value = "nBotSessionTurns")]
			Nbotsessionturns,

			/// <summary>
			/// Enum Nbotsessions for "nBotSessions"
			/// </summary>
			[EnumMember(Value = "nBotSessions")]
			Nbotsessions,

			/// <summary>
			/// Enum Obotintent for "oBotIntent"
			/// </summary>
			[EnumMember(Value = "oBotIntent")]
			Obotintent,

			/// <summary>
			/// Enum Obotsessioncollection for "oBotSessionCollection"
			/// </summary>
			[EnumMember(Value = "oBotSessionCollection")]
			Obotsessioncollection,

			/// <summary>
			/// Enum Obotsessioncollectionselfserved for "oBotSessionCollectionSelfServed"
			/// </summary>
			[EnumMember(Value = "oBotSessionCollectionSelfServed")]
			Obotsessioncollectionselfserved,

			/// <summary>
			/// Enum Obotsessionquery for "oBotSessionQuery"
			/// </summary>
			[EnumMember(Value = "oBotSessionQuery")]
			Obotsessionquery,

			/// <summary>
			/// Enum Obotsessionqueryselfserved for "oBotSessionQuerySelfServed"
			/// </summary>
			[EnumMember(Value = "oBotSessionQuerySelfServed")]
			Obotsessionqueryselfserved,

			/// <summary>
			/// Enum Obotsessionturn for "oBotSessionTurn"
			/// </summary>
			[EnumMember(Value = "oBotSessionTurn")]
			Obotsessionturn,

			/// <summary>
			/// Enum Obotslot for "oBotSlot"
			/// </summary>
			[EnumMember(Value = "oBotSlot")]
			Obotslot,

			/// <summary>
			/// Enum Tbotdisconnect for "tBotDisconnect"
			/// </summary>
			[EnumMember(Value = "tBotDisconnect")]
			Tbotdisconnect,

			/// <summary>
			/// Enum Tbotexit for "tBotExit"
			/// </summary>
			[EnumMember(Value = "tBotExit")]
			Tbotexit,

			/// <summary>
			/// Enum Tbotrecognitionfailure for "tBotRecognitionFailure"
			/// </summary>
			[EnumMember(Value = "tBotRecognitionFailure")]
			Tbotrecognitionfailure,

			/// <summary>
			/// Enum Tbotsession for "tBotSession"
			/// </summary>
			[EnumMember(Value = "tBotSession")]
			Tbotsession
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
		[DataMember(Name = "alternateTimeDimension", EmitDefaultValue = false)]
		public AlternateTimeDimensionEnum? AlternateTimeDimension { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="BotAggregationQuery" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected BotAggregationQuery() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="BotAggregationQuery" /> class.
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
		public BotAggregationQuery(string Interval = null, string Granularity = null, string TimeZone = null, List<GroupByEnum> GroupBy = null, BotAggregateQueryFilter Filter = null, List<MetricsEnum> Metrics = null, bool? FlattenMultivaluedDimensions = null, List<BotAggregationView> Views = null, AlternateTimeDimensionEnum? AlternateTimeDimension = null)
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

		}



		/// <summary>
		/// Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
		/// </summary>
		/// <value>Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
		[DataMember(Name = "interval", EmitDefaultValue = false)]
		public string Interval { get; set; }



		/// <summary>
		/// Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
		/// </summary>
		/// <value>Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
		[DataMember(Name = "granularity", EmitDefaultValue = false)]
		public string Granularity { get; set; }



		/// <summary>
		/// Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London
		/// </summary>
		/// <value>Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London</value>
		[DataMember(Name = "timeZone", EmitDefaultValue = false)]
		public string TimeZone { get; set; }



		/// <summary>
		/// Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group.
		/// </summary>
		/// <value>Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group.</value>
		[DataMember(Name = "groupBy", EmitDefaultValue = false)]
		public List<GroupByEnum> GroupBy { get; set; }



		/// <summary>
		/// Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters
		/// </summary>
		/// <value>Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters</value>
		[DataMember(Name = "filter", EmitDefaultValue = false)]
		public BotAggregateQueryFilter Filter { get; set; }



		/// <summary>
		/// Behaves like a SQL SELECT clause. Only named metrics will be retrieved.
		/// </summary>
		/// <value>Behaves like a SQL SELECT clause. Only named metrics will be retrieved.</value>
		[DataMember(Name = "metrics", EmitDefaultValue = false)]
		public List<MetricsEnum> Metrics { get; set; }



		/// <summary>
		/// Flattens any multivalued dimensions used in response groups (e.g. [&#39;a&#39;,&#39;b&#39;,&#39;c&#39;]-&gt;&#39;a,b,c&#39;)
		/// </summary>
		/// <value>Flattens any multivalued dimensions used in response groups (e.g. [&#39;a&#39;,&#39;b&#39;,&#39;c&#39;]-&gt;&#39;a,b,c&#39;)</value>
		[DataMember(Name = "flattenMultivaluedDimensions", EmitDefaultValue = false)]
		public bool? FlattenMultivaluedDimensions { get; set; }



		/// <summary>
		/// Custom derived metric views
		/// </summary>
		/// <value>Custom derived metric views</value>
		[DataMember(Name = "views", EmitDefaultValue = false)]
		public List<BotAggregationView> Views { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BotAggregationQuery {\n");

			sb.Append("  Interval: ").Append(Interval).Append("\n");
			sb.Append("  Granularity: ").Append(Granularity).Append("\n");
			sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
			sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
			sb.Append("  Filter: ").Append(Filter).Append("\n");
			sb.Append("  Metrics: ").Append(Metrics).Append("\n");
			sb.Append("  FlattenMultivaluedDimensions: ").Append(FlattenMultivaluedDimensions).Append("\n");
			sb.Append("  Views: ").Append(Views).Append("\n");
			sb.Append("  AlternateTimeDimension: ").Append(AlternateTimeDimension).Append("\n");
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
			return this.Equals(obj as BotAggregationQuery);
		}

		/// <summary>
		/// Returns true if BotAggregationQuery instances are equal
		/// </summary>
		/// <param name="other">Instance of BotAggregationQuery to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BotAggregationQuery other)
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

				return hash;
			}
		}
	}

}
