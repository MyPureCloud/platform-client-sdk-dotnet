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
    /// V3SynchronizationFileDeletionRequest
    /// </summary>
    [DataContract]
    public partial class V3SynchronizationFileDeletionRequest :  IEquatable<V3SynchronizationFileDeletionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SynchronizationFileDeletionRequest" /> class.
        /// </summary>
        /// <param name="FileId">The identifier of the file to mark for deletion. Mutually exclusive with fileName..</param>
        /// <param name="FileName">Name of the file to mark for deletion. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|. Mutually exclusive with fileId..</param>
        public V3SynchronizationFileDeletionRequest(string FileId = null, string FileName = null)
        {
            this.FileId = FileId;
            this.FileName = FileName;
            
        }
        


        /// <summary>
        /// The identifier of the file to mark for deletion. Mutually exclusive with fileName.
        /// </summary>
        /// <value>The identifier of the file to mark for deletion. Mutually exclusive with fileName.</value>
        [DataMember(Name="fileId", EmitDefaultValue=false)]
        public string FileId { get; set; }



        /// <summary>
        /// Name of the file to mark for deletion. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|. Mutually exclusive with fileId.
        /// </summary>
        /// <value>Name of the file to mark for deletion. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|. Mutually exclusive with fileId.</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3SynchronizationFileDeletionRequest {\n");

            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
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
            return this.Equals(obj as V3SynchronizationFileDeletionRequest);
        }

        /// <summary>
        /// Returns true if V3SynchronizationFileDeletionRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SynchronizationFileDeletionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SynchronizationFileDeletionRequest other)
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

                return hash;
            }
        }
    }

}
