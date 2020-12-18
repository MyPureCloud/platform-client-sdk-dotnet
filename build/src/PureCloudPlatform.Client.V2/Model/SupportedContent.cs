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
    /// Supported content for inbound and outbound messages
    /// </summary>
    [DataContract]
    public partial class SupportedContent :  IEquatable<SupportedContent>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedContent" /> class.
        /// </summary>
        /// <param name="MediaTypes">Defines the allowable media that may be accepted for an inbound message or to be sent in an outbound message. The following is an example of allowing all inbound media, and for outbound all images and only mpeg video: {   \&quot;mediaTypes\&quot;: {     \&quot;allow\&quot;: {       \&quot;inbound\&quot;: [{\&quot;type\&quot;: \&quot;*/*\&quot;}],       \&quot;outbound\&quot;: [{\&quot;type\&quot;: \&quot;image/*\&quot;}, {\&quot;type\&quot;: \&quot;video/mpeg\&quot;}]     }   } }.</param>
        public SupportedContent(MediaTypes MediaTypes = null)
        {
            this.MediaTypes = MediaTypes;
            
        }
        
        
        
        /// <summary>
        /// Defines the allowable media that may be accepted for an inbound message or to be sent in an outbound message. The following is an example of allowing all inbound media, and for outbound all images and only mpeg video: {   \&quot;mediaTypes\&quot;: {     \&quot;allow\&quot;: {       \&quot;inbound\&quot;: [{\&quot;type\&quot;: \&quot;*/*\&quot;}],       \&quot;outbound\&quot;: [{\&quot;type\&quot;: \&quot;image/*\&quot;}, {\&quot;type\&quot;: \&quot;video/mpeg\&quot;}]     }   } }
        /// </summary>
        /// <value>Defines the allowable media that may be accepted for an inbound message or to be sent in an outbound message. The following is an example of allowing all inbound media, and for outbound all images and only mpeg video: {   \&quot;mediaTypes\&quot;: {     \&quot;allow\&quot;: {       \&quot;inbound\&quot;: [{\&quot;type\&quot;: \&quot;*/*\&quot;}],       \&quot;outbound\&quot;: [{\&quot;type\&quot;: \&quot;image/*\&quot;}, {\&quot;type\&quot;: \&quot;video/mpeg\&quot;}]     }   } }</value>
        [DataMember(Name="mediaTypes", EmitDefaultValue=false)]
        public MediaTypes MediaTypes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportedContent {\n");
            
            sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
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
            return this.Equals(obj as SupportedContent);
        }

        /// <summary>
        /// Returns true if SupportedContent instances are equal
        /// </summary>
        /// <param name="other">Instance of SupportedContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportedContent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MediaTypes == other.MediaTypes ||
                    this.MediaTypes != null &&
                    this.MediaTypes.Equals(other.MediaTypes)
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
                
                if (this.MediaTypes != null)
                    hash = hash * 59 + this.MediaTypes.GetHashCode();
                
                return hash;
            }
        }
    }

}
