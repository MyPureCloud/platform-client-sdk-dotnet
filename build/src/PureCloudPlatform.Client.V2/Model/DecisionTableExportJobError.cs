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
    /// Error details when a decision table export job fails
    /// </summary>
    [DataContract]
    public partial class DecisionTableExportJobError :  IEquatable<DecisionTableExportJobError>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableExportJobError" /> class.
        /// </summary>
        /// <param name="ErrorCode">The error code for this job failure..</param>
        /// <param name="ErrorMessage">A human-readable error message..</param>
        /// <param name="MessageWithParams">Parameterized message template for the aggregate failure (when applicable).</param>
        /// <param name="MessageParams">Parameters for messageWithParams.</param>
        /// <param name="ValidationErrors">Validation failures for the export job.</param>
        public DecisionTableExportJobError(string ErrorCode = null, string ErrorMessage = null, string MessageWithParams = null, Dictionary<string, string> MessageParams = null, List<DecisionTableJobValidationError> ValidationErrors = null)
        {
            this.ErrorCode = ErrorCode;
            this.ErrorMessage = ErrorMessage;
            this.MessageWithParams = MessageWithParams;
            this.MessageParams = MessageParams;
            this.ValidationErrors = ValidationErrors;
            
        }
        


        /// <summary>
        /// The error code for this job failure.
        /// </summary>
        /// <value>The error code for this job failure.</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }



        /// <summary>
        /// A human-readable error message.
        /// </summary>
        /// <value>A human-readable error message.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }



        /// <summary>
        /// Parameterized message template for the aggregate failure (when applicable)
        /// </summary>
        /// <value>Parameterized message template for the aggregate failure (when applicable)</value>
        [DataMember(Name="messageWithParams", EmitDefaultValue=false)]
        public string MessageWithParams { get; set; }



        /// <summary>
        /// Parameters for messageWithParams
        /// </summary>
        /// <value>Parameters for messageWithParams</value>
        [DataMember(Name="messageParams", EmitDefaultValue=false)]
        public Dictionary<string, string> MessageParams { get; set; }



        /// <summary>
        /// Validation failures for the export job
        /// </summary>
        /// <value>Validation failures for the export job</value>
        [DataMember(Name="validationErrors", EmitDefaultValue=false)]
        public List<DecisionTableJobValidationError> ValidationErrors { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecisionTableExportJobError {\n");

            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  MessageWithParams: ").Append(MessageWithParams).Append("\n");
            sb.Append("  MessageParams: ").Append(MessageParams).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
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
            return this.Equals(obj as DecisionTableExportJobError);
        }

        /// <summary>
        /// Returns true if DecisionTableExportJobError instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionTableExportJobError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionTableExportJobError other)
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
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) &&
                (
                    this.MessageWithParams == other.MessageWithParams ||
                    this.MessageWithParams != null &&
                    this.MessageWithParams.Equals(other.MessageWithParams)
                ) &&
                (
                    this.MessageParams == other.MessageParams ||
                    this.MessageParams != null &&
                    this.MessageParams.SequenceEqual(other.MessageParams)
                ) &&
                (
                    this.ValidationErrors == other.ValidationErrors ||
                    this.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(other.ValidationErrors)
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

                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();

                if (this.MessageWithParams != null)
                    hash = hash * 59 + this.MessageWithParams.GetHashCode();

                if (this.MessageParams != null)
                    hash = hash * 59 + this.MessageParams.GetHashCode();

                if (this.ValidationErrors != null)
                    hash = hash * 59 + this.ValidationErrors.GetHashCode();

                return hash;
            }
        }
    }

}
