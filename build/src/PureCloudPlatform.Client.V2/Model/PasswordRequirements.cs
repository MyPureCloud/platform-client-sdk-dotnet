using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PasswordRequirements
	/// </summary>
	[DataContract]
	public partial class PasswordRequirements : IEquatable<PasswordRequirements>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PasswordRequirements" /> class.
		/// </summary>
		/// <param name="MinimumLength">MinimumLength.</param>
		/// <param name="MinimumDigits">MinimumDigits.</param>
		/// <param name="MinimumLetters">MinimumLetters.</param>
		/// <param name="MinimumUpper">MinimumUpper.</param>
		/// <param name="MinimumLower">MinimumLower.</param>
		/// <param name="MinimumSpecials">MinimumSpecials.</param>
		/// <param name="MinimumAgeSeconds">MinimumAgeSeconds.</param>
		/// <param name="ExpirationDays">ExpirationDays.</param>
		public PasswordRequirements(int? MinimumLength = null, int? MinimumDigits = null, int? MinimumLetters = null, int? MinimumUpper = null, int? MinimumLower = null, int? MinimumSpecials = null, int? MinimumAgeSeconds = null, int? ExpirationDays = null)
		{
			this.MinimumLength = MinimumLength;
			this.MinimumDigits = MinimumDigits;
			this.MinimumLetters = MinimumLetters;
			this.MinimumUpper = MinimumUpper;
			this.MinimumLower = MinimumLower;
			this.MinimumSpecials = MinimumSpecials;
			this.MinimumAgeSeconds = MinimumAgeSeconds;
			this.ExpirationDays = ExpirationDays;

		}



		/// <summary>
		/// Gets or Sets MinimumLength
		/// </summary>
		[DataMember(Name = "minimumLength", EmitDefaultValue = false)]
		public int? MinimumLength { get; set; }



		/// <summary>
		/// Gets or Sets MinimumDigits
		/// </summary>
		[DataMember(Name = "minimumDigits", EmitDefaultValue = false)]
		public int? MinimumDigits { get; set; }



		/// <summary>
		/// Gets or Sets MinimumLetters
		/// </summary>
		[DataMember(Name = "minimumLetters", EmitDefaultValue = false)]
		public int? MinimumLetters { get; set; }



		/// <summary>
		/// Gets or Sets MinimumUpper
		/// </summary>
		[DataMember(Name = "minimumUpper", EmitDefaultValue = false)]
		public int? MinimumUpper { get; set; }



		/// <summary>
		/// Gets or Sets MinimumLower
		/// </summary>
		[DataMember(Name = "minimumLower", EmitDefaultValue = false)]
		public int? MinimumLower { get; set; }



		/// <summary>
		/// Gets or Sets MinimumSpecials
		/// </summary>
		[DataMember(Name = "minimumSpecials", EmitDefaultValue = false)]
		public int? MinimumSpecials { get; set; }



		/// <summary>
		/// Gets or Sets MinimumAgeSeconds
		/// </summary>
		[DataMember(Name = "minimumAgeSeconds", EmitDefaultValue = false)]
		public int? MinimumAgeSeconds { get; set; }



		/// <summary>
		/// Gets or Sets ExpirationDays
		/// </summary>
		[DataMember(Name = "expirationDays", EmitDefaultValue = false)]
		public int? ExpirationDays { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PasswordRequirements {\n");

			sb.Append("  MinimumLength: ").Append(MinimumLength).Append("\n");
			sb.Append("  MinimumDigits: ").Append(MinimumDigits).Append("\n");
			sb.Append("  MinimumLetters: ").Append(MinimumLetters).Append("\n");
			sb.Append("  MinimumUpper: ").Append(MinimumUpper).Append("\n");
			sb.Append("  MinimumLower: ").Append(MinimumLower).Append("\n");
			sb.Append("  MinimumSpecials: ").Append(MinimumSpecials).Append("\n");
			sb.Append("  MinimumAgeSeconds: ").Append(MinimumAgeSeconds).Append("\n");
			sb.Append("  ExpirationDays: ").Append(ExpirationDays).Append("\n");
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
			return this.Equals(obj as PasswordRequirements);
		}

		/// <summary>
		/// Returns true if PasswordRequirements instances are equal
		/// </summary>
		/// <param name="other">Instance of PasswordRequirements to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PasswordRequirements other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.MinimumLength == other.MinimumLength ||
					this.MinimumLength != null &&
					this.MinimumLength.Equals(other.MinimumLength)
				) &&
				(
					this.MinimumDigits == other.MinimumDigits ||
					this.MinimumDigits != null &&
					this.MinimumDigits.Equals(other.MinimumDigits)
				) &&
				(
					this.MinimumLetters == other.MinimumLetters ||
					this.MinimumLetters != null &&
					this.MinimumLetters.Equals(other.MinimumLetters)
				) &&
				(
					this.MinimumUpper == other.MinimumUpper ||
					this.MinimumUpper != null &&
					this.MinimumUpper.Equals(other.MinimumUpper)
				) &&
				(
					this.MinimumLower == other.MinimumLower ||
					this.MinimumLower != null &&
					this.MinimumLower.Equals(other.MinimumLower)
				) &&
				(
					this.MinimumSpecials == other.MinimumSpecials ||
					this.MinimumSpecials != null &&
					this.MinimumSpecials.Equals(other.MinimumSpecials)
				) &&
				(
					this.MinimumAgeSeconds == other.MinimumAgeSeconds ||
					this.MinimumAgeSeconds != null &&
					this.MinimumAgeSeconds.Equals(other.MinimumAgeSeconds)
				) &&
				(
					this.ExpirationDays == other.ExpirationDays ||
					this.ExpirationDays != null &&
					this.ExpirationDays.Equals(other.ExpirationDays)
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
				if (this.MinimumLength != null)
					hash = hash * 59 + this.MinimumLength.GetHashCode();

				if (this.MinimumDigits != null)
					hash = hash * 59 + this.MinimumDigits.GetHashCode();

				if (this.MinimumLetters != null)
					hash = hash * 59 + this.MinimumLetters.GetHashCode();

				if (this.MinimumUpper != null)
					hash = hash * 59 + this.MinimumUpper.GetHashCode();

				if (this.MinimumLower != null)
					hash = hash * 59 + this.MinimumLower.GetHashCode();

				if (this.MinimumSpecials != null)
					hash = hash * 59 + this.MinimumSpecials.GetHashCode();

				if (this.MinimumAgeSeconds != null)
					hash = hash * 59 + this.MinimumAgeSeconds.GetHashCode();

				if (this.ExpirationDays != null)
					hash = hash * 59 + this.ExpirationDays.GetHashCode();

				return hash;
			}
		}
	}

}
