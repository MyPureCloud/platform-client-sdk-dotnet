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
    /// TokenInfo
    /// </summary>
    [DataContract]
    public partial class TokenInfo :  IEquatable<TokenInfo>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenInfo" /> class.
        /// </summary>
        
        
        /// <param name="Organization">The current organization.</param>
        
        
        
        /// <param name="HomeOrganization">The token&#39;s home organization.</param>
        
        
        
        /// <param name="OAuthClient">OAuthClient.</param>
        
        
        public TokenInfo(Entity Organization = null, Entity HomeOrganization = null, OrgOAuthClient OAuthClient = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Organization = Organization;
            
            
            
            
            
            
            
            
this.HomeOrganization = HomeOrganization;
            
            
            
            
            
            
            
            
this.OAuthClient = OAuthClient;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The current organization
        /// </summary>
        /// <value>The current organization</value>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public Entity Organization { get; set; }
        
        
        
        /// <summary>
        /// The token&#39;s home organization
        /// </summary>
        /// <value>The token&#39;s home organization</value>
        [DataMember(Name="homeOrganization", EmitDefaultValue=false)]
        public Entity HomeOrganization { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets OAuthClient
        /// </summary>
        [DataMember(Name="OAuthClient", EmitDefaultValue=false)]
        public OrgOAuthClient OAuthClient { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenInfo {\n");
            
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            
            sb.Append("  HomeOrganization: ").Append(HomeOrganization).Append("\n");
            
            sb.Append("  OAuthClient: ").Append(OAuthClient).Append("\n");
            
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
            return this.Equals(obj as TokenInfo);
        }

        /// <summary>
        /// Returns true if TokenInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of TokenInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Organization == other.Organization ||
                    this.Organization != null &&
                    this.Organization.Equals(other.Organization)
                ) &&
                (
                    this.HomeOrganization == other.HomeOrganization ||
                    this.HomeOrganization != null &&
                    this.HomeOrganization.Equals(other.HomeOrganization)
                ) &&
                (
                    this.OAuthClient == other.OAuthClient ||
                    this.OAuthClient != null &&
                    this.OAuthClient.Equals(other.OAuthClient)
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
                
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
                
                if (this.HomeOrganization != null)
                    hash = hash * 59 + this.HomeOrganization.GetHashCode();
                
                if (this.OAuthClient != null)
                    hash = hash * 59 + this.OAuthClient.GetHashCode();
                
                return hash;
            }
        }
    }

}
