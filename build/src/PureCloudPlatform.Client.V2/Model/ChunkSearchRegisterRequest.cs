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
    /// ChunkSearchRegisterRequest
    /// </summary>
    [DataContract]
    public partial class ChunkSearchRegisterRequest :  IEquatable<ChunkSearchRegisterRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkSearchRegisterRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChunkSearchRegisterRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkSearchRegisterRequest" /> class.
        /// </summary>
        /// <param name="SessionId">The unique identifier of this session.</param>
        /// <param name="Answered">Mark the chunks search as answered/unanswered (required).</param>
        /// <param name="SelectedAnswers">The search results selected as answers.</param>
        public ChunkSearchRegisterRequest(string SessionId = null, bool? Answered = null, List<SelectedAnswer> SelectedAnswers = null)
        {
            this.SessionId = SessionId;
            this.Answered = Answered;
            this.SelectedAnswers = SelectedAnswers;
            
        }
        


        /// <summary>
        /// The unique identifier of this session
        /// </summary>
        /// <value>The unique identifier of this session</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }



        /// <summary>
        /// Mark the chunks search as answered/unanswered
        /// </summary>
        /// <value>Mark the chunks search as answered/unanswered</value>
        [DataMember(Name="answered", EmitDefaultValue=false)]
        public bool? Answered { get; set; }



        /// <summary>
        /// The search results selected as answers
        /// </summary>
        /// <value>The search results selected as answers</value>
        [DataMember(Name="selectedAnswers", EmitDefaultValue=false)]
        public List<SelectedAnswer> SelectedAnswers { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChunkSearchRegisterRequest {\n");

            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  Answered: ").Append(Answered).Append("\n");
            sb.Append("  SelectedAnswers: ").Append(SelectedAnswers).Append("\n");
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
            return this.Equals(obj as ChunkSearchRegisterRequest);
        }

        /// <summary>
        /// Returns true if ChunkSearchRegisterRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ChunkSearchRegisterRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChunkSearchRegisterRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) &&
                (
                    this.Answered == other.Answered ||
                    this.Answered != null &&
                    this.Answered.Equals(other.Answered)
                ) &&
                (
                    this.SelectedAnswers == other.SelectedAnswers ||
                    this.SelectedAnswers != null &&
                    this.SelectedAnswers.SequenceEqual(other.SelectedAnswers)
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
                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();

                if (this.Answered != null)
                    hash = hash * 59 + this.Answered.GetHashCode();

                if (this.SelectedAnswers != null)
                    hash = hash * 59 + this.SelectedAnswers.GetHashCode();

                return hash;
            }
        }
    }

}
