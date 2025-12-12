using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UnansweredGroup
	/// </summary>
	[DataContract]
	public partial class UnansweredGroup : IEquatable<UnansweredGroup>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UnansweredGroup" /> class.
		/// </summary>
		/// <param name="Label">Knowledge base unanswered group label.</param>
		/// <param name="PhraseGroups">Represents a list of phrase groups inside an unanswered group.</param>
		/// <param name="SuggestedDocuments">Represents a list of documents that may be linked to an unanswered group.</param>
		/// <param name="Statistics">Statistics object containing the various hit counts for an unanswered group.</param>
		public UnansweredGroup(string Label = null, List<UnansweredPhraseGroup> PhraseGroups = null, List<UnansweredGroupSuggestedDocument> SuggestedDocuments = null, KnowledgeGroupStatistics Statistics = null)
		{
			this.Label = Label;
			this.PhraseGroups = PhraseGroups;
			this.SuggestedDocuments = SuggestedDocuments;
			this.Statistics = Statistics;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Knowledge base unanswered group label
		/// </summary>
		/// <value>Knowledge base unanswered group label</value>
		[DataMember(Name = "label", EmitDefaultValue = false)]
		public string Label { get; set; }



		/// <summary>
		/// Represents a list of phrase groups inside an unanswered group
		/// </summary>
		/// <value>Represents a list of phrase groups inside an unanswered group</value>
		[DataMember(Name = "phraseGroups", EmitDefaultValue = false)]
		public List<UnansweredPhraseGroup> PhraseGroups { get; set; }



		/// <summary>
		/// Represents a list of documents that may be linked to an unanswered group
		/// </summary>
		/// <value>Represents a list of documents that may be linked to an unanswered group</value>
		[DataMember(Name = "suggestedDocuments", EmitDefaultValue = false)]
		public List<UnansweredGroupSuggestedDocument> SuggestedDocuments { get; set; }



		/// <summary>
		/// Statistics object containing the various hit counts for an unanswered group
		/// </summary>
		/// <value>Statistics object containing the various hit counts for an unanswered group</value>
		[DataMember(Name = "statistics", EmitDefaultValue = false)]
		public KnowledgeGroupStatistics Statistics { get; set; }



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
			sb.Append("class UnansweredGroup {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Label: ").Append(Label).Append("\n");
			sb.Append("  PhraseGroups: ").Append(PhraseGroups).Append("\n");
			sb.Append("  SuggestedDocuments: ").Append(SuggestedDocuments).Append("\n");
			sb.Append("  Statistics: ").Append(Statistics).Append("\n");
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
			return this.Equals(obj as UnansweredGroup);
		}

		/// <summary>
		/// Returns true if UnansweredGroup instances are equal
		/// </summary>
		/// <param name="other">Instance of UnansweredGroup to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UnansweredGroup other)
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
					this.PhraseGroups == other.PhraseGroups ||
					this.PhraseGroups != null &&
					this.PhraseGroups.SequenceEqual(other.PhraseGroups)
				) &&
				(
					this.SuggestedDocuments == other.SuggestedDocuments ||
					this.SuggestedDocuments != null &&
					this.SuggestedDocuments.SequenceEqual(other.SuggestedDocuments)
				) &&
				(
					this.Statistics == other.Statistics ||
					this.Statistics != null &&
					this.Statistics.Equals(other.Statistics)
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

				if (this.PhraseGroups != null)
					hash = hash * 59 + this.PhraseGroups.GetHashCode();

				if (this.SuggestedDocuments != null)
					hash = hash * 59 + this.SuggestedDocuments.GetHashCode();

				if (this.Statistics != null)
					hash = hash * 59 + this.Statistics.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
