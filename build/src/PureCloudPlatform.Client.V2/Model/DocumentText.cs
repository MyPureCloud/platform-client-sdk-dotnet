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
    /// DocumentText
    /// </summary>
    [DataContract]
    public partial class DocumentText :  IEquatable<DocumentText>
    {
        /// <summary>
        /// Gets or Sets Marks
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MarksEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Bold for "Bold"
            /// </summary>
            [EnumMember(Value = "Bold")]
            Bold,
            
            /// <summary>
            /// Enum Italic for "Italic"
            /// </summary>
            [EnumMember(Value = "Italic")]
            Italic,
            
            /// <summary>
            /// Enum Underline for "Underline"
            /// </summary>
            [EnumMember(Value = "Underline")]
            Underline
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentText" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentText() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentText" /> class.
        /// </summary>
        /// <param name="Text">Text. (required).</param>
        /// <param name="Marks">The unique list of marks (whether it is bold and/or underlined etc.) for the text..</param>
        /// <param name="Hyperlink">The URL of the page that the hyperlink goes to..</param>
        public DocumentText(string Text = null, List<MarksEnum> Marks = null, string Hyperlink = null)
        {
            this.Text = Text;
            this.Marks = Marks;
            this.Hyperlink = Hyperlink;
            
        }
        


        /// <summary>
        /// Text.
        /// </summary>
        /// <value>Text.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// The unique list of marks (whether it is bold and/or underlined etc.) for the text.
        /// </summary>
        /// <value>The unique list of marks (whether it is bold and/or underlined etc.) for the text.</value>
        [DataMember(Name="marks", EmitDefaultValue=false)]
        public List<MarksEnum> Marks { get; set; }



        /// <summary>
        /// The URL of the page that the hyperlink goes to.
        /// </summary>
        /// <value>The URL of the page that the hyperlink goes to.</value>
        [DataMember(Name="hyperlink", EmitDefaultValue=false)]
        public string Hyperlink { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentText {\n");

            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Marks: ").Append(Marks).Append("\n");
            sb.Append("  Hyperlink: ").Append(Hyperlink).Append("\n");
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
            return this.Equals(obj as DocumentText);
        }

        /// <summary>
        /// Returns true if DocumentText instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentText to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentText other)
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
                    this.Marks == other.Marks ||
                    this.Marks != null &&
                    this.Marks.SequenceEqual(other.Marks)
                ) &&
                (
                    this.Hyperlink == other.Hyperlink ||
                    this.Hyperlink != null &&
                    this.Hyperlink.Equals(other.Hyperlink)
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

                if (this.Marks != null)
                    hash = hash * 59 + this.Marks.GetHashCode();

                if (this.Hyperlink != null)
                    hash = hash * 59 + this.Hyperlink.GetHashCode();

                return hash;
            }
        }
    }

}
