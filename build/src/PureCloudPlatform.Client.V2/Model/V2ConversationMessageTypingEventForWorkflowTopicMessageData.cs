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
    /// V2ConversationMessageTypingEventForWorkflowTopicMessageData
    /// </summary>
    [DataContract]
    public partial class V2ConversationMessageTypingEventForWorkflowTopicMessageData :  IEquatable<V2ConversationMessageTypingEventForWorkflowTopicMessageData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2ConversationMessageTypingEventForWorkflowTopicMessageData" /> class.
        /// </summary>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="NormalizedMessage">NormalizedMessage.</param>
        public V2ConversationMessageTypingEventForWorkflowTopicMessageData(string ConversationId = null, V2ConversationMessageTypingEventForWorkflowTopicConversationNormalizedMessage NormalizedMessage = null)
        {
            this.ConversationId = ConversationId;
            this.NormalizedMessage = NormalizedMessage;
            
        }
        


        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// Gets or Sets NormalizedMessage
        /// </summary>
        [DataMember(Name="normalizedMessage", EmitDefaultValue=false)]
        public V2ConversationMessageTypingEventForWorkflowTopicConversationNormalizedMessage NormalizedMessage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2ConversationMessageTypingEventForWorkflowTopicMessageData {\n");

            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  NormalizedMessage: ").Append(NormalizedMessage).Append("\n");
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
            return this.Equals(obj as V2ConversationMessageTypingEventForWorkflowTopicMessageData);
        }

        /// <summary>
        /// Returns true if V2ConversationMessageTypingEventForWorkflowTopicMessageData instances are equal
        /// </summary>
        /// <param name="other">Instance of V2ConversationMessageTypingEventForWorkflowTopicMessageData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2ConversationMessageTypingEventForWorkflowTopicMessageData other)
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
                    this.NormalizedMessage == other.NormalizedMessage ||
                    this.NormalizedMessage != null &&
                    this.NormalizedMessage.Equals(other.NormalizedMessage)
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

                if (this.NormalizedMessage != null)
                    hash = hash * 59 + this.NormalizedMessage.GetHashCode();

                return hash;
            }
        }
    }

}
