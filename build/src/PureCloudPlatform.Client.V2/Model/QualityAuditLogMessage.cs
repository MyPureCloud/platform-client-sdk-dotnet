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
    /// QualityAuditLogMessage
    /// </summary>
    [DataContract]
    public partial class QualityAuditLogMessage :  IEquatable<QualityAuditLogMessage>
    {
        /// <summary>
        /// Name of the service that logged this audit message.
        /// </summary>
        /// <value>Name of the service that logged this audit message.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ServiceNameEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Recordingservice for "RecordingService"
            /// </summary>
            [EnumMember(Value = "RecordingService")]
            Recordingservice,
            
            /// <summary>
            /// Enum Recordingplaybackservice for "RecordingPlaybackService"
            /// </summary>
            [EnumMember(Value = "RecordingPlaybackService")]
            Recordingplaybackservice,
            
            /// <summary>
            /// Enum Qualityservice for "QualityService"
            /// </summary>
            [EnumMember(Value = "QualityService")]
            Qualityservice
        }
        /// <summary>
        /// The level of this audit message.
        /// </summary>
        /// <value>The level of this audit message.</value>
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
            /// Enum User for "User"
            /// </summary>
            [EnumMember(Value = "User")]
            User,
            
            /// <summary>
            /// Enum System for "System"
            /// </summary>
            [EnumMember(Value = "System")]
            System
        }
        /// <summary>
        /// The status of the action of this audit message.
        /// </summary>
        /// <value>The status of the action of this audit message.</value>
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
            /// Enum Success for "Success"
            /// </summary>
            [EnumMember(Value = "Success")]
            Success,
            
            /// <summary>
            /// Enum Failure for "Failure"
            /// </summary>
            [EnumMember(Value = "Failure")]
            Failure,
            
            /// <summary>
            /// Enum Warning for "Warning"
            /// </summary>
            [EnumMember(Value = "Warning")]
            Warning
        }
        /// <summary>
        /// Action that took place.
        /// </summary>
        /// <value>Action that took place.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Read for "Read"
            /// </summary>
            [EnumMember(Value = "Read")]
            Read,
            
            /// <summary>
            /// Enum Create for "Create"
            /// </summary>
            [EnumMember(Value = "Create")]
            Create,
            
            /// <summary>
            /// Enum Update for "Update"
            /// </summary>
            [EnumMember(Value = "Update")]
            Update,
            
            /// <summary>
            /// Enum Delete for "Delete"
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete,
            
            /// <summary>
            /// Enum Abandon for "Abandon"
            /// </summary>
            [EnumMember(Value = "Abandon")]
            Abandon,
            
            /// <summary>
            /// Enum Archive for "Archive"
            /// </summary>
            [EnumMember(Value = "Archive")]
            Archive,
            
            /// <summary>
            /// Enum Export for "Export"
            /// </summary>
            [EnumMember(Value = "Export")]
            Export,
            
            /// <summary>
            /// Enum Restorerequest for "RestoreRequest"
            /// </summary>
            [EnumMember(Value = "RestoreRequest")]
            Restorerequest,
            
            /// <summary>
            /// Enum Restorecomplete for "RestoreComplete"
            /// </summary>
            [EnumMember(Value = "RestoreComplete")]
            Restorecomplete,
            
            /// <summary>
            /// Enum Applyprotection for "ApplyProtection"
            /// </summary>
            [EnumMember(Value = "ApplyProtection")]
            Applyprotection,
            
            /// <summary>
            /// Enum Revokeprotection for "RevokeProtection"
            /// </summary>
            [EnumMember(Value = "RevokeProtection")]
            Revokeprotection,
            
            /// <summary>
            /// Enum Updateretention for "UpdateRetention"
            /// </summary>
            [EnumMember(Value = "UpdateRetention")]
            Updateretention
        }
        /// <summary>
        /// Type of the entity that was impacted.
        /// </summary>
        /// <value>Type of the entity that was impacted.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EntityTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Recording for "Recording"
            /// </summary>
            [EnumMember(Value = "Recording")]
            Recording,
            
            /// <summary>
            /// Enum Evaluation for "Evaluation"
            /// </summary>
            [EnumMember(Value = "Evaluation")]
            Evaluation,
            
            /// <summary>
            /// Enum Calibration for "Calibration"
            /// </summary>
            [EnumMember(Value = "Calibration")]
            Calibration,
            
            /// <summary>
            /// Enum Annotation for "Annotation"
            /// </summary>
            [EnumMember(Value = "Annotation")]
            Annotation,
            
            /// <summary>
            /// Enum Screenrecording for "ScreenRecording"
            /// </summary>
            [EnumMember(Value = "ScreenRecording")]
            Screenrecording,
            
            /// <summary>
            /// Enum Survey for "Survey"
            /// </summary>
            [EnumMember(Value = "Survey")]
            Survey
        }
        /// <summary>
        /// Name of the service that logged this audit message.
        /// </summary>
        /// <value>Name of the service that logged this audit message.</value>
        [DataMember(Name="serviceName", EmitDefaultValue=false)]
        public ServiceNameEnum? ServiceName { get; set; }
        /// <summary>
        /// The level of this audit message.
        /// </summary>
        /// <value>The level of this audit message.</value>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public LevelEnum? Level { get; set; }
        /// <summary>
        /// The status of the action of this audit message.
        /// </summary>
        /// <value>The status of the action of this audit message.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Action that took place.
        /// </summary>
        /// <value>Action that took place.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Type of the entity that was impacted.
        /// </summary>
        /// <value>Type of the entity that was impacted.</value>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public EntityTypeEnum? EntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QualityAuditLogMessage" /> class.
        /// </summary>
        /// <param name="Id">Id of the audit message..</param>
        /// <param name="UserHomeOrgId">Home Organization Id associated with this audit message..</param>
        /// <param name="UserTrusteeOrgId">Trustee Organization Id if this audit message is from trustee access..</param>
        /// <param name="User">User associated with this audit message..</param>
        /// <param name="Client">Client associated with this audit message..</param>
        /// <param name="RemoteIps">List of IP addresses of systems that originated or handled the request..</param>
        /// <param name="ServiceName">Name of the service that logged this audit message..</param>
        /// <param name="Level">The level of this audit message..</param>
        /// <param name="Status">The status of the action of this audit message..</param>
        /// <param name="EventDate">Date and time of when the audit message was logged. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="MessageInfo">Message describing the event being audited..</param>
        /// <param name="Action">Action that took place..</param>
        /// <param name="Entity">Entity that was impacted..</param>
        /// <param name="EntityType">Type of the entity that was impacted..</param>
        /// <param name="PropertyChanges">List of properties that were changed and changes made to those properties..</param>
        /// <param name="Context">Additional context for this message..</param>
        public QualityAuditLogMessage(string Id = null, string UserHomeOrgId = null, string UserTrusteeOrgId = null, DomainEntityRef User = null, AddressableEntityRef Client = null, List<string> RemoteIps = null, ServiceNameEnum? ServiceName = null, LevelEnum? Level = null, StatusEnum? Status = null, DateTime? EventDate = null, MessageInfo MessageInfo = null, ActionEnum? Action = null, DomainEntityRef Entity = null, EntityTypeEnum? EntityType = null, List<PropertyChange> PropertyChanges = null, Dictionary<string, string> Context = null)
        {
            this.Id = Id;
            this.UserHomeOrgId = UserHomeOrgId;
            this.UserTrusteeOrgId = UserTrusteeOrgId;
            this.User = User;
            this.Client = Client;
            this.RemoteIps = RemoteIps;
            this.ServiceName = ServiceName;
            this.Level = Level;
            this.Status = Status;
            this.EventDate = EventDate;
            this.MessageInfo = MessageInfo;
            this.Action = Action;
            this.Entity = Entity;
            this.EntityType = EntityType;
            this.PropertyChanges = PropertyChanges;
            this.Context = Context;
            
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
        /// Trustee Organization Id if this audit message is from trustee access.
        /// </summary>
        /// <value>Trustee Organization Id if this audit message is from trustee access.</value>
        [DataMember(Name="userTrusteeOrgId", EmitDefaultValue=false)]
        public string UserTrusteeOrgId { get; set; }



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
        [DataMember(Name="remoteIps", EmitDefaultValue=false)]
        public List<string> RemoteIps { get; set; }









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
        [DataMember(Name="messageInfo", EmitDefaultValue=false)]
        public MessageInfo MessageInfo { get; set; }





        /// <summary>
        /// Entity that was impacted.
        /// </summary>
        /// <value>Entity that was impacted.</value>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public DomainEntityRef Entity { get; set; }





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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QualityAuditLogMessage {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserHomeOrgId: ").Append(UserHomeOrgId).Append("\n");
            sb.Append("  UserTrusteeOrgId: ").Append(UserTrusteeOrgId).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Client: ").Append(Client).Append("\n");
            sb.Append("  RemoteIps: ").Append(RemoteIps).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  MessageInfo: ").Append(MessageInfo).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  PropertyChanges: ").Append(PropertyChanges).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
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
            return this.Equals(obj as QualityAuditLogMessage);
        }

        /// <summary>
        /// Returns true if QualityAuditLogMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of QualityAuditLogMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QualityAuditLogMessage other)
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
                    this.UserTrusteeOrgId == other.UserTrusteeOrgId ||
                    this.UserTrusteeOrgId != null &&
                    this.UserTrusteeOrgId.Equals(other.UserTrusteeOrgId)
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
                    this.RemoteIps == other.RemoteIps ||
                    this.RemoteIps != null &&
                    this.RemoteIps.SequenceEqual(other.RemoteIps)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.EventDate == other.EventDate ||
                    this.EventDate != null &&
                    this.EventDate.Equals(other.EventDate)
                ) &&
                (
                    this.MessageInfo == other.MessageInfo ||
                    this.MessageInfo != null &&
                    this.MessageInfo.Equals(other.MessageInfo)
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
                    this.PropertyChanges == other.PropertyChanges ||
                    this.PropertyChanges != null &&
                    this.PropertyChanges.SequenceEqual(other.PropertyChanges)
                ) &&
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.SequenceEqual(other.Context)
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

                if (this.UserTrusteeOrgId != null)
                    hash = hash * 59 + this.UserTrusteeOrgId.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Client != null)
                    hash = hash * 59 + this.Client.GetHashCode();

                if (this.RemoteIps != null)
                    hash = hash * 59 + this.RemoteIps.GetHashCode();

                if (this.ServiceName != null)
                    hash = hash * 59 + this.ServiceName.GetHashCode();

                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.EventDate != null)
                    hash = hash * 59 + this.EventDate.GetHashCode();

                if (this.MessageInfo != null)
                    hash = hash * 59 + this.MessageInfo.GetHashCode();

                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();

                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();

                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();

                if (this.PropertyChanges != null)
                    hash = hash * 59 + this.PropertyChanges.GetHashCode();

                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();

                return hash;
            }
        }
    }

}
