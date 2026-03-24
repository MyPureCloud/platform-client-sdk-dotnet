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
    /// V3SynchronizationUploadMetadata
    /// </summary>
    [DataContract]
    public partial class V3SynchronizationUploadMetadata :  IEquatable<V3SynchronizationUploadMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SynchronizationUploadMetadata" /> class.
        /// </summary>
        /// <param name="OriginUri">The origin URI of the file to upload.</param>
        /// <param name="Tags">List of tags that is used for filtering.</param>
        public V3SynchronizationUploadMetadata(string OriginUri = null, List<FabricTag> Tags = null)
        {
            this.OriginUri = OriginUri;
            this.Tags = Tags;
            
        }
        


        /// <summary>
        /// The origin URI of the file to upload
        /// </summary>
        /// <value>The origin URI of the file to upload</value>
        [DataMember(Name="originUri", EmitDefaultValue=false)]
        public string OriginUri { get; set; }



        /// <summary>
        /// List of tags that is used for filtering
        /// </summary>
        /// <value>List of tags that is used for filtering</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<FabricTag> Tags { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3SynchronizationUploadMetadata {\n");

            sb.Append("  OriginUri: ").Append(OriginUri).Append("\n");
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
            return this.Equals(obj as V3SynchronizationUploadMetadata);
        }

        /// <summary>
        /// Returns true if V3SynchronizationUploadMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SynchronizationUploadMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SynchronizationUploadMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OriginUri == other.OriginUri ||
                    this.OriginUri != null &&
                    this.OriginUri.Equals(other.OriginUri)
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
                if (this.OriginUri != null)
                    hash = hash * 59 + this.OriginUri.GetHashCode();

                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();

                return hash;
            }
        }
    }

}
