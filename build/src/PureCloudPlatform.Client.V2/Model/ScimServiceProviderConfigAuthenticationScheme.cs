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
    /// Authentication Schema
    /// </summary>
    [DataContract]
    public partial class ScimServiceProviderConfigAuthenticationScheme :  IEquatable<ScimServiceProviderConfigAuthenticationScheme>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The authentication type.
        /// </summary>
        /// <value>The authentication type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Oauth for "oauth"
            /// </summary>
            [EnumMember(Value = "oauth")]
            Oauth,
            
            /// <summary>
            /// Enum Oauth2 for "oauth2"
            /// </summary>
            [EnumMember(Value = "oauth2")]
            Oauth2,
            
            /// <summary>
            /// Enum Oauthbearertoken for "oauthbearertoken"
            /// </summary>
            [EnumMember(Value = "oauthbearertoken")]
            Oauthbearertoken,
            
            /// <summary>
            /// Enum Httpbasic for "httpbasic"
            /// </summary>
            [EnumMember(Value = "httpbasic")]
            Httpbasic,
            
            /// <summary>
            /// Enum Httpdigest for "httpdigest"
            /// </summary>
            [EnumMember(Value = "httpdigest")]
            Httpdigest
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The authentication type.
        /// </summary>
        /// <value>The authentication type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimServiceProviderConfigAuthenticationScheme" /> class.
        /// </summary>
        public ScimServiceProviderConfigAuthenticationScheme()
        {
            
        }
        
        
        
        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }
        
        
        
        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }
        
        
        
        /// <summary>
        /// An HTTP-addressable URL pointing to the authentication scheme&#39;s specification.
        /// </summary>
        /// <value>An HTTP-addressable URL pointing to the authentication scheme&#39;s specification.</value>
        [DataMember(Name="specUri", EmitDefaultValue=false)]
        public string SpecUri { get; private set; }
        
        
        
        /// <summary>
        /// An HTTP-addressable URL pointing to the authentication scheme&#39;s usage documentation
        /// </summary>
        /// <value>An HTTP-addressable URL pointing to the authentication scheme&#39;s usage documentation</value>
        [DataMember(Name="documentationUri", EmitDefaultValue=false)]
        public string DocumentationUri { get; private set; }
        
        
        
        
        
        /// <summary>
        /// Indication of primary method of authentication.
        /// </summary>
        /// <value>Indication of primary method of authentication.</value>
        [DataMember(Name="primary", EmitDefaultValue=false)]
        public bool? Primary { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimServiceProviderConfigAuthenticationScheme {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SpecUri: ").Append(SpecUri).Append("\n");
            sb.Append("  DocumentationUri: ").Append(DocumentationUri).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
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
            return this.Equals(obj as ScimServiceProviderConfigAuthenticationScheme);
        }

        /// <summary>
        /// Returns true if ScimServiceProviderConfigAuthenticationScheme instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimServiceProviderConfigAuthenticationScheme to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimServiceProviderConfigAuthenticationScheme other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.SpecUri == other.SpecUri ||
                    this.SpecUri != null &&
                    this.SpecUri.Equals(other.SpecUri)
                ) &&
                (
                    this.DocumentationUri == other.DocumentationUri ||
                    this.DocumentationUri != null &&
                    this.DocumentationUri.Equals(other.DocumentationUri)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Primary == other.Primary ||
                    this.Primary != null &&
                    this.Primary.Equals(other.Primary)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.SpecUri != null)
                    hash = hash * 59 + this.SpecUri.GetHashCode();
                
                if (this.DocumentationUri != null)
                    hash = hash * 59 + this.DocumentationUri.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Primary != null)
                    hash = hash * 59 + this.Primary.GetHashCode();
                
                return hash;
            }
        }
    }

}
