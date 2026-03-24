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
    /// V3SourceFolderDetails
    /// </summary>
    [DataContract]
    public partial class V3SourceFolderDetails :  IEquatable<V3SourceFolderDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SourceFolderDetails" /> class.
        /// </summary>
        /// <param name="Id">The folder&#39;s id..</param>
        /// <param name="Name">The folder&#39;s display name..</param>
        /// <param name="FullPath">The folder&#39;s full path from the root..</param>
        public V3SourceFolderDetails(string Id = null, string Name = null, string FullPath = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.FullPath = FullPath;
            
        }
        


        /// <summary>
        /// The folder&#39;s id.
        /// </summary>
        /// <value>The folder&#39;s id.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The folder&#39;s display name.
        /// </summary>
        /// <value>The folder&#39;s display name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The folder&#39;s full path from the root.
        /// </summary>
        /// <value>The folder&#39;s full path from the root.</value>
        [DataMember(Name="fullPath", EmitDefaultValue=false)]
        public string FullPath { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3SourceFolderDetails {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FullPath: ").Append(FullPath).Append("\n");
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
            return this.Equals(obj as V3SourceFolderDetails);
        }

        /// <summary>
        /// Returns true if V3SourceFolderDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SourceFolderDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SourceFolderDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.FullPath == other.FullPath ||
                    this.FullPath != null &&
                    this.FullPath.Equals(other.FullPath)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.FullPath != null)
                    hash = hash * 59 + this.FullPath.GetHashCode();

                return hash;
            }
        }
    }

}
