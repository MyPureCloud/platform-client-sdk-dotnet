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
    /// InputMessage
    /// </summary>
    [DataContract]
    public partial class InputMessage :  IEquatable<InputMessage>
    {
        /// <summary>
        /// Message type.
        /// </summary>
        /// <value>Message type.</value>
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
            /// Enum Text for "Text"
            /// </summary>
            [EnumMember(Value = "Text")]
            Text,
            
            /// <summary>
            /// Enum Structured for "Structured"
            /// </summary>
            [EnumMember(Value = "Structured")]
            Structured,
            
            /// <summary>
            /// Enum Receipt for "Receipt"
            /// </summary>
            [EnumMember(Value = "Receipt")]
            Receipt,
            
            /// <summary>
            /// Enum Event for "Event"
            /// </summary>
            [EnumMember(Value = "Event")]
            Event,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Message type.
        /// </summary>
        /// <value>Message type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InputMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessage" /> class.
        /// </summary>
        /// <param name="Type">Message type. (required).</param>
        /// <param name="Text">The text of the message being sent to the bot..</param>
        /// <param name="Content">A list of content elements in the message..</param>
        public InputMessage(TypeEnum? Type = null, string Text = null, List<ConversationMessageContent> Content = null)
        {
            this.Type = Type;
            this.Text = Text;
            this.Content = Content;
            
        }
        




        /// <summary>
        /// The text of the message being sent to the bot.
        /// </summary>
        /// <value>The text of the message being sent to the bot.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// A list of content elements in the message.
        /// </summary>
        /// <value>A list of content elements in the message.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public List<ConversationMessageContent> Content { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputMessage {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(obj as InputMessage);
        }

        /// <summary>
        /// Returns true if InputMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of InputMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputMessage other)
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
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.SequenceEqual(other.Content)
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

                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();

                return hash;
            }
        }
    }

}
