using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DialerCallabletimesetConfigChangeTimeSlot
	/// </summary>
	[DataContract]
	public partial class DialerCallabletimesetConfigChangeTimeSlot : IEquatable<DialerCallabletimesetConfigChangeTimeSlot>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DialerCallabletimesetConfigChangeTimeSlot" /> class.
		/// </summary>
		/// <param name="StartTime">The start time of this time slot.</param>
		/// <param name="StopTime">The stop time of this time slot.</param>
		/// <param name="Day">The day this time slot applies.</param>
		/// <param name="AdditionalProperties">AdditionalProperties.</param>
		/// <param name="GetAdditionalProperties">GetAdditionalProperties.</param>
		public DialerCallabletimesetConfigChangeTimeSlot(string StartTime = null, string StopTime = null, long? Day = null, Dictionary<string, Object> AdditionalProperties = null, Dictionary<string, Object> GetAdditionalProperties = null)
		{
			this.StartTime = StartTime;
			this.StopTime = StopTime;
			this.Day = Day;
			this.AdditionalProperties = AdditionalProperties;
			this.GetAdditionalProperties = GetAdditionalProperties;

		}



		/// <summary>
		/// The start time of this time slot
		/// </summary>
		/// <value>The start time of this time slot</value>
		[DataMember(Name = "startTime", EmitDefaultValue = false)]
		public string StartTime { get; set; }



		/// <summary>
		/// The stop time of this time slot
		/// </summary>
		/// <value>The stop time of this time slot</value>
		[DataMember(Name = "stopTime", EmitDefaultValue = false)]
		public string StopTime { get; set; }



		/// <summary>
		/// The day this time slot applies
		/// </summary>
		/// <value>The day this time slot applies</value>
		[DataMember(Name = "day", EmitDefaultValue = false)]
		public long? Day { get; set; }



		/// <summary>
		/// Gets or Sets AdditionalProperties
		/// </summary>
		[DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
		public Dictionary<string, Object> AdditionalProperties { get; set; }



		/// <summary>
		/// Gets or Sets GetAdditionalProperties
		/// </summary>
		[DataMember(Name = "getAdditionalProperties", EmitDefaultValue = false)]
		public Dictionary<string, Object> GetAdditionalProperties { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DialerCallabletimesetConfigChangeTimeSlot {\n");

			sb.Append("  StartTime: ").Append(StartTime).Append("\n");
			sb.Append("  StopTime: ").Append(StopTime).Append("\n");
			sb.Append("  Day: ").Append(Day).Append("\n");
			sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
			sb.Append("  GetAdditionalProperties: ").Append(GetAdditionalProperties).Append("\n");
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
			return this.Equals(obj as DialerCallabletimesetConfigChangeTimeSlot);
		}

		/// <summary>
		/// Returns true if DialerCallabletimesetConfigChangeTimeSlot instances are equal
		/// </summary>
		/// <param name="other">Instance of DialerCallabletimesetConfigChangeTimeSlot to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DialerCallabletimesetConfigChangeTimeSlot other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.StartTime == other.StartTime ||
					this.StartTime != null &&
					this.StartTime.Equals(other.StartTime)
				) &&
				(
					this.StopTime == other.StopTime ||
					this.StopTime != null &&
					this.StopTime.Equals(other.StopTime)
				) &&
				(
					this.Day == other.Day ||
					this.Day != null &&
					this.Day.Equals(other.Day)
				) &&
				(
					this.AdditionalProperties == other.AdditionalProperties ||
					this.AdditionalProperties != null &&
					this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
				) &&
				(
					this.GetAdditionalProperties == other.GetAdditionalProperties ||
					this.GetAdditionalProperties != null &&
					this.GetAdditionalProperties.SequenceEqual(other.GetAdditionalProperties)
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
				if (this.StartTime != null)
					hash = hash * 59 + this.StartTime.GetHashCode();

				if (this.StopTime != null)
					hash = hash * 59 + this.StopTime.GetHashCode();

				if (this.Day != null)
					hash = hash * 59 + this.Day.GetHashCode();

				if (this.AdditionalProperties != null)
					hash = hash * 59 + this.AdditionalProperties.GetHashCode();

				if (this.GetAdditionalProperties != null)
					hash = hash * 59 + this.GetAdditionalProperties.GetHashCode();

				return hash;
			}
		}
	}

}
