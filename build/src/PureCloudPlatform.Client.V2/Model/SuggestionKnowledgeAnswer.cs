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
    /// SuggestionKnowledgeAnswer
    /// </summary>
    [DataContract]
    public partial class SuggestionKnowledgeAnswer :  IEquatable<SuggestionKnowledgeAnswer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestionKnowledgeAnswer" /> class.
        /// </summary>
        public SuggestionKnowledgeAnswer()
        {
            
        }
        


        /// <summary>
        /// The most relevant answer
        /// </summary>
        /// <value>The most relevant answer</value>
        [DataMember(Name="answer", EmitDefaultValue=false)]
        public string Answer { get; private set; }



        /// <summary>
        /// The start index of the answer
        /// </summary>
        /// <value>The start index of the answer</value>
        [DataMember(Name="startIndex", EmitDefaultValue=false)]
        public int? StartIndex { get; private set; }



        /// <summary>
        /// The end index of the answer
        /// </summary>
        /// <value>The end index of the answer</value>
        [DataMember(Name="endIndex", EmitDefaultValue=false)]
        public int? EndIndex { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuggestionKnowledgeAnswer {\n");

            sb.Append("  Answer: ").Append(Answer).Append("\n");
            sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  EndIndex: ").Append(EndIndex).Append("\n");
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
            return this.Equals(obj as SuggestionKnowledgeAnswer);
        }

        /// <summary>
        /// Returns true if SuggestionKnowledgeAnswer instances are equal
        /// </summary>
        /// <param name="other">Instance of SuggestionKnowledgeAnswer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuggestionKnowledgeAnswer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Answer == other.Answer ||
                    this.Answer != null &&
                    this.Answer.Equals(other.Answer)
                ) &&
                (
                    this.StartIndex == other.StartIndex ||
                    this.StartIndex != null &&
                    this.StartIndex.Equals(other.StartIndex)
                ) &&
                (
                    this.EndIndex == other.EndIndex ||
                    this.EndIndex != null &&
                    this.EndIndex.Equals(other.EndIndex)
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
                if (this.Answer != null)
                    hash = hash * 59 + this.Answer.GetHashCode();

                if (this.StartIndex != null)
                    hash = hash * 59 + this.StartIndex.GetHashCode();

                if (this.EndIndex != null)
                    hash = hash * 59 + this.EndIndex.GetHashCode();

                return hash;
            }
        }
    }

}
