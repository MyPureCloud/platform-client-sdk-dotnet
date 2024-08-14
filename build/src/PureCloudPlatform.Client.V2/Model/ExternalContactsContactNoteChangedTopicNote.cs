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
    /// ExternalContactsContactNoteChangedTopicNote
    /// </summary>
    [DataContract]
    public partial class ExternalContactsContactNoteChangedTopicNote :  IEquatable<ExternalContactsContactNoteChangedTopicNote>
    {
        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
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
            /// Enum Contact for "Contact"
            /// </summary>
            [EnumMember(Value = "Contact")]
            Contact,
            
            /// <summary>
            /// Enum Organization for "Organization"
            /// </summary>
            [EnumMember(Value = "Organization")]
            Organization
        }
        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public EntityTypeEnum? EntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalContactsContactNoteChangedTopicNote" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Division">Division.</param>
        /// <param name="EntityId">EntityId.</param>
        /// <param name="EntityType">EntityType.</param>
        /// <param name="NoteText">NoteText.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="CreateDate">CreateDate.</param>
        /// <param name="ModifyDate">ModifyDate.</param>
        public ExternalContactsContactNoteChangedTopicNote(string Id = null, ExternalContactsContactNoteChangedTopicDivision Division = null, string EntityId = null, EntityTypeEnum? EntityType = null, string NoteText = null, ExternalContactsContactNoteChangedTopicUser CreatedBy = null, DateTime? CreateDate = null, DateTime? ModifyDate = null)
        {
            this.Id = Id;
            this.Division = Division;
            this.EntityId = EntityId;
            this.EntityType = EntityType;
            this.NoteText = NoteText;
            this.CreatedBy = CreatedBy;
            this.CreateDate = CreateDate;
            this.ModifyDate = ModifyDate;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public ExternalContactsContactNoteChangedTopicDivision Division { get; set; }



        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public string EntityId { get; set; }





        /// <summary>
        /// Gets or Sets NoteText
        /// </summary>
        [DataMember(Name="noteText", EmitDefaultValue=false)]
        public string NoteText { get; set; }



        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public ExternalContactsContactNoteChangedTopicUser CreatedBy { get; set; }



        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; set; }



        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalContactsContactNoteChangedTopicNote {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  NoteText: ").Append(NoteText).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
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
            return this.Equals(obj as ExternalContactsContactNoteChangedTopicNote);
        }

        /// <summary>
        /// Returns true if ExternalContactsContactNoteChangedTopicNote instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalContactsContactNoteChangedTopicNote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalContactsContactNoteChangedTopicNote other)
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
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.EntityId == other.EntityId ||
                    this.EntityId != null &&
                    this.EntityId.Equals(other.EntityId)
                ) &&
                (
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
                ) &&
                (
                    this.NoteText == other.NoteText ||
                    this.NoteText != null &&
                    this.NoteText.Equals(other.NoteText)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) &&
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
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

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.EntityId != null)
                    hash = hash * 59 + this.EntityId.GetHashCode();

                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();

                if (this.NoteText != null)
                    hash = hash * 59 + this.NoteText.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();

                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();

                return hash;
            }
        }
    }

}
