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
    /// PostTextMessage
    /// </summary>
    [DataContract]
    public partial class PostTextMessage :  IEquatable<PostTextMessage>
    {
        /// <summary>
        /// Message type
        /// </summary>
        /// <value>Message type</value>
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
            Receipt
        }
        /// <summary>
        /// Message type
        /// </summary>
        /// <value>Message type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTextMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostTextMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostTextMessage" /> class.
        /// </summary>
        /// <param name="Type">Message type (required).</param>
        /// <param name="Text">Message text. If type is structured, used as fallback for clients that do not support particular structured content.</param>
        /// <param name="Content">A list of content elements in message.</param>
        public PostTextMessage(TypeEnum? Type = null, string Text = null, List<MessageContent> Content = null)
        {
            this.Type = Type;
            this.Text = Text;
            this.Content = Content;
            
        }
        




        /// <summary>
        /// Message text. If type is structured, used as fallback for clients that do not support particular structured content
        /// </summary>
        /// <value>Message text. If type is structured, used as fallback for clients that do not support particular structured content</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// A list of content elements in message
        /// </summary>
        /// <value>A list of content elements in message</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public List<MessageContent> Content { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostTextMessage {\n");

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
            return this.Equals(obj as PostTextMessage);
        }

        /// <summary>
        /// Returns true if PostTextMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of PostTextMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostTextMessage other)
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
