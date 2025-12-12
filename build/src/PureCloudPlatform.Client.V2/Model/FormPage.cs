using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// A page in a form with title, subtitle, and components
	/// </summary>
	[DataContract]
	public partial class FormPage : IEquatable<FormPage>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="FormPage" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected FormPage() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="FormPage" /> class.
		/// </summary>
		/// <param name="Title">Title of the page (required).</param>
		/// <param name="Subtitle">Subtitle of the page (required).</param>
		/// <param name="PageComponents">Components on this page (required).</param>
		public FormPage(string Title = null, string Subtitle = null, List<FormPageComponent> PageComponents = null)
		{
			this.Title = Title;
			this.Subtitle = Subtitle;
			this.PageComponents = PageComponents;

		}



		/// <summary>
		/// Title of the page
		/// </summary>
		/// <value>Title of the page</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// Subtitle of the page
		/// </summary>
		/// <value>Subtitle of the page</value>
		[DataMember(Name = "subtitle", EmitDefaultValue = false)]
		public string Subtitle { get; set; }



		/// <summary>
		/// Components on this page
		/// </summary>
		/// <value>Components on this page</value>
		[DataMember(Name = "pageComponents", EmitDefaultValue = false)]
		public List<FormPageComponent> PageComponents { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FormPage {\n");

			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
			sb.Append("  PageComponents: ").Append(PageComponents).Append("\n");
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
			return this.Equals(obj as FormPage);
		}

		/// <summary>
		/// Returns true if FormPage instances are equal
		/// </summary>
		/// <param name="other">Instance of FormPage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FormPage other)
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
					this.PageComponents == other.PageComponents ||
					this.PageComponents != null &&
					this.PageComponents.SequenceEqual(other.PageComponents)
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

				if (this.PageComponents != null)
					hash = hash * 59 + this.PageComponents.GetHashCode();

				return hash;
			}
		}
	}

}
