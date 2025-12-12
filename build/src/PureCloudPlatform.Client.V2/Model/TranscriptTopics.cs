using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TranscriptTopics
	/// </summary>
	[DataContract]
	public partial class TranscriptTopics : IEquatable<TranscriptTopics>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TranscriptTopics" /> class.
		/// </summary>
		/// <param name="Includes">List of topics which need to be included in exact match criteria. This field is not mutually exclusive with excludes topic list..</param>
		/// <param name="Excludes">List of topics which need to be excluded in exact match criteria. This field is not mutually exclusive with includes topic list..</param>
		public TranscriptTopics(List<string> Includes = null, List<string> Excludes = null)
		{
			this.Includes = Includes;
			this.Excludes = Excludes;

		}



		/// <summary>
		/// List of topics which need to be included in exact match criteria. This field is not mutually exclusive with excludes topic list.
		/// </summary>
		/// <value>List of topics which need to be included in exact match criteria. This field is not mutually exclusive with excludes topic list.</value>
		[DataMember(Name = "includes", EmitDefaultValue = false)]
		public List<string> Includes { get; set; }



		/// <summary>
		/// List of topics which need to be excluded in exact match criteria. This field is not mutually exclusive with includes topic list.
		/// </summary>
		/// <value>List of topics which need to be excluded in exact match criteria. This field is not mutually exclusive with includes topic list.</value>
		[DataMember(Name = "excludes", EmitDefaultValue = false)]
		public List<string> Excludes { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TranscriptTopics {\n");

			sb.Append("  Includes: ").Append(Includes).Append("\n");
			sb.Append("  Excludes: ").Append(Excludes).Append("\n");
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
			return this.Equals(obj as TranscriptTopics);
		}

		/// <summary>
		/// Returns true if TranscriptTopics instances are equal
		/// </summary>
		/// <param name="other">Instance of TranscriptTopics to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TranscriptTopics other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Includes == other.Includes ||
					this.Includes != null &&
					this.Includes.SequenceEqual(other.Includes)
				) &&
				(
					this.Excludes == other.Excludes ||
					this.Excludes != null &&
					this.Excludes.SequenceEqual(other.Excludes)
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
				if (this.Includes != null)
					hash = hash * 59 + this.Includes.GetHashCode();

				if (this.Excludes != null)
					hash = hash * 59 + this.Excludes.GetHashCode();

				return hash;
			}
		}
	}

}
