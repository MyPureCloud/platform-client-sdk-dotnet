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
    /// ExternalContactsContactChangedTopicMergeOperation
    /// </summary>
    [DataContract]
    public partial class ExternalContactsContactChangedTopicMergeOperation :  IEquatable<ExternalContactsContactChangedTopicMergeOperation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalContactsContactChangedTopicMergeOperation" /> class.
        /// </summary>
        /// <param name="SourceContactId">SourceContactId.</param>
        /// <param name="TargetContactId">TargetContactId.</param>
        /// <param name="ResultingContactId">ResultingContactId.</param>
        public ExternalContactsContactChangedTopicMergeOperation(string SourceContactId = null, string TargetContactId = null, string ResultingContactId = null)
        {
            this.SourceContactId = SourceContactId;
            this.TargetContactId = TargetContactId;
            this.ResultingContactId = ResultingContactId;
            
        }
        


        /// <summary>
        /// Gets or Sets SourceContactId
        /// </summary>
        [DataMember(Name="sourceContactId", EmitDefaultValue=false)]
        public string SourceContactId { get; set; }



        /// <summary>
        /// Gets or Sets TargetContactId
        /// </summary>
        [DataMember(Name="targetContactId", EmitDefaultValue=false)]
        public string TargetContactId { get; set; }



        /// <summary>
        /// Gets or Sets ResultingContactId
        /// </summary>
        [DataMember(Name="resultingContactId", EmitDefaultValue=false)]
        public string ResultingContactId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalContactsContactChangedTopicMergeOperation {\n");

            sb.Append("  SourceContactId: ").Append(SourceContactId).Append("\n");
            sb.Append("  TargetContactId: ").Append(TargetContactId).Append("\n");
            sb.Append("  ResultingContactId: ").Append(ResultingContactId).Append("\n");
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
            return this.Equals(obj as ExternalContactsContactChangedTopicMergeOperation);
        }

        /// <summary>
        /// Returns true if ExternalContactsContactChangedTopicMergeOperation instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalContactsContactChangedTopicMergeOperation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalContactsContactChangedTopicMergeOperation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SourceContactId == other.SourceContactId ||
                    this.SourceContactId != null &&
                    this.SourceContactId.Equals(other.SourceContactId)
                ) &&
                (
                    this.TargetContactId == other.TargetContactId ||
                    this.TargetContactId != null &&
                    this.TargetContactId.Equals(other.TargetContactId)
                ) &&
                (
                    this.ResultingContactId == other.ResultingContactId ||
                    this.ResultingContactId != null &&
                    this.ResultingContactId.Equals(other.ResultingContactId)
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
                if (this.SourceContactId != null)
                    hash = hash * 59 + this.SourceContactId.GetHashCode();

                if (this.TargetContactId != null)
                    hash = hash * 59 + this.TargetContactId.GetHashCode();

                if (this.ResultingContactId != null)
                    hash = hash * 59 + this.ResultingContactId.GetHashCode();

                return hash;
            }
        }
    }

}
