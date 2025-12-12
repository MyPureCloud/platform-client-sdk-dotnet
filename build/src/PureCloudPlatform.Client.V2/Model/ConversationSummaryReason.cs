using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationSummaryReason
	/// </summary>
	[DataContract]
	public partial class ConversationSummaryReason : IEquatable<ConversationSummaryReason>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationSummaryReason" /> class.
		/// </summary>
		/// <param name="Text">The text of the reason..</param>
		/// <param name="Description">The description..</param>
		public ConversationSummaryReason(string Text = null, string Description = null)
		{
			this.Text = Text;
			this.Description = Description;

		}



		/// <summary>
		/// The text of the reason.
		/// </summary>
		/// <value>The text of the reason.</value>
		[DataMember(Name = "text", EmitDefaultValue = false)]
		public string Text { get; set; }



		/// <summary>
		/// The description.
		/// </summary>
		/// <value>The description.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// The AI confidence value.
		/// </summary>
		/// <value>The AI confidence value.</value>
		[DataMember(Name = "confidence", EmitDefaultValue = false)]
		public float? Confidence { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationSummaryReason {\n");

			sb.Append("  Text: ").Append(Text).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Confidence: ").Append(Confidence).Append("\n");
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
			return this.Equals(obj as ConversationSummaryReason);
		}

		/// <summary>
		/// Returns true if ConversationSummaryReason instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationSummaryReason to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationSummaryReason other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Text == other.Text ||
					this.Text != null &&
					this.Text.Equals(other.Text)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.Confidence == other.Confidence ||
					this.Confidence != null &&
					this.Confidence.Equals(other.Confidence)
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
				if (this.Text != null)
					hash = hash * 59 + this.Text.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Confidence != null)
					hash = hash * 59 + this.Confidence.GetHashCode();

				return hash;
			}
		}
	}

}
