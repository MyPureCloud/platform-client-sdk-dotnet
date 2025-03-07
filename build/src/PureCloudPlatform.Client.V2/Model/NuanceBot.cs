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
    /// Model for a Nuance bot
    /// </summary>
    [DataContract]
    public partial class NuanceBot :  IEquatable<NuanceBot>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="NuanceBot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NuanceBot() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NuanceBot" /> class.
        /// </summary>
        /// <param name="Id">Nuance bot Id (required).</param>
        /// <param name="Name">Nuance bot name (required).</param>
        /// <param name="IntegrationId">The Integration Id for this bot (required).</param>
        /// <param name="NuanceOrganization">The Nuance Organization for this bot (required).</param>
        /// <param name="Application">The Application for this bot (required).</param>
        /// <param name="NuanceEnvironment">The environment of the Nuance bot (required).</param>
        /// <param name="Geography">The Geography of the Nuance bot (required).</param>
        /// <param name="Credentials">client ID/Secret objects for the credentials that execute this Nuance bot.</param>
        /// <param name="Variables">List of available variables in this Nuance bot.  When querying, use the &#39;expand&#x3D;variables&#39; query param to populate this value.</param>
        /// <param name="TransferNodes">List of transferNodes in this Nuance bot.  When querying, use the &#39;expand&#x3D;transferNodes&#39; query param to populate this value.</param>
        /// <param name="Locales">List of locales associated with this Nuance bot.  Generally in the ISO format such as &#39;en-US&#39;.</param>
        /// <param name="Channels">List of channels associated with this Nuance bot..</param>
        public NuanceBot(string Id = null, string Name = null, string IntegrationId = null, NuanceOrganization NuanceOrganization = null, NuanceApplication Application = null, NuanceEnvironment NuanceEnvironment = null, NuanceGeography Geography = null, List<NuanceBotCredentials> Credentials = null, List<NuanceBotVariable> Variables = null, List<NuanceBotTransferNode> TransferNodes = null, List<string> Locales = null, List<NuanceChannel> Channels = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.IntegrationId = IntegrationId;
            this.NuanceOrganization = NuanceOrganization;
            this.Application = Application;
            this.NuanceEnvironment = NuanceEnvironment;
            this.Geography = Geography;
            this.Credentials = Credentials;
            this.Variables = Variables;
            this.TransferNodes = TransferNodes;
            this.Locales = Locales;
            this.Channels = Channels;
            
        }
        


        /// <summary>
        /// Nuance bot Id
        /// </summary>
        /// <value>Nuance bot Id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Nuance bot name
        /// </summary>
        /// <value>Nuance bot name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The Integration Id for this bot
        /// </summary>
        /// <value>The Integration Id for this bot</value>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public string IntegrationId { get; set; }



        /// <summary>
        /// The Nuance Organization for this bot
        /// </summary>
        /// <value>The Nuance Organization for this bot</value>
        [DataMember(Name="nuanceOrganization", EmitDefaultValue=false)]
        public NuanceOrganization NuanceOrganization { get; set; }



        /// <summary>
        /// The Application for this bot
        /// </summary>
        /// <value>The Application for this bot</value>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public NuanceApplication Application { get; set; }



        /// <summary>
        /// The environment of the Nuance bot
        /// </summary>
        /// <value>The environment of the Nuance bot</value>
        [DataMember(Name="nuanceEnvironment", EmitDefaultValue=false)]
        public NuanceEnvironment NuanceEnvironment { get; set; }



        /// <summary>
        /// The Geography of the Nuance bot
        /// </summary>
        /// <value>The Geography of the Nuance bot</value>
        [DataMember(Name="geography", EmitDefaultValue=false)]
        public NuanceGeography Geography { get; set; }



        /// <summary>
        /// client ID/Secret objects for the credentials that execute this Nuance bot
        /// </summary>
        /// <value>client ID/Secret objects for the credentials that execute this Nuance bot</value>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public List<NuanceBotCredentials> Credentials { get; set; }



        /// <summary>
        /// List of available variables in this Nuance bot.  When querying, use the &#39;expand&#x3D;variables&#39; query param to populate this value
        /// </summary>
        /// <value>List of available variables in this Nuance bot.  When querying, use the &#39;expand&#x3D;variables&#39; query param to populate this value</value>
        [DataMember(Name="variables", EmitDefaultValue=false)]
        public List<NuanceBotVariable> Variables { get; set; }



        /// <summary>
        /// List of transferNodes in this Nuance bot.  When querying, use the &#39;expand&#x3D;transferNodes&#39; query param to populate this value
        /// </summary>
        /// <value>List of transferNodes in this Nuance bot.  When querying, use the &#39;expand&#x3D;transferNodes&#39; query param to populate this value</value>
        [DataMember(Name="transferNodes", EmitDefaultValue=false)]
        public List<NuanceBotTransferNode> TransferNodes { get; set; }



        /// <summary>
        /// List of locales associated with this Nuance bot.  Generally in the ISO format such as &#39;en-US&#39;
        /// </summary>
        /// <value>List of locales associated with this Nuance bot.  Generally in the ISO format such as &#39;en-US&#39;</value>
        [DataMember(Name="locales", EmitDefaultValue=false)]
        public List<string> Locales { get; set; }



        /// <summary>
        /// List of channels associated with this Nuance bot.
        /// </summary>
        /// <value>List of channels associated with this Nuance bot.</value>
        [DataMember(Name="channels", EmitDefaultValue=false)]
        public List<NuanceChannel> Channels { get; set; }



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
            sb.Append("class NuanceBot {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
            sb.Append("  NuanceOrganization: ").Append(NuanceOrganization).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  NuanceEnvironment: ").Append(NuanceEnvironment).Append("\n");
            sb.Append("  Geography: ").Append(Geography).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  TransferNodes: ").Append(TransferNodes).Append("\n");
            sb.Append("  Locales: ").Append(Locales).Append("\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
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
            return this.Equals(obj as NuanceBot);
        }

        /// <summary>
        /// Returns true if NuanceBot instances are equal
        /// </summary>
        /// <param name="other">Instance of NuanceBot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NuanceBot other)
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
                    this.IntegrationId == other.IntegrationId ||
                    this.IntegrationId != null &&
                    this.IntegrationId.Equals(other.IntegrationId)
                ) &&
                (
                    this.NuanceOrganization == other.NuanceOrganization ||
                    this.NuanceOrganization != null &&
                    this.NuanceOrganization.Equals(other.NuanceOrganization)
                ) &&
                (
                    this.Application == other.Application ||
                    this.Application != null &&
                    this.Application.Equals(other.Application)
                ) &&
                (
                    this.NuanceEnvironment == other.NuanceEnvironment ||
                    this.NuanceEnvironment != null &&
                    this.NuanceEnvironment.Equals(other.NuanceEnvironment)
                ) &&
                (
                    this.Geography == other.Geography ||
                    this.Geography != null &&
                    this.Geography.Equals(other.Geography)
                ) &&
                (
                    this.Credentials == other.Credentials ||
                    this.Credentials != null &&
                    this.Credentials.SequenceEqual(other.Credentials)
                ) &&
                (
                    this.Variables == other.Variables ||
                    this.Variables != null &&
                    this.Variables.SequenceEqual(other.Variables)
                ) &&
                (
                    this.TransferNodes == other.TransferNodes ||
                    this.TransferNodes != null &&
                    this.TransferNodes.SequenceEqual(other.TransferNodes)
                ) &&
                (
                    this.Locales == other.Locales ||
                    this.Locales != null &&
                    this.Locales.SequenceEqual(other.Locales)
                ) &&
                (
                    this.Channels == other.Channels ||
                    this.Channels != null &&
                    this.Channels.SequenceEqual(other.Channels)
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

                if (this.IntegrationId != null)
                    hash = hash * 59 + this.IntegrationId.GetHashCode();

                if (this.NuanceOrganization != null)
                    hash = hash * 59 + this.NuanceOrganization.GetHashCode();

                if (this.Application != null)
                    hash = hash * 59 + this.Application.GetHashCode();

                if (this.NuanceEnvironment != null)
                    hash = hash * 59 + this.NuanceEnvironment.GetHashCode();

                if (this.Geography != null)
                    hash = hash * 59 + this.Geography.GetHashCode();

                if (this.Credentials != null)
                    hash = hash * 59 + this.Credentials.GetHashCode();

                if (this.Variables != null)
                    hash = hash * 59 + this.Variables.GetHashCode();

                if (this.TransferNodes != null)
                    hash = hash * 59 + this.TransferNodes.GetHashCode();

                if (this.Locales != null)
                    hash = hash * 59 + this.Locales.GetHashCode();

                if (this.Channels != null)
                    hash = hash * 59 + this.Channels.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
