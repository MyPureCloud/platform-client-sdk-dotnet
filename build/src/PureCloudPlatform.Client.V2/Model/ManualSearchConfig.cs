using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ManualSearchConfig
	/// </summary>
	[DataContract]
	public partial class ManualSearchConfig : IEquatable<ManualSearchConfig>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ManualSearchConfig" /> class.
		/// </summary>
		/// <param name="ArticlesWithAnswerHighlights">Articles with answer highlights..</param>
		/// <param name="AnswerGeneration">Answer generation..</param>
		public ManualSearchConfig(bool? ArticlesWithAnswerHighlights = null, bool? AnswerGeneration = null)
		{
			this.ArticlesWithAnswerHighlights = ArticlesWithAnswerHighlights;
			this.AnswerGeneration = AnswerGeneration;

		}



		/// <summary>
		/// Articles with answer highlights.
		/// </summary>
		/// <value>Articles with answer highlights.</value>
		[DataMember(Name = "articlesWithAnswerHighlights", EmitDefaultValue = false)]
		public bool? ArticlesWithAnswerHighlights { get; set; }



		/// <summary>
		/// Answer generation.
		/// </summary>
		/// <value>Answer generation.</value>
		[DataMember(Name = "answerGeneration", EmitDefaultValue = false)]
		public bool? AnswerGeneration { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ManualSearchConfig {\n");

			sb.Append("  ArticlesWithAnswerHighlights: ").Append(ArticlesWithAnswerHighlights).Append("\n");
			sb.Append("  AnswerGeneration: ").Append(AnswerGeneration).Append("\n");
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
			return this.Equals(obj as ManualSearchConfig);
		}

		/// <summary>
		/// Returns true if ManualSearchConfig instances are equal
		/// </summary>
		/// <param name="other">Instance of ManualSearchConfig to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ManualSearchConfig other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ArticlesWithAnswerHighlights == other.ArticlesWithAnswerHighlights ||
					this.ArticlesWithAnswerHighlights != null &&
					this.ArticlesWithAnswerHighlights.Equals(other.ArticlesWithAnswerHighlights)
				) &&
				(
					this.AnswerGeneration == other.AnswerGeneration ||
					this.AnswerGeneration != null &&
					this.AnswerGeneration.Equals(other.AnswerGeneration)
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
				if (this.ArticlesWithAnswerHighlights != null)
					hash = hash * 59 + this.ArticlesWithAnswerHighlights.GetHashCode();

				if (this.AnswerGeneration != null)
					hash = hash * 59 + this.AnswerGeneration.GetHashCode();

				return hash;
			}
		}
	}

}
