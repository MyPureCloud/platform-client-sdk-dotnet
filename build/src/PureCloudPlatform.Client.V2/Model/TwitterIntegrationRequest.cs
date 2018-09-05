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
    /// TwitterIntegrationRequest
    /// </summary>
    [DataContract]
    public partial class TwitterIntegrationRequest :  IEquatable<TwitterIntegrationRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of twitter account to be used for the integration
        /// </summary>
        /// <value>The type of twitter account to be used for the integration</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TierEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Premium for "premium"
            /// </summary>
            [EnumMember(Value = "premium")]
            Premium,
            
            /// <summary>
            /// Enum Enterprise for "enterprise"
            /// </summary>
            [EnumMember(Value = "enterprise")]
            Enterprise
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of twitter account to be used for the integration
        /// </summary>
        /// <value>The type of twitter account to be used for the integration</value>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public TierEnum? Tier { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterIntegrationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TwitterIntegrationRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterIntegrationRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the Twitter Integration (required).</param>
        /// <param name="AccessTokenKey">The Access Token Key from Twitter messenger (required).</param>
        /// <param name="AccessTokenSecret">The Access Token Secret from Twitter messenger (required).</param>
        /// <param name="ConsumerKey">The Consumer Key from Twitter messenger (required).</param>
        /// <param name="ConsumerSecret">The Consumer Secret from Twitter messenger (required).</param>
        /// <param name="Tier">The type of twitter account to be used for the integration (required).</param>
        /// <param name="EnvName">The Twitter environment name, e.g.: env-beta (required for premium tier).</param>
        public TwitterIntegrationRequest(string Name = null, string AccessTokenKey = null, string AccessTokenSecret = null, string ConsumerKey = null, string ConsumerSecret = null, TierEnum? Tier = null, string EnvName = null)
        {
            this.Name = Name;
            this.AccessTokenKey = AccessTokenKey;
            this.AccessTokenSecret = AccessTokenSecret;
            this.ConsumerKey = ConsumerKey;
            this.ConsumerSecret = ConsumerSecret;
            this.Tier = Tier;
            this.EnvName = EnvName;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The name of the Twitter Integration
        /// </summary>
        /// <value>The name of the Twitter Integration</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The Access Token Key from Twitter messenger
        /// </summary>
        /// <value>The Access Token Key from Twitter messenger</value>
        [DataMember(Name="accessTokenKey", EmitDefaultValue=false)]
        public string AccessTokenKey { get; set; }
        
        
        
        /// <summary>
        /// The Access Token Secret from Twitter messenger
        /// </summary>
        /// <value>The Access Token Secret from Twitter messenger</value>
        [DataMember(Name="accessTokenSecret", EmitDefaultValue=false)]
        public string AccessTokenSecret { get; set; }
        
        
        
        /// <summary>
        /// The Consumer Key from Twitter messenger
        /// </summary>
        /// <value>The Consumer Key from Twitter messenger</value>
        [DataMember(Name="consumerKey", EmitDefaultValue=false)]
        public string ConsumerKey { get; set; }
        
        
        
        /// <summary>
        /// The Consumer Secret from Twitter messenger
        /// </summary>
        /// <value>The Consumer Secret from Twitter messenger</value>
        [DataMember(Name="consumerSecret", EmitDefaultValue=false)]
        public string ConsumerSecret { get; set; }
        
        
        
        
        
        /// <summary>
        /// The Twitter environment name, e.g.: env-beta (required for premium tier)
        /// </summary>
        /// <value>The Twitter environment name, e.g.: env-beta (required for premium tier)</value>
        [DataMember(Name="envName", EmitDefaultValue=false)]
        public string EnvName { get; set; }
        
        
        
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
            sb.Append("class TwitterIntegrationRequest {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccessTokenKey: ").Append(AccessTokenKey).Append("\n");
            sb.Append("  AccessTokenSecret: ").Append(AccessTokenSecret).Append("\n");
            sb.Append("  ConsumerKey: ").Append(ConsumerKey).Append("\n");
            sb.Append("  ConsumerSecret: ").Append(ConsumerSecret).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  EnvName: ").Append(EnvName).Append("\n");
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
            return this.Equals(obj as TwitterIntegrationRequest);
        }

        /// <summary>
        /// Returns true if TwitterIntegrationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TwitterIntegrationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TwitterIntegrationRequest other)
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
                    this.AccessTokenKey == other.AccessTokenKey ||
                    this.AccessTokenKey != null &&
                    this.AccessTokenKey.Equals(other.AccessTokenKey)
                ) &&
                (
                    this.AccessTokenSecret == other.AccessTokenSecret ||
                    this.AccessTokenSecret != null &&
                    this.AccessTokenSecret.Equals(other.AccessTokenSecret)
                ) &&
                (
                    this.ConsumerKey == other.ConsumerKey ||
                    this.ConsumerKey != null &&
                    this.ConsumerKey.Equals(other.ConsumerKey)
                ) &&
                (
                    this.ConsumerSecret == other.ConsumerSecret ||
                    this.ConsumerSecret != null &&
                    this.ConsumerSecret.Equals(other.ConsumerSecret)
                ) &&
                (
                    this.Tier == other.Tier ||
                    this.Tier != null &&
                    this.Tier.Equals(other.Tier)
                ) &&
                (
                    this.EnvName == other.EnvName ||
                    this.EnvName != null &&
                    this.EnvName.Equals(other.EnvName)
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
                
                if (this.AccessTokenKey != null)
                    hash = hash * 59 + this.AccessTokenKey.GetHashCode();
                
                if (this.AccessTokenSecret != null)
                    hash = hash * 59 + this.AccessTokenSecret.GetHashCode();
                
                if (this.ConsumerKey != null)
                    hash = hash * 59 + this.ConsumerKey.GetHashCode();
                
                if (this.ConsumerSecret != null)
                    hash = hash * 59 + this.ConsumerSecret.GetHashCode();
                
                if (this.Tier != null)
                    hash = hash * 59 + this.Tier.GetHashCode();
                
                if (this.EnvName != null)
                    hash = hash * 59 + this.EnvName.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
