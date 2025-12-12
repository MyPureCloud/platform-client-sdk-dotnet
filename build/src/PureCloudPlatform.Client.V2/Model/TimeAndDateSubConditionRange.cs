using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TimeAndDateSubConditionRange
	/// </summary>
	[DataContract]
	public partial class TimeAndDateSubConditionRange : IEquatable<TimeAndDateSubConditionRange>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TimeAndDateSubConditionRange" /> class.
		/// </summary>
		/// <param name="Min">The minimum value of the range. Required for the operator BETWEEN. Format depends on type: timeOfDay: HH:mm, dayOfWeek: 1-7 (Monday-Sunday), dayOfMonth: 1-31, specificDate: yyyy-MM-dd (if includeYear&#x3D;true) or MM-dd (if includeYear&#x3D;false)..</param>
		/// <param name="Max">The maximum value of the range. Required for the operator BETWEEN. Format follows the same rules as &#39;min&#39;..</param>
		/// <param name="InSet">A set of values that the date/ time data should be in. Required for the IN operator. Format depends on type: dayOfWeek: 1-7 (Monday-Sunday), dayOfMonth: 1-31, and/ or LAST_DAY, ODD_DAY, EVEN_DAY,specificDate: yyyy-MM-dd (if includeYear&#x3D;true) or MM-dd (if includeYear&#x3D;false)..</param>
		public TimeAndDateSubConditionRange(string Min = null, string Max = null, List<string> InSet = null)
		{
			this.Min = Min;
			this.Max = Max;
			this.InSet = InSet;

		}



		/// <summary>
		/// The minimum value of the range. Required for the operator BETWEEN. Format depends on type: timeOfDay: HH:mm, dayOfWeek: 1-7 (Monday-Sunday), dayOfMonth: 1-31, specificDate: yyyy-MM-dd (if includeYear&#x3D;true) or MM-dd (if includeYear&#x3D;false).
		/// </summary>
		/// <value>The minimum value of the range. Required for the operator BETWEEN. Format depends on type: timeOfDay: HH:mm, dayOfWeek: 1-7 (Monday-Sunday), dayOfMonth: 1-31, specificDate: yyyy-MM-dd (if includeYear&#x3D;true) or MM-dd (if includeYear&#x3D;false).</value>
		[DataMember(Name = "min", EmitDefaultValue = false)]
		public string Min { get; set; }



		/// <summary>
		/// The maximum value of the range. Required for the operator BETWEEN. Format follows the same rules as &#39;min&#39;.
		/// </summary>
		/// <value>The maximum value of the range. Required for the operator BETWEEN. Format follows the same rules as &#39;min&#39;.</value>
		[DataMember(Name = "max", EmitDefaultValue = false)]
		public string Max { get; set; }



		/// <summary>
		/// A set of values that the date/ time data should be in. Required for the IN operator. Format depends on type: dayOfWeek: 1-7 (Monday-Sunday), dayOfMonth: 1-31, and/ or LAST_DAY, ODD_DAY, EVEN_DAY,specificDate: yyyy-MM-dd (if includeYear&#x3D;true) or MM-dd (if includeYear&#x3D;false).
		/// </summary>
		/// <value>A set of values that the date/ time data should be in. Required for the IN operator. Format depends on type: dayOfWeek: 1-7 (Monday-Sunday), dayOfMonth: 1-31, and/ or LAST_DAY, ODD_DAY, EVEN_DAY,specificDate: yyyy-MM-dd (if includeYear&#x3D;true) or MM-dd (if includeYear&#x3D;false).</value>
		[DataMember(Name = "inSet", EmitDefaultValue = false)]
		public List<string> InSet { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TimeAndDateSubConditionRange {\n");

			sb.Append("  Min: ").Append(Min).Append("\n");
			sb.Append("  Max: ").Append(Max).Append("\n");
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
			return this.Equals(obj as TimeAndDateSubConditionRange);
		}

		/// <summary>
		/// Returns true if TimeAndDateSubConditionRange instances are equal
		/// </summary>
		/// <param name="other">Instance of TimeAndDateSubConditionRange to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TimeAndDateSubConditionRange other)
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

				if (this.InSet != null)
					hash = hash * 59 + this.InSet.GetHashCode();

				return hash;
			}
		}
	}

}
