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
    /// ButtonResponse
    /// </summary>
    [DataContract]
    public partial class ButtonResponse :  IEquatable<ButtonResponse>
    {
        
        
        /// <summary>
        /// Button response type that captures Button and QuickReply type responses
        /// </summary>
        /// <value>Button response type that captures Button and QuickReply type responses</value>
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
            /// Enum Button for "Button"
            /// </summary>
            [EnumMember(Value = "Button")]
            Button,
            
            /// <summary>
            /// Enum Quickreply for "QuickReply"
            /// </summary>
            [EnumMember(Value = "QuickReply")]
            Quickreply
        }
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Button response message type that captures QuickReply , Cards and Carousel .This is used  as label for Card selection
        /// </summary>
        /// <value>Button response message type that captures QuickReply , Cards and Carousel .This is used  as label for Card selection</value>
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
            /// Enum Quickreply for "QuickReply"
            /// </summary>
            [EnumMember(Value = "QuickReply")]
            Quickreply,
            
            /// <summary>
            /// Enum Card for "Card"
            /// </summary>
            [EnumMember(Value = "Card")]
            Card,
            
            /// <summary>
            /// Enum Carousel for "Carousel"
            /// </summary>
            [EnumMember(Value = "Carousel")]
            Carousel
        }
        
        
        
        
        
        /// <summary>
        /// Button response type that captures Button and QuickReply type responses
        /// </summary>
        /// <value>Button response type that captures Button and QuickReply type responses</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Button response message type that captures QuickReply , Cards and Carousel .This is used  as label for Card selection
        /// </summary>
        /// <value>Button response message type that captures QuickReply , Cards and Carousel .This is used  as label for Card selection</value>
        [DataMember(Name="messageType", EmitDefaultValue=false)]
        public MessageTypeEnum? MessageType { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonResponse" /> class.
        /// </summary>
        /// <param name="Type">Button response type that captures Button and QuickReply type responses.</param>
        /// <param name="Text">Text to show inside the Button reply. This is also used as the response text after clicking on the Button..</param>
        /// <param name="Payload">Content of the textback payload after clicking a button.</param>
        /// <param name="MessageType">Button response message type that captures QuickReply , Cards and Carousel .This is used  as label for Card selection.</param>
        public ButtonResponse(TypeEnum? Type = null, string Text = null, string Payload = null, MessageTypeEnum? MessageType = null)
        {
            this.Type = Type;
            this.Text = Text;
            this.Payload = Payload;
            this.MessageType = MessageType;
            
        }
        
        
        
        
        
        /// <summary>
        /// Text to show inside the Button reply. This is also used as the response text after clicking on the Button.
        /// </summary>
        /// <value>Text to show inside the Button reply. This is also used as the response text after clicking on the Button.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        
        
        
        /// <summary>
        /// Content of the textback payload after clicking a button
        /// </summary>
        /// <value>Content of the textback payload after clicking a button</value>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public string Payload { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ButtonResponse {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
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
            return this.Equals(obj as ButtonResponse);
        }

        /// <summary>
        /// Returns true if ButtonResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ButtonResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ButtonResponse other)
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
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Payload == other.Payload ||
                    this.Payload != null &&
                    this.Payload.Equals(other.Payload)
                ) &&
                (
                    this.MessageType == other.MessageType ||
                    this.MessageType != null &&
                    this.MessageType.Equals(other.MessageType)
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
                
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                
                if (this.Payload != null)
                    hash = hash * 59 + this.Payload.GetHashCode();
                
                if (this.MessageType != null)
                    hash = hash * 59 + this.MessageType.GetHashCode();
                
                return hash;
            }
        }
    }

}
