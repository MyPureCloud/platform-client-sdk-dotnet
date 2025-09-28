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
    /// OAuthAppleAuthorizationResponse
    /// </summary>
    [DataContract]
    public partial class OAuthAppleAuthorizationResponse :  IEquatable<OAuthAppleAuthorizationResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthAppleAuthorizationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OAuthAppleAuthorizationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthAppleAuthorizationResponse" /> class.
        /// </summary>
        /// <param name="RedirectUrl">The redirected url (required).</param>
        /// <param name="Error">The error object.</param>
        public OAuthAppleAuthorizationResponse(string RedirectUrl = null, OAuthAppleAuthorizationResponseError Error = null)
        {
            this.RedirectUrl = RedirectUrl;
            this.Error = Error;
            
        }
        


        /// <summary>
        /// The redirected url
        /// </summary>
        /// <value>The redirected url</value>
        [DataMember(Name="redirectUrl", EmitDefaultValue=false)]
        public string RedirectUrl { get; set; }



        /// <summary>
        /// The error object
        /// </summary>
        /// <value>The error object</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public OAuthAppleAuthorizationResponseError Error { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OAuthAppleAuthorizationResponse {\n");

            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
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
            return this.Equals(obj as OAuthAppleAuthorizationResponse);
        }

        /// <summary>
        /// Returns true if OAuthAppleAuthorizationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OAuthAppleAuthorizationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuthAppleAuthorizationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RedirectUrl == other.RedirectUrl ||
                    this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(other.RedirectUrl)
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
                if (this.RedirectUrl != null)
                    hash = hash * 59 + this.RedirectUrl.GetHashCode();

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                return hash;
            }
        }
    }

}
