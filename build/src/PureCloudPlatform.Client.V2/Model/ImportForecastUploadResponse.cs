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
    /// ImportForecastUploadResponse
    /// </summary>
    [DataContract]
    public partial class ImportForecastUploadResponse :  IEquatable<ImportForecastUploadResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportForecastUploadResponse" /> class.
        /// </summary>
        /// <param name="UploadKey">The key to pass to the secondary request to start processing of the upload.</param>
        /// <param name="Url">The url to which to PUT the upload body.</param>
        /// <param name="Headers">Required headers for the PUT request to the url.</param>
        /// <param name="UploadBodySchema">Always null. Defines the schema of the json body to be PUT to the url. The json body should be gzip encoded before uploading.</param>
        public ImportForecastUploadResponse(string UploadKey = null, string Url = null, Dictionary<string, string> Headers = null, BuImportShortTermForecastSchema UploadBodySchema = null)
        {
            this.UploadKey = UploadKey;
            this.Url = Url;
            this.Headers = Headers;
            this.UploadBodySchema = UploadBodySchema;
            
        }
        


        /// <summary>
        /// The key to pass to the secondary request to start processing of the upload
        /// </summary>
        /// <value>The key to pass to the secondary request to start processing of the upload</value>
        [DataMember(Name="uploadKey", EmitDefaultValue=false)]
        public string UploadKey { get; set; }



        /// <summary>
        /// The url to which to PUT the upload body
        /// </summary>
        /// <value>The url to which to PUT the upload body</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// Required headers for the PUT request to the url
        /// </summary>
        /// <value>Required headers for the PUT request to the url</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public Dictionary<string, string> Headers { get; set; }



        /// <summary>
        /// Always null. Defines the schema of the json body to be PUT to the url. The json body should be gzip encoded before uploading
        /// </summary>
        /// <value>Always null. Defines the schema of the json body to be PUT to the url. The json body should be gzip encoded before uploading</value>
        [DataMember(Name="uploadBodySchema", EmitDefaultValue=false)]
        public BuImportShortTermForecastSchema UploadBodySchema { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportForecastUploadResponse {\n");

            sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  UploadBodySchema: ").Append(UploadBodySchema).Append("\n");
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
            return this.Equals(obj as ImportForecastUploadResponse);
        }

        /// <summary>
        /// Returns true if ImportForecastUploadResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportForecastUploadResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportForecastUploadResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UploadKey == other.UploadKey ||
                    this.UploadKey != null &&
                    this.UploadKey.Equals(other.UploadKey)
                ) &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.Headers == other.Headers ||
                    this.Headers != null &&
                    this.Headers.SequenceEqual(other.Headers)
                ) &&
                (
                    this.UploadBodySchema == other.UploadBodySchema ||
                    this.UploadBodySchema != null &&
                    this.UploadBodySchema.Equals(other.UploadBodySchema)
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
                if (this.UploadKey != null)
                    hash = hash * 59 + this.UploadKey.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.Headers != null)
                    hash = hash * 59 + this.Headers.GetHashCode();

                if (this.UploadBodySchema != null)
                    hash = hash * 59 + this.UploadBodySchema.GetHashCode();

                return hash;
            }
        }
    }

}
