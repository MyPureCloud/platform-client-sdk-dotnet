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
    /// TranscriptProperty
    /// </summary>
    [DataContract]
    public partial class TranscriptProperty :  IEquatable<TranscriptProperty>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptProperty" /> class.
        /// </summary>
        /// <param name="Url">The pre-signed S3 URL of the transcript.</param>
        /// <param name="Conversation">The conversation reference.</param>
        /// <param name="CommunicationId">The communication ID.</param>
        public TranscriptProperty(string Url = null, AddressableEntityRef Conversation = null, string CommunicationId = null)
        {
            this.Url = Url;
            this.Conversation = Conversation;
            this.CommunicationId = CommunicationId;
            
        }
        
        
        
        /// <summary>
        /// The pre-signed S3 URL of the transcript
        /// </summary>
        /// <value>The pre-signed S3 URL of the transcript</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        
        
        
        /// <summary>
        /// The conversation reference
        /// </summary>
        /// <value>The conversation reference</value>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public AddressableEntityRef Conversation { get; set; }
        
        
        
        /// <summary>
        /// The communication ID
        /// </summary>
        /// <value>The communication ID</value>
        [DataMember(Name="communicationId", EmitDefaultValue=false)]
        public string CommunicationId { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranscriptProperty {\n");
            
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
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
            return this.Equals(obj as TranscriptProperty);
        }

        /// <summary>
        /// Returns true if TranscriptProperty instances are equal
        /// </summary>
        /// <param name="other">Instance of TranscriptProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TranscriptProperty other)
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
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
                ) &&
                (
                    this.CommunicationId == other.CommunicationId ||
                    this.CommunicationId != null &&
                    this.CommunicationId.Equals(other.CommunicationId)
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
                
                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();
                
                if (this.CommunicationId != null)
                    hash = hash * 59 + this.CommunicationId.GetHashCode();
                
                return hash;
            }
        }
    }

}
