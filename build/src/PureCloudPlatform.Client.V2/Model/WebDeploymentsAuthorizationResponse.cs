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
    /// WebDeploymentsAuthorizationResponse
    /// </summary>
    [DataContract]
    public partial class WebDeploymentsAuthorizationResponse :  IEquatable<WebDeploymentsAuthorizationResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebDeploymentsAuthorizationResponse" /> class.
        /// </summary>
        /// <param name="RefreshToken">Refresh token used to issue a new JWT..</param>
        /// <param name="Jwt">Jwt.</param>
        public WebDeploymentsAuthorizationResponse(string RefreshToken = null, string Jwt = null)
        {
            this.RefreshToken = RefreshToken;
            this.Jwt = Jwt;
            
        }
        


        /// <summary>
        /// Refresh token used to issue a new JWT.
        /// </summary>
        /// <value>Refresh token used to issue a new JWT.</value>
        [DataMember(Name="refreshToken", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }



        /// <summary>
        /// Gets or Sets Jwt
        /// </summary>
        [DataMember(Name="jwt", EmitDefaultValue=false)]
        public string Jwt { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebDeploymentsAuthorizationResponse {\n");

            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  Jwt: ").Append(Jwt).Append("\n");
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
            return this.Equals(obj as WebDeploymentsAuthorizationResponse);
        }

        /// <summary>
        /// Returns true if WebDeploymentsAuthorizationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WebDeploymentsAuthorizationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebDeploymentsAuthorizationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RefreshToken == other.RefreshToken ||
                    this.RefreshToken != null &&
                    this.RefreshToken.Equals(other.RefreshToken)
                ) &&
                (
                    this.Jwt == other.Jwt ||
                    this.Jwt != null &&
                    this.Jwt.Equals(other.Jwt)
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
                if (this.RefreshToken != null)
                    hash = hash * 59 + this.RefreshToken.GetHashCode();

                if (this.Jwt != null)
                    hash = hash * 59 + this.Jwt.GetHashCode();

                return hash;
            }
        }
    }

}
