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
    /// DocumentFaq
    /// </summary>
    [DataContract]
    public partial class DocumentFaq :  IEquatable<DocumentFaq>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentFaq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentFaq() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentFaq" /> class.
        /// </summary>
        /// <param name="Question">The question for this FAQ (required).</param>
        /// <param name="Answer">The answer for this FAQ (required).</param>
        /// <param name="Alternatives">List of Alternative questions related to the answer which helps in improving the likelihood of a match to user query.</param>
        public DocumentFaq(string Question = null, string Answer = null, List<string> Alternatives = null)
        {
            this.Question = Question;
            this.Answer = Answer;
            this.Alternatives = Alternatives;
            
        }
        
        
        
        /// <summary>
        /// The question for this FAQ
        /// </summary>
        /// <value>The question for this FAQ</value>
        [DataMember(Name="question", EmitDefaultValue=false)]
        public string Question { get; set; }
        
        
        
        /// <summary>
        /// The answer for this FAQ
        /// </summary>
        /// <value>The answer for this FAQ</value>
        [DataMember(Name="answer", EmitDefaultValue=false)]
        public string Answer { get; set; }
        
        
        
        /// <summary>
        /// List of Alternative questions related to the answer which helps in improving the likelihood of a match to user query
        /// </summary>
        /// <value>List of Alternative questions related to the answer which helps in improving the likelihood of a match to user query</value>
        [DataMember(Name="alternatives", EmitDefaultValue=false)]
        public List<string> Alternatives { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentFaq {\n");
            
            sb.Append("  Question: ").Append(Question).Append("\n");
            sb.Append("  Answer: ").Append(Answer).Append("\n");
            sb.Append("  Alternatives: ").Append(Alternatives).Append("\n");
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
            return this.Equals(obj as DocumentFaq);
        }

        /// <summary>
        /// Returns true if DocumentFaq instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentFaq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentFaq other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Question == other.Question ||
                    this.Question != null &&
                    this.Question.Equals(other.Question)
                ) &&
                (
                    this.Answer == other.Answer ||
                    this.Answer != null &&
                    this.Answer.Equals(other.Answer)
                ) &&
                (
                    this.Alternatives == other.Alternatives ||
                    this.Alternatives != null &&
                    this.Alternatives.SequenceEqual(other.Alternatives)
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
                
                if (this.Question != null)
                    hash = hash * 59 + this.Question.GetHashCode();
                
                if (this.Answer != null)
                    hash = hash * 59 + this.Answer.GetHashCode();
                
                if (this.Alternatives != null)
                    hash = hash * 59 + this.Alternatives.GetHashCode();
                
                return hash;
            }
        }
    }

}
