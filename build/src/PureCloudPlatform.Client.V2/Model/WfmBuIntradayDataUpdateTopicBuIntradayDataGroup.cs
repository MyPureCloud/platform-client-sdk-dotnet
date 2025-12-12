using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WfmBuIntradayDataUpdateTopicBuIntradayDataGroup
	/// </summary>
	[DataContract]
	public partial class WfmBuIntradayDataUpdateTopicBuIntradayDataGroup : IEquatable<WfmBuIntradayDataUpdateTopicBuIntradayDataGroup>
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
			/// Enum Voice for "Voice"
			/// </summary>
			[EnumMember(Value = "Voice")]
			Voice,

			/// <summary>
			/// Enum Chat for "Chat"
			/// </summary>
			[EnumMember(Value = "Chat")]
			Chat,

			/// <summary>
			/// Enum Email for "Email"
			/// </summary>
			[EnumMember(Value = "Email")]
			Email,

			/// <summary>
			/// Enum Callback for "Callback"
			/// </summary>
			[EnumMember(Value = "Callback")]
			Callback,

			/// <summary>
			/// Enum Message for "Message"
			/// </summary>
			[EnumMember(Value = "Message")]
			Message,

			/// <summary>
			/// Enum Workitem for "Workitem"
			/// </summary>
			[EnumMember(Value = "Workitem")]
			Workitem
		}
		/// <summary>
		/// Gets or Sets MediaType
		/// </summary>
		[DataMember(Name = "mediaType", EmitDefaultValue = false)]
		public MediaTypeEnum? MediaType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="WfmBuIntradayDataUpdateTopicBuIntradayDataGroup" /> class.
		/// </summary>
		/// <param name="MediaType">MediaType.</param>
		/// <param name="ForecastDataSummary">ForecastDataSummary.</param>
		/// <param name="ForecastDataPerInterval">ForecastDataPerInterval.</param>
		/// <param name="ScheduleDataSummary">ScheduleDataSummary.</param>
		/// <param name="ScheduleDataPerInterval">ScheduleDataPerInterval.</param>
		/// <param name="PerformancePredictionDataSummary">PerformancePredictionDataSummary.</param>
		/// <param name="PerformancePredictionDataPerInterval">PerformancePredictionDataPerInterval.</param>
		public WfmBuIntradayDataUpdateTopicBuIntradayDataGroup(MediaTypeEnum? MediaType = null, WfmBuIntradayDataUpdateTopicBuIntradayForecastData ForecastDataSummary = null, List<WfmBuIntradayDataUpdateTopicBuIntradayForecastData> ForecastDataPerInterval = null, WfmBuIntradayDataUpdateTopicBuIntradayScheduleData ScheduleDataSummary = null, List<WfmBuIntradayDataUpdateTopicBuIntradayScheduleData> ScheduleDataPerInterval = null, WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData PerformancePredictionDataSummary = null, List<WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData> PerformancePredictionDataPerInterval = null)
		{
			this.MediaType = MediaType;
			this.ForecastDataSummary = ForecastDataSummary;
			this.ForecastDataPerInterval = ForecastDataPerInterval;
			this.ScheduleDataSummary = ScheduleDataSummary;
			this.ScheduleDataPerInterval = ScheduleDataPerInterval;
			this.PerformancePredictionDataSummary = PerformancePredictionDataSummary;
			this.PerformancePredictionDataPerInterval = PerformancePredictionDataPerInterval;

		}





		/// <summary>
		/// Gets or Sets ForecastDataSummary
		/// </summary>
		[DataMember(Name = "forecastDataSummary", EmitDefaultValue = false)]
		public WfmBuIntradayDataUpdateTopicBuIntradayForecastData ForecastDataSummary { get; set; }



		/// <summary>
		/// Gets or Sets ForecastDataPerInterval
		/// </summary>
		[DataMember(Name = "forecastDataPerInterval", EmitDefaultValue = false)]
		public List<WfmBuIntradayDataUpdateTopicBuIntradayForecastData> ForecastDataPerInterval { get; set; }



		/// <summary>
		/// Gets or Sets ScheduleDataSummary
		/// </summary>
		[DataMember(Name = "scheduleDataSummary", EmitDefaultValue = false)]
		public WfmBuIntradayDataUpdateTopicBuIntradayScheduleData ScheduleDataSummary { get; set; }



		/// <summary>
		/// Gets or Sets ScheduleDataPerInterval
		/// </summary>
		[DataMember(Name = "scheduleDataPerInterval", EmitDefaultValue = false)]
		public List<WfmBuIntradayDataUpdateTopicBuIntradayScheduleData> ScheduleDataPerInterval { get; set; }



		/// <summary>
		/// Gets or Sets PerformancePredictionDataSummary
		/// </summary>
		[DataMember(Name = "performancePredictionDataSummary", EmitDefaultValue = false)]
		public WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData PerformancePredictionDataSummary { get; set; }



		/// <summary>
		/// Gets or Sets PerformancePredictionDataPerInterval
		/// </summary>
		[DataMember(Name = "performancePredictionDataPerInterval", EmitDefaultValue = false)]
		public List<WfmBuIntradayDataUpdateTopicIntradayPerformancePredictionData> PerformancePredictionDataPerInterval { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WfmBuIntradayDataUpdateTopicBuIntradayDataGroup {\n");

			sb.Append("  MediaType: ").Append(MediaType).Append("\n");
			sb.Append("  ForecastDataSummary: ").Append(ForecastDataSummary).Append("\n");
			sb.Append("  ForecastDataPerInterval: ").Append(ForecastDataPerInterval).Append("\n");
			sb.Append("  ScheduleDataSummary: ").Append(ScheduleDataSummary).Append("\n");
			sb.Append("  ScheduleDataPerInterval: ").Append(ScheduleDataPerInterval).Append("\n");
			sb.Append("  PerformancePredictionDataSummary: ").Append(PerformancePredictionDataSummary).Append("\n");
			sb.Append("  PerformancePredictionDataPerInterval: ").Append(PerformancePredictionDataPerInterval).Append("\n");
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
			return this.Equals(obj as WfmBuIntradayDataUpdateTopicBuIntradayDataGroup);
		}

		/// <summary>
		/// Returns true if WfmBuIntradayDataUpdateTopicBuIntradayDataGroup instances are equal
		/// </summary>
		/// <param name="other">Instance of WfmBuIntradayDataUpdateTopicBuIntradayDataGroup to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WfmBuIntradayDataUpdateTopicBuIntradayDataGroup other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.MediaType == other.MediaType ||
					this.MediaType != null &&
					this.MediaType.Equals(other.MediaType)
				) &&
				(
					this.ForecastDataSummary == other.ForecastDataSummary ||
					this.ForecastDataSummary != null &&
					this.ForecastDataSummary.Equals(other.ForecastDataSummary)
				) &&
				(
					this.ForecastDataPerInterval == other.ForecastDataPerInterval ||
					this.ForecastDataPerInterval != null &&
					this.ForecastDataPerInterval.SequenceEqual(other.ForecastDataPerInterval)
				) &&
				(
					this.ScheduleDataSummary == other.ScheduleDataSummary ||
					this.ScheduleDataSummary != null &&
					this.ScheduleDataSummary.Equals(other.ScheduleDataSummary)
				) &&
				(
					this.ScheduleDataPerInterval == other.ScheduleDataPerInterval ||
					this.ScheduleDataPerInterval != null &&
					this.ScheduleDataPerInterval.SequenceEqual(other.ScheduleDataPerInterval)
				) &&
				(
					this.PerformancePredictionDataSummary == other.PerformancePredictionDataSummary ||
					this.PerformancePredictionDataSummary != null &&
					this.PerformancePredictionDataSummary.Equals(other.PerformancePredictionDataSummary)
				) &&
				(
					this.PerformancePredictionDataPerInterval == other.PerformancePredictionDataPerInterval ||
					this.PerformancePredictionDataPerInterval != null &&
					this.PerformancePredictionDataPerInterval.SequenceEqual(other.PerformancePredictionDataPerInterval)
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
				if (this.MediaType != null)
					hash = hash * 59 + this.MediaType.GetHashCode();

				if (this.ForecastDataSummary != null)
					hash = hash * 59 + this.ForecastDataSummary.GetHashCode();

				if (this.ForecastDataPerInterval != null)
					hash = hash * 59 + this.ForecastDataPerInterval.GetHashCode();

				if (this.ScheduleDataSummary != null)
					hash = hash * 59 + this.ScheduleDataSummary.GetHashCode();

				if (this.ScheduleDataPerInterval != null)
					hash = hash * 59 + this.ScheduleDataPerInterval.GetHashCode();

				if (this.PerformancePredictionDataSummary != null)
					hash = hash * 59 + this.PerformancePredictionDataSummary.GetHashCode();

				if (this.PerformancePredictionDataPerInterval != null)
					hash = hash * 59 + this.PerformancePredictionDataPerInterval.GetHashCode();

				return hash;
			}
		}
	}

}
