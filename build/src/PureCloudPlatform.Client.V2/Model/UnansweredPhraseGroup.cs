using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UnansweredPhraseGroup
	/// </summary>
	[DataContract]
	public partial class UnansweredPhraseGroup : IEquatable<UnansweredPhraseGroup>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UnansweredPhraseGroup" /> class.
		/// </summary>
		/// <param name="Label">Knowledge base phrase group label.</param>
		/// <param name="Phrases">List of unanswered phrases in a phrase group.</param>
		/// <param name="UnlinkedPhraseHitCount">Hit count of the unlinked phrase group.</param>
		/// <param name="UnlinkedPhraseCount">Unique phrase count of the unlinked phrase group.</param>
		public UnansweredPhraseGroup(string Label = null, List<UnansweredPhrase> Phrases = null, int? UnlinkedPhraseHitCount = null, int? UnlinkedPhraseCount = null)
		{
			this.Label = Label;
			this.Phrases = Phrases;
			this.UnlinkedPhraseHitCount = UnlinkedPhraseHitCount;
			this.UnlinkedPhraseCount = UnlinkedPhraseCount;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Knowledge base phrase group label
		/// </summary>
		/// <value>Knowledge base phrase group label</value>
		[DataMember(Name = "label", EmitDefaultValue = false)]
		public string Label { get; set; }



		/// <summary>
		/// List of unanswered phrases in a phrase group
		/// </summary>
		/// <value>List of unanswered phrases in a phrase group</value>
		[DataMember(Name = "phrases", EmitDefaultValue = false)]
		public List<UnansweredPhrase> Phrases { get; set; }



		/// <summary>
		/// Hit count of the unlinked phrase group
		/// </summary>
		/// <value>Hit count of the unlinked phrase group</value>
		[DataMember(Name = "unlinkedPhraseHitCount", EmitDefaultValue = false)]
		public int? UnlinkedPhraseHitCount { get; set; }



		/// <summary>
		/// Unique phrase count of the unlinked phrase group
		/// </summary>
		/// <value>Unique phrase count of the unlinked phrase group</value>
		[DataMember(Name = "unlinkedPhraseCount", EmitDefaultValue = false)]
		public int? UnlinkedPhraseCount { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UnansweredPhraseGroup {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Label: ").Append(Label).Append("\n");
			sb.Append("  Phrases: ").Append(Phrases).Append("\n");
			sb.Append("  UnlinkedPhraseHitCount: ").Append(UnlinkedPhraseHitCount).Append("\n");
			sb.Append("  UnlinkedPhraseCount: ").Append(UnlinkedPhraseCount).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as UnansweredPhraseGroup);
		}

		/// <summary>
		/// Returns true if UnansweredPhraseGroup instances are equal
		/// </summary>
		/// <param name="other">Instance of UnansweredPhraseGroup to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UnansweredPhraseGroup other)
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
					this.Label == other.Label ||
					this.Label != null &&
					this.Label.Equals(other.Label)
				) &&
				(
					this.Phrases == other.Phrases ||
					this.Phrases != null &&
					this.Phrases.SequenceEqual(other.Phrases)
				) &&
				(
					this.UnlinkedPhraseHitCount == other.UnlinkedPhraseHitCount ||
					this.UnlinkedPhraseHitCount != null &&
					this.UnlinkedPhraseHitCount.Equals(other.UnlinkedPhraseHitCount)
				) &&
				(
					this.UnlinkedPhraseCount == other.UnlinkedPhraseCount ||
					this.UnlinkedPhraseCount != null &&
					this.UnlinkedPhraseCount.Equals(other.UnlinkedPhraseCount)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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

				if (this.Label != null)
					hash = hash * 59 + this.Label.GetHashCode();

				if (this.Phrases != null)
					hash = hash * 59 + this.Phrases.GetHashCode();

				if (this.UnlinkedPhraseHitCount != null)
					hash = hash * 59 + this.UnlinkedPhraseHitCount.GetHashCode();

				if (this.UnlinkedPhraseCount != null)
					hash = hash * 59 + this.UnlinkedPhraseCount.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
