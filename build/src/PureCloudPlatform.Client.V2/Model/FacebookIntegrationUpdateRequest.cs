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
    /// FacebookIntegrationUpdateRequest
    /// </summary>
    [DataContract]
    public partial class FacebookIntegrationUpdateRequest :  IEquatable<FacebookIntegrationUpdateRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookIntegrationUpdateRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the Facebook Integration.</param>
        /// <param name="PageAccessToken">The long-lived Page Access Token of a facebook page.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  Either pageAccessToken or userAccessToken should be provided..</param>
        /// <param name="UserAccessToken">The short-lived User Access Token of the facebook user logged into the facebook app.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  Either pageAccessToken or userAccessToken should be provided..</param>
        public FacebookIntegrationUpdateRequest(string Name = null, string PageAccessToken = null, string UserAccessToken = null)
        {
            this.Name = Name;
            this.PageAccessToken = PageAccessToken;
            this.UserAccessToken = UserAccessToken;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The name of the Facebook Integration
        /// </summary>
        /// <value>The name of the Facebook Integration</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The long-lived Page Access Token of a facebook page.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  Either pageAccessToken or userAccessToken should be provided.
        /// </summary>
        /// <value>The long-lived Page Access Token of a facebook page.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  Either pageAccessToken or userAccessToken should be provided.</value>
        [DataMember(Name="pageAccessToken", EmitDefaultValue=false)]
        public string PageAccessToken { get; set; }
        
        
        
        /// <summary>
        /// The short-lived User Access Token of the facebook user logged into the facebook app.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  Either pageAccessToken or userAccessToken should be provided.
        /// </summary>
        /// <value>The short-lived User Access Token of the facebook user logged into the facebook app.  See https://developers.facebook.com/docs/facebook-login/access-tokens.  Either pageAccessToken or userAccessToken should be provided.</value>
        [DataMember(Name="userAccessToken", EmitDefaultValue=false)]
        public string UserAccessToken { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FacebookIntegrationUpdateRequest {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PageAccessToken: ").Append(PageAccessToken).Append("\n");
            sb.Append("  UserAccessToken: ").Append(UserAccessToken).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as FacebookIntegrationUpdateRequest);
        }

        /// <summary>
        /// Returns true if FacebookIntegrationUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of FacebookIntegrationUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FacebookIntegrationUpdateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.PageAccessToken == other.PageAccessToken ||
                    this.PageAccessToken != null &&
                    this.PageAccessToken.Equals(other.PageAccessToken)
                ) &&
                (
                    this.UserAccessToken == other.UserAccessToken ||
                    this.UserAccessToken != null &&
                    this.UserAccessToken.Equals(other.UserAccessToken)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.PageAccessToken != null)
                    hash = hash * 59 + this.PageAccessToken.GetHashCode();
                
                if (this.UserAccessToken != null)
                    hash = hash * 59 + this.UserAccessToken.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
