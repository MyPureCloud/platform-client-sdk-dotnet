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
    /// AuditLogMessage
    /// </summary>
    [DataContract]
    public partial class AuditLogMessage :  IEquatable<AuditLogMessage>
    {
        /// <summary>
        /// Level of this audit message, USER or SYSTEM.
        /// </summary>
        /// <value>Level of this audit message, USER or SYSTEM.</value>
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
            /// Enum User for "USER"
            /// </summary>
            [EnumMember(Value = "USER")]
            User,
            
            /// <summary>
            /// Enum System for "SYSTEM"
            /// </summary>
            [EnumMember(Value = "SYSTEM")]
            System,
            
            /// <summary>
            /// Enum GenesysInternal for "GENESYS_INTERNAL"
            /// </summary>
            [EnumMember(Value = "GENESYS_INTERNAL")]
            GenesysInternal
        }
        /// <summary>
        /// Status of the event being audited
        /// </summary>
        /// <value>Status of the event being audited</value>
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
            /// Enum Success for "SUCCESS"
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            Success,
            
            /// <summary>
            /// Enum Failure for "FAILURE"
            /// </summary>
            [EnumMember(Value = "FAILURE")]
            Failure,
            
            /// <summary>
            /// Enum Warning for "WARNING"
            /// </summary>
            [EnumMember(Value = "WARNING")]
            Warning
        }
        /// <summary>
        /// Level of this audit message, USER or SYSTEM.
        /// </summary>
        /// <value>Level of this audit message, USER or SYSTEM.</value>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public LevelEnum? Level { get; set; }
        /// <summary>
        /// Status of the event being audited
        /// </summary>
        /// <value>Status of the event being audited</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogMessage" /> class.
        /// </summary>
        /// <param name="Id">Id of the audit message..</param>
        /// <param name="UserHomeOrgId">Home Organization Id associated with this audit message..</param>
        /// <param name="User">User associated with this audit message..</param>
        /// <param name="Client">Client associated with this audit message..</param>
        /// <param name="RemoteIp">List of IP addresses of systems that originated or handled the request..</param>
        /// <param name="ServiceName">Name of the service that logged this audit message..</param>
        /// <param name="Level">Level of this audit message, USER or SYSTEM..</param>
        /// <param name="EventDate">Date and time of when the audit message was logged. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Message">Message describing the event being audited..</param>
        /// <param name="Action">Action that took place..</param>
        /// <param name="Entity">Entity that was impacted..</param>
        /// <param name="EntityType">Type of the entity that was impacted..</param>
        /// <param name="Status">Status of the event being audited.</param>
        /// <param name="Application">Name of the application used to perform the audit's action.</param>
        /// <param name="InitiatingAction">Id and action of the audit initiating the transaction.</param>
        /// <param name="TransactionInitiator">Whether the current audit is the initiator of the transaction.</param>
        /// <param name="PropertyChanges">List of properties that were changed and changes made to those properties..</param>
        /// <param name="Context">Additional context for this message..</param>
        /// <param name="EntityChanges">List of entities that were changed and changes made to those entities..</param>
        public AuditLogMessage(string Id = null, string UserHomeOrgId = null, DomainEntityRef User = null, AddressableEntityRef Client = null, List<string> RemoteIp = null, string ServiceName = null, LevelEnum? Level = null, DateTime? EventDate = null, MessageInfo Message = null, string Action = null, DomainEntityRef Entity = null, string EntityType = null, StatusEnum? Status = null, string Application = null, InitiatingAction InitiatingAction = null, bool? TransactionInitiator = null, List<PropertyChange> PropertyChanges = null, Dictionary<string, string> Context = null, List<EntityChange> EntityChanges = null)
        {
            this.Id = Id;
            this.UserHomeOrgId = UserHomeOrgId;
            this.User = User;
            this.Client = Client;
            this.RemoteIp = RemoteIp;
            this.ServiceName = ServiceName;
            this.Level = Level;
            this.EventDate = EventDate;
            this.Message = Message;
            this.Action = Action;
            this.Entity = Entity;
            this.EntityType = EntityType;
            this.Status = Status;
            this.Application = Application;
            this.InitiatingAction = InitiatingAction;
            this.TransactionInitiator = TransactionInitiator;
            this.PropertyChanges = PropertyChanges;
            this.Context = Context;
            this.EntityChanges = EntityChanges;
            
        }
        


        /// <summary>
        /// Id of the audit message.
        /// </summary>
        /// <value>Id of the audit message.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Home Organization Id associated with this audit message.
        /// </summary>
        /// <value>Home Organization Id associated with this audit message.</value>
        [DataMember(Name="userHomeOrgId", EmitDefaultValue=false)]
        public string UserHomeOrgId { get; set; }



        /// <summary>
        /// User associated with this audit message.
        /// </summary>
        /// <value>User associated with this audit message.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public DomainEntityRef User { get; set; }



        /// <summary>
        /// Client associated with this audit message.
        /// </summary>
        /// <value>Client associated with this audit message.</value>
        [DataMember(Name="client", EmitDefaultValue=false)]
        public AddressableEntityRef Client { get; set; }



        /// <summary>
        /// List of IP addresses of systems that originated or handled the request.
        /// </summary>
        /// <value>List of IP addresses of systems that originated or handled the request.</value>
        [DataMember(Name="remoteIp", EmitDefaultValue=false)]
        public List<string> RemoteIp { get; set; }



        /// <summary>
        /// Name of the service that logged this audit message.
        /// </summary>
        /// <value>Name of the service that logged this audit message.</value>
        [DataMember(Name="serviceName", EmitDefaultValue=false)]
        public string ServiceName { get; set; }





        /// <summary>
        /// Date and time of when the audit message was logged. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date and time of when the audit message was logged. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="eventDate", EmitDefaultValue=false)]
        public DateTime? EventDate { get; set; }



        /// <summary>
        /// Message describing the event being audited.
        /// </summary>
        /// <value>Message describing the event being audited.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public MessageInfo Message { get; set; }



        /// <summary>
        /// Action that took place.
        /// </summary>
        /// <value>Action that took place.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }



        /// <summary>
        /// Entity that was impacted.
        /// </summary>
        /// <value>Entity that was impacted.</value>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public DomainEntityRef Entity { get; set; }



        /// <summary>
        /// Type of the entity that was impacted.
        /// </summary>
        /// <value>Type of the entity that was impacted.</value>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public string EntityType { get; set; }





        /// <summary>
        /// Name of the application used to perform the audit's action
        /// </summary>
        /// <value>Name of the application used to perform the audit's action</value>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public string Application { get; set; }



        /// <summary>
        /// Id and action of the audit initiating the transaction
        /// </summary>
        /// <value>Id and action of the audit initiating the transaction</value>
        [DataMember(Name="initiatingAction", EmitDefaultValue=false)]
        public InitiatingAction InitiatingAction { get; set; }



        /// <summary>
        /// Whether the current audit is the initiator of the transaction
        /// </summary>
        /// <value>Whether the current audit is the initiator of the transaction</value>
        [DataMember(Name="transactionInitiator", EmitDefaultValue=false)]
        public bool? TransactionInitiator { get; set; }



        /// <summary>
        /// List of properties that were changed and changes made to those properties.
        /// </summary>
        /// <value>List of properties that were changed and changes made to those properties.</value>
        [DataMember(Name="propertyChanges", EmitDefaultValue=false)]
        public List<PropertyChange> PropertyChanges { get; set; }



        /// <summary>
        /// Additional context for this message.
        /// </summary>
        /// <value>Additional context for this message.</value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public Dictionary<string, string> Context { get; set; }



        /// <summary>
        /// List of entities that were changed and changes made to those entities.
        /// </summary>
        /// <value>List of entities that were changed and changes made to those entities.</value>
        [DataMember(Name="entityChanges", EmitDefaultValue=false)]
        public List<EntityChange> EntityChanges { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditLogMessage {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserHomeOrgId: ").Append(UserHomeOrgId).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Client: ").Append(Client).Append("\n");
            sb.Append("  RemoteIp: ").Append(RemoteIp).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  InitiatingAction: ").Append(InitiatingAction).Append("\n");
            sb.Append("  TransactionInitiator: ").Append(TransactionInitiator).Append("\n");
            sb.Append("  PropertyChanges: ").Append(PropertyChanges).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  EntityChanges: ").Append(EntityChanges).Append("\n");
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
            return this.Equals(obj as AuditLogMessage);
        }

        /// <summary>
        /// Returns true if AuditLogMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditLogMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditLogMessage other)
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
                    this.UserHomeOrgId == other.UserHomeOrgId ||
                    this.UserHomeOrgId != null &&
                    this.UserHomeOrgId.Equals(other.UserHomeOrgId)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Client == other.Client ||
                    this.Client != null &&
                    this.Client.Equals(other.Client)
                ) &&
                (
                    this.RemoteIp == other.RemoteIp ||
                    this.RemoteIp != null &&
                    this.RemoteIp.SequenceEqual(other.RemoteIp)
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
                    this.EventDate == other.EventDate ||
                    this.EventDate != null &&
                    this.EventDate.Equals(other.EventDate)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
                ) &&
                (
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Application == other.Application ||
                    this.Application != null &&
                    this.Application.Equals(other.Application)
                ) &&
                (
                    this.InitiatingAction == other.InitiatingAction ||
                    this.InitiatingAction != null &&
                    this.InitiatingAction.Equals(other.InitiatingAction)
                ) &&
                (
                    this.TransactionInitiator == other.TransactionInitiator ||
                    this.TransactionInitiator != null &&
                    this.TransactionInitiator.Equals(other.TransactionInitiator)
                ) &&
                (
                    this.PropertyChanges == other.PropertyChanges ||
                    this.PropertyChanges != null &&
                    this.PropertyChanges.SequenceEqual(other.PropertyChanges)
                ) &&
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.SequenceEqual(other.Context)
                ) &&
                (
                    this.EntityChanges == other.EntityChanges ||
                    this.EntityChanges != null &&
                    this.EntityChanges.SequenceEqual(other.EntityChanges)
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

                if (this.UserHomeOrgId != null)
                    hash = hash * 59 + this.UserHomeOrgId.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Client != null)
                    hash = hash * 59 + this.Client.GetHashCode();

                if (this.RemoteIp != null)
                    hash = hash * 59 + this.RemoteIp.GetHashCode();

                if (this.ServiceName != null)
                    hash = hash * 59 + this.ServiceName.GetHashCode();

                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();

                if (this.EventDate != null)
                    hash = hash * 59 + this.EventDate.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();

                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();

                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Application != null)
                    hash = hash * 59 + this.Application.GetHashCode();

                if (this.InitiatingAction != null)
                    hash = hash * 59 + this.InitiatingAction.GetHashCode();

                if (this.TransactionInitiator != null)
                    hash = hash * 59 + this.TransactionInitiator.GetHashCode();

                if (this.PropertyChanges != null)
                    hash = hash * 59 + this.PropertyChanges.GetHashCode();

                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();

                if (this.EntityChanges != null)
                    hash = hash * 59 + this.EntityChanges.GetHashCode();

                return hash;
            }
        }
    }

}
