using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationScriptSuggestionsTopicSuggestedScript
	/// </summary>
	[DataContract]
	public partial class ConversationScriptSuggestionsTopicSuggestedScript : IEquatable<ConversationScriptSuggestionsTopicSuggestedScript>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationScriptSuggestionsTopicSuggestedScript" /> class.
		/// </summary>
		/// <param name="ScriptId">ScriptId.</param>
		/// <param name="PageId">PageId.</param>
		/// <param name="Data">Data.</param>
		public ConversationScriptSuggestionsTopicSuggestedScript(Guid? ScriptId = null, Guid? PageId = null, Dictionary<string, string> Data = null)
		{
			this.ScriptId = ScriptId;
			this.PageId = PageId;
			this.Data = Data;

		}



		/// <summary>
		/// Gets or Sets ScriptId
		/// </summary>
		[DataMember(Name = "scriptId", EmitDefaultValue = false)]
		public Guid? ScriptId { get; set; }



		/// <summary>
		/// Gets or Sets PageId
		/// </summary>
		[DataMember(Name = "pageId", EmitDefaultValue = false)]
		public Guid? PageId { get; set; }



		/// <summary>
		/// Gets or Sets Data
		/// </summary>
		[DataMember(Name = "data", EmitDefaultValue = false)]
		public Dictionary<string, string> Data { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationScriptSuggestionsTopicSuggestedScript {\n");

			sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
			sb.Append("  PageId: ").Append(PageId).Append("\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
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
			return this.Equals(obj as ConversationScriptSuggestionsTopicSuggestedScript);
		}

		/// <summary>
		/// Returns true if ConversationScriptSuggestionsTopicSuggestedScript instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationScriptSuggestionsTopicSuggestedScript to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationScriptSuggestionsTopicSuggestedScript other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ScriptId == other.ScriptId ||
					this.ScriptId != null &&
					this.ScriptId.Equals(other.ScriptId)
				) &&
				(
					this.PageId == other.PageId ||
					this.PageId != null &&
					this.PageId.Equals(other.PageId)
				) &&
				(
					this.Data == other.Data ||
					this.Data != null &&
					this.Data.SequenceEqual(other.Data)
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
				if (this.ScriptId != null)
					hash = hash * 59 + this.ScriptId.GetHashCode();

				if (this.PageId != null)
					hash = hash * 59 + this.PageId.GetHashCode();

				if (this.Data != null)
					hash = hash * 59 + this.Data.GetHashCode();

				return hash;
			}
		}
	}

}
