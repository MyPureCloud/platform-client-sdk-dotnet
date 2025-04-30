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
    /// BotSearchResponse
    /// </summary>
    [DataContract]
    public partial class BotSearchResponse :  IEquatable<BotSearchResponse>
    {
        /// <summary>
        /// The provider of the bot
        /// </summary>
        /// <value>The provider of the bot</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum BotTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Genesysbotconnector for "GenesysBotConnector"
            /// </summary>
            [EnumMember(Value = "GenesysBotConnector")]
            Genesysbotconnector,
            
            /// <summary>
            /// Enum Genesysdialogengine for "GenesysDialogEngine"
            /// </summary>
            [EnumMember(Value = "GenesysDialogEngine")]
            Genesysdialogengine,
            
            /// <summary>
            /// Enum Amazonlex for "AmazonLex"
            /// </summary>
            [EnumMember(Value = "AmazonLex")]
            Amazonlex,
            
            /// <summary>
            /// Enum Googledialogflowes for "GoogleDialogFlowES"
            /// </summary>
            [EnumMember(Value = "GoogleDialogFlowES")]
            Googledialogflowes,
            
            /// <summary>
            /// Enum Googledialogflowcx for "GoogleDialogFlowCX"
            /// </summary>
            [EnumMember(Value = "GoogleDialogFlowCX")]
            Googledialogflowcx,
            
            /// <summary>
            /// Enum Nuancedlg for "NuanceDlg"
            /// </summary>
            [EnumMember(Value = "NuanceDlg")]
            Nuancedlg,
            
            /// <summary>
            /// Enum Genesysbotflow for "GenesysBotFlow"
            /// </summary>
            [EnumMember(Value = "GenesysBotFlow")]
            Genesysbotflow,
            
            /// <summary>
            /// Enum Genesysdigitalbotflow for "GenesysDigitalBotFlow"
            /// </summary>
            [EnumMember(Value = "GenesysDigitalBotFlow")]
            Genesysdigitalbotflow,
            
            /// <summary>
            /// Enum Genesysvoicesurveyflow for "GenesysVoiceSurveyFlow"
            /// </summary>
            [EnumMember(Value = "GenesysVoiceSurveyFlow")]
            Genesysvoicesurveyflow,
            
            /// <summary>
            /// Enum Genesysdigitalbotconnector for "GenesysDigitalBotConnector"
            /// </summary>
            [EnumMember(Value = "GenesysDigitalBotConnector")]
            Genesysdigitalbotconnector
        }
        /// <summary>
        /// The provider of the bot
        /// </summary>
        /// <value>The provider of the bot</value>
        [DataMember(Name="botType", EmitDefaultValue=false)]
        public BotTypeEnum? BotType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BotSearchResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BotSearchResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BotSearchResponse" /> class.
        /// </summary>
        /// <param name="Id">The id of the bot (required).</param>
        /// <param name="Name">The name of the bot (required).</param>
        /// <param name="BotType">The provider of the bot (required).</param>
        /// <param name="Description">The description of the bot.</param>
        public BotSearchResponse(string Id = null, string Name = null, BotTypeEnum? BotType = null, string Description = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.BotType = BotType;
            this.Description = Description;
            
        }
        


        /// <summary>
        /// The id of the bot
        /// </summary>
        /// <value>The id of the bot</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The name of the bot
        /// </summary>
        /// <value>The name of the bot</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// The description of the bot
        /// </summary>
        /// <value>The description of the bot</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



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
            sb.Append("class BotSearchResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BotType: ").Append(BotType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as BotSearchResponse);
        }

        /// <summary>
        /// Returns true if BotSearchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BotSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BotSearchResponse other)
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
                    this.BotType == other.BotType ||
                    this.BotType != null &&
                    this.BotType.Equals(other.BotType)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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

                if (this.BotType != null)
                    hash = hash * 59 + this.BotType.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
