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
    /// LocalEncryptionConfiguration
    /// </summary>
    [DataContract]
    public partial class LocalEncryptionConfiguration :  IEquatable<LocalEncryptionConfiguration>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalEncryptionConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LocalEncryptionConfiguration() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalEncryptionConfiguration" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Name">Name.</param>
        
        
        
        /// <param name="Url">The url for decryption. This must specify the path to where Purecloud can requests decryption (required).</param>
        
        
        
        /// <param name="ApiId">The api id for Hawk Authentication. (required).</param>
        
        
        
        /// <param name="ApiKey">The api shared symmetric key used for hawk authentication (required).</param>
        
        
        
        
        public LocalEncryptionConfiguration(string Name = null, string Url = null, string ApiId = null, string ApiKey = null)
        {
            
            
            
            
            
            
            
            
            
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for LocalEncryptionConfiguration and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            
            
            
            
            
            // to ensure "ApiId" is required (not null)
            if (ApiId == null)
            {
                throw new InvalidDataException("ApiId is a required property for LocalEncryptionConfiguration and cannot be null");
            }
            else
            {
                this.ApiId = ApiId;
            }
            
            
            
            
            
            // to ensure "ApiKey" is required (not null)
            if (ApiKey == null)
            {
                throw new InvalidDataException("ApiKey is a required property for LocalEncryptionConfiguration and cannot be null");
            }
            else
            {
                this.ApiKey = ApiKey;
            }
            
            
            
            
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The url for decryption. This must specify the path to where Purecloud can requests decryption
        /// </summary>
        /// <value>The url for decryption. This must specify the path to where Purecloud can requests decryption</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        
        
        
        /// <summary>
        /// The api id for Hawk Authentication.
        /// </summary>
        /// <value>The api id for Hawk Authentication.</value>
        [DataMember(Name="apiId", EmitDefaultValue=false)]
        public string ApiId { get; set; }
        
        
        
        /// <summary>
        /// The api shared symmetric key used for hawk authentication
        /// </summary>
        /// <value>The api shared symmetric key used for hawk authentication</value>
        [DataMember(Name="apiKey", EmitDefaultValue=false)]
        public string ApiKey { get; set; }
        
        
        
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
            sb.Append("class LocalEncryptionConfiguration {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  Url: ").Append(Url).Append("\n");
            
            sb.Append("  ApiId: ").Append(ApiId).Append("\n");
            
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            
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
            return this.Equals(obj as LocalEncryptionConfiguration);
        }

        /// <summary>
        /// Returns true if LocalEncryptionConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of LocalEncryptionConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocalEncryptionConfiguration other)
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
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.ApiId == other.ApiId ||
                    this.ApiId != null &&
                    this.ApiId.Equals(other.ApiId)
                ) &&
                (
                    this.ApiKey == other.ApiKey ||
                    this.ApiKey != null &&
                    this.ApiKey.Equals(other.ApiKey)
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
                
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                
                if (this.ApiId != null)
                    hash = hash * 59 + this.ApiId.GetHashCode();
                
                if (this.ApiKey != null)
                    hash = hash * 59 + this.ApiKey.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
