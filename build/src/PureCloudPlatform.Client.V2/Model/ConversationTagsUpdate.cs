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
    /// ConversationTagsUpdate
    /// </summary>
    [DataContract]
    public partial class ConversationTagsUpdate :  IEquatable<ConversationTagsUpdate>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTagsUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationTagsUpdate() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTagsUpdate" /> class.
        /// </summary>
        /// <param name="ExternalTag">The external tag associated with the conversation. (required).</param>
        public ConversationTagsUpdate(string ExternalTag = null)
        {
            this.ExternalTag = ExternalTag;
            
        }
        
        
        
        /// <summary>
        /// The external tag associated with the conversation.
        /// </summary>
        /// <value>The external tag associated with the conversation.</value>
        [DataMember(Name="externalTag", EmitDefaultValue=false)]
        public string ExternalTag { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationTagsUpdate {\n");
            
            sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
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
            return this.Equals(obj as ConversationTagsUpdate);
        }

        /// <summary>
        /// Returns true if ConversationTagsUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationTagsUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationTagsUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ExternalTag == other.ExternalTag ||
                    this.ExternalTag != null &&
                    this.ExternalTag.Equals(other.ExternalTag)
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
                
                if (this.ExternalTag != null)
                    hash = hash * 59 + this.ExternalTag.GetHashCode();
                
                return hash;
            }
        }
    }

}
