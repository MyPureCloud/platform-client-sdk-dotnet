using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Form message with title, subtitle, and optional image
	/// </summary>
	[DataContract]
	public partial class FormMessage : IEquatable<FormMessage>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="FormMessage" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected FormMessage() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="FormMessage" /> class.
		/// </summary>
		/// <param name="Title">Title of the message (required).</param>
		/// <param name="Subtitle">Subtitle of the message.</param>
		/// <param name="ImageUrl">URL of the image to display.</param>
		public FormMessage(string Title = null, string Subtitle = null, string ImageUrl = null)
		{
			this.Title = Title;
			this.Subtitle = Subtitle;
			this.ImageUrl = ImageUrl;

		}



		/// <summary>
		/// Title of the message
		/// </summary>
		/// <value>Title of the message</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// Subtitle of the message
		/// </summary>
		/// <value>Subtitle of the message</value>
		[DataMember(Name = "subtitle", EmitDefaultValue = false)]
		public string Subtitle { get; set; }



		/// <summary>
		/// URL of the image to display
		/// </summary>
		/// <value>URL of the image to display</value>
		[DataMember(Name = "imageUrl", EmitDefaultValue = false)]
		public string ImageUrl { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FormMessage {\n");

			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
			sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
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
			return this.Equals(obj as FormMessage);
		}

		/// <summary>
		/// Returns true if FormMessage instances are equal
		/// </summary>
		/// <param name="other">Instance of FormMessage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FormMessage other)
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
				) &&
				(
					this.ImageUrl == other.ImageUrl ||
					this.ImageUrl != null &&
					this.ImageUrl.Equals(other.ImageUrl)
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

				if (this.ImageUrl != null)
					hash = hash * 59 + this.ImageUrl.GetHashCode();

				return hash;
			}
		}
	}

}
