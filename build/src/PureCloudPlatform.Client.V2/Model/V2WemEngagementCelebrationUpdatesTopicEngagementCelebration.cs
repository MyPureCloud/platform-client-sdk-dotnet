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
    /// V2WemEngagementCelebrationUpdatesTopicEngagementCelebration
    /// </summary>
    [DataContract]
    public partial class V2WemEngagementCelebrationUpdatesTopicEngagementCelebration :  IEquatable<V2WemEngagementCelebrationUpdatesTopicEngagementCelebration>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum Recognition for "RECOGNITION"
            /// </summary>
            [EnumMember(Value = "RECOGNITION")]
            Recognition,
            
            /// <summary>
            /// Enum ContestComplete for "CONTEST_COMPLETE"
            /// </summary>
            [EnumMember(Value = "CONTEST_COMPLETE")]
            ContestComplete
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2WemEngagementCelebrationUpdatesTopicEngagementCelebration" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Recipient">Recipient.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="DateCreated">DateCreated.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Note">Note.</param>
        /// <param name="SourceEntity">SourceEntity.</param>
        public V2WemEngagementCelebrationUpdatesTopicEngagementCelebration(Guid? Id = null, V2WemEngagementCelebrationUpdatesTopicUserId Recipient = null, V2WemEngagementCelebrationUpdatesTopicUserId CreatedBy = null, string DateCreated = null, TypeEnum? Type = null, string Title = null, string Note = null, V2WemEngagementCelebrationUpdatesTopicSourceEntity SourceEntity = null)
        {
            this.Id = Id;
            this.Recipient = Recipient;
            this.CreatedBy = CreatedBy;
            this.DateCreated = DateCreated;
            this.Type = Type;
            this.Title = Title;
            this.Note = Note;
            this.SourceEntity = SourceEntity;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }



        /// <summary>
        /// Gets or Sets Recipient
        /// </summary>
        [DataMember(Name="recipient", EmitDefaultValue=false)]
        public V2WemEngagementCelebrationUpdatesTopicUserId Recipient { get; set; }



        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public V2WemEngagementCelebrationUpdatesTopicUserId CreatedBy { get; set; }



        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public string DateCreated { get; set; }





        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }



        /// <summary>
        /// Gets or Sets SourceEntity
        /// </summary>
        [DataMember(Name="sourceEntity", EmitDefaultValue=false)]
        public V2WemEngagementCelebrationUpdatesTopicSourceEntity SourceEntity { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2WemEngagementCelebrationUpdatesTopicEngagementCelebration {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  SourceEntity: ").Append(SourceEntity).Append("\n");
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
            return this.Equals(obj as V2WemEngagementCelebrationUpdatesTopicEngagementCelebration);
        }

        /// <summary>
        /// Returns true if V2WemEngagementCelebrationUpdatesTopicEngagementCelebration instances are equal
        /// </summary>
        /// <param name="other">Instance of V2WemEngagementCelebrationUpdatesTopicEngagementCelebration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2WemEngagementCelebrationUpdatesTopicEngagementCelebration other)
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
                    this.Recipient == other.Recipient ||
                    this.Recipient != null &&
                    this.Recipient.Equals(other.Recipient)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) &&
                (
                    this.SourceEntity == other.SourceEntity ||
                    this.SourceEntity != null &&
                    this.SourceEntity.Equals(other.SourceEntity)
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

                if (this.Recipient != null)
                    hash = hash * 59 + this.Recipient.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();

                if (this.SourceEntity != null)
                    hash = hash * 59 + this.SourceEntity.GetHashCode();

                return hash;
            }
        }
    }

}
