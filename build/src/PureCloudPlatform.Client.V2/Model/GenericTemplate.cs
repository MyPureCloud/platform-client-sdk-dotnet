using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// GenericTemplate
	/// </summary>
	[DataContract]
	public partial class GenericTemplate : IEquatable<GenericTemplate>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GenericTemplate" /> class.
		/// </summary>
		/// <param name="Title">Text to show in the title..</param>
		/// <param name="Description">Text to show in the description..</param>
		/// <param name="Url">URL of an image..</param>
		/// <param name="Components">List of button components offered with this message content..</param>
		/// <param name="Actions">Actions to be taken..</param>
		public GenericTemplate(string Title = null, string Description = null, string Url = null, List<RecordingButtonComponent> Components = null, RecordingContentActions Actions = null)
		{
			this.Title = Title;
			this.Description = Description;
			this.Url = Url;
			this.Components = Components;
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
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; set; }



		/// <summary>
		/// List of button components offered with this message content.
		/// </summary>
		/// <value>List of button components offered with this message content.</value>
		[DataMember(Name = "components", EmitDefaultValue = false)]
		public List<RecordingButtonComponent> Components { get; set; }



		/// <summary>
		/// Actions to be taken.
		/// </summary>
		/// <value>Actions to be taken.</value>
		[DataMember(Name = "actions", EmitDefaultValue = false)]
		public RecordingContentActions Actions { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GenericTemplate {\n");

			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Url: ").Append(Url).Append("\n");
			sb.Append("  Components: ").Append(Components).Append("\n");
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
			return this.Equals(obj as GenericTemplate);
		}

		/// <summary>
		/// Returns true if GenericTemplate instances are equal
		/// </summary>
		/// <param name="other">Instance of GenericTemplate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(GenericTemplate other)
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
					this.Url == other.Url ||
					this.Url != null &&
					this.Url.Equals(other.Url)
				) &&
				(
					this.Components == other.Components ||
					this.Components != null &&
					this.Components.SequenceEqual(other.Components)
				) &&
				(
					this.Actions == other.Actions ||
					this.Actions != null &&
					this.Actions.Equals(other.Actions)
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

				if (this.Url != null)
					hash = hash * 59 + this.Url.GetHashCode();

				if (this.Components != null)
					hash = hash * 59 + this.Components.GetHashCode();

				if (this.Actions != null)
					hash = hash * 59 + this.Actions.GetHashCode();

				return hash;
			}
		}
	}

}
