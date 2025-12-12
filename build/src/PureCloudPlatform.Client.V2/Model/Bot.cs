using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// A bot instance
	/// </summary>
	[DataContract]
	public partial class Bot : IEquatable<Bot>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Bot" /> class.
		/// </summary>
		/// <param name="Id">This is a string type that should denote a unique ID of the bot for calling purposes by the Genesys service (EG a UUID)..</param>
		/// <param name="Name">This is the name that will be displayed to the user in Architect..</param>
		/// <param name="Description">An optional description of the bot..</param>
		/// <param name="Provider">The provider of the bot..</param>
		/// <param name="Versions">This bots version..</param>
		/// <param name="BotCompositeTag">A system-generated string that contains metadata about this bot..</param>
		public Bot(string Id = null, string Name = null, string Description = null, string Provider = null, List<BotVersion> Versions = null, string BotCompositeTag = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.Provider = Provider;
			this.Versions = Versions;
			this.BotCompositeTag = BotCompositeTag;

		}



		/// <summary>
		/// This is a string type that should denote a unique ID of the bot for calling purposes by the Genesys service (EG a UUID).
		/// </summary>
		/// <value>This is a string type that should denote a unique ID of the bot for calling purposes by the Genesys service (EG a UUID).</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// This is the name that will be displayed to the user in Architect.
		/// </summary>
		/// <value>This is the name that will be displayed to the user in Architect.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// An optional description of the bot.
		/// </summary>
		/// <value>An optional description of the bot.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// The provider of the bot.
		/// </summary>
		/// <value>The provider of the bot.</value>
		[DataMember(Name = "provider", EmitDefaultValue = false)]
		public string Provider { get; set; }



		/// <summary>
		/// This bots version.
		/// </summary>
		/// <value>This bots version.</value>
		[DataMember(Name = "versions", EmitDefaultValue = false)]
		public List<BotVersion> Versions { get; set; }



		/// <summary>
		/// A system-generated string that contains metadata about this bot.
		/// </summary>
		/// <value>A system-generated string that contains metadata about this bot.</value>
		[DataMember(Name = "botCompositeTag", EmitDefaultValue = false)]
		public string BotCompositeTag { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Bot {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Provider: ").Append(Provider).Append("\n");
			sb.Append("  Versions: ").Append(Versions).Append("\n");
			sb.Append("  BotCompositeTag: ").Append(BotCompositeTag).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as Bot);
		}

		/// <summary>
		/// Returns true if Bot instances are equal
		/// </summary>
		/// <param name="other">Instance of Bot to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Bot other)
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
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.Provider == other.Provider ||
					this.Provider != null &&
					this.Provider.Equals(other.Provider)
				) &&
				(
					this.Versions == other.Versions ||
					this.Versions != null &&
					this.Versions.SequenceEqual(other.Versions)
				) &&
				(
					this.BotCompositeTag == other.BotCompositeTag ||
					this.BotCompositeTag != null &&
					this.BotCompositeTag.Equals(other.BotCompositeTag)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Provider != null)
					hash = hash * 59 + this.Provider.GetHashCode();

				if (this.Versions != null)
					hash = hash * 59 + this.Versions.GetHashCode();

				if (this.BotCompositeTag != null)
					hash = hash * 59 + this.BotCompositeTag.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
