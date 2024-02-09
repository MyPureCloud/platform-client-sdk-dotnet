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
    /// KnowledgeParseImportResult
    /// </summary>
    [DataContract]
    public partial class KnowledgeParseImportResult :  IEquatable<KnowledgeParseImportResult>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeParseImportResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeParseImportResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeParseImportResult" /> class.
        /// </summary>
        /// <param name="Success">Number of imported articles. (required).</param>
        /// <param name="Failure">Number of articles failed to import. (required).</param>
        /// <param name="Errors">Error information about the failures..</param>
        public KnowledgeParseImportResult(int? Success = null, int? Failure = null, List<ErrorBody> Errors = null)
        {
            this.Success = Success;
            this.Failure = Failure;
            this.Errors = Errors;
            
        }
        


        /// <summary>
        /// Number of imported articles.
        /// </summary>
        /// <value>Number of imported articles.</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public int? Success { get; set; }



        /// <summary>
        /// Number of articles failed to import.
        /// </summary>
        /// <value>Number of articles failed to import.</value>
        [DataMember(Name="failure", EmitDefaultValue=false)]
        public int? Failure { get; set; }



        /// <summary>
        /// Error information about the failures.
        /// </summary>
        /// <value>Error information about the failures.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<ErrorBody> Errors { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeParseImportResult {\n");

            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Failure: ").Append(Failure).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(obj as KnowledgeParseImportResult);
        }

        /// <summary>
        /// Returns true if KnowledgeParseImportResult instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeParseImportResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeParseImportResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Success == other.Success ||
                    this.Success != null &&
                    this.Success.Equals(other.Success)
                ) &&
                (
                    this.Failure == other.Failure ||
                    this.Failure != null &&
                    this.Failure.Equals(other.Failure)
                ) &&
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
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
                if (this.Success != null)
                    hash = hash * 59 + this.Success.GetHashCode();

                if (this.Failure != null)
                    hash = hash * 59 + this.Failure.GetHashCode();

                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();

                return hash;
            }
        }
    }

}
