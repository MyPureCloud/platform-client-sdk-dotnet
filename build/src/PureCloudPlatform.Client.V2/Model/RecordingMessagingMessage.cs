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
    /// RecordingMessagingMessage
    /// </summary>
    [DataContract]
    public partial class RecordingMessagingMessage :  IEquatable<RecordingMessagingMessage>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingMessagingMessage" /> class.
        /// </summary>
        /// <param name="From">From.</param>
        /// <param name="FromUser">FromUser.</param>
        /// <param name="FromExternalContact">FromExternalContact.</param>
        /// <param name="To">To.</param>
        /// <param name="Timestamp">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Id">Id.</param>
        /// <param name="MessageText">MessageText.</param>
        public RecordingMessagingMessage(string From = null, User FromUser = null, ExternalContact FromExternalContact = null, string To = null, DateTime? Timestamp = null, string Id = null, string MessageText = null)
        {
            this.From = From;
            this.FromUser = FromUser;
            this.FromExternalContact = FromExternalContact;
            this.To = To;
            this.Timestamp = Timestamp;
            this.Id = Id;
            this.MessageText = MessageText;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets FromUser
        /// </summary>
        [DataMember(Name="fromUser", EmitDefaultValue=false)]
        public User FromUser { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets FromExternalContact
        /// </summary>
        [DataMember(Name="fromExternalContact", EmitDefaultValue=false)]
        public ExternalContact FromExternalContact { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MessageText
        /// </summary>
        [DataMember(Name="messageText", EmitDefaultValue=false)]
        public string MessageText { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingMessagingMessage {\n");
            
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  FromUser: ").Append(FromUser).Append("\n");
            sb.Append("  FromExternalContact: ").Append(FromExternalContact).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MessageText: ").Append(MessageText).Append("\n");
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
            return this.Equals(obj as RecordingMessagingMessage);
        }

        /// <summary>
        /// Returns true if RecordingMessagingMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingMessagingMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingMessagingMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) &&
                (
                    this.FromUser == other.FromUser ||
                    this.FromUser != null &&
                    this.FromUser.Equals(other.FromUser)
                ) &&
                (
                    this.FromExternalContact == other.FromExternalContact ||
                    this.FromExternalContact != null &&
                    this.FromExternalContact.Equals(other.FromExternalContact)
                ) &&
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) &&
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.MessageText == other.MessageText ||
                    this.MessageText != null &&
                    this.MessageText.Equals(other.MessageText)
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
                
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                
                if (this.FromUser != null)
                    hash = hash * 59 + this.FromUser.GetHashCode();
                
                if (this.FromExternalContact != null)
                    hash = hash * 59 + this.FromExternalContact.GetHashCode();
                
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();
                
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.MessageText != null)
                    hash = hash * 59 + this.MessageText.GetHashCode();
                
                return hash;
            }
        }
    }

}
