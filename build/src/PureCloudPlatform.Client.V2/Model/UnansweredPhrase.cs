using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UnansweredPhrase
	/// </summary>
	[DataContract]
	public partial class UnansweredPhrase : IEquatable<UnansweredPhrase>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UnansweredPhrase" /> class.
		/// </summary>
		/// <param name="Id">Id of an unanswered phrase.</param>
		/// <param name="Text">Phrase text of an unanswered phrase.</param>
		/// <param name="UnlinkedPhraseHitCount">Hit count of an unlinked phrase.</param>
		public UnansweredPhrase(string Id = null, string Text = null, int? UnlinkedPhraseHitCount = null)
		{
			this.Id = Id;
			this.Text = Text;
			this.UnlinkedPhraseHitCount = UnlinkedPhraseHitCount;

		}



		/// <summary>
		/// Id of an unanswered phrase
		/// </summary>
		/// <value>Id of an unanswered phrase</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Phrase text of an unanswered phrase
		/// </summary>
		/// <value>Phrase text of an unanswered phrase</value>
		[DataMember(Name = "text", EmitDefaultValue = false)]
		public string Text { get; set; }



		/// <summary>
		/// Hit count of an unlinked phrase
		/// </summary>
		/// <value>Hit count of an unlinked phrase</value>
		[DataMember(Name = "unlinkedPhraseHitCount", EmitDefaultValue = false)]
		public int? UnlinkedPhraseHitCount { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UnansweredPhrase {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Text: ").Append(Text).Append("\n");
			sb.Append("  UnlinkedPhraseHitCount: ").Append(UnlinkedPhraseHitCount).Append("\n");
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
			return this.Equals(obj as UnansweredPhrase);
		}

		/// <summary>
		/// Returns true if UnansweredPhrase instances are equal
		/// </summary>
		/// <param name="other">Instance of UnansweredPhrase to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UnansweredPhrase other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Text == other.Text ||
					this.Text != null &&
					this.Text.Equals(other.Text)
				) &&
				(
					this.UnlinkedPhraseHitCount == other.UnlinkedPhraseHitCount ||
					this.UnlinkedPhraseHitCount != null &&
					this.UnlinkedPhraseHitCount.Equals(other.UnlinkedPhraseHitCount)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Text != null)
					hash = hash * 59 + this.Text.GetHashCode();

				if (this.UnlinkedPhraseHitCount != null)
					hash = hash * 59 + this.UnlinkedPhraseHitCount.GetHashCode();

				return hash;
			}
		}
	}

}
