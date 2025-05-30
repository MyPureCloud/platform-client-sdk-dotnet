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
    /// PublishTopicTestPhraseDetectedPhrase
    /// </summary>
    [DataContract]
    public partial class PublishTopicTestPhraseDetectedPhrase :  IEquatable<PublishTopicTestPhraseDetectedPhrase>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishTopicTestPhraseDetectedPhrase" /> class.
        /// </summary>
        /// <param name="FoundPhrase">FoundPhrase.</param>
        /// <param name="Snippet">Snippet.</param>
        /// <param name="Confidence">Confidence.</param>
        public PublishTopicTestPhraseDetectedPhrase(string FoundPhrase = null, string Snippet = null, long? Confidence = null)
        {
            this.FoundPhrase = FoundPhrase;
            this.Snippet = Snippet;
            this.Confidence = Confidence;
            
        }
        


        /// <summary>
        /// Gets or Sets FoundPhrase
        /// </summary>
        [DataMember(Name="foundPhrase", EmitDefaultValue=false)]
        public string FoundPhrase { get; set; }



        /// <summary>
        /// Gets or Sets Snippet
        /// </summary>
        [DataMember(Name="snippet", EmitDefaultValue=false)]
        public string Snippet { get; set; }



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
            sb.Append("class PublishTopicTestPhraseDetectedPhrase {\n");

            sb.Append("  FoundPhrase: ").Append(FoundPhrase).Append("\n");
            sb.Append("  Snippet: ").Append(Snippet).Append("\n");
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
            return this.Equals(obj as PublishTopicTestPhraseDetectedPhrase);
        }

        /// <summary>
        /// Returns true if PublishTopicTestPhraseDetectedPhrase instances are equal
        /// </summary>
        /// <param name="other">Instance of PublishTopicTestPhraseDetectedPhrase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublishTopicTestPhraseDetectedPhrase other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FoundPhrase == other.FoundPhrase ||
                    this.FoundPhrase != null &&
                    this.FoundPhrase.Equals(other.FoundPhrase)
                ) &&
                (
                    this.Snippet == other.Snippet ||
                    this.Snippet != null &&
                    this.Snippet.Equals(other.Snippet)
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
                if (this.FoundPhrase != null)
                    hash = hash * 59 + this.FoundPhrase.GetHashCode();

                if (this.Snippet != null)
                    hash = hash * 59 + this.Snippet.GetHashCode();

                if (this.Confidence != null)
                    hash = hash * 59 + this.Confidence.GetHashCode();

                return hash;
            }
        }
    }

}
