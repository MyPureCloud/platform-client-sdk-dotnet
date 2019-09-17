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
    /// WidgetDeployment
    /// </summary>
    [DataContract]
    public partial class WidgetDeployment :  IEquatable<WidgetDeployment>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of display widget for which this Deployment is configured, which controls the administrator settings shown.
        /// </summary>
        /// <value>The type of display widget for which this Deployment is configured, which controls the administrator settings shown.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ClientTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum V1 for "v1"
            /// </summary>
            [EnumMember(Value = "v1")]
            V1,
            
            /// <summary>
            /// Enum V2 for "v2"
            /// </summary>
            [EnumMember(Value = "v2")]
            V2,
            
            /// <summary>
            /// Enum V1http for "v1-http"
            /// </summary>
            [EnumMember(Value = "v1-http")]
            V1http,
            
            /// <summary>
            /// Enum Thirdparty for "third-party"
            /// </summary>
            [EnumMember(Value = "third-party")]
            Thirdparty
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of display widget for which this Deployment is configured, which controls the administrator settings shown.
        /// </summary>
        /// <value>The type of display widget for which this Deployment is configured, which controls the administrator settings shown.</value>
        [DataMember(Name="clientType", EmitDefaultValue=false)]
        public ClientTypeEnum? ClientType { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetDeployment" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">A human-readable description of this Deployment..</param>
        /// <param name="AuthenticationRequired">When true, the customer members starting a chat must be authenticated by supplying their JWT to the create operation..</param>
        /// <param name="Disabled">When true, all create chat operations using this Deployment will be rejected..</param>
        /// <param name="Flow">The URI of the Inbound Chat Flow to run when new chats are initiated under this Deployment..</param>
        /// <param name="AllowedDomains">The list of domains that are approved to use this Deployment; the list will be added to CORS headers for ease of web use..</param>
        /// <param name="ClientType">The type of display widget for which this Deployment is configured, which controls the administrator settings shown..</param>
        /// <param name="ClientConfig">The client configuration options that should be made available to the clients of this Deployment..</param>
        public WidgetDeployment(string Name = null, string Description = null, bool? AuthenticationRequired = null, bool? Disabled = null, DomainEntityRef Flow = null, List<string> AllowedDomains = null, ClientTypeEnum? ClientType = null, WidgetClientConfig ClientConfig = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.AuthenticationRequired = AuthenticationRequired;
            this.Disabled = Disabled;
            this.Flow = Flow;
            this.AllowedDomains = AllowedDomains;
            this.ClientType = ClientType;
            this.ClientConfig = ClientConfig;
            
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
        /// A human-readable description of this Deployment.
        /// </summary>
        /// <value>A human-readable description of this Deployment.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// When true, the customer members starting a chat must be authenticated by supplying their JWT to the create operation.
        /// </summary>
        /// <value>When true, the customer members starting a chat must be authenticated by supplying their JWT to the create operation.</value>
        [DataMember(Name="authenticationRequired", EmitDefaultValue=false)]
        public bool? AuthenticationRequired { get; set; }
        
        
        
        /// <summary>
        /// When true, all create chat operations using this Deployment will be rejected.
        /// </summary>
        /// <value>When true, all create chat operations using this Deployment will be rejected.</value>
        [DataMember(Name="disabled", EmitDefaultValue=false)]
        public bool? Disabled { get; set; }
        
        
        
        /// <summary>
        /// The URI of the Inbound Chat Flow to run when new chats are initiated under this Deployment.
        /// </summary>
        /// <value>The URI of the Inbound Chat Flow to run when new chats are initiated under this Deployment.</value>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public DomainEntityRef Flow { get; set; }
        
        
        
        /// <summary>
        /// The list of domains that are approved to use this Deployment; the list will be added to CORS headers for ease of web use.
        /// </summary>
        /// <value>The list of domains that are approved to use this Deployment; the list will be added to CORS headers for ease of web use.</value>
        [DataMember(Name="allowedDomains", EmitDefaultValue=false)]
        public List<string> AllowedDomains { get; set; }
        
        
        
        
        
        /// <summary>
        /// The client configuration options that should be made available to the clients of this Deployment.
        /// </summary>
        /// <value>The client configuration options that should be made available to the clients of this Deployment.</value>
        [DataMember(Name="clientConfig", EmitDefaultValue=false)]
        public WidgetClientConfig ClientConfig { get; set; }
        
        
        
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
            sb.Append("class WidgetDeployment {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AuthenticationRequired: ").Append(AuthenticationRequired).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  AllowedDomains: ").Append(AllowedDomains).Append("\n");
            sb.Append("  ClientType: ").Append(ClientType).Append("\n");
            sb.Append("  ClientConfig: ").Append(ClientConfig).Append("\n");
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
            return this.Equals(obj as WidgetDeployment);
        }

        /// <summary>
        /// Returns true if WidgetDeployment instances are equal
        /// </summary>
        /// <param name="other">Instance of WidgetDeployment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WidgetDeployment other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.AuthenticationRequired == other.AuthenticationRequired ||
                    this.AuthenticationRequired != null &&
                    this.AuthenticationRequired.Equals(other.AuthenticationRequired)
                ) &&
                (
                    this.Disabled == other.Disabled ||
                    this.Disabled != null &&
                    this.Disabled.Equals(other.Disabled)
                ) &&
                (
                    this.Flow == other.Flow ||
                    this.Flow != null &&
                    this.Flow.Equals(other.Flow)
                ) &&
                (
                    this.AllowedDomains == other.AllowedDomains ||
                    this.AllowedDomains != null &&
                    this.AllowedDomains.SequenceEqual(other.AllowedDomains)
                ) &&
                (
                    this.ClientType == other.ClientType ||
                    this.ClientType != null &&
                    this.ClientType.Equals(other.ClientType)
                ) &&
                (
                    this.ClientConfig == other.ClientConfig ||
                    this.ClientConfig != null &&
                    this.ClientConfig.Equals(other.ClientConfig)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.AuthenticationRequired != null)
                    hash = hash * 59 + this.AuthenticationRequired.GetHashCode();
                
                if (this.Disabled != null)
                    hash = hash * 59 + this.Disabled.GetHashCode();
                
                if (this.Flow != null)
                    hash = hash * 59 + this.Flow.GetHashCode();
                
                if (this.AllowedDomains != null)
                    hash = hash * 59 + this.AllowedDomains.GetHashCode();
                
                if (this.ClientType != null)
                    hash = hash * 59 + this.ClientType.GetHashCode();
                
                if (this.ClientConfig != null)
                    hash = hash * 59 + this.ClientConfig.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
