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
    /// CsvUploadResponse
    /// </summary>
    [DataContract]
    public partial class CsvUploadResponse :  IEquatable<CsvUploadResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CsvUploadResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CsvUploadResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CsvUploadResponse" /> class.
        /// </summary>
        /// <param name="UploadId">Id of the upload (required).</param>
        /// <param name="UploadUrl">Url for the upload (required).</param>
        /// <param name="UploadHeaders">Required headers for the upload (required).</param>
        public CsvUploadResponse(string UploadId = null, string UploadUrl = null, List<Header> UploadHeaders = null)
        {
            this.UploadId = UploadId;
            this.UploadUrl = UploadUrl;
            this.UploadHeaders = UploadHeaders;
            
        }
        


        /// <summary>
        /// Id of the upload
        /// </summary>
        /// <value>Id of the upload</value>
        [DataMember(Name="uploadId", EmitDefaultValue=false)]
        public string UploadId { get; set; }



        /// <summary>
        /// Url for the upload
        /// </summary>
        /// <value>Url for the upload</value>
        [DataMember(Name="uploadUrl", EmitDefaultValue=false)]
        public string UploadUrl { get; set; }



        /// <summary>
        /// Required headers for the upload
        /// </summary>
        /// <value>Required headers for the upload</value>
        [DataMember(Name="uploadHeaders", EmitDefaultValue=false)]
        public List<Header> UploadHeaders { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CsvUploadResponse {\n");

            sb.Append("  UploadId: ").Append(UploadId).Append("\n");
            sb.Append("  UploadUrl: ").Append(UploadUrl).Append("\n");
            sb.Append("  UploadHeaders: ").Append(UploadHeaders).Append("\n");
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
            return this.Equals(obj as CsvUploadResponse);
        }

        /// <summary>
        /// Returns true if CsvUploadResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CsvUploadResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsvUploadResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UploadId == other.UploadId ||
                    this.UploadId != null &&
                    this.UploadId.Equals(other.UploadId)
                ) &&
                (
                    this.UploadUrl == other.UploadUrl ||
                    this.UploadUrl != null &&
                    this.UploadUrl.Equals(other.UploadUrl)
                ) &&
                (
                    this.UploadHeaders == other.UploadHeaders ||
                    this.UploadHeaders != null &&
                    this.UploadHeaders.SequenceEqual(other.UploadHeaders)
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
                if (this.UploadId != null)
                    hash = hash * 59 + this.UploadId.GetHashCode();

                if (this.UploadUrl != null)
                    hash = hash * 59 + this.UploadUrl.GetHashCode();

                if (this.UploadHeaders != null)
                    hash = hash * 59 + this.UploadHeaders.GetHashCode();

                return hash;
            }
        }
    }

}
