using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// A summary description for a bot
	/// </summary>
	[DataContract]
	public partial class BotConnectorSummary : IEquatable<BotConnectorSummary>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BotConnectorSummary" /> class.
		/// </summary>
		/// <param name="Id">The id of the bot..</param>
		/// <param name="Name">The name of the bot..</param>
		/// <param name="Description">An optional description of the bot..</param>
		/// <param name="BotCompositeTag">A system-generated string that contains metadata about this bot..</param>
		/// <param name="Versions">This bots version..</param>
		public BotConnectorSummary(string Id = null, string Name = null, string Description = null, string BotCompositeTag = null, List<BotConnectorVersionSummary> Versions = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.BotCompositeTag = BotCompositeTag;
			this.Versions = Versions;

		}



		/// <summary>
		/// The id of the bot.
		/// </summary>
		/// <value>The id of the bot.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The name of the bot.
		/// </summary>
		/// <value>The name of the bot.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// An optional description of the bot.
		/// </summary>
		/// <value>An optional description of the bot.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// A system-generated string that contains metadata about this bot.
		/// </summary>
		/// <value>A system-generated string that contains metadata about this bot.</value>
		[DataMember(Name = "botCompositeTag", EmitDefaultValue = false)]
		public string BotCompositeTag { get; set; }



		/// <summary>
		/// This bots version.
		/// </summary>
		/// <value>This bots version.</value>
		[DataMember(Name = "versions", EmitDefaultValue = false)]
		public List<BotConnectorVersionSummary> Versions { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BotConnectorSummary {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  BotCompositeTag: ").Append(BotCompositeTag).Append("\n");
			sb.Append("  Versions: ").Append(Versions).Append("\n");
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
			return this.Equals(obj as BotConnectorSummary);
		}

		/// <summary>
		/// Returns true if BotConnectorSummary instances are equal
		/// </summary>
		/// <param name="other">Instance of BotConnectorSummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BotConnectorSummary other)
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
					this.BotCompositeTag == other.BotCompositeTag ||
					this.BotCompositeTag != null &&
					this.BotCompositeTag.Equals(other.BotCompositeTag)
				) &&
				(
					this.Versions == other.Versions ||
					this.Versions != null &&
					this.Versions.SequenceEqual(other.Versions)
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

				if (this.BotCompositeTag != null)
					hash = hash * 59 + this.BotCompositeTag.GetHashCode();

				if (this.Versions != null)
					hash = hash * 59 + this.Versions.GetHashCode();

				return hash;
			}
		}
	}

}
