using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Silent Call timeout configuration.
	/// </summary>
	[DataContract]
	public partial class QueueConversationCallEventTopicDispositionSilentCallTimeout : IEquatable<QueueConversationCallEventTopicDispositionSilentCallTimeout>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="QueueConversationCallEventTopicDispositionSilentCallTimeout" /> class.
		/// </summary>
		/// <param name="TimeoutMs">Configured Silent Call timeout value..</param>
		/// <param name="TimerStartTime">Timer start time, measured in epoch milliseconds..</param>
		/// <param name="TimerEndTime">Timer end time, measured in epoch milliseconds..</param>
		public QueueConversationCallEventTopicDispositionSilentCallTimeout(long? TimeoutMs = null, double? TimerStartTime = null, double? TimerEndTime = null)
		{
			this.TimeoutMs = TimeoutMs;
			this.TimerStartTime = TimerStartTime;
			this.TimerEndTime = TimerEndTime;

		}



		/// <summary>
		/// Configured Silent Call timeout value.
		/// </summary>
		/// <value>Configured Silent Call timeout value.</value>
		[DataMember(Name = "timeoutMs", EmitDefaultValue = false)]
		public long? TimeoutMs { get; set; }



		/// <summary>
		/// Timer start time, measured in epoch milliseconds.
		/// </summary>
		/// <value>Timer start time, measured in epoch milliseconds.</value>
		[DataMember(Name = "timerStartTime", EmitDefaultValue = false)]
		public double? TimerStartTime { get; set; }



		/// <summary>
		/// Timer end time, measured in epoch milliseconds.
		/// </summary>
		/// <value>Timer end time, measured in epoch milliseconds.</value>
		[DataMember(Name = "timerEndTime", EmitDefaultValue = false)]
		public double? TimerEndTime { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class QueueConversationCallEventTopicDispositionSilentCallTimeout {\n");

			sb.Append("  TimeoutMs: ").Append(TimeoutMs).Append("\n");
			sb.Append("  TimerStartTime: ").Append(TimerStartTime).Append("\n");
			sb.Append("  TimerEndTime: ").Append(TimerEndTime).Append("\n");
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
			return this.Equals(obj as QueueConversationCallEventTopicDispositionSilentCallTimeout);
		}

		/// <summary>
		/// Returns true if QueueConversationCallEventTopicDispositionSilentCallTimeout instances are equal
		/// </summary>
		/// <param name="other">Instance of QueueConversationCallEventTopicDispositionSilentCallTimeout to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(QueueConversationCallEventTopicDispositionSilentCallTimeout other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.TimeoutMs == other.TimeoutMs ||
					this.TimeoutMs != null &&
					this.TimeoutMs.Equals(other.TimeoutMs)
				) &&
				(
					this.TimerStartTime == other.TimerStartTime ||
					this.TimerStartTime != null &&
					this.TimerStartTime.Equals(other.TimerStartTime)
				) &&
				(
					this.TimerEndTime == other.TimerEndTime ||
					this.TimerEndTime != null &&
					this.TimerEndTime.Equals(other.TimerEndTime)
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
				if (this.TimeoutMs != null)
					hash = hash * 59 + this.TimeoutMs.GetHashCode();

				if (this.TimerStartTime != null)
					hash = hash * 59 + this.TimerStartTime.GetHashCode();

				if (this.TimerEndTime != null)
					hash = hash * 59 + this.TimerEndTime.GetHashCode();

				return hash;
			}
		}
	}

}
