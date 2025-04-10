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
    /// VoicemailMessagesTopicVoicemailMessage
    /// </summary>
    [DataContract]
    public partial class VoicemailMessagesTopicVoicemailMessage :  IEquatable<VoicemailMessagesTopicVoicemailMessage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailMessagesTopicVoicemailMessage" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Read">Read.</param>
        /// <param name="AudioRecordingDurationSeconds">AudioRecordingDurationSeconds.</param>
        /// <param name="AudioRecordingSizeBytes">AudioRecordingSizeBytes.</param>
        /// <param name="CreatedDate">CreatedDate.</param>
        /// <param name="ModifiedDate">ModifiedDate.</param>
        /// <param name="CreatedDateString">CreatedDateString.</param>
        /// <param name="CallerAddress">CallerAddress.</param>
        /// <param name="CallerName">CallerName.</param>
        /// <param name="Action">Action.</param>
        /// <param name="Note">Note.</param>
        /// <param name="Deleted">Deleted.</param>
        /// <param name="ModifiedByUserId">ModifiedByUserId.</param>
        /// <param name="CopiedTo">CopiedTo.</param>
        /// <param name="CopiedFrom">CopiedFrom.</param>
        /// <param name="ModifiedDateString">ModifiedDateString.</param>
        public VoicemailMessagesTopicVoicemailMessage(string Id = null, bool? Read = null, long? AudioRecordingDurationSeconds = null, long? AudioRecordingSizeBytes = null, DateTime? CreatedDate = null, DateTime? ModifiedDate = null, string CreatedDateString = null, string CallerAddress = null, string CallerName = null, string Action = null, string Note = null, bool? Deleted = null, string ModifiedByUserId = null, List<VoicemailMessagesTopicVoicemailCopyRecord> CopiedTo = null, VoicemailMessagesTopicVoicemailCopyRecord CopiedFrom = null, string ModifiedDateString = null)
        {
            this.Id = Id;
            this.Read = Read;
            this.AudioRecordingDurationSeconds = AudioRecordingDurationSeconds;
            this.AudioRecordingSizeBytes = AudioRecordingSizeBytes;
            this.CreatedDate = CreatedDate;
            this.ModifiedDate = ModifiedDate;
            this.CreatedDateString = CreatedDateString;
            this.CallerAddress = CallerAddress;
            this.CallerName = CallerName;
            this.Action = Action;
            this.Note = Note;
            this.Deleted = Deleted;
            this.ModifiedByUserId = ModifiedByUserId;
            this.CopiedTo = CopiedTo;
            this.CopiedFrom = CopiedFrom;
            this.ModifiedDateString = ModifiedDateString;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Read
        /// </summary>
        [DataMember(Name="read", EmitDefaultValue=false)]
        public bool? Read { get; set; }



        /// <summary>
        /// Gets or Sets AudioRecordingDurationSeconds
        /// </summary>
        [DataMember(Name="audioRecordingDurationSeconds", EmitDefaultValue=false)]
        public long? AudioRecordingDurationSeconds { get; set; }



        /// <summary>
        /// Gets or Sets AudioRecordingSizeBytes
        /// </summary>
        [DataMember(Name="audioRecordingSizeBytes", EmitDefaultValue=false)]
        public long? AudioRecordingSizeBytes { get; set; }



        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }



        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }



        /// <summary>
        /// Gets or Sets CreatedDateString
        /// </summary>
        [DataMember(Name="createdDateString", EmitDefaultValue=false)]
        public string CreatedDateString { get; set; }



        /// <summary>
        /// Gets or Sets CallerAddress
        /// </summary>
        [DataMember(Name="callerAddress", EmitDefaultValue=false)]
        public string CallerAddress { get; set; }



        /// <summary>
        /// Gets or Sets CallerName
        /// </summary>
        [DataMember(Name="callerName", EmitDefaultValue=false)]
        public string CallerName { get; set; }



        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }



        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }



        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; set; }



        /// <summary>
        /// Gets or Sets ModifiedByUserId
        /// </summary>
        [DataMember(Name="modifiedByUserId", EmitDefaultValue=false)]
        public string ModifiedByUserId { get; set; }



        /// <summary>
        /// Gets or Sets CopiedTo
        /// </summary>
        [DataMember(Name="copiedTo", EmitDefaultValue=false)]
        public List<VoicemailMessagesTopicVoicemailCopyRecord> CopiedTo { get; set; }



        /// <summary>
        /// Gets or Sets CopiedFrom
        /// </summary>
        [DataMember(Name="copiedFrom", EmitDefaultValue=false)]
        public VoicemailMessagesTopicVoicemailCopyRecord CopiedFrom { get; set; }



        /// <summary>
        /// Gets or Sets ModifiedDateString
        /// </summary>
        [DataMember(Name="modifiedDateString", EmitDefaultValue=false)]
        public string ModifiedDateString { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicemailMessagesTopicVoicemailMessage {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  AudioRecordingDurationSeconds: ").Append(AudioRecordingDurationSeconds).Append("\n");
            sb.Append("  AudioRecordingSizeBytes: ").Append(AudioRecordingSizeBytes).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CreatedDateString: ").Append(CreatedDateString).Append("\n");
            sb.Append("  CallerAddress: ").Append(CallerAddress).Append("\n");
            sb.Append("  CallerName: ").Append(CallerName).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  ModifiedByUserId: ").Append(ModifiedByUserId).Append("\n");
            sb.Append("  CopiedTo: ").Append(CopiedTo).Append("\n");
            sb.Append("  CopiedFrom: ").Append(CopiedFrom).Append("\n");
            sb.Append("  ModifiedDateString: ").Append(ModifiedDateString).Append("\n");
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
            return this.Equals(obj as VoicemailMessagesTopicVoicemailMessage);
        }

        /// <summary>
        /// Returns true if VoicemailMessagesTopicVoicemailMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of VoicemailMessagesTopicVoicemailMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicemailMessagesTopicVoicemailMessage other)
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
                    this.CreatedDateString == other.CreatedDateString ||
                    this.CreatedDateString != null &&
                    this.CreatedDateString.Equals(other.CreatedDateString)
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
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) &&
                (
                    this.Deleted == other.Deleted ||
                    this.Deleted != null &&
                    this.Deleted.Equals(other.Deleted)
                ) &&
                (
                    this.ModifiedByUserId == other.ModifiedByUserId ||
                    this.ModifiedByUserId != null &&
                    this.ModifiedByUserId.Equals(other.ModifiedByUserId)
                ) &&
                (
                    this.CopiedTo == other.CopiedTo ||
                    this.CopiedTo != null &&
                    this.CopiedTo.SequenceEqual(other.CopiedTo)
                ) &&
                (
                    this.CopiedFrom == other.CopiedFrom ||
                    this.CopiedFrom != null &&
                    this.CopiedFrom.Equals(other.CopiedFrom)
                ) &&
                (
                    this.ModifiedDateString == other.ModifiedDateString ||
                    this.ModifiedDateString != null &&
                    this.ModifiedDateString.Equals(other.ModifiedDateString)
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

                if (this.CreatedDateString != null)
                    hash = hash * 59 + this.CreatedDateString.GetHashCode();

                if (this.CallerAddress != null)
                    hash = hash * 59 + this.CallerAddress.GetHashCode();

                if (this.CallerName != null)
                    hash = hash * 59 + this.CallerName.GetHashCode();

                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();

                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();

                if (this.Deleted != null)
                    hash = hash * 59 + this.Deleted.GetHashCode();

                if (this.ModifiedByUserId != null)
                    hash = hash * 59 + this.ModifiedByUserId.GetHashCode();

                if (this.CopiedTo != null)
                    hash = hash * 59 + this.CopiedTo.GetHashCode();

                if (this.CopiedFrom != null)
                    hash = hash * 59 + this.CopiedFrom.GetHashCode();

                if (this.ModifiedDateString != null)
                    hash = hash * 59 + this.ModifiedDateString.GetHashCode();

                return hash;
            }
        }
    }

}
