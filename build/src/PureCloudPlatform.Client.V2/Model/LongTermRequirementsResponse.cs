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
    /// LongTermRequirementsResponse
    /// </summary>
    [DataContract]
    public partial class LongTermRequirementsResponse :  IEquatable<LongTermRequirementsResponse>
    {
        /// <summary>
        /// Status of the long term forecast
        /// </summary>
        /// <value>Status of the long term forecast</value>
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
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        /// <summary>
        /// Error code when status is Failed
        /// </summary>
        /// <value>Error code when status is Failed</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ErrorCodeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Timedout for "TimedOut"
            /// </summary>
            [EnumMember(Value = "TimedOut")]
            Timedout,
            
            /// <summary>
            /// Enum Nodata for "NoData"
            /// </summary>
            [EnumMember(Value = "NoData")]
            Nodata,
            
            /// <summary>
            /// Enum Clientdatainvalid for "ClientDataInvalid"
            /// </summary>
            [EnumMember(Value = "ClientDataInvalid")]
            Clientdatainvalid,
            
            /// <summary>
            /// Enum Configurationinvalid for "ConfigurationInvalid"
            /// </summary>
            [EnumMember(Value = "ConfigurationInvalid")]
            Configurationinvalid,
            
            /// <summary>
            /// Enum Requirementsfailed for "RequirementsFailed"
            /// </summary>
            [EnumMember(Value = "RequirementsFailed")]
            Requirementsfailed
        }
        /// <summary>
        /// Status of the long term forecast
        /// </summary>
        /// <value>Status of the long term forecast</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Error code when status is Failed
        /// </summary>
        /// <value>Error code when status is Failed</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public ErrorCodeEnum? ErrorCode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LongTermRequirementsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LongTermRequirementsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LongTermRequirementsResponse" /> class.
        /// </summary>
        /// <param name="Status">Status of the long term forecast (required).</param>
        /// <param name="ErrorCode">Error code when status is Failed.</param>
        /// <param name="LongTermRequirements">For schema documentation only, always null, schema for staffing forecast result at downloadUrl.</param>
        /// <param name="DownloadUrl">Download URL for the staffing forecast result.</param>
        public LongTermRequirementsResponse(StatusEnum? Status = null, ErrorCodeEnum? ErrorCode = null, LongTermRequirements LongTermRequirements = null, string DownloadUrl = null)
        {
            this.Status = Status;
            this.ErrorCode = ErrorCode;
            this.LongTermRequirements = LongTermRequirements;
            this.DownloadUrl = DownloadUrl;
            
        }
        






        /// <summary>
        /// For schema documentation only, always null, schema for staffing forecast result at downloadUrl
        /// </summary>
        /// <value>For schema documentation only, always null, schema for staffing forecast result at downloadUrl</value>
        [DataMember(Name="longTermRequirements", EmitDefaultValue=false)]
        public LongTermRequirements LongTermRequirements { get; set; }



        /// <summary>
        /// Download URL for the staffing forecast result
        /// </summary>
        /// <value>Download URL for the staffing forecast result</value>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LongTermRequirementsResponse {\n");

            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  LongTermRequirements: ").Append(LongTermRequirements).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
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
            return this.Equals(obj as LongTermRequirementsResponse);
        }

        /// <summary>
        /// Returns true if LongTermRequirementsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LongTermRequirementsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LongTermRequirementsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.LongTermRequirements == other.LongTermRequirements ||
                    this.LongTermRequirements != null &&
                    this.LongTermRequirements.Equals(other.LongTermRequirements)
                ) &&
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();

                if (this.LongTermRequirements != null)
                    hash = hash * 59 + this.LongTermRequirements.GetHashCode();

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                return hash;
            }
        }
    }

}
