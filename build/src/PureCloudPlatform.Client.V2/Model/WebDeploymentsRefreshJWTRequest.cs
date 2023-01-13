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
    /// WebDeploymentsRefreshJWTRequest
    /// </summary>
    [DataContract]
    public partial class WebDeploymentsRefreshJWTRequest :  IEquatable<WebDeploymentsRefreshJWTRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WebDeploymentsRefreshJWTRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebDeploymentsRefreshJWTRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebDeploymentsRefreshJWTRequest" /> class.
        /// </summary>
        /// <param name="RefreshToken">Refresh token used to issue a new JWT. (required).</param>
        /// <param name="DeploymentId">The WebDeployment ID (required).</param>
        public WebDeploymentsRefreshJWTRequest(string RefreshToken = null, string DeploymentId = null)
        {
            this.RefreshToken = RefreshToken;
            this.DeploymentId = DeploymentId;
            
        }
        


        /// <summary>
        /// Refresh token used to issue a new JWT.
        /// </summary>
        /// <value>Refresh token used to issue a new JWT.</value>
        [DataMember(Name="refreshToken", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }



        /// <summary>
        /// The WebDeployment ID
        /// </summary>
        /// <value>The WebDeployment ID</value>
        [DataMember(Name="deploymentId", EmitDefaultValue=false)]
        public string DeploymentId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebDeploymentsRefreshJWTRequest {\n");

            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  DeploymentId: ").Append(DeploymentId).Append("\n");
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
            return this.Equals(obj as WebDeploymentsRefreshJWTRequest);
        }

        /// <summary>
        /// Returns true if WebDeploymentsRefreshJWTRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of WebDeploymentsRefreshJWTRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebDeploymentsRefreshJWTRequest other)
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
                    this.DeploymentId == other.DeploymentId ||
                    this.DeploymentId != null &&
                    this.DeploymentId.Equals(other.DeploymentId)
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

                if (this.DeploymentId != null)
                    hash = hash * 59 + this.DeploymentId.GetHashCode();

                return hash;
            }
        }
    }

}
