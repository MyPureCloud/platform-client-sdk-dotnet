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
    /// KnowledgeImportJobReport
    /// </summary>
    [DataContract]
    public partial class KnowledgeImportJobReport :  IEquatable<KnowledgeImportJobReport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeImportJobReport" /> class.
        /// </summary>
        /// <param name="Errors">List of errors occurred during processing import..</param>
        /// <param name="Statistics">Statistics related to the import job..</param>
        public KnowledgeImportJobReport(List<KnowledgeImportJobError> Errors = null, KnowledgeImportJobStatistics Statistics = null)
        {
            this.Errors = Errors;
            this.Statistics = Statistics;
            
        }
        


        /// <summary>
        /// List of errors occurred during processing import.
        /// </summary>
        /// <value>List of errors occurred during processing import.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<KnowledgeImportJobError> Errors { get; set; }



        /// <summary>
        /// Statistics related to the import job.
        /// </summary>
        /// <value>Statistics related to the import job.</value>
        [DataMember(Name="statistics", EmitDefaultValue=false)]
        public KnowledgeImportJobStatistics Statistics { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeImportJobReport {\n");

            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Statistics: ").Append(Statistics).Append("\n");
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
            return this.Equals(obj as KnowledgeImportJobReport);
        }

        /// <summary>
        /// Returns true if KnowledgeImportJobReport instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeImportJobReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeImportJobReport other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) &&
                (
                    this.Statistics == other.Statistics ||
                    this.Statistics != null &&
                    this.Statistics.Equals(other.Statistics)
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
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();

                if (this.Statistics != null)
                    hash = hash * 59 + this.Statistics.GetHashCode();

                return hash;
            }
        }
    }

}
