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
    /// MessageDetails
    /// </summary>
    [DataContract]
    public partial class MessageDetails :  IEquatable<MessageDetails>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDetails" /> class.
        /// </summary>
        
        
        /// <param name="MessageId">UUID identifying the message media..</param>
        
        
        
        /// <param name="MessageURI">A URI for this message entity..</param>
        
        
        
        /// <param name="MessageTime">The time when the message was sent or received. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        public MessageDetails(string MessageId = null, string MessageURI = null, DateTime? MessageTime = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.MessageId = MessageId;
            
            
            
            
            
            
            
            
this.MessageURI = MessageURI;
            
            
            
            
            
            
            
            
this.MessageTime = MessageTime;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// UUID identifying the message media.
        /// </summary>
        /// <value>UUID identifying the message media.</value>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; set; }
        
        
        
        /// <summary>
        /// A URI for this message entity.
        /// </summary>
        /// <value>A URI for this message entity.</value>
        [DataMember(Name="messageURI", EmitDefaultValue=false)]
        public string MessageURI { get; set; }
        
        
        
        /// <summary>
        /// The time when the message was sent or received. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time when the message was sent or received. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="messageTime", EmitDefaultValue=false)]
        public DateTime? MessageTime { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageDetails {\n");
            
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            
            sb.Append("  MessageURI: ").Append(MessageURI).Append("\n");
            
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
            return this.Equals(obj as MessageDetails);
        }

        /// <summary>
        /// Returns true if MessageDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MessageId == other.MessageId ||
                    this.MessageId != null &&
                    this.MessageId.Equals(other.MessageId)
                ) &&
                (
                    this.MessageURI == other.MessageURI ||
                    this.MessageURI != null &&
                    this.MessageURI.Equals(other.MessageURI)
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
                
                if (this.MessageId != null)
                    hash = hash * 59 + this.MessageId.GetHashCode();
                
                if (this.MessageURI != null)
                    hash = hash * 59 + this.MessageURI.GetHashCode();
                
                if (this.MessageTime != null)
                    hash = hash * 59 + this.MessageTime.GetHashCode();
                
                return hash;
            }
        }
    }

}
