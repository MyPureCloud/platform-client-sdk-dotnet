using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Card content object.
	/// </summary>
	[DataContract]
	public partial class ConversationContentCard : IEquatable<ConversationContentCard>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationContentCard" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ConversationContentCard() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationContentCard" /> class.
		/// </summary>
		/// <param name="Title">Text to show in the title. (required).</param>
		/// <param name="Description">Text to show in the description..</param>
		/// <param name="Image">URL of an image..</param>
		/// <param name="Video">URL of a video..</param>
		/// <param name="DefaultAction">The default button action..</param>
		/// <param name="Actions">An array of action objects. (required).</param>
		public ConversationContentCard(string Title = null, string Description = null, string Image = null, string Video = null, ConversationContentCardAction DefaultAction = null, List<ConversationContentCardAction> Actions = null)
		{
			this.Title = Title;
			this.Description = Description;
			this.Image = Image;
			this.Video = Video;
			this.DefaultAction = DefaultAction;
			this.Actions = Actions;

		}



		/// <summary>
		/// Text to show in the title.
		/// </summary>
		/// <value>Text to show in the title.</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// Text to show in the description.
		/// </summary>
		/// <value>Text to show in the description.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// URL of an image.
		/// </summary>
		/// <value>URL of an image.</value>
		[DataMember(Name = "image", EmitDefaultValue = false)]
		public string Image { get; set; }



		/// <summary>
		/// URL of a video.
		/// </summary>
		/// <value>URL of a video.</value>
		[DataMember(Name = "video", EmitDefaultValue = false)]
		public string Video { get; set; }



		/// <summary>
		/// The default button action.
		/// </summary>
		/// <value>The default button action.</value>
		[DataMember(Name = "defaultAction", EmitDefaultValue = false)]
		public ConversationContentCardAction DefaultAction { get; set; }



		/// <summary>
		/// An array of action objects.
		/// </summary>
		/// <value>An array of action objects.</value>
		[DataMember(Name = "actions", EmitDefaultValue = false)]
		public List<ConversationContentCardAction> Actions { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationContentCard {\n");

			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Image: ").Append(Image).Append("\n");
			sb.Append("  Video: ").Append(Video).Append("\n");
			sb.Append("  DefaultAction: ").Append(DefaultAction).Append("\n");
			sb.Append("  Actions: ").Append(Actions).Append("\n");
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
			return this.Equals(obj as ConversationContentCard);
		}

		/// <summary>
		/// Returns true if ConversationContentCard instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationContentCard to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationContentCard other)
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
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.Image == other.Image ||
					this.Image != null &&
					this.Image.Equals(other.Image)
				) &&
				(
					this.Video == other.Video ||
					this.Video != null &&
					this.Video.Equals(other.Video)
				) &&
				(
					this.DefaultAction == other.DefaultAction ||
					this.DefaultAction != null &&
					this.DefaultAction.Equals(other.DefaultAction)
				) &&
				(
					this.Actions == other.Actions ||
					this.Actions != null &&
					this.Actions.SequenceEqual(other.Actions)
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

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Image != null)
					hash = hash * 59 + this.Image.GetHashCode();

				if (this.Video != null)
					hash = hash * 59 + this.Video.GetHashCode();

				if (this.DefaultAction != null)
					hash = hash * 59 + this.DefaultAction.GetHashCode();

				if (this.Actions != null)
					hash = hash * 59 + this.Actions.GetHashCode();

				return hash;
			}
		}
	}

}
