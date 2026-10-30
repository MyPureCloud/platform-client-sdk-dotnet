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
    /// V2StaTopicsDetectedRealtimeTopicRealTimeTopicTag
    /// </summary>
    [DataContract]
    public partial class V2StaTopicsDetectedRealtimeTopicRealTimeTopicTag :  IEquatable<V2StaTopicsDetectedRealtimeTopicRealTimeTopicTag>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2StaTopicsDetectedRealtimeTopicRealTimeTopicTag" /> class.
        /// </summary>
        /// <param name="TopicId">TopicId.</param>
        /// <param name="TopicName">TopicName.</param>
        /// <param name="Participant">Participant.</param>
        /// <param name="TopicPhrase">TopicPhrase.</param>
        /// <param name="MatchedTranscript">MatchedTranscript.</param>
        /// <param name="Confidence">Confidence.</param>
        public V2StaTopicsDetectedRealtimeTopicRealTimeTopicTag(string TopicId = null, string TopicName = null, string Participant = null, string TopicPhrase = null, string MatchedTranscript = null, long? Confidence = null)
        {
            this.TopicId = TopicId;
            this.TopicName = TopicName;
            this.Participant = Participant;
            this.TopicPhrase = TopicPhrase;
            this.MatchedTranscript = MatchedTranscript;
            this.Confidence = Confidence;
            
        }
        


        /// <summary>
        /// Gets or Sets TopicId
        /// </summary>
        [DataMember(Name="topicId", EmitDefaultValue=false)]
        public string TopicId { get; set; }



        /// <summary>
        /// Gets or Sets TopicName
        /// </summary>
        [DataMember(Name="topicName", EmitDefaultValue=false)]
        public string TopicName { get; set; }



        /// <summary>
        /// Gets or Sets Participant
        /// </summary>
        [DataMember(Name="participant", EmitDefaultValue=false)]
        public string Participant { get; set; }



        /// <summary>
        /// Gets or Sets TopicPhrase
        /// </summary>
        [DataMember(Name="topicPhrase", EmitDefaultValue=false)]
        public string TopicPhrase { get; set; }



        /// <summary>
        /// Gets or Sets MatchedTranscript
        /// </summary>
        [DataMember(Name="matchedTranscript", EmitDefaultValue=false)]
        public string MatchedTranscript { get; set; }



        /// <summary>
        /// Gets or Sets Confidence
        /// </summary>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public long? Confidence { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2StaTopicsDetectedRealtimeTopicRealTimeTopicTag {\n");

            sb.Append("  TopicId: ").Append(TopicId).Append("\n");
            sb.Append("  TopicName: ").Append(TopicName).Append("\n");
            sb.Append("  Participant: ").Append(Participant).Append("\n");
            sb.Append("  TopicPhrase: ").Append(TopicPhrase).Append("\n");
            sb.Append("  MatchedTranscript: ").Append(MatchedTranscript).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
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
            return this.Equals(obj as V2StaTopicsDetectedRealtimeTopicRealTimeTopicTag);
        }

        /// <summary>
        /// Returns true if V2StaTopicsDetectedRealtimeTopicRealTimeTopicTag instances are equal
        /// </summary>
        /// <param name="other">Instance of V2StaTopicsDetectedRealtimeTopicRealTimeTopicTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2StaTopicsDetectedRealtimeTopicRealTimeTopicTag other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TopicId == other.TopicId ||
                    this.TopicId != null &&
                    this.TopicId.Equals(other.TopicId)
                ) &&
                (
                    this.TopicName == other.TopicName ||
                    this.TopicName != null &&
                    this.TopicName.Equals(other.TopicName)
                ) &&
                (
                    this.Participant == other.Participant ||
                    this.Participant != null &&
                    this.Participant.Equals(other.Participant)
                ) &&
                (
                    this.TopicPhrase == other.TopicPhrase ||
                    this.TopicPhrase != null &&
                    this.TopicPhrase.Equals(other.TopicPhrase)
                ) &&
                (
                    this.MatchedTranscript == other.MatchedTranscript ||
                    this.MatchedTranscript != null &&
                    this.MatchedTranscript.Equals(other.MatchedTranscript)
                ) &&
                (
                    this.Confidence == other.Confidence ||
                    this.Confidence != null &&
                    this.Confidence.Equals(other.Confidence)
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
                if (this.TopicId != null)
                    hash = hash * 59 + this.TopicId.GetHashCode();

                if (this.TopicName != null)
                    hash = hash * 59 + this.TopicName.GetHashCode();

                if (this.Participant != null)
                    hash = hash * 59 + this.Participant.GetHashCode();

                if (this.TopicPhrase != null)
                    hash = hash * 59 + this.TopicPhrase.GetHashCode();

                if (this.MatchedTranscript != null)
                    hash = hash * 59 + this.MatchedTranscript.GetHashCode();

                if (this.Confidence != null)
                    hash = hash * 59 + this.Confidence.GetHashCode();

                return hash;
            }
        }
    }

}
