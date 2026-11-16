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
    /// ActivityPlanOccurrenceListItem
    /// </summary>
    [DataContract]
    public partial class ActivityPlanOccurrenceListItem :  IEquatable<ActivityPlanOccurrenceListItem>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanOccurrenceListItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityPlanOccurrenceListItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanOccurrenceListItem" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object. (required).</param>
        /// <param name="RunDate">The date the associated activity plan was run, in ISO-8601 format (required).</param>
        /// <param name="SessionDateRange">The dates potentially spanned by the sessions in this occurrence, even if no sessions currently exist (required).</param>
        /// <param name="Facilitated">Whether the run sessions are facilitated (required).</param>
        /// <param name="SessionCount">The number of sessions that were scheduled (required).</param>
        /// <param name="ScheduledAttendeesCount">The number of attendees that were scheduled for this occurrence (required).</param>
        /// <param name="UnscheduledAttendeesCount">The number of attendees that were unable to be scheduled for this occurrence (required).</param>
        /// <param name="Edited">Whether this occurrence is edited.</param>
        /// <param name="ViolationCount">The number of violations for this occurrence.</param>
        /// <param name="AffectedScheduleIndexes">The index of the affected schedule summary in the schedules list (required).</param>
        /// <param name="CreatedBy">The user who started the job which created this occurrence. The id may be &#39;System&#39; if it was an automated process (required).</param>
        public ActivityPlanOccurrenceListItem(string Id = null, DateTime? RunDate = null, RequiredDateRange SessionDateRange = null, bool? Facilitated = null, int? SessionCount = null, int? ScheduledAttendeesCount = null, int? UnscheduledAttendeesCount = null, bool? Edited = null, int? ViolationCount = null, List<int?> AffectedScheduleIndexes = null, UserReference CreatedBy = null)
        {
            this.Id = Id;
            this.RunDate = RunDate;
            this.SessionDateRange = SessionDateRange;
            this.Facilitated = Facilitated;
            this.SessionCount = SessionCount;
            this.ScheduledAttendeesCount = ScheduledAttendeesCount;
            this.UnscheduledAttendeesCount = UnscheduledAttendeesCount;
            this.Edited = Edited;
            this.ViolationCount = ViolationCount;
            this.AffectedScheduleIndexes = AffectedScheduleIndexes;
            this.CreatedBy = CreatedBy;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The date the associated activity plan was run, in ISO-8601 format
        /// </summary>
        /// <value>The date the associated activity plan was run, in ISO-8601 format</value>
        [DataMember(Name="runDate", EmitDefaultValue=false)]
        public DateTime? RunDate { get; set; }



        /// <summary>
        /// The dates potentially spanned by the sessions in this occurrence, even if no sessions currently exist
        /// </summary>
        /// <value>The dates potentially spanned by the sessions in this occurrence, even if no sessions currently exist</value>
        [DataMember(Name="sessionDateRange", EmitDefaultValue=false)]
        public RequiredDateRange SessionDateRange { get; set; }



        /// <summary>
        /// Whether the run sessions are facilitated
        /// </summary>
        /// <value>Whether the run sessions are facilitated</value>
        [DataMember(Name="facilitated", EmitDefaultValue=false)]
        public bool? Facilitated { get; set; }



        /// <summary>
        /// The number of sessions that were scheduled
        /// </summary>
        /// <value>The number of sessions that were scheduled</value>
        [DataMember(Name="sessionCount", EmitDefaultValue=false)]
        public int? SessionCount { get; set; }



        /// <summary>
        /// The number of attendees that were scheduled for this occurrence
        /// </summary>
        /// <value>The number of attendees that were scheduled for this occurrence</value>
        [DataMember(Name="scheduledAttendeesCount", EmitDefaultValue=false)]
        public int? ScheduledAttendeesCount { get; set; }



        /// <summary>
        /// The number of attendees that were unable to be scheduled for this occurrence
        /// </summary>
        /// <value>The number of attendees that were unable to be scheduled for this occurrence</value>
        [DataMember(Name="unscheduledAttendeesCount", EmitDefaultValue=false)]
        public int? UnscheduledAttendeesCount { get; set; }



        /// <summary>
        /// Whether this occurrence is edited
        /// </summary>
        /// <value>Whether this occurrence is edited</value>
        [DataMember(Name="edited", EmitDefaultValue=false)]
        public bool? Edited { get; set; }



        /// <summary>
        /// The number of violations for this occurrence
        /// </summary>
        /// <value>The number of violations for this occurrence</value>
        [DataMember(Name="violationCount", EmitDefaultValue=false)]
        public int? ViolationCount { get; set; }



        /// <summary>
        /// The index of the affected schedule summary in the schedules list
        /// </summary>
        /// <value>The index of the affected schedule summary in the schedules list</value>
        [DataMember(Name="affectedScheduleIndexes", EmitDefaultValue=false)]
        public List<int?> AffectedScheduleIndexes { get; set; }



        /// <summary>
        /// The user who started the job which created this occurrence. The id may be &#39;System&#39; if it was an automated process
        /// </summary>
        /// <value>The user who started the job which created this occurrence. The id may be &#39;System&#39; if it was an automated process</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public UserReference CreatedBy { get; set; }



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
            sb.Append("class ActivityPlanOccurrenceListItem {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RunDate: ").Append(RunDate).Append("\n");
            sb.Append("  SessionDateRange: ").Append(SessionDateRange).Append("\n");
            sb.Append("  Facilitated: ").Append(Facilitated).Append("\n");
            sb.Append("  SessionCount: ").Append(SessionCount).Append("\n");
            sb.Append("  ScheduledAttendeesCount: ").Append(ScheduledAttendeesCount).Append("\n");
            sb.Append("  UnscheduledAttendeesCount: ").Append(UnscheduledAttendeesCount).Append("\n");
            sb.Append("  Edited: ").Append(Edited).Append("\n");
            sb.Append("  ViolationCount: ").Append(ViolationCount).Append("\n");
            sb.Append("  AffectedScheduleIndexes: ").Append(AffectedScheduleIndexes).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
            return this.Equals(obj as ActivityPlanOccurrenceListItem);
        }

        /// <summary>
        /// Returns true if ActivityPlanOccurrenceListItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityPlanOccurrenceListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityPlanOccurrenceListItem other)
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
                    this.RunDate == other.RunDate ||
                    this.RunDate != null &&
                    this.RunDate.Equals(other.RunDate)
                ) &&
                (
                    this.SessionDateRange == other.SessionDateRange ||
                    this.SessionDateRange != null &&
                    this.SessionDateRange.Equals(other.SessionDateRange)
                ) &&
                (
                    this.Facilitated == other.Facilitated ||
                    this.Facilitated != null &&
                    this.Facilitated.Equals(other.Facilitated)
                ) &&
                (
                    this.SessionCount == other.SessionCount ||
                    this.SessionCount != null &&
                    this.SessionCount.Equals(other.SessionCount)
                ) &&
                (
                    this.ScheduledAttendeesCount == other.ScheduledAttendeesCount ||
                    this.ScheduledAttendeesCount != null &&
                    this.ScheduledAttendeesCount.Equals(other.ScheduledAttendeesCount)
                ) &&
                (
                    this.UnscheduledAttendeesCount == other.UnscheduledAttendeesCount ||
                    this.UnscheduledAttendeesCount != null &&
                    this.UnscheduledAttendeesCount.Equals(other.UnscheduledAttendeesCount)
                ) &&
                (
                    this.Edited == other.Edited ||
                    this.Edited != null &&
                    this.Edited.Equals(other.Edited)
                ) &&
                (
                    this.ViolationCount == other.ViolationCount ||
                    this.ViolationCount != null &&
                    this.ViolationCount.Equals(other.ViolationCount)
                ) &&
                (
                    this.AffectedScheduleIndexes == other.AffectedScheduleIndexes ||
                    this.AffectedScheduleIndexes != null &&
                    this.AffectedScheduleIndexes.SequenceEqual(other.AffectedScheduleIndexes)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
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

                if (this.RunDate != null)
                    hash = hash * 59 + this.RunDate.GetHashCode();

                if (this.SessionDateRange != null)
                    hash = hash * 59 + this.SessionDateRange.GetHashCode();

                if (this.Facilitated != null)
                    hash = hash * 59 + this.Facilitated.GetHashCode();

                if (this.SessionCount != null)
                    hash = hash * 59 + this.SessionCount.GetHashCode();

                if (this.ScheduledAttendeesCount != null)
                    hash = hash * 59 + this.ScheduledAttendeesCount.GetHashCode();

                if (this.UnscheduledAttendeesCount != null)
                    hash = hash * 59 + this.UnscheduledAttendeesCount.GetHashCode();

                if (this.Edited != null)
                    hash = hash * 59 + this.Edited.GetHashCode();

                if (this.ViolationCount != null)
                    hash = hash * 59 + this.ViolationCount.GetHashCode();

                if (this.AffectedScheduleIndexes != null)
                    hash = hash * 59 + this.AffectedScheduleIndexes.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
