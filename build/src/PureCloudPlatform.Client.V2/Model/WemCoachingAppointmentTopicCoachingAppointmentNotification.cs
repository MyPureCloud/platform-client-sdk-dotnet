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
    /// WemCoachingAppointmentTopicCoachingAppointmentNotification
    /// </summary>
    [DataContract]
    public partial class WemCoachingAppointmentTopicCoachingAppointmentNotification :  IEquatable<WemCoachingAppointmentTopicCoachingAppointmentNotification>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
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
            /// Enum Scheduled for "Scheduled"
            /// </summary>
            [EnumMember(Value = "Scheduled")]
            Scheduled,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Invalidschedule for "InvalidSchedule"
            /// </summary>
            [EnumMember(Value = "InvalidSchedule")]
            Invalidschedule
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ChangeType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ChangeTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
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
            /// Enum Invalidate for "Invalidate"
            /// </summary>
            [EnumMember(Value = "Invalidate")]
            Invalidate
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ChangeType
        /// </summary>
        [DataMember(Name="changeType", EmitDefaultValue=false)]
        public ChangeTypeEnum? ChangeType { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WemCoachingAppointmentTopicCoachingAppointmentNotification" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="DateStart">DateStart.</param>
        /// <param name="LengthInMinutes">LengthInMinutes.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Facilitator">Facilitator.</param>
        /// <param name="Attendees">Attendees.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="DateCreated">DateCreated.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="DateModified">DateModified.</param>
        /// <param name="Conversations">Conversations.</param>
        /// <param name="Documents">Documents.</param>
        /// <param name="ChangeType">ChangeType.</param>
        /// <param name="DateCompleted">DateCompleted.</param>
        /// <param name="ExternalLinks">ExternalLinks.</param>
        public WemCoachingAppointmentTopicCoachingAppointmentNotification(string Id = null, string Name = null, DateTime? DateStart = null, int? LengthInMinutes = null, StatusEnum? Status = null, WemCoachingAppointmentTopicUserReference Facilitator = null, List<WemCoachingAppointmentTopicUserReference> Attendees = null, WemCoachingAppointmentTopicUserReference CreatedBy = null, DateTime? DateCreated = null, WemCoachingAppointmentTopicUserReference ModifiedBy = null, DateTime? DateModified = null, List<WemCoachingAppointmentTopicCoachingAppointmentConversation> Conversations = null, List<WemCoachingAppointmentTopicCoachingAppointmentDocument> Documents = null, ChangeTypeEnum? ChangeType = null, DateTime? DateCompleted = null, List<WemCoachingAppointmentTopicCoachingAppointmentExternalLink> ExternalLinks = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.DateStart = DateStart;
            this.LengthInMinutes = LengthInMinutes;
            this.Status = Status;
            this.Facilitator = Facilitator;
            this.Attendees = Attendees;
            this.CreatedBy = CreatedBy;
            this.DateCreated = DateCreated;
            this.ModifiedBy = ModifiedBy;
            this.DateModified = DateModified;
            this.Conversations = Conversations;
            this.Documents = Documents;
            this.ChangeType = ChangeType;
            this.DateCompleted = DateCompleted;
            this.ExternalLinks = ExternalLinks;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateStart
        /// </summary>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public DateTime? DateStart { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets LengthInMinutes
        /// </summary>
        [DataMember(Name="lengthInMinutes", EmitDefaultValue=false)]
        public int? LengthInMinutes { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Facilitator
        /// </summary>
        [DataMember(Name="facilitator", EmitDefaultValue=false)]
        public WemCoachingAppointmentTopicUserReference Facilitator { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Attendees
        /// </summary>
        [DataMember(Name="attendees", EmitDefaultValue=false)]
        public List<WemCoachingAppointmentTopicUserReference> Attendees { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public WemCoachingAppointmentTopicUserReference CreatedBy { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public WemCoachingAppointmentTopicUserReference ModifiedBy { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateModified
        /// </summary>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Conversations
        /// </summary>
        [DataMember(Name="conversations", EmitDefaultValue=false)]
        public List<WemCoachingAppointmentTopicCoachingAppointmentConversation> Conversations { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Documents
        /// </summary>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        public List<WemCoachingAppointmentTopicCoachingAppointmentDocument> Documents { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets DateCompleted
        /// </summary>
        [DataMember(Name="dateCompleted", EmitDefaultValue=false)]
        public DateTime? DateCompleted { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ExternalLinks
        /// </summary>
        [DataMember(Name="externalLinks", EmitDefaultValue=false)]
        public List<WemCoachingAppointmentTopicCoachingAppointmentExternalLink> ExternalLinks { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WemCoachingAppointmentTopicCoachingAppointmentNotification {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Facilitator: ").Append(Facilitator).Append("\n");
            sb.Append("  Attendees: ").Append(Attendees).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Conversations: ").Append(Conversations).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  ChangeType: ").Append(ChangeType).Append("\n");
            sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
            sb.Append("  ExternalLinks: ").Append(ExternalLinks).Append("\n");
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
            return this.Equals(obj as WemCoachingAppointmentTopicCoachingAppointmentNotification);
        }

        /// <summary>
        /// Returns true if WemCoachingAppointmentTopicCoachingAppointmentNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of WemCoachingAppointmentTopicCoachingAppointmentNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WemCoachingAppointmentTopicCoachingAppointmentNotification other)
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
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
                ) &&
                (
                    this.LengthInMinutes == other.LengthInMinutes ||
                    this.LengthInMinutes != null &&
                    this.LengthInMinutes.Equals(other.LengthInMinutes)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Facilitator == other.Facilitator ||
                    this.Facilitator != null &&
                    this.Facilitator.Equals(other.Facilitator)
                ) &&
                (
                    this.Attendees == other.Attendees ||
                    this.Attendees != null &&
                    this.Attendees.SequenceEqual(other.Attendees)
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
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.Conversations == other.Conversations ||
                    this.Conversations != null &&
                    this.Conversations.SequenceEqual(other.Conversations)
                ) &&
                (
                    this.Documents == other.Documents ||
                    this.Documents != null &&
                    this.Documents.SequenceEqual(other.Documents)
                ) &&
                (
                    this.ChangeType == other.ChangeType ||
                    this.ChangeType != null &&
                    this.ChangeType.Equals(other.ChangeType)
                ) &&
                (
                    this.DateCompleted == other.DateCompleted ||
                    this.DateCompleted != null &&
                    this.DateCompleted.Equals(other.DateCompleted)
                ) &&
                (
                    this.ExternalLinks == other.ExternalLinks ||
                    this.ExternalLinks != null &&
                    this.ExternalLinks.SequenceEqual(other.ExternalLinks)
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
                
                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();
                
                if (this.LengthInMinutes != null)
                    hash = hash * 59 + this.LengthInMinutes.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Facilitator != null)
                    hash = hash * 59 + this.Facilitator.GetHashCode();
                
                if (this.Attendees != null)
                    hash = hash * 59 + this.Attendees.GetHashCode();
                
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.Conversations != null)
                    hash = hash * 59 + this.Conversations.GetHashCode();
                
                if (this.Documents != null)
                    hash = hash * 59 + this.Documents.GetHashCode();
                
                if (this.ChangeType != null)
                    hash = hash * 59 + this.ChangeType.GetHashCode();
                
                if (this.DateCompleted != null)
                    hash = hash * 59 + this.DateCompleted.GetHashCode();
                
                if (this.ExternalLinks != null)
                    hash = hash * 59 + this.ExternalLinks.GetHashCode();
                
                return hash;
            }
        }
    }

}
