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
    /// ProgramTopicLinksTestTopicPhraseResults
    /// </summary>
    [DataContract]
    public partial class ProgramTopicLinksTestTopicPhraseResults :  IEquatable<ProgramTopicLinksTestTopicPhraseResults>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramTopicLinksTestTopicPhraseResults" /> class.
        /// </summary>
        /// <param name="ProcessedTranscriptsCount">ProcessedTranscriptsCount.</param>
        /// <param name="MatchedTranscriptsCount">MatchedTranscriptsCount.</param>
        /// <param name="MatchedTranscripts">MatchedTranscripts.</param>
        public ProgramTopicLinksTestTopicPhraseResults(long? ProcessedTranscriptsCount = null, long? MatchedTranscriptsCount = null, List<ProgramTopicLinksTestPhraseMatchedTranscript> MatchedTranscripts = null)
        {
            this.ProcessedTranscriptsCount = ProcessedTranscriptsCount;
            this.MatchedTranscriptsCount = MatchedTranscriptsCount;
            this.MatchedTranscripts = MatchedTranscripts;
            
        }
        


        /// <summary>
        /// Gets or Sets ProcessedTranscriptsCount
        /// </summary>
        [DataMember(Name="processedTranscriptsCount", EmitDefaultValue=false)]
        public long? ProcessedTranscriptsCount { get; set; }



        /// <summary>
        /// Gets or Sets MatchedTranscriptsCount
        /// </summary>
        [DataMember(Name="matchedTranscriptsCount", EmitDefaultValue=false)]
        public long? MatchedTranscriptsCount { get; set; }



        /// <summary>
        /// Gets or Sets MatchedTranscripts
        /// </summary>
        [DataMember(Name="matchedTranscripts", EmitDefaultValue=false)]
        public List<ProgramTopicLinksTestPhraseMatchedTranscript> MatchedTranscripts { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgramTopicLinksTestTopicPhraseResults {\n");

            sb.Append("  ProcessedTranscriptsCount: ").Append(ProcessedTranscriptsCount).Append("\n");
            sb.Append("  MatchedTranscriptsCount: ").Append(MatchedTranscriptsCount).Append("\n");
            sb.Append("  MatchedTranscripts: ").Append(MatchedTranscripts).Append("\n");
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
            return this.Equals(obj as ProgramTopicLinksTestTopicPhraseResults);
        }

        /// <summary>
        /// Returns true if ProgramTopicLinksTestTopicPhraseResults instances are equal
        /// </summary>
        /// <param name="other">Instance of ProgramTopicLinksTestTopicPhraseResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgramTopicLinksTestTopicPhraseResults other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ProcessedTranscriptsCount == other.ProcessedTranscriptsCount ||
                    this.ProcessedTranscriptsCount != null &&
                    this.ProcessedTranscriptsCount.Equals(other.ProcessedTranscriptsCount)
                ) &&
                (
                    this.MatchedTranscriptsCount == other.MatchedTranscriptsCount ||
                    this.MatchedTranscriptsCount != null &&
                    this.MatchedTranscriptsCount.Equals(other.MatchedTranscriptsCount)
                ) &&
                (
                    this.MatchedTranscripts == other.MatchedTranscripts ||
                    this.MatchedTranscripts != null &&
                    this.MatchedTranscripts.SequenceEqual(other.MatchedTranscripts)
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
                if (this.ProcessedTranscriptsCount != null)
                    hash = hash * 59 + this.ProcessedTranscriptsCount.GetHashCode();

                if (this.MatchedTranscriptsCount != null)
                    hash = hash * 59 + this.MatchedTranscriptsCount.GetHashCode();

                if (this.MatchedTranscripts != null)
                    hash = hash * 59 + this.MatchedTranscripts.GetHashCode();

                return hash;
            }
        }
    }

}
