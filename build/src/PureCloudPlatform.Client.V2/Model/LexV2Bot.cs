using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LexV2Bot
	/// </summary>
	[DataContract]
	public partial class LexV2Bot : IEquatable<LexV2Bot>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="LexV2Bot" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected LexV2Bot() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="LexV2Bot" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="BotId">Lex V2 bot Id (required).</param>
		/// <param name="Region">A region of the Lex V2 bot (required).</param>
		/// <param name="Description">A description of the Lex V2 bot.</param>
		public LexV2Bot(string Name = null, string BotId = null, string Region = null, string Description = null)
		{
			this.Name = Name;
			this.BotId = BotId;
			this.Region = Region;
			this.Description = Description;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Lex V2 bot Id
		/// </summary>
		/// <value>Lex V2 bot Id</value>
		[DataMember(Name = "botId", EmitDefaultValue = false)]
		public string BotId { get; set; }



		/// <summary>
		/// A region of the Lex V2 bot
		/// </summary>
		/// <value>A region of the Lex V2 bot</value>
		[DataMember(Name = "region", EmitDefaultValue = false)]
		public string Region { get; set; }



		/// <summary>
		/// A description of the Lex V2 bot
		/// </summary>
		/// <value>A description of the Lex V2 bot</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



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
			sb.Append("class LexV2Bot {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  BotId: ").Append(BotId).Append("\n");
			sb.Append("  Region: ").Append(Region).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
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
			return this.Equals(obj as LexV2Bot);
		}

		/// <summary>
		/// Returns true if LexV2Bot instances are equal
		/// </summary>
		/// <param name="other">Instance of LexV2Bot to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LexV2Bot other)
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
					this.BotId == other.BotId ||
					this.BotId != null &&
					this.BotId.Equals(other.BotId)
				) &&
				(
					this.Region == other.Region ||
					this.Region != null &&
					this.Region.Equals(other.Region)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
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

				if (this.BotId != null)
					hash = hash * 59 + this.BotId.GetHashCode();

				if (this.Region != null)
					hash = hash * 59 + this.Region.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
