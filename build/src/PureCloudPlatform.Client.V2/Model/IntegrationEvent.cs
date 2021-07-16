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
    /// Describes an event that has happened related to an integration
    /// </summary>
    [DataContract]
    public partial class IntegrationEvent :  IEquatable<IntegrationEvent>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Indicates the severity of the event.
        /// </summary>
        /// <value>Indicates the severity of the event.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum LevelEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Info for "INFO"
            /// </summary>
            [EnumMember(Value = "INFO")]
            Info,
            
            /// <summary>
            /// Enum Warn for "WARN"
            /// </summary>
            [EnumMember(Value = "WARN")]
            Warn,
            
            /// <summary>
            /// Enum Error for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            Error,
            
            /// <summary>
            /// Enum Critical for "CRITICAL"
            /// </summary>
            [EnumMember(Value = "CRITICAL")]
            Critical
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Indicates the severity of the event.
        /// </summary>
        /// <value>Indicates the severity of the event.</value>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public LevelEnum? Level { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationEvent" /> class.
        /// </summary>
        /// <param name="Message">Message indicating what happened.</param>
        /// <param name="Entities">Collection of entities affected by or pertaining to the event (e.g. a list of Integrations or Bridge connectors).</param>
        /// <param name="ContextAttributes">Map of context attributes specific to this event..</param>
        /// <param name="DetailMessage">Message with additional details about the event. (e.g. an exception cause.).</param>
        /// <param name="User">User that took an action that resulted in the event..</param>
        public IntegrationEvent(MessageInfo Message = null, List<EventEntity> Entities = null, Dictionary<string, string> ContextAttributes = null, MessageInfo DetailMessage = null, User User = null)
        {
            this.Message = Message;
            this.Entities = Entities;
            this.ContextAttributes = ContextAttributes;
            this.DetailMessage = DetailMessage;
            this.User = User;
            
        }
        
        
        
        /// <summary>
        /// Unique ID for this event
        /// </summary>
        /// <value>Unique ID for this event</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        
        /// <summary>
        /// Correlation ID for the event
        /// </summary>
        /// <value>Correlation ID for the event</value>
        [DataMember(Name="correlationId", EmitDefaultValue=false)]
        public string CorrelationId { get; private set; }
        
        
        
        /// <summary>
        /// Time the event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Time the event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; private set; }
        
        
        
        
        
        /// <summary>
        /// A classification for the event. Suitable for programmatic searching, sorting, or filtering
        /// </summary>
        /// <value>A classification for the event. Suitable for programmatic searching, sorting, or filtering</value>
        [DataMember(Name="eventCode", EmitDefaultValue=false)]
        public string EventCode { get; private set; }
        
        
        
        /// <summary>
        /// Message indicating what happened
        /// </summary>
        /// <value>Message indicating what happened</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public MessageInfo Message { get; set; }
        
        
        
        /// <summary>
        /// Collection of entities affected by or pertaining to the event (e.g. a list of Integrations or Bridge connectors)
        /// </summary>
        /// <value>Collection of entities affected by or pertaining to the event (e.g. a list of Integrations or Bridge connectors)</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<EventEntity> Entities { get; set; }
        
        
        
        /// <summary>
        /// Map of context attributes specific to this event.
        /// </summary>
        /// <value>Map of context attributes specific to this event.</value>
        [DataMember(Name="contextAttributes", EmitDefaultValue=false)]
        public Dictionary<string, string> ContextAttributes { get; set; }
        
        
        
        /// <summary>
        /// Message with additional details about the event. (e.g. an exception cause.)
        /// </summary>
        /// <value>Message with additional details about the event. (e.g. an exception cause.)</value>
        [DataMember(Name="detailMessage", EmitDefaultValue=false)]
        public MessageInfo DetailMessage { get; set; }
        
        
        
        /// <summary>
        /// User that took an action that resulted in the event.
        /// </summary>
        /// <value>User that took an action that resulted in the event.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegrationEvent {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  EventCode: ").Append(EventCode).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  ContextAttributes: ").Append(ContextAttributes).Append("\n");
            sb.Append("  DetailMessage: ").Append(DetailMessage).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as IntegrationEvent);
        }

        /// <summary>
        /// Returns true if IntegrationEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegrationEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationEvent other)
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
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) &&
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) &&
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) &&
                (
                    this.EventCode == other.EventCode ||
                    this.EventCode != null &&
                    this.EventCode.Equals(other.EventCode)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
                ) &&
                (
                    this.ContextAttributes == other.ContextAttributes ||
                    this.ContextAttributes != null &&
                    this.ContextAttributes.SequenceEqual(other.ContextAttributes)
                ) &&
                (
                    this.DetailMessage == other.DetailMessage ||
                    this.DetailMessage != null &&
                    this.DetailMessage.Equals(other.DetailMessage)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                
                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();
                
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                
                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();
                
                if (this.EventCode != null)
                    hash = hash * 59 + this.EventCode.GetHashCode();
                
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                
                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();
                
                if (this.ContextAttributes != null)
                    hash = hash * 59 + this.ContextAttributes.GetHashCode();
                
                if (this.DetailMessage != null)
                    hash = hash * 59 + this.DetailMessage.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                return hash;
            }
        }
    }

}
