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
    /// KnowledgeExportJobRequest
    /// </summary>
    [DataContract]
    public partial class KnowledgeExportJobRequest :  IEquatable<KnowledgeExportJobRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeExportJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeExportJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeExportJobRequest" /> class.
        /// </summary>
        /// <param name="ExportFilter">What to export. (required).</param>
        public KnowledgeExportJobRequest(KnowledgeExportJobFilter ExportFilter = null)
        {
            this.ExportFilter = ExportFilter;
            
        }
        


        /// <summary>
        /// What to export.
        /// </summary>
        /// <value>What to export.</value>
        [DataMember(Name="exportFilter", EmitDefaultValue=false)]
        public KnowledgeExportJobFilter ExportFilter { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeExportJobRequest {\n");

            sb.Append("  ExportFilter: ").Append(ExportFilter).Append("\n");
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
            return this.Equals(obj as KnowledgeExportJobRequest);
        }

        /// <summary>
        /// Returns true if KnowledgeExportJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeExportJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeExportJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ExportFilter == other.ExportFilter ||
                    this.ExportFilter != null &&
                    this.ExportFilter.Equals(other.ExportFilter)
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
                if (this.ExportFilter != null)
                    hash = hash * 59 + this.ExportFilter.GetHashCode();

                return hash;
            }
        }
    }

}
