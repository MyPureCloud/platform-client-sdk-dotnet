using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WebEventBrowser
	/// </summary>
	[DataContract]
	public partial class WebEventBrowser : IEquatable<WebEventBrowser>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="WebEventBrowser" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected WebEventBrowser() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="WebEventBrowser" /> class.
		/// </summary>
		/// <param name="Family">Browser family (e.g. Chrome, Safari, Firefox). (required).</param>
		/// <param name="Version">Browser version (e.g. 68.0.3440.84). (required).</param>
		/// <param name="Lang">Language the browser is set to. Must conform to BCP 47..</param>
		public WebEventBrowser(string Family = null, string Version = null, string Lang = null)
		{
			this.Family = Family;
			this.Version = Version;
			this.Lang = Lang;

		}



		/// <summary>
		/// Browser family (e.g. Chrome, Safari, Firefox).
		/// </summary>
		/// <value>Browser family (e.g. Chrome, Safari, Firefox).</value>
		[DataMember(Name = "family", EmitDefaultValue = false)]
		public string Family { get; set; }



		/// <summary>
		/// Browser version (e.g. 68.0.3440.84).
		/// </summary>
		/// <value>Browser version (e.g. 68.0.3440.84).</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public string Version { get; set; }



		/// <summary>
		/// Language the browser is set to. Must conform to BCP 47.
		/// </summary>
		/// <value>Language the browser is set to. Must conform to BCP 47.</value>
		[DataMember(Name = "lang", EmitDefaultValue = false)]
		public string Lang { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WebEventBrowser {\n");

			sb.Append("  Family: ").Append(Family).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
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
			return this.Equals(obj as WebEventBrowser);
		}

		/// <summary>
		/// Returns true if WebEventBrowser instances are equal
		/// </summary>
		/// <param name="other">Instance of WebEventBrowser to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WebEventBrowser other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Family == other.Family ||
					this.Family != null &&
					this.Family.Equals(other.Family)
				) &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
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
				if (this.Family != null)
					hash = hash * 59 + this.Family.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				if (this.Lang != null)
					hash = hash * 59 + this.Lang.GetHashCode();

				return hash;
			}
		}
	}

}
