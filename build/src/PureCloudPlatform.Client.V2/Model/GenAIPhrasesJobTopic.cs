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
    /// GenAIPhrasesJobTopic
    /// </summary>
    [DataContract]
    public partial class GenAIPhrasesJobTopic :  IEquatable<GenAIPhrasesJobTopic>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIPhrasesJobTopic" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenAIPhrasesJobTopic() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIPhrasesJobTopic" /> class.
        /// </summary>
        /// <param name="Name">The topic name (required).</param>
        /// <param name="Description">The topic description.</param>
        /// <param name="Dialect">The topic dialect (required).</param>
        /// <param name="Phrases">Existing phrases for the topic.</param>
        public GenAIPhrasesJobTopic(string Name = null, string Description = null, string Dialect = null, List<string> Phrases = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Dialect = Dialect;
            this.Phrases = Phrases;
            
        }
        


        /// <summary>
        /// The topic name
        /// </summary>
        /// <value>The topic name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The topic description
        /// </summary>
        /// <value>The topic description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The topic dialect
        /// </summary>
        /// <value>The topic dialect</value>
        [DataMember(Name="dialect", EmitDefaultValue=false)]
        public string Dialect { get; set; }



        /// <summary>
        /// Existing phrases for the topic
        /// </summary>
        /// <value>Existing phrases for the topic</value>
        [DataMember(Name="phrases", EmitDefaultValue=false)]
        public List<string> Phrases { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenAIPhrasesJobTopic {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Dialect: ").Append(Dialect).Append("\n");
            sb.Append("  Phrases: ").Append(Phrases).Append("\n");
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
            return this.Equals(obj as GenAIPhrasesJobTopic);
        }

        /// <summary>
        /// Returns true if GenAIPhrasesJobTopic instances are equal
        /// </summary>
        /// <param name="other">Instance of GenAIPhrasesJobTopic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenAIPhrasesJobTopic other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Dialect == other.Dialect ||
                    this.Dialect != null &&
                    this.Dialect.Equals(other.Dialect)
                ) &&
                (
                    this.Phrases == other.Phrases ||
                    this.Phrases != null &&
                    this.Phrases.SequenceEqual(other.Phrases)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Dialect != null)
                    hash = hash * 59 + this.Dialect.GetHashCode();

                if (this.Phrases != null)
                    hash = hash * 59 + this.Phrases.GetHashCode();

                return hash;
            }
        }
    }

}
