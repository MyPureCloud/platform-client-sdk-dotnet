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
        /// Initializes a new instance of the <see cref="TwitterIntegrationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TwitterIntegrationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterIntegrationRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the Twitter Integration (required).</param>
        /// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
        /// <param name="MessagingSetting">Defines the message settings to be applied for this integration.</param>
        /// <param name="SignupCode">The authorization code returned from the signup flow to request access tokens later on (required).</param>
        /// <param name="AppId">The appId of the Twitter app to register the integration on (required).</param>
        /// <param name="CodeChallenge">The codeChallenge used during the signup flow (required).</param>
        /// <param name="RedirectUri">The redirectUri used during the signup flow (required).</param>
        public TwitterIntegrationRequest(string Name = null, SupportedContentReference SupportedContent = null, MessagingSettingRequestReference MessagingSetting = null, string SignupCode = null, string AppId = null, string CodeChallenge = null, string RedirectUri = null)
        {
            this.Name = Name;
            this.SupportedContent = SupportedContent;
            this.MessagingSetting = MessagingSetting;
            this.SignupCode = SignupCode;
            this.AppId = AppId;
            this.CodeChallenge = CodeChallenge;
            this.RedirectUri = RedirectUri;
            
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
        /// Defines the SupportedContent profile configured for an integration
        /// </summary>
        /// <value>Defines the SupportedContent profile configured for an integration</value>
        [DataMember(Name="supportedContent", EmitDefaultValue=false)]
        public SupportedContentReference SupportedContent { get; set; }



        /// <summary>
        /// Defines the message settings to be applied for this integration
        /// </summary>
        /// <value>Defines the message settings to be applied for this integration</value>
        [DataMember(Name="messagingSetting", EmitDefaultValue=false)]
        public MessagingSettingRequestReference MessagingSetting { get; set; }



        /// <summary>
        /// The authorization code returned from the signup flow to request access tokens later on
        /// </summary>
        /// <value>The authorization code returned from the signup flow to request access tokens later on</value>
        [DataMember(Name="signupCode", EmitDefaultValue=false)]
        public string SignupCode { get; set; }



        /// <summary>
        /// The appId of the Twitter app to register the integration on
        /// </summary>
        /// <value>The appId of the Twitter app to register the integration on</value>
        [DataMember(Name="appId", EmitDefaultValue=false)]
        public string AppId { get; set; }



        /// <summary>
        /// The codeChallenge used during the signup flow
        /// </summary>
        /// <value>The codeChallenge used during the signup flow</value>
        [DataMember(Name="codeChallenge", EmitDefaultValue=false)]
        public string CodeChallenge { get; set; }



        /// <summary>
        /// The redirectUri used during the signup flow
        /// </summary>
        /// <value>The redirectUri used during the signup flow</value>
        [DataMember(Name="redirectUri", EmitDefaultValue=false)]
        public string RedirectUri { get; set; }



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
            sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
            sb.Append("  MessagingSetting: ").Append(MessagingSetting).Append("\n");
            sb.Append("  SignupCode: ").Append(SignupCode).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  CodeChallenge: ").Append(CodeChallenge).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
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
                    this.SupportedContent == other.SupportedContent ||
                    this.SupportedContent != null &&
                    this.SupportedContent.Equals(other.SupportedContent)
                ) &&
                (
                    this.MessagingSetting == other.MessagingSetting ||
                    this.MessagingSetting != null &&
                    this.MessagingSetting.Equals(other.MessagingSetting)
                ) &&
                (
                    this.SignupCode == other.SignupCode ||
                    this.SignupCode != null &&
                    this.SignupCode.Equals(other.SignupCode)
                ) &&
                (
                    this.AppId == other.AppId ||
                    this.AppId != null &&
                    this.AppId.Equals(other.AppId)
                ) &&
                (
                    this.CodeChallenge == other.CodeChallenge ||
                    this.CodeChallenge != null &&
                    this.CodeChallenge.Equals(other.CodeChallenge)
                ) &&
                (
                    this.RedirectUri == other.RedirectUri ||
                    this.RedirectUri != null &&
                    this.RedirectUri.Equals(other.RedirectUri)
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

                if (this.SupportedContent != null)
                    hash = hash * 59 + this.SupportedContent.GetHashCode();

                if (this.MessagingSetting != null)
                    hash = hash * 59 + this.MessagingSetting.GetHashCode();

                if (this.SignupCode != null)
                    hash = hash * 59 + this.SignupCode.GetHashCode();

                if (this.AppId != null)
                    hash = hash * 59 + this.AppId.GetHashCode();

                if (this.CodeChallenge != null)
                    hash = hash * 59 + this.CodeChallenge.GetHashCode();

                if (this.RedirectUri != null)
                    hash = hash * 59 + this.RedirectUri.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
