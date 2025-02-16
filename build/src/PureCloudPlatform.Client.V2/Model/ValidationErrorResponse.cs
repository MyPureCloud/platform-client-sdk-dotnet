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
    /// ValidationErrorResponse
    /// </summary>
    [DataContract]
    public partial class ValidationErrorResponse :  IEquatable<ValidationErrorResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorResponse" /> class.
        /// </summary>
        /// <param name="Message">Message string of the validation error..</param>
        /// <param name="ErrorType">Type of validation errror..</param>
        /// <param name="Arguments">Map of argument names to corresponding values. Used for localization..</param>
        public ValidationErrorResponse(string Message = null, string ErrorType = null, Dictionary<string, string> Arguments = null)
        {
            this.Message = Message;
            this.ErrorType = ErrorType;
            this.Arguments = Arguments;
            
        }
        


        /// <summary>
        /// Message string of the validation error.
        /// </summary>
        /// <value>Message string of the validation error.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }



        /// <summary>
        /// Type of validation errror.
        /// </summary>
        /// <value>Type of validation errror.</value>
        [DataMember(Name="errorType", EmitDefaultValue=false)]
        public string ErrorType { get; set; }



        /// <summary>
        /// Map of argument names to corresponding values. Used for localization.
        /// </summary>
        /// <value>Map of argument names to corresponding values. Used for localization.</value>
        [DataMember(Name="arguments", EmitDefaultValue=false)]
        public Dictionary<string, string> Arguments { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidationErrorResponse {\n");

            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
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
            return this.Equals(obj as ValidationErrorResponse);
        }

        /// <summary>
        /// Returns true if ValidationErrorResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidationErrorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidationErrorResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.ErrorType == other.ErrorType ||
                    this.ErrorType != null &&
                    this.ErrorType.Equals(other.ErrorType)
                ) &&
                (
                    this.Arguments == other.Arguments ||
                    this.Arguments != null &&
                    this.Arguments.SequenceEqual(other.Arguments)
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
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.ErrorType != null)
                    hash = hash * 59 + this.ErrorType.GetHashCode();

                if (this.Arguments != null)
                    hash = hash * 59 + this.Arguments.GetHashCode();

                return hash;
            }
        }
    }

}
