using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// V2SessionConversationsSummarySettingsPreviewEventConversationSummaryExtractedEntity
	/// </summary>
	[DataContract]
	public partial class V2SessionConversationsSummarySettingsPreviewEventConversationSummaryExtractedEntity : IEquatable<V2SessionConversationsSummarySettingsPreviewEventConversationSummaryExtractedEntity>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="V2SessionConversationsSummarySettingsPreviewEventConversationSummaryExtractedEntity" /> class.
		/// </summary>
		/// <param name="Label">Label.</param>
		/// <param name="Value">Value.</param>
		public V2SessionConversationsSummarySettingsPreviewEventConversationSummaryExtractedEntity(string Label = null, string Value = null)
		{
			this.Label = Label;
			this.Value = Value;

		}



		/// <summary>
		/// Gets or Sets Label
		/// </summary>
		[DataMember(Name = "label", EmitDefaultValue = false)]
		public string Label { get; set; }



		/// <summary>
		/// Gets or Sets Value
		/// </summary>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2SessionConversationsSummarySettingsPreviewEventConversationSummaryExtractedEntity {\n");

			sb.Append("  Label: ").Append(Label).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
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
			return this.Equals(obj as V2SessionConversationsSummarySettingsPreviewEventConversationSummaryExtractedEntity);
		}

		/// <summary>
		/// Returns true if V2SessionConversationsSummarySettingsPreviewEventConversationSummaryExtractedEntity instances are equal
		/// </summary>
		/// <param name="other">Instance of V2SessionConversationsSummarySettingsPreviewEventConversationSummaryExtractedEntity to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2SessionConversationsSummarySettingsPreviewEventConversationSummaryExtractedEntity other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Label == other.Label ||
					this.Label != null &&
					this.Label.Equals(other.Label)
				) &&
				(
					this.Value == other.Value ||
					this.Value != null &&
					this.Value.Equals(other.Value)
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
				if (this.Label != null)
					hash = hash * 59 + this.Label.GetHashCode();

				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				return hash;
			}
		}
	}

}
