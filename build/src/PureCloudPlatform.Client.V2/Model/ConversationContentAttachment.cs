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
    /// Attachment object.
    /// </summary>
    [DataContract]
    public partial class ConversationContentAttachment :  IEquatable<ConversationContentAttachment>
    {
        /// <summary>
        /// The type of attachment this instance represents.
        /// </summary>
        /// <value>The type of attachment this instance represents.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
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
            /// Enum Audio for "Audio"
            /// </summary>
            [EnumMember(Value = "Audio")]
            Audio,
            
            /// <summary>
            /// Enum File for "File"
            /// </summary>
            [EnumMember(Value = "File")]
            File,
            
            /// <summary>
            /// Enum Link for "Link"
            /// </summary>
            [EnumMember(Value = "Link")]
            Link
        }
        /// <summary>
        /// The type of attachment this instance represents.
        /// </summary>
        /// <value>The type of attachment this instance represents.</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentAttachment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationContentAttachment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentAttachment" /> class.
        /// </summary>
        /// <param name="Id">Provider specific ID for attachment. For example, a LINE sticker ID..</param>
        /// <param name="MediaType">The type of attachment this instance represents. (required).</param>
        /// <param name="Url">URL of the attachment..</param>
        /// <param name="Mime">Attachment mime type (https://www.iana.org/assignments/media-types/media-types.xhtml)..</param>
        /// <param name="Text">Text associated with attachment such as an image caption..</param>
        /// <param name="Sha256">Secure hash of the attachment content..</param>
        /// <param name="Filename">Suggested file name for attachment..</param>
        /// <param name="ContentSizeBytes">Size in bytes of the attachment content..</param>
        public ConversationContentAttachment(string Id = null, MediaTypeEnum? MediaType = null, string Url = null, string Mime = null, string Text = null, string Sha256 = null, string Filename = null, long? ContentSizeBytes = null)
        {
            this.Id = Id;
            this.MediaType = MediaType;
            this.Url = Url;
            this.Mime = Mime;
            this.Text = Text;
            this.Sha256 = Sha256;
            this.Filename = Filename;
            this.ContentSizeBytes = ContentSizeBytes;
            
        }
        


        /// <summary>
        /// Provider specific ID for attachment. For example, a LINE sticker ID.
        /// </summary>
        /// <value>Provider specific ID for attachment. For example, a LINE sticker ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }





        /// <summary>
        /// URL of the attachment.
        /// </summary>
        /// <value>URL of the attachment.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// Attachment mime type (https://www.iana.org/assignments/media-types/media-types.xhtml).
        /// </summary>
        /// <value>Attachment mime type (https://www.iana.org/assignments/media-types/media-types.xhtml).</value>
        [DataMember(Name="mime", EmitDefaultValue=false)]
        public string Mime { get; set; }



        /// <summary>
        /// Text associated with attachment such as an image caption.
        /// </summary>
        /// <value>Text associated with attachment such as an image caption.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// Secure hash of the attachment content.
        /// </summary>
        /// <value>Secure hash of the attachment content.</value>
        [DataMember(Name="sha256", EmitDefaultValue=false)]
        public string Sha256 { get; set; }



        /// <summary>
        /// Suggested file name for attachment.
        /// </summary>
        /// <value>Suggested file name for attachment.</value>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }



        /// <summary>
        /// Size in bytes of the attachment content.
        /// </summary>
        /// <value>Size in bytes of the attachment content.</value>
        [DataMember(Name="contentSizeBytes", EmitDefaultValue=false)]
        public long? ContentSizeBytes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationContentAttachment {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Mime: ").Append(Mime).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Sha256: ").Append(Sha256).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  ContentSizeBytes: ").Append(ContentSizeBytes).Append("\n");
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
            return this.Equals(obj as ConversationContentAttachment);
        }

        /// <summary>
        /// Returns true if ConversationContentAttachment instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationContentAttachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationContentAttachment other)
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
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.Mime == other.Mime ||
                    this.Mime != null &&
                    this.Mime.Equals(other.Mime)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Sha256 == other.Sha256 ||
                    this.Sha256 != null &&
                    this.Sha256.Equals(other.Sha256)
                ) &&
                (
                    this.Filename == other.Filename ||
                    this.Filename != null &&
                    this.Filename.Equals(other.Filename)
                ) &&
                (
                    this.ContentSizeBytes == other.ContentSizeBytes ||
                    this.ContentSizeBytes != null &&
                    this.ContentSizeBytes.Equals(other.ContentSizeBytes)
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

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.Mime != null)
                    hash = hash * 59 + this.Mime.GetHashCode();

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Sha256 != null)
                    hash = hash * 59 + this.Sha256.GetHashCode();

                if (this.Filename != null)
                    hash = hash * 59 + this.Filename.GetHashCode();

                if (this.ContentSizeBytes != null)
                    hash = hash * 59 + this.ContentSizeBytes.GetHashCode();

                return hash;
            }
        }
    }

}
