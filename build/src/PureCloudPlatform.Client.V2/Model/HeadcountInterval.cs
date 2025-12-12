using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// HeadcountInterval
	/// </summary>
	[DataContract]
	public partial class HeadcountInterval : IEquatable<HeadcountInterval>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="HeadcountInterval" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected HeadcountInterval() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="HeadcountInterval" /> class.
		/// </summary>
		/// <param name="Interval">The start date-time for this headcount interval in ISO-8601 format, must be within the 8 day schedule (required).</param>
		/// <param name="Value">Headcount value for this interval (required).</param>
		public HeadcountInterval(DateTime? Interval = null, double? Value = null)
		{
			this.Interval = Interval;
			this.Value = Value;

		}



		/// <summary>
		/// The start date-time for this headcount interval in ISO-8601 format, must be within the 8 day schedule
		/// </summary>
		/// <value>The start date-time for this headcount interval in ISO-8601 format, must be within the 8 day schedule</value>
		[DataMember(Name = "interval", EmitDefaultValue = false)]
		public DateTime? Interval { get; set; }



		/// <summary>
		/// Headcount value for this interval
		/// </summary>
		/// <value>Headcount value for this interval</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public double? Value { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class HeadcountInterval {\n");

			sb.Append("  Interval: ").Append(Interval).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
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
			return this.Equals(obj as HeadcountInterval);
		}

		/// <summary>
		/// Returns true if HeadcountInterval instances are equal
		/// </summary>
		/// <param name="other">Instance of HeadcountInterval to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(HeadcountInterval other)
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
					this.Value == other.Value ||
					this.Value != null &&
					this.Value.Equals(other.Value)
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

				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				return hash;
			}
		}
	}

}
