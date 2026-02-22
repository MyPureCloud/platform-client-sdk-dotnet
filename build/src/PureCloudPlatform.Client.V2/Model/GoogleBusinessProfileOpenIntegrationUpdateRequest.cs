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
    /// GoogleBusinessProfileOpenIntegrationUpdateRequest
    /// </summary>
    [DataContract]
    public partial class GoogleBusinessProfileOpenIntegrationUpdateRequest :  IEquatable<GoogleBusinessProfileOpenIntegrationUpdateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleBusinessProfileOpenIntegrationUpdateRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the Google Business Profile Open Integration..</param>
        /// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
        /// <param name="MessagingSetting">Defines the message settings to be applied for this integration.</param>
        /// <param name="Token">Google OAuth 2 access token reference. The actual token cannot be accessed via Genesys API, only referenced by this property by its ID. When the token is not referenced by any integration, it is deleted after 24 hours..</param>
        /// <param name="Account">Google Business Profile account accessible with the authorization token.</param>
        public GoogleBusinessProfileOpenIntegrationUpdateRequest(string Name = null, SupportedContentReference SupportedContent = null, MessagingSettingRequestReference MessagingSetting = null, GoogleAuthTokenReference Token = null, GoogleBusinessProfileAccountReference Account = null)
        {
            this.Name = Name;
            this.SupportedContent = SupportedContent;
            this.MessagingSetting = MessagingSetting;
            this.Token = Token;
            this.Account = Account;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the Google Business Profile Open Integration.
        /// </summary>
        /// <value>The name of the Google Business Profile Open Integration.</value>
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
        /// Google OAuth 2 access token reference. The actual token cannot be accessed via Genesys API, only referenced by this property by its ID. When the token is not referenced by any integration, it is deleted after 24 hours.
        /// </summary>
        /// <value>Google OAuth 2 access token reference. The actual token cannot be accessed via Genesys API, only referenced by this property by its ID. When the token is not referenced by any integration, it is deleted after 24 hours.</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public GoogleAuthTokenReference Token { get; set; }



        /// <summary>
        /// Google Business Profile account accessible with the authorization token
        /// </summary>
        /// <value>Google Business Profile account accessible with the authorization token</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public GoogleBusinessProfileAccountReference Account { get; set; }



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
            sb.Append("class GoogleBusinessProfileOpenIntegrationUpdateRequest {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
            sb.Append("  MessagingSetting: ").Append(MessagingSetting).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
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
            return this.Equals(obj as GoogleBusinessProfileOpenIntegrationUpdateRequest);
        }

        /// <summary>
        /// Returns true if GoogleBusinessProfileOpenIntegrationUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GoogleBusinessProfileOpenIntegrationUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleBusinessProfileOpenIntegrationUpdateRequest other)
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
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) &&
                (
                    this.Account == other.Account ||
                    this.Account != null &&
                    this.Account.Equals(other.Account)
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

                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();

                if (this.Account != null)
                    hash = hash * 59 + this.Account.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
