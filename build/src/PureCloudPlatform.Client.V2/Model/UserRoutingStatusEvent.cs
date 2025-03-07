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
    /// UserRoutingStatusEvent
    /// </summary>
    [DataContract]
    public partial class UserRoutingStatusEvent :  IEquatable<UserRoutingStatusEvent>
    {
        /// <summary>
        /// The agent's current routing status.
        /// </summary>
        /// <value>The agent's current routing status.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Offqueue for "OffQueue"
            /// </summary>
            [EnumMember(Value = "OffQueue")]
            Offqueue,
            
            /// <summary>
            /// Enum Idle for "Idle"
            /// </summary>
            [EnumMember(Value = "Idle")]
            Idle,
            
            /// <summary>
            /// Enum Interacting for "Interacting"
            /// </summary>
            [EnumMember(Value = "Interacting")]
            Interacting,
            
            /// <summary>
            /// Enum Communicating for "Communicating"
            /// </summary>
            [EnumMember(Value = "Communicating")]
            Communicating,
            
            /// <summary>
            /// Enum Notresponding for "NotResponding"
            /// </summary>
            [EnumMember(Value = "NotResponding")]
            Notresponding
        }
        /// <summary>
        /// The agent's current routing status.
        /// </summary>
        /// <value>The agent's current routing status.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoutingStatusEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserRoutingStatusEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoutingStatusEvent" /> class.
        /// </summary>
        /// <param name="EventId">A unique (UUID) eventId for this event (required).</param>
        /// <param name="EventDateTime">A timestamp as epoch representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="AgentId">Unique identifier of the agent. (required).</param>
        /// <param name="Status">The agent&#39;s current routing status. (required).</param>
        /// <param name="SourceId">The agent&#39;s source platform Id. (required).</param>
        public UserRoutingStatusEvent(string EventId = null, DateTime? EventDateTime = null, string AgentId = null, StatusEnum? Status = null, string SourceId = null)
        {
            this.EventId = EventId;
            this.EventDateTime = EventDateTime;
            this.AgentId = AgentId;
            this.Status = Status;
            this.SourceId = SourceId;
            
        }
        


        /// <summary>
        /// A unique (UUID) eventId for this event
        /// </summary>
        /// <value>A unique (UUID) eventId for this event</value>
        [DataMember(Name="eventId", EmitDefaultValue=false)]
        public string EventId { get; set; }



        /// <summary>
        /// A timestamp as epoch representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>A timestamp as epoch representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="eventDateTime", EmitDefaultValue=false)]
        public DateTime? EventDateTime { get; set; }



        /// <summary>
        /// Unique identifier of the agent.
        /// </summary>
        /// <value>Unique identifier of the agent.</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }





        /// <summary>
        /// The agent&#39;s source platform Id.
        /// </summary>
        /// <value>The agent&#39;s source platform Id.</value>
        [DataMember(Name="sourceId", EmitDefaultValue=false)]
        public string SourceId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserRoutingStatusEvent {\n");

            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
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
            return this.Equals(obj as UserRoutingStatusEvent);
        }

        /// <summary>
        /// Returns true if UserRoutingStatusEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of UserRoutingStatusEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserRoutingStatusEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EventId == other.EventId ||
                    this.EventId != null &&
                    this.EventId.Equals(other.EventId)
                ) &&
                (
                    this.EventDateTime == other.EventDateTime ||
                    this.EventDateTime != null &&
                    this.EventDateTime.Equals(other.EventDateTime)
                ) &&
                (
                    this.AgentId == other.AgentId ||
                    this.AgentId != null &&
                    this.AgentId.Equals(other.AgentId)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.SourceId == other.SourceId ||
                    this.SourceId != null &&
                    this.SourceId.Equals(other.SourceId)
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
                if (this.EventId != null)
                    hash = hash * 59 + this.EventId.GetHashCode();

                if (this.EventDateTime != null)
                    hash = hash * 59 + this.EventDateTime.GetHashCode();

                if (this.AgentId != null)
                    hash = hash * 59 + this.AgentId.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.SourceId != null)
                    hash = hash * 59 + this.SourceId.GetHashCode();

                return hash;
            }
        }
    }

}
