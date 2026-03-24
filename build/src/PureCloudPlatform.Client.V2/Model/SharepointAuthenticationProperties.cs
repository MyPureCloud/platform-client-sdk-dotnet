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
    /// SharepointAuthenticationProperties
    /// </summary>
    [DataContract]
    public partial class SharepointAuthenticationProperties :  IEquatable<SharepointAuthenticationProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharepointAuthenticationProperties" /> class.
        /// </summary>
        /// <param name="AuthenticationUrl">The authentication URL for the connection..</param>
        /// <param name="TenantId">The tenant ID for the connection..</param>
        /// <param name="ClientId">The client ID for the connection..</param>
        /// <param name="RedirectUrl">The redirect URL for the connection..</param>
        public SharepointAuthenticationProperties(string AuthenticationUrl = null, string TenantId = null, string ClientId = null, string RedirectUrl = null)
        {
            this.AuthenticationUrl = AuthenticationUrl;
            this.TenantId = TenantId;
            this.ClientId = ClientId;
            this.RedirectUrl = RedirectUrl;
            
        }
        


        /// <summary>
        /// The authentication URL for the connection.
        /// </summary>
        /// <value>The authentication URL for the connection.</value>
        [DataMember(Name="authenticationUrl", EmitDefaultValue=false)]
        public string AuthenticationUrl { get; set; }



        /// <summary>
        /// The tenant ID for the connection.
        /// </summary>
        /// <value>The tenant ID for the connection.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public string TenantId { get; set; }



        /// <summary>
        /// The client ID for the connection.
        /// </summary>
        /// <value>The client ID for the connection.</value>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }



        /// <summary>
        /// The redirect URL for the connection.
        /// </summary>
        /// <value>The redirect URL for the connection.</value>
        [DataMember(Name="redirectUrl", EmitDefaultValue=false)]
        public string RedirectUrl { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharepointAuthenticationProperties {\n");

            sb.Append("  AuthenticationUrl: ").Append(AuthenticationUrl).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
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
            return this.Equals(obj as SharepointAuthenticationProperties);
        }

        /// <summary>
        /// Returns true if SharepointAuthenticationProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of SharepointAuthenticationProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharepointAuthenticationProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AuthenticationUrl == other.AuthenticationUrl ||
                    this.AuthenticationUrl != null &&
                    this.AuthenticationUrl.Equals(other.AuthenticationUrl)
                ) &&
                (
                    this.TenantId == other.TenantId ||
                    this.TenantId != null &&
                    this.TenantId.Equals(other.TenantId)
                ) &&
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) &&
                (
                    this.RedirectUrl == other.RedirectUrl ||
                    this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(other.RedirectUrl)
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
                if (this.AuthenticationUrl != null)
                    hash = hash * 59 + this.AuthenticationUrl.GetHashCode();

                if (this.TenantId != null)
                    hash = hash * 59 + this.TenantId.GetHashCode();

                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();

                if (this.RedirectUrl != null)
                    hash = hash * 59 + this.RedirectUrl.GetHashCode();

                return hash;
            }
        }
    }

}
