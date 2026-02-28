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
    /// KnowledgeSearchResult
    /// </summary>
    [DataContract]
    public partial class KnowledgeSearchResult :  IEquatable<KnowledgeSearchResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSearchResult" /> class.
        /// </summary>
        /// <param name="GeneratedAnswer">The generated answer for search query..</param>
        /// <param name="RetrievedReferences">The retrieved references for the search query..</param>
        public KnowledgeSearchResult(string GeneratedAnswer = null, List<KnowledgeRetrievedReference> RetrievedReferences = null)
        {
            this.GeneratedAnswer = GeneratedAnswer;
            this.RetrievedReferences = RetrievedReferences;
            
        }
        


        /// <summary>
        /// The generated answer for search query.
        /// </summary>
        /// <value>The generated answer for search query.</value>
        [DataMember(Name="generatedAnswer", EmitDefaultValue=false)]
        public string GeneratedAnswer { get; set; }



        /// <summary>
        /// The retrieved references for the search query.
        /// </summary>
        /// <value>The retrieved references for the search query.</value>
        [DataMember(Name="retrievedReferences", EmitDefaultValue=false)]
        public List<KnowledgeRetrievedReference> RetrievedReferences { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeSearchResult {\n");

            sb.Append("  GeneratedAnswer: ").Append(GeneratedAnswer).Append("\n");
            sb.Append("  RetrievedReferences: ").Append(RetrievedReferences).Append("\n");
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
            return this.Equals(obj as KnowledgeSearchResult);
        }

        /// <summary>
        /// Returns true if KnowledgeSearchResult instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeSearchResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.GeneratedAnswer == other.GeneratedAnswer ||
                    this.GeneratedAnswer != null &&
                    this.GeneratedAnswer.Equals(other.GeneratedAnswer)
                ) &&
                (
                    this.RetrievedReferences == other.RetrievedReferences ||
                    this.RetrievedReferences != null &&
                    this.RetrievedReferences.SequenceEqual(other.RetrievedReferences)
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
                if (this.GeneratedAnswer != null)
                    hash = hash * 59 + this.GeneratedAnswer.GetHashCode();

                if (this.RetrievedReferences != null)
                    hash = hash * 59 + this.RetrievedReferences.GetHashCode();

                return hash;
            }
        }
    }

}
