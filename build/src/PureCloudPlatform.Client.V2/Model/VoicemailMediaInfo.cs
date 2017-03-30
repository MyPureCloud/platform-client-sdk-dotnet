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
    /// VoicemailMediaInfo
    /// </summary>
    [DataContract]
    public partial class VoicemailMediaInfo :  IEquatable<VoicemailMediaInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailMediaInfo" /> class.
        /// </summary>
        /// <param name="MediaFileUri">MediaFileUri.</param>
        /// <param name="MediaImageUri">MediaImageUri.</param>
        public VoicemailMediaInfo(string MediaFileUri = null, string MediaImageUri = null)
        {
            this.MediaFileUri = MediaFileUri;
            this.MediaImageUri = MediaImageUri;
        }
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Gets or Sets MediaFileUri
        /// </summary>
        [DataMember(Name="mediaFileUri", EmitDefaultValue=false)]
        public string MediaFileUri { get; set; }
        /// <summary>
        /// Gets or Sets MediaImageUri
        /// </summary>
        [DataMember(Name="mediaImageUri", EmitDefaultValue=false)]
        public string MediaImageUri { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicemailMediaInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MediaFileUri: ").Append(MediaFileUri).Append("\n");
            sb.Append("  MediaImageUri: ").Append(MediaImageUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as VoicemailMediaInfo);
        }

        /// <summary>
        /// Returns true if VoicemailMediaInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of VoicemailMediaInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicemailMediaInfo other)
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
                    this.MediaFileUri == other.MediaFileUri ||
                    this.MediaFileUri != null &&
                    this.MediaFileUri.Equals(other.MediaFileUri)
                ) &&
                (
                    this.MediaImageUri == other.MediaImageUri ||
                    this.MediaImageUri != null &&
                    this.MediaImageUri.Equals(other.MediaImageUri)
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
                if (this.MediaFileUri != null)
                    hash = hash * 59 + this.MediaFileUri.GetHashCode();
                if (this.MediaImageUri != null)
                    hash = hash * 59 + this.MediaImageUri.GetHashCode();
                return hash;
            }
        }
    }

}
