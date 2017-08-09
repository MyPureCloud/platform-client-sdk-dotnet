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
    /// VoicemailMessage
    /// </summary>
    [DataContract]
    public partial class VoicemailMessage :  IEquatable<VoicemailMessage>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailMessage" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Conversation">The conversation that the voicemail message is associated with.</param>
        
        
        
        /// <param name="Read">Whether the voicemail message is marked as read.</param>
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <param name="CallerUser">Optionally the user that left the voicemail message if the caller was a known user.</param>
        
        
        
        /// <param name="Deleted">Whether the voicemail message has been marked as deleted.</param>
        
        
        
        /// <param name="Note">An optional note.</param>
        
        
        
        /// <param name="User">The user that the voicemail message belongs to or null which means the voicemail message belongs to a group or queue.</param>
        
        
        
        /// <param name="Group">The group that the voicemail message belongs to or null which means the voicemail message belongs to a user or queue.</param>
        
        
        
        /// <param name="Queue">The queue that the voicemail message belongs to or null which means the voicemail message belongs to a user or group.</param>
        
        
        
        /// <param name="CopiedFrom">Represents where this voicemail message was copied from.</param>
        
        
        
        /// <param name="CopiedTo">Represents where this voicemail has been copied to.</param>
        
        
        
        /// <param name="DeleteRetentionPolicy">The retention policy for this voicemail when deleted is set to true.</param>
        
        
        
        
        public VoicemailMessage(Conversation Conversation = null, bool? Read = null, User CallerUser = null, bool? Deleted = null, string Note = null, User User = null, Group Group = null, Queue Queue = null, VoicemailCopyRecord CopiedFrom = null, List<VoicemailCopyRecord> CopiedTo = null, VoicemailRetentionPolicy DeleteRetentionPolicy = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Conversation = Conversation;
            
            
            
            
            
            
            
            
this.Read = Read;
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.CallerUser = CallerUser;
            
            
            
            
            
            
            
            
this.Deleted = Deleted;
            
            
            
            
            
            
            
            
this.Note = Note;
            
            
            
            
            
            
            
            
this.User = User;
            
            
            
            
            
            
            
            
this.Group = Group;
            
            
            
            
            
            
            
            
this.Queue = Queue;
            
            
            
            
            
            
            
            
this.CopiedFrom = CopiedFrom;
            
            
            
            
            
            
            
            
this.CopiedTo = CopiedTo;
            
            
            
            
            
            
            
            
this.DeleteRetentionPolicy = DeleteRetentionPolicy;
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The conversation that the voicemail message is associated with
        /// </summary>
        /// <value>The conversation that the voicemail message is associated with</value>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public Conversation Conversation { get; set; }
        
        
        
        /// <summary>
        /// Whether the voicemail message is marked as read
        /// </summary>
        /// <value>Whether the voicemail message is marked as read</value>
        [DataMember(Name="read", EmitDefaultValue=false)]
        public bool? Read { get; set; }
        
        
        
        /// <summary>
        /// The voicemail message&#39;s audio recording duration in seconds
        /// </summary>
        /// <value>The voicemail message&#39;s audio recording duration in seconds</value>
        [DataMember(Name="audioRecordingDurationSeconds", EmitDefaultValue=false)]
        public int? AudioRecordingDurationSeconds { get; private set; }
        
        
        
        /// <summary>
        /// The voicemail message&#39;s audio recording size in bytes
        /// </summary>
        /// <value>The voicemail message&#39;s audio recording size in bytes</value>
        [DataMember(Name="audioRecordingSizeBytes", EmitDefaultValue=false)]
        public long? AudioRecordingSizeBytes { get; private set; }
        
        
        
        /// <summary>
        /// The date the voicemail message was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date the voicemail message was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; private set; }
        
        
        
        /// <summary>
        /// The date the voicemail message was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date the voicemail message was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; private set; }
        
        
        
        /// <summary>
        /// The date the voicemail message deleted property was set to true. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date the voicemail message deleted property was set to true. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="deletedDate", EmitDefaultValue=false)]
        public DateTime? DeletedDate { get; private set; }
        
        
        
        /// <summary>
        /// The caller address
        /// </summary>
        /// <value>The caller address</value>
        [DataMember(Name="callerAddress", EmitDefaultValue=false)]
        public string CallerAddress { get; private set; }
        
        
        
        /// <summary>
        /// Optionally the name of the caller that left the voicemail message if the caller was a known user
        /// </summary>
        /// <value>Optionally the name of the caller that left the voicemail message if the caller was a known user</value>
        [DataMember(Name="callerName", EmitDefaultValue=false)]
        public string CallerName { get; private set; }
        
        
        
        /// <summary>
        /// Optionally the user that left the voicemail message if the caller was a known user
        /// </summary>
        /// <value>Optionally the user that left the voicemail message if the caller was a known user</value>
        [DataMember(Name="callerUser", EmitDefaultValue=false)]
        public User CallerUser { get; set; }
        
        
        
        /// <summary>
        /// Whether the voicemail message has been marked as deleted
        /// </summary>
        /// <value>Whether the voicemail message has been marked as deleted</value>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; set; }
        
        
        
        /// <summary>
        /// An optional note
        /// </summary>
        /// <value>An optional note</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
        
        
        
        /// <summary>
        /// The user that the voicemail message belongs to or null which means the voicemail message belongs to a group or queue
        /// </summary>
        /// <value>The user that the voicemail message belongs to or null which means the voicemail message belongs to a group or queue</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        
        
        
        /// <summary>
        /// The group that the voicemail message belongs to or null which means the voicemail message belongs to a user or queue
        /// </summary>
        /// <value>The group that the voicemail message belongs to or null which means the voicemail message belongs to a user or queue</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public Group Group { get; set; }
        
        
        
        /// <summary>
        /// The queue that the voicemail message belongs to or null which means the voicemail message belongs to a user or group
        /// </summary>
        /// <value>The queue that the voicemail message belongs to or null which means the voicemail message belongs to a user or group</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public Queue Queue { get; set; }
        
        
        
        /// <summary>
        /// Represents where this voicemail message was copied from
        /// </summary>
        /// <value>Represents where this voicemail message was copied from</value>
        [DataMember(Name="copiedFrom", EmitDefaultValue=false)]
        public VoicemailCopyRecord CopiedFrom { get; set; }
        
        
        
        /// <summary>
        /// Represents where this voicemail has been copied to
        /// </summary>
        /// <value>Represents where this voicemail has been copied to</value>
        [DataMember(Name="copiedTo", EmitDefaultValue=false)]
        public List<VoicemailCopyRecord> CopiedTo { get; set; }
        
        
        
        /// <summary>
        /// The retention policy for this voicemail when deleted is set to true
        /// </summary>
        /// <value>The retention policy for this voicemail when deleted is set to true</value>
        [DataMember(Name="deleteRetentionPolicy", EmitDefaultValue=false)]
        public VoicemailRetentionPolicy DeleteRetentionPolicy { get; set; }
        
        
        
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
            sb.Append("class VoicemailMessage {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            
            sb.Append("  Read: ").Append(Read).Append("\n");
            
            sb.Append("  AudioRecordingDurationSeconds: ").Append(AudioRecordingDurationSeconds).Append("\n");
            
            sb.Append("  AudioRecordingSizeBytes: ").Append(AudioRecordingSizeBytes).Append("\n");
            
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            
            sb.Append("  DeletedDate: ").Append(DeletedDate).Append("\n");
            
            sb.Append("  CallerAddress: ").Append(CallerAddress).Append("\n");
            
            sb.Append("  CallerName: ").Append(CallerName).Append("\n");
            
            sb.Append("  CallerUser: ").Append(CallerUser).Append("\n");
            
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            
            sb.Append("  Note: ").Append(Note).Append("\n");
            
            sb.Append("  User: ").Append(User).Append("\n");
            
            sb.Append("  Group: ").Append(Group).Append("\n");
            
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            
            sb.Append("  CopiedFrom: ").Append(CopiedFrom).Append("\n");
            
            sb.Append("  CopiedTo: ").Append(CopiedTo).Append("\n");
            
            sb.Append("  DeleteRetentionPolicy: ").Append(DeleteRetentionPolicy).Append("\n");
            
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
            return this.Equals(obj as VoicemailMessage);
        }

        /// <summary>
        /// Returns true if VoicemailMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of VoicemailMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicemailMessage other)
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
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
                ) &&
                (
                    this.Read == other.Read ||
                    this.Read != null &&
                    this.Read.Equals(other.Read)
                ) &&
                (
                    this.AudioRecordingDurationSeconds == other.AudioRecordingDurationSeconds ||
                    this.AudioRecordingDurationSeconds != null &&
                    this.AudioRecordingDurationSeconds.Equals(other.AudioRecordingDurationSeconds)
                ) &&
                (
                    this.AudioRecordingSizeBytes == other.AudioRecordingSizeBytes ||
                    this.AudioRecordingSizeBytes != null &&
                    this.AudioRecordingSizeBytes.Equals(other.AudioRecordingSizeBytes)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) &&
                (
                    this.DeletedDate == other.DeletedDate ||
                    this.DeletedDate != null &&
                    this.DeletedDate.Equals(other.DeletedDate)
                ) &&
                (
                    this.CallerAddress == other.CallerAddress ||
                    this.CallerAddress != null &&
                    this.CallerAddress.Equals(other.CallerAddress)
                ) &&
                (
                    this.CallerName == other.CallerName ||
                    this.CallerName != null &&
                    this.CallerName.Equals(other.CallerName)
                ) &&
                (
                    this.CallerUser == other.CallerUser ||
                    this.CallerUser != null &&
                    this.CallerUser.Equals(other.CallerUser)
                ) &&
                (
                    this.Deleted == other.Deleted ||
                    this.Deleted != null &&
                    this.Deleted.Equals(other.Deleted)
                ) &&
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.CopiedFrom == other.CopiedFrom ||
                    this.CopiedFrom != null &&
                    this.CopiedFrom.Equals(other.CopiedFrom)
                ) &&
                (
                    this.CopiedTo == other.CopiedTo ||
                    this.CopiedTo != null &&
                    this.CopiedTo.SequenceEqual(other.CopiedTo)
                ) &&
                (
                    this.DeleteRetentionPolicy == other.DeleteRetentionPolicy ||
                    this.DeleteRetentionPolicy != null &&
                    this.DeleteRetentionPolicy.Equals(other.DeleteRetentionPolicy)
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
                
                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();
                
                if (this.Read != null)
                    hash = hash * 59 + this.Read.GetHashCode();
                
                if (this.AudioRecordingDurationSeconds != null)
                    hash = hash * 59 + this.AudioRecordingDurationSeconds.GetHashCode();
                
                if (this.AudioRecordingSizeBytes != null)
                    hash = hash * 59 + this.AudioRecordingSizeBytes.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                
                if (this.DeletedDate != null)
                    hash = hash * 59 + this.DeletedDate.GetHashCode();
                
                if (this.CallerAddress != null)
                    hash = hash * 59 + this.CallerAddress.GetHashCode();
                
                if (this.CallerName != null)
                    hash = hash * 59 + this.CallerName.GetHashCode();
                
                if (this.CallerUser != null)
                    hash = hash * 59 + this.CallerUser.GetHashCode();
                
                if (this.Deleted != null)
                    hash = hash * 59 + this.Deleted.GetHashCode();
                
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
                
                if (this.CopiedFrom != null)
                    hash = hash * 59 + this.CopiedFrom.GetHashCode();
                
                if (this.CopiedTo != null)
                    hash = hash * 59 + this.CopiedTo.GetHashCode();
                
                if (this.DeleteRetentionPolicy != null)
                    hash = hash * 59 + this.DeleteRetentionPolicy.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
