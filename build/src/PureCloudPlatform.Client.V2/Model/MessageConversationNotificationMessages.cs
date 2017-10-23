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
    /// MessageConversationNotificationMessages
    /// </summary>
    [DataContract]
    public partial class MessageConversationNotificationMessages :  IEquatable<MessageConversationNotificationMessages>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageConversationNotificationMessages" /> class.
        /// </summary>
        
        
        /// <param name="Message">Message.</param>
        
        
        
        /// <param name="MessageTime">MessageTime.</param>
        
        
        public MessageConversationNotificationMessages(MessageConversationNotificationUriReference Message = null, DateTime? MessageTime = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Message = Message;
            
            
            
            
            
            
            
            
this.MessageTime = MessageTime;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public MessageConversationNotificationUriReference Message { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MessageTime
        /// </summary>
        [DataMember(Name="messageTime", EmitDefaultValue=false)]
        public DateTime? MessageTime { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageConversationNotificationMessages {\n");
            
            sb.Append("  Message: ").Append(Message).Append("\n");
            
            sb.Append("  MessageTime: ").Append(MessageTime).Append("\n");
            
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
            return this.Equals(obj as MessageConversationNotificationMessages);
        }

        /// <summary>
        /// Returns true if MessageConversationNotificationMessages instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageConversationNotificationMessages to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageConversationNotificationMessages other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.MessageTime == other.MessageTime ||
                    this.MessageTime != null &&
                    this.MessageTime.Equals(other.MessageTime)
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
                
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                
                if (this.MessageTime != null)
                    hash = hash * 59 + this.MessageTime.GetHashCode();
                
                return hash;
            }
        }
    }

}
