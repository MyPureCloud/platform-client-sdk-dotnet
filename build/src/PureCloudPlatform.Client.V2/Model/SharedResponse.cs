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
    /// SharedResponse
    /// </summary>
    [DataContract]
    public partial class SharedResponse :  IEquatable<SharedResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedResponse" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="DownloadUri">DownloadUri.</param>
        /// <param name="ViewUri">ViewUri.</param>
        /// <param name="Document">Document.</param>
        /// <param name="Share">Share.</param>
        public SharedResponse(string Id = null, string DownloadUri = null, string ViewUri = null, Document Document = null, Share Share = null)
        {
            this.Id = Id;
            this.DownloadUri = DownloadUri;
            this.ViewUri = ViewUri;
            this.Document = Document;
            this.Share = Share;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DownloadUri
        /// </summary>
        [DataMember(Name="downloadUri", EmitDefaultValue=false)]
        public string DownloadUri { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ViewUri
        /// </summary>
        [DataMember(Name="viewUri", EmitDefaultValue=false)]
        public string ViewUri { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public Document Document { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Share
        /// </summary>
        [DataMember(Name="share", EmitDefaultValue=false)]
        public Share Share { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharedResponse {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DownloadUri: ").Append(DownloadUri).Append("\n");
            sb.Append("  ViewUri: ").Append(ViewUri).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
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
            return this.Equals(obj as SharedResponse);
        }

        /// <summary>
        /// Returns true if SharedResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SharedResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharedResponse other)
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
                    this.DownloadUri == other.DownloadUri ||
                    this.DownloadUri != null &&
                    this.DownloadUri.Equals(other.DownloadUri)
                ) &&
                (
                    this.ViewUri == other.ViewUri ||
                    this.ViewUri != null &&
                    this.ViewUri.Equals(other.ViewUri)
                ) &&
                (
                    this.Document == other.Document ||
                    this.Document != null &&
                    this.Document.Equals(other.Document)
                ) &&
                (
                    this.Share == other.Share ||
                    this.Share != null &&
                    this.Share.Equals(other.Share)
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
                
                if (this.DownloadUri != null)
                    hash = hash * 59 + this.DownloadUri.GetHashCode();
                
                if (this.ViewUri != null)
                    hash = hash * 59 + this.ViewUri.GetHashCode();
                
                if (this.Document != null)
                    hash = hash * 59 + this.Document.GetHashCode();
                
                if (this.Share != null)
                    hash = hash * 59 + this.Share.GetHashCode();
                
                return hash;
            }
        }
    }

}
