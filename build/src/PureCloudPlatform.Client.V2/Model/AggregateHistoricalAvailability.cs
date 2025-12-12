using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AggregateHistoricalAvailability
	/// </summary>
	[DataContract]
	public partial class AggregateHistoricalAvailability : IEquatable<AggregateHistoricalAvailability>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AggregateHistoricalAvailability" /> class.
		/// </summary>
		/// <param name="Weekly">All available week offsets from the historical start date..</param>
		/// <param name="Yearly">All available historical year offsets from the forecast start date..</param>
		public AggregateHistoricalAvailability(List<int?> Weekly = null, List<int?> Yearly = null)
		{
			this.Weekly = Weekly;
			this.Yearly = Yearly;

		}



		/// <summary>
		/// All available week offsets from the historical start date.
		/// </summary>
		/// <value>All available week offsets from the historical start date.</value>
		[DataMember(Name = "weekly", EmitDefaultValue = false)]
		public List<int?> Weekly { get; set; }



		/// <summary>
		/// All available historical year offsets from the forecast start date.
		/// </summary>
		/// <value>All available historical year offsets from the forecast start date.</value>
		[DataMember(Name = "yearly", EmitDefaultValue = false)]
		public List<int?> Yearly { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AggregateHistoricalAvailability {\n");

			sb.Append("  Weekly: ").Append(Weekly).Append("\n");
			sb.Append("  Yearly: ").Append(Yearly).Append("\n");
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
			return this.Equals(obj as AggregateHistoricalAvailability);
		}

		/// <summary>
		/// Returns true if AggregateHistoricalAvailability instances are equal
		/// </summary>
		/// <param name="other">Instance of AggregateHistoricalAvailability to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AggregateHistoricalAvailability other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Weekly == other.Weekly ||
					this.Weekly != null &&
					this.Weekly.SequenceEqual(other.Weekly)
				) &&
				(
					this.Yearly == other.Yearly ||
					this.Yearly != null &&
					this.Yearly.SequenceEqual(other.Yearly)
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
				if (this.Weekly != null)
					hash = hash * 59 + this.Weekly.GetHashCode();

				if (this.Yearly != null)
					hash = hash * 59 + this.Yearly.GetHashCode();

				return hash;
			}
		}
	}

}
