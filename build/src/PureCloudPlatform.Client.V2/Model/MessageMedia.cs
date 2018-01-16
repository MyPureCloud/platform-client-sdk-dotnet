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
    /// MessageMedia
    /// </summary>
    [DataContract]
    public partial class MessageMedia :  IEquatable<MessageMedia>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageMedia" /> class.
        /// </summary>
        
        
        /// <param name="Url">The location of the media, useful for retrieving it.</param>
        
        
        
        /// <param name="MediaType">The optional internet media type of the the media object.  If null then the media type should be dictated by the url.</param>
        
        
        public MessageMedia(string Url = null, string MediaType = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Url = Url;
            
            
            
            
            
            
            
            
this.MediaType = MediaType;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The location of the media, useful for retrieving it
        /// </summary>
        /// <value>The location of the media, useful for retrieving it</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        
        
        
        /// <summary>
        /// The optional internet media type of the the media object.  If null then the media type should be dictated by the url
        /// </summary>
        /// <value>The optional internet media type of the the media object.  If null then the media type should be dictated by the url</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public string MediaType { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageMedia {\n");
            
            sb.Append("  Url: ").Append(Url).Append("\n");
            
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            
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
            return this.Equals(obj as MessageMedia);
        }

        /// <summary>
        /// Returns true if MessageMedia instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageMedia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageMedia other)
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
                
                return hash;
            }
        }
    }

}
