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
    /// MessageMediaAttachment
    /// </summary>
    [DataContract]
    public partial class MessageMediaAttachment :  IEquatable<MessageMediaAttachment>
    {
        
        
        
        
        
        /// <summary>
        /// The optional internet media type of the the media object.If null then the media type should be dictated by the url.
        /// </summary>
        /// <value>The optional internet media type of the the media object.If null then the media type should be dictated by the url.</value>
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
            /// Enum Imagepng for "image/png"
            /// </summary>
            [EnumMember(Value = "image/png")]
            Imagepng,
            
            /// <summary>
            /// Enum Imagejpeg for "image/jpeg"
            /// </summary>
            [EnumMember(Value = "image/jpeg")]
            Imagejpeg,
            
            /// <summary>
            /// Enum Imagegif for "image/gif"
            /// </summary>
            [EnumMember(Value = "image/gif")]
            Imagegif
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The optional internet media type of the the media object.If null then the media type should be dictated by the url.
        /// </summary>
        /// <value>The optional internet media type of the the media object.If null then the media type should be dictated by the url.</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageMediaAttachment" /> class.
        /// </summary>
        /// <param name="Url">The location of the media, useful for retrieving it.</param>
        /// <param name="MediaType">The optional internet media type of the the media object.If null then the media type should be dictated by the url..</param>
        /// <param name="ContentLength">The optional content length of the the media object, in bytes..</param>
        /// <param name="Name">The name of the media object..</param>
        /// <param name="Id">A globally unique identifier for the media object..</param>
        public MessageMediaAttachment(string Url = null, MediaTypeEnum? MediaType = null, long? ContentLength = null, string Name = null, string Id = null)
        {
            this.Url = Url;
            this.MediaType = MediaType;
            this.ContentLength = ContentLength;
            this.Name = Name;
            this.Id = Id;
            
        }
        
        
        
        /// <summary>
        /// The location of the media, useful for retrieving it
        /// </summary>
        /// <value>The location of the media, useful for retrieving it</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        
        
        
        
        
        /// <summary>
        /// The optional content length of the the media object, in bytes.
        /// </summary>
        /// <value>The optional content length of the the media object, in bytes.</value>
        [DataMember(Name="contentLength", EmitDefaultValue=false)]
        public long? ContentLength { get; set; }
        
        
        
        /// <summary>
        /// The name of the media object.
        /// </summary>
        /// <value>The name of the media object.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// A globally unique identifier for the media object.
        /// </summary>
        /// <value>A globally unique identifier for the media object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageMediaAttachment {\n");
            
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as MessageMediaAttachment);
        }

        /// <summary>
        /// Returns true if MessageMediaAttachment instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageMediaAttachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageMediaAttachment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.ContentLength == other.ContentLength ||
                    this.ContentLength != null &&
                    this.ContentLength.Equals(other.ContentLength)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                
                if (this.ContentLength != null)
                    hash = hash * 59 + this.ContentLength.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                return hash;
            }
        }
    }

}
