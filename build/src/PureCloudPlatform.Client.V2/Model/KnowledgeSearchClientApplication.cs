using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// KnowledgeSearchClientApplication
	/// </summary>
	[DataContract]
	public partial class KnowledgeSearchClientApplication : IEquatable<KnowledgeSearchClientApplication>
	{
		/// <summary>
		/// Application type.
		/// </summary>
		/// <value>Application type.</value>
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
			/// Enum Assistant for "Assistant"
			/// </summary>
			[EnumMember(Value = "Assistant")]
			Assistant,

			/// <summary>
			/// Enum Botflow for "BotFlow"
			/// </summary>
			[EnumMember(Value = "BotFlow")]
			Botflow,

			/// <summary>
			/// Enum Messengerknowledgeapp for "MessengerKnowledgeApp"
			/// </summary>
			[EnumMember(Value = "MessengerKnowledgeApp")]
			Messengerknowledgeapp,

			/// <summary>
			/// Enum Smartadvisor for "SmartAdvisor"
			/// </summary>
			[EnumMember(Value = "SmartAdvisor")]
			Smartadvisor,

			/// <summary>
			/// Enum Supportcenter for "SupportCenter"
			/// </summary>
			[EnumMember(Value = "SupportCenter")]
			Supportcenter
		}
		/// <summary>
		/// Application type.
		/// </summary>
		/// <value>Application type.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeSearchClientApplication" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected KnowledgeSearchClientApplication() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeSearchClientApplication" /> class.
		/// </summary>
		/// <param name="Type">Application type. (required).</param>
		/// <param name="Deployment">Application details when type is MessengerKnowledgeApp or SupportCenter..</param>
		/// <param name="BotFlow">Application details when type is BotFlow..</param>
		/// <param name="Assistant">Application details when type is Assistant..</param>
		public KnowledgeSearchClientApplication(TypeEnum? Type = null, AddressableEntityRef Deployment = null, AddressableEntityRef BotFlow = null, AddressableEntityRef Assistant = null)
		{
			this.Type = Type;
			this.Deployment = Deployment;
			this.BotFlow = BotFlow;
			this.Assistant = Assistant;

		}





		/// <summary>
		/// Application details when type is MessengerKnowledgeApp or SupportCenter.
		/// </summary>
		/// <value>Application details when type is MessengerKnowledgeApp or SupportCenter.</value>
		[DataMember(Name = "deployment", EmitDefaultValue = false)]
		public AddressableEntityRef Deployment { get; set; }



		/// <summary>
		/// Application details when type is BotFlow.
		/// </summary>
		/// <value>Application details when type is BotFlow.</value>
		[DataMember(Name = "botFlow", EmitDefaultValue = false)]
		public AddressableEntityRef BotFlow { get; set; }



		/// <summary>
		/// Application details when type is Assistant.
		/// </summary>
		/// <value>Application details when type is Assistant.</value>
		[DataMember(Name = "assistant", EmitDefaultValue = false)]
		public AddressableEntityRef Assistant { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class KnowledgeSearchClientApplication {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Deployment: ").Append(Deployment).Append("\n");
			sb.Append("  BotFlow: ").Append(BotFlow).Append("\n");
			sb.Append("  Assistant: ").Append(Assistant).Append("\n");
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
			return this.Equals(obj as KnowledgeSearchClientApplication);
		}

		/// <summary>
		/// Returns true if KnowledgeSearchClientApplication instances are equal
		/// </summary>
		/// <param name="other">Instance of KnowledgeSearchClientApplication to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(KnowledgeSearchClientApplication other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Deployment == other.Deployment ||
					this.Deployment != null &&
					this.Deployment.Equals(other.Deployment)
				) &&
				(
					this.BotFlow == other.BotFlow ||
					this.BotFlow != null &&
					this.BotFlow.Equals(other.BotFlow)
				) &&
				(
					this.Assistant == other.Assistant ||
					this.Assistant != null &&
					this.Assistant.Equals(other.Assistant)
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
				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Deployment != null)
					hash = hash * 59 + this.Deployment.GetHashCode();

				if (this.BotFlow != null)
					hash = hash * 59 + this.BotFlow.GetHashCode();

				if (this.Assistant != null)
					hash = hash * 59 + this.Assistant.GetHashCode();

				return hash;
			}
		}
	}

}
