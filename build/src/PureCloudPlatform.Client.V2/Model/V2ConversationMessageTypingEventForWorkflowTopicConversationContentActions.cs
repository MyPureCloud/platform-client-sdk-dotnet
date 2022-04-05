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
    /// V2ConversationMessageTypingEventForWorkflowTopicConversationContentActions
    /// </summary>
    [DataContract]
    public partial class V2ConversationMessageTypingEventForWorkflowTopicConversationContentActions :  IEquatable<V2ConversationMessageTypingEventForWorkflowTopicConversationContentActions>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="V2ConversationMessageTypingEventForWorkflowTopicConversationContentActions" /> class.
        /// </summary>
        /// <param name="Url">Url.</param>
        /// <param name="UrlTarget">UrlTarget.</param>
        /// <param name="Textback">Textback.</param>
        public V2ConversationMessageTypingEventForWorkflowTopicConversationContentActions(string Url = null, string UrlTarget = null, string Textback = null)
        {
            this.Url = Url;
            this.UrlTarget = UrlTarget;
            this.Textback = Textback;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets UrlTarget
        /// </summary>
        [DataMember(Name="urlTarget", EmitDefaultValue=false)]
        public string UrlTarget { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Textback
        /// </summary>
        [DataMember(Name="textback", EmitDefaultValue=false)]
        public string Textback { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2ConversationMessageTypingEventForWorkflowTopicConversationContentActions {\n");
            
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  UrlTarget: ").Append(UrlTarget).Append("\n");
            sb.Append("  Textback: ").Append(Textback).Append("\n");
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
            return this.Equals(obj as V2ConversationMessageTypingEventForWorkflowTopicConversationContentActions);
        }

        /// <summary>
        /// Returns true if V2ConversationMessageTypingEventForWorkflowTopicConversationContentActions instances are equal
        /// </summary>
        /// <param name="other">Instance of V2ConversationMessageTypingEventForWorkflowTopicConversationContentActions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2ConversationMessageTypingEventForWorkflowTopicConversationContentActions other)
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
                    this.UrlTarget == other.UrlTarget ||
                    this.UrlTarget != null &&
                    this.UrlTarget.Equals(other.UrlTarget)
                ) &&
                (
                    this.Textback == other.Textback ||
                    this.Textback != null &&
                    this.Textback.Equals(other.Textback)
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
                
                if (this.UrlTarget != null)
                    hash = hash * 59 + this.UrlTarget.GetHashCode();
                
                if (this.Textback != null)
                    hash = hash * 59 + this.Textback.GetHashCode();
                
                return hash;
            }
        }
    }

}
