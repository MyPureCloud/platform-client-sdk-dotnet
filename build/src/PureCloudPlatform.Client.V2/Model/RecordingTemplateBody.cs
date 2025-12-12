using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// RecordingTemplateBody
	/// </summary>
	[DataContract]
	public partial class RecordingTemplateBody : IEquatable<RecordingTemplateBody>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RecordingTemplateBody" /> class.
		/// </summary>
		/// <param name="Text">Template parameters for placeholders in template..</param>
		public RecordingTemplateBody(string Text = null)
		{
			this.Text = Text;

		}



		/// <summary>
		/// Template parameters for placeholders in template.
		/// </summary>
		/// <value>Template parameters for placeholders in template.</value>
		[DataMember(Name = "text", EmitDefaultValue = false)]
		public string Text { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RecordingTemplateBody {\n");

			sb.Append("  Text: ").Append(Text).Append("\n");
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
			return this.Equals(obj as RecordingTemplateBody);
		}

		/// <summary>
		/// Returns true if RecordingTemplateBody instances are equal
		/// </summary>
		/// <param name="other">Instance of RecordingTemplateBody to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RecordingTemplateBody other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Text == other.Text ||
					this.Text != null &&
					this.Text.Equals(other.Text)
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

				return hash;
			}
		}
	}

}
