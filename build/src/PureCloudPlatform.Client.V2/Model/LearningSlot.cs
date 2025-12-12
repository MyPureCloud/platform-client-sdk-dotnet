using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LearningSlot
	/// </summary>
	[DataContract]
	public partial class LearningSlot : IEquatable<LearningSlot>
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
		public DifferenceRatingEnum? DifferenceRating { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="LearningSlot" /> class.
		/// </summary>
		/// <param name="DateStart">Start date and time of scheduled Learning activity slot. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="LengthInMinutes">Length of Learning activity slot in minutes.</param>
		/// <param name="StaffingDifference">Difference between scheduled and forecast headcount for this slot after scheduling the Learning activity.</param>
		/// <param name="DifferenceRating">Rating based on the staffing difference for scheduled slot.</param>
		public LearningSlot(DateTime? DateStart = null, int? LengthInMinutes = null, double? StaffingDifference = null, DifferenceRatingEnum? DifferenceRating = null)
		{
			this.DateStart = DateStart;
			this.LengthInMinutes = LengthInMinutes;
			this.StaffingDifference = StaffingDifference;
			this.DifferenceRating = DifferenceRating;

		}



		/// <summary>
		/// Start date and time of scheduled Learning activity slot. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Start date and time of scheduled Learning activity slot. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateStart", EmitDefaultValue = false)]
		public DateTime? DateStart { get; set; }



		/// <summary>
		/// Length of Learning activity slot in minutes
		/// </summary>
		/// <value>Length of Learning activity slot in minutes</value>
		[DataMember(Name = "lengthInMinutes", EmitDefaultValue = false)]
		public int? LengthInMinutes { get; set; }



		/// <summary>
		/// Difference between scheduled and forecast headcount for this slot after scheduling the Learning activity
		/// </summary>
		/// <value>Difference between scheduled and forecast headcount for this slot after scheduling the Learning activity</value>
		[DataMember(Name = "staffingDifference", EmitDefaultValue = false)]
		public double? StaffingDifference { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LearningSlot {\n");

			sb.Append("  DateStart: ").Append(DateStart).Append("\n");
			sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
			sb.Append("  StaffingDifference: ").Append(StaffingDifference).Append("\n");
			sb.Append("  DifferenceRating: ").Append(DifferenceRating).Append("\n");
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
			return this.Equals(obj as LearningSlot);
		}

		/// <summary>
		/// Returns true if LearningSlot instances are equal
		/// </summary>
		/// <param name="other">Instance of LearningSlot to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LearningSlot other)
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

				return hash;
			}
		}
	}

}
