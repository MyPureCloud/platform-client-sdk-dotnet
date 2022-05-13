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
    /// WebChatDeployment
    /// </summary>
    [DataContract]
    public partial class WebChatDeployment :  IEquatable<WebChatDeployment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebChatDeployment" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="AuthenticationRequired">AuthenticationRequired.</param>
        /// <param name="AuthenticationUrl">URL for third party service authenticating web chat clients. See https://github.com/MyPureCloud/authenticated-web-chat-server-examples.</param>
        /// <param name="Disabled">Disabled.</param>
        /// <param name="WebChatConfig">WebChatConfig.</param>
        /// <param name="AllowedDomains">AllowedDomains.</param>
        /// <param name="Flow">The URI of the Inbound Chat Flow to run when new chats are initiated under this Deployment..</param>
        public WebChatDeployment(string Name = null, string Description = null, bool? AuthenticationRequired = null, string AuthenticationUrl = null, bool? Disabled = null, WebChatConfig WebChatConfig = null, List<string> AllowedDomains = null, DomainEntityRef Flow = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.AuthenticationRequired = AuthenticationRequired;
            this.AuthenticationUrl = AuthenticationUrl;
            this.Disabled = Disabled;
            this.WebChatConfig = WebChatConfig;
            this.AllowedDomains = AllowedDomains;
            this.Flow = Flow;
            
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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Gets or Sets AuthenticationRequired
        /// </summary>
        [DataMember(Name="authenticationRequired", EmitDefaultValue=false)]
        public bool? AuthenticationRequired { get; set; }



        /// <summary>
        /// URL for third party service authenticating web chat clients. See https://github.com/MyPureCloud/authenticated-web-chat-server-examples
        /// </summary>
        /// <value>URL for third party service authenticating web chat clients. See https://github.com/MyPureCloud/authenticated-web-chat-server-examples</value>
        [DataMember(Name="authenticationUrl", EmitDefaultValue=false)]
        public string AuthenticationUrl { get; set; }



        /// <summary>
        /// Gets or Sets Disabled
        /// </summary>
        [DataMember(Name="disabled", EmitDefaultValue=false)]
        public bool? Disabled { get; set; }



        /// <summary>
        /// Gets or Sets WebChatConfig
        /// </summary>
        [DataMember(Name="webChatConfig", EmitDefaultValue=false)]
        public WebChatConfig WebChatConfig { get; set; }



        /// <summary>
        /// Gets or Sets AllowedDomains
        /// </summary>
        [DataMember(Name="allowedDomains", EmitDefaultValue=false)]
        public List<string> AllowedDomains { get; set; }



        /// <summary>
        /// The URI of the Inbound Chat Flow to run when new chats are initiated under this Deployment.
        /// </summary>
        /// <value>The URI of the Inbound Chat Flow to run when new chats are initiated under this Deployment.</value>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public DomainEntityRef Flow { get; set; }



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
            sb.Append("class WebChatDeployment {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AuthenticationRequired: ").Append(AuthenticationRequired).Append("\n");
            sb.Append("  AuthenticationUrl: ").Append(AuthenticationUrl).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  WebChatConfig: ").Append(WebChatConfig).Append("\n");
            sb.Append("  AllowedDomains: ").Append(AllowedDomains).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
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
            return this.Equals(obj as WebChatDeployment);
        }

        /// <summary>
        /// Returns true if WebChatDeployment instances are equal
        /// </summary>
        /// <param name="other">Instance of WebChatDeployment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebChatDeployment other)
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
                    this.AuthenticationUrl == other.AuthenticationUrl ||
                    this.AuthenticationUrl != null &&
                    this.AuthenticationUrl.Equals(other.AuthenticationUrl)
                ) &&
                (
                    this.Disabled == other.Disabled ||
                    this.Disabled != null &&
                    this.Disabled.Equals(other.Disabled)
                ) &&
                (
                    this.WebChatConfig == other.WebChatConfig ||
                    this.WebChatConfig != null &&
                    this.WebChatConfig.Equals(other.WebChatConfig)
                ) &&
                (
                    this.AllowedDomains == other.AllowedDomains ||
                    this.AllowedDomains != null &&
                    this.AllowedDomains.SequenceEqual(other.AllowedDomains)
                ) &&
                (
                    this.Flow == other.Flow ||
                    this.Flow != null &&
                    this.Flow.Equals(other.Flow)
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

                if (this.AuthenticationUrl != null)
                    hash = hash * 59 + this.AuthenticationUrl.GetHashCode();

                if (this.Disabled != null)
                    hash = hash * 59 + this.Disabled.GetHashCode();

                if (this.WebChatConfig != null)
                    hash = hash * 59 + this.WebChatConfig.GetHashCode();

                if (this.AllowedDomains != null)
                    hash = hash * 59 + this.AllowedDomains.GetHashCode();

                if (this.Flow != null)
                    hash = hash * 59 + this.Flow.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
