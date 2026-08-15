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
    /// GenAIPhrasesJobRequest
    /// </summary>
    [DataContract]
    public partial class GenAIPhrasesJobRequest :  IEquatable<GenAIPhrasesJobRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIPhrasesJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenAIPhrasesJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIPhrasesJobRequest" /> class.
        /// </summary>
        /// <param name="Topic">topic used for phrases generation by GenAI (required).</param>
        public GenAIPhrasesJobRequest(GenAIPhrasesJobTopic Topic = null)
        {
            this.Topic = Topic;
            
        }
        


        /// <summary>
        /// topic used for phrases generation by GenAI
        /// </summary>
        /// <value>topic used for phrases generation by GenAI</value>
        [DataMember(Name="topic", EmitDefaultValue=false)]
        public GenAIPhrasesJobTopic Topic { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenAIPhrasesJobRequest {\n");

            sb.Append("  Topic: ").Append(Topic).Append("\n");
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
            return this.Equals(obj as GenAIPhrasesJobRequest);
        }

        /// <summary>
        /// Returns true if GenAIPhrasesJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GenAIPhrasesJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenAIPhrasesJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Topic == other.Topic ||
                    this.Topic != null &&
                    this.Topic.Equals(other.Topic)
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
                if (this.Topic != null)
                    hash = hash * 59 + this.Topic.GetHashCode();

                return hash;
            }
        }
    }

}
