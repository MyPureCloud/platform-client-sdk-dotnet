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
    /// AgentMuQueryResponse
    /// </summary>
    [DataContract]
    public partial class AgentMuQueryResponse :  IEquatable<AgentMuQueryResponse>
    {
        /// <summary>
        /// The status of the operation
        /// </summary>
        /// <value>The status of the operation</value>
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
        /// The status of the operation
        /// </summary>
        /// <value>The status of the operation</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMuQueryResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentMuQueryResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMuQueryResponse" /> class.
        /// </summary>
        /// <param name="Status">The status of the operation (required).</param>
        /// <param name="OperationId">The ID for the operation (required).</param>
        /// <param name="Result">The schema of the result of the operation. Null if downloadUrl is populated, but defines the schema of the data that will be returned from the downloadUrl.</param>
        /// <param name="DownloadUrl">The URL from which to download the result. The result will follow the schema documented by the result field.</param>
        /// <param name="Error">Error details if status &#x3D;&#x3D; &#39;Error&#39;. Will always be null but the schema is documented in case of an error in an async notification.</param>
        public AgentMuQueryResponse(StatusEnum? Status = null, string OperationId = null, AgentMuScheduleResult Result = null, string DownloadUrl = null, ErrorBody Error = null)
        {
            this.Status = Status;
            this.OperationId = OperationId;
            this.Result = Result;
            this.DownloadUrl = DownloadUrl;
            this.Error = Error;
            
        }
        




        /// <summary>
        /// The ID for the operation
        /// </summary>
        /// <value>The ID for the operation</value>
        [DataMember(Name="operationId", EmitDefaultValue=false)]
        public string OperationId { get; set; }



        /// <summary>
        /// The schema of the result of the operation. Null if downloadUrl is populated, but defines the schema of the data that will be returned from the downloadUrl
        /// </summary>
        /// <value>The schema of the result of the operation. Null if downloadUrl is populated, but defines the schema of the data that will be returned from the downloadUrl</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public AgentMuScheduleResult Result { get; set; }



        /// <summary>
        /// The URL from which to download the result. The result will follow the schema documented by the result field
        /// </summary>
        /// <value>The URL from which to download the result. The result will follow the schema documented by the result field</value>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }



        /// <summary>
        /// Error details if status &#x3D;&#x3D; &#39;Error&#39;. Will always be null but the schema is documented in case of an error in an async notification
        /// </summary>
        /// <value>Error details if status &#x3D;&#x3D; &#39;Error&#39;. Will always be null but the schema is documented in case of an error in an async notification</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorBody Error { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentMuQueryResponse {\n");

            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(obj as AgentMuQueryResponse);
        }

        /// <summary>
        /// Returns true if AgentMuQueryResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentMuQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentMuQueryResponse other)
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
                    this.OperationId == other.OperationId ||
                    this.OperationId != null &&
                    this.OperationId.Equals(other.OperationId)
                ) &&
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
                ) &&
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
                ) &&
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
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

                if (this.OperationId != null)
                    hash = hash * 59 + this.OperationId.GetHashCode();

                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                return hash;
            }
        }
    }

}
