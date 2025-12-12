using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Duration
	/// </summary>
	[DataContract]
	public partial class Duration : IEquatable<Duration>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Duration" /> class.
		/// </summary>
		/// <param name="Seconds">Seconds.</param>
		/// <param name="Zero">Zero.</param>
		/// <param name="Nano">Nano.</param>
		/// <param name="Negative">Negative.</param>
		/// <param name="Units">Units.</param>
		public Duration(long? Seconds = null, bool? Zero = null, int? Nano = null, bool? Negative = null, List<TemporalUnit> Units = null)
		{
			this.Seconds = Seconds;
			this.Zero = Zero;
			this.Nano = Nano;
			this.Negative = Negative;
			this.Units = Units;

		}



		/// <summary>
		/// Gets or Sets Seconds
		/// </summary>
		[DataMember(Name = "seconds", EmitDefaultValue = false)]
		public long? Seconds { get; set; }



		/// <summary>
		/// Gets or Sets Zero
		/// </summary>
		[DataMember(Name = "zero", EmitDefaultValue = false)]
		public bool? Zero { get; set; }



		/// <summary>
		/// Gets or Sets Nano
		/// </summary>
		[DataMember(Name = "nano", EmitDefaultValue = false)]
		public int? Nano { get; set; }



		/// <summary>
		/// Gets or Sets Negative
		/// </summary>
		[DataMember(Name = "negative", EmitDefaultValue = false)]
		public bool? Negative { get; set; }



		/// <summary>
		/// Gets or Sets Units
		/// </summary>
		[DataMember(Name = "units", EmitDefaultValue = false)]
		public List<TemporalUnit> Units { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Duration {\n");

			sb.Append("  Seconds: ").Append(Seconds).Append("\n");
			sb.Append("  Zero: ").Append(Zero).Append("\n");
			sb.Append("  Nano: ").Append(Nano).Append("\n");
			sb.Append("  Negative: ").Append(Negative).Append("\n");
			sb.Append("  Units: ").Append(Units).Append("\n");
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
			return this.Equals(obj as Duration);
		}

		/// <summary>
		/// Returns true if Duration instances are equal
		/// </summary>
		/// <param name="other">Instance of Duration to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Duration other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Seconds == other.Seconds ||
					this.Seconds != null &&
					this.Seconds.Equals(other.Seconds)
				) &&
				(
					this.Zero == other.Zero ||
					this.Zero != null &&
					this.Zero.Equals(other.Zero)
				) &&
				(
					this.Nano == other.Nano ||
					this.Nano != null &&
					this.Nano.Equals(other.Nano)
				) &&
				(
					this.Negative == other.Negative ||
					this.Negative != null &&
					this.Negative.Equals(other.Negative)
				) &&
				(
					this.Units == other.Units ||
					this.Units != null &&
					this.Units.SequenceEqual(other.Units)
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
				if (this.Seconds != null)
					hash = hash * 59 + this.Seconds.GetHashCode();

				if (this.Zero != null)
					hash = hash * 59 + this.Zero.GetHashCode();

				if (this.Nano != null)
					hash = hash * 59 + this.Nano.GetHashCode();

				if (this.Negative != null)
					hash = hash * 59 + this.Negative.GetHashCode();

				if (this.Units != null)
					hash = hash * 59 + this.Units.GetHashCode();

				return hash;
			}
		}
	}

}
