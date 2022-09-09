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
    /// TopicOffset
    /// </summary>
    [DataContract]
    public partial class TopicOffset :  IEquatable<TopicOffset>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopicOffset" /> class.
        /// </summary>
        public TopicOffset()
        {
            
        }
        


        /// <summary>
        /// Count of words before the topic 
        /// </summary>
        /// <value>Count of words before the topic </value>
        [DataMember(Name="wordCount", EmitDefaultValue=false)]
        public long? WordCount { get; private set; }



        /// <summary>
        /// Count of characters before the topic 
        /// </summary>
        /// <value>Count of characters before the topic </value>
        [DataMember(Name="characterCount", EmitDefaultValue=false)]
        public long? CharacterCount { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopicOffset {\n");

            sb.Append("  WordCount: ").Append(WordCount).Append("\n");
            sb.Append("  CharacterCount: ").Append(CharacterCount).Append("\n");
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
            return this.Equals(obj as TopicOffset);
        }

        /// <summary>
        /// Returns true if TopicOffset instances are equal
        /// </summary>
        /// <param name="other">Instance of TopicOffset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TopicOffset other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WordCount == other.WordCount ||
                    this.WordCount != null &&
                    this.WordCount.Equals(other.WordCount)
                ) &&
                (
                    this.CharacterCount == other.CharacterCount ||
                    this.CharacterCount != null &&
                    this.CharacterCount.Equals(other.CharacterCount)
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
                if (this.WordCount != null)
                    hash = hash * 59 + this.WordCount.GetHashCode();

                if (this.CharacterCount != null)
                    hash = hash * 59 + this.CharacterCount.GetHashCode();

                return hash;
            }
        }
    }

}
