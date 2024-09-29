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
    /// ValidationServiceRequest
    /// </summary>
    [DataContract]
    public partial class ValidationServiceRequest :  IEquatable<ValidationServiceRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationServiceRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValidationServiceRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationServiceRequest" /> class.
        /// </summary>
        /// <param name="DateImportEnded">The last day of the data you are importing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="UploadKey">S3 key for the uploaded file (required).</param>
        /// <param name="FileName">Name of the uploaded file.</param>
        public ValidationServiceRequest(DateTime? DateImportEnded = null, string UploadKey = null, string FileName = null)
        {
            this.DateImportEnded = DateImportEnded;
            this.UploadKey = UploadKey;
            this.FileName = FileName;
            
        }
        


        /// <summary>
        /// The last day of the data you are importing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The last day of the data you are importing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateImportEnded", EmitDefaultValue=false)]
        public DateTime? DateImportEnded { get; set; }



        /// <summary>
        /// S3 key for the uploaded file
        /// </summary>
        /// <value>S3 key for the uploaded file</value>
        [DataMember(Name="uploadKey", EmitDefaultValue=false)]
        public string UploadKey { get; set; }



        /// <summary>
        /// Name of the uploaded file
        /// </summary>
        /// <value>Name of the uploaded file</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidationServiceRequest {\n");

            sb.Append("  DateImportEnded: ").Append(DateImportEnded).Append("\n");
            sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
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
            return this.Equals(obj as ValidationServiceRequest);
        }

        /// <summary>
        /// Returns true if ValidationServiceRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidationServiceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidationServiceRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateImportEnded == other.DateImportEnded ||
                    this.DateImportEnded != null &&
                    this.DateImportEnded.Equals(other.DateImportEnded)
                ) &&
                (
                    this.UploadKey == other.UploadKey ||
                    this.UploadKey != null &&
                    this.UploadKey.Equals(other.UploadKey)
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
                if (this.DateImportEnded != null)
                    hash = hash * 59 + this.DateImportEnded.GetHashCode();

                if (this.UploadKey != null)
                    hash = hash * 59 + this.UploadKey.GetHashCode();

                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();

                return hash;
            }
        }
    }

}
