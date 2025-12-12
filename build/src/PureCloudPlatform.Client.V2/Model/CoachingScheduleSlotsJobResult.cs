using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CoachingScheduleSlotsJobResult
	/// </summary>
	[DataContract]
	public partial class CoachingScheduleSlotsJobResult : IEquatable<CoachingScheduleSlotsJobResult>
	{
		/// <summary>
		/// The status of the job
		/// </summary>
		/// <value>The status of the job</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Inprogress for "InProgress"
			/// </summary>
			[EnumMember(Value = "InProgress")]
			Inprogress,

			/// <summary>
			/// Enum Complete for "Complete"
			/// </summary>
			[EnumMember(Value = "Complete")]
			Complete,

			/// <summary>
			/// Enum Error for "Error"
			/// </summary>
			[EnumMember(Value = "Error")]
			Error
		}
		/// <summary>
		/// The status of the job
		/// </summary>
		/// <value>The status of the job</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="CoachingScheduleSlotsJobResult" /> class.
		/// </summary>
		/// <param name="Interval">The interval of the job. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
		/// <param name="Status">The status of the job.</param>
		/// <param name="Slot">The slot found from the job.</param>
		/// <param name="HasConflict">True if the slot conflicts with a Coaching Appointment.</param>
		public CoachingScheduleSlotsJobResult(string Interval = null, StatusEnum? Status = null, CoachingScheduleSlotsJobSlot Slot = null, bool? HasConflict = null)
		{
			this.Interval = Interval;
			this.Status = Status;
			this.Slot = Slot;
			this.HasConflict = HasConflict;

		}



		/// <summary>
		/// The interval of the job. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
		/// </summary>
		/// <value>The interval of the job. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
		[DataMember(Name = "interval", EmitDefaultValue = false)]
		public string Interval { get; set; }





		/// <summary>
		/// The slot found from the job
		/// </summary>
		/// <value>The slot found from the job</value>
		[DataMember(Name = "slot", EmitDefaultValue = false)]
		public CoachingScheduleSlotsJobSlot Slot { get; set; }



		/// <summary>
		/// True if the slot conflicts with a Coaching Appointment
		/// </summary>
		/// <value>True if the slot conflicts with a Coaching Appointment</value>
		[DataMember(Name = "hasConflict", EmitDefaultValue = false)]
		public bool? HasConflict { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CoachingScheduleSlotsJobResult {\n");

			sb.Append("  Interval: ").Append(Interval).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Slot: ").Append(Slot).Append("\n");
			sb.Append("  HasConflict: ").Append(HasConflict).Append("\n");
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
			return this.Equals(obj as CoachingScheduleSlotsJobResult);
		}

		/// <summary>
		/// Returns true if CoachingScheduleSlotsJobResult instances are equal
		/// </summary>
		/// <param name="other">Instance of CoachingScheduleSlotsJobResult to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CoachingScheduleSlotsJobResult other)
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
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.Slot == other.Slot ||
					this.Slot != null &&
					this.Slot.Equals(other.Slot)
				) &&
				(
					this.HasConflict == other.HasConflict ||
					this.HasConflict != null &&
					this.HasConflict.Equals(other.HasConflict)
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

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.Slot != null)
					hash = hash * 59 + this.Slot.GetHashCode();

				if (this.HasConflict != null)
					hash = hash * 59 + this.HasConflict.GetHashCode();

				return hash;
			}
		}
	}

}
