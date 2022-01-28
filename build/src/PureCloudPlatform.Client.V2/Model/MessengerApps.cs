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
    /// The apps embedded in the messenger
    /// </summary>
    [DataContract]
    public partial class MessengerApps :  IEquatable<MessengerApps>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessengerApps" /> class.
        /// </summary>
        /// <param name="Conversations">The conversation settings that handles chats within the messenger.</param>
        /// <param name="Knowledge">The knowledge base config for messenger.</param>
        public MessengerApps(ConversationAppSettings Conversations = null, Knowledge Knowledge = null)
        {
            this.Conversations = Conversations;
            this.Knowledge = Knowledge;
            
        }
        
        
        
        /// <summary>
        /// The conversation settings that handles chats within the messenger
        /// </summary>
        /// <value>The conversation settings that handles chats within the messenger</value>
        [DataMember(Name="conversations", EmitDefaultValue=false)]
        public ConversationAppSettings Conversations { get; set; }
        
        
        
        /// <summary>
        /// The knowledge base config for messenger
        /// </summary>
        /// <value>The knowledge base config for messenger</value>
        [DataMember(Name="knowledge", EmitDefaultValue=false)]
        public Knowledge Knowledge { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessengerApps {\n");
            
            sb.Append("  Conversations: ").Append(Conversations).Append("\n");
            sb.Append("  Knowledge: ").Append(Knowledge).Append("\n");
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
            return this.Equals(obj as MessengerApps);
        }

        /// <summary>
        /// Returns true if MessengerApps instances are equal
        /// </summary>
        /// <param name="other">Instance of MessengerApps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessengerApps other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Conversations == other.Conversations ||
                    this.Conversations != null &&
                    this.Conversations.Equals(other.Conversations)
                ) &&
                (
                    this.Knowledge == other.Knowledge ||
                    this.Knowledge != null &&
                    this.Knowledge.Equals(other.Knowledge)
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
                
                if (this.Conversations != null)
                    hash = hash * 59 + this.Conversations.GetHashCode();
                
                if (this.Knowledge != null)
                    hash = hash * 59 + this.Knowledge.GetHashCode();
                
                return hash;
            }
        }
    }

}
