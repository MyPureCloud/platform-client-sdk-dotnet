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
    /// ArchitectJobMessageDetail
    /// </summary>
    [DataContract]
    public partial class ArchitectJobMessageDetail :  IEquatable<ArchitectJobMessageDetail>
    {
        /// <summary>
        /// The kind of information carried by this entry, which determines which of the other properties are set.
        /// </summary>
        /// <value>The kind of information carried by this entry, which determines which of the other properties are set.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Networkdiagnostic for "NetworkDiagnostic"
            /// </summary>
            [EnumMember(Value = "NetworkDiagnostic")]
            Networkdiagnostic,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The kind of information carried by this entry, which determines which of the other properties are set.
        /// </summary>
        /// <value>The kind of information carried by this entry, which determines which of the other properties are set.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectJobMessageDetail" /> class.
        /// </summary>
        public ArchitectJobMessageDetail()
        {
            
        }
        




        /// <summary>
        /// The URL of the request.
        /// </summary>
        /// <value>The URL of the request.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; private set; }



        /// <summary>
        /// The HTTP method of the request.
        /// </summary>
        /// <value>The HTTP method of the request.</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; private set; }



        /// <summary>
        /// The body of the request, reported as sent and without redaction. Omitted when the request had no body, so it is absent for ordinary GET lookups and present for calls such as POST searches. Truncated to 4096 characters with a &#x60;...&lt;truncated N chars&gt;&#x60; suffix when longer.
        /// </summary>
        /// <value>The body of the request, reported as sent and without redaction. Omitted when the request had no body, so it is absent for ordinary GET lookups and present for calls such as POST searches. Truncated to 4096 characters with a &#x60;...&lt;truncated N chars&gt;&#x60; suffix when longer.</value>
        [DataMember(Name="requestBody", EmitDefaultValue=false)]
        public string RequestBody { get; private set; }



        /// <summary>
        /// The HTTP status code of the response. Set only when a response was received, and never alongside errorCode.
        /// </summary>
        /// <value>The HTTP status code of the response. Set only when a response was received, and never alongside errorCode.</value>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public int? StatusCode { get; private set; }



        /// <summary>
        /// The HTTP status message of the response. Set only when a response was received, and never alongside errorMessage.
        /// </summary>
        /// <value>The HTTP status message of the response. Set only when a response was received, and never alongside errorMessage.</value>
        [DataMember(Name="statusMessage", EmitDefaultValue=false)]
        public string StatusMessage { get; private set; }



        /// <summary>
        /// The Genesys Cloud correlation id of the response, to quote when escalating to Genesys Cloud support. Set only when a response was received.
        /// </summary>
        /// <value>The Genesys Cloud correlation id of the response, to quote when escalating to Genesys Cloud support. Set only when a response was received.</value>
        [DataMember(Name="correlationId", EmitDefaultValue=false)]
        public string CorrelationId { get; private set; }



        /// <summary>
        /// The body of the response, reported as received and without redaction. Because entries are captured for requests that succeeded as well, this can carry data returned by a lookup that was unrelated to the failure. Omitted when the response had no body. Truncated to 4096 characters with a &#x60;...&lt;truncated N chars&gt;&#x60; suffix when longer.
        /// </summary>
        /// <value>The body of the response, reported as received and without redaction. Because entries are captured for requests that succeeded as well, this can carry data returned by a lookup that was unrelated to the failure. Omitted when the response had no body. Truncated to 4096 characters with a &#x60;...&lt;truncated N chars&gt;&#x60; suffix when longer.</value>
        [DataMember(Name="responseBody", EmitDefaultValue=false)]
        public string ResponseBody { get; private set; }



        /// <summary>
        /// The transport error code, such as ECONNRESET. Set only when the request failed before any HTTP response was received, and never alongside statusCode.
        /// </summary>
        /// <value>The transport error code, such as ECONNRESET. Set only when the request failed before any HTTP response was received, and never alongside statusCode.</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; private set; }



        /// <summary>
        /// The transport error message. Set only when the request failed before any HTTP response was received, and never alongside statusMessage.
        /// </summary>
        /// <value>The transport error message. Set only when the request failed before any HTTP response was received, and never alongside statusMessage.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchitectJobMessageDetail {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  RequestBody: ").Append(RequestBody).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  StatusMessage: ").Append(StatusMessage).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  ResponseBody: ").Append(ResponseBody).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            return this.Equals(obj as ArchitectJobMessageDetail);
        }

        /// <summary>
        /// Returns true if ArchitectJobMessageDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of ArchitectJobMessageDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchitectJobMessageDetail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
                ) &&
                (
                    this.RequestBody == other.RequestBody ||
                    this.RequestBody != null &&
                    this.RequestBody.Equals(other.RequestBody)
                ) &&
                (
                    this.StatusCode == other.StatusCode ||
                    this.StatusCode != null &&
                    this.StatusCode.Equals(other.StatusCode)
                ) &&
                (
                    this.StatusMessage == other.StatusMessage ||
                    this.StatusMessage != null &&
                    this.StatusMessage.Equals(other.StatusMessage)
                ) &&
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) &&
                (
                    this.ResponseBody == other.ResponseBody ||
                    this.ResponseBody != null &&
                    this.ResponseBody.Equals(other.ResponseBody)
                ) &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();

                if (this.RequestBody != null)
                    hash = hash * 59 + this.RequestBody.GetHashCode();

                if (this.StatusCode != null)
                    hash = hash * 59 + this.StatusCode.GetHashCode();

                if (this.StatusMessage != null)
                    hash = hash * 59 + this.StatusMessage.GetHashCode();

                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();

                if (this.ResponseBody != null)
                    hash = hash * 59 + this.ResponseBody.GetHashCode();

                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();

                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();

                return hash;
            }
        }
    }

}
