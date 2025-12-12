using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// RecordingJobFailedRecording
	/// </summary>
	[DataContract]
	public partial class RecordingJobFailedRecording : IEquatable<RecordingJobFailedRecording>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RecordingJobFailedRecording" /> class.
		/// </summary>
		public RecordingJobFailedRecording()
		{

		}



		/// <summary>
		/// Conversation
		/// </summary>
		/// <value>Conversation</value>
		[DataMember(Name = "conversation", EmitDefaultValue = false)]
		public AddressableEntityRef Conversation { get; private set; }



		/// <summary>
		/// Recording
		/// </summary>
		/// <value>Recording</value>
		[DataMember(Name = "recording", EmitDefaultValue = false)]
		public AddressableEntityRef Recording { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RecordingJobFailedRecording {\n");

			sb.Append("  Conversation: ").Append(Conversation).Append("\n");
			sb.Append("  Recording: ").Append(Recording).Append("\n");
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
			return this.Equals(obj as RecordingJobFailedRecording);
		}

		/// <summary>
		/// Returns true if RecordingJobFailedRecording instances are equal
		/// </summary>
		/// <param name="other">Instance of RecordingJobFailedRecording to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RecordingJobFailedRecording other)
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
					this.Recording == other.Recording ||
					this.Recording != null &&
					this.Recording.Equals(other.Recording)
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

				if (this.Recording != null)
					hash = hash * 59 + this.Recording.GetHashCode();

				return hash;
			}
		}
	}

}
