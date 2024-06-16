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
    /// Action function URL upload input.
    /// </summary>
    [DataContract]
    public partial class FunctionUploadRequest :  IEquatable<FunctionUploadRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionUploadRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FunctionUploadRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionUploadRequest" /> class.
        /// </summary>
        /// <param name="FileName">Name of the file to upload.File name can only contain letters, numbers, and the following special characters: + - _ . ' ( ) (required).</param>
        /// <param name="SignedUrlTimeoutSeconds">The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 900 seconds.</param>
        public FunctionUploadRequest(string FileName = null, int? SignedUrlTimeoutSeconds = null)
        {
            this.FileName = FileName;
            this.SignedUrlTimeoutSeconds = SignedUrlTimeoutSeconds;
            
        }
        


        /// <summary>
        /// Name of the file to upload.File name can only contain letters, numbers, and the following special characters: + - _ . ' ( )
        /// </summary>
        /// <value>Name of the file to upload.File name can only contain letters, numbers, and the following special characters: + - _ . ' ( )</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }



        /// <summary>
        /// The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 900 seconds
        /// </summary>
        /// <value>The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 900 seconds</value>
        [DataMember(Name="signedUrlTimeoutSeconds", EmitDefaultValue=false)]
        public int? SignedUrlTimeoutSeconds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FunctionUploadRequest {\n");

            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  SignedUrlTimeoutSeconds: ").Append(SignedUrlTimeoutSeconds).Append("\n");
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
            return this.Equals(obj as FunctionUploadRequest);
        }

        /// <summary>
        /// Returns true if FunctionUploadRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of FunctionUploadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FunctionUploadRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
                ) &&
                (
                    this.SignedUrlTimeoutSeconds == other.SignedUrlTimeoutSeconds ||
                    this.SignedUrlTimeoutSeconds != null &&
                    this.SignedUrlTimeoutSeconds.Equals(other.SignedUrlTimeoutSeconds)
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
                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();

                if (this.SignedUrlTimeoutSeconds != null)
                    hash = hash * 59 + this.SignedUrlTimeoutSeconds.GetHashCode();

                return hash;
            }
        }
    }

}
