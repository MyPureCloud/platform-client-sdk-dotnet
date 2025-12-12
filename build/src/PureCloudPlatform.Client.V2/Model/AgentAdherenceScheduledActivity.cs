using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AgentAdherenceScheduledActivity
	/// </summary>
	[DataContract]
	public partial class AgentAdherenceScheduledActivity : IEquatable<AgentAdherenceScheduledActivity>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="AgentAdherenceScheduledActivity" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AgentAdherenceScheduledActivity() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AgentAdherenceScheduledActivity" /> class.
		/// </summary>
		/// <param name="ActivityCodeId">The ID of the activity code from the schedule (required).</param>
		/// <param name="StartOffsetSeconds">Start offset in seconds relative to query start time (required).</param>
		/// <param name="EndOffsetSeconds">End offset in seconds relative to query start time (required).</param>
		public AgentAdherenceScheduledActivity(string ActivityCodeId = null, int? StartOffsetSeconds = null, int? EndOffsetSeconds = null)
		{
			this.ActivityCodeId = ActivityCodeId;
			this.StartOffsetSeconds = StartOffsetSeconds;
			this.EndOffsetSeconds = EndOffsetSeconds;

		}



		/// <summary>
		/// The ID of the activity code from the schedule
		/// </summary>
		/// <value>The ID of the activity code from the schedule</value>
		[DataMember(Name = "activityCodeId", EmitDefaultValue = false)]
		public string ActivityCodeId { get; set; }



		/// <summary>
		/// Start offset in seconds relative to query start time
		/// </summary>
		/// <value>Start offset in seconds relative to query start time</value>
		[DataMember(Name = "startOffsetSeconds", EmitDefaultValue = false)]
		public int? StartOffsetSeconds { get; set; }



		/// <summary>
		/// End offset in seconds relative to query start time
		/// </summary>
		/// <value>End offset in seconds relative to query start time</value>
		[DataMember(Name = "endOffsetSeconds", EmitDefaultValue = false)]
		public int? EndOffsetSeconds { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AgentAdherenceScheduledActivity {\n");

			sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
			sb.Append("  StartOffsetSeconds: ").Append(StartOffsetSeconds).Append("\n");
			sb.Append("  EndOffsetSeconds: ").Append(EndOffsetSeconds).Append("\n");
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
			return this.Equals(obj as AgentAdherenceScheduledActivity);
		}

		/// <summary>
		/// Returns true if AgentAdherenceScheduledActivity instances are equal
		/// </summary>
		/// <param name="other">Instance of AgentAdherenceScheduledActivity to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AgentAdherenceScheduledActivity other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ActivityCodeId == other.ActivityCodeId ||
					this.ActivityCodeId != null &&
					this.ActivityCodeId.Equals(other.ActivityCodeId)
				) &&
				(
					this.StartOffsetSeconds == other.StartOffsetSeconds ||
					this.StartOffsetSeconds != null &&
					this.StartOffsetSeconds.Equals(other.StartOffsetSeconds)
				) &&
				(
					this.EndOffsetSeconds == other.EndOffsetSeconds ||
					this.EndOffsetSeconds != null &&
					this.EndOffsetSeconds.Equals(other.EndOffsetSeconds)
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
				if (this.ActivityCodeId != null)
					hash = hash * 59 + this.ActivityCodeId.GetHashCode();

				if (this.StartOffsetSeconds != null)
					hash = hash * 59 + this.StartOffsetSeconds.GetHashCode();

				if (this.EndOffsetSeconds != null)
					hash = hash * 59 + this.EndOffsetSeconds.GetHashCode();

				return hash;
			}
		}
	}

}
