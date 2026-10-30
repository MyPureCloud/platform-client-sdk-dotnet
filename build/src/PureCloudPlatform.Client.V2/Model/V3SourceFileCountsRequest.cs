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
    /// V3SourceFileCountsRequest
    /// </summary>
    [DataContract]
    public partial class V3SourceFileCountsRequest :  IEquatable<V3SourceFileCountsRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="V3SourceFileCountsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V3SourceFileCountsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SourceFileCountsRequest" /> class.
        /// </summary>
        /// <param name="SourceIds">Source IDs used to scope the file count response. (required).</param>
        /// <param name="Filter">Composite tag filter..</param>
        /// <param name="IncludeFileNames">When true, response may include fileNames per source..</param>
        public V3SourceFileCountsRequest(List<string> SourceIds = null, V3SourceTagFilter Filter = null, bool? IncludeFileNames = null)
        {
            this.SourceIds = SourceIds;
            this.Filter = Filter;
            this.IncludeFileNames = IncludeFileNames;
            
        }
        


        /// <summary>
        /// Source IDs used to scope the file count response.
        /// </summary>
        /// <value>Source IDs used to scope the file count response.</value>
        [DataMember(Name="sourceIds", EmitDefaultValue=false)]
        public List<string> SourceIds { get; set; }



        /// <summary>
        /// Composite tag filter.
        /// </summary>
        /// <value>Composite tag filter.</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public V3SourceTagFilter Filter { get; set; }



        /// <summary>
        /// When true, response may include fileNames per source.
        /// </summary>
        /// <value>When true, response may include fileNames per source.</value>
        [DataMember(Name="includeFileNames", EmitDefaultValue=false)]
        public bool? IncludeFileNames { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3SourceFileCountsRequest {\n");

            sb.Append("  SourceIds: ").Append(SourceIds).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  IncludeFileNames: ").Append(IncludeFileNames).Append("\n");
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
            return this.Equals(obj as V3SourceFileCountsRequest);
        }

        /// <summary>
        /// Returns true if V3SourceFileCountsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SourceFileCountsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SourceFileCountsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SourceIds == other.SourceIds ||
                    this.SourceIds != null &&
                    this.SourceIds.SequenceEqual(other.SourceIds)
                ) &&
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) &&
                (
                    this.IncludeFileNames == other.IncludeFileNames ||
                    this.IncludeFileNames != null &&
                    this.IncludeFileNames.Equals(other.IncludeFileNames)
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
                if (this.SourceIds != null)
                    hash = hash * 59 + this.SourceIds.GetHashCode();

                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();

                if (this.IncludeFileNames != null)
                    hash = hash * 59 + this.IncludeFileNames.GetHashCode();

                return hash;
            }
        }
    }

}
