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
    /// PostTextRequest
    /// </summary>
    [DataContract]
    public partial class PostTextRequest :  IEquatable<PostTextRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets BotChannels
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum BotChannelsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Call for "Call"
            /// </summary>
            [EnumMember(Value = "Call")]
            Call,
            
            /// <summary>
            /// Enum Callback for "Callback"
            /// </summary>
            [EnumMember(Value = "Callback")]
            Callback,
            
            /// <summary>
            /// Enum Messaging for "Messaging"
            /// </summary>
            [EnumMember(Value = "Messaging")]
            Messaging,
            
            /// <summary>
            /// Enum Webchat for "Webchat"
            /// </summary>
            [EnumMember(Value = "Webchat")]
            Webchat
        }
        
        
        
        
        
        
        
        /// <summary>
        /// If the channels list contains a 'Messaging' item and the messaging platform is known, include it here to get accurate analytics
        /// </summary>
        /// <value>If the channels list contains a 'Messaging' item and the messaging platform is known, include it here to get accurate analytics</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MessagingPlatformTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Phone for "Phone"
            /// </summary>
            [EnumMember(Value = "Phone")]
            Phone,
            
            /// <summary>
            /// Enum Sms for "SMS"
            /// </summary>
            [EnumMember(Value = "SMS")]
            Sms,
            
            /// <summary>
            /// Enum Genesyswebwidget for "GenesysWebWidget"
            /// </summary>
            [EnumMember(Value = "GenesysWebWidget")]
            Genesyswebwidget,
            
            /// <summary>
            /// Enum Facebookmessenger for "FacebookMessenger"
            /// </summary>
            [EnumMember(Value = "FacebookMessenger")]
            Facebookmessenger,
            
            /// <summary>
            /// Enum Wechat for "WeChat"
            /// </summary>
            [EnumMember(Value = "WeChat")]
            Wechat,
            
            /// <summary>
            /// Enum Whatsapp for "Whatsapp"
            /// </summary>
            [EnumMember(Value = "Whatsapp")]
            Whatsapp,
            
            /// <summary>
            /// Enum Applebusinesschat for "AppleBusinessChat"
            /// </summary>
            [EnumMember(Value = "AppleBusinessChat")]
            Applebusinesschat,
            
            /// <summary>
            /// Enum Telegram for "Telegram"
            /// </summary>
            [EnumMember(Value = "Telegram")]
            Telegram,
            
            /// <summary>
            /// Enum Slack for "Slack"
            /// </summary>
            [EnumMember(Value = "Slack")]
            Slack,
            
            /// <summary>
            /// Enum Signal for "Signal"
            /// </summary>
            [EnumMember(Value = "Signal")]
            Signal,
            
            /// <summary>
            /// Enum Line for "Line"
            /// </summary>
            [EnumMember(Value = "Line")]
            Line,
            
            /// <summary>
            /// Enum Discord for "Discord"
            /// </summary>
            [EnumMember(Value = "Discord")]
            Discord,
            
            /// <summary>
            /// Enum Twitterdirectmessage for "TwitterDirectMessage"
            /// </summary>
            [EnumMember(Value = "TwitterDirectMessage")]
            Twitterdirectmessage,
            
            /// <summary>
            /// Enum Other for "Other"
            /// </summary>
            [EnumMember(Value = "Other")]
            Other,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// If the channels list contains a 'Messaging' item and the messaging platform is known, include it here to get accurate analytics
        /// </summary>
        /// <value>If the channels list contains a 'Messaging' item and the messaging platform is known, include it here to get accurate analytics</value>
        [DataMember(Name="messagingPlatformType", EmitDefaultValue=false)]
        public MessagingPlatformTypeEnum? MessagingPlatformType { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PostTextRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostTextRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PostTextRequest" /> class.
        /// </summary>
        /// <param name="BotId">ID of the bot to send the text to. (required).</param>
        /// <param name="BotAlias">Alias/Version of the bot.</param>
        /// <param name="IntegrationId">the integration service id for the bot&#39;s credentials (required).</param>
        /// <param name="BotSessionId">GUID for this bot&#39;s session (required).</param>
        /// <param name="PostTextMessage">Message to send to the bot (required).</param>
        /// <param name="LanguageCode">The launguage code the bot will run under.</param>
        /// <param name="BotSessionTimeoutMinutes">Override timeout for the bot session. This should be greater than 10 minutes..</param>
        /// <param name="BotChannels">The channels this bot is utilizing.</param>
        /// <param name="BotCorrelationId">Id for tracking the activity - this will be returned in the response.</param>
        /// <param name="MessagingPlatformType">If the channels list contains a &#39;Messaging&#39; item and the messaging platform is known, include it here to get accurate analytics.</param>
        /// <param name="AmazonLexRequest">Provider specific settings, if any.</param>
        /// <param name="GoogleDialogflow">Provider specific settings, if any.</param>
        /// <param name="GenesysBotConnector">Provider specific settings, if any.</param>
        /// <param name="NuanceMixDlg">Provider specific settings, if any.</param>
        public PostTextRequest(string BotId = null, string BotAlias = null, string IntegrationId = null, string BotSessionId = null, PostTextMessage PostTextMessage = null, string LanguageCode = null, int? BotSessionTimeoutMinutes = null, List<BotChannelsEnum> BotChannels = null, string BotCorrelationId = null, MessagingPlatformTypeEnum? MessagingPlatformType = null, AmazonLexRequest AmazonLexRequest = null, GoogleDialogflowCustomSettings GoogleDialogflow = null, GenesysBotConnector GenesysBotConnector = null, NuanceMixDlgSettings NuanceMixDlg = null)
        {
            this.BotId = BotId;
            this.BotAlias = BotAlias;
            this.IntegrationId = IntegrationId;
            this.BotSessionId = BotSessionId;
            this.PostTextMessage = PostTextMessage;
            this.LanguageCode = LanguageCode;
            this.BotSessionTimeoutMinutes = BotSessionTimeoutMinutes;
            this.BotChannels = BotChannels;
            this.BotCorrelationId = BotCorrelationId;
            this.MessagingPlatformType = MessagingPlatformType;
            this.AmazonLexRequest = AmazonLexRequest;
            this.GoogleDialogflow = GoogleDialogflow;
            this.GenesysBotConnector = GenesysBotConnector;
            this.NuanceMixDlg = NuanceMixDlg;
            
        }
        
        
        
        /// <summary>
        /// ID of the bot to send the text to.
        /// </summary>
        /// <value>ID of the bot to send the text to.</value>
        [DataMember(Name="botId", EmitDefaultValue=false)]
        public string BotId { get; set; }
        
        
        
        /// <summary>
        /// Alias/Version of the bot
        /// </summary>
        /// <value>Alias/Version of the bot</value>
        [DataMember(Name="botAlias", EmitDefaultValue=false)]
        public string BotAlias { get; set; }
        
        
        
        /// <summary>
        /// the integration service id for the bot&#39;s credentials
        /// </summary>
        /// <value>the integration service id for the bot&#39;s credentials</value>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public string IntegrationId { get; set; }
        
        
        
        /// <summary>
        /// GUID for this bot&#39;s session
        /// </summary>
        /// <value>GUID for this bot&#39;s session</value>
        [DataMember(Name="botSessionId", EmitDefaultValue=false)]
        public string BotSessionId { get; set; }
        
        
        
        /// <summary>
        /// Message to send to the bot
        /// </summary>
        /// <value>Message to send to the bot</value>
        [DataMember(Name="postTextMessage", EmitDefaultValue=false)]
        public PostTextMessage PostTextMessage { get; set; }
        
        
        
        /// <summary>
        /// The launguage code the bot will run under
        /// </summary>
        /// <value>The launguage code the bot will run under</value>
        [DataMember(Name="languageCode", EmitDefaultValue=false)]
        public string LanguageCode { get; set; }
        
        
        
        /// <summary>
        /// Override timeout for the bot session. This should be greater than 10 minutes.
        /// </summary>
        /// <value>Override timeout for the bot session. This should be greater than 10 minutes.</value>
        [DataMember(Name="botSessionTimeoutMinutes", EmitDefaultValue=false)]
        public int? BotSessionTimeoutMinutes { get; set; }
        
        
        
        /// <summary>
        /// The channels this bot is utilizing
        /// </summary>
        /// <value>The channels this bot is utilizing</value>
        [DataMember(Name="botChannels", EmitDefaultValue=false)]
        public List<BotChannelsEnum> BotChannels { get; set; }
        
        
        
        /// <summary>
        /// Id for tracking the activity - this will be returned in the response
        /// </summary>
        /// <value>Id for tracking the activity - this will be returned in the response</value>
        [DataMember(Name="botCorrelationId", EmitDefaultValue=false)]
        public string BotCorrelationId { get; set; }
        
        
        
        
        
        /// <summary>
        /// Provider specific settings, if any
        /// </summary>
        /// <value>Provider specific settings, if any</value>
        [DataMember(Name="amazonLexRequest", EmitDefaultValue=false)]
        public AmazonLexRequest AmazonLexRequest { get; set; }
        
        
        
        /// <summary>
        /// Provider specific settings, if any
        /// </summary>
        /// <value>Provider specific settings, if any</value>
        [DataMember(Name="googleDialogflow", EmitDefaultValue=false)]
        public GoogleDialogflowCustomSettings GoogleDialogflow { get; set; }
        
        
        
        /// <summary>
        /// Provider specific settings, if any
        /// </summary>
        /// <value>Provider specific settings, if any</value>
        [DataMember(Name="genesysBotConnector", EmitDefaultValue=false)]
        public GenesysBotConnector GenesysBotConnector { get; set; }
        
        
        
        /// <summary>
        /// Provider specific settings, if any
        /// </summary>
        /// <value>Provider specific settings, if any</value>
        [DataMember(Name="nuanceMixDlg", EmitDefaultValue=false)]
        public NuanceMixDlgSettings NuanceMixDlg { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostTextRequest {\n");
            
            sb.Append("  BotId: ").Append(BotId).Append("\n");
            sb.Append("  BotAlias: ").Append(BotAlias).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
            sb.Append("  BotSessionId: ").Append(BotSessionId).Append("\n");
            sb.Append("  PostTextMessage: ").Append(PostTextMessage).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  BotSessionTimeoutMinutes: ").Append(BotSessionTimeoutMinutes).Append("\n");
            sb.Append("  BotChannels: ").Append(BotChannels).Append("\n");
            sb.Append("  BotCorrelationId: ").Append(BotCorrelationId).Append("\n");
            sb.Append("  MessagingPlatformType: ").Append(MessagingPlatformType).Append("\n");
            sb.Append("  AmazonLexRequest: ").Append(AmazonLexRequest).Append("\n");
            sb.Append("  GoogleDialogflow: ").Append(GoogleDialogflow).Append("\n");
            sb.Append("  GenesysBotConnector: ").Append(GenesysBotConnector).Append("\n");
            sb.Append("  NuanceMixDlg: ").Append(NuanceMixDlg).Append("\n");
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
            return this.Equals(obj as PostTextRequest);
        }

        /// <summary>
        /// Returns true if PostTextRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PostTextRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostTextRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.BotId == other.BotId ||
                    this.BotId != null &&
                    this.BotId.Equals(other.BotId)
                ) &&
                (
                    this.BotAlias == other.BotAlias ||
                    this.BotAlias != null &&
                    this.BotAlias.Equals(other.BotAlias)
                ) &&
                (
                    this.IntegrationId == other.IntegrationId ||
                    this.IntegrationId != null &&
                    this.IntegrationId.Equals(other.IntegrationId)
                ) &&
                (
                    this.BotSessionId == other.BotSessionId ||
                    this.BotSessionId != null &&
                    this.BotSessionId.Equals(other.BotSessionId)
                ) &&
                (
                    this.PostTextMessage == other.PostTextMessage ||
                    this.PostTextMessage != null &&
                    this.PostTextMessage.Equals(other.PostTextMessage)
                ) &&
                (
                    this.LanguageCode == other.LanguageCode ||
                    this.LanguageCode != null &&
                    this.LanguageCode.Equals(other.LanguageCode)
                ) &&
                (
                    this.BotSessionTimeoutMinutes == other.BotSessionTimeoutMinutes ||
                    this.BotSessionTimeoutMinutes != null &&
                    this.BotSessionTimeoutMinutes.Equals(other.BotSessionTimeoutMinutes)
                ) &&
                (
                    this.BotChannels == other.BotChannels ||
                    this.BotChannels != null &&
                    this.BotChannels.SequenceEqual(other.BotChannels)
                ) &&
                (
                    this.BotCorrelationId == other.BotCorrelationId ||
                    this.BotCorrelationId != null &&
                    this.BotCorrelationId.Equals(other.BotCorrelationId)
                ) &&
                (
                    this.MessagingPlatformType == other.MessagingPlatformType ||
                    this.MessagingPlatformType != null &&
                    this.MessagingPlatformType.Equals(other.MessagingPlatformType)
                ) &&
                (
                    this.AmazonLexRequest == other.AmazonLexRequest ||
                    this.AmazonLexRequest != null &&
                    this.AmazonLexRequest.Equals(other.AmazonLexRequest)
                ) &&
                (
                    this.GoogleDialogflow == other.GoogleDialogflow ||
                    this.GoogleDialogflow != null &&
                    this.GoogleDialogflow.Equals(other.GoogleDialogflow)
                ) &&
                (
                    this.GenesysBotConnector == other.GenesysBotConnector ||
                    this.GenesysBotConnector != null &&
                    this.GenesysBotConnector.Equals(other.GenesysBotConnector)
                ) &&
                (
                    this.NuanceMixDlg == other.NuanceMixDlg ||
                    this.NuanceMixDlg != null &&
                    this.NuanceMixDlg.Equals(other.NuanceMixDlg)
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
                
                if (this.BotId != null)
                    hash = hash * 59 + this.BotId.GetHashCode();
                
                if (this.BotAlias != null)
                    hash = hash * 59 + this.BotAlias.GetHashCode();
                
                if (this.IntegrationId != null)
                    hash = hash * 59 + this.IntegrationId.GetHashCode();
                
                if (this.BotSessionId != null)
                    hash = hash * 59 + this.BotSessionId.GetHashCode();
                
                if (this.PostTextMessage != null)
                    hash = hash * 59 + this.PostTextMessage.GetHashCode();
                
                if (this.LanguageCode != null)
                    hash = hash * 59 + this.LanguageCode.GetHashCode();
                
                if (this.BotSessionTimeoutMinutes != null)
                    hash = hash * 59 + this.BotSessionTimeoutMinutes.GetHashCode();
                
                if (this.BotChannels != null)
                    hash = hash * 59 + this.BotChannels.GetHashCode();
                
                if (this.BotCorrelationId != null)
                    hash = hash * 59 + this.BotCorrelationId.GetHashCode();
                
                if (this.MessagingPlatformType != null)
                    hash = hash * 59 + this.MessagingPlatformType.GetHashCode();
                
                if (this.AmazonLexRequest != null)
                    hash = hash * 59 + this.AmazonLexRequest.GetHashCode();
                
                if (this.GoogleDialogflow != null)
                    hash = hash * 59 + this.GoogleDialogflow.GetHashCode();
                
                if (this.GenesysBotConnector != null)
                    hash = hash * 59 + this.GenesysBotConnector.GetHashCode();
                
                if (this.NuanceMixDlg != null)
                    hash = hash * 59 + this.NuanceMixDlg.GetHashCode();
                
                return hash;
            }
        }
    }

}
