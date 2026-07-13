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
    /// V3SynchronizationDeletion
    /// </summary>
    [DataContract]
    public partial class V3SynchronizationDeletion :  IEquatable<V3SynchronizationDeletion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SynchronizationDeletion" /> class.
        /// </summary>
        /// <param name="FileId">The unique identifier for the deletion object..</param>
        /// <param name="FileName">Name of the file marked for deletion..</param>
        /// <param name="Synchronization">The synchronization of the file deletion..</param>
        public V3SynchronizationDeletion(string FileId = null, string FileName = null, V3SynchronizationRef Synchronization = null)
        {
            this.FileId = FileId;
            this.FileName = FileName;
            this.Synchronization = Synchronization;
            
        }
        


        /// <summary>
        /// The unique identifier for the deletion object.
        /// </summary>
        /// <value>The unique identifier for the deletion object.</value>
        [DataMember(Name="fileId", EmitDefaultValue=false)]
        public string FileId { get; set; }



        /// <summary>
        /// Name of the file marked for deletion.
        /// </summary>
        /// <value>Name of the file marked for deletion.</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }



        /// <summary>
        /// The synchronization of the file deletion.
        /// </summary>
        /// <value>The synchronization of the file deletion.</value>
        [DataMember(Name="synchronization", EmitDefaultValue=false)]
        public V3SynchronizationRef Synchronization { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3SynchronizationDeletion {\n");

            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Synchronization: ").Append(Synchronization).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as V3SynchronizationDeletion);
        }

        /// <summary>
        /// Returns true if V3SynchronizationDeletion instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SynchronizationDeletion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SynchronizationDeletion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FileId == other.FileId ||
                    this.FileId != null &&
                    this.FileId.Equals(other.FileId)
                ) &&
                (
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
                ) &&
                (
                    this.Synchronization == other.Synchronization ||
                    this.Synchronization != null &&
                    this.Synchronization.Equals(other.Synchronization)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.FileId != null)
                    hash = hash * 59 + this.FileId.GetHashCode();

                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();

                if (this.Synchronization != null)
                    hash = hash * 59 + this.Synchronization.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
