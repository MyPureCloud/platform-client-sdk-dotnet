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
    /// DocumentTableContentBlock
    /// </summary>
    [DataContract]
    public partial class DocumentTableContentBlock :  IEquatable<DocumentTableContentBlock>
    {
        /// <summary>
        /// The type of the block for the table cell. This determines which body block object (paragraph, list, video, image or table) would have a value.
        /// </summary>
        /// <value>The type of the block for the table cell. This determines which body block object (paragraph, list, video, image or table) would have a value.</value>
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
            /// Enum Paragraph for "Paragraph"
            /// </summary>
            [EnumMember(Value = "Paragraph")]
            Paragraph,
            
            /// <summary>
            /// Enum Text for "Text"
            /// </summary>
            [EnumMember(Value = "Text")]
            Text,
            
            /// <summary>
            /// Enum Image for "Image"
            /// </summary>
            [EnumMember(Value = "Image")]
            Image,
            
            /// <summary>
            /// Enum Video for "Video"
            /// </summary>
            [EnumMember(Value = "Video")]
            Video,
            
            /// <summary>
            /// Enum Orderedlist for "OrderedList"
            /// </summary>
            [EnumMember(Value = "OrderedList")]
            Orderedlist,
            
            /// <summary>
            /// Enum Unorderedlist for "UnorderedList"
            /// </summary>
            [EnumMember(Value = "UnorderedList")]
            Unorderedlist,
            
            /// <summary>
            /// Enum Table for "Table"
            /// </summary>
            [EnumMember(Value = "Table")]
            Table
        }
        /// <summary>
        /// The type of the block for the table cell. This determines which body block object (paragraph, list, video, image or table) would have a value.
        /// </summary>
        /// <value>The type of the block for the table cell. This determines which body block object (paragraph, list, video, image or table) would have a value.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTableContentBlock" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentTableContentBlock() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTableContentBlock" /> class.
        /// </summary>
        /// <param name="Type">The type of the block for the table cell. This determines which body block object (paragraph, list, video, image or table) would have a value. (required).</param>
        /// <param name="Paragraph">Paragraph. It must contain a value if the type of the block is Paragraph..</param>
        /// <param name="Text">Text. It must contain a value if the type of the block is Text..</param>
        /// <param name="Image">Image. It must contain a value if the type of the block is Image..</param>
        /// <param name="Video">Video. It must contain a value if the type of the block is Video..</param>
        /// <param name="List">List. It must contain a value if the type of the block is UnorderedList or OrderedList..</param>
        /// <param name="Table">Table. It must contain a value if the type of the block is Table..</param>
        public DocumentTableContentBlock(TypeEnum? Type = null, DocumentBodyParagraph Paragraph = null, DocumentText Text = null, DocumentBodyImage Image = null, DocumentBodyVideo Video = null, DocumentBodyList List = null, DocumentBodyTable Table = null)
        {
            this.Type = Type;
            this.Paragraph = Paragraph;
            this.Text = Text;
            this.Image = Image;
            this.Video = Video;
            this.List = List;
            this.Table = Table;
            
        }
        




        /// <summary>
        /// Paragraph. It must contain a value if the type of the block is Paragraph.
        /// </summary>
        /// <value>Paragraph. It must contain a value if the type of the block is Paragraph.</value>
        [DataMember(Name="paragraph", EmitDefaultValue=false)]
        public DocumentBodyParagraph Paragraph { get; set; }



        /// <summary>
        /// Text. It must contain a value if the type of the block is Text.
        /// </summary>
        /// <value>Text. It must contain a value if the type of the block is Text.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public DocumentText Text { get; set; }



        /// <summary>
        /// Image. It must contain a value if the type of the block is Image.
        /// </summary>
        /// <value>Image. It must contain a value if the type of the block is Image.</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public DocumentBodyImage Image { get; set; }



        /// <summary>
        /// Video. It must contain a value if the type of the block is Video.
        /// </summary>
        /// <value>Video. It must contain a value if the type of the block is Video.</value>
        [DataMember(Name="video", EmitDefaultValue=false)]
        public DocumentBodyVideo Video { get; set; }



        /// <summary>
        /// List. It must contain a value if the type of the block is UnorderedList or OrderedList.
        /// </summary>
        /// <value>List. It must contain a value if the type of the block is UnorderedList or OrderedList.</value>
        [DataMember(Name="list", EmitDefaultValue=false)]
        public DocumentBodyList List { get; set; }



        /// <summary>
        /// Table. It must contain a value if the type of the block is Table.
        /// </summary>
        /// <value>Table. It must contain a value if the type of the block is Table.</value>
        [DataMember(Name="table", EmitDefaultValue=false)]
        public DocumentBodyTable Table { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentTableContentBlock {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Paragraph: ").Append(Paragraph).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
            sb.Append("  List: ").Append(List).Append("\n");
            sb.Append("  Table: ").Append(Table).Append("\n");
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
            return this.Equals(obj as DocumentTableContentBlock);
        }

        /// <summary>
        /// Returns true if DocumentTableContentBlock instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentTableContentBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentTableContentBlock other)
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
                    this.Paragraph == other.Paragraph ||
                    this.Paragraph != null &&
                    this.Paragraph.Equals(other.Paragraph)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
                ) &&
                (
                    this.Video == other.Video ||
                    this.Video != null &&
                    this.Video.Equals(other.Video)
                ) &&
                (
                    this.List == other.List ||
                    this.List != null &&
                    this.List.Equals(other.List)
                ) &&
                (
                    this.Table == other.Table ||
                    this.Table != null &&
                    this.Table.Equals(other.Table)
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

                if (this.Paragraph != null)
                    hash = hash * 59 + this.Paragraph.GetHashCode();

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();

                if (this.Video != null)
                    hash = hash * 59 + this.Video.GetHashCode();

                if (this.List != null)
                    hash = hash * 59 + this.List.GetHashCode();

                if (this.Table != null)
                    hash = hash * 59 + this.Table.GetHashCode();

                return hash;
            }
        }
    }

}
