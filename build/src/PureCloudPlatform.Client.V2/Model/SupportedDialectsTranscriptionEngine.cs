using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SupportedDialectsTranscriptionEngine
	/// </summary>
	[DataContract]
	public partial class SupportedDialectsTranscriptionEngine : IEquatable<SupportedDialectsTranscriptionEngine>
	{
		/// <summary>
		/// Gets or Sets Engine
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum EngineEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Genesys for "Genesys"
			/// </summary>
			[EnumMember(Value = "Genesys")]
			Genesys,

			/// <summary>
			/// Enum Genesysextended for "GenesysExtended"
			/// </summary>
			[EnumMember(Value = "GenesysExtended")]
			Genesysextended,

			/// <summary>
			/// Enum Transcriptionconnector for "TranscriptionConnector"
			/// </summary>
			[EnumMember(Value = "TranscriptionConnector")]
			Transcriptionconnector
		}
		/// <summary>
		/// Gets or Sets Engine
		/// </summary>
		[DataMember(Name = "engine", EmitDefaultValue = false)]
		public EngineEnum? Engine { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="SupportedDialectsTranscriptionEngine" /> class.
		/// </summary>
		/// <param name="Engine">Engine.</param>
		/// <param name="Dialects">Dialects.</param>
		/// <param name="EngineIntegration">EngineIntegration.</param>
		public SupportedDialectsTranscriptionEngine(EngineEnum? Engine = null, List<string> Dialects = null, EngineIntegration EngineIntegration = null)
		{
			this.Engine = Engine;
			this.Dialects = Dialects;
			this.EngineIntegration = EngineIntegration;

		}





		/// <summary>
		/// Gets or Sets Dialects
		/// </summary>
		[DataMember(Name = "dialects", EmitDefaultValue = false)]
		public List<string> Dialects { get; set; }



		/// <summary>
		/// Gets or Sets EngineIntegration
		/// </summary>
		[DataMember(Name = "engineIntegration", EmitDefaultValue = false)]
		public EngineIntegration EngineIntegration { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SupportedDialectsTranscriptionEngine {\n");

			sb.Append("  Engine: ").Append(Engine).Append("\n");
			sb.Append("  Dialects: ").Append(Dialects).Append("\n");
			sb.Append("  EngineIntegration: ").Append(EngineIntegration).Append("\n");
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
			return this.Equals(obj as SupportedDialectsTranscriptionEngine);
		}

		/// <summary>
		/// Returns true if SupportedDialectsTranscriptionEngine instances are equal
		/// </summary>
		/// <param name="other">Instance of SupportedDialectsTranscriptionEngine to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SupportedDialectsTranscriptionEngine other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Engine == other.Engine ||
					this.Engine != null &&
					this.Engine.Equals(other.Engine)
				) &&
				(
					this.Dialects == other.Dialects ||
					this.Dialects != null &&
					this.Dialects.SequenceEqual(other.Dialects)
				) &&
				(
					this.EngineIntegration == other.EngineIntegration ||
					this.EngineIntegration != null &&
					this.EngineIntegration.Equals(other.EngineIntegration)
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
				if (this.Engine != null)
					hash = hash * 59 + this.Engine.GetHashCode();

				if (this.Dialects != null)
					hash = hash * 59 + this.Dialects.GetHashCode();

				if (this.EngineIntegration != null)
					hash = hash * 59 + this.EngineIntegration.GetHashCode();

				return hash;
			}
		}
	}

}
