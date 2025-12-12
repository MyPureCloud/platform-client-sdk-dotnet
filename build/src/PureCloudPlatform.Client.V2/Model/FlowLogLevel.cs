using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// This is a table of settings per a loglevel that define what will be logged in executionData when enabled (true)
	/// </summary>
	[DataContract]
	public partial class FlowLogLevel : IEquatable<FlowLogLevel>
	{
		/// <summary>
		/// The logLevel for this characteristics set
		/// </summary>
		/// <value>The logLevel for this characteristics set</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum LevelEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown,

			/// <summary>
			/// Enum Disabled for "Disabled"
			/// </summary>
			[EnumMember(Value = "Disabled")]
			Disabled,

			/// <summary>
			/// Enum Base for "Base"
			/// </summary>
			[EnumMember(Value = "Base")]
			Base,

			/// <summary>
			/// Enum Notes for "Notes"
			/// </summary>
			[EnumMember(Value = "Notes")]
			Notes,

			/// <summary>
			/// Enum Verbosenotes for "VerboseNotes"
			/// </summary>
			[EnumMember(Value = "VerboseNotes")]
			Verbosenotes,

			/// <summary>
			/// Enum All for "All"
			/// </summary>
			[EnumMember(Value = "All")]
			All
		}
		/// <summary>
		/// The logLevel for this characteristics set
		/// </summary>
		/// <value>The logLevel for this characteristics set</value>
		[DataMember(Name = "level", EmitDefaultValue = false)]
		public LevelEnum? Level { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="FlowLogLevel" /> class.
		/// </summary>
		/// <param name="Level">The logLevel for this characteristics set.</param>
		/// <param name="Characteristics">Shows what characteristics are enabled for this log level.</param>
		public FlowLogLevel(LevelEnum? Level = null, FlowCharacteristics Characteristics = null)
		{
			this.Level = Level;
			this.Characteristics = Characteristics;

		}





		/// <summary>
		/// Shows what characteristics are enabled for this log level
		/// </summary>
		/// <value>Shows what characteristics are enabled for this log level</value>
		[DataMember(Name = "characteristics", EmitDefaultValue = false)]
		public FlowCharacteristics Characteristics { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FlowLogLevel {\n");

			sb.Append("  Level: ").Append(Level).Append("\n");
			sb.Append("  Characteristics: ").Append(Characteristics).Append("\n");
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
			return this.Equals(obj as FlowLogLevel);
		}

		/// <summary>
		/// Returns true if FlowLogLevel instances are equal
		/// </summary>
		/// <param name="other">Instance of FlowLogLevel to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FlowLogLevel other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Level == other.Level ||
					this.Level != null &&
					this.Level.Equals(other.Level)
				) &&
				(
					this.Characteristics == other.Characteristics ||
					this.Characteristics != null &&
					this.Characteristics.Equals(other.Characteristics)
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
				if (this.Level != null)
					hash = hash * 59 + this.Level.GetHashCode();

				if (this.Characteristics != null)
					hash = hash * 59 + this.Characteristics.GetHashCode();

				return hash;
			}
		}
	}

}
