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
    /// Data for a single bot flow prompt segment.
    /// </summary>
    [DataContract]
    public partial class TextBotPromptSegment :  IEquatable<TextBotPromptSegment>
    {
        /// <summary>
        /// The segment type which describes any semantics about the 'text' and also indicates which other field might include additional relevant info.
        /// </summary>
        /// <value>The segment type which describes any semantics about the 'text' and also indicates which other field might include additional relevant info.</value>
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
            /// Enum Richmedia for "RichMedia"
            /// </summary>
            [EnumMember(Value = "RichMedia")]
            Richmedia,
            
            /// <summary>
            /// Enum Messageevent for "MessageEvent"
            /// </summary>
            [EnumMember(Value = "MessageEvent")]
            Messageevent
        }
        /// <summary>
        /// The segment type which describes any semantics about the 'text' and also indicates which other field might include additional relevant info.
        /// </summary>
        /// <value>The segment type which describes any semantics about the 'text' and also indicates which other field might include additional relevant info.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBotPromptSegment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextBotPromptSegment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextBotPromptSegment" /> class.
        /// </summary>
        /// <param name="Text">The text of this prompt segment. (required).</param>
        /// <param name="Type">The segment type which describes any semantics about the 'text' and also indicates which other field might include additional relevant info. (required).</param>
        /// <param name="Format">Additional details describing the segment’s contents, which the client should honour where possible..</param>
        /// <param name="Content">Details to display Rich Media content. This is only populated when the segment 'type' is 'Rich Media'..</param>
        public TextBotPromptSegment(string Text = null, TypeEnum? Type = null, Format Format = null, List<MessageContent> Content = null)
        {
            this.Text = Text;
            this.Type = Type;
            this.Format = Format;
            this.Content = Content;
            
        }
        


        /// <summary>
        /// The text of this prompt segment.
        /// </summary>
        /// <value>The text of this prompt segment.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }





        /// <summary>
        /// Additional details describing the segment’s contents, which the client should honour where possible.
        /// </summary>
        /// <value>Additional details describing the segment’s contents, which the client should honour where possible.</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public Format Format { get; set; }



        /// <summary>
        /// Details to display Rich Media content. This is only populated when the segment 'type' is 'Rich Media'.
        /// </summary>
        /// <value>Details to display Rich Media content. This is only populated when the segment 'type' is 'Rich Media'.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public List<MessageContent> Content { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextBotPromptSegment {\n");

            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
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
            return this.Equals(obj as TextBotPromptSegment);
        }

        /// <summary>
        /// Returns true if TextBotPromptSegment instances are equal
        /// </summary>
        /// <param name="other">Instance of TextBotPromptSegment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextBotPromptSegment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
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
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();

                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();

                return hash;
            }
        }
    }

}
