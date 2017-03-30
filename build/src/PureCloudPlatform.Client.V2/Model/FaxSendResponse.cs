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
    /// FaxSendResponse
    /// </summary>
    [DataContract]
    public partial class FaxSendResponse :  IEquatable<FaxSendResponse>
    {
        /// <summary>
        /// Gets or Sets UploadMethodType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UploadMethodTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum SinglePut for "SINGLE_PUT"
            /// </summary>
            [EnumMember(Value = "SINGLE_PUT")]
            SinglePut,
            
            /// <summary>
            /// Enum MultipartPost for "MULTIPART_POST"
            /// </summary>
            [EnumMember(Value = "MULTIPART_POST")]
            MultipartPost
        }
        /// <summary>
        /// Gets or Sets UploadMethodType
        /// </summary>
        [DataMember(Name="uploadMethodType", EmitDefaultValue=false)]
        public UploadMethodTypeEnum? UploadMethodType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FaxSendResponse" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="UploadDestinationUri">UploadDestinationUri.</param>
        /// <param name="UploadMethodType">UploadMethodType.</param>
        public FaxSendResponse(string Name = null, string UploadDestinationUri = null, UploadMethodTypeEnum? UploadMethodType = null)
        {
            this.Name = Name;
            this.UploadDestinationUri = UploadDestinationUri;
            this.UploadMethodType = UploadMethodType;
        }
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets UploadDestinationUri
        /// </summary>
        [DataMember(Name="uploadDestinationUri", EmitDefaultValue=false)]
        public string UploadDestinationUri { get; set; }
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
            sb.Append("class FaxSendResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UploadDestinationUri: ").Append(UploadDestinationUri).Append("\n");
            sb.Append("  UploadMethodType: ").Append(UploadMethodType).Append("\n");
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
            return this.Equals(obj as FaxSendResponse);
        }

        /// <summary>
        /// Returns true if FaxSendResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of FaxSendResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaxSendResponse other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.UploadDestinationUri == other.UploadDestinationUri ||
                    this.UploadDestinationUri != null &&
                    this.UploadDestinationUri.Equals(other.UploadDestinationUri)
                ) &&
                (
                    this.UploadMethodType == other.UploadMethodType ||
                    this.UploadMethodType != null &&
                    this.UploadMethodType.Equals(other.UploadMethodType)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.UploadDestinationUri != null)
                    hash = hash * 59 + this.UploadDestinationUri.GetHashCode();
                if (this.UploadMethodType != null)
                    hash = hash * 59 + this.UploadMethodType.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
