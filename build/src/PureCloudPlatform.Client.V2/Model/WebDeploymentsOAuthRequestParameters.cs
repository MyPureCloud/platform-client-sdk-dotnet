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
    /// WebDeploymentsOAuthRequestParameters
    /// </summary>
    [DataContract]
    public partial class WebDeploymentsOAuthRequestParameters :  IEquatable<WebDeploymentsOAuthRequestParameters>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WebDeploymentsOAuthRequestParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebDeploymentsOAuthRequestParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebDeploymentsOAuthRequestParameters" /> class.
        /// </summary>
        /// <param name="Code">The authorization code to be sent to the authentication server during the token request.  Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest.</param>
        /// <param name="IdToken">The implicit id_token to be sent to the authentication server during the token request.  Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest.</param>
        /// <param name="RedirectUri">Redirect URI sent in the \&quot;Authentication Request\&quot;Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest (required).</param>
        /// <param name="Nonce">Required if provided in the \&quot;Authentication Request\&quot;. Otherwise should be empty.String value used to associate a Client session with an ID Token, and to mitigate replay attacks. The value is passed through unmodified from the Authentication Request to the ID Token. Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest.</param>
        /// <param name="MaxAge">Required if provided in the  \&quot;Authentication Request\&quot;. Otherwise should be empty.Specifies the allowable elapsed time in seconds since the last time the End-User was actively authenticated.Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest.</param>
        /// <param name="CodeVerifier">Required if authorizing using Proof Key for Code Exchange (PKCE). Otherwise should be empty.Random URL-safe string with a minimum length of 43 characters generated at start of authorization flow to mitigate the threat of having the authorization code intercepted. Refer to https://datatracker.ietf.org/doc/html/rfc7636.</param>
        /// <param name="Iss">Optional parameter. Set it if authorization server discovery metadata authorization_response_iss_parameter_supported is enabled. Refer to https://datatracker.ietf.org/doc/html/rfc9207.</param>
        public WebDeploymentsOAuthRequestParameters(string Code = null, string IdToken = null, string RedirectUri = null, string Nonce = null, int? MaxAge = null, string CodeVerifier = null, string Iss = null)
        {
            this.Code = Code;
            this.IdToken = IdToken;
            this.RedirectUri = RedirectUri;
            this.Nonce = Nonce;
            this.MaxAge = MaxAge;
            this.CodeVerifier = CodeVerifier;
            this.Iss = Iss;
            
        }
        


        /// <summary>
        /// The authorization code to be sent to the authentication server during the token request.  Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest
        /// </summary>
        /// <value>The authorization code to be sent to the authentication server during the token request.  Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }



        /// <summary>
        /// The implicit id_token to be sent to the authentication server during the token request.  Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest
        /// </summary>
        /// <value>The implicit id_token to be sent to the authentication server during the token request.  Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest</value>
        [DataMember(Name="idToken", EmitDefaultValue=false)]
        public string IdToken { get; set; }



        /// <summary>
        /// Redirect URI sent in the \&quot;Authentication Request\&quot;Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest
        /// </summary>
        /// <value>Redirect URI sent in the \&quot;Authentication Request\&quot;Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest</value>
        [DataMember(Name="redirectUri", EmitDefaultValue=false)]
        public string RedirectUri { get; set; }



        /// <summary>
        /// Required if provided in the \&quot;Authentication Request\&quot;. Otherwise should be empty.String value used to associate a Client session with an ID Token, and to mitigate replay attacks. The value is passed through unmodified from the Authentication Request to the ID Token. Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest
        /// </summary>
        /// <value>Required if provided in the \&quot;Authentication Request\&quot;. Otherwise should be empty.String value used to associate a Client session with an ID Token, and to mitigate replay attacks. The value is passed through unmodified from the Authentication Request to the ID Token. Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest</value>
        [DataMember(Name="nonce", EmitDefaultValue=false)]
        public string Nonce { get; set; }



        /// <summary>
        /// Required if provided in the  \&quot;Authentication Request\&quot;. Otherwise should be empty.Specifies the allowable elapsed time in seconds since the last time the End-User was actively authenticated.Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest
        /// </summary>
        /// <value>Required if provided in the  \&quot;Authentication Request\&quot;. Otherwise should be empty.Specifies the allowable elapsed time in seconds since the last time the End-User was actively authenticated.Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest</value>
        [DataMember(Name="maxAge", EmitDefaultValue=false)]
        public int? MaxAge { get; set; }



        /// <summary>
        /// Required if authorizing using Proof Key for Code Exchange (PKCE). Otherwise should be empty.Random URL-safe string with a minimum length of 43 characters generated at start of authorization flow to mitigate the threat of having the authorization code intercepted. Refer to https://datatracker.ietf.org/doc/html/rfc7636
        /// </summary>
        /// <value>Required if authorizing using Proof Key for Code Exchange (PKCE). Otherwise should be empty.Random URL-safe string with a minimum length of 43 characters generated at start of authorization flow to mitigate the threat of having the authorization code intercepted. Refer to https://datatracker.ietf.org/doc/html/rfc7636</value>
        [DataMember(Name="codeVerifier", EmitDefaultValue=false)]
        public string CodeVerifier { get; set; }



        /// <summary>
        /// Optional parameter. Set it if authorization server discovery metadata authorization_response_iss_parameter_supported is enabled. Refer to https://datatracker.ietf.org/doc/html/rfc9207
        /// </summary>
        /// <value>Optional parameter. Set it if authorization server discovery metadata authorization_response_iss_parameter_supported is enabled. Refer to https://datatracker.ietf.org/doc/html/rfc9207</value>
        [DataMember(Name="iss", EmitDefaultValue=false)]
        public string Iss { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebDeploymentsOAuthRequestParameters {\n");

            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  IdToken: ").Append(IdToken).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  MaxAge: ").Append(MaxAge).Append("\n");
            sb.Append("  CodeVerifier: ").Append(CodeVerifier).Append("\n");
            sb.Append("  Iss: ").Append(Iss).Append("\n");
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
            return this.Equals(obj as WebDeploymentsOAuthRequestParameters);
        }

        /// <summary>
        /// Returns true if WebDeploymentsOAuthRequestParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of WebDeploymentsOAuthRequestParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebDeploymentsOAuthRequestParameters other)
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
                    this.IdToken == other.IdToken ||
                    this.IdToken != null &&
                    this.IdToken.Equals(other.IdToken)
                ) &&
                (
                    this.RedirectUri == other.RedirectUri ||
                    this.RedirectUri != null &&
                    this.RedirectUri.Equals(other.RedirectUri)
                ) &&
                (
                    this.Nonce == other.Nonce ||
                    this.Nonce != null &&
                    this.Nonce.Equals(other.Nonce)
                ) &&
                (
                    this.MaxAge == other.MaxAge ||
                    this.MaxAge != null &&
                    this.MaxAge.Equals(other.MaxAge)
                ) &&
                (
                    this.CodeVerifier == other.CodeVerifier ||
                    this.CodeVerifier != null &&
                    this.CodeVerifier.Equals(other.CodeVerifier)
                ) &&
                (
                    this.Iss == other.Iss ||
                    this.Iss != null &&
                    this.Iss.Equals(other.Iss)
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

                if (this.IdToken != null)
                    hash = hash * 59 + this.IdToken.GetHashCode();

                if (this.RedirectUri != null)
                    hash = hash * 59 + this.RedirectUri.GetHashCode();

                if (this.Nonce != null)
                    hash = hash * 59 + this.Nonce.GetHashCode();

                if (this.MaxAge != null)
                    hash = hash * 59 + this.MaxAge.GetHashCode();

                if (this.CodeVerifier != null)
                    hash = hash * 59 + this.CodeVerifier.GetHashCode();

                if (this.Iss != null)
                    hash = hash * 59 + this.Iss.GetHashCode();

                return hash;
            }
        }
    }

}
