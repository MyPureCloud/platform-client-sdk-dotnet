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
    /// AdditionalMessage
    /// </summary>
    [DataContract]
    public partial class AdditionalMessage :  IEquatable<AdditionalMessage>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdditionalMessage() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalMessage" /> class.
        /// </summary>
        /// <param name="TextBody">The body of the text message. (required).</param>
        /// <param name="MediaIds">The media ids associated with the text message..</param>
        /// <param name="StickerIds">The sticker ids associated with the text message..</param>
        public AdditionalMessage(string TextBody = null, List<string> MediaIds = null, List<string> StickerIds = null)
        {
            this.TextBody = TextBody;
            this.MediaIds = MediaIds;
            this.StickerIds = StickerIds;
            
        }
        
        
        
        /// <summary>
        /// The body of the text message.
        /// </summary>
        /// <value>The body of the text message.</value>
        [DataMember(Name="textBody", EmitDefaultValue=false)]
        public string TextBody { get; set; }
        
        
        
        /// <summary>
        /// The media ids associated with the text message.
        /// </summary>
        /// <value>The media ids associated with the text message.</value>
        [DataMember(Name="mediaIds", EmitDefaultValue=false)]
        public List<string> MediaIds { get; set; }
        
        
        
        /// <summary>
        /// The sticker ids associated with the text message.
        /// </summary>
        /// <value>The sticker ids associated with the text message.</value>
        [DataMember(Name="stickerIds", EmitDefaultValue=false)]
        public List<string> StickerIds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalMessage {\n");
            
            sb.Append("  TextBody: ").Append(TextBody).Append("\n");
            sb.Append("  MediaIds: ").Append(MediaIds).Append("\n");
            sb.Append("  StickerIds: ").Append(StickerIds).Append("\n");
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
            return this.Equals(obj as AdditionalMessage);
        }

        /// <summary>
        /// Returns true if AdditionalMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of AdditionalMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TextBody == other.TextBody ||
                    this.TextBody != null &&
                    this.TextBody.Equals(other.TextBody)
                ) &&
                (
                    this.MediaIds == other.MediaIds ||
                    this.MediaIds != null &&
                    this.MediaIds.SequenceEqual(other.MediaIds)
                ) &&
                (
                    this.StickerIds == other.StickerIds ||
                    this.StickerIds != null &&
                    this.StickerIds.SequenceEqual(other.StickerIds)
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
                
                if (this.TextBody != null)
                    hash = hash * 59 + this.TextBody.GetHashCode();
                
                if (this.MediaIds != null)
                    hash = hash * 59 + this.MediaIds.GetHashCode();
                
                if (this.StickerIds != null)
                    hash = hash * 59 + this.StickerIds.GetHashCode();
                
                return hash;
            }
        }
    }

}
