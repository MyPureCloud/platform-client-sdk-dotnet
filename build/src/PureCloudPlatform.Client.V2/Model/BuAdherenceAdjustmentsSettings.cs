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
    /// BuAdherenceAdjustmentsSettings
    /// </summary>
    [DataContract]
    public partial class BuAdherenceAdjustmentsSettings :  IEquatable<BuAdherenceAdjustmentsSettings>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BuAdherenceAdjustmentsSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuAdherenceAdjustmentsSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuAdherenceAdjustmentsSettings" /> class.
        /// </summary>
        /// <param name="SubmissionRangeConstraintDays">The maximum number of days in the past that an adherence adjustment can be submitted (required).</param>
        /// <param name="Metadata">Version info metadata for these adherence adjustments settings (required).</param>
        public BuAdherenceAdjustmentsSettings(int? SubmissionRangeConstraintDays = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.SubmissionRangeConstraintDays = SubmissionRangeConstraintDays;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The maximum number of days in the past that an adherence adjustment can be submitted
        /// </summary>
        /// <value>The maximum number of days in the past that an adherence adjustment can be submitted</value>
        [DataMember(Name="submissionRangeConstraintDays", EmitDefaultValue=false)]
        public int? SubmissionRangeConstraintDays { get; set; }



        /// <summary>
        /// Version info metadata for these adherence adjustments settings
        /// </summary>
        /// <value>Version info metadata for these adherence adjustments settings</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuAdherenceAdjustmentsSettings {\n");

            sb.Append("  SubmissionRangeConstraintDays: ").Append(SubmissionRangeConstraintDays).Append("\n");
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
            return this.Equals(obj as BuAdherenceAdjustmentsSettings);
        }

        /// <summary>
        /// Returns true if BuAdherenceAdjustmentsSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of BuAdherenceAdjustmentsSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuAdherenceAdjustmentsSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SubmissionRangeConstraintDays == other.SubmissionRangeConstraintDays ||
                    this.SubmissionRangeConstraintDays != null &&
                    this.SubmissionRangeConstraintDays.Equals(other.SubmissionRangeConstraintDays)
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
                if (this.SubmissionRangeConstraintDays != null)
                    hash = hash * 59 + this.SubmissionRangeConstraintDays.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
