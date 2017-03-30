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
    /// ReplaceResponse
    /// </summary>
    [DataContract]
    public partial class ReplaceResponse :  IEquatable<ReplaceResponse>
    {
        /// <summary>
        /// Gets or Sets UploadMethod
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UploadMethodEnum
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
        /// Gets or Sets UploadMethod
        /// </summary>
        [DataMember(Name="uploadMethod", EmitDefaultValue=false)]
        public UploadMethodEnum? UploadMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceResponse" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="ChangeNumber">ChangeNumber.</param>
        /// <param name="UploadStatus">UploadStatus.</param>
        /// <param name="UploadDestinationUri">UploadDestinationUri.</param>
        /// <param name="UploadMethod">UploadMethod.</param>
        public ReplaceResponse(string Id = null, string Name = null, int? ChangeNumber = null, UriReference UploadStatus = null, string UploadDestinationUri = null, UploadMethodEnum? UploadMethod = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.ChangeNumber = ChangeNumber;
            this.UploadStatus = UploadStatus;
            this.UploadDestinationUri = UploadDestinationUri;
            this.UploadMethod = UploadMethod;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets ChangeNumber
        /// </summary>
        [DataMember(Name="changeNumber", EmitDefaultValue=false)]
        public int? ChangeNumber { get; set; }
        /// <summary>
        /// Gets or Sets UploadStatus
        /// </summary>
        [DataMember(Name="uploadStatus", EmitDefaultValue=false)]
        public UriReference UploadStatus { get; set; }
        /// <summary>
        /// Gets or Sets UploadDestinationUri
        /// </summary>
        [DataMember(Name="uploadDestinationUri", EmitDefaultValue=false)]
        public string UploadDestinationUri { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplaceResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ChangeNumber: ").Append(ChangeNumber).Append("\n");
            sb.Append("  UploadStatus: ").Append(UploadStatus).Append("\n");
            sb.Append("  UploadDestinationUri: ").Append(UploadDestinationUri).Append("\n");
            sb.Append("  UploadMethod: ").Append(UploadMethod).Append("\n");
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
            return this.Equals(obj as ReplaceResponse);
        }

        /// <summary>
        /// Returns true if ReplaceResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ReplaceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplaceResponse other)
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
                    this.ChangeNumber == other.ChangeNumber ||
                    this.ChangeNumber != null &&
                    this.ChangeNumber.Equals(other.ChangeNumber)
                ) &&
                (
                    this.UploadStatus == other.UploadStatus ||
                    this.UploadStatus != null &&
                    this.UploadStatus.Equals(other.UploadStatus)
                ) &&
                (
                    this.UploadDestinationUri == other.UploadDestinationUri ||
                    this.UploadDestinationUri != null &&
                    this.UploadDestinationUri.Equals(other.UploadDestinationUri)
                ) &&
                (
                    this.UploadMethod == other.UploadMethod ||
                    this.UploadMethod != null &&
                    this.UploadMethod.Equals(other.UploadMethod)
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
                if (this.ChangeNumber != null)
                    hash = hash * 59 + this.ChangeNumber.GetHashCode();
                if (this.UploadStatus != null)
                    hash = hash * 59 + this.UploadStatus.GetHashCode();
                if (this.UploadDestinationUri != null)
                    hash = hash * 59 + this.UploadDestinationUri.GetHashCode();
                if (this.UploadMethod != null)
                    hash = hash * 59 + this.UploadMethod.GetHashCode();
                return hash;
            }
        }
    }

}
