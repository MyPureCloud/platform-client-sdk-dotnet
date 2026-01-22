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
    /// Update coaching appointment request
    /// </summary>
    [DataContract]
    public partial class UpdateCoachingAppointmentRequest :  IEquatable<UpdateCoachingAppointmentRequest>
    {
        /// <summary>
        /// The status of the coaching appointment.
        /// </summary>
        /// <value>The status of the coaching appointment.</value>
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
            Completed
        }
        /// <summary>
        /// The status of the coaching appointment.
        /// </summary>
        /// <value>The status of the coaching appointment.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCoachingAppointmentRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of coaching appointment..</param>
        /// <param name="Description">The description of coaching appointment..</param>
        /// <param name="DateStart">The date/time the coaching appointment starts. Times will be rounded down to the minute. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="LengthInMinutes">The duration of coaching appointment in minutes..</param>
        /// <param name="ConversationIds">IDs of conversations associated with this coaching appointment..</param>
        /// <param name="DocumentIds">IDs of documents associated with this coaching appointment..</param>
        /// <param name="Status">The status of the coaching appointment..</param>
        /// <param name="WfmSchedule">The Workforce Management schedule the appointment is associated with..</param>
        /// <param name="ExternalLinks">The list of external links related to the appointment.</param>
        /// <param name="Location">The location of the appointment.</param>
        /// <param name="ShareInsightsData">Whether to share the insight data.</param>
        /// <param name="AddToSchedule">If True, adds the appointment to their schedule.</param>
        public UpdateCoachingAppointmentRequest(string Name = null, string Description = null, DateTime? DateStart = null, int? LengthInMinutes = null, List<string> ConversationIds = null, List<string> DocumentIds = null, StatusEnum? Status = null, WfmScheduleReference WfmSchedule = null, List<string> ExternalLinks = null, string Location = null, bool? ShareInsightsData = null, bool? AddToSchedule = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.DateStart = DateStart;
            this.LengthInMinutes = LengthInMinutes;
            this.ConversationIds = ConversationIds;
            this.DocumentIds = DocumentIds;
            this.Status = Status;
            this.WfmSchedule = WfmSchedule;
            this.ExternalLinks = ExternalLinks;
            this.Location = Location;
            this.ShareInsightsData = ShareInsightsData;
            this.AddToSchedule = AddToSchedule;
            
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
        /// The location of the appointment
        /// </summary>
        /// <value>The location of the appointment</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }



        /// <summary>
        /// Whether to share the insight data
        /// </summary>
        /// <value>Whether to share the insight data</value>
        [DataMember(Name="shareInsightsData", EmitDefaultValue=false)]
        public bool? ShareInsightsData { get; set; }



        /// <summary>
        /// If True, adds the appointment to their schedule
        /// </summary>
        /// <value>If True, adds the appointment to their schedule</value>
        [DataMember(Name="addToSchedule", EmitDefaultValue=false)]
        public bool? AddToSchedule { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCoachingAppointmentRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
            sb.Append("  ConversationIds: ").Append(ConversationIds).Append("\n");
            sb.Append("  DocumentIds: ").Append(DocumentIds).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  WfmSchedule: ").Append(WfmSchedule).Append("\n");
            sb.Append("  ExternalLinks: ").Append(ExternalLinks).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  ShareInsightsData: ").Append(ShareInsightsData).Append("\n");
            sb.Append("  AddToSchedule: ").Append(AddToSchedule).Append("\n");
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
            return this.Equals(obj as UpdateCoachingAppointmentRequest);
        }

        /// <summary>
        /// Returns true if UpdateCoachingAppointmentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateCoachingAppointmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCoachingAppointmentRequest other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                ) &&
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) &&
                (
                    this.ShareInsightsData == other.ShareInsightsData ||
                    this.ShareInsightsData != null &&
                    this.ShareInsightsData.Equals(other.ShareInsightsData)
                ) &&
                (
                    this.AddToSchedule == other.AddToSchedule ||
                    this.AddToSchedule != null &&
                    this.AddToSchedule.Equals(other.AddToSchedule)
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

                if (this.ConversationIds != null)
                    hash = hash * 59 + this.ConversationIds.GetHashCode();

                if (this.DocumentIds != null)
                    hash = hash * 59 + this.DocumentIds.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.WfmSchedule != null)
                    hash = hash * 59 + this.WfmSchedule.GetHashCode();

                if (this.ExternalLinks != null)
                    hash = hash * 59 + this.ExternalLinks.GetHashCode();

                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();

                if (this.ShareInsightsData != null)
                    hash = hash * 59 + this.ShareInsightsData.GetHashCode();

                if (this.AddToSchedule != null)
                    hash = hash * 59 + this.AddToSchedule.GetHashCode();

                return hash;
            }
        }
    }

}
