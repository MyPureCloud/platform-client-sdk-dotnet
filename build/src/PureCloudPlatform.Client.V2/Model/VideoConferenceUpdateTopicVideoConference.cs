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
    /// VideoConferenceUpdateTopicVideoConference
    /// </summary>
    [DataContract]
    public partial class VideoConferenceUpdateTopicVideoConference :  IEquatable<VideoConferenceUpdateTopicVideoConference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoConferenceUpdateTopicVideoConference" /> class.
        /// </summary>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="ConferenceId">ConferenceId.</param>
        /// <param name="ParticipantInfo">ParticipantInfo.</param>
        public VideoConferenceUpdateTopicVideoConference(Guid? ConversationId = null, string ConferenceId = null, VideoConferenceUpdateTopicParticipantInfo ParticipantInfo = null)
        {
            this.ConversationId = ConversationId;
            this.ConferenceId = ConferenceId;
            this.ParticipantInfo = ParticipantInfo;
            
        }
        


        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public Guid? ConversationId { get; set; }



        /// <summary>
        /// Gets or Sets ConferenceId
        /// </summary>
        [DataMember(Name="conferenceId", EmitDefaultValue=false)]
        public string ConferenceId { get; set; }



        /// <summary>
        /// Gets or Sets ParticipantInfo
        /// </summary>
        [DataMember(Name="participantInfo", EmitDefaultValue=false)]
        public VideoConferenceUpdateTopicParticipantInfo ParticipantInfo { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoConferenceUpdateTopicVideoConference {\n");

            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  ConferenceId: ").Append(ConferenceId).Append("\n");
            sb.Append("  ParticipantInfo: ").Append(ParticipantInfo).Append("\n");
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
            return this.Equals(obj as VideoConferenceUpdateTopicVideoConference);
        }

        /// <summary>
        /// Returns true if VideoConferenceUpdateTopicVideoConference instances are equal
        /// </summary>
        /// <param name="other">Instance of VideoConferenceUpdateTopicVideoConference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoConferenceUpdateTopicVideoConference other)
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
                    this.ConferenceId == other.ConferenceId ||
                    this.ConferenceId != null &&
                    this.ConferenceId.Equals(other.ConferenceId)
                ) &&
                (
                    this.ParticipantInfo == other.ParticipantInfo ||
                    this.ParticipantInfo != null &&
                    this.ParticipantInfo.Equals(other.ParticipantInfo)
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

                if (this.ConferenceId != null)
                    hash = hash * 59 + this.ConferenceId.GetHashCode();

                if (this.ParticipantInfo != null)
                    hash = hash * 59 + this.ParticipantInfo.GetHashCode();

                return hash;
            }
        }
    }

}
