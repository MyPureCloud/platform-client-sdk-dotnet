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
    /// KnowledgeExportJobDocumentsFilter
    /// </summary>
    [DataContract]
    public partial class KnowledgeExportJobDocumentsFilter :  IEquatable<KnowledgeExportJobDocumentsFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeExportJobDocumentsFilter" /> class.
        /// </summary>
        /// <param name="Interval">Retrieves the documents modified in specified date and time range. Cannot be used together with entities filter. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
        /// <param name="Entities">Retrieves the documents with the given ids. Cannot be used together with internal filter..</param>
        /// <param name="SourceId">SourceId.</param>
        /// <param name="IncludeDocumentsWithFileBody">IncludeDocumentsWithFileBody.</param>
        public KnowledgeExportJobDocumentsFilter(string Interval = null, List<Entity> Entities = null, string SourceId = null, bool? IncludeDocumentsWithFileBody = null)
        {
            this.Interval = Interval;
            this.Entities = Entities;
            this.SourceId = SourceId;
            this.IncludeDocumentsWithFileBody = IncludeDocumentsWithFileBody;
            
        }
        


        /// <summary>
        /// Retrieves the documents modified in specified date and time range. Cannot be used together with entities filter. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>Retrieves the documents modified in specified date and time range. Cannot be used together with entities filter. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }



        /// <summary>
        /// Retrieves the documents with the given ids. Cannot be used together with internal filter.
        /// </summary>
        /// <value>Retrieves the documents with the given ids. Cannot be used together with internal filter.</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<Entity> Entities { get; set; }



        /// <summary>
        /// Gets or Sets SourceId
        /// </summary>
        [DataMember(Name="sourceId", EmitDefaultValue=false)]
        public string SourceId { get; set; }



        /// <summary>
        /// Gets or Sets IncludeDocumentsWithFileBody
        /// </summary>
        [DataMember(Name="includeDocumentsWithFileBody", EmitDefaultValue=false)]
        public bool? IncludeDocumentsWithFileBody { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeExportJobDocumentsFilter {\n");

            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  IncludeDocumentsWithFileBody: ").Append(IncludeDocumentsWithFileBody).Append("\n");
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
            return this.Equals(obj as KnowledgeExportJobDocumentsFilter);
        }

        /// <summary>
        /// Returns true if KnowledgeExportJobDocumentsFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeExportJobDocumentsFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeExportJobDocumentsFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
                ) &&
                (
                    this.SourceId == other.SourceId ||
                    this.SourceId != null &&
                    this.SourceId.Equals(other.SourceId)
                ) &&
                (
                    this.IncludeDocumentsWithFileBody == other.IncludeDocumentsWithFileBody ||
                    this.IncludeDocumentsWithFileBody != null &&
                    this.IncludeDocumentsWithFileBody.Equals(other.IncludeDocumentsWithFileBody)
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
                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();

                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                if (this.SourceId != null)
                    hash = hash * 59 + this.SourceId.GetHashCode();

                if (this.IncludeDocumentsWithFileBody != null)
                    hash = hash * 59 + this.IncludeDocumentsWithFileBody.GetHashCode();

                return hash;
            }
        }
    }

}
