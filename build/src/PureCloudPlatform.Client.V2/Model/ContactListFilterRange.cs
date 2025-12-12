using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContactListFilterRange
	/// </summary>
	[DataContract]
	public partial class ContactListFilterRange : IEquatable<ContactListFilterRange>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactListFilterRange" /> class.
		/// </summary>
		/// <param name="Min">The minimum value of the range. Required for the operator BETWEEN..</param>
		/// <param name="Max">The maximum value of the range. Required for the operator BETWEEN..</param>
		/// <param name="MinInclusive">Whether or not to include the minimum in the range..</param>
		/// <param name="MaxInclusive">Whether or not to include the maximum in the range..</param>
		/// <param name="InSet">A set of values that the contact data should be in. Required for the IN operator..</param>
		public ContactListFilterRange(string Min = null, string Max = null, bool? MinInclusive = null, bool? MaxInclusive = null, List<string> InSet = null)
		{
			this.Min = Min;
			this.Max = Max;
			this.MinInclusive = MinInclusive;
			this.MaxInclusive = MaxInclusive;
			this.InSet = InSet;

		}



		/// <summary>
		/// The minimum value of the range. Required for the operator BETWEEN.
		/// </summary>
		/// <value>The minimum value of the range. Required for the operator BETWEEN.</value>
		[DataMember(Name = "min", EmitDefaultValue = false)]
		public string Min { get; set; }



		/// <summary>
		/// The maximum value of the range. Required for the operator BETWEEN.
		/// </summary>
		/// <value>The maximum value of the range. Required for the operator BETWEEN.</value>
		[DataMember(Name = "max", EmitDefaultValue = false)]
		public string Max { get; set; }



		/// <summary>
		/// Whether or not to include the minimum in the range.
		/// </summary>
		/// <value>Whether or not to include the minimum in the range.</value>
		[DataMember(Name = "minInclusive", EmitDefaultValue = false)]
		public bool? MinInclusive { get; set; }



		/// <summary>
		/// Whether or not to include the maximum in the range.
		/// </summary>
		/// <value>Whether or not to include the maximum in the range.</value>
		[DataMember(Name = "maxInclusive", EmitDefaultValue = false)]
		public bool? MaxInclusive { get; set; }



		/// <summary>
		/// A set of values that the contact data should be in. Required for the IN operator.
		/// </summary>
		/// <value>A set of values that the contact data should be in. Required for the IN operator.</value>
		[DataMember(Name = "inSet", EmitDefaultValue = false)]
		public List<string> InSet { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ContactListFilterRange {\n");

			sb.Append("  Min: ").Append(Min).Append("\n");
			sb.Append("  Max: ").Append(Max).Append("\n");
			sb.Append("  MinInclusive: ").Append(MinInclusive).Append("\n");
			sb.Append("  MaxInclusive: ").Append(MaxInclusive).Append("\n");
			sb.Append("  InSet: ").Append(InSet).Append("\n");
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
			return this.Equals(obj as ContactListFilterRange);
		}

		/// <summary>
		/// Returns true if ContactListFilterRange instances are equal
		/// </summary>
		/// <param name="other">Instance of ContactListFilterRange to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContactListFilterRange other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
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
					this.MinInclusive == other.MinInclusive ||
					this.MinInclusive != null &&
					this.MinInclusive.Equals(other.MinInclusive)
				) &&
				(
					this.MaxInclusive == other.MaxInclusive ||
					this.MaxInclusive != null &&
					this.MaxInclusive.Equals(other.MaxInclusive)
				) &&
				(
					this.InSet == other.InSet ||
					this.InSet != null &&
					this.InSet.SequenceEqual(other.InSet)
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
				if (this.Min != null)
					hash = hash * 59 + this.Min.GetHashCode();

				if (this.Max != null)
					hash = hash * 59 + this.Max.GetHashCode();

				if (this.MinInclusive != null)
					hash = hash * 59 + this.MinInclusive.GetHashCode();

				if (this.MaxInclusive != null)
					hash = hash * 59 + this.MaxInclusive.GetHashCode();

				if (this.InSet != null)
					hash = hash * 59 + this.InSet.GetHashCode();

				return hash;
			}
		}
	}

}
