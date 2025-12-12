using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// QueueConversationSocialExpressionEventTopicCobrowse
	/// </summary>
	[DataContract]
	public partial class QueueConversationSocialExpressionEventTopicCobrowse : IEquatable<QueueConversationSocialExpressionEventTopicCobrowse>
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
			/// Enum Dialing for "dialing"
			/// </summary>
			[EnumMember(Value = "dialing")]
			Dialing,

			/// <summary>
			/// Enum Contacting for "contacting"
			/// </summary>
			[EnumMember(Value = "contacting")]
			Contacting,

			/// <summary>
			/// Enum Offering for "offering"
			/// </summary>
			[EnumMember(Value = "offering")]
			Offering,

			/// <summary>
			/// Enum Connected for "connected"
			/// </summary>
			[EnumMember(Value = "connected")]
			Connected,

			/// <summary>
			/// Enum Disconnected for "disconnected"
			/// </summary>
			[EnumMember(Value = "disconnected")]
			Disconnected,

			/// <summary>
			/// Enum Terminated for "terminated"
			/// </summary>
			[EnumMember(Value = "terminated")]
			Terminated,

			/// <summary>
			/// Enum None for "none"
			/// </summary>
			[EnumMember(Value = "none")]
			None
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
			/// Enum Dialing for "dialing"
			/// </summary>
			[EnumMember(Value = "dialing")]
			Dialing,

			/// <summary>
			/// Enum Contacting for "contacting"
			/// </summary>
			[EnumMember(Value = "contacting")]
			Contacting,

			/// <summary>
			/// Enum Offering for "offering"
			/// </summary>
			[EnumMember(Value = "offering")]
			Offering,

			/// <summary>
			/// Enum Connected for "connected"
			/// </summary>
			[EnumMember(Value = "connected")]
			Connected,

			/// <summary>
			/// Enum Disconnected for "disconnected"
			/// </summary>
			[EnumMember(Value = "disconnected")]
			Disconnected,

			/// <summary>
			/// Enum Terminated for "terminated"
			/// </summary>
			[EnumMember(Value = "terminated")]
			Terminated,

			/// <summary>
			/// Enum None for "none"
			/// </summary>
			[EnumMember(Value = "none")]
			None
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
			/// Enum Endpoint for "endpoint"
			/// </summary>
			[EnumMember(Value = "endpoint")]
			Endpoint,

			/// <summary>
			/// Enum Endpointdnd for "endpoint.dnd"
			/// </summary>
			[EnumMember(Value = "endpoint.dnd")]
			Endpointdnd,

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
			/// Enum Timeout for "timeout"
			/// </summary>
			[EnumMember(Value = "timeout")]
			Timeout,

			/// <summary>
			/// Enum Transfer for "transfer"
			/// </summary>
			[EnumMember(Value = "transfer")]
			Transfer,

			/// <summary>
			/// Enum Transferconference for "transfer.conference"
			/// </summary>
			[EnumMember(Value = "transfer.conference")]
			Transferconference,

			/// <summary>
			/// Enum Transferconsult for "transfer.consult"
			/// </summary>
			[EnumMember(Value = "transfer.consult")]
			Transferconsult,

			/// <summary>
			/// Enum Transferforward for "transfer.forward"
			/// </summary>
			[EnumMember(Value = "transfer.forward")]
			Transferforward,

			/// <summary>
			/// Enum Transfernoanswer for "transfer.noanswer"
			/// </summary>
			[EnumMember(Value = "transfer.noanswer")]
			Transfernoanswer,

			/// <summary>
			/// Enum Transfernotavailable for "transfer.notavailable"
			/// </summary>
			[EnumMember(Value = "transfer.notavailable")]
			Transfernotavailable,

			/// <summary>
			/// Enum Transferdnd for "transfer.dnd"
			/// </summary>
			[EnumMember(Value = "transfer.dnd")]
			Transferdnd,

			/// <summary>
			/// Enum Transportfailure for "transport.failure"
			/// </summary>
			[EnumMember(Value = "transport.failure")]
			Transportfailure,

			/// <summary>
			/// Enum Error for "error"
			/// </summary>
			[EnumMember(Value = "error")]
			Error,

			/// <summary>
			/// Enum Peer for "peer"
			/// </summary>
			[EnumMember(Value = "peer")]
			Peer,

			/// <summary>
			/// Enum Other for "other"
			/// </summary>
			[EnumMember(Value = "other")]
			Other,

			/// <summary>
			/// Enum Spam for "spam"
			/// </summary>
			[EnumMember(Value = "spam")]
			Spam,

			/// <summary>
			/// Enum Uncallable for "uncallable"
			/// </summary>
			[EnumMember(Value = "uncallable")]
			Uncallable
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
		/// Initializes a new instance of the <see cref="QueueConversationSocialExpressionEventTopicCobrowse" /> class.
		/// </summary>
		/// <param name="State">State.</param>
		/// <param name="InitialState">InitialState.</param>
		/// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
		/// <param name="Id">A globally unique identifier for this communication..</param>
		/// <param name="Self">Address and name data for a call endpoint..</param>
		/// <param name="RoomId">The room id for the chat..</param>
		/// <param name="CobrowseSessionId">The co-browse session ID..</param>
		/// <param name="CobrowseRole">This value identifies the role of the co-browse client within the co-browse session (a client is a sharer or a viewer)..</param>
		/// <param name="Controlling">ID of co-browse participants for which this client has been granted control (list is empty if this client cannot control any shared pages)..</param>
		/// <param name="ViewerUrl">The URL that can be used to open co-browse session in web browser..</param>
		/// <param name="Provider">The source provider of the co-browse communication..</param>
		/// <param name="ScriptId">The UUID of the script to use..</param>
		/// <param name="PeerId">The id of the peer communication corresponding to a matching leg for this communication..</param>
		/// <param name="ProviderEventTime">The time when the provider event which triggered this conversation update happened in the corrected provider clock (milliseconds since 1970-01-01 00:00:00 UTC)..</param>
		/// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock..</param>
		/// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock..</param>
		/// <param name="Wrapup">Call wrap up or disposition data..</param>
		/// <param name="AfterCallWork">A communication&#39;s after-call work data..</param>
		/// <param name="AfterCallWorkRequired">Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested..</param>
		/// <param name="QueueMediaSettings">Represents the queue setting for this media..</param>
		public QueueConversationSocialExpressionEventTopicCobrowse(StateEnum? State = null, InitialStateEnum? InitialState = null, DisconnectTypeEnum? DisconnectType = null, string Id = null, QueueConversationSocialExpressionEventTopicAddress Self = null, string RoomId = null, string CobrowseSessionId = null, string CobrowseRole = null, List<string> Controlling = null, string ViewerUrl = null, string Provider = null, string ScriptId = null, string PeerId = null, DateTime? ProviderEventTime = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, QueueConversationSocialExpressionEventTopicWrapup Wrapup = null, QueueConversationSocialExpressionEventTopicAfterCallWork AfterCallWork = null, bool? AfterCallWorkRequired = null, QueueConversationSocialExpressionEventTopicQueueMediaSettings QueueMediaSettings = null)
		{
			this.State = State;
			this.InitialState = InitialState;
			this.DisconnectType = DisconnectType;
			this.Id = Id;
			this.Self = Self;
			this.RoomId = RoomId;
			this.CobrowseSessionId = CobrowseSessionId;
			this.CobrowseRole = CobrowseRole;
			this.Controlling = Controlling;
			this.ViewerUrl = ViewerUrl;
			this.Provider = Provider;
			this.ScriptId = ScriptId;
			this.PeerId = PeerId;
			this.ProviderEventTime = ProviderEventTime;
			this.ConnectedTime = ConnectedTime;
			this.DisconnectedTime = DisconnectedTime;
			this.Wrapup = Wrapup;
			this.AfterCallWork = AfterCallWork;
			this.AfterCallWorkRequired = AfterCallWorkRequired;
			this.QueueMediaSettings = QueueMediaSettings;

		}









		/// <summary>
		/// A globally unique identifier for this communication.
		/// </summary>
		/// <value>A globally unique identifier for this communication.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Address and name data for a call endpoint.
		/// </summary>
		/// <value>Address and name data for a call endpoint.</value>
		[DataMember(Name = "self", EmitDefaultValue = false)]
		public QueueConversationSocialExpressionEventTopicAddress Self { get; set; }



		/// <summary>
		/// The room id for the chat.
		/// </summary>
		/// <value>The room id for the chat.</value>
		[DataMember(Name = "roomId", EmitDefaultValue = false)]
		public string RoomId { get; set; }



		/// <summary>
		/// The co-browse session ID.
		/// </summary>
		/// <value>The co-browse session ID.</value>
		[DataMember(Name = "cobrowseSessionId", EmitDefaultValue = false)]
		public string CobrowseSessionId { get; set; }



		/// <summary>
		/// This value identifies the role of the co-browse client within the co-browse session (a client is a sharer or a viewer).
		/// </summary>
		/// <value>This value identifies the role of the co-browse client within the co-browse session (a client is a sharer or a viewer).</value>
		[DataMember(Name = "cobrowseRole", EmitDefaultValue = false)]
		public string CobrowseRole { get; set; }



		/// <summary>
		/// ID of co-browse participants for which this client has been granted control (list is empty if this client cannot control any shared pages).
		/// </summary>
		/// <value>ID of co-browse participants for which this client has been granted control (list is empty if this client cannot control any shared pages).</value>
		[DataMember(Name = "controlling", EmitDefaultValue = false)]
		public List<string> Controlling { get; set; }



		/// <summary>
		/// The URL that can be used to open co-browse session in web browser.
		/// </summary>
		/// <value>The URL that can be used to open co-browse session in web browser.</value>
		[DataMember(Name = "viewerUrl", EmitDefaultValue = false)]
		public string ViewerUrl { get; set; }



		/// <summary>
		/// The source provider of the co-browse communication.
		/// </summary>
		/// <value>The source provider of the co-browse communication.</value>
		[DataMember(Name = "provider", EmitDefaultValue = false)]
		public string Provider { get; set; }



		/// <summary>
		/// The UUID of the script to use.
		/// </summary>
		/// <value>The UUID of the script to use.</value>
		[DataMember(Name = "scriptId", EmitDefaultValue = false)]
		public string ScriptId { get; set; }



		/// <summary>
		/// The id of the peer communication corresponding to a matching leg for this communication.
		/// </summary>
		/// <value>The id of the peer communication corresponding to a matching leg for this communication.</value>
		[DataMember(Name = "peerId", EmitDefaultValue = false)]
		public string PeerId { get; set; }



		/// <summary>
		/// The time when the provider event which triggered this conversation update happened in the corrected provider clock (milliseconds since 1970-01-01 00:00:00 UTC).
		/// </summary>
		/// <value>The time when the provider event which triggered this conversation update happened in the corrected provider clock (milliseconds since 1970-01-01 00:00:00 UTC).</value>
		[DataMember(Name = "providerEventTime", EmitDefaultValue = false)]
		public DateTime? ProviderEventTime { get; set; }



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
		/// Call wrap up or disposition data.
		/// </summary>
		/// <value>Call wrap up or disposition data.</value>
		[DataMember(Name = "wrapup", EmitDefaultValue = false)]
		public QueueConversationSocialExpressionEventTopicWrapup Wrapup { get; set; }



		/// <summary>
		/// A communication&#39;s after-call work data.
		/// </summary>
		/// <value>A communication&#39;s after-call work data.</value>
		[DataMember(Name = "afterCallWork", EmitDefaultValue = false)]
		public QueueConversationSocialExpressionEventTopicAfterCallWork AfterCallWork { get; set; }



		/// <summary>
		/// Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.
		/// </summary>
		/// <value>Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.</value>
		[DataMember(Name = "afterCallWorkRequired", EmitDefaultValue = false)]
		public bool? AfterCallWorkRequired { get; set; }



		/// <summary>
		/// Represents the queue setting for this media.
		/// </summary>
		/// <value>Represents the queue setting for this media.</value>
		[DataMember(Name = "queueMediaSettings", EmitDefaultValue = false)]
		public QueueConversationSocialExpressionEventTopicQueueMediaSettings QueueMediaSettings { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class QueueConversationSocialExpressionEventTopicCobrowse {\n");

			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  InitialState: ").Append(InitialState).Append("\n");
			sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Self: ").Append(Self).Append("\n");
			sb.Append("  RoomId: ").Append(RoomId).Append("\n");
			sb.Append("  CobrowseSessionId: ").Append(CobrowseSessionId).Append("\n");
			sb.Append("  CobrowseRole: ").Append(CobrowseRole).Append("\n");
			sb.Append("  Controlling: ").Append(Controlling).Append("\n");
			sb.Append("  ViewerUrl: ").Append(ViewerUrl).Append("\n");
			sb.Append("  Provider: ").Append(Provider).Append("\n");
			sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
			sb.Append("  PeerId: ").Append(PeerId).Append("\n");
			sb.Append("  ProviderEventTime: ").Append(ProviderEventTime).Append("\n");
			sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
			sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
			sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
			sb.Append("  AfterCallWork: ").Append(AfterCallWork).Append("\n");
			sb.Append("  AfterCallWorkRequired: ").Append(AfterCallWorkRequired).Append("\n");
			sb.Append("  QueueMediaSettings: ").Append(QueueMediaSettings).Append("\n");
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
			return this.Equals(obj as QueueConversationSocialExpressionEventTopicCobrowse);
		}

		/// <summary>
		/// Returns true if QueueConversationSocialExpressionEventTopicCobrowse instances are equal
		/// </summary>
		/// <param name="other">Instance of QueueConversationSocialExpressionEventTopicCobrowse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(QueueConversationSocialExpressionEventTopicCobrowse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
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
					this.DisconnectType == other.DisconnectType ||
					this.DisconnectType != null &&
					this.DisconnectType.Equals(other.DisconnectType)
				) &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Self == other.Self ||
					this.Self != null &&
					this.Self.Equals(other.Self)
				) &&
				(
					this.RoomId == other.RoomId ||
					this.RoomId != null &&
					this.RoomId.Equals(other.RoomId)
				) &&
				(
					this.CobrowseSessionId == other.CobrowseSessionId ||
					this.CobrowseSessionId != null &&
					this.CobrowseSessionId.Equals(other.CobrowseSessionId)
				) &&
				(
					this.CobrowseRole == other.CobrowseRole ||
					this.CobrowseRole != null &&
					this.CobrowseRole.Equals(other.CobrowseRole)
				) &&
				(
					this.Controlling == other.Controlling ||
					this.Controlling != null &&
					this.Controlling.SequenceEqual(other.Controlling)
				) &&
				(
					this.ViewerUrl == other.ViewerUrl ||
					this.ViewerUrl != null &&
					this.ViewerUrl.Equals(other.ViewerUrl)
				) &&
				(
					this.Provider == other.Provider ||
					this.Provider != null &&
					this.Provider.Equals(other.Provider)
				) &&
				(
					this.ScriptId == other.ScriptId ||
					this.ScriptId != null &&
					this.ScriptId.Equals(other.ScriptId)
				) &&
				(
					this.PeerId == other.PeerId ||
					this.PeerId != null &&
					this.PeerId.Equals(other.PeerId)
				) &&
				(
					this.ProviderEventTime == other.ProviderEventTime ||
					this.ProviderEventTime != null &&
					this.ProviderEventTime.Equals(other.ProviderEventTime)
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
					this.Wrapup == other.Wrapup ||
					this.Wrapup != null &&
					this.Wrapup.Equals(other.Wrapup)
				) &&
				(
					this.AfterCallWork == other.AfterCallWork ||
					this.AfterCallWork != null &&
					this.AfterCallWork.Equals(other.AfterCallWork)
				) &&
				(
					this.AfterCallWorkRequired == other.AfterCallWorkRequired ||
					this.AfterCallWorkRequired != null &&
					this.AfterCallWorkRequired.Equals(other.AfterCallWorkRequired)
				) &&
				(
					this.QueueMediaSettings == other.QueueMediaSettings ||
					this.QueueMediaSettings != null &&
					this.QueueMediaSettings.Equals(other.QueueMediaSettings)
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
				if (this.State != null)
					hash = hash * 59 + this.State.GetHashCode();

				if (this.InitialState != null)
					hash = hash * 59 + this.InitialState.GetHashCode();

				if (this.DisconnectType != null)
					hash = hash * 59 + this.DisconnectType.GetHashCode();

				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Self != null)
					hash = hash * 59 + this.Self.GetHashCode();

				if (this.RoomId != null)
					hash = hash * 59 + this.RoomId.GetHashCode();

				if (this.CobrowseSessionId != null)
					hash = hash * 59 + this.CobrowseSessionId.GetHashCode();

				if (this.CobrowseRole != null)
					hash = hash * 59 + this.CobrowseRole.GetHashCode();

				if (this.Controlling != null)
					hash = hash * 59 + this.Controlling.GetHashCode();

				if (this.ViewerUrl != null)
					hash = hash * 59 + this.ViewerUrl.GetHashCode();

				if (this.Provider != null)
					hash = hash * 59 + this.Provider.GetHashCode();

				if (this.ScriptId != null)
					hash = hash * 59 + this.ScriptId.GetHashCode();

				if (this.PeerId != null)
					hash = hash * 59 + this.PeerId.GetHashCode();

				if (this.ProviderEventTime != null)
					hash = hash * 59 + this.ProviderEventTime.GetHashCode();

				if (this.ConnectedTime != null)
					hash = hash * 59 + this.ConnectedTime.GetHashCode();

				if (this.DisconnectedTime != null)
					hash = hash * 59 + this.DisconnectedTime.GetHashCode();

				if (this.Wrapup != null)
					hash = hash * 59 + this.Wrapup.GetHashCode();

				if (this.AfterCallWork != null)
					hash = hash * 59 + this.AfterCallWork.GetHashCode();

				if (this.AfterCallWorkRequired != null)
					hash = hash * 59 + this.AfterCallWorkRequired.GetHashCode();

				if (this.QueueMediaSettings != null)
					hash = hash * 59 + this.QueueMediaSettings.GetHashCode();

				return hash;
			}
		}
	}

}
