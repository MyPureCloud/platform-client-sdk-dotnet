using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// RequestPage
	/// </summary>
	[DataContract]
	public partial class RequestPage : IEquatable<RequestPage>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="RequestPage" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected RequestPage() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="RequestPage" /> class.
		/// </summary>
		/// <param name="Url">The page URL. (required).</param>
		/// <param name="Title">Title of the page. (required).</param>
		/// <param name="Keywords">Keywords from the HTML &lt;meta&gt; tag of the page..</param>
		/// <param name="Lang">ISO 639-1 language code for the page as defined in the &lt;html&gt; tag..</param>
		public RequestPage(string Url = null, string Title = null, string Keywords = null, string Lang = null)
		{
			this.Url = Url;
			this.Title = Title;
			this.Keywords = Keywords;
			this.Lang = Lang;

		}



		/// <summary>
		/// The page URL.
		/// </summary>
		/// <value>The page URL.</value>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; set; }



		/// <summary>
		/// Title of the page.
		/// </summary>
		/// <value>Title of the page.</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// Keywords from the HTML &lt;meta&gt; tag of the page.
		/// </summary>
		/// <value>Keywords from the HTML &lt;meta&gt; tag of the page.</value>
		[DataMember(Name = "keywords", EmitDefaultValue = false)]
		public string Keywords { get; set; }



		/// <summary>
		/// ISO 639-1 language code for the page as defined in the &lt;html&gt; tag.
		/// </summary>
		/// <value>ISO 639-1 language code for the page as defined in the &lt;html&gt; tag.</value>
		[DataMember(Name = "lang", EmitDefaultValue = false)]
		public string Lang { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RequestPage {\n");

			sb.Append("  Url: ").Append(Url).Append("\n");
			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Keywords: ").Append(Keywords).Append("\n");
			sb.Append("  Lang: ").Append(Lang).Append("\n");
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
			return this.Equals(obj as RequestPage);
		}

		/// <summary>
		/// Returns true if RequestPage instances are equal
		/// </summary>
		/// <param name="other">Instance of RequestPage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RequestPage other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Url == other.Url ||
					this.Url != null &&
					this.Url.Equals(other.Url)
				) &&
				(
					this.Title == other.Title ||
					this.Title != null &&
					this.Title.Equals(other.Title)
				) &&
				(
					this.Keywords == other.Keywords ||
					this.Keywords != null &&
					this.Keywords.Equals(other.Keywords)
				) &&
				(
					this.Lang == other.Lang ||
					this.Lang != null &&
					this.Lang.Equals(other.Lang)
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
				if (this.Url != null)
					hash = hash * 59 + this.Url.GetHashCode();

				if (this.Title != null)
					hash = hash * 59 + this.Title.GetHashCode();

				if (this.Keywords != null)
					hash = hash * 59 + this.Keywords.GetHashCode();

				if (this.Lang != null)
					hash = hash * 59 + this.Lang.GetHashCode();

				return hash;
			}
		}
	}

}
