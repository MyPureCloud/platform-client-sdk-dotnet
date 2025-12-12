using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationChat
	/// </summary>
	[DataContract]
	public partial class ConversationChat : IEquatable<ConversationChat>
	{
		/// <summary>
		/// The connection state of this communication.
		/// </summary>
		/// <value>The connection state of this communication.</value>
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
		/// The initial connection state of this communication.
		/// </summary>
		/// <value>The initial connection state of this communication.</value>
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
		/// The direction of the chat
		/// </summary>
		/// <value>The direction of the chat</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum DirectionEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Inbound for "inbound"
			/// </summary>
			[EnumMember(Value = "inbound")]
			Inbound,

			/// <summary>
			/// Enum Outbound for "outbound"
			/// </summary>
			[EnumMember(Value = "outbound")]
			Outbound
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
			/// Enum Uncallable for "uncallable"
			/// </summary>
			[EnumMember(Value = "uncallable")]
			Uncallable,

			/// <summary>
			/// Enum Timeout for "timeout"
			/// </summary>
			[EnumMember(Value = "timeout")]
			Timeout
		}
		/// <summary>
		/// The connection state of this communication.
		/// </summary>
		/// <value>The connection state of this communication.</value>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public StateEnum? State { get; set; }
		/// <summary>
		/// The initial connection state of this communication.
		/// </summary>
		/// <value>The initial connection state of this communication.</value>
		[DataMember(Name = "initialState", EmitDefaultValue = false)]
		public InitialStateEnum? InitialState { get; set; }
		/// <summary>
		/// The direction of the chat
		/// </summary>
		/// <value>The direction of the chat</value>
		[DataMember(Name = "direction", EmitDefaultValue = false)]
		public DirectionEnum? Direction { get; set; }
		/// <summary>
		/// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
		/// </summary>
		/// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
		[DataMember(Name = "disconnectType", EmitDefaultValue = false)]
		public DisconnectTypeEnum? DisconnectType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationChat" /> class.
		/// </summary>
		/// <param name="State">The connection state of this communication..</param>
		/// <param name="InitialState">The initial connection state of this communication..</param>
		/// <param name="Id">A globally unique identifier for this communication..</param>
		/// <param name="RoomId">The room id for the chat..</param>
		/// <param name="RecordingId">A globally unique identifier for the recording associated with this chat..</param>
		/// <param name="Segments">The time line of the participant&#39;s chat, divided into activity segments..</param>
		/// <param name="Held">True if this call is held and the person on this side hears silence..</param>
		/// <param name="Direction">The direction of the chat.</param>
		/// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
		/// <param name="StartHoldTime">The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="StartAlertingTime">The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="Provider">The source provider for the email..</param>
		/// <param name="ScriptId">The UUID of the script to use..</param>
		/// <param name="PeerId">The id of the peer communication corresponding to a matching leg for this communication..</param>
		/// <param name="AvatarImageUrl">If available, the URI to the avatar image of this communication..</param>
		/// <param name="JourneyContext">A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context)..</param>
		/// <param name="Wrapup">Call wrap up or disposition data..</param>
		/// <param name="AfterCallWork">After-call work for the communication..</param>
		/// <param name="AfterCallWorkRequired">Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested..</param>
		/// <param name="QueueMediaSettings">Represents the queue settings for this media type..</param>
		public ConversationChat(StateEnum? State = null, InitialStateEnum? InitialState = null, string Id = null, string RoomId = null, string RecordingId = null, List<Segment> Segments = null, bool? Held = null, DirectionEnum? Direction = null, DisconnectTypeEnum? DisconnectType = null, DateTime? StartHoldTime = null, DateTime? StartAlertingTime = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, string Provider = null, string ScriptId = null, string PeerId = null, string AvatarImageUrl = null, JourneyContext JourneyContext = null, Wrapup Wrapup = null, AfterCallWork AfterCallWork = null, bool? AfterCallWorkRequired = null, ConversationQueueMediaSettings QueueMediaSettings = null)
		{
			this.State = State;
			this.InitialState = InitialState;
			this.Id = Id;
			this.RoomId = RoomId;
			this.RecordingId = RecordingId;
			this.Segments = Segments;
			this.Held = Held;
			this.Direction = Direction;
			this.DisconnectType = DisconnectType;
			this.StartHoldTime = StartHoldTime;
			this.StartAlertingTime = StartAlertingTime;
			this.ConnectedTime = ConnectedTime;
			this.DisconnectedTime = DisconnectedTime;
			this.Provider = Provider;
			this.ScriptId = ScriptId;
			this.PeerId = PeerId;
			this.AvatarImageUrl = AvatarImageUrl;
			this.JourneyContext = JourneyContext;
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
		/// The room id for the chat.
		/// </summary>
		/// <value>The room id for the chat.</value>
		[DataMember(Name = "roomId", EmitDefaultValue = false)]
		public string RoomId { get; set; }



		/// <summary>
		/// A globally unique identifier for the recording associated with this chat.
		/// </summary>
		/// <value>A globally unique identifier for the recording associated with this chat.</value>
		[DataMember(Name = "recordingId", EmitDefaultValue = false)]
		public string RecordingId { get; set; }



		/// <summary>
		/// The time line of the participant&#39;s chat, divided into activity segments.
		/// </summary>
		/// <value>The time line of the participant&#39;s chat, divided into activity segments.</value>
		[DataMember(Name = "segments", EmitDefaultValue = false)]
		public List<Segment> Segments { get; set; }



		/// <summary>
		/// True if this call is held and the person on this side hears silence.
		/// </summary>
		/// <value>True if this call is held and the person on this side hears silence.</value>
		[DataMember(Name = "held", EmitDefaultValue = false)]
		public bool? Held { get; set; }







		/// <summary>
		/// The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "startHoldTime", EmitDefaultValue = false)]
		public DateTime? StartHoldTime { get; set; }



		/// <summary>
		/// The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "startAlertingTime", EmitDefaultValue = false)]
		public DateTime? StartAlertingTime { get; set; }



		/// <summary>
		/// The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "connectedTime", EmitDefaultValue = false)]
		public DateTime? ConnectedTime { get; set; }



		/// <summary>
		/// The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "disconnectedTime", EmitDefaultValue = false)]
		public DateTime? DisconnectedTime { get; set; }



		/// <summary>
		/// The source provider for the email.
		/// </summary>
		/// <value>The source provider for the email.</value>
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
		/// If available, the URI to the avatar image of this communication.
		/// </summary>
		/// <value>If available, the URI to the avatar image of this communication.</value>
		[DataMember(Name = "avatarImageUrl", EmitDefaultValue = false)]
		public string AvatarImageUrl { get; set; }



		/// <summary>
		/// A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context).
		/// </summary>
		/// <value>A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context).</value>
		[DataMember(Name = "journeyContext", EmitDefaultValue = false)]
		public JourneyContext JourneyContext { get; set; }



		/// <summary>
		/// Call wrap up or disposition data.
		/// </summary>
		/// <value>Call wrap up or disposition data.</value>
		[DataMember(Name = "wrapup", EmitDefaultValue = false)]
		public Wrapup Wrapup { get; set; }



		/// <summary>
		/// After-call work for the communication.
		/// </summary>
		/// <value>After-call work for the communication.</value>
		[DataMember(Name = "afterCallWork", EmitDefaultValue = false)]
		public AfterCallWork AfterCallWork { get; set; }



		/// <summary>
		/// Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested.
		/// </summary>
		/// <value>Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested.</value>
		[DataMember(Name = "afterCallWorkRequired", EmitDefaultValue = false)]
		public bool? AfterCallWorkRequired { get; set; }



		/// <summary>
		/// Represents the queue settings for this media type.
		/// </summary>
		/// <value>Represents the queue settings for this media type.</value>
		[DataMember(Name = "queueMediaSettings", EmitDefaultValue = false)]
		public ConversationQueueMediaSettings QueueMediaSettings { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationChat {\n");

			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  InitialState: ").Append(InitialState).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  RoomId: ").Append(RoomId).Append("\n");
			sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
			sb.Append("  Segments: ").Append(Segments).Append("\n");
			sb.Append("  Held: ").Append(Held).Append("\n");
			sb.Append("  Direction: ").Append(Direction).Append("\n");
			sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
			sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
			sb.Append("  StartAlertingTime: ").Append(StartAlertingTime).Append("\n");
			sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
			sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
			sb.Append("  Provider: ").Append(Provider).Append("\n");
			sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
			sb.Append("  PeerId: ").Append(PeerId).Append("\n");
			sb.Append("  AvatarImageUrl: ").Append(AvatarImageUrl).Append("\n");
			sb.Append("  JourneyContext: ").Append(JourneyContext).Append("\n");
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
			return this.Equals(obj as ConversationChat);
		}

		/// <summary>
		/// Returns true if ConversationChat instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationChat to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationChat other)
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
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.RoomId == other.RoomId ||
					this.RoomId != null &&
					this.RoomId.Equals(other.RoomId)
				) &&
				(
					this.RecordingId == other.RecordingId ||
					this.RecordingId != null &&
					this.RecordingId.Equals(other.RecordingId)
				) &&
				(
					this.Segments == other.Segments ||
					this.Segments != null &&
					this.Segments.SequenceEqual(other.Segments)
				) &&
				(
					this.Held == other.Held ||
					this.Held != null &&
					this.Held.Equals(other.Held)
				) &&
				(
					this.Direction == other.Direction ||
					this.Direction != null &&
					this.Direction.Equals(other.Direction)
				) &&
				(
					this.DisconnectType == other.DisconnectType ||
					this.DisconnectType != null &&
					this.DisconnectType.Equals(other.DisconnectType)
				) &&
				(
					this.StartHoldTime == other.StartHoldTime ||
					this.StartHoldTime != null &&
					this.StartHoldTime.Equals(other.StartHoldTime)
				) &&
				(
					this.StartAlertingTime == other.StartAlertingTime ||
					this.StartAlertingTime != null &&
					this.StartAlertingTime.Equals(other.StartAlertingTime)
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
					this.AvatarImageUrl == other.AvatarImageUrl ||
					this.AvatarImageUrl != null &&
					this.AvatarImageUrl.Equals(other.AvatarImageUrl)
				) &&
				(
					this.JourneyContext == other.JourneyContext ||
					this.JourneyContext != null &&
					this.JourneyContext.Equals(other.JourneyContext)
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

				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.RoomId != null)
					hash = hash * 59 + this.RoomId.GetHashCode();

				if (this.RecordingId != null)
					hash = hash * 59 + this.RecordingId.GetHashCode();

				if (this.Segments != null)
					hash = hash * 59 + this.Segments.GetHashCode();

				if (this.Held != null)
					hash = hash * 59 + this.Held.GetHashCode();

				if (this.Direction != null)
					hash = hash * 59 + this.Direction.GetHashCode();

				if (this.DisconnectType != null)
					hash = hash * 59 + this.DisconnectType.GetHashCode();

				if (this.StartHoldTime != null)
					hash = hash * 59 + this.StartHoldTime.GetHashCode();

				if (this.StartAlertingTime != null)
					hash = hash * 59 + this.StartAlertingTime.GetHashCode();

				if (this.ConnectedTime != null)
					hash = hash * 59 + this.ConnectedTime.GetHashCode();

				if (this.DisconnectedTime != null)
					hash = hash * 59 + this.DisconnectedTime.GetHashCode();

				if (this.Provider != null)
					hash = hash * 59 + this.Provider.GetHashCode();

				if (this.ScriptId != null)
					hash = hash * 59 + this.ScriptId.GetHashCode();

				if (this.PeerId != null)
					hash = hash * 59 + this.PeerId.GetHashCode();

				if (this.AvatarImageUrl != null)
					hash = hash * 59 + this.AvatarImageUrl.GetHashCode();

				if (this.JourneyContext != null)
					hash = hash * 59 + this.JourneyContext.GetHashCode();

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
