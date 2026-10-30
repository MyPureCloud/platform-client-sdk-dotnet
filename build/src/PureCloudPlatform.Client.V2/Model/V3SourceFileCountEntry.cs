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
    /// V3SourceFileCountEntry
    /// </summary>
    [DataContract]
    public partial class V3SourceFileCountEntry :  IEquatable<V3SourceFileCountEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SourceFileCountEntry" /> class.
        /// </summary>
        /// <param name="Source">Knowledge source reference for this entry..</param>
        /// <param name="SelectedTagsFileCount">Unique file count matching the tag filter for this source..</param>
        /// <param name="TotalFileCount">Total unique file count for this source without tag filters..</param>
        /// <param name="FileNames">File names when includeFileNames is enabled..</param>
        public V3SourceFileCountEntry(V3SourceRef Source = null, int? SelectedTagsFileCount = null, int? TotalFileCount = null, List<string> FileNames = null)
        {
            this.Source = Source;
            this.SelectedTagsFileCount = SelectedTagsFileCount;
            this.TotalFileCount = TotalFileCount;
            this.FileNames = FileNames;
            
        }
        


        /// <summary>
        /// Knowledge source reference for this entry.
        /// </summary>
        /// <value>Knowledge source reference for this entry.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public V3SourceRef Source { get; set; }



        /// <summary>
        /// Unique file count matching the tag filter for this source.
        /// </summary>
        /// <value>Unique file count matching the tag filter for this source.</value>
        [DataMember(Name="selectedTagsFileCount", EmitDefaultValue=false)]
        public int? SelectedTagsFileCount { get; set; }



        /// <summary>
        /// Total unique file count for this source without tag filters.
        /// </summary>
        /// <value>Total unique file count for this source without tag filters.</value>
        [DataMember(Name="totalFileCount", EmitDefaultValue=false)]
        public int? TotalFileCount { get; set; }



        /// <summary>
        /// File names when includeFileNames is enabled.
        /// </summary>
        /// <value>File names when includeFileNames is enabled.</value>
        [DataMember(Name="fileNames", EmitDefaultValue=false)]
        public List<string> FileNames { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3SourceFileCountEntry {\n");

            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  SelectedTagsFileCount: ").Append(SelectedTagsFileCount).Append("\n");
            sb.Append("  TotalFileCount: ").Append(TotalFileCount).Append("\n");
            sb.Append("  FileNames: ").Append(FileNames).Append("\n");
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
            return this.Equals(obj as V3SourceFileCountEntry);
        }

        /// <summary>
        /// Returns true if V3SourceFileCountEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SourceFileCountEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SourceFileCountEntry other)
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
                    this.SelectedTagsFileCount == other.SelectedTagsFileCount ||
                    this.SelectedTagsFileCount != null &&
                    this.SelectedTagsFileCount.Equals(other.SelectedTagsFileCount)
                ) &&
                (
                    this.TotalFileCount == other.TotalFileCount ||
                    this.TotalFileCount != null &&
                    this.TotalFileCount.Equals(other.TotalFileCount)
                ) &&
                (
                    this.FileNames == other.FileNames ||
                    this.FileNames != null &&
                    this.FileNames.SequenceEqual(other.FileNames)
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

                if (this.SelectedTagsFileCount != null)
                    hash = hash * 59 + this.SelectedTagsFileCount.GetHashCode();

                if (this.TotalFileCount != null)
                    hash = hash * 59 + this.TotalFileCount.GetHashCode();

                if (this.FileNames != null)
                    hash = hash * 59 + this.FileNames.GetHashCode();

                return hash;
            }
        }
    }

}
