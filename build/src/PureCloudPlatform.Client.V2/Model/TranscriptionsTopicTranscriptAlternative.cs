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
    /// TranscriptionsTopicTranscriptAlternative
    /// </summary>
    [DataContract]
    public partial class TranscriptionsTopicTranscriptAlternative :  IEquatable<TranscriptionsTopicTranscriptAlternative>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionsTopicTranscriptAlternative" /> class.
        /// </summary>
        /// <param name="Confidence">Confidence.</param>
        /// <param name="Transcript">Transcript.</param>
        /// <param name="Words">Words.</param>
        public TranscriptionsTopicTranscriptAlternative(double? Confidence = null, string Transcript = null, List<TranscriptionsTopicTranscriptWord> Words = null)
        {
            this.Confidence = Confidence;
            this.Transcript = Transcript;
            this.Words = Words;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Confidence
        /// </summary>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public double? Confidence { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Transcript
        /// </summary>
        [DataMember(Name="transcript", EmitDefaultValue=false)]
        public string Transcript { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Words
        /// </summary>
        [DataMember(Name="words", EmitDefaultValue=false)]
        public List<TranscriptionsTopicTranscriptWord> Words { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranscriptionsTopicTranscriptAlternative {\n");
            
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  Transcript: ").Append(Transcript).Append("\n");
            sb.Append("  Words: ").Append(Words).Append("\n");
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
            return this.Equals(obj as TranscriptionsTopicTranscriptAlternative);
        }

        /// <summary>
        /// Returns true if TranscriptionsTopicTranscriptAlternative instances are equal
        /// </summary>
        /// <param name="other">Instance of TranscriptionsTopicTranscriptAlternative to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TranscriptionsTopicTranscriptAlternative other)
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
                    this.Transcript == other.Transcript ||
                    this.Transcript != null &&
                    this.Transcript.Equals(other.Transcript)
                ) &&
                (
                    this.Words == other.Words ||
                    this.Words != null &&
                    this.Words.SequenceEqual(other.Words)
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
                
                if (this.Transcript != null)
                    hash = hash * 59 + this.Transcript.GetHashCode();
                
                if (this.Words != null)
                    hash = hash * 59 + this.Words.GetHashCode();
                
                return hash;
            }
        }
    }

}
