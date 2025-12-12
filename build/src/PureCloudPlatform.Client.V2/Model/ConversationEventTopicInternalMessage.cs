using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationEventTopicInternalMessage
	/// </summary>
	[DataContract]
	public partial class ConversationEventTopicInternalMessage : IEquatable<ConversationEventTopicInternalMessage>
	{
		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StateEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Alerting for "alerting"
			/// </summary>
			[EnumMember(Value = "alerting")]
			Alerting,

			/// <summary>
			/// Enum Connected for "connected"
			/// </summary>
			[EnumMember(Value = "connected")]
			Connected,

			/// <summary>
			/// Enum Disconnected for "disconnected"
			/// </summary>
			[EnumMember(Value = "disconnected")]
			Disconnected
		}
		/// <summary>
		/// Gets or Sets InitialState
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum InitialStateEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Alerting for "alerting"
			/// </summary>
			[EnumMember(Value = "alerting")]
			Alerting,

			/// <summary>
			/// Enum Connected for "connected"
			/// </summary>
			[EnumMember(Value = "connected")]
			Connected,

			/// <summary>
			/// Enum Disconnected for "disconnected"
			/// </summary>
			[EnumMember(Value = "disconnected")]
			Disconnected
		}
		/// <summary>
		/// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
		/// </summary>
		/// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum DisconnectTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Client for "client"
			/// </summary>
			[EnumMember(Value = "client")]
			Client,

			/// <summary>
			/// Enum System for "system"
			/// </summary>
			[EnumMember(Value = "system")]
			System,

			/// <summary>
			/// Enum Peer for "peer"
			/// </summary>
			[EnumMember(Value = "peer")]
			Peer,

			/// <summary>
			/// Enum Transfer for "transfer"
			/// </summary>
			[EnumMember(Value = "transfer")]
			Transfer
		}
		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public StateEnum? State { get; set; }
		/// <summary>
		/// Gets or Sets InitialState
		/// </summary>
		[DataMember(Name = "initialState", EmitDefaultValue = false)]
		public InitialStateEnum? InitialState { get; set; }
		/// <summary>
		/// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
		/// </summary>
		/// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
		[DataMember(Name = "disconnectType", EmitDefaultValue = false)]
		public DisconnectTypeEnum? DisconnectType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationEventTopicInternalMessage" /> class.
		/// </summary>
		/// <param name="Id">A globally unique identifier for this communication..</param>
		/// <param name="State">State.</param>
		/// <param name="InitialState">InitialState.</param>
		/// <param name="Provider">The source provider of the message..</param>
		/// <param name="PeerId">The id of the peer communication corresponding to a matching leg for this communication..</param>
		/// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
		/// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock..</param>
		/// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock..</param>
		/// <param name="TargetUserId">The user ID for the participant on receiving side of the internal message conversation..</param>
		/// <param name="SourceUserId">The user ID for the participant on sending side of the internal message conversation..</param>
		/// <param name="ToAddress">Address and name data for a call endpoint..</param>
		/// <param name="FromAddress">Address and name data for a call endpoint..</param>
		/// <param name="Messages">The messages sent on this communication channel..</param>
		public ConversationEventTopicInternalMessage(string Id = null, StateEnum? State = null, InitialStateEnum? InitialState = null, string Provider = null, string PeerId = null, DisconnectTypeEnum? DisconnectType = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, string TargetUserId = null, string SourceUserId = null, ConversationEventTopicAddress ToAddress = null, ConversationEventTopicAddress FromAddress = null, List<ConversationEventTopicInternalMessageDetails> Messages = null)
		{
			this.Id = Id;
			this.State = State;
			this.InitialState = InitialState;
			this.Provider = Provider;
			this.PeerId = PeerId;
			this.DisconnectType = DisconnectType;
			this.ConnectedTime = ConnectedTime;
			this.DisconnectedTime = DisconnectedTime;
			this.TargetUserId = TargetUserId;
			this.SourceUserId = SourceUserId;
			this.ToAddress = ToAddress;
			this.FromAddress = FromAddress;
			this.Messages = Messages;

		}



		/// <summary>
		/// A globally unique identifier for this communication.
		/// </summary>
		/// <value>A globally unique identifier for this communication.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }







		/// <summary>
		/// The source provider of the message.
		/// </summary>
		/// <value>The source provider of the message.</value>
		[DataMember(Name = "provider", EmitDefaultValue = false)]
		public string Provider { get; set; }



		/// <summary>
		/// The id of the peer communication corresponding to a matching leg for this communication.
		/// </summary>
		/// <value>The id of the peer communication corresponding to a matching leg for this communication.</value>
		[DataMember(Name = "peerId", EmitDefaultValue = false)]
		public string PeerId { get; set; }





		/// <summary>
		/// The timestamp when this communication was connected in the cloud clock.
		/// </summary>
		/// <value>The timestamp when this communication was connected in the cloud clock.</value>
		[DataMember(Name = "connectedTime", EmitDefaultValue = false)]
		public DateTime? ConnectedTime { get; set; }



		/// <summary>
		/// The timestamp when this communication disconnected from the conversation in the provider clock.
		/// </summary>
		/// <value>The timestamp when this communication disconnected from the conversation in the provider clock.</value>
		[DataMember(Name = "disconnectedTime", EmitDefaultValue = false)]
		public DateTime? DisconnectedTime { get; set; }



		/// <summary>
		/// The user ID for the participant on receiving side of the internal message conversation.
		/// </summary>
		/// <value>The user ID for the participant on receiving side of the internal message conversation.</value>
		[DataMember(Name = "targetUserId", EmitDefaultValue = false)]
		public string TargetUserId { get; set; }



		/// <summary>
		/// The user ID for the participant on sending side of the internal message conversation.
		/// </summary>
		/// <value>The user ID for the participant on sending side of the internal message conversation.</value>
		[DataMember(Name = "sourceUserId", EmitDefaultValue = false)]
		public string SourceUserId { get; set; }



		/// <summary>
		/// Address and name data for a call endpoint.
		/// </summary>
		/// <value>Address and name data for a call endpoint.</value>
		[DataMember(Name = "toAddress", EmitDefaultValue = false)]
		public ConversationEventTopicAddress ToAddress { get; set; }



		/// <summary>
		/// Address and name data for a call endpoint.
		/// </summary>
		/// <value>Address and name data for a call endpoint.</value>
		[DataMember(Name = "fromAddress", EmitDefaultValue = false)]
		public ConversationEventTopicAddress FromAddress { get; set; }



		/// <summary>
		/// The messages sent on this communication channel.
		/// </summary>
		/// <value>The messages sent on this communication channel.</value>
		[DataMember(Name = "messages", EmitDefaultValue = false)]
		public List<ConversationEventTopicInternalMessageDetails> Messages { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationEventTopicInternalMessage {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  InitialState: ").Append(InitialState).Append("\n");
			sb.Append("  Provider: ").Append(Provider).Append("\n");
			sb.Append("  PeerId: ").Append(PeerId).Append("\n");
			sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
			sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
			sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
			sb.Append("  TargetUserId: ").Append(TargetUserId).Append("\n");
			sb.Append("  SourceUserId: ").Append(SourceUserId).Append("\n");
			sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
			sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
			sb.Append("  Messages: ").Append(Messages).Append("\n");
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
			return this.Equals(obj as ConversationEventTopicInternalMessage);
		}

		/// <summary>
		/// Returns true if ConversationEventTopicInternalMessage instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationEventTopicInternalMessage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationEventTopicInternalMessage other)
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
					this.State == other.State ||
					this.State != null &&
					this.State.Equals(other.State)
				) &&
				(
					this.InitialState == other.InitialState ||
					this.InitialState != null &&
					this.InitialState.Equals(other.InitialState)
				) &&
				(
					this.Provider == other.Provider ||
					this.Provider != null &&
					this.Provider.Equals(other.Provider)
				) &&
				(
					this.PeerId == other.PeerId ||
					this.PeerId != null &&
					this.PeerId.Equals(other.PeerId)
				) &&
				(
					this.DisconnectType == other.DisconnectType ||
					this.DisconnectType != null &&
					this.DisconnectType.Equals(other.DisconnectType)
				) &&
				(
					this.ConnectedTime == other.ConnectedTime ||
					this.ConnectedTime != null &&
					this.ConnectedTime.Equals(other.ConnectedTime)
				) &&
				(
					this.DisconnectedTime == other.DisconnectedTime ||
					this.DisconnectedTime != null &&
					this.DisconnectedTime.Equals(other.DisconnectedTime)
				) &&
				(
					this.TargetUserId == other.TargetUserId ||
					this.TargetUserId != null &&
					this.TargetUserId.Equals(other.TargetUserId)
				) &&
				(
					this.SourceUserId == other.SourceUserId ||
					this.SourceUserId != null &&
					this.SourceUserId.Equals(other.SourceUserId)
				) &&
				(
					this.ToAddress == other.ToAddress ||
					this.ToAddress != null &&
					this.ToAddress.Equals(other.ToAddress)
				) &&
				(
					this.FromAddress == other.FromAddress ||
					this.FromAddress != null &&
					this.FromAddress.Equals(other.FromAddress)
				) &&
				(
					this.Messages == other.Messages ||
					this.Messages != null &&
					this.Messages.SequenceEqual(other.Messages)
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

				if (this.State != null)
					hash = hash * 59 + this.State.GetHashCode();

				if (this.InitialState != null)
					hash = hash * 59 + this.InitialState.GetHashCode();

				if (this.Provider != null)
					hash = hash * 59 + this.Provider.GetHashCode();

				if (this.PeerId != null)
					hash = hash * 59 + this.PeerId.GetHashCode();

				if (this.DisconnectType != null)
					hash = hash * 59 + this.DisconnectType.GetHashCode();

				if (this.ConnectedTime != null)
					hash = hash * 59 + this.ConnectedTime.GetHashCode();

				if (this.DisconnectedTime != null)
					hash = hash * 59 + this.DisconnectedTime.GetHashCode();

				if (this.TargetUserId != null)
					hash = hash * 59 + this.TargetUserId.GetHashCode();

				if (this.SourceUserId != null)
					hash = hash * 59 + this.SourceUserId.GetHashCode();

				if (this.ToAddress != null)
					hash = hash * 59 + this.ToAddress.GetHashCode();

				if (this.FromAddress != null)
					hash = hash * 59 + this.FromAddress.GetHashCode();

				if (this.Messages != null)
					hash = hash * 59 + this.Messages.GetHashCode();

				return hash;
			}
		}
	}

}
