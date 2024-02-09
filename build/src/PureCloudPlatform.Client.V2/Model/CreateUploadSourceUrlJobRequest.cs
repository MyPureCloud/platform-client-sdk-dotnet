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
    /// CreateUploadSourceUrlJobRequest
    /// </summary>
    [DataContract]
    public partial class CreateUploadSourceUrlJobRequest :  IEquatable<CreateUploadSourceUrlJobRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUploadSourceUrlJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateUploadSourceUrlJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUploadSourceUrlJobRequest" /> class.
        /// </summary>
        /// <param name="UploadUrl">The URL of the content to upload. (required).</param>
        public CreateUploadSourceUrlJobRequest(string UploadUrl = null)
        {
            this.UploadUrl = UploadUrl;
            
        }
        


        /// <summary>
        /// The URL of the content to upload.
        /// </summary>
        /// <value>The URL of the content to upload.</value>
        [DataMember(Name="uploadUrl", EmitDefaultValue=false)]
        public string UploadUrl { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUploadSourceUrlJobRequest {\n");

            sb.Append("  UploadUrl: ").Append(UploadUrl).Append("\n");
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
            return this.Equals(obj as CreateUploadSourceUrlJobRequest);
        }

        /// <summary>
        /// Returns true if CreateUploadSourceUrlJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateUploadSourceUrlJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUploadSourceUrlJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UploadUrl == other.UploadUrl ||
                    this.UploadUrl != null &&
                    this.UploadUrl.Equals(other.UploadUrl)
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
                if (this.UploadUrl != null)
                    hash = hash * 59 + this.UploadUrl.GetHashCode();

                return hash;
            }
        }
    }

}
