using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PunctualityEvent
	/// </summary>
	[DataContract]
	public partial class PunctualityEvent : IEquatable<PunctualityEvent>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PunctualityEvent" /> class.
		/// </summary>
		/// <param name="Bullseye">Bullseye.</param>
		public PunctualityEvent(bool? Bullseye = null)
		{
			this.Bullseye = Bullseye;

		}



		/// <summary>
		/// The scheduled activity start time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The scheduled activity start time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateScheduleStart", EmitDefaultValue = false)]
		public DateTime? DateScheduleStart { get; private set; }



		/// <summary>
		/// The time the user started the activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The time the user started the activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateStart", EmitDefaultValue = false)]
		public DateTime? DateStart { get; private set; }



		/// <summary>
		/// The length of the activity in minutes
		/// </summary>
		/// <value>The length of the activity in minutes</value>
		[DataMember(Name = "lengthMinutes", EmitDefaultValue = false)]
		public int? LengthMinutes { get; private set; }



		/// <summary>
		/// The description of the activity
		/// </summary>
		/// <value>The description of the activity</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; private set; }



		/// <summary>
		/// The ID of the activity code associated with this activity
		/// </summary>
		/// <value>The ID of the activity code associated with this activity</value>
		[DataMember(Name = "activityCodeId", EmitDefaultValue = false)]
		public string ActivityCodeId { get; private set; }



		/// <summary>
		/// The activity code
		/// </summary>
		/// <value>The activity code</value>
		[DataMember(Name = "activityCode", EmitDefaultValue = false)]
		public string ActivityCode { get; private set; }



		/// <summary>
		/// The activity name
		/// </summary>
		/// <value>The activity name</value>
		[DataMember(Name = "activityName", EmitDefaultValue = false)]
		public string ActivityName { get; private set; }



		/// <summary>
		/// The category for the activity
		/// </summary>
		/// <value>The category for the activity</value>
		[DataMember(Name = "category", EmitDefaultValue = false)]
		public string Category { get; private set; }



		/// <summary>
		/// The points earned for this activity
		/// </summary>
		/// <value>The points earned for this activity</value>
		[DataMember(Name = "points", EmitDefaultValue = false)]
		public int? Points { get; private set; }



		/// <summary>
		/// Difference between this activity and the last activity in seconds
		/// </summary>
		/// <value>Difference between this activity and the last activity in seconds</value>
		[DataMember(Name = "delta", EmitDefaultValue = false)]
		public double? Delta { get; private set; }



		/// <summary>
		/// Gets or Sets Bullseye
		/// </summary>
		[DataMember(Name = "bullseye", EmitDefaultValue = false)]
		public bool? Bullseye { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PunctualityEvent {\n");

			sb.Append("  DateScheduleStart: ").Append(DateScheduleStart).Append("\n");
			sb.Append("  DateStart: ").Append(DateStart).Append("\n");
			sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
			sb.Append("  ActivityCode: ").Append(ActivityCode).Append("\n");
			sb.Append("  ActivityName: ").Append(ActivityName).Append("\n");
			sb.Append("  Category: ").Append(Category).Append("\n");
			sb.Append("  Points: ").Append(Points).Append("\n");
			sb.Append("  Delta: ").Append(Delta).Append("\n");
			sb.Append("  Bullseye: ").Append(Bullseye).Append("\n");
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
			return this.Equals(obj as PunctualityEvent);
		}

		/// <summary>
		/// Returns true if PunctualityEvent instances are equal
		/// </summary>
		/// <param name="other">Instance of PunctualityEvent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PunctualityEvent other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DateScheduleStart == other.DateScheduleStart ||
					this.DateScheduleStart != null &&
					this.DateScheduleStart.Equals(other.DateScheduleStart)
				) &&
				(
					this.DateStart == other.DateStart ||
					this.DateStart != null &&
					this.DateStart.Equals(other.DateStart)
				) &&
				(
					this.LengthMinutes == other.LengthMinutes ||
					this.LengthMinutes != null &&
					this.LengthMinutes.Equals(other.LengthMinutes)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.ActivityCodeId == other.ActivityCodeId ||
					this.ActivityCodeId != null &&
					this.ActivityCodeId.Equals(other.ActivityCodeId)
				) &&
				(
					this.ActivityCode == other.ActivityCode ||
					this.ActivityCode != null &&
					this.ActivityCode.Equals(other.ActivityCode)
				) &&
				(
					this.ActivityName == other.ActivityName ||
					this.ActivityName != null &&
					this.ActivityName.Equals(other.ActivityName)
				) &&
				(
					this.Category == other.Category ||
					this.Category != null &&
					this.Category.Equals(other.Category)
				) &&
				(
					this.Points == other.Points ||
					this.Points != null &&
					this.Points.Equals(other.Points)
				) &&
				(
					this.Delta == other.Delta ||
					this.Delta != null &&
					this.Delta.Equals(other.Delta)
				) &&
				(
					this.Bullseye == other.Bullseye ||
					this.Bullseye != null &&
					this.Bullseye.Equals(other.Bullseye)
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
				if (this.DateScheduleStart != null)
					hash = hash * 59 + this.DateScheduleStart.GetHashCode();

				if (this.DateStart != null)
					hash = hash * 59 + this.DateStart.GetHashCode();

				if (this.LengthMinutes != null)
					hash = hash * 59 + this.LengthMinutes.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.ActivityCodeId != null)
					hash = hash * 59 + this.ActivityCodeId.GetHashCode();

				if (this.ActivityCode != null)
					hash = hash * 59 + this.ActivityCode.GetHashCode();

				if (this.ActivityName != null)
					hash = hash * 59 + this.ActivityName.GetHashCode();

				if (this.Category != null)
					hash = hash * 59 + this.Category.GetHashCode();

				if (this.Points != null)
					hash = hash * 59 + this.Points.GetHashCode();

				if (this.Delta != null)
					hash = hash * 59 + this.Delta.GetHashCode();

				if (this.Bullseye != null)
					hash = hash * 59 + this.Bullseye.GetHashCode();

				return hash;
			}
		}
	}

}
