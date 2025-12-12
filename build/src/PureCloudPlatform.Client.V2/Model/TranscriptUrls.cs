using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TranscriptUrls
	/// </summary>
	[DataContract]
	public partial class TranscriptUrls : IEquatable<TranscriptUrls>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TranscriptUrls" /> class.
		/// </summary>
		/// <param name="Conversation">The Conversation Reference.</param>
		/// <param name="CommunicationId">The Communication ID.</param>
		/// <param name="Urls">List of Transcript URLs.</param>
		public TranscriptUrls(AddressableEntityRef Conversation = null, string CommunicationId = null, List<SegmentUrl> Urls = null)
		{
			this.Conversation = Conversation;
			this.CommunicationId = CommunicationId;
			this.Urls = Urls;

		}



		/// <summary>
		/// The Conversation Reference
		/// </summary>
		/// <value>The Conversation Reference</value>
		[DataMember(Name = "conversation", EmitDefaultValue = false)]
		public AddressableEntityRef Conversation { get; set; }



		/// <summary>
		/// The Communication ID
		/// </summary>
		/// <value>The Communication ID</value>
		[DataMember(Name = "communicationId", EmitDefaultValue = false)]
		public string CommunicationId { get; set; }



		/// <summary>
		/// List of Transcript URLs
		/// </summary>
		/// <value>List of Transcript URLs</value>
		[DataMember(Name = "urls", EmitDefaultValue = false)]
		public List<SegmentUrl> Urls { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TranscriptUrls {\n");

			sb.Append("  Conversation: ").Append(Conversation).Append("\n");
			sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
			sb.Append("  Urls: ").Append(Urls).Append("\n");
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
			return this.Equals(obj as TranscriptUrls);
		}

		/// <summary>
		/// Returns true if TranscriptUrls instances are equal
		/// </summary>
		/// <param name="other">Instance of TranscriptUrls to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TranscriptUrls other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Conversation == other.Conversation ||
					this.Conversation != null &&
					this.Conversation.Equals(other.Conversation)
				) &&
				(
					this.CommunicationId == other.CommunicationId ||
					this.CommunicationId != null &&
					this.CommunicationId.Equals(other.CommunicationId)
				) &&
				(
					this.Urls == other.Urls ||
					this.Urls != null &&
					this.Urls.SequenceEqual(other.Urls)
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
				if (this.Conversation != null)
					hash = hash * 59 + this.Conversation.GetHashCode();

				if (this.CommunicationId != null)
					hash = hash * 59 + this.CommunicationId.GetHashCode();

				if (this.Urls != null)
					hash = hash * 59 + this.Urls.GetHashCode();

				return hash;
			}
		}
	}

}
