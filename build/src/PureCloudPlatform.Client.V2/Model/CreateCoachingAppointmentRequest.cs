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
    /// Create coaching appointment request
    /// </summary>
    [DataContract]
    public partial class CreateCoachingAppointmentRequest :  IEquatable<CreateCoachingAppointmentRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCoachingAppointmentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCoachingAppointmentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCoachingAppointmentRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of coaching appointment. (required).</param>
        /// <param name="Description">The description of coaching appointment. (required).</param>
        /// <param name="DateStart">The date/time the coaching appointment starts. Times will be rounded down to the minute. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="LengthInMinutes">The duration of coaching appointment in minutes. (required).</param>
        /// <param name="FacilitatorId">The facilitator ID of coaching appointment..</param>
        /// <param name="AttendeeIds">IDs of attendees in the coaching appointment. (required).</param>
        /// <param name="ConversationIds">IDs of conversations associated with this coaching appointment..</param>
        /// <param name="DocumentIds">IDs of documents associated with this coaching appointment..</param>
        /// <param name="WfmSchedule">The Workforce Management schedule the appointment is associated with..</param>
        /// <param name="ExternalLinks">The list of external links related to the appointment.</param>
        public CreateCoachingAppointmentRequest(string Name = null, string Description = null, DateTime? DateStart = null, int? LengthInMinutes = null, string FacilitatorId = null, List<string> AttendeeIds = null, List<string> ConversationIds = null, List<string> DocumentIds = null, WfmScheduleReference WfmSchedule = null, List<string> ExternalLinks = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.DateStart = DateStart;
            this.LengthInMinutes = LengthInMinutes;
            this.FacilitatorId = FacilitatorId;
            this.AttendeeIds = AttendeeIds;
            this.ConversationIds = ConversationIds;
            this.DocumentIds = DocumentIds;
            this.WfmSchedule = WfmSchedule;
            this.ExternalLinks = ExternalLinks;
            
        }
        


        /// <summary>
        /// The name of coaching appointment.
        /// </summary>
        /// <value>The name of coaching appointment.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The description of coaching appointment.
        /// </summary>
        /// <value>The description of coaching appointment.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The date/time the coaching appointment starts. Times will be rounded down to the minute. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date/time the coaching appointment starts. Times will be rounded down to the minute. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public DateTime? DateStart { get; set; }



        /// <summary>
        /// The duration of coaching appointment in minutes.
        /// </summary>
        /// <value>The duration of coaching appointment in minutes.</value>
        [DataMember(Name="lengthInMinutes", EmitDefaultValue=false)]
        public int? LengthInMinutes { get; set; }



        /// <summary>
        /// The facilitator ID of coaching appointment.
        /// </summary>
        /// <value>The facilitator ID of coaching appointment.</value>
        [DataMember(Name="facilitatorId", EmitDefaultValue=false)]
        public string FacilitatorId { get; set; }



        /// <summary>
        /// IDs of attendees in the coaching appointment.
        /// </summary>
        /// <value>IDs of attendees in the coaching appointment.</value>
        [DataMember(Name="attendeeIds", EmitDefaultValue=false)]
        public List<string> AttendeeIds { get; set; }



        /// <summary>
        /// IDs of conversations associated with this coaching appointment.
        /// </summary>
        /// <value>IDs of conversations associated with this coaching appointment.</value>
        [DataMember(Name="conversationIds", EmitDefaultValue=false)]
        public List<string> ConversationIds { get; set; }



        /// <summary>
        /// IDs of documents associated with this coaching appointment.
        /// </summary>
        /// <value>IDs of documents associated with this coaching appointment.</value>
        [DataMember(Name="documentIds", EmitDefaultValue=false)]
        public List<string> DocumentIds { get; set; }



        /// <summary>
        /// The Workforce Management schedule the appointment is associated with.
        /// </summary>
        /// <value>The Workforce Management schedule the appointment is associated with.</value>
        [DataMember(Name="wfmSchedule", EmitDefaultValue=false)]
        public WfmScheduleReference WfmSchedule { get; set; }



        /// <summary>
        /// The list of external links related to the appointment
        /// </summary>
        /// <value>The list of external links related to the appointment</value>
        [DataMember(Name="externalLinks", EmitDefaultValue=false)]
        public List<string> ExternalLinks { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCoachingAppointmentRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
            sb.Append("  FacilitatorId: ").Append(FacilitatorId).Append("\n");
            sb.Append("  AttendeeIds: ").Append(AttendeeIds).Append("\n");
            sb.Append("  ConversationIds: ").Append(ConversationIds).Append("\n");
            sb.Append("  DocumentIds: ").Append(DocumentIds).Append("\n");
            sb.Append("  WfmSchedule: ").Append(WfmSchedule).Append("\n");
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
            return this.Equals(obj as CreateCoachingAppointmentRequest);
        }

        /// <summary>
        /// Returns true if CreateCoachingAppointmentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCoachingAppointmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCoachingAppointmentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                    this.FacilitatorId == other.FacilitatorId ||
                    this.FacilitatorId != null &&
                    this.FacilitatorId.Equals(other.FacilitatorId)
                ) &&
                (
                    this.AttendeeIds == other.AttendeeIds ||
                    this.AttendeeIds != null &&
                    this.AttendeeIds.SequenceEqual(other.AttendeeIds)
                ) &&
                (
                    this.ConversationIds == other.ConversationIds ||
                    this.ConversationIds != null &&
                    this.ConversationIds.SequenceEqual(other.ConversationIds)
                ) &&
                (
                    this.DocumentIds == other.DocumentIds ||
                    this.DocumentIds != null &&
                    this.DocumentIds.SequenceEqual(other.DocumentIds)
                ) &&
                (
                    this.WfmSchedule == other.WfmSchedule ||
                    this.WfmSchedule != null &&
                    this.WfmSchedule.Equals(other.WfmSchedule)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();

                if (this.LengthInMinutes != null)
                    hash = hash * 59 + this.LengthInMinutes.GetHashCode();

                if (this.FacilitatorId != null)
                    hash = hash * 59 + this.FacilitatorId.GetHashCode();

                if (this.AttendeeIds != null)
                    hash = hash * 59 + this.AttendeeIds.GetHashCode();

                if (this.ConversationIds != null)
                    hash = hash * 59 + this.ConversationIds.GetHashCode();

                if (this.DocumentIds != null)
                    hash = hash * 59 + this.DocumentIds.GetHashCode();

                if (this.WfmSchedule != null)
                    hash = hash * 59 + this.WfmSchedule.GetHashCode();

                if (this.ExternalLinks != null)
                    hash = hash * 59 + this.ExternalLinks.GetHashCode();

                return hash;
            }
        }
    }

}
