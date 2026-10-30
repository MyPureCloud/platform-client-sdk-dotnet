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
    /// V3SourceTagsGroupedEntry
    /// </summary>
    [DataContract]
    public partial class V3SourceTagsGroupedEntry :  IEquatable<V3SourceTagsGroupedEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SourceTagsGroupedEntry" /> class.
        /// </summary>
        /// <param name="Source">Knowledge source reference for this entry..</param>
        /// <param name="Tags">Distinct tags for this source..</param>
        public V3SourceTagsGroupedEntry(V3SourceRef Source = null, List<V3SourceTagResponse> Tags = null)
        {
            this.Source = Source;
            this.Tags = Tags;
            
        }
        


        /// <summary>
        /// Knowledge source reference for this entry.
        /// </summary>
        /// <value>Knowledge source reference for this entry.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public V3SourceRef Source { get; set; }



        /// <summary>
        /// Distinct tags for this source.
        /// </summary>
        /// <value>Distinct tags for this source.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<V3SourceTagResponse> Tags { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3SourceTagsGroupedEntry {\n");

            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(obj as V3SourceTagsGroupedEntry);
        }

        /// <summary>
        /// Returns true if V3SourceTagsGroupedEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SourceTagsGroupedEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SourceTagsGroupedEntry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) &&
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
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
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();

                return hash;
            }
        }
    }

}
