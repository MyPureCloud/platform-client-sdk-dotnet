using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// JourneyWebEventsNotificationPage
	/// </summary>
	[DataContract]
	public partial class JourneyWebEventsNotificationPage : IEquatable<JourneyWebEventsNotificationPage>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="JourneyWebEventsNotificationPage" /> class.
		/// </summary>
		/// <param name="Url">Url.</param>
		/// <param name="Title">Title.</param>
		/// <param name="Domain">Domain.</param>
		/// <param name="Fragment">Fragment.</param>
		/// <param name="Hostname">Hostname.</param>
		/// <param name="Keywords">Keywords.</param>
		/// <param name="Lang">Lang.</param>
		/// <param name="Pathname">Pathname.</param>
		/// <param name="QueryString">QueryString.</param>
		/// <param name="Breadcrumb">Breadcrumb.</param>
		public JourneyWebEventsNotificationPage(string Url = null, string Title = null, string Domain = null, string Fragment = null, string Hostname = null, string Keywords = null, string Lang = null, string Pathname = null, string QueryString = null, List<string> Breadcrumb = null)
		{
			this.Url = Url;
			this.Title = Title;
			this.Domain = Domain;
			this.Fragment = Fragment;
			this.Hostname = Hostname;
			this.Keywords = Keywords;
			this.Lang = Lang;
			this.Pathname = Pathname;
			this.QueryString = QueryString;
			this.Breadcrumb = Breadcrumb;

		}



		/// <summary>
		/// Gets or Sets Url
		/// </summary>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; set; }



		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// Gets or Sets Domain
		/// </summary>
		[DataMember(Name = "domain", EmitDefaultValue = false)]
		public string Domain { get; set; }



		/// <summary>
		/// Gets or Sets Fragment
		/// </summary>
		[DataMember(Name = "fragment", EmitDefaultValue = false)]
		public string Fragment { get; set; }



		/// <summary>
		/// Gets or Sets Hostname
		/// </summary>
		[DataMember(Name = "hostname", EmitDefaultValue = false)]
		public string Hostname { get; set; }



		/// <summary>
		/// Gets or Sets Keywords
		/// </summary>
		[DataMember(Name = "keywords", EmitDefaultValue = false)]
		public string Keywords { get; set; }



		/// <summary>
		/// Gets or Sets Lang
		/// </summary>
		[DataMember(Name = "lang", EmitDefaultValue = false)]
		public string Lang { get; set; }



		/// <summary>
		/// Gets or Sets Pathname
		/// </summary>
		[DataMember(Name = "pathname", EmitDefaultValue = false)]
		public string Pathname { get; set; }



		/// <summary>
		/// Gets or Sets QueryString
		/// </summary>
		[DataMember(Name = "queryString", EmitDefaultValue = false)]
		public string QueryString { get; set; }



		/// <summary>
		/// Gets or Sets Breadcrumb
		/// </summary>
		[DataMember(Name = "breadcrumb", EmitDefaultValue = false)]
		public List<string> Breadcrumb { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JourneyWebEventsNotificationPage {\n");

			sb.Append("  Url: ").Append(Url).Append("\n");
			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Domain: ").Append(Domain).Append("\n");
			sb.Append("  Fragment: ").Append(Fragment).Append("\n");
			sb.Append("  Hostname: ").Append(Hostname).Append("\n");
			sb.Append("  Keywords: ").Append(Keywords).Append("\n");
			sb.Append("  Lang: ").Append(Lang).Append("\n");
			sb.Append("  Pathname: ").Append(Pathname).Append("\n");
			sb.Append("  QueryString: ").Append(QueryString).Append("\n");
			sb.Append("  Breadcrumb: ").Append(Breadcrumb).Append("\n");
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
			return this.Equals(obj as JourneyWebEventsNotificationPage);
		}

		/// <summary>
		/// Returns true if JourneyWebEventsNotificationPage instances are equal
		/// </summary>
		/// <param name="other">Instance of JourneyWebEventsNotificationPage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JourneyWebEventsNotificationPage other)
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
					this.Domain == other.Domain ||
					this.Domain != null &&
					this.Domain.Equals(other.Domain)
				) &&
				(
					this.Fragment == other.Fragment ||
					this.Fragment != null &&
					this.Fragment.Equals(other.Fragment)
				) &&
				(
					this.Hostname == other.Hostname ||
					this.Hostname != null &&
					this.Hostname.Equals(other.Hostname)
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
				) &&
				(
					this.Pathname == other.Pathname ||
					this.Pathname != null &&
					this.Pathname.Equals(other.Pathname)
				) &&
				(
					this.QueryString == other.QueryString ||
					this.QueryString != null &&
					this.QueryString.Equals(other.QueryString)
				) &&
				(
					this.Breadcrumb == other.Breadcrumb ||
					this.Breadcrumb != null &&
					this.Breadcrumb.SequenceEqual(other.Breadcrumb)
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

				if (this.Domain != null)
					hash = hash * 59 + this.Domain.GetHashCode();

				if (this.Fragment != null)
					hash = hash * 59 + this.Fragment.GetHashCode();

				if (this.Hostname != null)
					hash = hash * 59 + this.Hostname.GetHashCode();

				if (this.Keywords != null)
					hash = hash * 59 + this.Keywords.GetHashCode();

				if (this.Lang != null)
					hash = hash * 59 + this.Lang.GetHashCode();

				if (this.Pathname != null)
					hash = hash * 59 + this.Pathname.GetHashCode();

				if (this.QueryString != null)
					hash = hash * 59 + this.QueryString.GetHashCode();

				if (this.Breadcrumb != null)
					hash = hash * 59 + this.Breadcrumb.GetHashCode();

				return hash;
			}
		}
	}

}
