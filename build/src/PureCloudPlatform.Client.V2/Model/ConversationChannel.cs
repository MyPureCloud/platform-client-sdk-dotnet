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
    /// ConversationChannel
    /// </summary>
    [DataContract]
    public partial class ConversationChannel :  IEquatable<ConversationChannel>
    {
        /// <summary>
        /// The type or category of this channel.
        /// </summary>
        /// <value>The type or category of this channel.</value>
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
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
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
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Genericobject for "GenericObject"
            /// </summary>
            [EnumMember(Value = "GenericObject")]
            Genericobject,
            
            /// <summary>
            /// Enum Messaging for "Messaging"
            /// </summary>
            [EnumMember(Value = "Messaging")]
            Messaging,
            
            /// <summary>
            /// Enum Social for "Social"
            /// </summary>
            [EnumMember(Value = "Social")]
            Social,
            
            /// <summary>
            /// Enum Webchat for "Webchat"
            /// </summary>
            [EnumMember(Value = "Webchat")]
            Webchat,
            
            /// <summary>
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice,
            
            /// <summary>
            /// Enum Chat for "Chat"
            /// </summary>
            [EnumMember(Value = "Chat")]
            Chat,
            
            /// <summary>
            /// Enum Cobrowse for "Cobrowse"
            /// </summary>
            [EnumMember(Value = "Cobrowse")]
            Cobrowse,
            
            /// <summary>
            /// Enum Video for "Video"
            /// </summary>
            [EnumMember(Value = "Video")]
            Video,
            
            /// <summary>
            /// Enum Screenshare for "Screenshare"
            /// </summary>
            [EnumMember(Value = "Screenshare")]
            Screenshare,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message
        }
        /// <summary>
        /// Message type for messaging conversations.
        /// </summary>
        /// <value>Message type for messaging conversations.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MessageTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Sms for "Sms"
            /// </summary>
            [EnumMember(Value = "Sms")]
            Sms,
            
            /// <summary>
            /// Enum Twitter for "Twitter"
            /// </summary>
            [EnumMember(Value = "Twitter")]
            Twitter,
            
            /// <summary>
            /// Enum Facebook for "Facebook"
            /// </summary>
            [EnumMember(Value = "Facebook")]
            Facebook,
            
            /// <summary>
            /// Enum Line for "Line"
            /// </summary>
            [EnumMember(Value = "Line")]
            Line,
            
            /// <summary>
            /// Enum Whatsapp for "WhatsApp"
            /// </summary>
            [EnumMember(Value = "WhatsApp")]
            Whatsapp,
            
            /// <summary>
            /// Enum Webmessaging for "WebMessaging"
            /// </summary>
            [EnumMember(Value = "WebMessaging")]
            Webmessaging,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Instagram for "Instagram"
            /// </summary>
            [EnumMember(Value = "Instagram")]
            Instagram
        }
        /// <summary>
        /// The type or category of this channel.
        /// </summary>
        /// <value>The type or category of this channel.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Message type for messaging conversations.
        /// </summary>
        /// <value>Message type for messaging conversations.</value>
        [DataMember(Name="messageType", EmitDefaultValue=false)]
        public MessageTypeEnum? MessageType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationChannel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationChannel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationChannel" /> class.
        /// </summary>
        /// <param name="Type">The type or category of this channel. (required).</param>
        /// <param name="MessageType">Message type for messaging conversations..</param>
        /// <param name="Platform">The source provider for the conversation (e.g. Edge, PureCloud Messaging, PureCloud Email)..</param>
        public ConversationChannel(TypeEnum? Type = null, MessageTypeEnum? MessageType = null, string Platform = null)
        {
            this.Type = Type;
            this.MessageType = MessageType;
            this.Platform = Platform;
            
        }
        






        /// <summary>
        /// The source provider for the conversation (e.g. Edge, PureCloud Messaging, PureCloud Email).
        /// </summary>
        /// <value>The source provider for the conversation (e.g. Edge, PureCloud Messaging, PureCloud Email).</value>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public string Platform { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationChannel {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
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
            return this.Equals(obj as ConversationChannel);
        }

        /// <summary>
        /// Returns true if ConversationChannel instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationChannel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.MessageType == other.MessageType ||
                    this.MessageType != null &&
                    this.MessageType.Equals(other.MessageType)
                ) &&
                (
                    this.Platform == other.Platform ||
                    this.Platform != null &&
                    this.Platform.Equals(other.Platform)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.MessageType != null)
                    hash = hash * 59 + this.MessageType.GetHashCode();

                if (this.Platform != null)
                    hash = hash * 59 + this.Platform.GetHashCode();

                return hash;
            }
        }
    }

}
