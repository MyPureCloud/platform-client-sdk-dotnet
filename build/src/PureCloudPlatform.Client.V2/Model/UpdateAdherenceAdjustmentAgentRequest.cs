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
    /// UpdateAdherenceAdjustmentAgentRequest
    /// </summary>
    [DataContract]
    public partial class UpdateAdherenceAdjustmentAgentRequest :  IEquatable<UpdateAdherenceAdjustmentAgentRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAdherenceAdjustmentAgentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAdherenceAdjustmentAgentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAdherenceAdjustmentAgentRequest" /> class.
        /// </summary>
        /// <param name="ReasonCodeId">The ID of the reason code for this adherence adjustment.</param>
        /// <param name="StartDate">The start timestamp of the adherence adjustment in ISO-8601 format.</param>
        /// <param name="LengthMinutes">The length of the adherence adjustment in minutes.</param>
        /// <param name="Metadata">Version metadata for the adherence adjustment (required).</param>
        /// <param name="SubmitterNotes">Notes provided by the submitter for this adherence adjustment.</param>
        public UpdateAdherenceAdjustmentAgentRequest(string ReasonCodeId = null, DateTime? StartDate = null, int? LengthMinutes = null, WfmVersionedEntityMetadata Metadata = null, string SubmitterNotes = null)
        {
            this.ReasonCodeId = ReasonCodeId;
            this.StartDate = StartDate;
            this.LengthMinutes = LengthMinutes;
            this.Metadata = Metadata;
            this.SubmitterNotes = SubmitterNotes;
            
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
        /// Notes provided by the submitter for this adherence adjustment
        /// </summary>
        /// <value>Notes provided by the submitter for this adherence adjustment</value>
        [DataMember(Name="submitterNotes", EmitDefaultValue=false)]
        public string SubmitterNotes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAdherenceAdjustmentAgentRequest {\n");

            sb.Append("  ReasonCodeId: ").Append(ReasonCodeId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  SubmitterNotes: ").Append(SubmitterNotes).Append("\n");
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
            return this.Equals(obj as UpdateAdherenceAdjustmentAgentRequest);
        }

        /// <summary>
        /// Returns true if UpdateAdherenceAdjustmentAgentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateAdherenceAdjustmentAgentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAdherenceAdjustmentAgentRequest other)
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
                    this.SubmitterNotes == other.SubmitterNotes ||
                    this.SubmitterNotes != null &&
                    this.SubmitterNotes.Equals(other.SubmitterNotes)
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

                if (this.SubmitterNotes != null)
                    hash = hash * 59 + this.SubmitterNotes.GetHashCode();

                return hash;
            }
        }
    }

}
