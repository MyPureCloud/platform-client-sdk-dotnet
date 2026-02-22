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
    /// GoogleAuthTokenRequest
    /// </summary>
    [DataContract]
    public partial class GoogleAuthTokenRequest :  IEquatable<GoogleAuthTokenRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAuthTokenRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GoogleAuthTokenRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAuthTokenRequest" /> class.
        /// </summary>
        /// <param name="Code">One-time authorization code from Google. See docs: https://developers.google.com/identity/protocols/oauth2 (required).</param>
        /// <param name="RedirectUri">The origin of the page from which the auth flow was called. Used as redirectUri when exchanging the one-time code for auth token (required).</param>
        public GoogleAuthTokenRequest(string Code = null, string RedirectUri = null)
        {
            this.Code = Code;
            this.RedirectUri = RedirectUri;
            
        }
        


        /// <summary>
        /// One-time authorization code from Google. See docs: https://developers.google.com/identity/protocols/oauth2
        /// </summary>
        /// <value>One-time authorization code from Google. See docs: https://developers.google.com/identity/protocols/oauth2</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }



        /// <summary>
        /// The origin of the page from which the auth flow was called. Used as redirectUri when exchanging the one-time code for auth token
        /// </summary>
        /// <value>The origin of the page from which the auth flow was called. Used as redirectUri when exchanging the one-time code for auth token</value>
        [DataMember(Name="redirectUri", EmitDefaultValue=false)]
        public string RedirectUri { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoogleAuthTokenRequest {\n");

            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
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
            return this.Equals(obj as GoogleAuthTokenRequest);
        }

        /// <summary>
        /// Returns true if GoogleAuthTokenRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GoogleAuthTokenRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleAuthTokenRequest other)
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
                    this.RedirectUri == other.RedirectUri ||
                    this.RedirectUri != null &&
                    this.RedirectUri.Equals(other.RedirectUri)
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

                if (this.RedirectUri != null)
                    hash = hash * 59 + this.RedirectUri.GetHashCode();

                return hash;
            }
        }
    }

}
