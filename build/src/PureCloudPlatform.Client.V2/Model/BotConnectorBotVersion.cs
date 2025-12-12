using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// A version description for a botConnector bot.
	/// </summary>
	[DataContract]
	public partial class BotConnectorBotVersion : IEquatable<BotConnectorBotVersion>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="BotConnectorBotVersion" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected BotConnectorBotVersion() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="BotConnectorBotVersion" /> class.
		/// </summary>
		/// <param name="Version">The name of the version. This can be up to 100 characters long and must be comprised of displayable characters without leading or trailing whitespace (required).</param>
		/// <param name="SupportedLanguages">The supported languages for this bot. EG &#39;en-us&#39; or &#39;es&#39;, etc; These language codes are W3C language identification tags (ISO 639-1 for the language name and ISO 3166 for the country code) (required).</param>
		/// <param name="Intents">A list of potential intents this bot will return, limit of 50 (required).</param>
		public BotConnectorBotVersion(string Version = null, List<string> SupportedLanguages = null, List<BotIntent> Intents = null)
		{
			this.Version = Version;
			this.SupportedLanguages = SupportedLanguages;
			this.Intents = Intents;

		}



		/// <summary>
		/// The name of the version. This can be up to 100 characters long and must be comprised of displayable characters without leading or trailing whitespace
		/// </summary>
		/// <value>The name of the version. This can be up to 100 characters long and must be comprised of displayable characters without leading or trailing whitespace</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public string Version { get; set; }



		/// <summary>
		/// The supported languages for this bot. EG &#39;en-us&#39; or &#39;es&#39;, etc; These language codes are W3C language identification tags (ISO 639-1 for the language name and ISO 3166 for the country code)
		/// </summary>
		/// <value>The supported languages for this bot. EG &#39;en-us&#39; or &#39;es&#39;, etc; These language codes are W3C language identification tags (ISO 639-1 for the language name and ISO 3166 for the country code)</value>
		[DataMember(Name = "supportedLanguages", EmitDefaultValue = false)]
		public List<string> SupportedLanguages { get; set; }



		/// <summary>
		/// A list of potential intents this bot will return, limit of 50
		/// </summary>
		/// <value>A list of potential intents this bot will return, limit of 50</value>
		[DataMember(Name = "intents", EmitDefaultValue = false)]
		public List<BotIntent> Intents { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BotConnectorBotVersion {\n");

			sb.Append("  Version: ").Append(Version).Append("\n");
			sb.Append("  SupportedLanguages: ").Append(SupportedLanguages).Append("\n");
			sb.Append("  Intents: ").Append(Intents).Append("\n");
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
			return this.Equals(obj as BotConnectorBotVersion);
		}

		/// <summary>
		/// Returns true if BotConnectorBotVersion instances are equal
		/// </summary>
		/// <param name="other">Instance of BotConnectorBotVersion to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BotConnectorBotVersion other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
				) &&
				(
					this.SupportedLanguages == other.SupportedLanguages ||
					this.SupportedLanguages != null &&
					this.SupportedLanguages.SequenceEqual(other.SupportedLanguages)
				) &&
				(
					this.Intents == other.Intents ||
					this.Intents != null &&
					this.Intents.SequenceEqual(other.Intents)
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
				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				if (this.SupportedLanguages != null)
					hash = hash * 59 + this.SupportedLanguages.GetHashCode();

				if (this.Intents != null)
					hash = hash * 59 + this.Intents.GetHashCode();

				return hash;
			}
		}
	}

}
