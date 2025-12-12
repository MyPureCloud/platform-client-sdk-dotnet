using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// FacetStatistics
	/// </summary>
	[DataContract]
	public partial class FacetStatistics : IEquatable<FacetStatistics>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FacetStatistics" /> class.
		/// </summary>
		/// <param name="Count">Count.</param>
		/// <param name="Min">Min.</param>
		/// <param name="Max">Max.</param>
		/// <param name="Mean">Mean.</param>
		/// <param name="StdDeviation">StdDeviation.</param>
		/// <param name="DateMin">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DateMax">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		public FacetStatistics(long? Count = null, double? Min = null, double? Max = null, double? Mean = null, double? StdDeviation = null, DateTime? DateMin = null, DateTime? DateMax = null)
		{
			this.Count = Count;
			this.Min = Min;
			this.Max = Max;
			this.Mean = Mean;
			this.StdDeviation = StdDeviation;
			this.DateMin = DateMin;
			this.DateMax = DateMax;

		}



		/// <summary>
		/// Gets or Sets Count
		/// </summary>
		[DataMember(Name = "count", EmitDefaultValue = false)]
		public long? Count { get; set; }



		/// <summary>
		/// Gets or Sets Min
		/// </summary>
		[DataMember(Name = "min", EmitDefaultValue = false)]
		public double? Min { get; set; }



		/// <summary>
		/// Gets or Sets Max
		/// </summary>
		[DataMember(Name = "max", EmitDefaultValue = false)]
		public double? Max { get; set; }



		/// <summary>
		/// Gets or Sets Mean
		/// </summary>
		[DataMember(Name = "mean", EmitDefaultValue = false)]
		public double? Mean { get; set; }



		/// <summary>
		/// Gets or Sets StdDeviation
		/// </summary>
		[DataMember(Name = "stdDeviation", EmitDefaultValue = false)]
		public double? StdDeviation { get; set; }



		/// <summary>
		/// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateMin", EmitDefaultValue = false)]
		public DateTime? DateMin { get; set; }



		/// <summary>
		/// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateMax", EmitDefaultValue = false)]
		public DateTime? DateMax { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FacetStatistics {\n");

			sb.Append("  Count: ").Append(Count).Append("\n");
			sb.Append("  Min: ").Append(Min).Append("\n");
			sb.Append("  Max: ").Append(Max).Append("\n");
			sb.Append("  Mean: ").Append(Mean).Append("\n");
			sb.Append("  StdDeviation: ").Append(StdDeviation).Append("\n");
			sb.Append("  DateMin: ").Append(DateMin).Append("\n");
			sb.Append("  DateMax: ").Append(DateMax).Append("\n");
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
			return this.Equals(obj as FacetStatistics);
		}

		/// <summary>
		/// Returns true if FacetStatistics instances are equal
		/// </summary>
		/// <param name="other">Instance of FacetStatistics to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FacetStatistics other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Count == other.Count ||
					this.Count != null &&
					this.Count.Equals(other.Count)
				) &&
				(
					this.Min == other.Min ||
					this.Min != null &&
					this.Min.Equals(other.Min)
				) &&
				(
					this.Max == other.Max ||
					this.Max != null &&
					this.Max.Equals(other.Max)
				) &&
				(
					this.Mean == other.Mean ||
					this.Mean != null &&
					this.Mean.Equals(other.Mean)
				) &&
				(
					this.StdDeviation == other.StdDeviation ||
					this.StdDeviation != null &&
					this.StdDeviation.Equals(other.StdDeviation)
				) &&
				(
					this.DateMin == other.DateMin ||
					this.DateMin != null &&
					this.DateMin.Equals(other.DateMin)
				) &&
				(
					this.DateMax == other.DateMax ||
					this.DateMax != null &&
					this.DateMax.Equals(other.DateMax)
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
				if (this.Count != null)
					hash = hash * 59 + this.Count.GetHashCode();

				if (this.Min != null)
					hash = hash * 59 + this.Min.GetHashCode();

				if (this.Max != null)
					hash = hash * 59 + this.Max.GetHashCode();

				if (this.Mean != null)
					hash = hash * 59 + this.Mean.GetHashCode();

				if (this.StdDeviation != null)
					hash = hash * 59 + this.StdDeviation.GetHashCode();

				if (this.DateMin != null)
					hash = hash * 59 + this.DateMin.GetHashCode();

				if (this.DateMax != null)
					hash = hash * 59 + this.DateMax.GetHashCode();

				return hash;
			}
		}
	}

}
