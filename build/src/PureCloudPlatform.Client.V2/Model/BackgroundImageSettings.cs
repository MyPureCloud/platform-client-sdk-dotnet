using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// The settings to Agent Video background image
	/// </summary>
	[DataContract]
	public partial class BackgroundImageSettings : IEquatable<BackgroundImageSettings>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BackgroundImageSettings" /> class.
		/// </summary>
		/// <param name="Url">BackgroundImage URL for agent video settings.</param>
		public BackgroundImageSettings(string Url = null)
		{
			this.Url = Url;

		}



		/// <summary>
		/// BackgroundImage URL for agent video settings
		/// </summary>
		/// <value>BackgroundImage URL for agent video settings</value>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BackgroundImageSettings {\n");

			sb.Append("  Url: ").Append(Url).Append("\n");
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
			return this.Equals(obj as BackgroundImageSettings);
		}

		/// <summary>
		/// Returns true if BackgroundImageSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of BackgroundImageSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BackgroundImageSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Url == other.Url ||
					this.Url != null &&
					this.Url.Equals(other.Url)
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

				return hash;
			}
		}
	}

}
