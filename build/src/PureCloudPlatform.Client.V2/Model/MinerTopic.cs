using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// MinerTopic
	/// </summary>
	[DataContract]
	public partial class MinerTopic : IEquatable<MinerTopic>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MinerTopic" /> class.
		/// </summary>
		/// <param name="Name">Topic name..</param>
		/// <param name="Phrases">Phrases associated with a topic..</param>
		public MinerTopic(string Name = null, List<TopicPhrase> Phrases = null)
		{
			this.Name = Name;
			this.Phrases = Phrases;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Topic name.
		/// </summary>
		/// <value>Topic name.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The miner to which the topic belongs.
		/// </summary>
		/// <value>The miner to which the topic belongs.</value>
		[DataMember(Name = "miner", EmitDefaultValue = false)]
		public Miner Miner { get; private set; }



		/// <summary>
		/// Number of conversations where a topic has occurred.
		/// </summary>
		/// <value>Number of conversations where a topic has occurred.</value>
		[DataMember(Name = "conversationCount", EmitDefaultValue = false)]
		public int? ConversationCount { get; private set; }



		/// <summary>
		/// Percentage of conversations where a topic has occurred.
		/// </summary>
		/// <value>Percentage of conversations where a topic has occurred.</value>
		[DataMember(Name = "conversationPercent", EmitDefaultValue = false)]
		public float? ConversationPercent { get; private set; }



		/// <summary>
		/// Number of unique utterances where a topic has occurred.
		/// </summary>
		/// <value>Number of unique utterances where a topic has occurred.</value>
		[DataMember(Name = "utteranceCount", EmitDefaultValue = false)]
		public int? UtteranceCount { get; private set; }



		/// <summary>
		/// Number of unique phrases (sub-utterances) where a topic has occurred.
		/// </summary>
		/// <value>Number of unique phrases (sub-utterances) where a topic has occurred.</value>
		[DataMember(Name = "phraseCount", EmitDefaultValue = false)]
		public int? PhraseCount { get; private set; }



		/// <summary>
		/// Phrases associated with a topic.
		/// </summary>
		/// <value>Phrases associated with a topic.</value>
		[DataMember(Name = "phrases", EmitDefaultValue = false)]
		public List<TopicPhrase> Phrases { get; set; }



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
			sb.Append("class MinerTopic {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Miner: ").Append(Miner).Append("\n");
			sb.Append("  ConversationCount: ").Append(ConversationCount).Append("\n");
			sb.Append("  ConversationPercent: ").Append(ConversationPercent).Append("\n");
			sb.Append("  UtteranceCount: ").Append(UtteranceCount).Append("\n");
			sb.Append("  PhraseCount: ").Append(PhraseCount).Append("\n");
			sb.Append("  Phrases: ").Append(Phrases).Append("\n");
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
			return this.Equals(obj as MinerTopic);
		}

		/// <summary>
		/// Returns true if MinerTopic instances are equal
		/// </summary>
		/// <param name="other">Instance of MinerTopic to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MinerTopic other)
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
					this.Miner == other.Miner ||
					this.Miner != null &&
					this.Miner.Equals(other.Miner)
				) &&
				(
					this.ConversationCount == other.ConversationCount ||
					this.ConversationCount != null &&
					this.ConversationCount.Equals(other.ConversationCount)
				) &&
				(
					this.ConversationPercent == other.ConversationPercent ||
					this.ConversationPercent != null &&
					this.ConversationPercent.Equals(other.ConversationPercent)
				) &&
				(
					this.UtteranceCount == other.UtteranceCount ||
					this.UtteranceCount != null &&
					this.UtteranceCount.Equals(other.UtteranceCount)
				) &&
				(
					this.PhraseCount == other.PhraseCount ||
					this.PhraseCount != null &&
					this.PhraseCount.Equals(other.PhraseCount)
				) &&
				(
					this.Phrases == other.Phrases ||
					this.Phrases != null &&
					this.Phrases.SequenceEqual(other.Phrases)
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

				if (this.Miner != null)
					hash = hash * 59 + this.Miner.GetHashCode();

				if (this.ConversationCount != null)
					hash = hash * 59 + this.ConversationCount.GetHashCode();

				if (this.ConversationPercent != null)
					hash = hash * 59 + this.ConversationPercent.GetHashCode();

				if (this.UtteranceCount != null)
					hash = hash * 59 + this.UtteranceCount.GetHashCode();

				if (this.PhraseCount != null)
					hash = hash * 59 + this.PhraseCount.GetHashCode();

				if (this.Phrases != null)
					hash = hash * 59 + this.Phrases.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
