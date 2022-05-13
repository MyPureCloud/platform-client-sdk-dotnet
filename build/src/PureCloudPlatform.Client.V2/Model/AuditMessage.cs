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
    /// AuditMessage
    /// </summary>
    [DataContract]
    public partial class AuditMessage :  IEquatable<AuditMessage>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditMessage" /> class.
        /// </summary>
        /// <param name="Id">AuditMessage ID. (required).</param>
        /// <param name="User">User.</param>
        /// <param name="CorrelationId">Correlation ID..</param>
        /// <param name="TransactionId">Transaction ID..</param>
        /// <param name="TransactionInitiator">Whether or not this audit can be considered the initiator of the transaction it is a part of..</param>
        /// <param name="Application">The application through which the action of this AuditMessage was initiated..</param>
        /// <param name="ServiceName">The name of the service which sent this AuditMessage. (required).</param>
        /// <param name="Level">The level of this audit. USER or SYSTEM. (required).</param>
        /// <param name="Timestamp">The time at which the action of this AuditMessage was initiated..</param>
        /// <param name="ReceivedTimestamp">The time at which this AuditMessage was received. (required).</param>
        /// <param name="Status">The status of the action of this AuditMessage (required).</param>
        /// <param name="ActionContext">The context of a system-level action.</param>
        /// <param name="Action">A string representing the action that took place.</param>
        /// <param name="Changes">Details about any changes that occurred in this audit.</param>
        /// <param name="Entity">Entity.</param>
        /// <param name="ServiceContext">The service-specific context associated with this AuditMessage..</param>
        public AuditMessage(string Id = null, AuditUser User = null, string CorrelationId = null, string TransactionId = null, bool? TransactionInitiator = null, string Application = null, string ServiceName = null, string Level = null, string Timestamp = null, string ReceivedTimestamp = null, string Status = null, string ActionContext = null, string Action = null, List<Change> Changes = null, AuditEntity Entity = null, ServiceContext ServiceContext = null)
        {
            this.Id = Id;
            this.User = User;
            this.CorrelationId = CorrelationId;
            this.TransactionId = TransactionId;
            this.TransactionInitiator = TransactionInitiator;
            this.Application = Application;
            this.ServiceName = ServiceName;
            this.Level = Level;
            this.Timestamp = Timestamp;
            this.ReceivedTimestamp = ReceivedTimestamp;
            this.Status = Status;
            this.ActionContext = ActionContext;
            this.Action = Action;
            this.Changes = Changes;
            this.Entity = Entity;
            this.ServiceContext = ServiceContext;
            
        }
        


        /// <summary>
        /// AuditMessage ID.
        /// </summary>
        /// <value>AuditMessage ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public AuditUser User { get; set; }



        /// <summary>
        /// Correlation ID.
        /// </summary>
        /// <value>Correlation ID.</value>
        [DataMember(Name="correlationId", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }



        /// <summary>
        /// Transaction ID.
        /// </summary>
        /// <value>Transaction ID.</value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }



        /// <summary>
        /// Whether or not this audit can be considered the initiator of the transaction it is a part of.
        /// </summary>
        /// <value>Whether or not this audit can be considered the initiator of the transaction it is a part of.</value>
        [DataMember(Name="transactionInitiator", EmitDefaultValue=false)]
        public bool? TransactionInitiator { get; set; }



        /// <summary>
        /// The application through which the action of this AuditMessage was initiated.
        /// </summary>
        /// <value>The application through which the action of this AuditMessage was initiated.</value>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public string Application { get; set; }



        /// <summary>
        /// The name of the service which sent this AuditMessage.
        /// </summary>
        /// <value>The name of the service which sent this AuditMessage.</value>
        [DataMember(Name="serviceName", EmitDefaultValue=false)]
        public string ServiceName { get; set; }



        /// <summary>
        /// The level of this audit. USER or SYSTEM.
        /// </summary>
        /// <value>The level of this audit. USER or SYSTEM.</value>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public string Level { get; set; }



        /// <summary>
        /// The time at which the action of this AuditMessage was initiated.
        /// </summary>
        /// <value>The time at which the action of this AuditMessage was initiated.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }



        /// <summary>
        /// The time at which this AuditMessage was received.
        /// </summary>
        /// <value>The time at which this AuditMessage was received.</value>
        [DataMember(Name="receivedTimestamp", EmitDefaultValue=false)]
        public string ReceivedTimestamp { get; set; }



        /// <summary>
        /// The status of the action of this AuditMessage
        /// </summary>
        /// <value>The status of the action of this AuditMessage</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }



        /// <summary>
        /// The context of a system-level action
        /// </summary>
        /// <value>The context of a system-level action</value>
        [DataMember(Name="actionContext", EmitDefaultValue=false)]
        public string ActionContext { get; set; }



        /// <summary>
        /// A string representing the action that took place
        /// </summary>
        /// <value>A string representing the action that took place</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }



        /// <summary>
        /// Details about any changes that occurred in this audit
        /// </summary>
        /// <value>Details about any changes that occurred in this audit</value>
        [DataMember(Name="changes", EmitDefaultValue=false)]
        public List<Change> Changes { get; set; }



        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public AuditEntity Entity { get; set; }



        /// <summary>
        /// The service-specific context associated with this AuditMessage.
        /// </summary>
        /// <value>The service-specific context associated with this AuditMessage.</value>
        [DataMember(Name="serviceContext", EmitDefaultValue=false)]
        public ServiceContext ServiceContext { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditMessage {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  TransactionInitiator: ").Append(TransactionInitiator).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  ReceivedTimestamp: ").Append(ReceivedTimestamp).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ActionContext: ").Append(ActionContext).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Changes: ").Append(Changes).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  ServiceContext: ").Append(ServiceContext).Append("\n");
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
            return this.Equals(obj as AuditMessage);
        }

        /// <summary>
        /// Returns true if AuditMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditMessage other)
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
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) &&
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
                ) &&
                (
                    this.TransactionInitiator == other.TransactionInitiator ||
                    this.TransactionInitiator != null &&
                    this.TransactionInitiator.Equals(other.TransactionInitiator)
                ) &&
                (
                    this.Application == other.Application ||
                    this.Application != null &&
                    this.Application.Equals(other.Application)
                ) &&
                (
                    this.ServiceName == other.ServiceName ||
                    this.ServiceName != null &&
                    this.ServiceName.Equals(other.ServiceName)
                ) &&
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) &&
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) &&
                (
                    this.ReceivedTimestamp == other.ReceivedTimestamp ||
                    this.ReceivedTimestamp != null &&
                    this.ReceivedTimestamp.Equals(other.ReceivedTimestamp)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ActionContext == other.ActionContext ||
                    this.ActionContext != null &&
                    this.ActionContext.Equals(other.ActionContext)
                ) &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.Changes == other.Changes ||
                    this.Changes != null &&
                    this.Changes.SequenceEqual(other.Changes)
                ) &&
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
                ) &&
                (
                    this.ServiceContext == other.ServiceContext ||
                    this.ServiceContext != null &&
                    this.ServiceContext.Equals(other.ServiceContext)
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

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();

                if (this.TransactionId != null)
                    hash = hash * 59 + this.TransactionId.GetHashCode();

                if (this.TransactionInitiator != null)
                    hash = hash * 59 + this.TransactionInitiator.GetHashCode();

                if (this.Application != null)
                    hash = hash * 59 + this.Application.GetHashCode();

                if (this.ServiceName != null)
                    hash = hash * 59 + this.ServiceName.GetHashCode();

                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();

                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();

                if (this.ReceivedTimestamp != null)
                    hash = hash * 59 + this.ReceivedTimestamp.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.ActionContext != null)
                    hash = hash * 59 + this.ActionContext.GetHashCode();

                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();

                if (this.Changes != null)
                    hash = hash * 59 + this.Changes.GetHashCode();

                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();

                if (this.ServiceContext != null)
                    hash = hash * 59 + this.ServiceContext.GetHashCode();

                return hash;
            }
        }
    }

}
