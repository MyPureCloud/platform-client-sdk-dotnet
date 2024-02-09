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
    /// GetUploadSourceUrlJobStatusResponse
    /// </summary>
    [DataContract]
    public partial class GetUploadSourceUrlJobStatusResponse :  IEquatable<GetUploadSourceUrlJobStatusResponse>
    {
        /// <summary>
        /// Status of the upload job
        /// </summary>
        /// <value>Status of the upload job</value>
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
            /// Enum Created for "Created"
            /// </summary>
            [EnumMember(Value = "Created")]
            Created,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed
        }
        /// <summary>
        /// Status of the upload job
        /// </summary>
        /// <value>Status of the upload job</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUploadSourceUrlJobStatusResponse" /> class.
        /// </summary>
        /// <param name="Id">Id of the upload from URL job..</param>
        /// <param name="Status">Status of the upload job.</param>
        /// <param name="UploadKey">Key that identifies the file in the storage including the file name.</param>
        /// <param name="ErrorInformation">Any error information, or null of the processing is not in failed state..</param>
        public GetUploadSourceUrlJobStatusResponse(string Id = null, StatusEnum? Status = null, string UploadKey = null, ErrorBody ErrorInformation = null)
        {
            this.Id = Id;
            this.Status = Status;
            this.UploadKey = UploadKey;
            this.ErrorInformation = ErrorInformation;
            
        }
        


        /// <summary>
        /// Id of the upload from URL job.
        /// </summary>
        /// <value>Id of the upload from URL job.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }





        /// <summary>
        /// Key that identifies the file in the storage including the file name
        /// </summary>
        /// <value>Key that identifies the file in the storage including the file name</value>
        [DataMember(Name="uploadKey", EmitDefaultValue=false)]
        public string UploadKey { get; set; }



        /// <summary>
        /// Any error information, or null of the processing is not in failed state.
        /// </summary>
        /// <value>Any error information, or null of the processing is not in failed state.</value>
        [DataMember(Name="errorInformation", EmitDefaultValue=false)]
        public ErrorBody ErrorInformation { get; set; }



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
            sb.Append("class GetUploadSourceUrlJobStatusResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
            sb.Append("  ErrorInformation: ").Append(ErrorInformation).Append("\n");
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
            return this.Equals(obj as GetUploadSourceUrlJobStatusResponse);
        }

        /// <summary>
        /// Returns true if GetUploadSourceUrlJobStatusResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GetUploadSourceUrlJobStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUploadSourceUrlJobStatusResponse other)
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
                    this.UploadKey == other.UploadKey ||
                    this.UploadKey != null &&
                    this.UploadKey.Equals(other.UploadKey)
                ) &&
                (
                    this.ErrorInformation == other.ErrorInformation ||
                    this.ErrorInformation != null &&
                    this.ErrorInformation.Equals(other.ErrorInformation)
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

                if (this.UploadKey != null)
                    hash = hash * 59 + this.UploadKey.GetHashCode();

                if (this.ErrorInformation != null)
                    hash = hash * 59 + this.ErrorInformation.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
