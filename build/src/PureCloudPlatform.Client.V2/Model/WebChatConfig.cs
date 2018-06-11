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
    /// WebChatConfig
    /// </summary>
    [DataContract]
    public partial class WebChatConfig :  IEquatable<WebChatConfig>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebChatConfig" /> class.
        /// </summary>
        
        
        /// <param name="WebChatSkin">css class to be applied to the web chat widget..</param>
        
        
        public WebChatConfig(string WebChatSkin = null)
        {
            
            
            
            
            
            
            
            
            
            
this.WebChatSkin = WebChatSkin;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// css class to be applied to the web chat widget.
        /// </summary>
        /// <value>css class to be applied to the web chat widget.</value>
        [DataMember(Name="webChatSkin", EmitDefaultValue=false)]
        public string WebChatSkin { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebChatConfig {\n");
            
            sb.Append("  WebChatSkin: ").Append(WebChatSkin).Append("\n");
            
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
            return this.Equals(obj as WebChatConfig);
        }

        /// <summary>
        /// Returns true if WebChatConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of WebChatConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebChatConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WebChatSkin == other.WebChatSkin ||
                    this.WebChatSkin != null &&
                    this.WebChatSkin.Equals(other.WebChatSkin)
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
                
                if (this.WebChatSkin != null)
                    hash = hash * 59 + this.WebChatSkin.GetHashCode();
                
                return hash;
            }
        }
    }

}
