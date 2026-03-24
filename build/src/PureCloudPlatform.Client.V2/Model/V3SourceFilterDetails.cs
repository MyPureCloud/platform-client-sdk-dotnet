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
    /// V3SourceFilterDetails
    /// </summary>
    [DataContract]
    public partial class V3SourceFilterDetails :  IEquatable<V3SourceFilterDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SourceFilterDetails" /> class.
        /// </summary>
        /// <param name="Site">Details about the site associated with the Fabric Source..</param>
        /// <param name="Folders">Details about the folders associated with the Fabric Source..</param>
        public V3SourceFilterDetails(V3SourceSiteDetails Site = null, List<V3SourceFolderDetails> Folders = null)
        {
            this.Site = Site;
            this.Folders = Folders;
            
        }
        


        /// <summary>
        /// Details about the site associated with the Fabric Source.
        /// </summary>
        /// <value>Details about the site associated with the Fabric Source.</value>
        [DataMember(Name="site", EmitDefaultValue=false)]
        public V3SourceSiteDetails Site { get; set; }



        /// <summary>
        /// Details about the folders associated with the Fabric Source.
        /// </summary>
        /// <value>Details about the folders associated with the Fabric Source.</value>
        [DataMember(Name="folders", EmitDefaultValue=false)]
        public List<V3SourceFolderDetails> Folders { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3SourceFilterDetails {\n");

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
            return this.Equals(obj as V3SourceFilterDetails);
        }

        /// <summary>
        /// Returns true if V3SourceFilterDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SourceFilterDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SourceFilterDetails other)
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
