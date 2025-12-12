using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Range
	/// </summary>
	[DataContract]
	public partial class Range : IEquatable<Range>
	{
		/// <summary>
		/// Range type (NoEnd: without an end date. EndDate: with an end date. Numbered: with a specific number of occurrences)
		/// </summary>
		/// <value>Range type (NoEnd: without an end date. EndDate: with an end date. Numbered: with a specific number of occurrences)</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Noend for "NoEnd"
			/// </summary>
			[EnumMember(Value = "NoEnd")]
			Noend,

			/// <summary>
			/// Enum Enddate for "EndDate"
			/// </summary>
			[EnumMember(Value = "EndDate")]
			Enddate,

			/// <summary>
			/// Enum Numbered for "Numbered"
			/// </summary>
			[EnumMember(Value = "Numbered")]
			Numbered
		}
		/// <summary>
		/// Range type (NoEnd: without an end date. EndDate: with an end date. Numbered: with a specific number of occurrences)
		/// </summary>
		/// <value>Range type (NoEnd: without an end date. EndDate: with an end date. Numbered: with a specific number of occurrences)</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Range" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected Range() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Range" /> class.
		/// </summary>
		/// <param name="Type">Range type (NoEnd: without an end date. EndDate: with an end date. Numbered: with a specific number of occurrences) (required).</param>
		/// <param name="End">The end date time of the last occurrence of the range as an ISO-8601 string. Required for EndDate range type..</param>
		/// <param name="NumberOfOccurrences">The number of times the schedule will be repeated, e.g: 2. Required to set for Numbered range type..</param>
		public Range(TypeEnum? Type = null, string End = null, int? NumberOfOccurrences = null)
		{
			this.Type = Type;
			this.End = End;
			this.NumberOfOccurrences = NumberOfOccurrences;

		}





		/// <summary>
		/// The end date time of the last occurrence of the range as an ISO-8601 string. Required for EndDate range type.
		/// </summary>
		/// <value>The end date time of the last occurrence of the range as an ISO-8601 string. Required for EndDate range type.</value>
		[DataMember(Name = "end", EmitDefaultValue = false)]
		public string End { get; set; }



		/// <summary>
		/// The number of times the schedule will be repeated, e.g: 2. Required to set for Numbered range type.
		/// </summary>
		/// <value>The number of times the schedule will be repeated, e.g: 2. Required to set for Numbered range type.</value>
		[DataMember(Name = "numberOfOccurrences", EmitDefaultValue = false)]
		public int? NumberOfOccurrences { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Range {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  End: ").Append(End).Append("\n");
			sb.Append("  NumberOfOccurrences: ").Append(NumberOfOccurrences).Append("\n");
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
			return this.Equals(obj as Range);
		}

		/// <summary>
		/// Returns true if Range instances are equal
		/// </summary>
		/// <param name="other">Instance of Range to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Range other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.End == other.End ||
					this.End != null &&
					this.End.Equals(other.End)
				) &&
				(
					this.NumberOfOccurrences == other.NumberOfOccurrences ||
					this.NumberOfOccurrences != null &&
					this.NumberOfOccurrences.Equals(other.NumberOfOccurrences)
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
				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.End != null)
					hash = hash * 59 + this.End.GetHashCode();

				if (this.NumberOfOccurrences != null)
					hash = hash * 59 + this.NumberOfOccurrences.GetHashCode();

				return hash;
			}
		}
	}

}
