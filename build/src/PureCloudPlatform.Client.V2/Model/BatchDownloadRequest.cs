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
    /// BatchDownloadRequest
    /// </summary>
    [DataContract]
    public partial class BatchDownloadRequest :  IEquatable<BatchDownloadRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDownloadRequest" /> class.
        /// </summary>
        /// <param name="ConversationId">Conversation id requested.</param>
        /// <param name="RecordingId">Recording id requested, optional.  Leave null for all recordings on the conversation.</param>
        public BatchDownloadRequest(string ConversationId = null, string RecordingId = null)
        {
            this.ConversationId = ConversationId;
            this.RecordingId = RecordingId;
            
        }
        
        
        
        /// <summary>
        /// Conversation id requested
        /// </summary>
        /// <value>Conversation id requested</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }
        
        
        
        /// <summary>
        /// Recording id requested, optional.  Leave null for all recordings on the conversation
        /// </summary>
        /// <value>Recording id requested, optional.  Leave null for all recordings on the conversation</value>
        [DataMember(Name="recordingId", EmitDefaultValue=false)]
        public string RecordingId { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDownloadRequest {\n");
            
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
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
            return this.Equals(obj as BatchDownloadRequest);
        }

        /// <summary>
        /// Returns true if BatchDownloadRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchDownloadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchDownloadRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.RecordingId == other.RecordingId ||
                    this.RecordingId != null &&
                    this.RecordingId.Equals(other.RecordingId)
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
                
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();
                
                if (this.RecordingId != null)
                    hash = hash * 59 + this.RecordingId.GetHashCode();
                
                return hash;
            }
        }
    }

}
