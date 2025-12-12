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
	public partial class FlowSettingsResponse : IEquatable<FlowSettingsResponse>
	{
		/// <summary>
		/// The Flow Type
		/// </summary>
		/// <value>The Flow Type</value>
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
			/// Enum Bot for "bot"
			/// </summary>
			[EnumMember(Value = "bot")]
			Bot,

			/// <summary>
			/// Enum Commonmodule for "commonmodule"
			/// </summary>
			[EnumMember(Value = "commonmodule")]
			Commonmodule,

			/// <summary>
			/// Enum Digitalbot for "digitalbot"
			/// </summary>
			[EnumMember(Value = "digitalbot")]
			Digitalbot,

			/// <summary>
			/// Enum Inboundcall for "inboundcall"
			/// </summary>
			[EnumMember(Value = "inboundcall")]
			Inboundcall,

			/// <summary>
			/// Enum Inboundchat for "inboundchat"
			/// </summary>
			[EnumMember(Value = "inboundchat")]
			Inboundchat,

			/// <summary>
			/// Enum Inboundemail for "inboundemail"
			/// </summary>
			[EnumMember(Value = "inboundemail")]
			Inboundemail,

			/// <summary>
			/// Enum Inboundshortmessage for "inboundshortmessage"
			/// </summary>
			[EnumMember(Value = "inboundshortmessage")]
			Inboundshortmessage,

			/// <summary>
			/// Enum Inqueuecall for "inqueuecall"
			/// </summary>
			[EnumMember(Value = "inqueuecall")]
			Inqueuecall,

			/// <summary>
			/// Enum Inqueueshortmessage for "inqueueshortmessage"
			/// </summary>
			[EnumMember(Value = "inqueueshortmessage")]
			Inqueueshortmessage,

			/// <summary>
			/// Enum Inqueueemail for "inqueueemail"
			/// </summary>
			[EnumMember(Value = "inqueueemail")]
			Inqueueemail,

			/// <summary>
			/// Enum Outboundcall for "outboundcall"
			/// </summary>
			[EnumMember(Value = "outboundcall")]
			Outboundcall,

			/// <summary>
			/// Enum Securecall for "securecall"
			/// </summary>
			[EnumMember(Value = "securecall")]
			Securecall,

			/// <summary>
			/// Enum Surveyinvite for "surveyinvite"
			/// </summary>
			[EnumMember(Value = "surveyinvite")]
			Surveyinvite,

			/// <summary>
			/// Enum Voice for "voice"
			/// </summary>
			[EnumMember(Value = "voice")]
			Voice,

			/// <summary>
			/// Enum Voicemail for "voicemail"
			/// </summary>
			[EnumMember(Value = "voicemail")]
			Voicemail,

			/// <summary>
			/// Enum Voicesurvey for "voicesurvey"
			/// </summary>
			[EnumMember(Value = "voicesurvey")]
			Voicesurvey,

			/// <summary>
			/// Enum Workflow for "workflow"
			/// </summary>
			[EnumMember(Value = "workflow")]
			Workflow,

			/// <summary>
			/// Enum Workitem for "workitem"
			/// </summary>
			[EnumMember(Value = "workitem")]
			Workitem
		}
		/// <summary>
		/// The Flow Type
		/// </summary>
		/// <value>The Flow Type</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="FlowSettingsResponse" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Type">The Flow Type.</param>
		/// <param name="ModifiedBy">User that last changed the log level setting..</param>
		/// <param name="ModifiedByClient">OAuth client that last changed the log level setting..</param>
		/// <param name="DateModified">The time this log level was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="LogLevelCharacteristics">The log level set for this flow.</param>
		public FlowSettingsResponse(string Name = null, TypeEnum? Type = null, UserReference ModifiedBy = null, DomainEntityRef ModifiedByClient = null, DateTime? DateModified = null, FlowLogLevel LogLevelCharacteristics = null)
		{
			this.Name = Name;
			this.Type = Type;
			this.ModifiedBy = ModifiedBy;
			this.ModifiedByClient = ModifiedByClient;
			this.DateModified = DateModified;
			this.LogLevelCharacteristics = LogLevelCharacteristics;

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
		/// User that last changed the log level setting.
		/// </summary>
		/// <value>User that last changed the log level setting.</value>
		[DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
		public UserReference ModifiedBy { get; set; }



		/// <summary>
		/// OAuth client that last changed the log level setting.
		/// </summary>
		/// <value>OAuth client that last changed the log level setting.</value>
		[DataMember(Name = "modifiedByClient", EmitDefaultValue = false)]
		public DomainEntityRef ModifiedByClient { get; set; }



		/// <summary>
		/// The time this log level was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The time this log level was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; set; }



		/// <summary>
		/// The log level set for this flow
		/// </summary>
		/// <value>The log level set for this flow</value>
		[DataMember(Name = "logLevelCharacteristics", EmitDefaultValue = false)]
		public FlowLogLevel LogLevelCharacteristics { get; set; }



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
			sb.Append("class FlowSettingsResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
			sb.Append("  ModifiedByClient: ").Append(ModifiedByClient).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  LogLevelCharacteristics: ").Append(LogLevelCharacteristics).Append("\n");
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
			return this.Equals(obj as FlowSettingsResponse);
		}

		/// <summary>
		/// Returns true if FlowSettingsResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of FlowSettingsResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FlowSettingsResponse other)
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
					this.ModifiedBy == other.ModifiedBy ||
					this.ModifiedBy != null &&
					this.ModifiedBy.Equals(other.ModifiedBy)
				) &&
				(
					this.ModifiedByClient == other.ModifiedByClient ||
					this.ModifiedByClient != null &&
					this.ModifiedByClient.Equals(other.ModifiedByClient)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.LogLevelCharacteristics == other.LogLevelCharacteristics ||
					this.LogLevelCharacteristics != null &&
					this.LogLevelCharacteristics.Equals(other.LogLevelCharacteristics)
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

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.ModifiedBy != null)
					hash = hash * 59 + this.ModifiedBy.GetHashCode();

				if (this.ModifiedByClient != null)
					hash = hash * 59 + this.ModifiedByClient.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.LogLevelCharacteristics != null)
					hash = hash * 59 + this.LogLevelCharacteristics.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
