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
    /// MessagingConferResponse
    /// </summary>
    [DataContract]
    public partial class MessagingConferResponse :  IEquatable<MessagingConferResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingConferResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessagingConferResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingConferResponse" /> class.
        /// </summary>
        /// <param name="Conversation">conversation ID. (required).</param>
        /// <param name="CommunicationId">The internal communication ID. (required).</param>
        /// <param name="PeerCommunicationId">The peer internal communication ID. (required).</param>
        /// <param name="CommandId">Command ID for a given request. (required).</param>
        public MessagingConferResponse(AddressableEntityRef Conversation = null, string CommunicationId = null, string PeerCommunicationId = null, string CommandId = null)
        {
            this.Conversation = Conversation;
            this.CommunicationId = CommunicationId;
            this.PeerCommunicationId = PeerCommunicationId;
            this.CommandId = CommandId;
            
        }
        


        /// <summary>
        /// conversation ID.
        /// </summary>
        /// <value>conversation ID.</value>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public AddressableEntityRef Conversation { get; set; }



        /// <summary>
        /// The internal communication ID.
        /// </summary>
        /// <value>The internal communication ID.</value>
        [DataMember(Name="communicationId", EmitDefaultValue=false)]
        public string CommunicationId { get; set; }



        /// <summary>
        /// The peer internal communication ID.
        /// </summary>
        /// <value>The peer internal communication ID.</value>
        [DataMember(Name="peerCommunicationId", EmitDefaultValue=false)]
        public string PeerCommunicationId { get; set; }



        /// <summary>
        /// Command ID for a given request.
        /// </summary>
        /// <value>Command ID for a given request.</value>
        [DataMember(Name="commandId", EmitDefaultValue=false)]
        public string CommandId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagingConferResponse {\n");

            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
            sb.Append("  PeerCommunicationId: ").Append(PeerCommunicationId).Append("\n");
            sb.Append("  CommandId: ").Append(CommandId).Append("\n");
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
            return this.Equals(obj as MessagingConferResponse);
        }

        /// <summary>
        /// Returns true if MessagingConferResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of MessagingConferResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagingConferResponse other)
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
                    this.CommunicationId == other.CommunicationId ||
                    this.CommunicationId != null &&
                    this.CommunicationId.Equals(other.CommunicationId)
                ) &&
                (
                    this.PeerCommunicationId == other.PeerCommunicationId ||
                    this.PeerCommunicationId != null &&
                    this.PeerCommunicationId.Equals(other.PeerCommunicationId)
                ) &&
                (
                    this.CommandId == other.CommandId ||
                    this.CommandId != null &&
                    this.CommandId.Equals(other.CommandId)
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

                if (this.CommunicationId != null)
                    hash = hash * 59 + this.CommunicationId.GetHashCode();

                if (this.PeerCommunicationId != null)
                    hash = hash * 59 + this.PeerCommunicationId.GetHashCode();

                if (this.CommandId != null)
                    hash = hash * 59 + this.CommandId.GetHashCode();

                return hash;
            }
        }
    }

}
