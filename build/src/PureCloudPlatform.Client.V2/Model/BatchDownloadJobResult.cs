using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BatchDownloadJobResult
	/// </summary>
	[DataContract]
	public partial class BatchDownloadJobResult : IEquatable<BatchDownloadJobResult>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BatchDownloadJobResult" /> class.
		/// </summary>
		/// <param name="ConversationId">Conversation id of the result.</param>
		/// <param name="RecordingId">Recording id of the result.</param>
		/// <param name="ResultUrl">URL of results... HTTP GET from this location to download results for this item.</param>
		/// <param name="ContentType">Content type of this result.</param>
		/// <param name="ErrorMsg">An error message, in case of failed processing will indicate the cause of the failure.</param>
		public BatchDownloadJobResult(string ConversationId = null, string RecordingId = null, string ResultUrl = null, string ContentType = null, string ErrorMsg = null)
		{
			this.ConversationId = ConversationId;
			this.RecordingId = RecordingId;
			this.ResultUrl = ResultUrl;
			this.ContentType = ContentType;
			this.ErrorMsg = ErrorMsg;

		}



		/// <summary>
		/// Conversation id of the result
		/// </summary>
		/// <value>Conversation id of the result</value>
		[DataMember(Name = "conversationId", EmitDefaultValue = false)]
		public string ConversationId { get; set; }



		/// <summary>
		/// Recording id of the result
		/// </summary>
		/// <value>Recording id of the result</value>
		[DataMember(Name = "recordingId", EmitDefaultValue = false)]
		public string RecordingId { get; set; }



		/// <summary>
		/// URL of results... HTTP GET from this location to download results for this item
		/// </summary>
		/// <value>URL of results... HTTP GET from this location to download results for this item</value>
		[DataMember(Name = "resultUrl", EmitDefaultValue = false)]
		public string ResultUrl { get; set; }



		/// <summary>
		/// Content type of this result
		/// </summary>
		/// <value>Content type of this result</value>
		[DataMember(Name = "contentType", EmitDefaultValue = false)]
		public string ContentType { get; set; }



		/// <summary>
		/// An error message, in case of failed processing will indicate the cause of the failure
		/// </summary>
		/// <value>An error message, in case of failed processing will indicate the cause of the failure</value>
		[DataMember(Name = "errorMsg", EmitDefaultValue = false)]
		public string ErrorMsg { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BatchDownloadJobResult {\n");

			sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
			sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
			sb.Append("  ResultUrl: ").Append(ResultUrl).Append("\n");
			sb.Append("  ContentType: ").Append(ContentType).Append("\n");
			sb.Append("  ErrorMsg: ").Append(ErrorMsg).Append("\n");
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
			return this.Equals(obj as BatchDownloadJobResult);
		}

		/// <summary>
		/// Returns true if BatchDownloadJobResult instances are equal
		/// </summary>
		/// <param name="other">Instance of BatchDownloadJobResult to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BatchDownloadJobResult other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ConversationId == other.ConversationId ||
					this.ConversationId != null &&
					this.ConversationId.Equals(other.ConversationId)
				) &&
				(
					this.RecordingId == other.RecordingId ||
					this.RecordingId != null &&
					this.RecordingId.Equals(other.RecordingId)
				) &&
				(
					this.ResultUrl == other.ResultUrl ||
					this.ResultUrl != null &&
					this.ResultUrl.Equals(other.ResultUrl)
				) &&
				(
					this.ContentType == other.ContentType ||
					this.ContentType != null &&
					this.ContentType.Equals(other.ContentType)
				) &&
				(
					this.ErrorMsg == other.ErrorMsg ||
					this.ErrorMsg != null &&
					this.ErrorMsg.Equals(other.ErrorMsg)
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
				if (this.ConversationId != null)
					hash = hash * 59 + this.ConversationId.GetHashCode();

				if (this.RecordingId != null)
					hash = hash * 59 + this.RecordingId.GetHashCode();

				if (this.ResultUrl != null)
					hash = hash * 59 + this.ResultUrl.GetHashCode();

				if (this.ContentType != null)
					hash = hash * 59 + this.ContentType.GetHashCode();

				if (this.ErrorMsg != null)
					hash = hash * 59 + this.ErrorMsg.GetHashCode();

				return hash;
			}
		}
	}

}
