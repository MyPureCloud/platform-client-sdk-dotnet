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
    /// ObservationValue
    /// </summary>
    [DataContract]
    public partial class ObservationValue :  IEquatable<ObservationValue>
    {
        /// <summary>
        /// The direction of the communication
        /// </summary>
        /// <value>The direction of the communication</value>
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
        /// Gets or Sets RequestedRoutings
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RequestedRoutingsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Bullseye for "Bullseye"
            /// </summary>
            [EnumMember(Value = "Bullseye")]
            Bullseye,
            
            /// <summary>
            /// Enum Conditional for "Conditional"
            /// </summary>
            [EnumMember(Value = "Conditional")]
            Conditional,
            
            /// <summary>
            /// Enum Last for "Last"
            /// </summary>
            [EnumMember(Value = "Last")]
            Last,
            
            /// <summary>
            /// Enum Manual for "Manual"
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual,
            
            /// <summary>
            /// Enum Predictive for "Predictive"
            /// </summary>
            [EnumMember(Value = "Predictive")]
            Predictive,
            
            /// <summary>
            /// Enum Preferred for "Preferred"
            /// </summary>
            [EnumMember(Value = "Preferred")]
            Preferred,
            
            /// <summary>
            /// Enum Standard for "Standard"
            /// </summary>
            [EnumMember(Value = "Standard")]
            Standard,
            
            /// <summary>
            /// Enum Vip for "Vip"
            /// </summary>
            [EnumMember(Value = "Vip")]
            Vip
        }
        /// <summary>
        /// Complete routing method
        /// </summary>
        /// <value>Complete routing method</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UsedRoutingEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Bullseye for "Bullseye"
            /// </summary>
            [EnumMember(Value = "Bullseye")]
            Bullseye,
            
            /// <summary>
            /// Enum Conditional for "Conditional"
            /// </summary>
            [EnumMember(Value = "Conditional")]
            Conditional,
            
            /// <summary>
            /// Enum Last for "Last"
            /// </summary>
            [EnumMember(Value = "Last")]
            Last,
            
            /// <summary>
            /// Enum Manual for "Manual"
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual,
            
            /// <summary>
            /// Enum Predictive for "Predictive"
            /// </summary>
            [EnumMember(Value = "Predictive")]
            Predictive,
            
            /// <summary>
            /// Enum Preferred for "Preferred"
            /// </summary>
            [EnumMember(Value = "Preferred")]
            Preferred,
            
            /// <summary>
            /// Enum Standard for "Standard"
            /// </summary>
            [EnumMember(Value = "Standard")]
            Standard,
            
            /// <summary>
            /// Enum Vip for "Vip"
            /// </summary>
            [EnumMember(Value = "Vip")]
            Vip
        }
        /// <summary>
        /// The direction of the communication
        /// </summary>
        /// <value>The direction of the communication</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Complete routing method
        /// </summary>
        /// <value>Complete routing method</value>
        [DataMember(Name="usedRouting", EmitDefaultValue=false)]
        public UsedRoutingEnum? UsedRouting { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationValue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ObservationValue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationValue" /> class.
        /// </summary>
        /// <param name="ObservationDate">The time at which the observation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="ConversationId">Unique identifier for the conversation.</param>
        /// <param name="SessionId">The unique identifier of this session.</param>
        /// <param name="RequestedRoutingSkillIds">Unique identifier for a skill requested for an interaction.</param>
        /// <param name="RequestedLanguageId">Unique identifier for the language requested for an interaction.</param>
        /// <param name="RoutingPriority">Routing priority for the current interaction.</param>
        /// <param name="ParticipantName">A human readable name identifying the participant.</param>
        /// <param name="UserId">Unique identifier for the user.</param>
        /// <param name="Direction">The direction of the communication.</param>
        /// <param name="ConvertedFrom">Session media type that was converted from in case of a media type conversion.</param>
        /// <param name="ConvertedTo">Session media type that was converted to in case of a media type conversion.</param>
        /// <param name="AddressFrom">The address that initiated an action.</param>
        /// <param name="AddressTo">The address receiving an action.</param>
        /// <param name="Ani">Automatic Number Identification (caller's number).</param>
        /// <param name="Dnis">Dialed number identification service (number dialed by the calling party).</param>
        /// <param name="TeamId">The team id the user is a member of.</param>
        /// <param name="RequestedRoutings">All routing types for requested/attempted routing methods.</param>
        /// <param name="UsedRouting">Complete routing method.</param>
        /// <param name="ScoredAgents">ScoredAgents.</param>
        public ObservationValue(DateTime? ObservationDate = null, string ConversationId = null, string SessionId = null, List<string> RequestedRoutingSkillIds = null, string RequestedLanguageId = null, long? RoutingPriority = null, string ParticipantName = null, string UserId = null, DirectionEnum? Direction = null, string ConvertedFrom = null, string ConvertedTo = null, string AddressFrom = null, string AddressTo = null, string Ani = null, string Dnis = null, string TeamId = null, List<RequestedRoutingsEnum> RequestedRoutings = null, UsedRoutingEnum? UsedRouting = null, List<AnalyticsScoredAgent> ScoredAgents = null)
        {
            this.ObservationDate = ObservationDate;
            this.ConversationId = ConversationId;
            this.SessionId = SessionId;
            this.RequestedRoutingSkillIds = RequestedRoutingSkillIds;
            this.RequestedLanguageId = RequestedLanguageId;
            this.RoutingPriority = RoutingPriority;
            this.ParticipantName = ParticipantName;
            this.UserId = UserId;
            this.Direction = Direction;
            this.ConvertedFrom = ConvertedFrom;
            this.ConvertedTo = ConvertedTo;
            this.AddressFrom = AddressFrom;
            this.AddressTo = AddressTo;
            this.Ani = Ani;
            this.Dnis = Dnis;
            this.TeamId = TeamId;
            this.RequestedRoutings = RequestedRoutings;
            this.UsedRouting = UsedRouting;
            this.ScoredAgents = ScoredAgents;
            
        }
        


        /// <summary>
        /// The time at which the observation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time at which the observation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="observationDate", EmitDefaultValue=false)]
        public DateTime? ObservationDate { get; set; }



        /// <summary>
        /// Unique identifier for the conversation
        /// </summary>
        /// <value>Unique identifier for the conversation</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// The unique identifier of this session
        /// </summary>
        /// <value>The unique identifier of this session</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }



        /// <summary>
        /// Unique identifier for a skill requested for an interaction
        /// </summary>
        /// <value>Unique identifier for a skill requested for an interaction</value>
        [DataMember(Name="requestedRoutingSkillIds", EmitDefaultValue=false)]
        public List<string> RequestedRoutingSkillIds { get; set; }



        /// <summary>
        /// Unique identifier for the language requested for an interaction
        /// </summary>
        /// <value>Unique identifier for the language requested for an interaction</value>
        [DataMember(Name="requestedLanguageId", EmitDefaultValue=false)]
        public string RequestedLanguageId { get; set; }



        /// <summary>
        /// Routing priority for the current interaction
        /// </summary>
        /// <value>Routing priority for the current interaction</value>
        [DataMember(Name="routingPriority", EmitDefaultValue=false)]
        public long? RoutingPriority { get; set; }



        /// <summary>
        /// A human readable name identifying the participant
        /// </summary>
        /// <value>A human readable name identifying the participant</value>
        [DataMember(Name="participantName", EmitDefaultValue=false)]
        public string ParticipantName { get; set; }



        /// <summary>
        /// Unique identifier for the user
        /// </summary>
        /// <value>Unique identifier for the user</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }





        /// <summary>
        /// Session media type that was converted from in case of a media type conversion
        /// </summary>
        /// <value>Session media type that was converted from in case of a media type conversion</value>
        [DataMember(Name="convertedFrom", EmitDefaultValue=false)]
        public string ConvertedFrom { get; set; }



        /// <summary>
        /// Session media type that was converted to in case of a media type conversion
        /// </summary>
        /// <value>Session media type that was converted to in case of a media type conversion</value>
        [DataMember(Name="convertedTo", EmitDefaultValue=false)]
        public string ConvertedTo { get; set; }



        /// <summary>
        /// The address that initiated an action
        /// </summary>
        /// <value>The address that initiated an action</value>
        [DataMember(Name="addressFrom", EmitDefaultValue=false)]
        public string AddressFrom { get; set; }



        /// <summary>
        /// The address receiving an action
        /// </summary>
        /// <value>The address receiving an action</value>
        [DataMember(Name="addressTo", EmitDefaultValue=false)]
        public string AddressTo { get; set; }



        /// <summary>
        /// Automatic Number Identification (caller's number)
        /// </summary>
        /// <value>Automatic Number Identification (caller's number)</value>
        [DataMember(Name="ani", EmitDefaultValue=false)]
        public string Ani { get; set; }



        /// <summary>
        /// Dialed number identification service (number dialed by the calling party)
        /// </summary>
        /// <value>Dialed number identification service (number dialed by the calling party)</value>
        [DataMember(Name="dnis", EmitDefaultValue=false)]
        public string Dnis { get; set; }



        /// <summary>
        /// The team id the user is a member of
        /// </summary>
        /// <value>The team id the user is a member of</value>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }



        /// <summary>
        /// All routing types for requested/attempted routing methods
        /// </summary>
        /// <value>All routing types for requested/attempted routing methods</value>
        [DataMember(Name="requestedRoutings", EmitDefaultValue=false)]
        public List<RequestedRoutingsEnum> RequestedRoutings { get; set; }





        /// <summary>
        /// Gets or Sets ScoredAgents
        /// </summary>
        [DataMember(Name="scoredAgents", EmitDefaultValue=false)]
        public List<AnalyticsScoredAgent> ScoredAgents { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObservationValue {\n");

            sb.Append("  ObservationDate: ").Append(ObservationDate).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  RequestedRoutingSkillIds: ").Append(RequestedRoutingSkillIds).Append("\n");
            sb.Append("  RequestedLanguageId: ").Append(RequestedLanguageId).Append("\n");
            sb.Append("  RoutingPriority: ").Append(RoutingPriority).Append("\n");
            sb.Append("  ParticipantName: ").Append(ParticipantName).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  ConvertedFrom: ").Append(ConvertedFrom).Append("\n");
            sb.Append("  ConvertedTo: ").Append(ConvertedTo).Append("\n");
            sb.Append("  AddressFrom: ").Append(AddressFrom).Append("\n");
            sb.Append("  AddressTo: ").Append(AddressTo).Append("\n");
            sb.Append("  Ani: ").Append(Ani).Append("\n");
            sb.Append("  Dnis: ").Append(Dnis).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  RequestedRoutings: ").Append(RequestedRoutings).Append("\n");
            sb.Append("  UsedRouting: ").Append(UsedRouting).Append("\n");
            sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
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
            return this.Equals(obj as ObservationValue);
        }

        /// <summary>
        /// Returns true if ObservationValue instances are equal
        /// </summary>
        /// <param name="other">Instance of ObservationValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObservationValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ObservationDate == other.ObservationDate ||
                    this.ObservationDate != null &&
                    this.ObservationDate.Equals(other.ObservationDate)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) &&
                (
                    this.RequestedRoutingSkillIds == other.RequestedRoutingSkillIds ||
                    this.RequestedRoutingSkillIds != null &&
                    this.RequestedRoutingSkillIds.SequenceEqual(other.RequestedRoutingSkillIds)
                ) &&
                (
                    this.RequestedLanguageId == other.RequestedLanguageId ||
                    this.RequestedLanguageId != null &&
                    this.RequestedLanguageId.Equals(other.RequestedLanguageId)
                ) &&
                (
                    this.RoutingPriority == other.RoutingPriority ||
                    this.RoutingPriority != null &&
                    this.RoutingPriority.Equals(other.RoutingPriority)
                ) &&
                (
                    this.ParticipantName == other.ParticipantName ||
                    this.ParticipantName != null &&
                    this.ParticipantName.Equals(other.ParticipantName)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) &&
                (
                    this.ConvertedFrom == other.ConvertedFrom ||
                    this.ConvertedFrom != null &&
                    this.ConvertedFrom.Equals(other.ConvertedFrom)
                ) &&
                (
                    this.ConvertedTo == other.ConvertedTo ||
                    this.ConvertedTo != null &&
                    this.ConvertedTo.Equals(other.ConvertedTo)
                ) &&
                (
                    this.AddressFrom == other.AddressFrom ||
                    this.AddressFrom != null &&
                    this.AddressFrom.Equals(other.AddressFrom)
                ) &&
                (
                    this.AddressTo == other.AddressTo ||
                    this.AddressTo != null &&
                    this.AddressTo.Equals(other.AddressTo)
                ) &&
                (
                    this.Ani == other.Ani ||
                    this.Ani != null &&
                    this.Ani.Equals(other.Ani)
                ) &&
                (
                    this.Dnis == other.Dnis ||
                    this.Dnis != null &&
                    this.Dnis.Equals(other.Dnis)
                ) &&
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
                ) &&
                (
                    this.RequestedRoutings == other.RequestedRoutings ||
                    this.RequestedRoutings != null &&
                    this.RequestedRoutings.SequenceEqual(other.RequestedRoutings)
                ) &&
                (
                    this.UsedRouting == other.UsedRouting ||
                    this.UsedRouting != null &&
                    this.UsedRouting.Equals(other.UsedRouting)
                ) &&
                (
                    this.ScoredAgents == other.ScoredAgents ||
                    this.ScoredAgents != null &&
                    this.ScoredAgents.SequenceEqual(other.ScoredAgents)
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
                if (this.ObservationDate != null)
                    hash = hash * 59 + this.ObservationDate.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();

                if (this.RequestedRoutingSkillIds != null)
                    hash = hash * 59 + this.RequestedRoutingSkillIds.GetHashCode();

                if (this.RequestedLanguageId != null)
                    hash = hash * 59 + this.RequestedLanguageId.GetHashCode();

                if (this.RoutingPriority != null)
                    hash = hash * 59 + this.RoutingPriority.GetHashCode();

                if (this.ParticipantName != null)
                    hash = hash * 59 + this.ParticipantName.GetHashCode();

                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();

                if (this.ConvertedFrom != null)
                    hash = hash * 59 + this.ConvertedFrom.GetHashCode();

                if (this.ConvertedTo != null)
                    hash = hash * 59 + this.ConvertedTo.GetHashCode();

                if (this.AddressFrom != null)
                    hash = hash * 59 + this.AddressFrom.GetHashCode();

                if (this.AddressTo != null)
                    hash = hash * 59 + this.AddressTo.GetHashCode();

                if (this.Ani != null)
                    hash = hash * 59 + this.Ani.GetHashCode();

                if (this.Dnis != null)
                    hash = hash * 59 + this.Dnis.GetHashCode();

                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();

                if (this.RequestedRoutings != null)
                    hash = hash * 59 + this.RequestedRoutings.GetHashCode();

                if (this.UsedRouting != null)
                    hash = hash * 59 + this.UsedRouting.GetHashCode();

                if (this.ScoredAgents != null)
                    hash = hash * 59 + this.ScoredAgents.GetHashCode();

                return hash;
            }
        }
    }

}
