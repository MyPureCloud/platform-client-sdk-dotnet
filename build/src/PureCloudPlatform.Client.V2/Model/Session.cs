using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Session
    /// </summary>
    [DataContract]
    public partial class Session :  IEquatable<Session>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The original direction of the conversation.
        /// </summary>
        /// <value>The original direction of the conversation.</value>
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
        /// The original direction of the conversation.
        /// </summary>
        /// <value>The original direction of the conversation.</value>
        [DataMember(Name="originatingDirection", EmitDefaultValue=false)]
        public OriginatingDirectionEnum? OriginatingDirection { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Session" /> class.
        /// </summary>
        /// <param name="CustomerId">Primary identifier of the customer in the source where the events for the session originate from..</param>
        /// <param name="CustomerIdType">Type of source customer identifier (e.g. cookie, email, phone)..</param>
        /// <param name="Type">Session types indicate the type or category of sessions (e.g. web, ticket, delivery, atm)..</param>
        /// <param name="ExternalId">Unique identifier in the external system where the events for the session originate from..</param>
        /// <param name="ExternalUrl">A URL that identifies an external system-of-record resource that may have more detailed information on the session..</param>
        /// <param name="ShortId">Shortened numeric identifier of 4-6 digits..</param>
        /// <param name="OutcomeAchievements">List of the outcome achievements by the customer in this session..</param>
        /// <param name="SegmentAssignments">List of the segment assignments to the customer in this session..</param>
        /// <param name="Attributes">Attributes projected from the session&#39;s event stream..</param>
        /// <param name="AttributeLists">List-type attributes projected from the session&#39;s event stream..</param>
        /// <param name="Browser">Customer&#39;s browser..</param>
        /// <param name="Device">Customer&#39;s device..</param>
        /// <param name="Geolocation">Customer&#39;s geolocation..</param>
        /// <param name="IpAddress">Customer&#39;s IP address..</param>
        /// <param name="IpOrganization">Customer&#39;s IP-based organization or ISP name..</param>
        /// <param name="LastPage">The webpage where the customer&#39;s last web interaction occurred..</param>
        /// <param name="MktCampaign">Marketing / traffic source information..</param>
        /// <param name="Referrer">Identifies the page URL that originally generated the request for the current page being viewed..</param>
        /// <param name="SearchTerms">Search terms associated with the session..</param>
        /// <param name="UserAgentString">String identifying the user agent..</param>
        /// <param name="DurationInSeconds">Indicates how long the session has been active (valid for an individual device)..</param>
        /// <param name="EventCount">The count of all events performed during the session..</param>
        /// <param name="PageviewCount">The count of all pageviews performed during the session..</param>
        /// <param name="ScreenviewCount">The count of all screenviews performed during the session..</param>
        /// <param name="LastEvent">Information about the most recent event in this session..</param>
        /// <param name="LastConnectedQueue">The last queue connected to this session..</param>
        /// <param name="LastConnectedUser">The last user connected to this session..</param>
        /// <param name="LastUserDisposition">The last user disposition connected to this session..</param>
        /// <param name="ConversationChannels">Represents the channels used for this conversation..</param>
        /// <param name="OriginatingDirection">The original direction of the conversation..</param>
        /// <param name="ConversationSubject">The subject for the conversation, for example an email subject..</param>
        /// <param name="Authenticated">Indicates whether or not the session is authenticated..</param>
        /// <param name="CreatedDate">Timestamp indicating when the session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="EndedDate">Timestamp indicating when the session was ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="AwayDate">Timestamp indicating when the visitor should be considered as away. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="IdleDate">Timestamp indicating when the visitor should be considered as idle. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public Session(string CustomerId = null, string CustomerIdType = null, string Type = null, string ExternalId = null, string ExternalUrl = null, string ShortId = null, List<OutcomeAchievement> OutcomeAchievements = null, List<SessionSegmentAssignment> SegmentAssignments = null, Dictionary<string, CustomEventAttribute> Attributes = null, Dictionary<string, CustomEventAttributeList> AttributeLists = null, Browser Browser = null, Device Device = null, JourneyGeolocation Geolocation = null, string IpAddress = null, string IpOrganization = null, JourneyPage LastPage = null, JourneyCampaign MktCampaign = null, Referrer Referrer = null, List<string> SearchTerms = null, string UserAgentString = null, int? DurationInSeconds = null, int? EventCount = null, int? PageviewCount = null, int? ScreenviewCount = null, SessionLastEvent LastEvent = null, ConnectedQueue LastConnectedQueue = null, ConnectedUser LastConnectedUser = null, ConversationUserDisposition LastUserDisposition = null, List<ConversationChannel> ConversationChannels = null, OriginatingDirectionEnum? OriginatingDirection = null, string ConversationSubject = null, bool? Authenticated = null, DateTime? CreatedDate = null, DateTime? EndedDate = null, DateTime? AwayDate = null, DateTime? IdleDate = null)
        {
            this.CustomerId = CustomerId;
            this.CustomerIdType = CustomerIdType;
            this.Type = Type;
            this.ExternalId = ExternalId;
            this.ExternalUrl = ExternalUrl;
            this.ShortId = ShortId;
            this.OutcomeAchievements = OutcomeAchievements;
            this.SegmentAssignments = SegmentAssignments;
            this.Attributes = Attributes;
            this.AttributeLists = AttributeLists;
            this.Browser = Browser;
            this.Device = Device;
            this.Geolocation = Geolocation;
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
            this.LastConnectedQueue = LastConnectedQueue;
            this.LastConnectedUser = LastConnectedUser;
            this.LastUserDisposition = LastUserDisposition;
            this.ConversationChannels = ConversationChannels;
            this.OriginatingDirection = OriginatingDirection;
            this.ConversationSubject = ConversationSubject;
            this.Authenticated = Authenticated;
            this.CreatedDate = CreatedDate;
            this.EndedDate = EndedDate;
            this.AwayDate = AwayDate;
            this.IdleDate = IdleDate;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Primary identifier of the customer in the source where the events for the session originate from.
        /// </summary>
        /// <value>Primary identifier of the customer in the source where the events for the session originate from.</value>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; set; }
        
        
        
        /// <summary>
        /// Type of source customer identifier (e.g. cookie, email, phone).
        /// </summary>
        /// <value>Type of source customer identifier (e.g. cookie, email, phone).</value>
        [DataMember(Name="customerIdType", EmitDefaultValue=false)]
        public string CustomerIdType { get; set; }
        
        
        
        /// <summary>
        /// Session types indicate the type or category of sessions (e.g. web, ticket, delivery, atm).
        /// </summary>
        /// <value>Session types indicate the type or category of sessions (e.g. web, ticket, delivery, atm).</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        
        
        
        /// <summary>
        /// Unique identifier in the external system where the events for the session originate from.
        /// </summary>
        /// <value>Unique identifier in the external system where the events for the session originate from.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }
        
        
        
        /// <summary>
        /// A URL that identifies an external system-of-record resource that may have more detailed information on the session.
        /// </summary>
        /// <value>A URL that identifies an external system-of-record resource that may have more detailed information on the session.</value>
        [DataMember(Name="externalUrl", EmitDefaultValue=false)]
        public string ExternalUrl { get; set; }
        
        
        
        /// <summary>
        /// Shortened numeric identifier of 4-6 digits.
        /// </summary>
        /// <value>Shortened numeric identifier of 4-6 digits.</value>
        [DataMember(Name="shortId", EmitDefaultValue=false)]
        public string ShortId { get; set; }
        
        
        
        /// <summary>
        /// List of the outcome achievements by the customer in this session.
        /// </summary>
        /// <value>List of the outcome achievements by the customer in this session.</value>
        [DataMember(Name="outcomeAchievements", EmitDefaultValue=false)]
        public List<OutcomeAchievement> OutcomeAchievements { get; set; }
        
        
        
        /// <summary>
        /// List of the segment assignments to the customer in this session.
        /// </summary>
        /// <value>List of the segment assignments to the customer in this session.</value>
        [DataMember(Name="segmentAssignments", EmitDefaultValue=false)]
        public List<SessionSegmentAssignment> SegmentAssignments { get; set; }
        
        
        
        /// <summary>
        /// Attributes projected from the session&#39;s event stream.
        /// </summary>
        /// <value>Attributes projected from the session&#39;s event stream.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, CustomEventAttribute> Attributes { get; set; }
        
        
        
        /// <summary>
        /// List-type attributes projected from the session&#39;s event stream.
        /// </summary>
        /// <value>List-type attributes projected from the session&#39;s event stream.</value>
        [DataMember(Name="attributeLists", EmitDefaultValue=false)]
        public Dictionary<string, CustomEventAttributeList> AttributeLists { get; set; }
        
        
        
        /// <summary>
        /// Customer&#39;s browser.
        /// </summary>
        /// <value>Customer&#39;s browser.</value>
        [DataMember(Name="browser", EmitDefaultValue=false)]
        public Browser Browser { get; set; }
        
        
        
        /// <summary>
        /// Customer&#39;s device.
        /// </summary>
        /// <value>Customer&#39;s device.</value>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public Device Device { get; set; }
        
        
        
        /// <summary>
        /// Customer&#39;s geolocation.
        /// </summary>
        /// <value>Customer&#39;s geolocation.</value>
        [DataMember(Name="geolocation", EmitDefaultValue=false)]
        public JourneyGeolocation Geolocation { get; set; }
        
        
        
        /// <summary>
        /// Customer&#39;s IP address.
        /// </summary>
        /// <value>Customer&#39;s IP address.</value>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }
        
        
        
        /// <summary>
        /// Customer&#39;s IP-based organization or ISP name.
        /// </summary>
        /// <value>Customer&#39;s IP-based organization or ISP name.</value>
        [DataMember(Name="ipOrganization", EmitDefaultValue=false)]
        public string IpOrganization { get; set; }
        
        
        
        /// <summary>
        /// The webpage where the customer&#39;s last web interaction occurred.
        /// </summary>
        /// <value>The webpage where the customer&#39;s last web interaction occurred.</value>
        [DataMember(Name="lastPage", EmitDefaultValue=false)]
        public JourneyPage LastPage { get; set; }
        
        
        
        /// <summary>
        /// Marketing / traffic source information.
        /// </summary>
        /// <value>Marketing / traffic source information.</value>
        [DataMember(Name="mktCampaign", EmitDefaultValue=false)]
        public JourneyCampaign MktCampaign { get; set; }
        
        
        
        /// <summary>
        /// Identifies the page URL that originally generated the request for the current page being viewed.
        /// </summary>
        /// <value>Identifies the page URL that originally generated the request for the current page being viewed.</value>
        [DataMember(Name="referrer", EmitDefaultValue=false)]
        public Referrer Referrer { get; set; }
        
        
        
        /// <summary>
        /// Search terms associated with the session.
        /// </summary>
        /// <value>Search terms associated with the session.</value>
        [DataMember(Name="searchTerms", EmitDefaultValue=false)]
        public List<string> SearchTerms { get; set; }
        
        
        
        /// <summary>
        /// String identifying the user agent.
        /// </summary>
        /// <value>String identifying the user agent.</value>
        [DataMember(Name="userAgentString", EmitDefaultValue=false)]
        public string UserAgentString { get; set; }
        
        
        
        /// <summary>
        /// Indicates how long the session has been active (valid for an individual device).
        /// </summary>
        /// <value>Indicates how long the session has been active (valid for an individual device).</value>
        [DataMember(Name="durationInSeconds", EmitDefaultValue=false)]
        public int? DurationInSeconds { get; set; }
        
        
        
        /// <summary>
        /// The count of all events performed during the session.
        /// </summary>
        /// <value>The count of all events performed during the session.</value>
        [DataMember(Name="eventCount", EmitDefaultValue=false)]
        public int? EventCount { get; set; }
        
        
        
        /// <summary>
        /// The count of all pageviews performed during the session.
        /// </summary>
        /// <value>The count of all pageviews performed during the session.</value>
        [DataMember(Name="pageviewCount", EmitDefaultValue=false)]
        public int? PageviewCount { get; set; }
        
        
        
        /// <summary>
        /// The count of all screenviews performed during the session.
        /// </summary>
        /// <value>The count of all screenviews performed during the session.</value>
        [DataMember(Name="screenviewCount", EmitDefaultValue=false)]
        public int? ScreenviewCount { get; set; }
        
        
        
        /// <summary>
        /// Information about the most recent event in this session.
        /// </summary>
        /// <value>Information about the most recent event in this session.</value>
        [DataMember(Name="lastEvent", EmitDefaultValue=false)]
        public SessionLastEvent LastEvent { get; set; }
        
        
        
        /// <summary>
        /// The last queue connected to this session.
        /// </summary>
        /// <value>The last queue connected to this session.</value>
        [DataMember(Name="lastConnectedQueue", EmitDefaultValue=false)]
        public ConnectedQueue LastConnectedQueue { get; set; }
        
        
        
        /// <summary>
        /// The last user connected to this session.
        /// </summary>
        /// <value>The last user connected to this session.</value>
        [DataMember(Name="lastConnectedUser", EmitDefaultValue=false)]
        public ConnectedUser LastConnectedUser { get; set; }
        
        
        
        /// <summary>
        /// The last user disposition connected to this session.
        /// </summary>
        /// <value>The last user disposition connected to this session.</value>
        [DataMember(Name="lastUserDisposition", EmitDefaultValue=false)]
        public ConversationUserDisposition LastUserDisposition { get; set; }
        
        
        
        /// <summary>
        /// Represents the channels used for this conversation.
        /// </summary>
        /// <value>Represents the channels used for this conversation.</value>
        [DataMember(Name="conversationChannels", EmitDefaultValue=false)]
        public List<ConversationChannel> ConversationChannels { get; set; }
        
        
        
        
        
        /// <summary>
        /// The subject for the conversation, for example an email subject.
        /// </summary>
        /// <value>The subject for the conversation, for example an email subject.</value>
        [DataMember(Name="conversationSubject", EmitDefaultValue=false)]
        public string ConversationSubject { get; set; }
        
        
        
        /// <summary>
        /// Indicates whether or not the session is authenticated.
        /// </summary>
        /// <value>Indicates whether or not the session is authenticated.</value>
        [DataMember(Name="authenticated", EmitDefaultValue=false)]
        public bool? Authenticated { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        
        /// <summary>
        /// Timestamp indicating when the session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        
        
        
        /// <summary>
        /// Timestamp indicating when the session was ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the session was ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="endedDate", EmitDefaultValue=false)]
        public DateTime? EndedDate { get; set; }
        
        
        
        /// <summary>
        /// The external contact associated with this session.
        /// </summary>
        /// <value>The external contact associated with this session.</value>
        [DataMember(Name="externalContact", EmitDefaultValue=false)]
        public AddressableEntityRef ExternalContact { get; private set; }
        
        
        
        /// <summary>
        /// Timestamp indicating when the visitor should be considered as away. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the visitor should be considered as away. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="awayDate", EmitDefaultValue=false)]
        public DateTime? AwayDate { get; set; }
        
        
        
        /// <summary>
        /// Timestamp indicating when the visitor should be considered as idle. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the visitor should be considered as idle. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="idleDate", EmitDefaultValue=false)]
        public DateTime? IdleDate { get; set; }
        
        
        
        /// <summary>
        /// The conversation for this session.
        /// </summary>
        /// <value>The conversation for this session.</value>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public AddressableEntityRef Conversation { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Session {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  CustomerIdType: ").Append(CustomerIdType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  ExternalUrl: ").Append(ExternalUrl).Append("\n");
            sb.Append("  ShortId: ").Append(ShortId).Append("\n");
            sb.Append("  OutcomeAchievements: ").Append(OutcomeAchievements).Append("\n");
            sb.Append("  SegmentAssignments: ").Append(SegmentAssignments).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  AttributeLists: ").Append(AttributeLists).Append("\n");
            sb.Append("  Browser: ").Append(Browser).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
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
            sb.Append("  LastConnectedQueue: ").Append(LastConnectedQueue).Append("\n");
            sb.Append("  LastConnectedUser: ").Append(LastConnectedUser).Append("\n");
            sb.Append("  LastUserDisposition: ").Append(LastUserDisposition).Append("\n");
            sb.Append("  ConversationChannels: ").Append(ConversationChannels).Append("\n");
            sb.Append("  OriginatingDirection: ").Append(OriginatingDirection).Append("\n");
            sb.Append("  ConversationSubject: ").Append(ConversationSubject).Append("\n");
            sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  EndedDate: ").Append(EndedDate).Append("\n");
            sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
            sb.Append("  AwayDate: ").Append(AwayDate).Append("\n");
            sb.Append("  IdleDate: ").Append(IdleDate).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
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
            return this.Equals(obj as Session);
        }

        /// <summary>
        /// Returns true if Session instances are equal
        /// </summary>
        /// <param name="other">Instance of Session to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Session other)
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
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) &&
                (
                    this.ExternalUrl == other.ExternalUrl ||
                    this.ExternalUrl != null &&
                    this.ExternalUrl.Equals(other.ExternalUrl)
                ) &&
                (
                    this.ShortId == other.ShortId ||
                    this.ShortId != null &&
                    this.ShortId.Equals(other.ShortId)
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
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) &&
                (
                    this.AttributeLists == other.AttributeLists ||
                    this.AttributeLists != null &&
                    this.AttributeLists.SequenceEqual(other.AttributeLists)
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
                    this.LastConnectedQueue == other.LastConnectedQueue ||
                    this.LastConnectedQueue != null &&
                    this.LastConnectedQueue.Equals(other.LastConnectedQueue)
                ) &&
                (
                    this.LastConnectedUser == other.LastConnectedUser ||
                    this.LastConnectedUser != null &&
                    this.LastConnectedUser.Equals(other.LastConnectedUser)
                ) &&
                (
                    this.LastUserDisposition == other.LastUserDisposition ||
                    this.LastUserDisposition != null &&
                    this.LastUserDisposition.Equals(other.LastUserDisposition)
                ) &&
                (
                    this.ConversationChannels == other.ConversationChannels ||
                    this.ConversationChannels != null &&
                    this.ConversationChannels.SequenceEqual(other.ConversationChannels)
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
                    this.Authenticated == other.Authenticated ||
                    this.Authenticated != null &&
                    this.Authenticated.Equals(other.Authenticated)
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
                    this.AwayDate == other.AwayDate ||
                    this.AwayDate != null &&
                    this.AwayDate.Equals(other.AwayDate)
                ) &&
                (
                    this.IdleDate == other.IdleDate ||
                    this.IdleDate != null &&
                    this.IdleDate.Equals(other.IdleDate)
                ) &&
                (
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
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
                
                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                
                if (this.CustomerIdType != null)
                    hash = hash * 59 + this.CustomerIdType.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                
                if (this.ExternalUrl != null)
                    hash = hash * 59 + this.ExternalUrl.GetHashCode();
                
                if (this.ShortId != null)
                    hash = hash * 59 + this.ShortId.GetHashCode();
                
                if (this.OutcomeAchievements != null)
                    hash = hash * 59 + this.OutcomeAchievements.GetHashCode();
                
                if (this.SegmentAssignments != null)
                    hash = hash * 59 + this.SegmentAssignments.GetHashCode();
                
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                
                if (this.AttributeLists != null)
                    hash = hash * 59 + this.AttributeLists.GetHashCode();
                
                if (this.Browser != null)
                    hash = hash * 59 + this.Browser.GetHashCode();
                
                if (this.Device != null)
                    hash = hash * 59 + this.Device.GetHashCode();
                
                if (this.Geolocation != null)
                    hash = hash * 59 + this.Geolocation.GetHashCode();
                
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
                
                if (this.LastConnectedQueue != null)
                    hash = hash * 59 + this.LastConnectedQueue.GetHashCode();
                
                if (this.LastConnectedUser != null)
                    hash = hash * 59 + this.LastConnectedUser.GetHashCode();
                
                if (this.LastUserDisposition != null)
                    hash = hash * 59 + this.LastUserDisposition.GetHashCode();
                
                if (this.ConversationChannels != null)
                    hash = hash * 59 + this.ConversationChannels.GetHashCode();
                
                if (this.OriginatingDirection != null)
                    hash = hash * 59 + this.OriginatingDirection.GetHashCode();
                
                if (this.ConversationSubject != null)
                    hash = hash * 59 + this.ConversationSubject.GetHashCode();
                
                if (this.Authenticated != null)
                    hash = hash * 59 + this.Authenticated.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                
                if (this.EndedDate != null)
                    hash = hash * 59 + this.EndedDate.GetHashCode();
                
                if (this.ExternalContact != null)
                    hash = hash * 59 + this.ExternalContact.GetHashCode();
                
                if (this.AwayDate != null)
                    hash = hash * 59 + this.AwayDate.GetHashCode();
                
                if (this.IdleDate != null)
                    hash = hash * 59 + this.IdleDate.GetHashCode();
                
                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();
                
                return hash;
            }
        }
    }

}
