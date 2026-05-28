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
    /// QueryEnrollmentOpportunityResult
    /// </summary>
    [DataContract]
    public partial class QueryEnrollmentOpportunityResult :  IEquatable<QueryEnrollmentOpportunityResult>
    {
        /// <summary>
        /// The current status of the opportunity
        /// </summary>
        /// <value>The current status of the opportunity</value>
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
            /// Enum Draft for "Draft"
            /// </summary>
            [EnumMember(Value = "Draft")]
            Draft,
            
            /// <summary>
            /// Enum Published for "Published"
            /// </summary>
            [EnumMember(Value = "Published")]
            Published,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Closed for "Closed"
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed
        }
        /// <summary>
        /// The current status of the opportunity
        /// </summary>
        /// <value>The current status of the opportunity</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryEnrollmentOpportunityResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryEnrollmentOpportunityResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryEnrollmentOpportunityResult" /> class.
        /// </summary>
        /// <param name="Name">The name of the opportunity (required).</param>
        /// <param name="ActivityCodeId">The ID of the activity code associated with the opportunity (required).</param>
        /// <param name="StartDate">The start date and time of the opportunity in ISO-8601 format (required).</param>
        /// <param name="EndDate">The end date and time of the opportunity in ISO-8601 format (required).</param>
        /// <param name="DeadlineDate">The deadline date and time for enrollment in the opportunity in ISO-8601 format (required).</param>
        /// <param name="Status">The current status of the opportunity (required).</param>
        /// <param name="Capacity">The maximum capacity (enrollment slots) for this opportunity (required).</param>
        /// <param name="EnrollmentCounts">The counts for enrollment statuses (required).</param>
        public QueryEnrollmentOpportunityResult(string Name = null, string ActivityCodeId = null, DateTime? StartDate = null, DateTime? EndDate = null, DateTime? DeadlineDate = null, StatusEnum? Status = null, int? Capacity = null, PendingAndApprovedOpportunityEnrollmentCounts EnrollmentCounts = null)
        {
            this.Name = Name;
            this.ActivityCodeId = ActivityCodeId;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.DeadlineDate = DeadlineDate;
            this.Status = Status;
            this.Capacity = Capacity;
            this.EnrollmentCounts = EnrollmentCounts;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the opportunity
        /// </summary>
        /// <value>The name of the opportunity</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The ID of the activity code associated with the opportunity
        /// </summary>
        /// <value>The ID of the activity code associated with the opportunity</value>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }



        /// <summary>
        /// The start date and time of the opportunity in ISO-8601 format
        /// </summary>
        /// <value>The start date and time of the opportunity in ISO-8601 format</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// The end date and time of the opportunity in ISO-8601 format
        /// </summary>
        /// <value>The end date and time of the opportunity in ISO-8601 format</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }



        /// <summary>
        /// The deadline date and time for enrollment in the opportunity in ISO-8601 format
        /// </summary>
        /// <value>The deadline date and time for enrollment in the opportunity in ISO-8601 format</value>
        [DataMember(Name="deadlineDate", EmitDefaultValue=false)]
        public DateTime? DeadlineDate { get; set; }





        /// <summary>
        /// The maximum capacity (enrollment slots) for this opportunity
        /// </summary>
        /// <value>The maximum capacity (enrollment slots) for this opportunity</value>
        [DataMember(Name="capacity", EmitDefaultValue=false)]
        public int? Capacity { get; set; }



        /// <summary>
        /// The counts for enrollment statuses
        /// </summary>
        /// <value>The counts for enrollment statuses</value>
        [DataMember(Name="enrollmentCounts", EmitDefaultValue=false)]
        public PendingAndApprovedOpportunityEnrollmentCounts EnrollmentCounts { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryEnrollmentOpportunityResult {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  DeadlineDate: ").Append(DeadlineDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  EnrollmentCounts: ").Append(EnrollmentCounts).Append("\n");
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
            return this.Equals(obj as QueryEnrollmentOpportunityResult);
        }

        /// <summary>
        /// Returns true if QueryEnrollmentOpportunityResult instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryEnrollmentOpportunityResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryEnrollmentOpportunityResult other)
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
                    this.ActivityCodeId == other.ActivityCodeId ||
                    this.ActivityCodeId != null &&
                    this.ActivityCodeId.Equals(other.ActivityCodeId)
                ) &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) &&
                (
                    this.DeadlineDate == other.DeadlineDate ||
                    this.DeadlineDate != null &&
                    this.DeadlineDate.Equals(other.DeadlineDate)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Capacity == other.Capacity ||
                    this.Capacity != null &&
                    this.Capacity.Equals(other.Capacity)
                ) &&
                (
                    this.EnrollmentCounts == other.EnrollmentCounts ||
                    this.EnrollmentCounts != null &&
                    this.EnrollmentCounts.Equals(other.EnrollmentCounts)
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

                if (this.ActivityCodeId != null)
                    hash = hash * 59 + this.ActivityCodeId.GetHashCode();

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();

                if (this.DeadlineDate != null)
                    hash = hash * 59 + this.DeadlineDate.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Capacity != null)
                    hash = hash * 59 + this.Capacity.GetHashCode();

                if (this.EnrollmentCounts != null)
                    hash = hash * 59 + this.EnrollmentCounts.GetHashCode();

                return hash;
            }
        }
    }

}
