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
    /// CreateCallbackResponse
    /// </summary>
    [DataContract]
    public partial class CreateCallbackResponse :  IEquatable<CreateCallbackResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCallbackResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCallbackResponse() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCallbackResponse" /> class.
        /// </summary>
        /// <param name="Conversation">The conversation associated with the callback (required).</param>
        /// <param name="CallbackIdentifiers">The list of communication identifiers for the callback participants (required).</param>
        public CreateCallbackResponse(UriReference Conversation = null, List<CallbackIdentifier> CallbackIdentifiers = null)
        {
            
        }
        
        
        
        /// <summary>
        /// The conversation associated with the callback
        /// </summary>
        /// <value>The conversation associated with the callback</value>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public UriReference Conversation { get; set; }
        
        
        
        /// <summary>
        /// The list of communication identifiers for the callback participants
        /// </summary>
        /// <value>The list of communication identifiers for the callback participants</value>
        [DataMember(Name="callbackIdentifiers", EmitDefaultValue=false)]
        public List<CallbackIdentifier> CallbackIdentifiers { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCallbackResponse {\n");
            
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  CallbackIdentifiers: ").Append(CallbackIdentifiers).Append("\n");
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
            return this.Equals(obj as CreateCallbackResponse);
        }

        /// <summary>
        /// Returns true if CreateCallbackResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCallbackResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCallbackResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
                ) &&
                (
                    this.CallbackIdentifiers == other.CallbackIdentifiers ||
                    this.CallbackIdentifiers != null &&
                    this.CallbackIdentifiers.SequenceEqual(other.CallbackIdentifiers)
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
                
                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();
                
                if (this.CallbackIdentifiers != null)
                    hash = hash * 59 + this.CallbackIdentifiers.GetHashCode();
                
                return hash;
            }
        }
    }

}
