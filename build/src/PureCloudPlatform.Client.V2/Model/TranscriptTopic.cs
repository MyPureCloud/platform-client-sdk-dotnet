using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TranscriptTopic
	/// </summary>
	[DataContract]
	public partial class TranscriptTopic : IEquatable<TranscriptTopic>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TranscriptTopic" /> class.
		/// </summary>
		/// <param name="Duration">Duration.</param>
		public TranscriptTopic(TopicDuration Duration = null)
		{
			this.Duration = Duration;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The name of the object.
		/// </summary>
		/// <value>The name of the object.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; private set; }



		/// <summary>
		/// The phrase which detected the topic. 
		/// </summary>
		/// <value>The phrase which detected the topic. </value>
		[DataMember(Name = "topicPhrase", EmitDefaultValue = false)]
		public string TopicPhrase { get; private set; }



		/// <summary>
		/// The transcript phrase which detected the topic.
		/// </summary>
		/// <value>The transcript phrase which detected the topic.</value>
		[DataMember(Name = "transcriptPhrase", EmitDefaultValue = false)]
		public string TranscriptPhrase { get; private set; }



		/// <summary>
		/// The detection confidence of the topic.
		/// </summary>
		/// <value>The detection confidence of the topic.</value>
		[DataMember(Name = "confidence", EmitDefaultValue = false)]
		public int? Confidence { get; private set; }



		/// <summary>
		/// The start time of the topic phrase.
		/// </summary>
		/// <value>The start time of the topic phrase.</value>
		[DataMember(Name = "startTimeMilliseconds", EmitDefaultValue = false)]
		public long? StartTimeMilliseconds { get; private set; }



		/// <summary>
		/// Gets or Sets Duration
		/// </summary>
		[DataMember(Name = "duration", EmitDefaultValue = false)]
		public TopicDuration Duration { get; set; }



		/// <summary>
		/// Location of the phrase
		/// </summary>
		/// <value>Location of the phrase</value>
		[DataMember(Name = "offset", EmitDefaultValue = false)]
		public TopicOffset Offset { get; private set; }



		/// <summary>
		/// Location of the phrase in the recording in milliseconds
		/// </summary>
		/// <value>Location of the phrase in the recording in milliseconds</value>
		[DataMember(Name = "recordingLocation", EmitDefaultValue = false)]
		public long? RecordingLocation { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TranscriptTopic {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  TopicPhrase: ").Append(TopicPhrase).Append("\n");
			sb.Append("  TranscriptPhrase: ").Append(TranscriptPhrase).Append("\n");
			sb.Append("  Confidence: ").Append(Confidence).Append("\n");
			sb.Append("  StartTimeMilliseconds: ").Append(StartTimeMilliseconds).Append("\n");
			sb.Append("  Duration: ").Append(Duration).Append("\n");
			sb.Append("  Offset: ").Append(Offset).Append("\n");
			sb.Append("  RecordingLocation: ").Append(RecordingLocation).Append("\n");
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
			return this.Equals(obj as TranscriptTopic);
		}

		/// <summary>
		/// Returns true if TranscriptTopic instances are equal
		/// </summary>
		/// <param name="other">Instance of TranscriptTopic to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TranscriptTopic other)
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
					this.TopicPhrase == other.TopicPhrase ||
					this.TopicPhrase != null &&
					this.TopicPhrase.Equals(other.TopicPhrase)
				) &&
				(
					this.TranscriptPhrase == other.TranscriptPhrase ||
					this.TranscriptPhrase != null &&
					this.TranscriptPhrase.Equals(other.TranscriptPhrase)
				) &&
				(
					this.Confidence == other.Confidence ||
					this.Confidence != null &&
					this.Confidence.Equals(other.Confidence)
				) &&
				(
					this.StartTimeMilliseconds == other.StartTimeMilliseconds ||
					this.StartTimeMilliseconds != null &&
					this.StartTimeMilliseconds.Equals(other.StartTimeMilliseconds)
				) &&
				(
					this.Duration == other.Duration ||
					this.Duration != null &&
					this.Duration.Equals(other.Duration)
				) &&
				(
					this.Offset == other.Offset ||
					this.Offset != null &&
					this.Offset.Equals(other.Offset)
				) &&
				(
					this.RecordingLocation == other.RecordingLocation ||
					this.RecordingLocation != null &&
					this.RecordingLocation.Equals(other.RecordingLocation)
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

				if (this.TopicPhrase != null)
					hash = hash * 59 + this.TopicPhrase.GetHashCode();

				if (this.TranscriptPhrase != null)
					hash = hash * 59 + this.TranscriptPhrase.GetHashCode();

				if (this.Confidence != null)
					hash = hash * 59 + this.Confidence.GetHashCode();

				if (this.StartTimeMilliseconds != null)
					hash = hash * 59 + this.StartTimeMilliseconds.GetHashCode();

				if (this.Duration != null)
					hash = hash * 59 + this.Duration.GetHashCode();

				if (this.Offset != null)
					hash = hash * 59 + this.Offset.GetHashCode();

				if (this.RecordingLocation != null)
					hash = hash * 59 + this.RecordingLocation.GetHashCode();

				return hash;
			}
		}
	}

}
