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
    /// UploadUrlResponse
    /// </summary>
    [DataContract]
    public partial class UploadUrlResponse :  IEquatable<UploadUrlResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadUrlResponse" /> class.
        /// </summary>
        /// <param name="Headers">Required headers when uploading a file through PUT request to the URL.</param>
        public UploadUrlResponse(Dictionary<string, string> Headers = null)
        {
            this.Headers = Headers;
            
        }
        
        
        
        /// <summary>
        /// Presigned URL to PUT the file to
        /// </summary>
        /// <value>Presigned URL to PUT the file to</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; private set; }
        
        
        
        /// <summary>
        /// Key that identifies the file in the storage including the file name
        /// </summary>
        /// <value>Key that identifies the file in the storage including the file name</value>
        [DataMember(Name="uploadKey", EmitDefaultValue=false)]
        public string UploadKey { get; private set; }
        
        
        
        /// <summary>
        /// Required headers when uploading a file through PUT request to the URL
        /// </summary>
        /// <value>Required headers when uploading a file through PUT request to the URL</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public Dictionary<string, string> Headers { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadUrlResponse {\n");
            
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
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
            return this.Equals(obj as UploadUrlResponse);
        }

        /// <summary>
        /// Returns true if UploadUrlResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UploadUrlResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadUrlResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.UploadKey == other.UploadKey ||
                    this.UploadKey != null &&
                    this.UploadKey.Equals(other.UploadKey)
                ) &&
                (
                    this.Headers == other.Headers ||
                    this.Headers != null &&
                    this.Headers.SequenceEqual(other.Headers)
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
                
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                
                if (this.UploadKey != null)
                    hash = hash * 59 + this.UploadKey.GetHashCode();
                
                if (this.Headers != null)
                    hash = hash * 59 + this.Headers.GetHashCode();
                
                return hash;
            }
        }
    }

}
