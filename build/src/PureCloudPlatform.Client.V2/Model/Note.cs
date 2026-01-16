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
    /// Note
    /// </summary>
    [DataContract]
    public partial class Note :  IEquatable<Note>
    {
        /// <summary>
        /// This is only need to be set when using Bulk API. Using any other value than contact or organization will result in null being used.
        /// </summary>
        /// <value>This is only need to be set when using Bulk API. Using any other value than contact or organization will result in null being used.</value>
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
            /// Enum Contact for "contact"
            /// </summary>
            [EnumMember(Value = "contact")]
            Contact,
            
            /// <summary>
            /// Enum Organization for "organization"
            /// </summary>
            [EnumMember(Value = "organization")]
            Organization
        }
        /// <summary>
        /// This is only need to be set when using Bulk API. Using any other value than contact or organization will result in null being used.
        /// </summary>
        /// <value>This is only need to be set when using Bulk API. Using any other value than contact or organization will result in null being used.</value>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public EntityTypeEnum? EntityType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Note" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Note() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Note" /> class.
        /// </summary>
        /// <param name="Division">The division to which this entity belongs..</param>
        /// <param name="EntityId">The id of the contact or organization to which this note refers. This only needs to be set for input when using the Bulk APIs..</param>
        /// <param name="EntityType">This is only need to be set when using Bulk API. Using any other value than contact or organization will result in null being used..</param>
        /// <param name="NoteText">Between 1 and 32,000 characters..</param>
        /// <param name="ModifyDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="CreateDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="CreatedBy">When creating or updating a note, only User.id is required. User object is fully populated when expanding a note. (required).</param>
        public Note(WritableStarrableDivision Division = null, string EntityId = null, EntityTypeEnum? EntityType = null, string NoteText = null, DateTime? ModifyDate = null, DateTime? CreateDate = null, User CreatedBy = null)
        {
            this.Division = Division;
            this.EntityId = EntityId;
            this.EntityType = EntityType;
            this.NoteText = NoteText;
            this.ModifyDate = ModifyDate;
            this.CreateDate = CreateDate;
            this.CreatedBy = CreatedBy;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The division to which this entity belongs.
        /// </summary>
        /// <value>The division to which this entity belongs.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public WritableStarrableDivision Division { get; set; }



        /// <summary>
        /// The id of the contact or organization to which this note refers. This only needs to be set for input when using the Bulk APIs.
        /// </summary>
        /// <value>The id of the contact or organization to which this note refers. This only needs to be set for input when using the Bulk APIs.</value>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public string EntityId { get; set; }





        /// <summary>
        /// Between 1 and 32,000 characters.
        /// </summary>
        /// <value>Between 1 and 32,000 characters.</value>
        [DataMember(Name="noteText", EmitDefaultValue=false)]
        public string NoteText { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; set; }



        /// <summary>
        /// When creating or updating a note, only User.id is required. User object is fully populated when expanding a note.
        /// </summary>
        /// <value>When creating or updating a note, only User.id is required. User object is fully populated when expanding a note.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public User CreatedBy { get; set; }



        /// <summary>
        /// Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param.
        /// </summary>
        /// <value>Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param.</value>
        [DataMember(Name="externalDataSources", EmitDefaultValue=false)]
        public List<ExternalDataSource> ExternalDataSources { get; private set; }



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
            sb.Append("class Note {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  NoteText: ").Append(NoteText).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ExternalDataSources: ").Append(ExternalDataSources).Append("\n");
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
            return this.Equals(obj as Note);
        }

        /// <summary>
        /// Returns true if Note instances are equal
        /// </summary>
        /// <param name="other">Instance of Note to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Note other)
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
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
                ) &&
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.ExternalDataSources == other.ExternalDataSources ||
                    this.ExternalDataSources != null &&
                    this.ExternalDataSources.SequenceEqual(other.ExternalDataSources)
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

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.EntityId != null)
                    hash = hash * 59 + this.EntityId.GetHashCode();

                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();

                if (this.NoteText != null)
                    hash = hash * 59 + this.NoteText.GetHashCode();

                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();

                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.ExternalDataSources != null)
                    hash = hash * 59 + this.ExternalDataSources.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
