using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// A journey view result
	/// </summary>
	[DataContract]
	public partial class JourneyViewResult : IEquatable<JourneyViewResult>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="JourneyViewResult" /> class.
		/// </summary>
		public JourneyViewResult()
		{

		}



		/// <summary>
		/// The elements within the journey view result
		/// </summary>
		/// <value>The elements within the journey view result</value>
		[DataMember(Name = "elements", EmitDefaultValue = false)]
		public List<JourneyViewResultElement> Elements { get; private set; }



		/// <summary>
		/// The chart results within the journey view result
		/// </summary>
		/// <value>The chart results within the journey view result</value>
		[DataMember(Name = "charts", EmitDefaultValue = false)]
		public List<JourneyViewChartResult> Charts { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JourneyViewResult {\n");

			sb.Append("  Elements: ").Append(Elements).Append("\n");
			sb.Append("  Charts: ").Append(Charts).Append("\n");
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
			return this.Equals(obj as JourneyViewResult);
		}

		/// <summary>
		/// Returns true if JourneyViewResult instances are equal
		/// </summary>
		/// <param name="other">Instance of JourneyViewResult to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JourneyViewResult other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Elements == other.Elements ||
					this.Elements != null &&
					this.Elements.SequenceEqual(other.Elements)
				) &&
				(
					this.Charts == other.Charts ||
					this.Charts != null &&
					this.Charts.SequenceEqual(other.Charts)
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
				if (this.Elements != null)
					hash = hash * 59 + this.Elements.GetHashCode();

				if (this.Charts != null)
					hash = hash * 59 + this.Charts.GetHashCode();

				return hash;
			}
		}
	}

}
