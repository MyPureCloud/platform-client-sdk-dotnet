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
    /// TranscriptionsTopicTranscriptWord
    /// </summary>
    [DataContract]
    public partial class TranscriptionsTopicTranscriptWord :  IEquatable<TranscriptionsTopicTranscriptWord>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionsTopicTranscriptWord" /> class.
        /// </summary>
        /// <param name="Confidence">Confidence.</param>
        /// <param name="StartTimeMs">StartTimeMs.</param>
        /// <param name="OffsetMs">OffsetMs.</param>
        /// <param name="DurationMs">DurationMs.</param>
        /// <param name="Word">Word.</param>
        public TranscriptionsTopicTranscriptWord(double? Confidence = null, int? StartTimeMs = null, int? OffsetMs = null, int? DurationMs = null, string Word = null)
        {
            this.Confidence = Confidence;
            this.StartTimeMs = StartTimeMs;
            this.OffsetMs = OffsetMs;
            this.DurationMs = DurationMs;
            this.Word = Word;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Confidence
        /// </summary>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public double? Confidence { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets StartTimeMs
        /// </summary>
        [DataMember(Name="startTimeMs", EmitDefaultValue=false)]
        public int? StartTimeMs { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets OffsetMs
        /// </summary>
        [DataMember(Name="offsetMs", EmitDefaultValue=false)]
        public int? OffsetMs { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DurationMs
        /// </summary>
        [DataMember(Name="durationMs", EmitDefaultValue=false)]
        public int? DurationMs { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Word
        /// </summary>
        [DataMember(Name="word", EmitDefaultValue=false)]
        public string Word { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranscriptionsTopicTranscriptWord {\n");
            
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  StartTimeMs: ").Append(StartTimeMs).Append("\n");
            sb.Append("  OffsetMs: ").Append(OffsetMs).Append("\n");
            sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
            sb.Append("  Word: ").Append(Word).Append("\n");
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
            return this.Equals(obj as TranscriptionsTopicTranscriptWord);
        }

        /// <summary>
        /// Returns true if TranscriptionsTopicTranscriptWord instances are equal
        /// </summary>
        /// <param name="other">Instance of TranscriptionsTopicTranscriptWord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TranscriptionsTopicTranscriptWord other)
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
                    this.StartTimeMs == other.StartTimeMs ||
                    this.StartTimeMs != null &&
                    this.StartTimeMs.Equals(other.StartTimeMs)
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
                    this.Word == other.Word ||
                    this.Word != null &&
                    this.Word.Equals(other.Word)
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
                
                if (this.StartTimeMs != null)
                    hash = hash * 59 + this.StartTimeMs.GetHashCode();
                
                if (this.OffsetMs != null)
                    hash = hash * 59 + this.OffsetMs.GetHashCode();
                
                if (this.DurationMs != null)
                    hash = hash * 59 + this.DurationMs.GetHashCode();
                
                if (this.Word != null)
                    hash = hash * 59 + this.Word.GetHashCode();
                
                return hash;
            }
        }
    }

}
