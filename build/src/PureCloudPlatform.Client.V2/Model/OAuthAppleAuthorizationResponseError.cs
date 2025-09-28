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
    /// OAuthAppleAuthorizationResponseError
    /// </summary>
    [DataContract]
    public partial class OAuthAppleAuthorizationResponseError :  IEquatable<OAuthAppleAuthorizationResponseError>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthAppleAuthorizationResponseError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OAuthAppleAuthorizationResponseError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthAppleAuthorizationResponseError" /> class.
        /// </summary>
        /// <param name="Code">The error code (required).</param>
        /// <param name="Message">The error message (required).</param>
        /// <param name="Details">The error details.</param>
        public OAuthAppleAuthorizationResponseError(string Code = null, string Message = null, Object Details = null)
        {
            this.Code = Code;
            this.Message = Message;
            this.Details = Details;
            
        }
        


        /// <summary>
        /// The error code
        /// </summary>
        /// <value>The error code</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }



        /// <summary>
        /// The error message
        /// </summary>
        /// <value>The error message</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }



        /// <summary>
        /// The error details
        /// </summary>
        /// <value>The error details</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public Object Details { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OAuthAppleAuthorizationResponseError {\n");

            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(obj as OAuthAppleAuthorizationResponseError);
        }

        /// <summary>
        /// Returns true if OAuthAppleAuthorizationResponseError instances are equal
        /// </summary>
        /// <param name="other">Instance of OAuthAppleAuthorizationResponseError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuthAppleAuthorizationResponseError other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.Equals(other.Details)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();

                return hash;
            }
        }
    }

}
