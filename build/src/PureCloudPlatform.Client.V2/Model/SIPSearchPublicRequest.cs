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
    /// SIPSearchPublicRequest
    /// </summary>
    [DataContract]
    public partial class SIPSearchPublicRequest :  IEquatable<SIPSearchPublicRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SIPSearchPublicRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SIPSearchPublicRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SIPSearchPublicRequest" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="CallId">unique identification of the placed call.</param>
        /// <param name="ToUser">SIP user to who the call was placed.</param>
        /// <param name="FromUser">SIP user who placed the call.</param>
        /// <param name="ConversationId">Unique identification of the conversation.</param>
        /// <param name="ParticipantId">Unique identification of the participant.</param>
        /// <param name="DateStart">Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="DateEnd">End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        public SIPSearchPublicRequest(string Name = null, string CallId = null, string ToUser = null, string FromUser = null, string ConversationId = null, string ParticipantId = null, DateTime? DateStart = null, DateTime? DateEnd = null)
        {
            this.Name = Name;
            this.CallId = CallId;
            this.ToUser = ToUser;
            this.FromUser = FromUser;
            this.ConversationId = ConversationId;
            this.ParticipantId = ParticipantId;
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
            
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
        /// unique identification of the placed call
        /// </summary>
        /// <value>unique identification of the placed call</value>
        [DataMember(Name="callId", EmitDefaultValue=false)]
        public string CallId { get; set; }
        
        
        
        /// <summary>
        /// SIP user to who the call was placed
        /// </summary>
        /// <value>SIP user to who the call was placed</value>
        [DataMember(Name="toUser", EmitDefaultValue=false)]
        public string ToUser { get; set; }
        
        
        
        /// <summary>
        /// SIP user who placed the call
        /// </summary>
        /// <value>SIP user who placed the call</value>
        [DataMember(Name="fromUser", EmitDefaultValue=false)]
        public string FromUser { get; set; }
        
        
        
        /// <summary>
        /// Unique identification of the conversation
        /// </summary>
        /// <value>Unique identification of the conversation</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }
        
        
        
        /// <summary>
        /// Unique identification of the participant
        /// </summary>
        /// <value>Unique identification of the participant</value>
        [DataMember(Name="participantId", EmitDefaultValue=false)]
        public string ParticipantId { get; set; }
        
        
        
        /// <summary>
        /// Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public DateTime? DateStart { get; set; }
        
        
        
        /// <summary>
        /// End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateEnd", EmitDefaultValue=false)]
        public DateTime? DateEnd { get; set; }
        
        
        
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
            sb.Append("class SIPSearchPublicRequest {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  ToUser: ").Append(ToUser).Append("\n");
            sb.Append("  FromUser: ").Append(FromUser).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
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
            return this.Equals(obj as SIPSearchPublicRequest);
        }

        /// <summary>
        /// Returns true if SIPSearchPublicRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SIPSearchPublicRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SIPSearchPublicRequest other)
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
                    this.CallId == other.CallId ||
                    this.CallId != null &&
                    this.CallId.Equals(other.CallId)
                ) &&
                (
                    this.ToUser == other.ToUser ||
                    this.ToUser != null &&
                    this.ToUser.Equals(other.ToUser)
                ) &&
                (
                    this.FromUser == other.FromUser ||
                    this.FromUser != null &&
                    this.FromUser.Equals(other.FromUser)
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
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
                ) &&
                (
                    this.DateEnd == other.DateEnd ||
                    this.DateEnd != null &&
                    this.DateEnd.Equals(other.DateEnd)
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
                
                if (this.CallId != null)
                    hash = hash * 59 + this.CallId.GetHashCode();
                
                if (this.ToUser != null)
                    hash = hash * 59 + this.ToUser.GetHashCode();
                
                if (this.FromUser != null)
                    hash = hash * 59 + this.FromUser.GetHashCode();
                
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();
                
                if (this.ParticipantId != null)
                    hash = hash * 59 + this.ParticipantId.GetHashCode();
                
                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();
                
                if (this.DateEnd != null)
                    hash = hash * 59 + this.DateEnd.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
