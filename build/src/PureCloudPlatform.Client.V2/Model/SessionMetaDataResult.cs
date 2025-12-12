using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SessionMetaDataResult
	/// </summary>
	[DataContract]
	public partial class SessionMetaDataResult : IEquatable<SessionMetaDataResult>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SessionMetaDataResult" /> class.
		/// </summary>
		/// <param name="SessionInfo">Information about the continuous forecast session.</param>
		/// <param name="Snapshots">Captured snapshots.</param>
		/// <param name="DateForecastStart">Start date of the forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DateHistoricalStart">Start date of the oldest available historical week. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="AggregateOfferedHistoricalAvailability">Total historical availability for offered metric across all planning groups.</param>
		/// <param name="AggregateAverageHandleTimeHistoricalAvailability">Total historical availability for average handle time metric across all planning groups.</param>
		public SessionMetaDataResult(SessionInfo SessionInfo = null, List<Snapshots> Snapshots = null, DateTime? DateForecastStart = null, DateTime? DateHistoricalStart = null, AggregateHistoricalAvailability AggregateOfferedHistoricalAvailability = null, AggregateHistoricalAvailability AggregateAverageHandleTimeHistoricalAvailability = null)
		{
			this.SessionInfo = SessionInfo;
			this.Snapshots = Snapshots;
			this.DateForecastStart = DateForecastStart;
			this.DateHistoricalStart = DateHistoricalStart;
			this.AggregateOfferedHistoricalAvailability = AggregateOfferedHistoricalAvailability;
			this.AggregateAverageHandleTimeHistoricalAvailability = AggregateAverageHandleTimeHistoricalAvailability;

		}



		/// <summary>
		/// Information about the continuous forecast session
		/// </summary>
		/// <value>Information about the continuous forecast session</value>
		[DataMember(Name = "sessionInfo", EmitDefaultValue = false)]
		public SessionInfo SessionInfo { get; set; }



		/// <summary>
		/// Captured snapshots
		/// </summary>
		/// <value>Captured snapshots</value>
		[DataMember(Name = "snapshots", EmitDefaultValue = false)]
		public List<Snapshots> Snapshots { get; set; }



		/// <summary>
		/// Start date of the forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Start date of the forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateForecastStart", EmitDefaultValue = false)]
		public DateTime? DateForecastStart { get; set; }



		/// <summary>
		/// Start date of the oldest available historical week. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Start date of the oldest available historical week. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateHistoricalStart", EmitDefaultValue = false)]
		public DateTime? DateHistoricalStart { get; set; }



		/// <summary>
		/// Total historical availability for offered metric across all planning groups
		/// </summary>
		/// <value>Total historical availability for offered metric across all planning groups</value>
		[DataMember(Name = "aggregateOfferedHistoricalAvailability", EmitDefaultValue = false)]
		public AggregateHistoricalAvailability AggregateOfferedHistoricalAvailability { get; set; }



		/// <summary>
		/// Total historical availability for average handle time metric across all planning groups
		/// </summary>
		/// <value>Total historical availability for average handle time metric across all planning groups</value>
		[DataMember(Name = "aggregateAverageHandleTimeHistoricalAvailability", EmitDefaultValue = false)]
		public AggregateHistoricalAvailability AggregateAverageHandleTimeHistoricalAvailability { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SessionMetaDataResult {\n");

			sb.Append("  SessionInfo: ").Append(SessionInfo).Append("\n");
			sb.Append("  Snapshots: ").Append(Snapshots).Append("\n");
			sb.Append("  DateForecastStart: ").Append(DateForecastStart).Append("\n");
			sb.Append("  DateHistoricalStart: ").Append(DateHistoricalStart).Append("\n");
			sb.Append("  AggregateOfferedHistoricalAvailability: ").Append(AggregateOfferedHistoricalAvailability).Append("\n");
			sb.Append("  AggregateAverageHandleTimeHistoricalAvailability: ").Append(AggregateAverageHandleTimeHistoricalAvailability).Append("\n");
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
			return this.Equals(obj as SessionMetaDataResult);
		}

		/// <summary>
		/// Returns true if SessionMetaDataResult instances are equal
		/// </summary>
		/// <param name="other">Instance of SessionMetaDataResult to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SessionMetaDataResult other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SessionInfo == other.SessionInfo ||
					this.SessionInfo != null &&
					this.SessionInfo.Equals(other.SessionInfo)
				) &&
				(
					this.Snapshots == other.Snapshots ||
					this.Snapshots != null &&
					this.Snapshots.SequenceEqual(other.Snapshots)
				) &&
				(
					this.DateForecastStart == other.DateForecastStart ||
					this.DateForecastStart != null &&
					this.DateForecastStart.Equals(other.DateForecastStart)
				) &&
				(
					this.DateHistoricalStart == other.DateHistoricalStart ||
					this.DateHistoricalStart != null &&
					this.DateHistoricalStart.Equals(other.DateHistoricalStart)
				) &&
				(
					this.AggregateOfferedHistoricalAvailability == other.AggregateOfferedHistoricalAvailability ||
					this.AggregateOfferedHistoricalAvailability != null &&
					this.AggregateOfferedHistoricalAvailability.Equals(other.AggregateOfferedHistoricalAvailability)
				) &&
				(
					this.AggregateAverageHandleTimeHistoricalAvailability == other.AggregateAverageHandleTimeHistoricalAvailability ||
					this.AggregateAverageHandleTimeHistoricalAvailability != null &&
					this.AggregateAverageHandleTimeHistoricalAvailability.Equals(other.AggregateAverageHandleTimeHistoricalAvailability)
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
				if (this.SessionInfo != null)
					hash = hash * 59 + this.SessionInfo.GetHashCode();

				if (this.Snapshots != null)
					hash = hash * 59 + this.Snapshots.GetHashCode();

				if (this.DateForecastStart != null)
					hash = hash * 59 + this.DateForecastStart.GetHashCode();

				if (this.DateHistoricalStart != null)
					hash = hash * 59 + this.DateHistoricalStart.GetHashCode();

				if (this.AggregateOfferedHistoricalAvailability != null)
					hash = hash * 59 + this.AggregateOfferedHistoricalAvailability.GetHashCode();

				if (this.AggregateAverageHandleTimeHistoricalAvailability != null)
					hash = hash * 59 + this.AggregateAverageHandleTimeHistoricalAvailability.GetHashCode();

				return hash;
			}
		}
	}

}
