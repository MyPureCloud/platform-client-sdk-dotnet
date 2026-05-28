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
    /// BulkOpportunityEnrollmentsStatusUpdateRequest
    /// </summary>
    [DataContract]
    public partial class BulkOpportunityEnrollmentsStatusUpdateRequest :  IEquatable<BulkOpportunityEnrollmentsStatusUpdateRequest>
    {
        /// <summary>
        /// The status to set for all enrollments specified in this request
        /// </summary>
        /// <value>The status to set for all enrollments specified in this request</value>
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
            Denied
        }
        /// <summary>
        /// The status to set for all enrollments specified in this request
        /// </summary>
        /// <value>The status to set for all enrollments specified in this request</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkOpportunityEnrollmentsStatusUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkOpportunityEnrollmentsStatusUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkOpportunityEnrollmentsStatusUpdateRequest" /> class.
        /// </summary>
        /// <param name="EnrollmentIds">The IDs of the enrollments to update (required).</param>
        /// <param name="Status">The status to set for all enrollments specified in this request (required).</param>
        /// <param name="ReviewNote">Supervisor&#39;s note explaining the agent&#39;s enrollment status change.</param>
        public BulkOpportunityEnrollmentsStatusUpdateRequest(List<string> EnrollmentIds = null, StatusEnum? Status = null, string ReviewNote = null)
        {
            this.EnrollmentIds = EnrollmentIds;
            this.Status = Status;
            this.ReviewNote = ReviewNote;
            
        }
        


        /// <summary>
        /// The IDs of the enrollments to update
        /// </summary>
        /// <value>The IDs of the enrollments to update</value>
        [DataMember(Name="enrollmentIds", EmitDefaultValue=false)]
        public List<string> EnrollmentIds { get; set; }





        /// <summary>
        /// Supervisor&#39;s note explaining the agent&#39;s enrollment status change
        /// </summary>
        /// <value>Supervisor&#39;s note explaining the agent&#39;s enrollment status change</value>
        [DataMember(Name="reviewNote", EmitDefaultValue=false)]
        public string ReviewNote { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkOpportunityEnrollmentsStatusUpdateRequest {\n");

            sb.Append("  EnrollmentIds: ").Append(EnrollmentIds).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ReviewNote: ").Append(ReviewNote).Append("\n");
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
            return this.Equals(obj as BulkOpportunityEnrollmentsStatusUpdateRequest);
        }

        /// <summary>
        /// Returns true if BulkOpportunityEnrollmentsStatusUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkOpportunityEnrollmentsStatusUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkOpportunityEnrollmentsStatusUpdateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EnrollmentIds == other.EnrollmentIds ||
                    this.EnrollmentIds != null &&
                    this.EnrollmentIds.SequenceEqual(other.EnrollmentIds)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ReviewNote == other.ReviewNote ||
                    this.ReviewNote != null &&
                    this.ReviewNote.Equals(other.ReviewNote)
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
                if (this.EnrollmentIds != null)
                    hash = hash * 59 + this.EnrollmentIds.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.ReviewNote != null)
                    hash = hash * 59 + this.ReviewNote.GetHashCode();

                return hash;
            }
        }
    }

}
