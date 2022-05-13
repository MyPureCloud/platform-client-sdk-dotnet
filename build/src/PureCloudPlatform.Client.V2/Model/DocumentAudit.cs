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
    /// DocumentAudit
    /// </summary>
    [DataContract]
    public partial class DocumentAudit :  IEquatable<DocumentAudit>
    {
        /// <summary>
        /// Gets or Sets Level
        /// </summary>
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
            System
        }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
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
        /// Gets or Sets ActionContext
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionContextEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Create for "CREATE"
            /// </summary>
            [EnumMember(Value = "CREATE")]
            Create,
            
            /// <summary>
            /// Enum Read for "READ"
            /// </summary>
            [EnumMember(Value = "READ")]
            Read,
            
            /// <summary>
            /// Enum Update for "UPDATE"
            /// </summary>
            [EnumMember(Value = "UPDATE")]
            Update,
            
            /// <summary>
            /// Enum Delete for "DELETE"
            /// </summary>
            [EnumMember(Value = "DELETE")]
            Delete,
            
            /// <summary>
            /// Enum Download for "DOWNLOAD"
            /// </summary>
            [EnumMember(Value = "DOWNLOAD")]
            Download,
            
            /// <summary>
            /// Enum View for "VIEW"
            /// </summary>
            [EnumMember(Value = "VIEW")]
            View,
            
            /// <summary>
            /// Enum Upload for "UPLOAD"
            /// </summary>
            [EnumMember(Value = "UPLOAD")]
            Upload,
            
            /// <summary>
            /// Enum Save for "SAVE"
            /// </summary>
            [EnumMember(Value = "SAVE")]
            Save,
            
            /// <summary>
            /// Enum Move for "MOVE"
            /// </summary>
            [EnumMember(Value = "MOVE")]
            Move,
            
            /// <summary>
            /// Enum Copy for "COPY"
            /// </summary>
            [EnumMember(Value = "COPY")]
            Copy,
            
            /// <summary>
            /// Enum Add for "ADD"
            /// </summary>
            [EnumMember(Value = "ADD")]
            Add,
            
            /// <summary>
            /// Enum Remove for "REMOVE"
            /// </summary>
            [EnumMember(Value = "REMOVE")]
            Remove,
            
            /// <summary>
            /// Enum Receive for "RECEIVE"
            /// </summary>
            [EnumMember(Value = "RECEIVE")]
            Receive,
            
            /// <summary>
            /// Enum Convert for "CONVERT"
            /// </summary>
            [EnumMember(Value = "CONVERT")]
            Convert,
            
            /// <summary>
            /// Enum Fax for "FAX"
            /// </summary>
            [EnumMember(Value = "FAX")]
            Fax,
            
            /// <summary>
            /// Enum CreateCoverpage for "CREATE_COVERPAGE"
            /// </summary>
            [EnumMember(Value = "CREATE_COVERPAGE")]
            CreateCoverpage,
            
            /// <summary>
            /// Enum UserAdd for "USER_ADD"
            /// </summary>
            [EnumMember(Value = "USER_ADD")]
            UserAdd,
            
            /// <summary>
            /// Enum UserRemove for "USER_REMOVE"
            /// </summary>
            [EnumMember(Value = "USER_REMOVE")]
            UserRemove,
            
            /// <summary>
            /// Enum MemberAdd for "MEMBER_ADD"
            /// </summary>
            [EnumMember(Value = "MEMBER_ADD")]
            MemberAdd,
            
            /// <summary>
            /// Enum MemberRemove for "MEMBER_REMOVE"
            /// </summary>
            [EnumMember(Value = "MEMBER_REMOVE")]
            MemberRemove,
            
            /// <summary>
            /// Enum MemberUpdate for "MEMBER_UPDATE"
            /// </summary>
            [EnumMember(Value = "MEMBER_UPDATE")]
            MemberUpdate,
            
            /// <summary>
            /// Enum TagAdd for "TAG_ADD"
            /// </summary>
            [EnumMember(Value = "TAG_ADD")]
            TagAdd,
            
            /// <summary>
            /// Enum TagRemove for "TAG_REMOVE"
            /// </summary>
            [EnumMember(Value = "TAG_REMOVE")]
            TagRemove,
            
            /// <summary>
            /// Enum TagUpdate for "TAG_UPDATE"
            /// </summary>
            [EnumMember(Value = "TAG_UPDATE")]
            TagUpdate,
            
            /// <summary>
            /// Enum AttributeAdd for "ATTRIBUTE_ADD"
            /// </summary>
            [EnumMember(Value = "ATTRIBUTE_ADD")]
            AttributeAdd,
            
            /// <summary>
            /// Enum AttributeRemove for "ATTRIBUTE_REMOVE"
            /// </summary>
            [EnumMember(Value = "ATTRIBUTE_REMOVE")]
            AttributeRemove,
            
            /// <summary>
            /// Enum AttributeUpdate for "ATTRIBUTE_UPDATE"
            /// </summary>
            [EnumMember(Value = "ATTRIBUTE_UPDATE")]
            AttributeUpdate,
            
            /// <summary>
            /// Enum AttributeGroupInstanceAdd for "ATTRIBUTE_GROUP_INSTANCE_ADD"
            /// </summary>
            [EnumMember(Value = "ATTRIBUTE_GROUP_INSTANCE_ADD")]
            AttributeGroupInstanceAdd,
            
            /// <summary>
            /// Enum AttributeGroupInstanceRemove for "ATTRIBUTE_GROUP_INSTANCE_REMOVE"
            /// </summary>
            [EnumMember(Value = "ATTRIBUTE_GROUP_INSTANCE_REMOVE")]
            AttributeGroupInstanceRemove,
            
            /// <summary>
            /// Enum AttributeGroupInstanceUpdate for "ATTRIBUTE_GROUP_INSTANCE_UPDATE"
            /// </summary>
            [EnumMember(Value = "ATTRIBUTE_GROUP_INSTANCE_UPDATE")]
            AttributeGroupInstanceUpdate,
            
            /// <summary>
            /// Enum IndexSave for "INDEX_SAVE"
            /// </summary>
            [EnumMember(Value = "INDEX_SAVE")]
            IndexSave,
            
            /// <summary>
            /// Enum IndexDelete for "INDEX_DELETE"
            /// </summary>
            [EnumMember(Value = "INDEX_DELETE")]
            IndexDelete,
            
            /// <summary>
            /// Enum IndexCreate for "INDEX_CREATE"
            /// </summary>
            [EnumMember(Value = "INDEX_CREATE")]
            IndexCreate,
            
            /// <summary>
            /// Enum FileSave for "FILE_SAVE"
            /// </summary>
            [EnumMember(Value = "FILE_SAVE")]
            FileSave,
            
            /// <summary>
            /// Enum FileDelete for "FILE_DELETE"
            /// </summary>
            [EnumMember(Value = "FILE_DELETE")]
            FileDelete,
            
            /// <summary>
            /// Enum FileRead for "FILE_READ"
            /// </summary>
            [EnumMember(Value = "FILE_READ")]
            FileRead,
            
            /// <summary>
            /// Enum ThumbnailCreate for "THUMBNAIL_CREATE"
            /// </summary>
            [EnumMember(Value = "THUMBNAIL_CREATE")]
            ThumbnailCreate,
            
            /// <summary>
            /// Enum TextExtract for "TEXT_EXTRACT"
            /// </summary>
            [EnumMember(Value = "TEXT_EXTRACT")]
            TextExtract,
            
            /// <summary>
            /// Enum ShareAdd for "SHARE_ADD"
            /// </summary>
            [EnumMember(Value = "SHARE_ADD")]
            ShareAdd,
            
            /// <summary>
            /// Enum ShareRemove for "SHARE_REMOVE"
            /// </summary>
            [EnumMember(Value = "SHARE_REMOVE")]
            ShareRemove,
            
            /// <summary>
            /// Enum VersionCreate for "VERSION_CREATE"
            /// </summary>
            [EnumMember(Value = "VERSION_CREATE")]
            VersionCreate
        }
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
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
            /// Enum Create for "CREATE"
            /// </summary>
            [EnumMember(Value = "CREATE")]
            Create,
            
            /// <summary>
            /// Enum Read for "READ"
            /// </summary>
            [EnumMember(Value = "READ")]
            Read,
            
            /// <summary>
            /// Enum Update for "UPDATE"
            /// </summary>
            [EnumMember(Value = "UPDATE")]
            Update,
            
            /// <summary>
            /// Enum Delete for "DELETE"
            /// </summary>
            [EnumMember(Value = "DELETE")]
            Delete,
            
            /// <summary>
            /// Enum Download for "DOWNLOAD"
            /// </summary>
            [EnumMember(Value = "DOWNLOAD")]
            Download,
            
            /// <summary>
            /// Enum View for "VIEW"
            /// </summary>
            [EnumMember(Value = "VIEW")]
            View,
            
            /// <summary>
            /// Enum Upload for "UPLOAD"
            /// </summary>
            [EnumMember(Value = "UPLOAD")]
            Upload,
            
            /// <summary>
            /// Enum Save for "SAVE"
            /// </summary>
            [EnumMember(Value = "SAVE")]
            Save,
            
            /// <summary>
            /// Enum Move for "MOVE"
            /// </summary>
            [EnumMember(Value = "MOVE")]
            Move,
            
            /// <summary>
            /// Enum Copy for "COPY"
            /// </summary>
            [EnumMember(Value = "COPY")]
            Copy,
            
            /// <summary>
            /// Enum Add for "ADD"
            /// </summary>
            [EnumMember(Value = "ADD")]
            Add,
            
            /// <summary>
            /// Enum Remove for "REMOVE"
            /// </summary>
            [EnumMember(Value = "REMOVE")]
            Remove,
            
            /// <summary>
            /// Enum Receive for "RECEIVE"
            /// </summary>
            [EnumMember(Value = "RECEIVE")]
            Receive,
            
            /// <summary>
            /// Enum Convert for "CONVERT"
            /// </summary>
            [EnumMember(Value = "CONVERT")]
            Convert,
            
            /// <summary>
            /// Enum Fax for "FAX"
            /// </summary>
            [EnumMember(Value = "FAX")]
            Fax,
            
            /// <summary>
            /// Enum CreateCoverpage for "CREATE_COVERPAGE"
            /// </summary>
            [EnumMember(Value = "CREATE_COVERPAGE")]
            CreateCoverpage,
            
            /// <summary>
            /// Enum UserAdd for "USER_ADD"
            /// </summary>
            [EnumMember(Value = "USER_ADD")]
            UserAdd,
            
            /// <summary>
            /// Enum UserRemove for "USER_REMOVE"
            /// </summary>
            [EnumMember(Value = "USER_REMOVE")]
            UserRemove,
            
            /// <summary>
            /// Enum MemberAdd for "MEMBER_ADD"
            /// </summary>
            [EnumMember(Value = "MEMBER_ADD")]
            MemberAdd,
            
            /// <summary>
            /// Enum MemberRemove for "MEMBER_REMOVE"
            /// </summary>
            [EnumMember(Value = "MEMBER_REMOVE")]
            MemberRemove,
            
            /// <summary>
            /// Enum MemberUpdate for "MEMBER_UPDATE"
            /// </summary>
            [EnumMember(Value = "MEMBER_UPDATE")]
            MemberUpdate,
            
            /// <summary>
            /// Enum TagAdd for "TAG_ADD"
            /// </summary>
            [EnumMember(Value = "TAG_ADD")]
            TagAdd,
            
            /// <summary>
            /// Enum TagRemove for "TAG_REMOVE"
            /// </summary>
            [EnumMember(Value = "TAG_REMOVE")]
            TagRemove,
            
            /// <summary>
            /// Enum TagUpdate for "TAG_UPDATE"
            /// </summary>
            [EnumMember(Value = "TAG_UPDATE")]
            TagUpdate,
            
            /// <summary>
            /// Enum AttributeAdd for "ATTRIBUTE_ADD"
            /// </summary>
            [EnumMember(Value = "ATTRIBUTE_ADD")]
            AttributeAdd,
            
            /// <summary>
            /// Enum AttributeRemove for "ATTRIBUTE_REMOVE"
            /// </summary>
            [EnumMember(Value = "ATTRIBUTE_REMOVE")]
            AttributeRemove,
            
            /// <summary>
            /// Enum AttributeUpdate for "ATTRIBUTE_UPDATE"
            /// </summary>
            [EnumMember(Value = "ATTRIBUTE_UPDATE")]
            AttributeUpdate,
            
            /// <summary>
            /// Enum AttributeGroupInstanceAdd for "ATTRIBUTE_GROUP_INSTANCE_ADD"
            /// </summary>
            [EnumMember(Value = "ATTRIBUTE_GROUP_INSTANCE_ADD")]
            AttributeGroupInstanceAdd,
            
            /// <summary>
            /// Enum AttributeGroupInstanceRemove for "ATTRIBUTE_GROUP_INSTANCE_REMOVE"
            /// </summary>
            [EnumMember(Value = "ATTRIBUTE_GROUP_INSTANCE_REMOVE")]
            AttributeGroupInstanceRemove,
            
            /// <summary>
            /// Enum AttributeGroupInstanceUpdate for "ATTRIBUTE_GROUP_INSTANCE_UPDATE"
            /// </summary>
            [EnumMember(Value = "ATTRIBUTE_GROUP_INSTANCE_UPDATE")]
            AttributeGroupInstanceUpdate,
            
            /// <summary>
            /// Enum IndexSave for "INDEX_SAVE"
            /// </summary>
            [EnumMember(Value = "INDEX_SAVE")]
            IndexSave,
            
            /// <summary>
            /// Enum IndexDelete for "INDEX_DELETE"
            /// </summary>
            [EnumMember(Value = "INDEX_DELETE")]
            IndexDelete,
            
            /// <summary>
            /// Enum IndexCreate for "INDEX_CREATE"
            /// </summary>
            [EnumMember(Value = "INDEX_CREATE")]
            IndexCreate,
            
            /// <summary>
            /// Enum FileSave for "FILE_SAVE"
            /// </summary>
            [EnumMember(Value = "FILE_SAVE")]
            FileSave,
            
            /// <summary>
            /// Enum FileDelete for "FILE_DELETE"
            /// </summary>
            [EnumMember(Value = "FILE_DELETE")]
            FileDelete,
            
            /// <summary>
            /// Enum FileRead for "FILE_READ"
            /// </summary>
            [EnumMember(Value = "FILE_READ")]
            FileRead,
            
            /// <summary>
            /// Enum ThumbnailCreate for "THUMBNAIL_CREATE"
            /// </summary>
            [EnumMember(Value = "THUMBNAIL_CREATE")]
            ThumbnailCreate,
            
            /// <summary>
            /// Enum TextExtract for "TEXT_EXTRACT"
            /// </summary>
            [EnumMember(Value = "TEXT_EXTRACT")]
            TextExtract,
            
            /// <summary>
            /// Enum ShareAdd for "SHARE_ADD"
            /// </summary>
            [EnumMember(Value = "SHARE_ADD")]
            ShareAdd,
            
            /// <summary>
            /// Enum ShareRemove for "SHARE_REMOVE"
            /// </summary>
            [EnumMember(Value = "SHARE_REMOVE")]
            ShareRemove,
            
            /// <summary>
            /// Enum VersionCreate for "VERSION_CREATE"
            /// </summary>
            [EnumMember(Value = "VERSION_CREATE")]
            VersionCreate
        }
        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public LevelEnum? Level { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Gets or Sets ActionContext
        /// </summary>
        [DataMember(Name="actionContext", EmitDefaultValue=false)]
        public ActionContextEnum? ActionContext { get; set; }
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentAudit" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="User">User.</param>
        /// <param name="Workspace">Workspace.</param>
        /// <param name="TransactionId">TransactionId.</param>
        /// <param name="TransactionInitiator">TransactionInitiator.</param>
        /// <param name="Application">Application.</param>
        /// <param name="ServiceName">ServiceName.</param>
        /// <param name="Level">Level.</param>
        /// <param name="Timestamp">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Status">Status.</param>
        /// <param name="ActionContext">ActionContext.</param>
        /// <param name="Action">Action.</param>
        /// <param name="Entity">Entity.</param>
        /// <param name="Changes">Changes.</param>
        public DocumentAudit(string Name = null, DomainEntityRef User = null, DomainEntityRef Workspace = null, string TransactionId = null, bool? TransactionInitiator = null, string Application = null, string ServiceName = null, LevelEnum? Level = null, DateTime? Timestamp = null, StatusEnum? Status = null, ActionContextEnum? ActionContext = null, ActionEnum? Action = null, AuditEntityReference Entity = null, List<AuditChange> Changes = null)
        {
            this.Name = Name;
            this.User = User;
            this.Workspace = Workspace;
            this.TransactionId = TransactionId;
            this.TransactionInitiator = TransactionInitiator;
            this.Application = Application;
            this.ServiceName = ServiceName;
            this.Level = Level;
            this.Timestamp = Timestamp;
            this.Status = Status;
            this.ActionContext = ActionContext;
            this.Action = Action;
            this.Entity = Entity;
            this.Changes = Changes;
            
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
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public DomainEntityRef User { get; set; }



        /// <summary>
        /// Gets or Sets Workspace
        /// </summary>
        [DataMember(Name="workspace", EmitDefaultValue=false)]
        public DomainEntityRef Workspace { get; set; }



        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }



        /// <summary>
        /// Gets or Sets TransactionInitiator
        /// </summary>
        [DataMember(Name="transactionInitiator", EmitDefaultValue=false)]
        public bool? TransactionInitiator { get; set; }



        /// <summary>
        /// Gets or Sets Application
        /// </summary>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public string Application { get; set; }



        /// <summary>
        /// Gets or Sets ServiceName
        /// </summary>
        [DataMember(Name="serviceName", EmitDefaultValue=false)]
        public string ServiceName { get; set; }





        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }









        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public AuditEntityReference Entity { get; set; }



        /// <summary>
        /// Gets or Sets Changes
        /// </summary>
        [DataMember(Name="changes", EmitDefaultValue=false)]
        public List<AuditChange> Changes { get; set; }



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
            sb.Append("class DocumentAudit {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Workspace: ").Append(Workspace).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  TransactionInitiator: ").Append(TransactionInitiator).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ActionContext: ").Append(ActionContext).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Changes: ").Append(Changes).Append("\n");
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
            return this.Equals(obj as DocumentAudit);
        }

        /// <summary>
        /// Returns true if DocumentAudit instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentAudit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentAudit other)
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
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Workspace == other.Workspace ||
                    this.Workspace != null &&
                    this.Workspace.Equals(other.Workspace)
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
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
                ) &&
                (
                    this.Changes == other.Changes ||
                    this.Changes != null &&
                    this.Changes.SequenceEqual(other.Changes)
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

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Workspace != null)
                    hash = hash * 59 + this.Workspace.GetHashCode();

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

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.ActionContext != null)
                    hash = hash * 59 + this.ActionContext.GetHashCode();

                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();

                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();

                if (this.Changes != null)
                    hash = hash * 59 + this.Changes.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
