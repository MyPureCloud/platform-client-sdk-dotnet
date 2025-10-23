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
    /// AppleAuthentication
    /// </summary>
    [DataContract]
    public partial class AppleAuthentication :  IEquatable<AppleAuthentication>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppleAuthentication" /> class.
        /// </summary>
        /// <param name="OauthClientId">The Apple Messages for Business OAuth client id..</param>
        /// <param name="OauthClientSecret">The Apple Messages for Business OAuth client secret..</param>
        /// <param name="OauthTokenUrl">The Apple Messages for Business token URL..</param>
        /// <param name="OauthScope">The Apple Messages for Business OAuth scope..</param>
        public AppleAuthentication(string OauthClientId = null, string OauthClientSecret = null, string OauthTokenUrl = null, string OauthScope = null)
        {
            this.OauthClientId = OauthClientId;
            this.OauthClientSecret = OauthClientSecret;
            this.OauthTokenUrl = OauthTokenUrl;
            this.OauthScope = OauthScope;
            
        }
        


        /// <summary>
        /// The Apple Messages for Business OAuth client id.
        /// </summary>
        /// <value>The Apple Messages for Business OAuth client id.</value>
        [DataMember(Name="oauthClientId", EmitDefaultValue=false)]
        public string OauthClientId { get; set; }



        /// <summary>
        /// The Apple Messages for Business OAuth client secret.
        /// </summary>
        /// <value>The Apple Messages for Business OAuth client secret.</value>
        [DataMember(Name="oauthClientSecret", EmitDefaultValue=false)]
        public string OauthClientSecret { get; set; }



        /// <summary>
        /// The Apple Messages for Business token URL.
        /// </summary>
        /// <value>The Apple Messages for Business token URL.</value>
        [DataMember(Name="oauthTokenUrl", EmitDefaultValue=false)]
        public string OauthTokenUrl { get; set; }



        /// <summary>
        /// The Apple Messages for Business OAuth scope.
        /// </summary>
        /// <value>The Apple Messages for Business OAuth scope.</value>
        [DataMember(Name="oauthScope", EmitDefaultValue=false)]
        public string OauthScope { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppleAuthentication {\n");

            sb.Append("  OauthClientId: ").Append(OauthClientId).Append("\n");
            sb.Append("  OauthClientSecret: ").Append(OauthClientSecret).Append("\n");
            sb.Append("  OauthTokenUrl: ").Append(OauthTokenUrl).Append("\n");
            sb.Append("  OauthScope: ").Append(OauthScope).Append("\n");
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
            return this.Equals(obj as AppleAuthentication);
        }

        /// <summary>
        /// Returns true if AppleAuthentication instances are equal
        /// </summary>
        /// <param name="other">Instance of AppleAuthentication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppleAuthentication other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OauthClientId == other.OauthClientId ||
                    this.OauthClientId != null &&
                    this.OauthClientId.Equals(other.OauthClientId)
                ) &&
                (
                    this.OauthClientSecret == other.OauthClientSecret ||
                    this.OauthClientSecret != null &&
                    this.OauthClientSecret.Equals(other.OauthClientSecret)
                ) &&
                (
                    this.OauthTokenUrl == other.OauthTokenUrl ||
                    this.OauthTokenUrl != null &&
                    this.OauthTokenUrl.Equals(other.OauthTokenUrl)
                ) &&
                (
                    this.OauthScope == other.OauthScope ||
                    this.OauthScope != null &&
                    this.OauthScope.Equals(other.OauthScope)
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
                if (this.OauthClientId != null)
                    hash = hash * 59 + this.OauthClientId.GetHashCode();

                if (this.OauthClientSecret != null)
                    hash = hash * 59 + this.OauthClientSecret.GetHashCode();

                if (this.OauthTokenUrl != null)
                    hash = hash * 59 + this.OauthTokenUrl.GetHashCode();

                if (this.OauthScope != null)
                    hash = hash * 59 + this.OauthScope.GetHashCode();

                return hash;
            }
        }
    }

}
