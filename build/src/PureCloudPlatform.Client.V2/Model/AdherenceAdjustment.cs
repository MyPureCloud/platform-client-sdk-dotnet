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
    /// AdherenceAdjustment
    /// </summary>
    [DataContract]
    public partial class AdherenceAdjustment :  IEquatable<AdherenceAdjustment>
    {
        /// <summary>
        /// The status of the adherence adjustment
        /// </summary>
        /// <value>The status of the adherence adjustment</value>
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
            /// Enum Approved for "Approved"
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved,
            
            /// <summary>
            /// Enum Denied for "Denied"
            /// </summary>
            [EnumMember(Value = "Denied")]
            Denied,
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending
        }
        /// <summary>
        /// The status of the adherence adjustment
        /// </summary>
        /// <value>The status of the adherence adjustment</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdherenceAdjustment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdherenceAdjustment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdherenceAdjustment" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object. (required).</param>
        /// <param name="Agent">The agent to whom this adherence adjustment applies (required).</param>
        /// <param name="ManagementUnit">The management unit to which the agent belonged when the adherence adjustment was submitted (required).</param>
        /// <param name="BusinessUnit">The business unit to which the agent belonged when the adherence adjustment was submitted (required).</param>
        /// <param name="StartDate">The start timestamp of the adherence adjustment in ISO-8601 format (required).</param>
        /// <param name="LengthMinutes">The length of the adherence adjustment in minutes (required).</param>
        /// <param name="ReasonCode">The reason code for this adherence adjustment (required).</param>
        /// <param name="Status">The status of the adherence adjustment (required).</param>
        /// <param name="Expired">Indicates if the adherence adjustment is expired (required).</param>
        /// <param name="SubmitterNotes">Notes provided by the submitter for this adherence adjustment.</param>
        /// <param name="ReviewerNotes">Notes provided by the reviewer for this adherence adjustment.</param>
        /// <param name="ReviewedBy">The user who reviewed the adherence adjustment, if applicable. The id may be &#39;System&#39; if it was an automated process.</param>
        /// <param name="ReviewedDate">The date the adherence adjustment was reviewed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Metadata">Version metadata for the adherence adjustment (required).</param>
        public AdherenceAdjustment(string Id = null, UserReference Agent = null, ManagementUnitReference ManagementUnit = null, BusinessUnitReference BusinessUnit = null, DateTime? StartDate = null, int? LengthMinutes = null, AdherenceAdjustmentsReasonCodeReference ReasonCode = null, StatusEnum? Status = null, bool? Expired = null, string SubmitterNotes = null, string ReviewerNotes = null, UserReference ReviewedBy = null, DateTime? ReviewedDate = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Id = Id;
            this.Agent = Agent;
            this.ManagementUnit = ManagementUnit;
            this.BusinessUnit = BusinessUnit;
            this.StartDate = StartDate;
            this.LengthMinutes = LengthMinutes;
            this.ReasonCode = ReasonCode;
            this.Status = Status;
            this.Expired = Expired;
            this.SubmitterNotes = SubmitterNotes;
            this.ReviewerNotes = ReviewerNotes;
            this.ReviewedBy = ReviewedBy;
            this.ReviewedDate = ReviewedDate;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The agent to whom this adherence adjustment applies
        /// </summary>
        /// <value>The agent to whom this adherence adjustment applies</value>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public UserReference Agent { get; set; }



        /// <summary>
        /// The management unit to which the agent belonged when the adherence adjustment was submitted
        /// </summary>
        /// <value>The management unit to which the agent belonged when the adherence adjustment was submitted</value>
        [DataMember(Name="managementUnit", EmitDefaultValue=false)]
        public ManagementUnitReference ManagementUnit { get; set; }



        /// <summary>
        /// The business unit to which the agent belonged when the adherence adjustment was submitted
        /// </summary>
        /// <value>The business unit to which the agent belonged when the adherence adjustment was submitted</value>
        [DataMember(Name="businessUnit", EmitDefaultValue=false)]
        public BusinessUnitReference BusinessUnit { get; set; }



        /// <summary>
        /// The start timestamp of the adherence adjustment in ISO-8601 format
        /// </summary>
        /// <value>The start timestamp of the adherence adjustment in ISO-8601 format</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// The length of the adherence adjustment in minutes
        /// </summary>
        /// <value>The length of the adherence adjustment in minutes</value>
        [DataMember(Name="lengthMinutes", EmitDefaultValue=false)]
        public int? LengthMinutes { get; set; }



        /// <summary>
        /// The reason code for this adherence adjustment
        /// </summary>
        /// <value>The reason code for this adherence adjustment</value>
        [DataMember(Name="reasonCode", EmitDefaultValue=false)]
        public AdherenceAdjustmentsReasonCodeReference ReasonCode { get; set; }





        /// <summary>
        /// Indicates if the adherence adjustment is expired
        /// </summary>
        /// <value>Indicates if the adherence adjustment is expired</value>
        [DataMember(Name="expired", EmitDefaultValue=false)]
        public bool? Expired { get; set; }



        /// <summary>
        /// Notes provided by the submitter for this adherence adjustment
        /// </summary>
        /// <value>Notes provided by the submitter for this adherence adjustment</value>
        [DataMember(Name="submitterNotes", EmitDefaultValue=false)]
        public string SubmitterNotes { get; set; }



        /// <summary>
        /// Notes provided by the reviewer for this adherence adjustment
        /// </summary>
        /// <value>Notes provided by the reviewer for this adherence adjustment</value>
        [DataMember(Name="reviewerNotes", EmitDefaultValue=false)]
        public string ReviewerNotes { get; set; }



        /// <summary>
        /// The user who reviewed the adherence adjustment, if applicable. The id may be &#39;System&#39; if it was an automated process
        /// </summary>
        /// <value>The user who reviewed the adherence adjustment, if applicable. The id may be &#39;System&#39; if it was an automated process</value>
        [DataMember(Name="reviewedBy", EmitDefaultValue=false)]
        public UserReference ReviewedBy { get; set; }



        /// <summary>
        /// The date the adherence adjustment was reviewed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the adherence adjustment was reviewed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="reviewedDate", EmitDefaultValue=false)]
        public DateTime? ReviewedDate { get; set; }



        /// <summary>
        /// Version metadata for the adherence adjustment
        /// </summary>
        /// <value>Version metadata for the adherence adjustment</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }



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
            sb.Append("class AdherenceAdjustment {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
            sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  SubmitterNotes: ").Append(SubmitterNotes).Append("\n");
            sb.Append("  ReviewerNotes: ").Append(ReviewerNotes).Append("\n");
            sb.Append("  ReviewedBy: ").Append(ReviewedBy).Append("\n");
            sb.Append("  ReviewedDate: ").Append(ReviewedDate).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as AdherenceAdjustment);
        }

        /// <summary>
        /// Returns true if AdherenceAdjustment instances are equal
        /// </summary>
        /// <param name="other">Instance of AdherenceAdjustment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdherenceAdjustment other)
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
                    this.Agent == other.Agent ||
                    this.Agent != null &&
                    this.Agent.Equals(other.Agent)
                ) &&
                (
                    this.ManagementUnit == other.ManagementUnit ||
                    this.ManagementUnit != null &&
                    this.ManagementUnit.Equals(other.ManagementUnit)
                ) &&
                (
                    this.BusinessUnit == other.BusinessUnit ||
                    this.BusinessUnit != null &&
                    this.BusinessUnit.Equals(other.BusinessUnit)
                ) &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.LengthMinutes == other.LengthMinutes ||
                    this.LengthMinutes != null &&
                    this.LengthMinutes.Equals(other.LengthMinutes)
                ) &&
                (
                    this.ReasonCode == other.ReasonCode ||
                    this.ReasonCode != null &&
                    this.ReasonCode.Equals(other.ReasonCode)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Expired == other.Expired ||
                    this.Expired != null &&
                    this.Expired.Equals(other.Expired)
                ) &&
                (
                    this.SubmitterNotes == other.SubmitterNotes ||
                    this.SubmitterNotes != null &&
                    this.SubmitterNotes.Equals(other.SubmitterNotes)
                ) &&
                (
                    this.ReviewerNotes == other.ReviewerNotes ||
                    this.ReviewerNotes != null &&
                    this.ReviewerNotes.Equals(other.ReviewerNotes)
                ) &&
                (
                    this.ReviewedBy == other.ReviewedBy ||
                    this.ReviewedBy != null &&
                    this.ReviewedBy.Equals(other.ReviewedBy)
                ) &&
                (
                    this.ReviewedDate == other.ReviewedDate ||
                    this.ReviewedDate != null &&
                    this.ReviewedDate.Equals(other.ReviewedDate)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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

                if (this.Agent != null)
                    hash = hash * 59 + this.Agent.GetHashCode();

                if (this.ManagementUnit != null)
                    hash = hash * 59 + this.ManagementUnit.GetHashCode();

                if (this.BusinessUnit != null)
                    hash = hash * 59 + this.BusinessUnit.GetHashCode();

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.LengthMinutes != null)
                    hash = hash * 59 + this.LengthMinutes.GetHashCode();

                if (this.ReasonCode != null)
                    hash = hash * 59 + this.ReasonCode.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Expired != null)
                    hash = hash * 59 + this.Expired.GetHashCode();

                if (this.SubmitterNotes != null)
                    hash = hash * 59 + this.SubmitterNotes.GetHashCode();

                if (this.ReviewerNotes != null)
                    hash = hash * 59 + this.ReviewerNotes.GetHashCode();

                if (this.ReviewedBy != null)
                    hash = hash * 59 + this.ReviewedBy.GetHashCode();

                if (this.ReviewedDate != null)
                    hash = hash * 59 + this.ReviewedDate.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
