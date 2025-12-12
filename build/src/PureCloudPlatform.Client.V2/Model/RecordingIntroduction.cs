using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// RecordingIntroduction
	/// </summary>
	[DataContract]
	public partial class RecordingIntroduction : IEquatable<RecordingIntroduction>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RecordingIntroduction" /> class.
		/// </summary>
		/// <param name="Title">Text to show in the title..</param>
		/// <param name="Subtitle">Text to show in the subtitle..</param>
		public RecordingIntroduction(string Title = null, string Subtitle = null)
		{
			this.Title = Title;
			this.Subtitle = Subtitle;

		}



		/// <summary>
		/// Text to show in the title.
		/// </summary>
		/// <value>Text to show in the title.</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// Text to show in the subtitle.
		/// </summary>
		/// <value>Text to show in the subtitle.</value>
		[DataMember(Name = "subtitle", EmitDefaultValue = false)]
		public string Subtitle { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RecordingIntroduction {\n");

			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
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
			return this.Equals(obj as RecordingIntroduction);
		}

		/// <summary>
		/// Returns true if RecordingIntroduction instances are equal
		/// </summary>
		/// <param name="other">Instance of RecordingIntroduction to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RecordingIntroduction other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Title == other.Title ||
					this.Title != null &&
					this.Title.Equals(other.Title)
				) &&
				(
					this.Subtitle == other.Subtitle ||
					this.Subtitle != null &&
					this.Subtitle.Equals(other.Subtitle)
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
				if (this.Title != null)
					hash = hash * 59 + this.Title.GetHashCode();

				if (this.Subtitle != null)
					hash = hash * 59 + this.Subtitle.GetHashCode();

				return hash;
			}
		}
	}

}
