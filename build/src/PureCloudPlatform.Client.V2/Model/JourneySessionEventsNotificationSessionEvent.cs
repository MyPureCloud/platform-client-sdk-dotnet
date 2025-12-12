using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// JourneySessionEventsNotificationSessionEvent
	/// </summary>
	[DataContract]
	public partial class JourneySessionEventsNotificationSessionEvent : IEquatable<JourneySessionEventsNotificationSessionEvent>
	{
		/// <summary>
		/// Gets or Sets OriginatingDirection
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum OriginatingDirectionEnum
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
			/// Enum Inbound for "Inbound"
			/// </summary>
			[EnumMember(Value = "Inbound")]
			Inbound,

			/// <summary>
			/// Enum Outbound for "Outbound"
			/// </summary>
			[EnumMember(Value = "Outbound")]
			Outbound
		}
		/// <summary>
		/// Gets or Sets LastUserDisconnectType
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum LastUserDisconnectTypeEnum
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
			/// Enum Endpoint for "Endpoint"
			/// </summary>
			[EnumMember(Value = "Endpoint")]
			Endpoint,

			/// <summary>
			/// Enum Client for "Client"
			/// </summary>
			[EnumMember(Value = "Client")]
			Client,

			/// <summary>
			/// Enum System for "System"
			/// </summary>
			[EnumMember(Value = "System")]
			System,

			/// <summary>
			/// Enum Transfer for "Transfer"
			/// </summary>
			[EnumMember(Value = "Transfer")]
			Transfer,

			/// <summary>
			/// Enum Error for "Error"
			/// </summary>
			[EnumMember(Value = "Error")]
			Error,

			/// <summary>
			/// Enum Peer for "Peer"
			/// </summary>
			[EnumMember(Value = "Peer")]
			Peer,

			/// <summary>
			/// Enum Other for "Other"
			/// </summary>
			[EnumMember(Value = "Other")]
			Other,

			/// <summary>
			/// Enum Spam for "Spam"
			/// </summary>
			[EnumMember(Value = "Spam")]
			Spam,

			/// <summary>
			/// Enum Timeout for "Timeout"
			/// </summary>
			[EnumMember(Value = "Timeout")]
			Timeout,

			/// <summary>
			/// Enum Transportfailure for "TransportFailure"
			/// </summary>
			[EnumMember(Value = "TransportFailure")]
			Transportfailure,

			/// <summary>
			/// Enum Conferencetransfer for "ConferenceTransfer"
			/// </summary>
			[EnumMember(Value = "ConferenceTransfer")]
			Conferencetransfer,

			/// <summary>
			/// Enum Consulttransfer for "ConsultTransfer"
			/// </summary>
			[EnumMember(Value = "ConsultTransfer")]
			Consulttransfer,

			/// <summary>
			/// Enum Forwardtransfer for "ForwardTransfer"
			/// </summary>
			[EnumMember(Value = "ForwardTransfer")]
			Forwardtransfer,

			/// <summary>
			/// Enum Noanswertransfer for "NoAnswerTransfer"
			/// </summary>
			[EnumMember(Value = "NoAnswerTransfer")]
			Noanswertransfer,

			/// <summary>
			/// Enum Notavailabletransfer for "NotAvailableTransfer"
			/// </summary>
			[EnumMember(Value = "NotAvailableTransfer")]
			Notavailabletransfer,

			/// <summary>
			/// Enum Uncallable for "Uncallable"
			/// </summary>
			[EnumMember(Value = "Uncallable")]
			Uncallable,

			/// <summary>
			/// Enum Donotdisturbendpoint for "DoNotDisturbEndpoint"
			/// </summary>
			[EnumMember(Value = "DoNotDisturbEndpoint")]
			Donotdisturbendpoint,

			/// <summary>
			/// Enum Donotdisturbtransfer for "DoNotDisturbTransfer"
			/// </summary>
			[EnumMember(Value = "DoNotDisturbTransfer")]
			Donotdisturbtransfer,

			/// <summary>
			/// Enum Sessionexpired for "SessionExpired"
			/// </summary>
			[EnumMember(Value = "SessionExpired")]
			Sessionexpired
		}
		/// <summary>
		/// Gets or Sets LastAcdOutcome
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum LastAcdOutcomeEnum
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
			/// Enum Abandon for "Abandon"
			/// </summary>
			[EnumMember(Value = "Abandon")]
			Abandon,

			/// <summary>
			/// Enum Answered for "Answered"
			/// </summary>
			[EnumMember(Value = "Answered")]
			Answered,

			/// <summary>
			/// Enum Flowout for "FlowOut"
			/// </summary>
			[EnumMember(Value = "FlowOut")]
			Flowout
		}
		/// <summary>
		/// Gets or Sets OriginatingDirection
		/// </summary>
		[DataMember(Name = "originatingDirection", EmitDefaultValue = false)]
		public OriginatingDirectionEnum? OriginatingDirection { get; set; }
		/// <summary>
		/// Gets or Sets LastUserDisconnectType
		/// </summary>
		[DataMember(Name = "lastUserDisconnectType", EmitDefaultValue = false)]
		public LastUserDisconnectTypeEnum? LastUserDisconnectType { get; set; }
		/// <summary>
		/// Gets or Sets LastAcdOutcome
		/// </summary>
		[DataMember(Name = "lastAcdOutcome", EmitDefaultValue = false)]
		public LastAcdOutcomeEnum? LastAcdOutcome { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="JourneySessionEventsNotificationSessionEvent" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="SelfUri">SelfUri.</param>
		/// <param name="CreatedDate">CreatedDate.</param>
		/// <param name="EndedDate">EndedDate.</param>
		/// <param name="ExternalContact">ExternalContact.</param>
		/// <param name="CustomerId">CustomerId.</param>
		/// <param name="CustomerIdType">CustomerIdType.</param>
		/// <param name="Type">Type.</param>
		/// <param name="OutcomeAchievements">OutcomeAchievements.</param>
		/// <param name="SegmentAssignments">SegmentAssignments.</param>
		/// <param name="AwayDate">AwayDate.</param>
		/// <param name="Browser">Browser.</param>
		/// <param name="Device">Device.</param>
		/// <param name="Geolocation">Geolocation.</param>
		/// <param name="IdleDate">IdleDate.</param>
		/// <param name="IpAddress">IpAddress.</param>
		/// <param name="IpOrganization">IpOrganization.</param>
		/// <param name="LastPage">LastPage.</param>
		/// <param name="MktCampaign">MktCampaign.</param>
		/// <param name="Referrer">Referrer.</param>
		/// <param name="SearchTerms">SearchTerms.</param>
		/// <param name="UserAgentString">UserAgentString.</param>
		/// <param name="DurationInSeconds">DurationInSeconds.</param>
		/// <param name="EventCount">EventCount.</param>
		/// <param name="PageviewCount">PageviewCount.</param>
		/// <param name="ScreenviewCount">ScreenviewCount.</param>
		/// <param name="LastEvent">LastEvent.</param>
		/// <param name="Conversation">Conversation.</param>
		/// <param name="OriginatingDirection">OriginatingDirection.</param>
		/// <param name="ConversationSubject">ConversationSubject.</param>
		/// <param name="LastUserDisposition">LastUserDisposition.</param>
		/// <param name="LastConnectedUser">LastConnectedUser.</param>
		/// <param name="LastConnectedQueue">LastConnectedQueue.</param>
		/// <param name="ConversationChannels">ConversationChannels.</param>
		/// <param name="LastUserDisconnectType">LastUserDisconnectType.</param>
		/// <param name="LastAcdOutcome">LastAcdOutcome.</param>
		/// <param name="Authenticated">Authenticated.</param>
		/// <param name="App">App.</param>
		/// <param name="SdkLibrary">SdkLibrary.</param>
		/// <param name="NetworkConnectivity">NetworkConnectivity.</param>
		/// <param name="DivisionIds">DivisionIds.</param>
		/// <param name="LastScreen">LastScreen.</param>
		public JourneySessionEventsNotificationSessionEvent(Guid? Id = null, string SelfUri = null, DateTime? CreatedDate = null, DateTime? EndedDate = null, JourneySessionEventsNotificationExternalContact ExternalContact = null, string CustomerId = null, string CustomerIdType = null, string Type = null, List<JourneySessionEventsNotificationOutcomeAchievement> OutcomeAchievements = null, List<JourneySessionEventsNotificationSegmentAssignment> SegmentAssignments = null, DateTime? AwayDate = null, JourneySessionEventsNotificationBrowser Browser = null, JourneySessionEventsNotificationDevice Device = null, JourneySessionEventsNotificationGeoLocation Geolocation = null, DateTime? IdleDate = null, string IpAddress = null, string IpOrganization = null, JourneySessionEventsNotificationPage LastPage = null, JourneySessionEventsNotificationMktCampaign MktCampaign = null, JourneySessionEventsNotificationReferrer Referrer = null, List<string> SearchTerms = null, string UserAgentString = null, long? DurationInSeconds = null, long? EventCount = null, long? PageviewCount = null, long? ScreenviewCount = null, JourneySessionEventsNotificationSessionLastEvent LastEvent = null, JourneySessionEventsNotificationConversation Conversation = null, OriginatingDirectionEnum? OriginatingDirection = null, string ConversationSubject = null, JourneySessionEventsNotificationConversationUserDisposition LastUserDisposition = null, JourneySessionEventsNotificationUser LastConnectedUser = null, JourneySessionEventsNotificationConnectedQueue LastConnectedQueue = null, List<JourneySessionEventsNotificationConversationChannel> ConversationChannels = null, LastUserDisconnectTypeEnum? LastUserDisconnectType = null, LastAcdOutcomeEnum? LastAcdOutcome = null, bool? Authenticated = null, JourneySessionEventsNotificationApp App = null, JourneySessionEventsNotificationSdkLibrary SdkLibrary = null, JourneySessionEventsNotificationNetworkConnectivity NetworkConnectivity = null, List<string> DivisionIds = null, string LastScreen = null)
		{
			this.Id = Id;
			this.SelfUri = SelfUri;
			this.CreatedDate = CreatedDate;
			this.EndedDate = EndedDate;
			this.ExternalContact = ExternalContact;
			this.CustomerId = CustomerId;
			this.CustomerIdType = CustomerIdType;
			this.Type = Type;
			this.OutcomeAchievements = OutcomeAchievements;
			this.SegmentAssignments = SegmentAssignments;
			this.AwayDate = AwayDate;
			this.Browser = Browser;
			this.Device = Device;
			this.Geolocation = Geolocation;
			this.IdleDate = IdleDate;
			this.IpAddress = IpAddress;
			this.IpOrganization = IpOrganization;
			this.LastPage = LastPage;
			this.MktCampaign = MktCampaign;
			this.Referrer = Referrer;
			this.SearchTerms = SearchTerms;
			this.UserAgentString = UserAgentString;
			this.DurationInSeconds = DurationInSeconds;
			this.EventCount = EventCount;
			this.PageviewCount = PageviewCount;
			this.ScreenviewCount = ScreenviewCount;
			this.LastEvent = LastEvent;
			this.Conversation = Conversation;
			this.OriginatingDirection = OriginatingDirection;
			this.ConversationSubject = ConversationSubject;
			this.LastUserDisposition = LastUserDisposition;
			this.LastConnectedUser = LastConnectedUser;
			this.LastConnectedQueue = LastConnectedQueue;
			this.ConversationChannels = ConversationChannels;
			this.LastUserDisconnectType = LastUserDisconnectType;
			this.LastAcdOutcome = LastAcdOutcome;
			this.Authenticated = Authenticated;
			this.App = App;
			this.SdkLibrary = SdkLibrary;
			this.NetworkConnectivity = NetworkConnectivity;
			this.DivisionIds = DivisionIds;
			this.LastScreen = LastScreen;

		}



		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public Guid? Id { get; set; }



		/// <summary>
		/// Gets or Sets SelfUri
		/// </summary>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; set; }



		/// <summary>
		/// Gets or Sets CreatedDate
		/// </summary>
		[DataMember(Name = "createdDate", EmitDefaultValue = false)]
		public DateTime? CreatedDate { get; set; }



		/// <summary>
		/// Gets or Sets EndedDate
		/// </summary>
		[DataMember(Name = "endedDate", EmitDefaultValue = false)]
		public DateTime? EndedDate { get; set; }



		/// <summary>
		/// Gets or Sets ExternalContact
		/// </summary>
		[DataMember(Name = "externalContact", EmitDefaultValue = false)]
		public JourneySessionEventsNotificationExternalContact ExternalContact { get; set; }



		/// <summary>
		/// Gets or Sets CustomerId
		/// </summary>
		[DataMember(Name = "customerId", EmitDefaultValue = false)]
		public string CustomerId { get; set; }



		/// <summary>
		/// Gets or Sets CustomerIdType
		/// </summary>
		[DataMember(Name = "customerIdType", EmitDefaultValue = false)]
		public string CustomerIdType { get; set; }



		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string Type { get; set; }



		/// <summary>
		/// Gets or Sets OutcomeAchievements
		/// </summary>
		[DataMember(Name = "outcomeAchievements", EmitDefaultValue = false)]
		public List<JourneySessionEventsNotificationOutcomeAchievement> OutcomeAchievements { get; set; }



		/// <summary>
		/// Gets or Sets SegmentAssignments
		/// </summary>
		[DataMember(Name = "segmentAssignments", EmitDefaultValue = false)]
		public List<JourneySessionEventsNotificationSegmentAssignment> SegmentAssignments { get; set; }



		/// <summary>
		/// Gets or Sets AwayDate
		/// </summary>
		[DataMember(Name = "awayDate", EmitDefaultValue = false)]
		public DateTime? AwayDate { get; set; }



		/// <summary>
		/// Gets or Sets Browser
		/// </summary>
		[DataMember(Name = "browser", EmitDefaultValue = false)]
		public JourneySessionEventsNotificationBrowser Browser { get; set; }



		/// <summary>
		/// Gets or Sets Device
		/// </summary>
		[DataMember(Name = "device", EmitDefaultValue = false)]
		public JourneySessionEventsNotificationDevice Device { get; set; }



		/// <summary>
		/// Gets or Sets Geolocation
		/// </summary>
		[DataMember(Name = "geolocation", EmitDefaultValue = false)]
		public JourneySessionEventsNotificationGeoLocation Geolocation { get; set; }



		/// <summary>
		/// Gets or Sets IdleDate
		/// </summary>
		[DataMember(Name = "idleDate", EmitDefaultValue = false)]
		public DateTime? IdleDate { get; set; }



		/// <summary>
		/// Gets or Sets IpAddress
		/// </summary>
		[DataMember(Name = "ipAddress", EmitDefaultValue = false)]
		public string IpAddress { get; set; }



		/// <summary>
		/// Gets or Sets IpOrganization
		/// </summary>
		[DataMember(Name = "ipOrganization", EmitDefaultValue = false)]
		public string IpOrganization { get; set; }



		/// <summary>
		/// Gets or Sets LastPage
		/// </summary>
		[DataMember(Name = "lastPage", EmitDefaultValue = false)]
		public JourneySessionEventsNotificationPage LastPage { get; set; }



		/// <summary>
		/// Gets or Sets MktCampaign
		/// </summary>
		[DataMember(Name = "mktCampaign", EmitDefaultValue = false)]
		public JourneySessionEventsNotificationMktCampaign MktCampaign { get; set; }



		/// <summary>
		/// Gets or Sets Referrer
		/// </summary>
		[DataMember(Name = "referrer", EmitDefaultValue = false)]
		public JourneySessionEventsNotificationReferrer Referrer { get; set; }



		/// <summary>
		/// Gets or Sets SearchTerms
		/// </summary>
		[DataMember(Name = "searchTerms", EmitDefaultValue = false)]
		public List<string> SearchTerms { get; set; }



		/// <summary>
		/// Gets or Sets UserAgentString
		/// </summary>
		[DataMember(Name = "userAgentString", EmitDefaultValue = false)]
		public string UserAgentString { get; set; }



		/// <summary>
		/// Gets or Sets DurationInSeconds
		/// </summary>
		[DataMember(Name = "durationInSeconds", EmitDefaultValue = false)]
		public long? DurationInSeconds { get; set; }



		/// <summary>
		/// Gets or Sets EventCount
		/// </summary>
		[DataMember(Name = "eventCount", EmitDefaultValue = false)]
		public long? EventCount { get; set; }



		/// <summary>
		/// Gets or Sets PageviewCount
		/// </summary>
		[DataMember(Name = "pageviewCount", EmitDefaultValue = false)]
		public long? PageviewCount { get; set; }



		/// <summary>
		/// Gets or Sets ScreenviewCount
		/// </summary>
		[DataMember(Name = "screenviewCount", EmitDefaultValue = false)]
		public long? ScreenviewCount { get; set; }



		/// <summary>
		/// Gets or Sets LastEvent
		/// </summary>
		[DataMember(Name = "lastEvent", EmitDefaultValue = false)]
		public JourneySessionEventsNotificationSessionLastEvent LastEvent { get; set; }



		/// <summary>
		/// Gets or Sets Conversation
		/// </summary>
		[DataMember(Name = "conversation", EmitDefaultValue = false)]
		public JourneySessionEventsNotificationConversation Conversation { get; set; }





		/// <summary>
		/// Gets or Sets ConversationSubject
		/// </summary>
		[DataMember(Name = "conversationSubject", EmitDefaultValue = false)]
		public string ConversationSubject { get; set; }



		/// <summary>
		/// Gets or Sets LastUserDisposition
		/// </summary>
		[DataMember(Name = "lastUserDisposition", EmitDefaultValue = false)]
		public JourneySessionEventsNotificationConversationUserDisposition LastUserDisposition { get; set; }



		/// <summary>
		/// Gets or Sets LastConnectedUser
		/// </summary>
		[DataMember(Name = "lastConnectedUser", EmitDefaultValue = false)]
		public JourneySessionEventsNotificationUser LastConnectedUser { get; set; }



		/// <summary>
		/// Gets or Sets LastConnectedQueue
		/// </summary>
		[DataMember(Name = "lastConnectedQueue", EmitDefaultValue = false)]
		public JourneySessionEventsNotificationConnectedQueue LastConnectedQueue { get; set; }



		/// <summary>
		/// Gets or Sets ConversationChannels
		/// </summary>
		[DataMember(Name = "conversationChannels", EmitDefaultValue = false)]
		public List<JourneySessionEventsNotificationConversationChannel> ConversationChannels { get; set; }







		/// <summary>
		/// Gets or Sets Authenticated
		/// </summary>
		[DataMember(Name = "authenticated", EmitDefaultValue = false)]
		public bool? Authenticated { get; set; }



		/// <summary>
		/// Gets or Sets App
		/// </summary>
		[DataMember(Name = "app", EmitDefaultValue = false)]
		public JourneySessionEventsNotificationApp App { get; set; }



		/// <summary>
		/// Gets or Sets SdkLibrary
		/// </summary>
		[DataMember(Name = "sdkLibrary", EmitDefaultValue = false)]
		public JourneySessionEventsNotificationSdkLibrary SdkLibrary { get; set; }



		/// <summary>
		/// Gets or Sets NetworkConnectivity
		/// </summary>
		[DataMember(Name = "networkConnectivity", EmitDefaultValue = false)]
		public JourneySessionEventsNotificationNetworkConnectivity NetworkConnectivity { get; set; }



		/// <summary>
		/// Gets or Sets DivisionIds
		/// </summary>
		[DataMember(Name = "divisionIds", EmitDefaultValue = false)]
		public List<string> DivisionIds { get; set; }



		/// <summary>
		/// Gets or Sets LastScreen
		/// </summary>
		[DataMember(Name = "lastScreen", EmitDefaultValue = false)]
		public string LastScreen { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JourneySessionEventsNotificationSessionEvent {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
			sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
			sb.Append("  EndedDate: ").Append(EndedDate).Append("\n");
			sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
			sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
			sb.Append("  CustomerIdType: ").Append(CustomerIdType).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  OutcomeAchievements: ").Append(OutcomeAchievements).Append("\n");
			sb.Append("  SegmentAssignments: ").Append(SegmentAssignments).Append("\n");
			sb.Append("  AwayDate: ").Append(AwayDate).Append("\n");
			sb.Append("  Browser: ").Append(Browser).Append("\n");
			sb.Append("  Device: ").Append(Device).Append("\n");
			sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
			sb.Append("  IdleDate: ").Append(IdleDate).Append("\n");
			sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
			sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
			sb.Append("  LastPage: ").Append(LastPage).Append("\n");
			sb.Append("  MktCampaign: ").Append(MktCampaign).Append("\n");
			sb.Append("  Referrer: ").Append(Referrer).Append("\n");
			sb.Append("  SearchTerms: ").Append(SearchTerms).Append("\n");
			sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
			sb.Append("  DurationInSeconds: ").Append(DurationInSeconds).Append("\n");
			sb.Append("  EventCount: ").Append(EventCount).Append("\n");
			sb.Append("  PageviewCount: ").Append(PageviewCount).Append("\n");
			sb.Append("  ScreenviewCount: ").Append(ScreenviewCount).Append("\n");
			sb.Append("  LastEvent: ").Append(LastEvent).Append("\n");
			sb.Append("  Conversation: ").Append(Conversation).Append("\n");
			sb.Append("  OriginatingDirection: ").Append(OriginatingDirection).Append("\n");
			sb.Append("  ConversationSubject: ").Append(ConversationSubject).Append("\n");
			sb.Append("  LastUserDisposition: ").Append(LastUserDisposition).Append("\n");
			sb.Append("  LastConnectedUser: ").Append(LastConnectedUser).Append("\n");
			sb.Append("  LastConnectedQueue: ").Append(LastConnectedQueue).Append("\n");
			sb.Append("  ConversationChannels: ").Append(ConversationChannels).Append("\n");
			sb.Append("  LastUserDisconnectType: ").Append(LastUserDisconnectType).Append("\n");
			sb.Append("  LastAcdOutcome: ").Append(LastAcdOutcome).Append("\n");
			sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
			sb.Append("  App: ").Append(App).Append("\n");
			sb.Append("  SdkLibrary: ").Append(SdkLibrary).Append("\n");
			sb.Append("  NetworkConnectivity: ").Append(NetworkConnectivity).Append("\n");
			sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
			sb.Append("  LastScreen: ").Append(LastScreen).Append("\n");
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
			return this.Equals(obj as JourneySessionEventsNotificationSessionEvent);
		}

		/// <summary>
		/// Returns true if JourneySessionEventsNotificationSessionEvent instances are equal
		/// </summary>
		/// <param name="other">Instance of JourneySessionEventsNotificationSessionEvent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JourneySessionEventsNotificationSessionEvent other)
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
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
				) &&
				(
					this.CreatedDate == other.CreatedDate ||
					this.CreatedDate != null &&
					this.CreatedDate.Equals(other.CreatedDate)
				) &&
				(
					this.EndedDate == other.EndedDate ||
					this.EndedDate != null &&
					this.EndedDate.Equals(other.EndedDate)
				) &&
				(
					this.ExternalContact == other.ExternalContact ||
					this.ExternalContact != null &&
					this.ExternalContact.Equals(other.ExternalContact)
				) &&
				(
					this.CustomerId == other.CustomerId ||
					this.CustomerId != null &&
					this.CustomerId.Equals(other.CustomerId)
				) &&
				(
					this.CustomerIdType == other.CustomerIdType ||
					this.CustomerIdType != null &&
					this.CustomerIdType.Equals(other.CustomerIdType)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.OutcomeAchievements == other.OutcomeAchievements ||
					this.OutcomeAchievements != null &&
					this.OutcomeAchievements.SequenceEqual(other.OutcomeAchievements)
				) &&
				(
					this.SegmentAssignments == other.SegmentAssignments ||
					this.SegmentAssignments != null &&
					this.SegmentAssignments.SequenceEqual(other.SegmentAssignments)
				) &&
				(
					this.AwayDate == other.AwayDate ||
					this.AwayDate != null &&
					this.AwayDate.Equals(other.AwayDate)
				) &&
				(
					this.Browser == other.Browser ||
					this.Browser != null &&
					this.Browser.Equals(other.Browser)
				) &&
				(
					this.Device == other.Device ||
					this.Device != null &&
					this.Device.Equals(other.Device)
				) &&
				(
					this.Geolocation == other.Geolocation ||
					this.Geolocation != null &&
					this.Geolocation.Equals(other.Geolocation)
				) &&
				(
					this.IdleDate == other.IdleDate ||
					this.IdleDate != null &&
					this.IdleDate.Equals(other.IdleDate)
				) &&
				(
					this.IpAddress == other.IpAddress ||
					this.IpAddress != null &&
					this.IpAddress.Equals(other.IpAddress)
				) &&
				(
					this.IpOrganization == other.IpOrganization ||
					this.IpOrganization != null &&
					this.IpOrganization.Equals(other.IpOrganization)
				) &&
				(
					this.LastPage == other.LastPage ||
					this.LastPage != null &&
					this.LastPage.Equals(other.LastPage)
				) &&
				(
					this.MktCampaign == other.MktCampaign ||
					this.MktCampaign != null &&
					this.MktCampaign.Equals(other.MktCampaign)
				) &&
				(
					this.Referrer == other.Referrer ||
					this.Referrer != null &&
					this.Referrer.Equals(other.Referrer)
				) &&
				(
					this.SearchTerms == other.SearchTerms ||
					this.SearchTerms != null &&
					this.SearchTerms.SequenceEqual(other.SearchTerms)
				) &&
				(
					this.UserAgentString == other.UserAgentString ||
					this.UserAgentString != null &&
					this.UserAgentString.Equals(other.UserAgentString)
				) &&
				(
					this.DurationInSeconds == other.DurationInSeconds ||
					this.DurationInSeconds != null &&
					this.DurationInSeconds.Equals(other.DurationInSeconds)
				) &&
				(
					this.EventCount == other.EventCount ||
					this.EventCount != null &&
					this.EventCount.Equals(other.EventCount)
				) &&
				(
					this.PageviewCount == other.PageviewCount ||
					this.PageviewCount != null &&
					this.PageviewCount.Equals(other.PageviewCount)
				) &&
				(
					this.ScreenviewCount == other.ScreenviewCount ||
					this.ScreenviewCount != null &&
					this.ScreenviewCount.Equals(other.ScreenviewCount)
				) &&
				(
					this.LastEvent == other.LastEvent ||
					this.LastEvent != null &&
					this.LastEvent.Equals(other.LastEvent)
				) &&
				(
					this.Conversation == other.Conversation ||
					this.Conversation != null &&
					this.Conversation.Equals(other.Conversation)
				) &&
				(
					this.OriginatingDirection == other.OriginatingDirection ||
					this.OriginatingDirection != null &&
					this.OriginatingDirection.Equals(other.OriginatingDirection)
				) &&
				(
					this.ConversationSubject == other.ConversationSubject ||
					this.ConversationSubject != null &&
					this.ConversationSubject.Equals(other.ConversationSubject)
				) &&
				(
					this.LastUserDisposition == other.LastUserDisposition ||
					this.LastUserDisposition != null &&
					this.LastUserDisposition.Equals(other.LastUserDisposition)
				) &&
				(
					this.LastConnectedUser == other.LastConnectedUser ||
					this.LastConnectedUser != null &&
					this.LastConnectedUser.Equals(other.LastConnectedUser)
				) &&
				(
					this.LastConnectedQueue == other.LastConnectedQueue ||
					this.LastConnectedQueue != null &&
					this.LastConnectedQueue.Equals(other.LastConnectedQueue)
				) &&
				(
					this.ConversationChannels == other.ConversationChannels ||
					this.ConversationChannels != null &&
					this.ConversationChannels.SequenceEqual(other.ConversationChannels)
				) &&
				(
					this.LastUserDisconnectType == other.LastUserDisconnectType ||
					this.LastUserDisconnectType != null &&
					this.LastUserDisconnectType.Equals(other.LastUserDisconnectType)
				) &&
				(
					this.LastAcdOutcome == other.LastAcdOutcome ||
					this.LastAcdOutcome != null &&
					this.LastAcdOutcome.Equals(other.LastAcdOutcome)
				) &&
				(
					this.Authenticated == other.Authenticated ||
					this.Authenticated != null &&
					this.Authenticated.Equals(other.Authenticated)
				) &&
				(
					this.App == other.App ||
					this.App != null &&
					this.App.Equals(other.App)
				) &&
				(
					this.SdkLibrary == other.SdkLibrary ||
					this.SdkLibrary != null &&
					this.SdkLibrary.Equals(other.SdkLibrary)
				) &&
				(
					this.NetworkConnectivity == other.NetworkConnectivity ||
					this.NetworkConnectivity != null &&
					this.NetworkConnectivity.Equals(other.NetworkConnectivity)
				) &&
				(
					this.DivisionIds == other.DivisionIds ||
					this.DivisionIds != null &&
					this.DivisionIds.SequenceEqual(other.DivisionIds)
				) &&
				(
					this.LastScreen == other.LastScreen ||
					this.LastScreen != null &&
					this.LastScreen.Equals(other.LastScreen)
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

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				if (this.CreatedDate != null)
					hash = hash * 59 + this.CreatedDate.GetHashCode();

				if (this.EndedDate != null)
					hash = hash * 59 + this.EndedDate.GetHashCode();

				if (this.ExternalContact != null)
					hash = hash * 59 + this.ExternalContact.GetHashCode();

				if (this.CustomerId != null)
					hash = hash * 59 + this.CustomerId.GetHashCode();

				if (this.CustomerIdType != null)
					hash = hash * 59 + this.CustomerIdType.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.OutcomeAchievements != null)
					hash = hash * 59 + this.OutcomeAchievements.GetHashCode();

				if (this.SegmentAssignments != null)
					hash = hash * 59 + this.SegmentAssignments.GetHashCode();

				if (this.AwayDate != null)
					hash = hash * 59 + this.AwayDate.GetHashCode();

				if (this.Browser != null)
					hash = hash * 59 + this.Browser.GetHashCode();

				if (this.Device != null)
					hash = hash * 59 + this.Device.GetHashCode();

				if (this.Geolocation != null)
					hash = hash * 59 + this.Geolocation.GetHashCode();

				if (this.IdleDate != null)
					hash = hash * 59 + this.IdleDate.GetHashCode();

				if (this.IpAddress != null)
					hash = hash * 59 + this.IpAddress.GetHashCode();

				if (this.IpOrganization != null)
					hash = hash * 59 + this.IpOrganization.GetHashCode();

				if (this.LastPage != null)
					hash = hash * 59 + this.LastPage.GetHashCode();

				if (this.MktCampaign != null)
					hash = hash * 59 + this.MktCampaign.GetHashCode();

				if (this.Referrer != null)
					hash = hash * 59 + this.Referrer.GetHashCode();

				if (this.SearchTerms != null)
					hash = hash * 59 + this.SearchTerms.GetHashCode();

				if (this.UserAgentString != null)
					hash = hash * 59 + this.UserAgentString.GetHashCode();

				if (this.DurationInSeconds != null)
					hash = hash * 59 + this.DurationInSeconds.GetHashCode();

				if (this.EventCount != null)
					hash = hash * 59 + this.EventCount.GetHashCode();

				if (this.PageviewCount != null)
					hash = hash * 59 + this.PageviewCount.GetHashCode();

				if (this.ScreenviewCount != null)
					hash = hash * 59 + this.ScreenviewCount.GetHashCode();

				if (this.LastEvent != null)
					hash = hash * 59 + this.LastEvent.GetHashCode();

				if (this.Conversation != null)
					hash = hash * 59 + this.Conversation.GetHashCode();

				if (this.OriginatingDirection != null)
					hash = hash * 59 + this.OriginatingDirection.GetHashCode();

				if (this.ConversationSubject != null)
					hash = hash * 59 + this.ConversationSubject.GetHashCode();

				if (this.LastUserDisposition != null)
					hash = hash * 59 + this.LastUserDisposition.GetHashCode();

				if (this.LastConnectedUser != null)
					hash = hash * 59 + this.LastConnectedUser.GetHashCode();

				if (this.LastConnectedQueue != null)
					hash = hash * 59 + this.LastConnectedQueue.GetHashCode();

				if (this.ConversationChannels != null)
					hash = hash * 59 + this.ConversationChannels.GetHashCode();

				if (this.LastUserDisconnectType != null)
					hash = hash * 59 + this.LastUserDisconnectType.GetHashCode();

				if (this.LastAcdOutcome != null)
					hash = hash * 59 + this.LastAcdOutcome.GetHashCode();

				if (this.Authenticated != null)
					hash = hash * 59 + this.Authenticated.GetHashCode();

				if (this.App != null)
					hash = hash * 59 + this.App.GetHashCode();

				if (this.SdkLibrary != null)
					hash = hash * 59 + this.SdkLibrary.GetHashCode();

				if (this.NetworkConnectivity != null)
					hash = hash * 59 + this.NetworkConnectivity.GetHashCode();

				if (this.DivisionIds != null)
					hash = hash * 59 + this.DivisionIds.GetHashCode();

				if (this.LastScreen != null)
					hash = hash * 59 + this.LastScreen.GetHashCode();

				return hash;
			}
		}
	}

}
