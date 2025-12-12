using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ForecastMetadata
	/// </summary>
	[DataContract]
	public partial class ForecastMetadata : IEquatable<ForecastMetadata>
	{
		/// <summary>
		/// Forecast source
		/// </summary>
		/// <value>Forecast source</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SourceEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Automaticbestmethod for "AutomaticBestMethod"
			/// </summary>
			[EnumMember(Value = "AutomaticBestMethod")]
			Automaticbestmethod,

			/// <summary>
			/// Enum Mainforecast for "MainForecast"
			/// </summary>
			[EnumMember(Value = "MainForecast")]
			Mainforecast
		}
		/// <summary>
		/// Forecast source
		/// </summary>
		/// <value>Forecast source</value>
		[DataMember(Name = "source", EmitDefaultValue = false)]
		public SourceEnum? Source { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ForecastMetadata" /> class.
		/// </summary>
		/// <param name="DateCreated">Forecast creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="ForecastId">Forecast ID.</param>
		/// <param name="IntervalLengthInMinutes">Interval length.</param>
		/// <param name="Source">Forecast source.</param>
		/// <param name="DateStart">Forecast start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="TimeZone">Timezone of the business unit.</param>
		public ForecastMetadata(DateTime? DateCreated = null, string ForecastId = null, string IntervalLengthInMinutes = null, SourceEnum? Source = null, DateTime? DateStart = null, string TimeZone = null)
		{
			this.DateCreated = DateCreated;
			this.ForecastId = ForecastId;
			this.IntervalLengthInMinutes = IntervalLengthInMinutes;
			this.Source = Source;
			this.DateStart = DateStart;
			this.TimeZone = TimeZone;

		}



		/// <summary>
		/// Forecast creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Forecast creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }



		/// <summary>
		/// Forecast ID
		/// </summary>
		/// <value>Forecast ID</value>
		[DataMember(Name = "forecastId", EmitDefaultValue = false)]
		public string ForecastId { get; set; }



		/// <summary>
		/// Interval length
		/// </summary>
		/// <value>Interval length</value>
		[DataMember(Name = "intervalLengthInMinutes", EmitDefaultValue = false)]
		public string IntervalLengthInMinutes { get; set; }





		/// <summary>
		/// Forecast start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Forecast start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateStart", EmitDefaultValue = false)]
		public DateTime? DateStart { get; set; }



		/// <summary>
		/// Timezone of the business unit
		/// </summary>
		/// <value>Timezone of the business unit</value>
		[DataMember(Name = "timeZone", EmitDefaultValue = false)]
		public string TimeZone { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ForecastMetadata {\n");

			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  ForecastId: ").Append(ForecastId).Append("\n");
			sb.Append("  IntervalLengthInMinutes: ").Append(IntervalLengthInMinutes).Append("\n");
			sb.Append("  Source: ").Append(Source).Append("\n");
			sb.Append("  DateStart: ").Append(DateStart).Append("\n");
			sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
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
			return this.Equals(obj as ForecastMetadata);
		}

		/// <summary>
		/// Returns true if ForecastMetadata instances are equal
		/// </summary>
		/// <param name="other">Instance of ForecastMetadata to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ForecastMetadata other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.ForecastId == other.ForecastId ||
					this.ForecastId != null &&
					this.ForecastId.Equals(other.ForecastId)
				) &&
				(
					this.IntervalLengthInMinutes == other.IntervalLengthInMinutes ||
					this.IntervalLengthInMinutes != null &&
					this.IntervalLengthInMinutes.Equals(other.IntervalLengthInMinutes)
				) &&
				(
					this.Source == other.Source ||
					this.Source != null &&
					this.Source.Equals(other.Source)
				) &&
				(
					this.DateStart == other.DateStart ||
					this.DateStart != null &&
					this.DateStart.Equals(other.DateStart)
				) &&
				(
					this.TimeZone == other.TimeZone ||
					this.TimeZone != null &&
					this.TimeZone.Equals(other.TimeZone)
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
				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.ForecastId != null)
					hash = hash * 59 + this.ForecastId.GetHashCode();

				if (this.IntervalLengthInMinutes != null)
					hash = hash * 59 + this.IntervalLengthInMinutes.GetHashCode();

				if (this.Source != null)
					hash = hash * 59 + this.Source.GetHashCode();

				if (this.DateStart != null)
					hash = hash * 59 + this.DateStart.GetHashCode();

				if (this.TimeZone != null)
					hash = hash * 59 + this.TimeZone.GetHashCode();

				return hash;
			}
		}
	}

}
