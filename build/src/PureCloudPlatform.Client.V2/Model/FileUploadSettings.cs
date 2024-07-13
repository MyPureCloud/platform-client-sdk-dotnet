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
    /// File upload settings for messenger
    /// </summary>
    [DataContract]
    public partial class FileUploadSettings :  IEquatable<FileUploadSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadSettings" /> class.
        /// </summary>
        /// <param name="EnableAttachments">whether or not attachments are enabled.</param>
        /// <param name="Modes">The list of supported file upload modes.</param>
        public FileUploadSettings(bool? EnableAttachments = null, List<FileUploadMode> Modes = null)
        {
            this.EnableAttachments = EnableAttachments;
            this.Modes = Modes;
            
        }
        


        /// <summary>
        /// whether or not attachments are enabled
        /// </summary>
        /// <value>whether or not attachments are enabled</value>
        [DataMember(Name="enableAttachments", EmitDefaultValue=false)]
        public bool? EnableAttachments { get; set; }



        /// <summary>
        /// The list of supported file upload modes
        /// </summary>
        /// <value>The list of supported file upload modes</value>
        [DataMember(Name="modes", EmitDefaultValue=false)]
        public List<FileUploadMode> Modes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileUploadSettings {\n");

            sb.Append("  EnableAttachments: ").Append(EnableAttachments).Append("\n");
            sb.Append("  Modes: ").Append(Modes).Append("\n");
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
            return this.Equals(obj as FileUploadSettings);
        }

        /// <summary>
        /// Returns true if FileUploadSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of FileUploadSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileUploadSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EnableAttachments == other.EnableAttachments ||
                    this.EnableAttachments != null &&
                    this.EnableAttachments.Equals(other.EnableAttachments)
                ) &&
                (
                    this.Modes == other.Modes ||
                    this.Modes != null &&
                    this.Modes.SequenceEqual(other.Modes)
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
                if (this.EnableAttachments != null)
                    hash = hash * 59 + this.EnableAttachments.GetHashCode();

                if (this.Modes != null)
                    hash = hash * 59 + this.Modes.GetHashCode();

                return hash;
            }
        }
    }

}
