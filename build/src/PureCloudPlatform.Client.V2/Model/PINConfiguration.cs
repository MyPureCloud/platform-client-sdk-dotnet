using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PINConfiguration
	/// </summary>
	[DataContract]
	public partial class PINConfiguration : IEquatable<PINConfiguration>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PINConfiguration" /> class.
		/// </summary>
		/// <param name="MinimumLength">MinimumLength.</param>
		/// <param name="MaximumLength">MaximumLength.</param>
		public PINConfiguration(int? MinimumLength = null, int? MaximumLength = null)
		{
			this.MinimumLength = MinimumLength;
			this.MaximumLength = MaximumLength;

		}



		/// <summary>
		/// Gets or Sets MinimumLength
		/// </summary>
		[DataMember(Name = "minimumLength", EmitDefaultValue = false)]
		public int? MinimumLength { get; set; }



		/// <summary>
		/// Gets or Sets MaximumLength
		/// </summary>
		[DataMember(Name = "maximumLength", EmitDefaultValue = false)]
		public int? MaximumLength { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PINConfiguration {\n");

			sb.Append("  MinimumLength: ").Append(MinimumLength).Append("\n");
			sb.Append("  MaximumLength: ").Append(MaximumLength).Append("\n");
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
			return this.Equals(obj as PINConfiguration);
		}

		/// <summary>
		/// Returns true if PINConfiguration instances are equal
		/// </summary>
		/// <param name="other">Instance of PINConfiguration to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PINConfiguration other)
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
					this.MaximumLength == other.MaximumLength ||
					this.MaximumLength != null &&
					this.MaximumLength.Equals(other.MaximumLength)
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

				if (this.MaximumLength != null)
					hash = hash * 59 + this.MaximumLength.GetHashCode();

				return hash;
			}
		}
	}

}
