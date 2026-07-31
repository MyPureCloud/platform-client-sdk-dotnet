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
    /// ValidateVerifierRequest
    /// </summary>
    [DataContract]
    public partial class ValidateVerifierRequest :  IEquatable<ValidateVerifierRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateVerifierRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValidateVerifierRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateVerifierRequest" /> class.
        /// </summary>
        /// <param name="Enable">Whether to enable the verifier upon successful validation..</param>
        /// <param name="Token">The verification token to validate against the verifier. (required).</param>
        public ValidateVerifierRequest(bool? Enable = null, string Token = null)
        {
            this.Enable = Enable;
            this.Token = Token;
            
        }
        


        /// <summary>
        /// Whether to enable the verifier upon successful validation.
        /// </summary>
        /// <value>Whether to enable the verifier upon successful validation.</value>
        [DataMember(Name="enable", EmitDefaultValue=false)]
        public bool? Enable { get; set; }



        /// <summary>
        /// The verification token to validate against the verifier.
        /// </summary>
        /// <value>The verification token to validate against the verifier.</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateVerifierRequest {\n");

            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(obj as ValidateVerifierRequest);
        }

        /// <summary>
        /// Returns true if ValidateVerifierRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidateVerifierRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateVerifierRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enable == other.Enable ||
                    this.Enable != null &&
                    this.Enable.Equals(other.Enable)
                ) &&
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
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
                if (this.Enable != null)
                    hash = hash * 59 + this.Enable.GetHashCode();

                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();

                return hash;
            }
        }
    }

}
