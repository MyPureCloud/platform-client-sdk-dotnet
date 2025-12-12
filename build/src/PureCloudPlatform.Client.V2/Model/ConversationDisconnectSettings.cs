using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationDisconnectSettings
	/// </summary>
	[DataContract]
	public partial class ConversationDisconnectSettings : IEquatable<ConversationDisconnectSettings>
	{
		/// <summary>
		/// Conversation disconnect type
		/// </summary>
		/// <value>Conversation disconnect type</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Send for "Send"
			/// </summary>
			[EnumMember(Value = "Send")]
			Send,

			/// <summary>
			/// Enum Readonly for "ReadOnly"
			/// </summary>
			[EnumMember(Value = "ReadOnly")]
			Readonly
		}
		/// <summary>
		/// Conversation disconnect type
		/// </summary>
		/// <value>Conversation disconnect type</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationDisconnectSettings" /> class.
		/// </summary>
		/// <param name="Enabled">whether or not conversation disconnect setting is enabled.</param>
		/// <param name="Type">Conversation disconnect type.</param>
		public ConversationDisconnectSettings(bool? Enabled = null, TypeEnum? Type = null)
		{
			this.Enabled = Enabled;
			this.Type = Type;

		}



		/// <summary>
		/// whether or not conversation disconnect setting is enabled
		/// </summary>
		/// <value>whether or not conversation disconnect setting is enabled</value>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationDisconnectSettings {\n");

			sb.Append("  Enabled: ").Append(Enabled).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
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
			return this.Equals(obj as ConversationDisconnectSettings);
		}

		/// <summary>
		/// Returns true if ConversationDisconnectSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationDisconnectSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationDisconnectSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Enabled == other.Enabled ||
					this.Enabled != null &&
					this.Enabled.Equals(other.Enabled)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
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
				if (this.Enabled != null)
					hash = hash * 59 + this.Enabled.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				return hash;
			}
		}
	}

}
