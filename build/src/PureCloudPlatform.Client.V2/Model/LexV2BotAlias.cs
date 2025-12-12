using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LexV2BotAlias
	/// </summary>
	[DataContract]
	public partial class LexV2BotAlias : IEquatable<LexV2BotAlias>
	{
		/// <summary>
		/// The status of the Lex V2 bot alias
		/// </summary>
		/// <value>The status of the Lex V2 bot alias</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Creating for "Creating"
			/// </summary>
			[EnumMember(Value = "Creating")]
			Creating,

			/// <summary>
			/// Enum Available for "Available"
			/// </summary>
			[EnumMember(Value = "Available")]
			Available,

			/// <summary>
			/// Enum Deleting for "Deleting"
			/// </summary>
			[EnumMember(Value = "Deleting")]
			Deleting,

			/// <summary>
			/// Enum Failed for "Failed"
			/// </summary>
			[EnumMember(Value = "Failed")]
			Failed
		}
		/// <summary>
		/// The status of the Lex V2 bot alias
		/// </summary>
		/// <value>The status of the Lex V2 bot alias</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="LexV2BotAlias" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected LexV2BotAlias() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="LexV2BotAlias" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Region">The Lex V2 bot region (required).</param>
		/// <param name="AliasId">The Lex V2 bot alias Id (required).</param>
		/// <param name="Bot">The Lex V2 bot this is an alias for.</param>
		/// <param name="BotVersion">The version of the Lex V2 bot this alias points at.</param>
		/// <param name="Status">The status of the Lex V2 bot alias.</param>
		/// <param name="Language">The target language of the Lex V2 bot.</param>
		/// <param name="Intents">An array of Intents associated with this bot alias.</param>
		public LexV2BotAlias(string Name = null, string Region = null, string AliasId = null, LexV2Bot Bot = null, string BotVersion = null, StatusEnum? Status = null, string Language = null, List<LexV2Intent> Intents = null)
		{
			this.Name = Name;
			this.Region = Region;
			this.AliasId = AliasId;
			this.Bot = Bot;
			this.BotVersion = BotVersion;
			this.Status = Status;
			this.Language = Language;
			this.Intents = Intents;

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
		/// The Lex V2 bot region
		/// </summary>
		/// <value>The Lex V2 bot region</value>
		[DataMember(Name = "region", EmitDefaultValue = false)]
		public string Region { get; set; }



		/// <summary>
		/// The Lex V2 bot alias Id
		/// </summary>
		/// <value>The Lex V2 bot alias Id</value>
		[DataMember(Name = "aliasId", EmitDefaultValue = false)]
		public string AliasId { get; set; }



		/// <summary>
		/// The Lex V2 bot this is an alias for
		/// </summary>
		/// <value>The Lex V2 bot this is an alias for</value>
		[DataMember(Name = "bot", EmitDefaultValue = false)]
		public LexV2Bot Bot { get; set; }



		/// <summary>
		/// The version of the Lex V2 bot this alias points at
		/// </summary>
		/// <value>The version of the Lex V2 bot this alias points at</value>
		[DataMember(Name = "botVersion", EmitDefaultValue = false)]
		public string BotVersion { get; set; }





		/// <summary>
		/// The target language of the Lex V2 bot
		/// </summary>
		/// <value>The target language of the Lex V2 bot</value>
		[DataMember(Name = "language", EmitDefaultValue = false)]
		public string Language { get; set; }



		/// <summary>
		/// An array of Intents associated with this bot alias
		/// </summary>
		/// <value>An array of Intents associated with this bot alias</value>
		[DataMember(Name = "intents", EmitDefaultValue = false)]
		public List<LexV2Intent> Intents { get; set; }



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
			sb.Append("class LexV2BotAlias {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Region: ").Append(Region).Append("\n");
			sb.Append("  AliasId: ").Append(AliasId).Append("\n");
			sb.Append("  Bot: ").Append(Bot).Append("\n");
			sb.Append("  BotVersion: ").Append(BotVersion).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Language: ").Append(Language).Append("\n");
			sb.Append("  Intents: ").Append(Intents).Append("\n");
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
			return this.Equals(obj as LexV2BotAlias);
		}

		/// <summary>
		/// Returns true if LexV2BotAlias instances are equal
		/// </summary>
		/// <param name="other">Instance of LexV2BotAlias to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LexV2BotAlias other)
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
					this.Region == other.Region ||
					this.Region != null &&
					this.Region.Equals(other.Region)
				) &&
				(
					this.AliasId == other.AliasId ||
					this.AliasId != null &&
					this.AliasId.Equals(other.AliasId)
				) &&
				(
					this.Bot == other.Bot ||
					this.Bot != null &&
					this.Bot.Equals(other.Bot)
				) &&
				(
					this.BotVersion == other.BotVersion ||
					this.BotVersion != null &&
					this.BotVersion.Equals(other.BotVersion)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.Language == other.Language ||
					this.Language != null &&
					this.Language.Equals(other.Language)
				) &&
				(
					this.Intents == other.Intents ||
					this.Intents != null &&
					this.Intents.SequenceEqual(other.Intents)
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

				if (this.Region != null)
					hash = hash * 59 + this.Region.GetHashCode();

				if (this.AliasId != null)
					hash = hash * 59 + this.AliasId.GetHashCode();

				if (this.Bot != null)
					hash = hash * 59 + this.Bot.GetHashCode();

				if (this.BotVersion != null)
					hash = hash * 59 + this.BotVersion.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.Language != null)
					hash = hash * 59 + this.Language.GetHashCode();

				if (this.Intents != null)
					hash = hash * 59 + this.Intents.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
