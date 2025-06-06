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
    /// CreateGeneralProgramTestPhraseDetectedPhrase
    /// </summary>
    [DataContract]
    public partial class CreateGeneralProgramTestPhraseDetectedPhrase :  IEquatable<CreateGeneralProgramTestPhraseDetectedPhrase>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGeneralProgramTestPhraseDetectedPhrase" /> class.
        /// </summary>
        /// <param name="FoundPhrase">FoundPhrase.</param>
        /// <param name="Snippet">Snippet.</param>
        /// <param name="Confidence">Confidence.</param>
        public CreateGeneralProgramTestPhraseDetectedPhrase(string FoundPhrase = null, string Snippet = null, long? Confidence = null)
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
            sb.Append("class CreateGeneralProgramTestPhraseDetectedPhrase {\n");

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
            return this.Equals(obj as CreateGeneralProgramTestPhraseDetectedPhrase);
        }

        /// <summary>
        /// Returns true if CreateGeneralProgramTestPhraseDetectedPhrase instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateGeneralProgramTestPhraseDetectedPhrase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateGeneralProgramTestPhraseDetectedPhrase other)
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
