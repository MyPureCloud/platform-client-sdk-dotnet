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
    /// Incoming Message request
    /// </summary>
    [DataContract]
    public partial class IncomingMessageRequest :  IEquatable<IncomingMessageRequest>
    {
        /// <summary>
        /// Type of messaging platform being used
        /// </summary>
        /// <value>Type of messaging platform being used</value>
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
            /// Enum Apple for "Apple"
            /// </summary>
            [EnumMember(Value = "Apple")]
            Apple,
            
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
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Instagram for "Instagram"
            /// </summary>
            [EnumMember(Value = "Instagram")]
            Instagram,
            
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
        /// Gets or Sets Channels
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ChannelsEnum
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
        /// Type of messaging platform being used
        /// </summary>
        /// <value>Type of messaging platform being used</value>
        [DataMember(Name="messagingPlatformType", EmitDefaultValue=false)]
        public MessagingPlatformTypeEnum? MessagingPlatformType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IncomingMessageRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IncomingMessageRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomingMessageRequest" /> class.
        /// </summary>
        /// <param name="BotId">The unique id of the bot. (required).</param>
        /// <param name="BotName">Name of the bot (required).</param>
        /// <param name="BotVersion">The version of the bot. (required).</param>
        /// <param name="IntegrationId">The Integration Id for the bot&#39;s configuration (required).</param>
        /// <param name="BotSessionId">The id of the session. This id will be used for an entire conversation with the bot (a series of back and forth between the bot until the bot has fulfilled its intent). (required).</param>
        /// <param name="AutomateFlowExecId">Execution ID of the Automate Flow. (required).</param>
        /// <param name="ConversationId">Genesys conversation ID. (required).</param>
        /// <param name="LanguageCode">Language code for the conversation (e.g., &#39;en-US&#39;). (required).</param>
        /// <param name="InputMessage">Message received from the user to send to the bot (required).</param>
        /// <param name="MessagingPlatformType">Type of messaging platform being used (required).</param>
        /// <param name="Channels">The channels this bot is utilizing. (required).</param>
        /// <param name="BotSessionTimeout">Timeout duration for bot session in minutes..</param>
        /// <param name="Parameters">This is a map of string-string key, value pairs containing optional fields that can be passed to the bot for custom behavior, tracking, etc..</param>
        public IncomingMessageRequest(string BotId = null, string BotName = null, string BotVersion = null, string IntegrationId = null, string BotSessionId = null, string AutomateFlowExecId = null, string ConversationId = null, string LanguageCode = null, InputMessage InputMessage = null, MessagingPlatformTypeEnum? MessagingPlatformType = null, List<ChannelsEnum> Channels = null, int? BotSessionTimeout = null, Dictionary<string, string> Parameters = null)
        {
            this.BotId = BotId;
            this.BotName = BotName;
            this.BotVersion = BotVersion;
            this.IntegrationId = IntegrationId;
            this.BotSessionId = BotSessionId;
            this.AutomateFlowExecId = AutomateFlowExecId;
            this.ConversationId = ConversationId;
            this.LanguageCode = LanguageCode;
            this.InputMessage = InputMessage;
            this.MessagingPlatformType = MessagingPlatformType;
            this.Channels = Channels;
            this.BotSessionTimeout = BotSessionTimeout;
            this.Parameters = Parameters;
            
        }
        


        /// <summary>
        /// The unique id of the bot.
        /// </summary>
        /// <value>The unique id of the bot.</value>
        [DataMember(Name="botId", EmitDefaultValue=false)]
        public string BotId { get; set; }



        /// <summary>
        /// Name of the bot
        /// </summary>
        /// <value>Name of the bot</value>
        [DataMember(Name="botName", EmitDefaultValue=false)]
        public string BotName { get; set; }



        /// <summary>
        /// The version of the bot.
        /// </summary>
        /// <value>The version of the bot.</value>
        [DataMember(Name="botVersion", EmitDefaultValue=false)]
        public string BotVersion { get; set; }



        /// <summary>
        /// The Integration Id for the bot&#39;s configuration
        /// </summary>
        /// <value>The Integration Id for the bot&#39;s configuration</value>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public string IntegrationId { get; set; }



        /// <summary>
        /// The id of the session. This id will be used for an entire conversation with the bot (a series of back and forth between the bot until the bot has fulfilled its intent).
        /// </summary>
        /// <value>The id of the session. This id will be used for an entire conversation with the bot (a series of back and forth between the bot until the bot has fulfilled its intent).</value>
        [DataMember(Name="botSessionId", EmitDefaultValue=false)]
        public string BotSessionId { get; set; }



        /// <summary>
        /// Execution ID of the Automate Flow.
        /// </summary>
        /// <value>Execution ID of the Automate Flow.</value>
        [DataMember(Name="automateFlowExecId", EmitDefaultValue=false)]
        public string AutomateFlowExecId { get; set; }



        /// <summary>
        /// Genesys conversation ID.
        /// </summary>
        /// <value>Genesys conversation ID.</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// Language code for the conversation (e.g., &#39;en-US&#39;).
        /// </summary>
        /// <value>Language code for the conversation (e.g., &#39;en-US&#39;).</value>
        [DataMember(Name="languageCode", EmitDefaultValue=false)]
        public string LanguageCode { get; set; }



        /// <summary>
        /// Message received from the user to send to the bot
        /// </summary>
        /// <value>Message received from the user to send to the bot</value>
        [DataMember(Name="inputMessage", EmitDefaultValue=false)]
        public InputMessage InputMessage { get; set; }





        /// <summary>
        /// The channels this bot is utilizing.
        /// </summary>
        /// <value>The channels this bot is utilizing.</value>
        [DataMember(Name="channels", EmitDefaultValue=false)]
        public List<ChannelsEnum> Channels { get; set; }



        /// <summary>
        /// Timeout duration for bot session in minutes.
        /// </summary>
        /// <value>Timeout duration for bot session in minutes.</value>
        [DataMember(Name="botSessionTimeout", EmitDefaultValue=false)]
        public int? BotSessionTimeout { get; set; }



        /// <summary>
        /// This is a map of string-string key, value pairs containing optional fields that can be passed to the bot for custom behavior, tracking, etc.
        /// </summary>
        /// <value>This is a map of string-string key, value pairs containing optional fields that can be passed to the bot for custom behavior, tracking, etc.</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public Dictionary<string, string> Parameters { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IncomingMessageRequest {\n");

            sb.Append("  BotId: ").Append(BotId).Append("\n");
            sb.Append("  BotName: ").Append(BotName).Append("\n");
            sb.Append("  BotVersion: ").Append(BotVersion).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
            sb.Append("  BotSessionId: ").Append(BotSessionId).Append("\n");
            sb.Append("  AutomateFlowExecId: ").Append(AutomateFlowExecId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  InputMessage: ").Append(InputMessage).Append("\n");
            sb.Append("  MessagingPlatformType: ").Append(MessagingPlatformType).Append("\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
            sb.Append("  BotSessionTimeout: ").Append(BotSessionTimeout).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return this.Equals(obj as IncomingMessageRequest);
        }

        /// <summary>
        /// Returns true if IncomingMessageRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of IncomingMessageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncomingMessageRequest other)
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
                    this.BotName == other.BotName ||
                    this.BotName != null &&
                    this.BotName.Equals(other.BotName)
                ) &&
                (
                    this.BotVersion == other.BotVersion ||
                    this.BotVersion != null &&
                    this.BotVersion.Equals(other.BotVersion)
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
                    this.AutomateFlowExecId == other.AutomateFlowExecId ||
                    this.AutomateFlowExecId != null &&
                    this.AutomateFlowExecId.Equals(other.AutomateFlowExecId)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.LanguageCode == other.LanguageCode ||
                    this.LanguageCode != null &&
                    this.LanguageCode.Equals(other.LanguageCode)
                ) &&
                (
                    this.InputMessage == other.InputMessage ||
                    this.InputMessage != null &&
                    this.InputMessage.Equals(other.InputMessage)
                ) &&
                (
                    this.MessagingPlatformType == other.MessagingPlatformType ||
                    this.MessagingPlatformType != null &&
                    this.MessagingPlatformType.Equals(other.MessagingPlatformType)
                ) &&
                (
                    this.Channels == other.Channels ||
                    this.Channels != null &&
                    this.Channels.SequenceEqual(other.Channels)
                ) &&
                (
                    this.BotSessionTimeout == other.BotSessionTimeout ||
                    this.BotSessionTimeout != null &&
                    this.BotSessionTimeout.Equals(other.BotSessionTimeout)
                ) &&
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
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

                if (this.BotName != null)
                    hash = hash * 59 + this.BotName.GetHashCode();

                if (this.BotVersion != null)
                    hash = hash * 59 + this.BotVersion.GetHashCode();

                if (this.IntegrationId != null)
                    hash = hash * 59 + this.IntegrationId.GetHashCode();

                if (this.BotSessionId != null)
                    hash = hash * 59 + this.BotSessionId.GetHashCode();

                if (this.AutomateFlowExecId != null)
                    hash = hash * 59 + this.AutomateFlowExecId.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.LanguageCode != null)
                    hash = hash * 59 + this.LanguageCode.GetHashCode();

                if (this.InputMessage != null)
                    hash = hash * 59 + this.InputMessage.GetHashCode();

                if (this.MessagingPlatformType != null)
                    hash = hash * 59 + this.MessagingPlatformType.GetHashCode();

                if (this.Channels != null)
                    hash = hash * 59 + this.Channels.GetHashCode();

                if (this.BotSessionTimeout != null)
                    hash = hash * 59 + this.BotSessionTimeout.GetHashCode();

                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();

                return hash;
            }
        }
    }

}
