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
    /// UpdateAdherenceAdjustmentAdminRequest
    /// </summary>
    [DataContract]
    public partial class UpdateAdherenceAdjustmentAdminRequest :  IEquatable<UpdateAdherenceAdjustmentAdminRequest>
    {
        /// <summary>
        /// The new status for the adherence adjustment
        /// </summary>
        /// <value>The new status for the adherence adjustment</value>
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
        /// The new status for the adherence adjustment
        /// </summary>
        /// <value>The new status for the adherence adjustment</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAdherenceAdjustmentAdminRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAdherenceAdjustmentAdminRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAdherenceAdjustmentAdminRequest" /> class.
        /// </summary>
        /// <param name="ReasonCodeId">The ID of the reason code for this adherence adjustment.</param>
        /// <param name="StartDate">The start timestamp of the adherence adjustment in ISO-8601 format.</param>
        /// <param name="LengthMinutes">The length of the adherence adjustment in minutes.</param>
        /// <param name="Metadata">Version metadata for the adherence adjustment (required).</param>
        /// <param name="ReviewerNotes">Notes provided by the reviewer for this adherence adjustment.</param>
        /// <param name="Status">The new status for the adherence adjustment.</param>
        public UpdateAdherenceAdjustmentAdminRequest(string ReasonCodeId = null, DateTime? StartDate = null, int? LengthMinutes = null, WfmVersionedEntityMetadata Metadata = null, string ReviewerNotes = null, StatusEnum? Status = null)
        {
            this.ReasonCodeId = ReasonCodeId;
            this.StartDate = StartDate;
            this.LengthMinutes = LengthMinutes;
            this.Metadata = Metadata;
            this.ReviewerNotes = ReviewerNotes;
            this.Status = Status;
            
        }
        


        /// <summary>
        /// The ID of the reason code for this adherence adjustment
        /// </summary>
        /// <value>The ID of the reason code for this adherence adjustment</value>
        [DataMember(Name="reasonCodeId", EmitDefaultValue=false)]
        public string ReasonCodeId { get; set; }



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
        /// Version metadata for the adherence adjustment
        /// </summary>
        /// <value>Version metadata for the adherence adjustment</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }



        /// <summary>
        /// Notes provided by the reviewer for this adherence adjustment
        /// </summary>
        /// <value>Notes provided by the reviewer for this adherence adjustment</value>
        [DataMember(Name="reviewerNotes", EmitDefaultValue=false)]
        public string ReviewerNotes { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAdherenceAdjustmentAdminRequest {\n");

            sb.Append("  ReasonCodeId: ").Append(ReasonCodeId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  ReviewerNotes: ").Append(ReviewerNotes).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as UpdateAdherenceAdjustmentAdminRequest);
        }

        /// <summary>
        /// Returns true if UpdateAdherenceAdjustmentAdminRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateAdherenceAdjustmentAdminRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAdherenceAdjustmentAdminRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ReasonCodeId == other.ReasonCodeId ||
                    this.ReasonCodeId != null &&
                    this.ReasonCodeId.Equals(other.ReasonCodeId)
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
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) &&
                (
                    this.ReviewerNotes == other.ReviewerNotes ||
                    this.ReviewerNotes != null &&
                    this.ReviewerNotes.Equals(other.ReviewerNotes)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.ReasonCodeId != null)
                    hash = hash * 59 + this.ReasonCodeId.GetHashCode();

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.LengthMinutes != null)
                    hash = hash * 59 + this.LengthMinutes.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                if (this.ReviewerNotes != null)
                    hash = hash * 59 + this.ReviewerNotes.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                return hash;
            }
        }
    }

}
