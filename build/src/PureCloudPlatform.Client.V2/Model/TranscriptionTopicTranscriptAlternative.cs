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
    /// TranscriptionTopicTranscriptAlternative
    /// </summary>
    [DataContract]
    public partial class TranscriptionTopicTranscriptAlternative :  IEquatable<TranscriptionTopicTranscriptAlternative>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionTopicTranscriptAlternative" /> class.
        /// </summary>
        /// <param name="Confidence">Confidence.</param>
        /// <param name="OffsetMs">OffsetMs.</param>
        /// <param name="DurationMs">DurationMs.</param>
        /// <param name="Transcript">Transcript.</param>
        /// <param name="Words">Words.</param>
        /// <param name="DecoratedTranscript">DecoratedTranscript.</param>
        /// <param name="DecoratedWords">DecoratedWords.</param>
        public TranscriptionTopicTranscriptAlternative(double? Confidence = null, long? OffsetMs = null, long? DurationMs = null, string Transcript = null, List<TranscriptionTopicTranscriptWord> Words = null, string DecoratedTranscript = null, List<TranscriptionTopicTranscriptWord> DecoratedWords = null)
        {
            this.Confidence = Confidence;
            this.OffsetMs = OffsetMs;
            this.DurationMs = DurationMs;
            this.Transcript = Transcript;
            this.Words = Words;
            this.DecoratedTranscript = DecoratedTranscript;
            this.DecoratedWords = DecoratedWords;
            
        }
        


        /// <summary>
        /// Gets or Sets Confidence
        /// </summary>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public double? Confidence { get; set; }



        /// <summary>
        /// Gets or Sets OffsetMs
        /// </summary>
        [DataMember(Name="offsetMs", EmitDefaultValue=false)]
        public long? OffsetMs { get; set; }



        /// <summary>
        /// Gets or Sets DurationMs
        /// </summary>
        [DataMember(Name="durationMs", EmitDefaultValue=false)]
        public long? DurationMs { get; set; }



        /// <summary>
        /// Gets or Sets Transcript
        /// </summary>
        [DataMember(Name="transcript", EmitDefaultValue=false)]
        public string Transcript { get; set; }



        /// <summary>
        /// Gets or Sets Words
        /// </summary>
        [DataMember(Name="words", EmitDefaultValue=false)]
        public List<TranscriptionTopicTranscriptWord> Words { get; set; }



        /// <summary>
        /// Gets or Sets DecoratedTranscript
        /// </summary>
        [DataMember(Name="decoratedTranscript", EmitDefaultValue=false)]
        public string DecoratedTranscript { get; set; }



        /// <summary>
        /// Gets or Sets DecoratedWords
        /// </summary>
        [DataMember(Name="decoratedWords", EmitDefaultValue=false)]
        public List<TranscriptionTopicTranscriptWord> DecoratedWords { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranscriptionTopicTranscriptAlternative {\n");

            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  OffsetMs: ").Append(OffsetMs).Append("\n");
            sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
            sb.Append("  Transcript: ").Append(Transcript).Append("\n");
            sb.Append("  Words: ").Append(Words).Append("\n");
            sb.Append("  DecoratedTranscript: ").Append(DecoratedTranscript).Append("\n");
            sb.Append("  DecoratedWords: ").Append(DecoratedWords).Append("\n");
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
            return this.Equals(obj as TranscriptionTopicTranscriptAlternative);
        }

        /// <summary>
        /// Returns true if TranscriptionTopicTranscriptAlternative instances are equal
        /// </summary>
        /// <param name="other">Instance of TranscriptionTopicTranscriptAlternative to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TranscriptionTopicTranscriptAlternative other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Confidence == other.Confidence ||
                    this.Confidence != null &&
                    this.Confidence.Equals(other.Confidence)
                ) &&
                (
                    this.OffsetMs == other.OffsetMs ||
                    this.OffsetMs != null &&
                    this.OffsetMs.Equals(other.OffsetMs)
                ) &&
                (
                    this.DurationMs == other.DurationMs ||
                    this.DurationMs != null &&
                    this.DurationMs.Equals(other.DurationMs)
                ) &&
                (
                    this.Transcript == other.Transcript ||
                    this.Transcript != null &&
                    this.Transcript.Equals(other.Transcript)
                ) &&
                (
                    this.Words == other.Words ||
                    this.Words != null &&
                    this.Words.SequenceEqual(other.Words)
                ) &&
                (
                    this.DecoratedTranscript == other.DecoratedTranscript ||
                    this.DecoratedTranscript != null &&
                    this.DecoratedTranscript.Equals(other.DecoratedTranscript)
                ) &&
                (
                    this.DecoratedWords == other.DecoratedWords ||
                    this.DecoratedWords != null &&
                    this.DecoratedWords.SequenceEqual(other.DecoratedWords)
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
                if (this.Confidence != null)
                    hash = hash * 59 + this.Confidence.GetHashCode();

                if (this.OffsetMs != null)
                    hash = hash * 59 + this.OffsetMs.GetHashCode();

                if (this.DurationMs != null)
                    hash = hash * 59 + this.DurationMs.GetHashCode();

                if (this.Transcript != null)
                    hash = hash * 59 + this.Transcript.GetHashCode();

                if (this.Words != null)
                    hash = hash * 59 + this.Words.GetHashCode();

                if (this.DecoratedTranscript != null)
                    hash = hash * 59 + this.DecoratedTranscript.GetHashCode();

                if (this.DecoratedWords != null)
                    hash = hash * 59 + this.DecoratedWords.GetHashCode();

                return hash;
            }
        }
    }

}
