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
    /// V3SynchronizationUploadUrlResponse
    /// </summary>
    [DataContract]
    public partial class V3SynchronizationUploadUrlResponse :  IEquatable<V3SynchronizationUploadUrlResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SynchronizationUploadUrlResponse" /> class.
        /// </summary>
        /// <param name="Url">Pre-signed URL to PUT the file to..</param>
        /// <param name="Headers">Required headers when uploading a file through PUT request to the URL..</param>
        public V3SynchronizationUploadUrlResponse(string Url = null, Dictionary<string, string> Headers = null)
        {
            this.Url = Url;
            this.Headers = Headers;
            
        }
        


        /// <summary>
        /// Pre-signed URL to PUT the file to.
        /// </summary>
        /// <value>Pre-signed URL to PUT the file to.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// Required headers when uploading a file through PUT request to the URL.
        /// </summary>
        /// <value>Required headers when uploading a file through PUT request to the URL.</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public Dictionary<string, string> Headers { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3SynchronizationUploadUrlResponse {\n");

            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(obj as V3SynchronizationUploadUrlResponse);
        }

        /// <summary>
        /// Returns true if V3SynchronizationUploadUrlResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SynchronizationUploadUrlResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SynchronizationUploadUrlResponse other)
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

                if (this.Headers != null)
                    hash = hash * 59 + this.Headers.GetHashCode();

                return hash;
            }
        }
    }

}
