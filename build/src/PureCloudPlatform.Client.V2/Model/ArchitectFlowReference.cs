using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ArchitectFlowReference
	/// </summary>
	[DataContract]
	public partial class ArchitectFlowReference : IEquatable<ArchitectFlowReference>
	{
		/// <summary>
		/// The flow type.
		/// </summary>
		/// <value>The flow type.</value>
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
			/// Enum Bot for "BOT"
			/// </summary>
			[EnumMember(Value = "BOT")]
			Bot,

			/// <summary>
			/// Enum Commonmodule for "COMMONMODULE"
			/// </summary>
			[EnumMember(Value = "COMMONMODULE")]
			Commonmodule,

			/// <summary>
			/// Enum Digitalbot for "DIGITALBOT"
			/// </summary>
			[EnumMember(Value = "DIGITALBOT")]
			Digitalbot,

			/// <summary>
			/// Enum Inboundcall for "INBOUNDCALL"
			/// </summary>
			[EnumMember(Value = "INBOUNDCALL")]
			Inboundcall,

			/// <summary>
			/// Enum Inboundchat for "INBOUNDCHAT"
			/// </summary>
			[EnumMember(Value = "INBOUNDCHAT")]
			Inboundchat,

			/// <summary>
			/// Enum Inboundemail for "INBOUNDEMAIL"
			/// </summary>
			[EnumMember(Value = "INBOUNDEMAIL")]
			Inboundemail,

			/// <summary>
			/// Enum Inboundshortmessage for "INBOUNDSHORTMESSAGE"
			/// </summary>
			[EnumMember(Value = "INBOUNDSHORTMESSAGE")]
			Inboundshortmessage,

			/// <summary>
			/// Enum Inqueuecall for "INQUEUECALL"
			/// </summary>
			[EnumMember(Value = "INQUEUECALL")]
			Inqueuecall,

			/// <summary>
			/// Enum Inqueueemail for "INQUEUEEMAIL"
			/// </summary>
			[EnumMember(Value = "INQUEUEEMAIL")]
			Inqueueemail,

			/// <summary>
			/// Enum Inqueueshortmessage for "INQUEUESHORTMESSAGE"
			/// </summary>
			[EnumMember(Value = "INQUEUESHORTMESSAGE")]
			Inqueueshortmessage,

			/// <summary>
			/// Enum Outboundcall for "OUTBOUNDCALL"
			/// </summary>
			[EnumMember(Value = "OUTBOUNDCALL")]
			Outboundcall,

			/// <summary>
			/// Enum Securecall for "SECURECALL"
			/// </summary>
			[EnumMember(Value = "SECURECALL")]
			Securecall,

			/// <summary>
			/// Enum Speech for "SPEECH"
			/// </summary>
			[EnumMember(Value = "SPEECH")]
			Speech,

			/// <summary>
			/// Enum Surveyinvite for "SURVEYINVITE"
			/// </summary>
			[EnumMember(Value = "SURVEYINVITE")]
			Surveyinvite,

			/// <summary>
			/// Enum Voice for "VOICE"
			/// </summary>
			[EnumMember(Value = "VOICE")]
			Voice,

			/// <summary>
			/// Enum Voicemail for "VOICEMAIL"
			/// </summary>
			[EnumMember(Value = "VOICEMAIL")]
			Voicemail,

			/// <summary>
			/// Enum Voicesurvey for "VOICESURVEY"
			/// </summary>
			[EnumMember(Value = "VOICESURVEY")]
			Voicesurvey,

			/// <summary>
			/// Enum Workflow for "WORKFLOW"
			/// </summary>
			[EnumMember(Value = "WORKFLOW")]
			Workflow,

			/// <summary>
			/// Enum Workitem for "WORKITEM"
			/// </summary>
			[EnumMember(Value = "WORKITEM")]
			Workitem
		}
		/// <summary>
		/// The flow type.
		/// </summary>
		/// <value>The flow type.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ArchitectFlowReference" /> class.
		/// </summary>
		/// <param name="Id">The flow identifier..</param>
		/// <param name="Name">The flow name..</param>
		/// <param name="Type">The flow type..</param>
		/// <param name="Version">The flow version..</param>
		public ArchitectFlowReference(string Id = null, string Name = null, TypeEnum? Type = null, string Version = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.Type = Type;
			this.Version = Version;

		}



		/// <summary>
		/// The flow identifier.
		/// </summary>
		/// <value>The flow identifier.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The flow name.
		/// </summary>
		/// <value>The flow name.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }





		/// <summary>
		/// The flow version.
		/// </summary>
		/// <value>The flow version.</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public string Version { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ArchitectFlowReference {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
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
			return this.Equals(obj as ArchitectFlowReference);
		}

		/// <summary>
		/// Returns true if ArchitectFlowReference instances are equal
		/// </summary>
		/// <param name="other">Instance of ArchitectFlowReference to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ArchitectFlowReference other)
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
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
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

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				return hash;
			}
		}
	}

}
