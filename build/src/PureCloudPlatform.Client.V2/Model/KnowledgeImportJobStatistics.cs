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
    /// KnowledgeImportJobStatistics
    /// </summary>
    [DataContract]
    public partial class KnowledgeImportJobStatistics :  IEquatable<KnowledgeImportJobStatistics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeImportJobStatistics" /> class.
        /// </summary>
        /// <param name="CountDocumentImportActivityCreate">Number of documents will be created by the import..</param>
        /// <param name="CountDocumentImportActivityUpdate">Number of documents will be updated by the import..</param>
        /// <param name="CountDocumentStateDraft">Number of documents will be imported as draft..</param>
        /// <param name="CountDocumentStatePublished">Number of documents will be imported as published..</param>
        /// <param name="CountDocumentValidationSuccess">Number of documents that validated successfully for import..</param>
        /// <param name="CountDocumentValidationFailure">Number of documents that failed validation for import..</param>
        /// <param name="CountDocumentImportSuccess">Number of imported documents..</param>
        /// <param name="CountDocumentImportFailure">Number of documents failed to import..</param>
        public KnowledgeImportJobStatistics(int? CountDocumentImportActivityCreate = null, int? CountDocumentImportActivityUpdate = null, int? CountDocumentStateDraft = null, int? CountDocumentStatePublished = null, int? CountDocumentValidationSuccess = null, int? CountDocumentValidationFailure = null, int? CountDocumentImportSuccess = null, int? CountDocumentImportFailure = null)
        {
            this.CountDocumentImportActivityCreate = CountDocumentImportActivityCreate;
            this.CountDocumentImportActivityUpdate = CountDocumentImportActivityUpdate;
            this.CountDocumentStateDraft = CountDocumentStateDraft;
            this.CountDocumentStatePublished = CountDocumentStatePublished;
            this.CountDocumentValidationSuccess = CountDocumentValidationSuccess;
            this.CountDocumentValidationFailure = CountDocumentValidationFailure;
            this.CountDocumentImportSuccess = CountDocumentImportSuccess;
            this.CountDocumentImportFailure = CountDocumentImportFailure;
            
        }
        


        /// <summary>
        /// Number of documents will be created by the import.
        /// </summary>
        /// <value>Number of documents will be created by the import.</value>
        [DataMember(Name="countDocumentImportActivityCreate", EmitDefaultValue=false)]
        public int? CountDocumentImportActivityCreate { get; set; }



        /// <summary>
        /// Number of documents will be updated by the import.
        /// </summary>
        /// <value>Number of documents will be updated by the import.</value>
        [DataMember(Name="countDocumentImportActivityUpdate", EmitDefaultValue=false)]
        public int? CountDocumentImportActivityUpdate { get; set; }



        /// <summary>
        /// Number of documents will be imported as draft.
        /// </summary>
        /// <value>Number of documents will be imported as draft.</value>
        [DataMember(Name="countDocumentStateDraft", EmitDefaultValue=false)]
        public int? CountDocumentStateDraft { get; set; }



        /// <summary>
        /// Number of documents will be imported as published.
        /// </summary>
        /// <value>Number of documents will be imported as published.</value>
        [DataMember(Name="countDocumentStatePublished", EmitDefaultValue=false)]
        public int? CountDocumentStatePublished { get; set; }



        /// <summary>
        /// Number of documents that validated successfully for import.
        /// </summary>
        /// <value>Number of documents that validated successfully for import.</value>
        [DataMember(Name="countDocumentValidationSuccess", EmitDefaultValue=false)]
        public int? CountDocumentValidationSuccess { get; set; }



        /// <summary>
        /// Number of documents that failed validation for import.
        /// </summary>
        /// <value>Number of documents that failed validation for import.</value>
        [DataMember(Name="countDocumentValidationFailure", EmitDefaultValue=false)]
        public int? CountDocumentValidationFailure { get; set; }



        /// <summary>
        /// Number of imported documents.
        /// </summary>
        /// <value>Number of imported documents.</value>
        [DataMember(Name="countDocumentImportSuccess", EmitDefaultValue=false)]
        public int? CountDocumentImportSuccess { get; set; }



        /// <summary>
        /// Number of documents failed to import.
        /// </summary>
        /// <value>Number of documents failed to import.</value>
        [DataMember(Name="countDocumentImportFailure", EmitDefaultValue=false)]
        public int? CountDocumentImportFailure { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeImportJobStatistics {\n");

            sb.Append("  CountDocumentImportActivityCreate: ").Append(CountDocumentImportActivityCreate).Append("\n");
            sb.Append("  CountDocumentImportActivityUpdate: ").Append(CountDocumentImportActivityUpdate).Append("\n");
            sb.Append("  CountDocumentStateDraft: ").Append(CountDocumentStateDraft).Append("\n");
            sb.Append("  CountDocumentStatePublished: ").Append(CountDocumentStatePublished).Append("\n");
            sb.Append("  CountDocumentValidationSuccess: ").Append(CountDocumentValidationSuccess).Append("\n");
            sb.Append("  CountDocumentValidationFailure: ").Append(CountDocumentValidationFailure).Append("\n");
            sb.Append("  CountDocumentImportSuccess: ").Append(CountDocumentImportSuccess).Append("\n");
            sb.Append("  CountDocumentImportFailure: ").Append(CountDocumentImportFailure).Append("\n");
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
            return this.Equals(obj as KnowledgeImportJobStatistics);
        }

        /// <summary>
        /// Returns true if KnowledgeImportJobStatistics instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeImportJobStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeImportJobStatistics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CountDocumentImportActivityCreate == other.CountDocumentImportActivityCreate ||
                    this.CountDocumentImportActivityCreate != null &&
                    this.CountDocumentImportActivityCreate.Equals(other.CountDocumentImportActivityCreate)
                ) &&
                (
                    this.CountDocumentImportActivityUpdate == other.CountDocumentImportActivityUpdate ||
                    this.CountDocumentImportActivityUpdate != null &&
                    this.CountDocumentImportActivityUpdate.Equals(other.CountDocumentImportActivityUpdate)
                ) &&
                (
                    this.CountDocumentStateDraft == other.CountDocumentStateDraft ||
                    this.CountDocumentStateDraft != null &&
                    this.CountDocumentStateDraft.Equals(other.CountDocumentStateDraft)
                ) &&
                (
                    this.CountDocumentStatePublished == other.CountDocumentStatePublished ||
                    this.CountDocumentStatePublished != null &&
                    this.CountDocumentStatePublished.Equals(other.CountDocumentStatePublished)
                ) &&
                (
                    this.CountDocumentValidationSuccess == other.CountDocumentValidationSuccess ||
                    this.CountDocumentValidationSuccess != null &&
                    this.CountDocumentValidationSuccess.Equals(other.CountDocumentValidationSuccess)
                ) &&
                (
                    this.CountDocumentValidationFailure == other.CountDocumentValidationFailure ||
                    this.CountDocumentValidationFailure != null &&
                    this.CountDocumentValidationFailure.Equals(other.CountDocumentValidationFailure)
                ) &&
                (
                    this.CountDocumentImportSuccess == other.CountDocumentImportSuccess ||
                    this.CountDocumentImportSuccess != null &&
                    this.CountDocumentImportSuccess.Equals(other.CountDocumentImportSuccess)
                ) &&
                (
                    this.CountDocumentImportFailure == other.CountDocumentImportFailure ||
                    this.CountDocumentImportFailure != null &&
                    this.CountDocumentImportFailure.Equals(other.CountDocumentImportFailure)
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
                if (this.CountDocumentImportActivityCreate != null)
                    hash = hash * 59 + this.CountDocumentImportActivityCreate.GetHashCode();

                if (this.CountDocumentImportActivityUpdate != null)
                    hash = hash * 59 + this.CountDocumentImportActivityUpdate.GetHashCode();

                if (this.CountDocumentStateDraft != null)
                    hash = hash * 59 + this.CountDocumentStateDraft.GetHashCode();

                if (this.CountDocumentStatePublished != null)
                    hash = hash * 59 + this.CountDocumentStatePublished.GetHashCode();

                if (this.CountDocumentValidationSuccess != null)
                    hash = hash * 59 + this.CountDocumentValidationSuccess.GetHashCode();

                if (this.CountDocumentValidationFailure != null)
                    hash = hash * 59 + this.CountDocumentValidationFailure.GetHashCode();

                if (this.CountDocumentImportSuccess != null)
                    hash = hash * 59 + this.CountDocumentImportSuccess.GetHashCode();

                if (this.CountDocumentImportFailure != null)
                    hash = hash * 59 + this.CountDocumentImportFailure.GetHashCode();

                return hash;
            }
        }
    }

}
