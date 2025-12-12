using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CoachingSlot
	/// </summary>
	[DataContract]
	public partial class CoachingSlot : IEquatable<CoachingSlot>
	{
		/// <summary>
		/// Rating based on the staffing difference for scheduled slot
		/// </summary>
		/// <value>Rating based on the staffing difference for scheduled slot</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum DifferenceRatingEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Poor for "Poor"
			/// </summary>
			[EnumMember(Value = "Poor")]
			Poor,

			/// <summary>
			/// Enum Neutral for "Neutral"
			/// </summary>
			[EnumMember(Value = "Neutral")]
			Neutral,

			/// <summary>
			/// Enum Good for "Good"
			/// </summary>
			[EnumMember(Value = "Good")]
			Good
		}
		/// <summary>
		/// Rating based on the staffing difference for scheduled slot
		/// </summary>
		/// <value>Rating based on the staffing difference for scheduled slot</value>
		[DataMember(Name = "differenceRating", EmitDefaultValue = false)]
		public DifferenceRatingEnum? DifferenceRating { get; private set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="CoachingSlot" /> class.
		/// </summary>
		public CoachingSlot()
		{

		}



		/// <summary>
		/// Start date and time of scheduled coaching appointment slot. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Start date and time of scheduled coaching appointment slot. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateStart", EmitDefaultValue = false)]
		public DateTime? DateStart { get; private set; }



		/// <summary>
		/// Length of coaching appointment slot in minutes
		/// </summary>
		/// <value>Length of coaching appointment slot in minutes</value>
		[DataMember(Name = "lengthInMinutes", EmitDefaultValue = false)]
		public int? LengthInMinutes { get; private set; }



		/// <summary>
		/// Difference between scheduled and forecast headcount for this slot after scheduling the coaching appointment
		/// </summary>
		/// <value>Difference between scheduled and forecast headcount for this slot after scheduling the coaching appointment</value>
		[DataMember(Name = "staffingDifference", EmitDefaultValue = false)]
		public double? StaffingDifference { get; private set; }





		/// <summary>
		/// Workforce Management schedule information associated with the slot
		/// </summary>
		/// <value>Workforce Management schedule information associated with the slot</value>
		[DataMember(Name = "wfmSchedule", EmitDefaultValue = false)]
		public WfmScheduleReference WfmSchedule { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CoachingSlot {\n");

			sb.Append("  DateStart: ").Append(DateStart).Append("\n");
			sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
			sb.Append("  StaffingDifference: ").Append(StaffingDifference).Append("\n");
			sb.Append("  DifferenceRating: ").Append(DifferenceRating).Append("\n");
			sb.Append("  WfmSchedule: ").Append(WfmSchedule).Append("\n");
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
			return this.Equals(obj as CoachingSlot);
		}

		/// <summary>
		/// Returns true if CoachingSlot instances are equal
		/// </summary>
		/// <param name="other">Instance of CoachingSlot to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CoachingSlot other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DateStart == other.DateStart ||
					this.DateStart != null &&
					this.DateStart.Equals(other.DateStart)
				) &&
				(
					this.LengthInMinutes == other.LengthInMinutes ||
					this.LengthInMinutes != null &&
					this.LengthInMinutes.Equals(other.LengthInMinutes)
				) &&
				(
					this.StaffingDifference == other.StaffingDifference ||
					this.StaffingDifference != null &&
					this.StaffingDifference.Equals(other.StaffingDifference)
				) &&
				(
					this.DifferenceRating == other.DifferenceRating ||
					this.DifferenceRating != null &&
					this.DifferenceRating.Equals(other.DifferenceRating)
				) &&
				(
					this.WfmSchedule == other.WfmSchedule ||
					this.WfmSchedule != null &&
					this.WfmSchedule.Equals(other.WfmSchedule)
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
				if (this.DateStart != null)
					hash = hash * 59 + this.DateStart.GetHashCode();

				if (this.LengthInMinutes != null)
					hash = hash * 59 + this.LengthInMinutes.GetHashCode();

				if (this.StaffingDifference != null)
					hash = hash * 59 + this.StaffingDifference.GetHashCode();

				if (this.DifferenceRating != null)
					hash = hash * 59 + this.DifferenceRating.GetHashCode();

				if (this.WfmSchedule != null)
					hash = hash * 59 + this.WfmSchedule.GetHashCode();

				return hash;
			}
		}
	}

}
