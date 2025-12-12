using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Represents a selectable item in a list picker.
	/// </summary>
	[DataContract]
	public partial class ConversationContentListPickerItem : IEquatable<ConversationContentListPickerItem>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationContentListPickerItem" /> class.
		/// </summary>
		/// <param name="Id">Unique identifier for the list picker item.</param>
		/// <param name="Title">The main text displayed for the item..</param>
		/// <param name="Subtitle">Additional text providing more details about the item..</param>
		/// <param name="ImageUrl">URL of an image to be displayed alongside the item..</param>
		public ConversationContentListPickerItem(string Id = null, string Title = null, string Subtitle = null, string ImageUrl = null)
		{
			this.Id = Id;
			this.Title = Title;
			this.Subtitle = Subtitle;
			this.ImageUrl = ImageUrl;

		}



		/// <summary>
		/// Unique identifier for the list picker item
		/// </summary>
		/// <value>Unique identifier for the list picker item</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The main text displayed for the item.
		/// </summary>
		/// <value>The main text displayed for the item.</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// Additional text providing more details about the item.
		/// </summary>
		/// <value>Additional text providing more details about the item.</value>
		[DataMember(Name = "subtitle", EmitDefaultValue = false)]
		public string Subtitle { get; set; }



		/// <summary>
		/// URL of an image to be displayed alongside the item.
		/// </summary>
		/// <value>URL of an image to be displayed alongside the item.</value>
		[DataMember(Name = "imageUrl", EmitDefaultValue = false)]
		public string ImageUrl { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationContentListPickerItem {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
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
			return this.Equals(obj as ConversationContentListPickerItem);
		}

		/// <summary>
		/// Returns true if ConversationContentListPickerItem instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationContentListPickerItem to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationContentListPickerItem other)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

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
