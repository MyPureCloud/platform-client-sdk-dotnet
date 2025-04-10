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
    /// Error information that the Public API will receive in a response body. This allows backend services to pass an error message to consumers of the Public API.
    /// </summary>
    [DataContract]
    public partial class UserRoutingStatusErrorInfo :  IEquatable<UserRoutingStatusErrorInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoutingStatusErrorInfo" /> class.
        /// </summary>
        /// <param name="ErrorCode">A code unique to this error. Typically prefixed with the service that originated the error. For example CONFIG_USER_NOT_FOUND.</param>
        /// <param name="Status">The HTTP status code for this message. If left blank the status code from the HTTP response is used..</param>
        /// <param name="CorrelationId">The correlation Id or context Id for this message. If left blank the Public API will look at the HTTP response header &#39;ININ-Correlation-Id&#39; instead..</param>
        /// <param name="UserMessage">A customer friendly message. This should be a complete sentence, use proper grammar and only include information useful to a customer. This is not a dev message and should not include things like Org Id.</param>
        /// <param name="UserParamsMessage">This is the same as userMessage except it uses template fields for variable replacement. For instance: &#39;User {username} was not found&#39;.</param>
        /// <param name="UserParams">Used in conjunction with userParamsMessage. These are the template parameters. For instance: UserParam.key &#x3D; &#39;username&#39;, UserParam.value &#x3D; &#39;chuck.pulfer&#39;.</param>
        public UserRoutingStatusErrorInfo(string ErrorCode = null, long? Status = null, string CorrelationId = null, string UserMessage = null, string UserParamsMessage = null, List<UserRoutingStatusUserParam> UserParams = null)
        {
            this.ErrorCode = ErrorCode;
            this.Status = Status;
            this.CorrelationId = CorrelationId;
            this.UserMessage = UserMessage;
            this.UserParamsMessage = UserParamsMessage;
            this.UserParams = UserParams;
            
        }
        


        /// <summary>
        /// A code unique to this error. Typically prefixed with the service that originated the error. For example CONFIG_USER_NOT_FOUND
        /// </summary>
        /// <value>A code unique to this error. Typically prefixed with the service that originated the error. For example CONFIG_USER_NOT_FOUND</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }



        /// <summary>
        /// The HTTP status code for this message. If left blank the status code from the HTTP response is used.
        /// </summary>
        /// <value>The HTTP status code for this message. If left blank the status code from the HTTP response is used.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public long? Status { get; set; }



        /// <summary>
        /// The correlation Id or context Id for this message. If left blank the Public API will look at the HTTP response header &#39;ININ-Correlation-Id&#39; instead.
        /// </summary>
        /// <value>The correlation Id or context Id for this message. If left blank the Public API will look at the HTTP response header &#39;ININ-Correlation-Id&#39; instead.</value>
        [DataMember(Name="correlationId", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }



        /// <summary>
        /// A customer friendly message. This should be a complete sentence, use proper grammar and only include information useful to a customer. This is not a dev message and should not include things like Org Id
        /// </summary>
        /// <value>A customer friendly message. This should be a complete sentence, use proper grammar and only include information useful to a customer. This is not a dev message and should not include things like Org Id</value>
        [DataMember(Name="userMessage", EmitDefaultValue=false)]
        public string UserMessage { get; set; }



        /// <summary>
        /// This is the same as userMessage except it uses template fields for variable replacement. For instance: &#39;User {username} was not found&#39;
        /// </summary>
        /// <value>This is the same as userMessage except it uses template fields for variable replacement. For instance: &#39;User {username} was not found&#39;</value>
        [DataMember(Name="userParamsMessage", EmitDefaultValue=false)]
        public string UserParamsMessage { get; set; }



        /// <summary>
        /// Used in conjunction with userParamsMessage. These are the template parameters. For instance: UserParam.key &#x3D; &#39;username&#39;, UserParam.value &#x3D; &#39;chuck.pulfer&#39;
        /// </summary>
        /// <value>Used in conjunction with userParamsMessage. These are the template parameters. For instance: UserParam.key &#x3D; &#39;username&#39;, UserParam.value &#x3D; &#39;chuck.pulfer&#39;</value>
        [DataMember(Name="userParams", EmitDefaultValue=false)]
        public List<UserRoutingStatusUserParam> UserParams { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserRoutingStatusErrorInfo {\n");

            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  UserMessage: ").Append(UserMessage).Append("\n");
            sb.Append("  UserParamsMessage: ").Append(UserParamsMessage).Append("\n");
            sb.Append("  UserParams: ").Append(UserParams).Append("\n");
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
            return this.Equals(obj as UserRoutingStatusErrorInfo);
        }

        /// <summary>
        /// Returns true if UserRoutingStatusErrorInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of UserRoutingStatusErrorInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserRoutingStatusErrorInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) &&
                (
                    this.UserMessage == other.UserMessage ||
                    this.UserMessage != null &&
                    this.UserMessage.Equals(other.UserMessage)
                ) &&
                (
                    this.UserParamsMessage == other.UserParamsMessage ||
                    this.UserParamsMessage != null &&
                    this.UserParamsMessage.Equals(other.UserParamsMessage)
                ) &&
                (
                    this.UserParams == other.UserParams ||
                    this.UserParams != null &&
                    this.UserParams.SequenceEqual(other.UserParams)
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
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();

                if (this.UserMessage != null)
                    hash = hash * 59 + this.UserMessage.GetHashCode();

                if (this.UserParamsMessage != null)
                    hash = hash * 59 + this.UserParamsMessage.GetHashCode();

                if (this.UserParams != null)
                    hash = hash * 59 + this.UserParams.GetHashCode();

                return hash;
            }
        }
    }

}
