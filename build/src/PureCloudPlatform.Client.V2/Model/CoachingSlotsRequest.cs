using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CoachingSlotsRequest
	/// </summary>
	[DataContract]
	public partial class CoachingSlotsRequest : IEquatable<CoachingSlotsRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="CoachingSlotsRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CoachingSlotsRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CoachingSlotsRequest" /> class.
		/// </summary>
		/// <param name="Interval">Range of time to get slots for scheduling coaching appointments. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
		/// <param name="LengthInMinutes">The duration of coaching appointment to schedule in 15 minutes granularity up to maximum of 60 minutes (required).</param>
		/// <param name="AttendeeIds">List of attendees to determine coaching appointment slots (required).</param>
		/// <param name="FacilitatorIds">List of facilitators to determine coaching appointment slots.</param>
		/// <param name="InterruptibleAppointmentIds">List of appointment ids to exclude from consideration when determining blocked slots.</param>
		public CoachingSlotsRequest(string Interval = null, int? LengthInMinutes = null, List<string> AttendeeIds = null, List<string> FacilitatorIds = null, List<string> InterruptibleAppointmentIds = null)
		{
			this.Interval = Interval;
			this.LengthInMinutes = LengthInMinutes;
			this.AttendeeIds = AttendeeIds;
			this.FacilitatorIds = FacilitatorIds;
			this.InterruptibleAppointmentIds = InterruptibleAppointmentIds;

		}



		/// <summary>
		/// Range of time to get slots for scheduling coaching appointments. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
		/// </summary>
		/// <value>Range of time to get slots for scheduling coaching appointments. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
		[DataMember(Name = "interval", EmitDefaultValue = false)]
		public string Interval { get; set; }



		/// <summary>
		/// The duration of coaching appointment to schedule in 15 minutes granularity up to maximum of 60 minutes
		/// </summary>
		/// <value>The duration of coaching appointment to schedule in 15 minutes granularity up to maximum of 60 minutes</value>
		[DataMember(Name = "lengthInMinutes", EmitDefaultValue = false)]
		public int? LengthInMinutes { get; set; }



		/// <summary>
		/// List of attendees to determine coaching appointment slots
		/// </summary>
		/// <value>List of attendees to determine coaching appointment slots</value>
		[DataMember(Name = "attendeeIds", EmitDefaultValue = false)]
		public List<string> AttendeeIds { get; set; }



		/// <summary>
		/// List of facilitators to determine coaching appointment slots
		/// </summary>
		/// <value>List of facilitators to determine coaching appointment slots</value>
		[DataMember(Name = "facilitatorIds", EmitDefaultValue = false)]
		public List<string> FacilitatorIds { get; set; }



		/// <summary>
		/// List of appointment ids to exclude from consideration when determining blocked slots
		/// </summary>
		/// <value>List of appointment ids to exclude from consideration when determining blocked slots</value>
		[DataMember(Name = "interruptibleAppointmentIds", EmitDefaultValue = false)]
		public List<string> InterruptibleAppointmentIds { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CoachingSlotsRequest {\n");

			sb.Append("  Interval: ").Append(Interval).Append("\n");
			sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
			sb.Append("  AttendeeIds: ").Append(AttendeeIds).Append("\n");
			sb.Append("  FacilitatorIds: ").Append(FacilitatorIds).Append("\n");
			sb.Append("  InterruptibleAppointmentIds: ").Append(InterruptibleAppointmentIds).Append("\n");
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
			return this.Equals(obj as CoachingSlotsRequest);
		}

		/// <summary>
		/// Returns true if CoachingSlotsRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of CoachingSlotsRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CoachingSlotsRequest other)
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
					this.LengthInMinutes == other.LengthInMinutes ||
					this.LengthInMinutes != null &&
					this.LengthInMinutes.Equals(other.LengthInMinutes)
				) &&
				(
					this.AttendeeIds == other.AttendeeIds ||
					this.AttendeeIds != null &&
					this.AttendeeIds.SequenceEqual(other.AttendeeIds)
				) &&
				(
					this.FacilitatorIds == other.FacilitatorIds ||
					this.FacilitatorIds != null &&
					this.FacilitatorIds.SequenceEqual(other.FacilitatorIds)
				) &&
				(
					this.InterruptibleAppointmentIds == other.InterruptibleAppointmentIds ||
					this.InterruptibleAppointmentIds != null &&
					this.InterruptibleAppointmentIds.SequenceEqual(other.InterruptibleAppointmentIds)
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

				if (this.LengthInMinutes != null)
					hash = hash * 59 + this.LengthInMinutes.GetHashCode();

				if (this.AttendeeIds != null)
					hash = hash * 59 + this.AttendeeIds.GetHashCode();

				if (this.FacilitatorIds != null)
					hash = hash * 59 + this.FacilitatorIds.GetHashCode();

				if (this.InterruptibleAppointmentIds != null)
					hash = hash * 59 + this.InterruptibleAppointmentIds.GetHashCode();

				return hash;
			}
		}
	}

}
