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
    /// CreateJoinVideoResponse
    /// </summary>
    [DataContract]
    public partial class CreateJoinVideoResponse :  IEquatable<CreateJoinVideoResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJoinVideoResponse" /> class.
        /// </summary>
        /// <param name="CommunicationId">The communication id for the video or modified by the command..</param>
        /// <param name="ConversationId">The conversation id for the conversation created or modified by the command..</param>
        /// <param name="JoinCode">The join code for the video conference. Only returned by the voice-to-video upgrade endpoint (POST /conversations/videos/{conversationId}/agentconference/communications/{communicationId}); not populated by POST /conversations/videos. Valid until the voice-to-video offer expires (default 5 minutes) or until used by a guest. One-time use..</param>
        public CreateJoinVideoResponse(string CommunicationId = null, string ConversationId = null, string JoinCode = null)
        {
            this.CommunicationId = CommunicationId;
            this.ConversationId = ConversationId;
            this.JoinCode = JoinCode;
            
        }
        


        /// <summary>
        /// The communication id for the video or modified by the command.
        /// </summary>
        /// <value>The communication id for the video or modified by the command.</value>
        [DataMember(Name="communicationId", EmitDefaultValue=false)]
        public string CommunicationId { get; set; }



        /// <summary>
        /// The conversation id for the conversation created or modified by the command.
        /// </summary>
        /// <value>The conversation id for the conversation created or modified by the command.</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// The join code for the video conference. Only returned by the voice-to-video upgrade endpoint (POST /conversations/videos/{conversationId}/agentconference/communications/{communicationId}); not populated by POST /conversations/videos. Valid until the voice-to-video offer expires (default 5 minutes) or until used by a guest. One-time use.
        /// </summary>
        /// <value>The join code for the video conference. Only returned by the voice-to-video upgrade endpoint (POST /conversations/videos/{conversationId}/agentconference/communications/{communicationId}); not populated by POST /conversations/videos. Valid until the voice-to-video offer expires (default 5 minutes) or until used by a guest. One-time use.</value>
        [DataMember(Name="joinCode", EmitDefaultValue=false)]
        public string JoinCode { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateJoinVideoResponse {\n");

            sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  JoinCode: ").Append(JoinCode).Append("\n");
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
            return this.Equals(obj as CreateJoinVideoResponse);
        }

        /// <summary>
        /// Returns true if CreateJoinVideoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateJoinVideoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateJoinVideoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CommunicationId == other.CommunicationId ||
                    this.CommunicationId != null &&
                    this.CommunicationId.Equals(other.CommunicationId)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.JoinCode == other.JoinCode ||
                    this.JoinCode != null &&
                    this.JoinCode.Equals(other.JoinCode)
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
                if (this.CommunicationId != null)
                    hash = hash * 59 + this.CommunicationId.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.JoinCode != null)
                    hash = hash * 59 + this.JoinCode.GetHashCode();

                return hash;
            }
        }
    }

}
