using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// MinerTopicPhrase
	/// </summary>
	[DataContract]
	public partial class MinerTopicPhrase : IEquatable<MinerTopicPhrase>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MinerTopicPhrase" /> class.
		/// </summary>
		/// <param name="Name">Phrase name..</param>
		/// <param name="Topic">Topic associated with a phrase..</param>
		/// <param name="Utterances">List of utterances related to a phrase..</param>
		/// <param name="UtteranceCount">Number of utterances belonging to a phrase.</param>
		public MinerTopicPhrase(string Name = null, MinerTopic Topic = null, List<Utterance> Utterances = null, int? UtteranceCount = null)
		{
			this.Name = Name;
			this.Topic = Topic;
			this.Utterances = Utterances;
			this.UtteranceCount = UtteranceCount;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Phrase name.
		/// </summary>
		/// <value>Phrase name.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Topic associated with a phrase.
		/// </summary>
		/// <value>Topic associated with a phrase.</value>
		[DataMember(Name = "topic", EmitDefaultValue = false)]
		public MinerTopic Topic { get; set; }



		/// <summary>
		/// List of utterances related to a phrase.
		/// </summary>
		/// <value>List of utterances related to a phrase.</value>
		[DataMember(Name = "utterances", EmitDefaultValue = false)]
		public List<Utterance> Utterances { get; set; }



		/// <summary>
		/// Number of utterances belonging to a phrase
		/// </summary>
		/// <value>Number of utterances belonging to a phrase</value>
		[DataMember(Name = "utteranceCount", EmitDefaultValue = false)]
		public int? UtteranceCount { get; set; }



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
			sb.Append("class MinerTopicPhrase {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Topic: ").Append(Topic).Append("\n");
			sb.Append("  Utterances: ").Append(Utterances).Append("\n");
			sb.Append("  UtteranceCount: ").Append(UtteranceCount).Append("\n");
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
			return this.Equals(obj as MinerTopicPhrase);
		}

		/// <summary>
		/// Returns true if MinerTopicPhrase instances are equal
		/// </summary>
		/// <param name="other">Instance of MinerTopicPhrase to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MinerTopicPhrase other)
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
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Topic == other.Topic ||
					this.Topic != null &&
					this.Topic.Equals(other.Topic)
				) &&
				(
					this.Utterances == other.Utterances ||
					this.Utterances != null &&
					this.Utterances.SequenceEqual(other.Utterances)
				) &&
				(
					this.UtteranceCount == other.UtteranceCount ||
					this.UtteranceCount != null &&
					this.UtteranceCount.Equals(other.UtteranceCount)
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

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Topic != null)
					hash = hash * 59 + this.Topic.GetHashCode();

				if (this.Utterances != null)
					hash = hash * 59 + this.Utterances.GetHashCode();

				if (this.UtteranceCount != null)
					hash = hash * 59 + this.UtteranceCount.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
