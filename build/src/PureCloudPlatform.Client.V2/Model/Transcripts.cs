using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Transcripts
	/// </summary>
	[DataContract]
	public partial class Transcripts : IEquatable<Transcripts>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Transcripts" /> class.
		/// </summary>
		/// <param name="ExactMatch">List of transcript contents which needs to satisfy exact match criteria.</param>
		/// <param name="Contains">List of transcript contents which needs to satisfy contains criteria.</param>
		/// <param name="DoesNotContain">List of transcript contents which needs to satisfy does not contain criteria.</param>
		/// <param name="NotSimilarTo">List of words or phrases used to filter out transcripts that contain content similar to any item in this list.</param>
		public Transcripts(List<string> ExactMatch = null, List<string> Contains = null, List<string> DoesNotContain = null, List<string> NotSimilarTo = null)
		{
			this.ExactMatch = ExactMatch;
			this.Contains = Contains;
			this.DoesNotContain = DoesNotContain;
			this.NotSimilarTo = NotSimilarTo;

		}



		/// <summary>
		/// List of transcript contents which needs to satisfy exact match criteria
		/// </summary>
		/// <value>List of transcript contents which needs to satisfy exact match criteria</value>
		[DataMember(Name = "exactMatch", EmitDefaultValue = false)]
		public List<string> ExactMatch { get; set; }



		/// <summary>
		/// List of transcript contents which needs to satisfy contains criteria
		/// </summary>
		/// <value>List of transcript contents which needs to satisfy contains criteria</value>
		[DataMember(Name = "contains", EmitDefaultValue = false)]
		public List<string> Contains { get; set; }



		/// <summary>
		/// List of transcript contents which needs to satisfy does not contain criteria
		/// </summary>
		/// <value>List of transcript contents which needs to satisfy does not contain criteria</value>
		[DataMember(Name = "doesNotContain", EmitDefaultValue = false)]
		public List<string> DoesNotContain { get; set; }



		/// <summary>
		/// List of words or phrases used to filter out transcripts that contain content similar to any item in this list
		/// </summary>
		/// <value>List of words or phrases used to filter out transcripts that contain content similar to any item in this list</value>
		[DataMember(Name = "notSimilarTo", EmitDefaultValue = false)]
		public List<string> NotSimilarTo { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Transcripts {\n");

			sb.Append("  ExactMatch: ").Append(ExactMatch).Append("\n");
			sb.Append("  Contains: ").Append(Contains).Append("\n");
			sb.Append("  DoesNotContain: ").Append(DoesNotContain).Append("\n");
			sb.Append("  NotSimilarTo: ").Append(NotSimilarTo).Append("\n");
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
			return this.Equals(obj as Transcripts);
		}

		/// <summary>
		/// Returns true if Transcripts instances are equal
		/// </summary>
		/// <param name="other">Instance of Transcripts to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Transcripts other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ExactMatch == other.ExactMatch ||
					this.ExactMatch != null &&
					this.ExactMatch.SequenceEqual(other.ExactMatch)
				) &&
				(
					this.Contains == other.Contains ||
					this.Contains != null &&
					this.Contains.SequenceEqual(other.Contains)
				) &&
				(
					this.DoesNotContain == other.DoesNotContain ||
					this.DoesNotContain != null &&
					this.DoesNotContain.SequenceEqual(other.DoesNotContain)
				) &&
				(
					this.NotSimilarTo == other.NotSimilarTo ||
					this.NotSimilarTo != null &&
					this.NotSimilarTo.SequenceEqual(other.NotSimilarTo)
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
				if (this.ExactMatch != null)
					hash = hash * 59 + this.ExactMatch.GetHashCode();

				if (this.Contains != null)
					hash = hash * 59 + this.Contains.GetHashCode();

				if (this.DoesNotContain != null)
					hash = hash * 59 + this.DoesNotContain.GetHashCode();

				if (this.NotSimilarTo != null)
					hash = hash * 59 + this.NotSimilarTo.GetHashCode();

				return hash;
			}
		}
	}

}
