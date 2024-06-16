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
    /// Learning SCORM upload response
    /// </summary>
    [DataContract]
    public partial class LearningScormUploadResponse :  IEquatable<LearningScormUploadResponse>
    {
        /// <summary>
        /// The status of the SCORM package
        /// </summary>
        /// <value>The status of the SCORM package</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Uploadpending for "UploadPending"
            /// </summary>
            [EnumMember(Value = "UploadPending")]
            Uploadpending,
            
            /// <summary>
            /// Enum Unpacking for "Unpacking"
            /// </summary>
            [EnumMember(Value = "Unpacking")]
            Unpacking,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Ready for "Ready"
            /// </summary>
            [EnumMember(Value = "Ready")]
            Ready
        }
        /// <summary>
        /// The status of the SCORM package
        /// </summary>
        /// <value>The status of the SCORM package</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningScormUploadResponse" /> class.
        /// </summary>
        /// <param name="Status">The status of the SCORM package.</param>
        /// <param name="UploadUrl">The pre-signed URL. Use it with headers below to upload file to S3.</param>
        /// <param name="Headers">The additional headers that need to be included in the upload request.</param>
        public LearningScormUploadResponse(StatusEnum? Status = null, string UploadUrl = null, Dictionary<string, string> Headers = null)
        {
            this.Status = Status;
            this.UploadUrl = UploadUrl;
            this.Headers = Headers;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }





        /// <summary>
        /// The pre-signed URL. Use it with headers below to upload file to S3
        /// </summary>
        /// <value>The pre-signed URL. Use it with headers below to upload file to S3</value>
        [DataMember(Name="uploadUrl", EmitDefaultValue=false)]
        public string UploadUrl { get; set; }



        /// <summary>
        /// The additional headers that need to be included in the upload request
        /// </summary>
        /// <value>The additional headers that need to be included in the upload request</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public Dictionary<string, string> Headers { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningScormUploadResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UploadUrl: ").Append(UploadUrl).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as LearningScormUploadResponse);
        }

        /// <summary>
        /// Returns true if LearningScormUploadResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningScormUploadResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningScormUploadResponse other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.UploadUrl == other.UploadUrl ||
                    this.UploadUrl != null &&
                    this.UploadUrl.Equals(other.UploadUrl)
                ) &&
                (
                    this.Headers == other.Headers ||
                    this.Headers != null &&
                    this.Headers.SequenceEqual(other.Headers)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.UploadUrl != null)
                    hash = hash * 59 + this.UploadUrl.GetHashCode();

                if (this.Headers != null)
                    hash = hash * 59 + this.Headers.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
