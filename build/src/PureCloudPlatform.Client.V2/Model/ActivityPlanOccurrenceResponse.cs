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
    /// ActivityPlanOccurrenceResponse
    /// </summary>
    [DataContract]
    public partial class ActivityPlanOccurrenceResponse :  IEquatable<ActivityPlanOccurrenceResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanOccurrenceResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityPlanOccurrenceResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanOccurrenceResponse" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object. (required).</param>
        /// <param name="RunDate">The date the associated activity plan was run, in ISO-8601 format (required).</param>
        /// <param name="SessionDateRange">The dates potentially spanned by the sessions in this occurrence, even if no sessions currently exist (required).</param>
        /// <param name="Facilitated">Whether the run sessions are facilitated (required).</param>
        /// <param name="Edited">Whether this occurrence is edited.</param>
        /// <param name="Violations">The violations for this occurrence.</param>
        /// <param name="Sessions">The sessions scheduled by the run (required).</param>
        /// <param name="UnscheduledAttendees">The attendees who could not be scheduled for this occurrence (required).</param>
        /// <param name="AffectedSchedules">Summaries of the schedules affected by this occurrence (required).</param>
        /// <param name="CreatedBy">The user who started the job which created this occurrence (required).</param>
        public ActivityPlanOccurrenceResponse(string Id = null, DateTime? RunDate = null, RequiredDateRange SessionDateRange = null, bool? Facilitated = null, bool? Edited = null, List<ActivityPlanOccurrenceViolation> Violations = null, List<ActivityPlanOccurrenceSessionWithAttendees> Sessions = null, List<ActivityPlanUnscheduledAttendee> UnscheduledAttendees = null, List<BuScheduleSummary> AffectedSchedules = null, UserReference CreatedBy = null)
        {
            this.Id = Id;
            this.RunDate = RunDate;
            this.SessionDateRange = SessionDateRange;
            this.Facilitated = Facilitated;
            this.Edited = Edited;
            this.Violations = Violations;
            this.Sessions = Sessions;
            this.UnscheduledAttendees = UnscheduledAttendees;
            this.AffectedSchedules = AffectedSchedules;
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
        /// Whether this occurrence is edited
        /// </summary>
        /// <value>Whether this occurrence is edited</value>
        [DataMember(Name="edited", EmitDefaultValue=false)]
        public bool? Edited { get; set; }



        /// <summary>
        /// The violations for this occurrence
        /// </summary>
        /// <value>The violations for this occurrence</value>
        [DataMember(Name="violations", EmitDefaultValue=false)]
        public List<ActivityPlanOccurrenceViolation> Violations { get; set; }



        /// <summary>
        /// The sessions scheduled by the run
        /// </summary>
        /// <value>The sessions scheduled by the run</value>
        [DataMember(Name="sessions", EmitDefaultValue=false)]
        public List<ActivityPlanOccurrenceSessionWithAttendees> Sessions { get; set; }



        /// <summary>
        /// The attendees who could not be scheduled for this occurrence
        /// </summary>
        /// <value>The attendees who could not be scheduled for this occurrence</value>
        [DataMember(Name="unscheduledAttendees", EmitDefaultValue=false)]
        public List<ActivityPlanUnscheduledAttendee> UnscheduledAttendees { get; set; }



        /// <summary>
        /// Summaries of the schedules affected by this occurrence
        /// </summary>
        /// <value>Summaries of the schedules affected by this occurrence</value>
        [DataMember(Name="affectedSchedules", EmitDefaultValue=false)]
        public List<BuScheduleSummary> AffectedSchedules { get; set; }



        /// <summary>
        /// The user who started the job which created this occurrence
        /// </summary>
        /// <value>The user who started the job which created this occurrence</value>
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
            sb.Append("class ActivityPlanOccurrenceResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RunDate: ").Append(RunDate).Append("\n");
            sb.Append("  SessionDateRange: ").Append(SessionDateRange).Append("\n");
            sb.Append("  Facilitated: ").Append(Facilitated).Append("\n");
            sb.Append("  Edited: ").Append(Edited).Append("\n");
            sb.Append("  Violations: ").Append(Violations).Append("\n");
            sb.Append("  Sessions: ").Append(Sessions).Append("\n");
            sb.Append("  UnscheduledAttendees: ").Append(UnscheduledAttendees).Append("\n");
            sb.Append("  AffectedSchedules: ").Append(AffectedSchedules).Append("\n");
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
            return this.Equals(obj as ActivityPlanOccurrenceResponse);
        }

        /// <summary>
        /// Returns true if ActivityPlanOccurrenceResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityPlanOccurrenceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityPlanOccurrenceResponse other)
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
                    this.Edited == other.Edited ||
                    this.Edited != null &&
                    this.Edited.Equals(other.Edited)
                ) &&
                (
                    this.Violations == other.Violations ||
                    this.Violations != null &&
                    this.Violations.SequenceEqual(other.Violations)
                ) &&
                (
                    this.Sessions == other.Sessions ||
                    this.Sessions != null &&
                    this.Sessions.SequenceEqual(other.Sessions)
                ) &&
                (
                    this.UnscheduledAttendees == other.UnscheduledAttendees ||
                    this.UnscheduledAttendees != null &&
                    this.UnscheduledAttendees.SequenceEqual(other.UnscheduledAttendees)
                ) &&
                (
                    this.AffectedSchedules == other.AffectedSchedules ||
                    this.AffectedSchedules != null &&
                    this.AffectedSchedules.SequenceEqual(other.AffectedSchedules)
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

                if (this.Edited != null)
                    hash = hash * 59 + this.Edited.GetHashCode();

                if (this.Violations != null)
                    hash = hash * 59 + this.Violations.GetHashCode();

                if (this.Sessions != null)
                    hash = hash * 59 + this.Sessions.GetHashCode();

                if (this.UnscheduledAttendees != null)
                    hash = hash * 59 + this.UnscheduledAttendees.GetHashCode();

                if (this.AffectedSchedules != null)
                    hash = hash * 59 + this.AffectedSchedules.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
