using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// MediaRtpStatistics
	/// </summary>
	[DataContract]
	public partial class MediaRtpStatistics : IEquatable<MediaRtpStatistics>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MediaRtpStatistics" /> class.
		/// </summary>
		/// <param name="PacketsReceived">Number of packets received, including all invalid, duplicate, and discarded packets.</param>
		/// <param name="PacketsSent">Number of packets sent.</param>
		/// <param name="RtpEventsReceived">Number of RFC#2833 packets received.</param>
		/// <param name="RtpEventsSent">Number of RFC#2833 packets sent.</param>
		/// <param name="EstimatedAverageMos">The estimated average MOS score.</param>
		/// <param name="AverageJitter">The average jitter.</param>
		public MediaRtpStatistics(int? PacketsReceived = null, int? PacketsSent = null, int? RtpEventsReceived = null, int? RtpEventsSent = null, double? EstimatedAverageMos = null, double? AverageJitter = null)
		{
			this.PacketsReceived = PacketsReceived;
			this.PacketsSent = PacketsSent;
			this.RtpEventsReceived = RtpEventsReceived;
			this.RtpEventsSent = RtpEventsSent;
			this.EstimatedAverageMos = EstimatedAverageMos;
			this.AverageJitter = AverageJitter;

		}



		/// <summary>
		/// Number of packets received, including all invalid, duplicate, and discarded packets
		/// </summary>
		/// <value>Number of packets received, including all invalid, duplicate, and discarded packets</value>
		[DataMember(Name = "packetsReceived", EmitDefaultValue = false)]
		public int? PacketsReceived { get; set; }



		/// <summary>
		/// Number of packets sent
		/// </summary>
		/// <value>Number of packets sent</value>
		[DataMember(Name = "packetsSent", EmitDefaultValue = false)]
		public int? PacketsSent { get; set; }



		/// <summary>
		/// Number of RFC#2833 packets received
		/// </summary>
		/// <value>Number of RFC#2833 packets received</value>
		[DataMember(Name = "rtpEventsReceived", EmitDefaultValue = false)]
		public int? RtpEventsReceived { get; set; }



		/// <summary>
		/// Number of RFC#2833 packets sent
		/// </summary>
		/// <value>Number of RFC#2833 packets sent</value>
		[DataMember(Name = "rtpEventsSent", EmitDefaultValue = false)]
		public int? RtpEventsSent { get; set; }



		/// <summary>
		/// The estimated average MOS score
		/// </summary>
		/// <value>The estimated average MOS score</value>
		[DataMember(Name = "estimatedAverageMos", EmitDefaultValue = false)]
		public double? EstimatedAverageMos { get; set; }



		/// <summary>
		/// The average jitter
		/// </summary>
		/// <value>The average jitter</value>
		[DataMember(Name = "averageJitter", EmitDefaultValue = false)]
		public double? AverageJitter { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MediaRtpStatistics {\n");

			sb.Append("  PacketsReceived: ").Append(PacketsReceived).Append("\n");
			sb.Append("  PacketsSent: ").Append(PacketsSent).Append("\n");
			sb.Append("  RtpEventsReceived: ").Append(RtpEventsReceived).Append("\n");
			sb.Append("  RtpEventsSent: ").Append(RtpEventsSent).Append("\n");
			sb.Append("  EstimatedAverageMos: ").Append(EstimatedAverageMos).Append("\n");
			sb.Append("  AverageJitter: ").Append(AverageJitter).Append("\n");
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
			return this.Equals(obj as MediaRtpStatistics);
		}

		/// <summary>
		/// Returns true if MediaRtpStatistics instances are equal
		/// </summary>
		/// <param name="other">Instance of MediaRtpStatistics to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MediaRtpStatistics other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.PacketsReceived == other.PacketsReceived ||
					this.PacketsReceived != null &&
					this.PacketsReceived.Equals(other.PacketsReceived)
				) &&
				(
					this.PacketsSent == other.PacketsSent ||
					this.PacketsSent != null &&
					this.PacketsSent.Equals(other.PacketsSent)
				) &&
				(
					this.RtpEventsReceived == other.RtpEventsReceived ||
					this.RtpEventsReceived != null &&
					this.RtpEventsReceived.Equals(other.RtpEventsReceived)
				) &&
				(
					this.RtpEventsSent == other.RtpEventsSent ||
					this.RtpEventsSent != null &&
					this.RtpEventsSent.Equals(other.RtpEventsSent)
				) &&
				(
					this.EstimatedAverageMos == other.EstimatedAverageMos ||
					this.EstimatedAverageMos != null &&
					this.EstimatedAverageMos.Equals(other.EstimatedAverageMos)
				) &&
				(
					this.AverageJitter == other.AverageJitter ||
					this.AverageJitter != null &&
					this.AverageJitter.Equals(other.AverageJitter)
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
				if (this.PacketsReceived != null)
					hash = hash * 59 + this.PacketsReceived.GetHashCode();

				if (this.PacketsSent != null)
					hash = hash * 59 + this.PacketsSent.GetHashCode();

				if (this.RtpEventsReceived != null)
					hash = hash * 59 + this.RtpEventsReceived.GetHashCode();

				if (this.RtpEventsSent != null)
					hash = hash * 59 + this.RtpEventsSent.GetHashCode();

				if (this.EstimatedAverageMos != null)
					hash = hash * 59 + this.EstimatedAverageMos.GetHashCode();

				if (this.AverageJitter != null)
					hash = hash * 59 + this.AverageJitter.GetHashCode();

				return hash;
			}
		}
	}

}
