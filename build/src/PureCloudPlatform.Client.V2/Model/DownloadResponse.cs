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
    /// DownloadResponse
    /// </summary>
    [DataContract]
    public partial class DownloadResponse :  IEquatable<DownloadResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadResponse" /> class.
        /// </summary>
        /// <param name="ContentLocationUri">ContentLocationUri.</param>
        /// <param name="ImageUri">ImageUri.</param>
        /// <param name="Thumbnails">Thumbnails.</param>
        public DownloadResponse(string ContentLocationUri = null, string ImageUri = null, List<DocumentThumbnail> Thumbnails = null)
        {
            this.ContentLocationUri = ContentLocationUri;
            this.ImageUri = ImageUri;
            this.Thumbnails = Thumbnails;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets ContentLocationUri
        /// </summary>
        [DataMember(Name="contentLocationUri", EmitDefaultValue=false)]
        public string ContentLocationUri { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ImageUri
        /// </summary>
        [DataMember(Name="imageUri", EmitDefaultValue=false)]
        public string ImageUri { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Thumbnails
        /// </summary>
        [DataMember(Name="thumbnails", EmitDefaultValue=false)]
        public List<DocumentThumbnail> Thumbnails { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadResponse {\n");
            
            sb.Append("  ContentLocationUri: ").Append(ContentLocationUri).Append("\n");
            sb.Append("  ImageUri: ").Append(ImageUri).Append("\n");
            sb.Append("  Thumbnails: ").Append(Thumbnails).Append("\n");
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
            return this.Equals(obj as DownloadResponse);
        }

        /// <summary>
        /// Returns true if DownloadResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DownloadResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DownloadResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContentLocationUri == other.ContentLocationUri ||
                    this.ContentLocationUri != null &&
                    this.ContentLocationUri.Equals(other.ContentLocationUri)
                ) &&
                (
                    this.ImageUri == other.ImageUri ||
                    this.ImageUri != null &&
                    this.ImageUri.Equals(other.ImageUri)
                ) &&
                (
                    this.Thumbnails == other.Thumbnails ||
                    this.Thumbnails != null &&
                    this.Thumbnails.SequenceEqual(other.Thumbnails)
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
                
                if (this.ContentLocationUri != null)
                    hash = hash * 59 + this.ContentLocationUri.GetHashCode();
                
                if (this.ImageUri != null)
                    hash = hash * 59 + this.ImageUri.GetHashCode();
                
                if (this.Thumbnails != null)
                    hash = hash * 59 + this.Thumbnails.GetHashCode();
                
                return hash;
            }
        }
    }

}
