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
    /// TopicCriteria
    /// </summary>
    [DataContract]
    public partial class TopicCriteria :  IEquatable<TopicCriteria>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicCriteria" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TopicCriteria() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TopicCriteria" /> class.
        /// </summary>
        /// <param name="TopicId">The ID of the topic. (required).</param>
        /// <param name="DataIngestionRules">The data ingestion rules for this topic. (required).</param>
        public TopicCriteria(string TopicId = null, List<DataIngestionRuleCriteria> DataIngestionRules = null)
        {
            this.TopicId = TopicId;
            this.DataIngestionRules = DataIngestionRules;
            
        }
        


        /// <summary>
        /// The ID of the topic.
        /// </summary>
        /// <value>The ID of the topic.</value>
        [DataMember(Name="topicId", EmitDefaultValue=false)]
        public string TopicId { get; set; }



        /// <summary>
        /// The data ingestion rules for this topic.
        /// </summary>
        /// <value>The data ingestion rules for this topic.</value>
        [DataMember(Name="dataIngestionRules", EmitDefaultValue=false)]
        public List<DataIngestionRuleCriteria> DataIngestionRules { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopicCriteria {\n");

            sb.Append("  TopicId: ").Append(TopicId).Append("\n");
            sb.Append("  DataIngestionRules: ").Append(DataIngestionRules).Append("\n");
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
            return this.Equals(obj as TopicCriteria);
        }

        /// <summary>
        /// Returns true if TopicCriteria instances are equal
        /// </summary>
        /// <param name="other">Instance of TopicCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TopicCriteria other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TopicId == other.TopicId ||
                    this.TopicId != null &&
                    this.TopicId.Equals(other.TopicId)
                ) &&
                (
                    this.DataIngestionRules == other.DataIngestionRules ||
                    this.DataIngestionRules != null &&
                    this.DataIngestionRules.SequenceEqual(other.DataIngestionRules)
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
                if (this.TopicId != null)
                    hash = hash * 59 + this.TopicId.GetHashCode();

                if (this.DataIngestionRules != null)
                    hash = hash * 59 + this.DataIngestionRules.GetHashCode();

                return hash;
            }
        }
    }

}
