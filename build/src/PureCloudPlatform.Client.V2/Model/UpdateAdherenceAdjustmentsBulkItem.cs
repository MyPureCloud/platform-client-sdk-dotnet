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
    /// UpdateAdherenceAdjustmentsBulkItem
    /// </summary>
    [DataContract]
    public partial class UpdateAdherenceAdjustmentsBulkItem :  IEquatable<UpdateAdherenceAdjustmentsBulkItem>
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
        /// Initializes a new instance of the <see cref="UpdateAdherenceAdjustmentsBulkItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAdherenceAdjustmentsBulkItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAdherenceAdjustmentsBulkItem" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="ReviewerNotes">Notes provided by the reviewer for this adherence adjustment.</param>
        /// <param name="Status">The new status for the adherence adjustment.</param>
        /// <param name="Metadata">Version metadata for the adherence adjustment (required).</param>
        public UpdateAdherenceAdjustmentsBulkItem(string Id = null, string ReviewerNotes = null, StatusEnum? Status = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Id = Id;
            this.ReviewerNotes = ReviewerNotes;
            this.Status = Status;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Notes provided by the reviewer for this adherence adjustment
        /// </summary>
        /// <value>Notes provided by the reviewer for this adherence adjustment</value>
        [DataMember(Name="reviewerNotes", EmitDefaultValue=false)]
        public string ReviewerNotes { get; set; }





        /// <summary>
        /// Version metadata for the adherence adjustment
        /// </summary>
        /// <value>Version metadata for the adherence adjustment</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAdherenceAdjustmentsBulkItem {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ReviewerNotes: ").Append(ReviewerNotes).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as UpdateAdherenceAdjustmentsBulkItem);
        }

        /// <summary>
        /// Returns true if UpdateAdherenceAdjustmentsBulkItem instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateAdherenceAdjustmentsBulkItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAdherenceAdjustmentsBulkItem other)
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
                    this.ReviewerNotes == other.ReviewerNotes ||
                    this.ReviewerNotes != null &&
                    this.ReviewerNotes.Equals(other.ReviewerNotes)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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

                if (this.ReviewerNotes != null)
                    hash = hash * 59 + this.ReviewerNotes.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
