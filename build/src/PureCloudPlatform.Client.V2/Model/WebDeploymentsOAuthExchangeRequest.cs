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
    /// WebDeploymentsOAuthExchangeRequest
    /// </summary>
    [DataContract]
    public partial class WebDeploymentsOAuthExchangeRequest :  IEquatable<WebDeploymentsOAuthExchangeRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WebDeploymentsOAuthExchangeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebDeploymentsOAuthExchangeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebDeploymentsOAuthExchangeRequest" /> class.
        /// </summary>
        /// <param name="DeploymentId">The WebDeployment ID (required).</param>
        /// <param name="JourneyContext">A Customer journey context..</param>
        /// <param name="Oauth">Oauth.</param>
        public WebDeploymentsOAuthExchangeRequest(string DeploymentId = null, WebDeploymentsJourneyContext JourneyContext = null, WebDeploymentsOAuthRequestParameters Oauth = null)
        {
            this.DeploymentId = DeploymentId;
            this.JourneyContext = JourneyContext;
            this.Oauth = Oauth;
            
        }
        


        /// <summary>
        /// The WebDeployment ID
        /// </summary>
        /// <value>The WebDeployment ID</value>
        [DataMember(Name="deploymentId", EmitDefaultValue=false)]
        public string DeploymentId { get; set; }



        /// <summary>
        /// A Customer journey context.
        /// </summary>
        /// <value>A Customer journey context.</value>
        [DataMember(Name="journeyContext", EmitDefaultValue=false)]
        public WebDeploymentsJourneyContext JourneyContext { get; set; }



        /// <summary>
        /// Gets or Sets Oauth
        /// </summary>
        [DataMember(Name="oauth", EmitDefaultValue=false)]
        public WebDeploymentsOAuthRequestParameters Oauth { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebDeploymentsOAuthExchangeRequest {\n");

            sb.Append("  DeploymentId: ").Append(DeploymentId).Append("\n");
            sb.Append("  JourneyContext: ").Append(JourneyContext).Append("\n");
            sb.Append("  Oauth: ").Append(Oauth).Append("\n");
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
            return this.Equals(obj as WebDeploymentsOAuthExchangeRequest);
        }

        /// <summary>
        /// Returns true if WebDeploymentsOAuthExchangeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of WebDeploymentsOAuthExchangeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebDeploymentsOAuthExchangeRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DeploymentId == other.DeploymentId ||
                    this.DeploymentId != null &&
                    this.DeploymentId.Equals(other.DeploymentId)
                ) &&
                (
                    this.JourneyContext == other.JourneyContext ||
                    this.JourneyContext != null &&
                    this.JourneyContext.Equals(other.JourneyContext)
                ) &&
                (
                    this.Oauth == other.Oauth ||
                    this.Oauth != null &&
                    this.Oauth.Equals(other.Oauth)
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
                if (this.DeploymentId != null)
                    hash = hash * 59 + this.DeploymentId.GetHashCode();

                if (this.JourneyContext != null)
                    hash = hash * 59 + this.JourneyContext.GetHashCode();

                if (this.Oauth != null)
                    hash = hash * 59 + this.Oauth.GetHashCode();

                return hash;
            }
        }
    }

}
