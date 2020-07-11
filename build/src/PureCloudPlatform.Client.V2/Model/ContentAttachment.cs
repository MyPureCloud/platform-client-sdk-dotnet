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
    /// Attachment object
    /// </summary>
    [DataContract]
    public partial class ContentAttachment :  IEquatable<ContentAttachment>
    {
        
        
        
        
        
        /// <summary>
        /// The type of media this instance represents
        /// </summary>
        /// <value>The type of media this instance represents</value>
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
            File
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of media this instance represents
        /// </summary>
        /// <value>The type of media this instance represents</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentAttachment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContentAttachment() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentAttachment" /> class.
        /// </summary>
        /// <param name="Id">Vendor specific ID for media. For example, a LINE sticker ID.</param>
        /// <param name="MediaType">The type of media this instance represents (required).</param>
        /// <param name="Url">Content element url.</param>
        /// <param name="Mime">Content mime type from https://www.iana.org/assignments/media-types/media-types.xhtml.</param>
        /// <param name="Text">Text message associated with media element: e.g. caption in case of image..</param>
        /// <param name="Sha256">Secure hash of the media content.</param>
        /// <param name="Filename">Suggested file name for media file.</param>
        public ContentAttachment(string Id = null, MediaTypeEnum? MediaType = null, string Url = null, string Mime = null, string Text = null, string Sha256 = null, string Filename = null)
        {
            this.Id = Id;
            this.MediaType = MediaType;
            this.Url = Url;
            this.Mime = Mime;
            this.Text = Text;
            this.Sha256 = Sha256;
            this.Filename = Filename;
            
        }
        
        
        
        /// <summary>
        /// Vendor specific ID for media. For example, a LINE sticker ID
        /// </summary>
        /// <value>Vendor specific ID for media. For example, a LINE sticker ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        
        
        /// <summary>
        /// Content element url
        /// </summary>
        /// <value>Content element url</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        
        
        
        /// <summary>
        /// Content mime type from https://www.iana.org/assignments/media-types/media-types.xhtml
        /// </summary>
        /// <value>Content mime type from https://www.iana.org/assignments/media-types/media-types.xhtml</value>
        [DataMember(Name="mime", EmitDefaultValue=false)]
        public string Mime { get; set; }
        
        
        
        /// <summary>
        /// Text message associated with media element: e.g. caption in case of image.
        /// </summary>
        /// <value>Text message associated with media element: e.g. caption in case of image.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        
        
        
        /// <summary>
        /// Secure hash of the media content
        /// </summary>
        /// <value>Secure hash of the media content</value>
        [DataMember(Name="sha256", EmitDefaultValue=false)]
        public string Sha256 { get; set; }
        
        
        
        /// <summary>
        /// Suggested file name for media file
        /// </summary>
        /// <value>Suggested file name for media file</value>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentAttachment {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Mime: ").Append(Mime).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Sha256: ").Append(Sha256).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
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
            return this.Equals(obj as ContentAttachment);
        }

        /// <summary>
        /// Returns true if ContentAttachment instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentAttachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentAttachment other)
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
                
                return hash;
            }
        }
    }

}
