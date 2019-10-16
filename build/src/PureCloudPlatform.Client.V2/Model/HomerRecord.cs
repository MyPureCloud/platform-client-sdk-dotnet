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
    /// HomerRecord
    /// </summary>
    [DataContract]
    public partial class HomerRecord :  IEquatable<HomerRecord>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HomerRecord" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Date">metadata associated to the SIP calls. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="MilliTs">metadata associated to the SIP calls.</param>
        /// <param name="MicroTs">metadata associated to the SIP calls.</param>
        /// <param name="Method">metadata associated to the SIP calls.</param>
        /// <param name="ReplyReason">metadata associated to the SIP calls.</param>
        /// <param name="Ruri">metadata associated to the SIP calls.</param>
        /// <param name="RuriUser">metadata associated to the SIP calls.</param>
        /// <param name="RuriDomain">metadata associated to the SIP calls.</param>
        /// <param name="FromUser">metadata associated to the SIP calls.</param>
        /// <param name="FromDomain">metadata associated to the SIP calls.</param>
        /// <param name="FromTag">metadata associated to the SIP calls.</param>
        /// <param name="ToUser">metadata associated to the SIP calls.</param>
        /// <param name="ToDomain">metadata associated to the SIP calls.</param>
        /// <param name="ToTag">metadata associated to the SIP calls.</param>
        /// <param name="PidUser">metadata associated to the SIP calls.</param>
        /// <param name="ContactUser">metadata associated to the SIP calls.</param>
        /// <param name="AuthUser">metadata associated to the SIP calls.</param>
        /// <param name="Callid">metadata associated to the SIP calls.</param>
        /// <param name="CallidAleg">metadata associated to the SIP calls.</param>
        /// <param name="Via1">metadata associated to the SIP calls.</param>
        /// <param name="Via1Branch">metadata associated to the SIP calls.</param>
        /// <param name="Cseq">metadata associated to the SIP calls.</param>
        /// <param name="Diversion">metadata associated to the SIP calls.</param>
        /// <param name="Reason">metadata associated to the SIP calls.</param>
        /// <param name="ContentType">metadata associated to the SIP calls.</param>
        /// <param name="Auth">metadata associated to the SIP calls.</param>
        /// <param name="UserAgent">metadata associated to the SIP calls.</param>
        /// <param name="SourceIp">metadata associated to the SIP calls.</param>
        /// <param name="SourcePort">metadata associated to the SIP calls.</param>
        /// <param name="DestinationIp">metadata associated to the SIP calls.</param>
        /// <param name="DestinationPort">metadata associated to the SIP calls.</param>
        /// <param name="ContactIp">metadata associated to the SIP calls.</param>
        /// <param name="ContactPort">metadata associated to the SIP calls.</param>
        /// <param name="OriginatorIp">metadata associated to the SIP calls.</param>
        /// <param name="OriginatorPort">metadata associated to the SIP calls.</param>
        /// <param name="CorrelationId">metadata associated to the SIP calls.</param>
        /// <param name="Proto">metadata associated to the SIP calls.</param>
        /// <param name="Family">metadata associated to the SIP calls.</param>
        /// <param name="RtpStat">metadata associated to the SIP calls.</param>
        /// <param name="Type">metadata associated to the SIP calls.</param>
        /// <param name="Node">metadata associated to the SIP calls.</param>
        /// <param name="Trans">metadata associated to the SIP calls.</param>
        /// <param name="Dbnode">metadata associated to the SIP calls.</param>
        /// <param name="Msg">metadata associated to the SIP calls.</param>
        /// <param name="SourceAlias">metadata associated to the SIP calls.</param>
        /// <param name="DestinationAlias">metadata associated to the SIP calls.</param>
        /// <param name="ConversationId">metadata associated to the SIP calls.</param>
        /// <param name="ParticipantId">metadata associated to the SIP calls.</param>
        public HomerRecord(string Name = null, DateTime? Date = null, string MilliTs = null, string MicroTs = null, string Method = null, string ReplyReason = null, string Ruri = null, string RuriUser = null, string RuriDomain = null, string FromUser = null, string FromDomain = null, string FromTag = null, string ToUser = null, string ToDomain = null, string ToTag = null, string PidUser = null, string ContactUser = null, string AuthUser = null, string Callid = null, string CallidAleg = null, string Via1 = null, string Via1Branch = null, string Cseq = null, string Diversion = null, string Reason = null, string ContentType = null, string Auth = null, string UserAgent = null, string SourceIp = null, string SourcePort = null, string DestinationIp = null, string DestinationPort = null, string ContactIp = null, string ContactPort = null, string OriginatorIp = null, string OriginatorPort = null, string CorrelationId = null, string Proto = null, string Family = null, string RtpStat = null, string Type = null, string Node = null, string Trans = null, string Dbnode = null, string Msg = null, string SourceAlias = null, string DestinationAlias = null, string ConversationId = null, string ParticipantId = null)
        {
            this.Name = Name;
            this.Date = Date;
            this.MilliTs = MilliTs;
            this.MicroTs = MicroTs;
            this.Method = Method;
            this.ReplyReason = ReplyReason;
            this.Ruri = Ruri;
            this.RuriUser = RuriUser;
            this.RuriDomain = RuriDomain;
            this.FromUser = FromUser;
            this.FromDomain = FromDomain;
            this.FromTag = FromTag;
            this.ToUser = ToUser;
            this.ToDomain = ToDomain;
            this.ToTag = ToTag;
            this.PidUser = PidUser;
            this.ContactUser = ContactUser;
            this.AuthUser = AuthUser;
            this.Callid = Callid;
            this.CallidAleg = CallidAleg;
            this.Via1 = Via1;
            this.Via1Branch = Via1Branch;
            this.Cseq = Cseq;
            this.Diversion = Diversion;
            this.Reason = Reason;
            this.ContentType = ContentType;
            this.Auth = Auth;
            this.UserAgent = UserAgent;
            this.SourceIp = SourceIp;
            this.SourcePort = SourcePort;
            this.DestinationIp = DestinationIp;
            this.DestinationPort = DestinationPort;
            this.ContactIp = ContactIp;
            this.ContactPort = ContactPort;
            this.OriginatorIp = OriginatorIp;
            this.OriginatorPort = OriginatorPort;
            this.CorrelationId = CorrelationId;
            this.Proto = Proto;
            this.Family = Family;
            this.RtpStat = RtpStat;
            this.Type = Type;
            this.Node = Node;
            this.Trans = Trans;
            this.Dbnode = Dbnode;
            this.Msg = Msg;
            this.SourceAlias = SourceAlias;
            this.DestinationAlias = DestinationAlias;
            this.ConversationId = ConversationId;
            this.ParticipantId = ParticipantId;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>metadata associated to the SIP calls. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="milliTs", EmitDefaultValue=false)]
        public string MilliTs { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="microTs", EmitDefaultValue=false)]
        public string MicroTs { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="replyReason", EmitDefaultValue=false)]
        public string ReplyReason { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="ruri", EmitDefaultValue=false)]
        public string Ruri { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="ruriUser", EmitDefaultValue=false)]
        public string RuriUser { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="ruriDomain", EmitDefaultValue=false)]
        public string RuriDomain { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="fromUser", EmitDefaultValue=false)]
        public string FromUser { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="fromDomain", EmitDefaultValue=false)]
        public string FromDomain { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="fromTag", EmitDefaultValue=false)]
        public string FromTag { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="toUser", EmitDefaultValue=false)]
        public string ToUser { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="toDomain", EmitDefaultValue=false)]
        public string ToDomain { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="toTag", EmitDefaultValue=false)]
        public string ToTag { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="pidUser", EmitDefaultValue=false)]
        public string PidUser { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="contactUser", EmitDefaultValue=false)]
        public string ContactUser { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="authUser", EmitDefaultValue=false)]
        public string AuthUser { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="callid", EmitDefaultValue=false)]
        public string Callid { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="callidAleg", EmitDefaultValue=false)]
        public string CallidAleg { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="via1", EmitDefaultValue=false)]
        public string Via1 { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="via1Branch", EmitDefaultValue=false)]
        public string Via1Branch { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="cseq", EmitDefaultValue=false)]
        public string Cseq { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="diversion", EmitDefaultValue=false)]
        public string Diversion { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="auth", EmitDefaultValue=false)]
        public string Auth { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="userAgent", EmitDefaultValue=false)]
        public string UserAgent { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="sourceIp", EmitDefaultValue=false)]
        public string SourceIp { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="sourcePort", EmitDefaultValue=false)]
        public string SourcePort { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="destinationIp", EmitDefaultValue=false)]
        public string DestinationIp { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="destinationPort", EmitDefaultValue=false)]
        public string DestinationPort { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="contactIp", EmitDefaultValue=false)]
        public string ContactIp { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="contactPort", EmitDefaultValue=false)]
        public string ContactPort { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="originatorIp", EmitDefaultValue=false)]
        public string OriginatorIp { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="originatorPort", EmitDefaultValue=false)]
        public string OriginatorPort { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="correlationId", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="proto", EmitDefaultValue=false)]
        public string Proto { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="family", EmitDefaultValue=false)]
        public string Family { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="rtpStat", EmitDefaultValue=false)]
        public string RtpStat { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="node", EmitDefaultValue=false)]
        public string Node { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="trans", EmitDefaultValue=false)]
        public string Trans { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="dbnode", EmitDefaultValue=false)]
        public string Dbnode { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="msg", EmitDefaultValue=false)]
        public string Msg { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="sourceAlias", EmitDefaultValue=false)]
        public string SourceAlias { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="destinationAlias", EmitDefaultValue=false)]
        public string DestinationAlias { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }
        
        
        
        /// <summary>
        /// metadata associated to the SIP calls
        /// </summary>
        /// <value>metadata associated to the SIP calls</value>
        [DataMember(Name="participantId", EmitDefaultValue=false)]
        public string ParticipantId { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HomerRecord {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  MilliTs: ").Append(MilliTs).Append("\n");
            sb.Append("  MicroTs: ").Append(MicroTs).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  ReplyReason: ").Append(ReplyReason).Append("\n");
            sb.Append("  Ruri: ").Append(Ruri).Append("\n");
            sb.Append("  RuriUser: ").Append(RuriUser).Append("\n");
            sb.Append("  RuriDomain: ").Append(RuriDomain).Append("\n");
            sb.Append("  FromUser: ").Append(FromUser).Append("\n");
            sb.Append("  FromDomain: ").Append(FromDomain).Append("\n");
            sb.Append("  FromTag: ").Append(FromTag).Append("\n");
            sb.Append("  ToUser: ").Append(ToUser).Append("\n");
            sb.Append("  ToDomain: ").Append(ToDomain).Append("\n");
            sb.Append("  ToTag: ").Append(ToTag).Append("\n");
            sb.Append("  PidUser: ").Append(PidUser).Append("\n");
            sb.Append("  ContactUser: ").Append(ContactUser).Append("\n");
            sb.Append("  AuthUser: ").Append(AuthUser).Append("\n");
            sb.Append("  Callid: ").Append(Callid).Append("\n");
            sb.Append("  CallidAleg: ").Append(CallidAleg).Append("\n");
            sb.Append("  Via1: ").Append(Via1).Append("\n");
            sb.Append("  Via1Branch: ").Append(Via1Branch).Append("\n");
            sb.Append("  Cseq: ").Append(Cseq).Append("\n");
            sb.Append("  Diversion: ").Append(Diversion).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Auth: ").Append(Auth).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  SourceIp: ").Append(SourceIp).Append("\n");
            sb.Append("  SourcePort: ").Append(SourcePort).Append("\n");
            sb.Append("  DestinationIp: ").Append(DestinationIp).Append("\n");
            sb.Append("  DestinationPort: ").Append(DestinationPort).Append("\n");
            sb.Append("  ContactIp: ").Append(ContactIp).Append("\n");
            sb.Append("  ContactPort: ").Append(ContactPort).Append("\n");
            sb.Append("  OriginatorIp: ").Append(OriginatorIp).Append("\n");
            sb.Append("  OriginatorPort: ").Append(OriginatorPort).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  Proto: ").Append(Proto).Append("\n");
            sb.Append("  Family: ").Append(Family).Append("\n");
            sb.Append("  RtpStat: ").Append(RtpStat).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Node: ").Append(Node).Append("\n");
            sb.Append("  Trans: ").Append(Trans).Append("\n");
            sb.Append("  Dbnode: ").Append(Dbnode).Append("\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
            sb.Append("  SourceAlias: ").Append(SourceAlias).Append("\n");
            sb.Append("  DestinationAlias: ").Append(DestinationAlias).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as HomerRecord);
        }

        /// <summary>
        /// Returns true if HomerRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of HomerRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HomerRecord other)
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
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) &&
                (
                    this.MilliTs == other.MilliTs ||
                    this.MilliTs != null &&
                    this.MilliTs.Equals(other.MilliTs)
                ) &&
                (
                    this.MicroTs == other.MicroTs ||
                    this.MicroTs != null &&
                    this.MicroTs.Equals(other.MicroTs)
                ) &&
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
                ) &&
                (
                    this.ReplyReason == other.ReplyReason ||
                    this.ReplyReason != null &&
                    this.ReplyReason.Equals(other.ReplyReason)
                ) &&
                (
                    this.Ruri == other.Ruri ||
                    this.Ruri != null &&
                    this.Ruri.Equals(other.Ruri)
                ) &&
                (
                    this.RuriUser == other.RuriUser ||
                    this.RuriUser != null &&
                    this.RuriUser.Equals(other.RuriUser)
                ) &&
                (
                    this.RuriDomain == other.RuriDomain ||
                    this.RuriDomain != null &&
                    this.RuriDomain.Equals(other.RuriDomain)
                ) &&
                (
                    this.FromUser == other.FromUser ||
                    this.FromUser != null &&
                    this.FromUser.Equals(other.FromUser)
                ) &&
                (
                    this.FromDomain == other.FromDomain ||
                    this.FromDomain != null &&
                    this.FromDomain.Equals(other.FromDomain)
                ) &&
                (
                    this.FromTag == other.FromTag ||
                    this.FromTag != null &&
                    this.FromTag.Equals(other.FromTag)
                ) &&
                (
                    this.ToUser == other.ToUser ||
                    this.ToUser != null &&
                    this.ToUser.Equals(other.ToUser)
                ) &&
                (
                    this.ToDomain == other.ToDomain ||
                    this.ToDomain != null &&
                    this.ToDomain.Equals(other.ToDomain)
                ) &&
                (
                    this.ToTag == other.ToTag ||
                    this.ToTag != null &&
                    this.ToTag.Equals(other.ToTag)
                ) &&
                (
                    this.PidUser == other.PidUser ||
                    this.PidUser != null &&
                    this.PidUser.Equals(other.PidUser)
                ) &&
                (
                    this.ContactUser == other.ContactUser ||
                    this.ContactUser != null &&
                    this.ContactUser.Equals(other.ContactUser)
                ) &&
                (
                    this.AuthUser == other.AuthUser ||
                    this.AuthUser != null &&
                    this.AuthUser.Equals(other.AuthUser)
                ) &&
                (
                    this.Callid == other.Callid ||
                    this.Callid != null &&
                    this.Callid.Equals(other.Callid)
                ) &&
                (
                    this.CallidAleg == other.CallidAleg ||
                    this.CallidAleg != null &&
                    this.CallidAleg.Equals(other.CallidAleg)
                ) &&
                (
                    this.Via1 == other.Via1 ||
                    this.Via1 != null &&
                    this.Via1.Equals(other.Via1)
                ) &&
                (
                    this.Via1Branch == other.Via1Branch ||
                    this.Via1Branch != null &&
                    this.Via1Branch.Equals(other.Via1Branch)
                ) &&
                (
                    this.Cseq == other.Cseq ||
                    this.Cseq != null &&
                    this.Cseq.Equals(other.Cseq)
                ) &&
                (
                    this.Diversion == other.Diversion ||
                    this.Diversion != null &&
                    this.Diversion.Equals(other.Diversion)
                ) &&
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) &&
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) &&
                (
                    this.Auth == other.Auth ||
                    this.Auth != null &&
                    this.Auth.Equals(other.Auth)
                ) &&
                (
                    this.UserAgent == other.UserAgent ||
                    this.UserAgent != null &&
                    this.UserAgent.Equals(other.UserAgent)
                ) &&
                (
                    this.SourceIp == other.SourceIp ||
                    this.SourceIp != null &&
                    this.SourceIp.Equals(other.SourceIp)
                ) &&
                (
                    this.SourcePort == other.SourcePort ||
                    this.SourcePort != null &&
                    this.SourcePort.Equals(other.SourcePort)
                ) &&
                (
                    this.DestinationIp == other.DestinationIp ||
                    this.DestinationIp != null &&
                    this.DestinationIp.Equals(other.DestinationIp)
                ) &&
                (
                    this.DestinationPort == other.DestinationPort ||
                    this.DestinationPort != null &&
                    this.DestinationPort.Equals(other.DestinationPort)
                ) &&
                (
                    this.ContactIp == other.ContactIp ||
                    this.ContactIp != null &&
                    this.ContactIp.Equals(other.ContactIp)
                ) &&
                (
                    this.ContactPort == other.ContactPort ||
                    this.ContactPort != null &&
                    this.ContactPort.Equals(other.ContactPort)
                ) &&
                (
                    this.OriginatorIp == other.OriginatorIp ||
                    this.OriginatorIp != null &&
                    this.OriginatorIp.Equals(other.OriginatorIp)
                ) &&
                (
                    this.OriginatorPort == other.OriginatorPort ||
                    this.OriginatorPort != null &&
                    this.OriginatorPort.Equals(other.OriginatorPort)
                ) &&
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) &&
                (
                    this.Proto == other.Proto ||
                    this.Proto != null &&
                    this.Proto.Equals(other.Proto)
                ) &&
                (
                    this.Family == other.Family ||
                    this.Family != null &&
                    this.Family.Equals(other.Family)
                ) &&
                (
                    this.RtpStat == other.RtpStat ||
                    this.RtpStat != null &&
                    this.RtpStat.Equals(other.RtpStat)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Node == other.Node ||
                    this.Node != null &&
                    this.Node.Equals(other.Node)
                ) &&
                (
                    this.Trans == other.Trans ||
                    this.Trans != null &&
                    this.Trans.Equals(other.Trans)
                ) &&
                (
                    this.Dbnode == other.Dbnode ||
                    this.Dbnode != null &&
                    this.Dbnode.Equals(other.Dbnode)
                ) &&
                (
                    this.Msg == other.Msg ||
                    this.Msg != null &&
                    this.Msg.Equals(other.Msg)
                ) &&
                (
                    this.SourceAlias == other.SourceAlias ||
                    this.SourceAlias != null &&
                    this.SourceAlias.Equals(other.SourceAlias)
                ) &&
                (
                    this.DestinationAlias == other.DestinationAlias ||
                    this.DestinationAlias != null &&
                    this.DestinationAlias.Equals(other.DestinationAlias)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.ParticipantId == other.ParticipantId ||
                    this.ParticipantId != null &&
                    this.ParticipantId.Equals(other.ParticipantId)
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
                
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                
                if (this.MilliTs != null)
                    hash = hash * 59 + this.MilliTs.GetHashCode();
                
                if (this.MicroTs != null)
                    hash = hash * 59 + this.MicroTs.GetHashCode();
                
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
                
                if (this.ReplyReason != null)
                    hash = hash * 59 + this.ReplyReason.GetHashCode();
                
                if (this.Ruri != null)
                    hash = hash * 59 + this.Ruri.GetHashCode();
                
                if (this.RuriUser != null)
                    hash = hash * 59 + this.RuriUser.GetHashCode();
                
                if (this.RuriDomain != null)
                    hash = hash * 59 + this.RuriDomain.GetHashCode();
                
                if (this.FromUser != null)
                    hash = hash * 59 + this.FromUser.GetHashCode();
                
                if (this.FromDomain != null)
                    hash = hash * 59 + this.FromDomain.GetHashCode();
                
                if (this.FromTag != null)
                    hash = hash * 59 + this.FromTag.GetHashCode();
                
                if (this.ToUser != null)
                    hash = hash * 59 + this.ToUser.GetHashCode();
                
                if (this.ToDomain != null)
                    hash = hash * 59 + this.ToDomain.GetHashCode();
                
                if (this.ToTag != null)
                    hash = hash * 59 + this.ToTag.GetHashCode();
                
                if (this.PidUser != null)
                    hash = hash * 59 + this.PidUser.GetHashCode();
                
                if (this.ContactUser != null)
                    hash = hash * 59 + this.ContactUser.GetHashCode();
                
                if (this.AuthUser != null)
                    hash = hash * 59 + this.AuthUser.GetHashCode();
                
                if (this.Callid != null)
                    hash = hash * 59 + this.Callid.GetHashCode();
                
                if (this.CallidAleg != null)
                    hash = hash * 59 + this.CallidAleg.GetHashCode();
                
                if (this.Via1 != null)
                    hash = hash * 59 + this.Via1.GetHashCode();
                
                if (this.Via1Branch != null)
                    hash = hash * 59 + this.Via1Branch.GetHashCode();
                
                if (this.Cseq != null)
                    hash = hash * 59 + this.Cseq.GetHashCode();
                
                if (this.Diversion != null)
                    hash = hash * 59 + this.Diversion.GetHashCode();
                
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();
                
                if (this.Auth != null)
                    hash = hash * 59 + this.Auth.GetHashCode();
                
                if (this.UserAgent != null)
                    hash = hash * 59 + this.UserAgent.GetHashCode();
                
                if (this.SourceIp != null)
                    hash = hash * 59 + this.SourceIp.GetHashCode();
                
                if (this.SourcePort != null)
                    hash = hash * 59 + this.SourcePort.GetHashCode();
                
                if (this.DestinationIp != null)
                    hash = hash * 59 + this.DestinationIp.GetHashCode();
                
                if (this.DestinationPort != null)
                    hash = hash * 59 + this.DestinationPort.GetHashCode();
                
                if (this.ContactIp != null)
                    hash = hash * 59 + this.ContactIp.GetHashCode();
                
                if (this.ContactPort != null)
                    hash = hash * 59 + this.ContactPort.GetHashCode();
                
                if (this.OriginatorIp != null)
                    hash = hash * 59 + this.OriginatorIp.GetHashCode();
                
                if (this.OriginatorPort != null)
                    hash = hash * 59 + this.OriginatorPort.GetHashCode();
                
                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();
                
                if (this.Proto != null)
                    hash = hash * 59 + this.Proto.GetHashCode();
                
                if (this.Family != null)
                    hash = hash * 59 + this.Family.GetHashCode();
                
                if (this.RtpStat != null)
                    hash = hash * 59 + this.RtpStat.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Node != null)
                    hash = hash * 59 + this.Node.GetHashCode();
                
                if (this.Trans != null)
                    hash = hash * 59 + this.Trans.GetHashCode();
                
                if (this.Dbnode != null)
                    hash = hash * 59 + this.Dbnode.GetHashCode();
                
                if (this.Msg != null)
                    hash = hash * 59 + this.Msg.GetHashCode();
                
                if (this.SourceAlias != null)
                    hash = hash * 59 + this.SourceAlias.GetHashCode();
                
                if (this.DestinationAlias != null)
                    hash = hash * 59 + this.DestinationAlias.GetHashCode();
                
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();
                
                if (this.ParticipantId != null)
                    hash = hash * 59 + this.ParticipantId.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
