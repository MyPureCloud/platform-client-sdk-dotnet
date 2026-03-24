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
    /// V3SourceFilter
    /// </summary>
    [DataContract]
    public partial class V3SourceFilter :  IEquatable<V3SourceFilter>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="V3SourceFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V3SourceFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SourceFilter" /> class.
        /// </summary>
        /// <param name="Site">The site from which to sync data. (required).</param>
        /// <param name="Folders">The folders from which to sync data. (required).</param>
        public V3SourceFilter(string Site = null, List<string> Folders = null)
        {
            this.Site = Site;
            this.Folders = Folders;
            
        }
        


        /// <summary>
        /// The site from which to sync data.
        /// </summary>
        /// <value>The site from which to sync data.</value>
        [DataMember(Name="site", EmitDefaultValue=false)]
        public string Site { get; set; }



        /// <summary>
        /// The folders from which to sync data.
        /// </summary>
        /// <value>The folders from which to sync data.</value>
        [DataMember(Name="folders", EmitDefaultValue=false)]
        public List<string> Folders { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3SourceFilter {\n");

            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  Folders: ").Append(Folders).Append("\n");
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
            return this.Equals(obj as V3SourceFilter);
        }

        /// <summary>
        /// Returns true if V3SourceFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SourceFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SourceFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Site == other.Site ||
                    this.Site != null &&
                    this.Site.Equals(other.Site)
                ) &&
                (
                    this.Folders == other.Folders ||
                    this.Folders != null &&
                    this.Folders.SequenceEqual(other.Folders)
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
                if (this.Site != null)
                    hash = hash * 59 + this.Site.GetHashCode();

                if (this.Folders != null)
                    hash = hash * 59 + this.Folders.GetHashCode();

                return hash;
            }
        }
    }

}
