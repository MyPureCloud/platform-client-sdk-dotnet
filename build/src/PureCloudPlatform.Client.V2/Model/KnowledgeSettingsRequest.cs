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
    /// KnowledgeSettingsRequest
    /// </summary>
    [DataContract]
    public partial class KnowledgeSettingsRequest :  IEquatable<KnowledgeSettingsRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSettingsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeSettingsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSettingsRequest" /> class.
        /// </summary>
        /// <param name="Name">Knowledge setting name. (required).</param>
        /// <param name="Description">Knowledge setting description..</param>
        /// <param name="Sources">Knowledge source information to search upon. (required).</param>
        /// <param name="GenerationSetting">Setting for answer generation..</param>
        /// <param name="Stateful">Indicates if stateful search and generation is enabled for the knowledge setting..</param>
        public KnowledgeSettingsRequest(string Name = null, string Description = null, List<V3SourceRef> Sources = null, KnowledgeGenerationSetting GenerationSetting = null, bool? Stateful = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Sources = Sources;
            this.GenerationSetting = GenerationSetting;
            this.Stateful = Stateful;
            
        }
        


        /// <summary>
        /// Knowledge setting name.
        /// </summary>
        /// <value>Knowledge setting name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Knowledge setting description.
        /// </summary>
        /// <value>Knowledge setting description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Knowledge source information to search upon.
        /// </summary>
        /// <value>Knowledge source information to search upon.</value>
        [DataMember(Name="sources", EmitDefaultValue=false)]
        public List<V3SourceRef> Sources { get; set; }



        /// <summary>
        /// Setting for answer generation.
        /// </summary>
        /// <value>Setting for answer generation.</value>
        [DataMember(Name="generationSetting", EmitDefaultValue=false)]
        public KnowledgeGenerationSetting GenerationSetting { get; set; }



        /// <summary>
        /// Indicates if stateful search and generation is enabled for the knowledge setting.
        /// </summary>
        /// <value>Indicates if stateful search and generation is enabled for the knowledge setting.</value>
        [DataMember(Name="stateful", EmitDefaultValue=false)]
        public bool? Stateful { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeSettingsRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
            sb.Append("  GenerationSetting: ").Append(GenerationSetting).Append("\n");
            sb.Append("  Stateful: ").Append(Stateful).Append("\n");
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
            return this.Equals(obj as KnowledgeSettingsRequest);
        }

        /// <summary>
        /// Returns true if KnowledgeSettingsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeSettingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeSettingsRequest other)
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
                    this.Sources == other.Sources ||
                    this.Sources != null &&
                    this.Sources.SequenceEqual(other.Sources)
                ) &&
                (
                    this.GenerationSetting == other.GenerationSetting ||
                    this.GenerationSetting != null &&
                    this.GenerationSetting.Equals(other.GenerationSetting)
                ) &&
                (
                    this.Stateful == other.Stateful ||
                    this.Stateful != null &&
                    this.Stateful.Equals(other.Stateful)
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

                if (this.Sources != null)
                    hash = hash * 59 + this.Sources.GetHashCode();

                if (this.GenerationSetting != null)
                    hash = hash * 59 + this.GenerationSetting.GetHashCode();

                if (this.Stateful != null)
                    hash = hash * 59 + this.Stateful.GetHashCode();

                return hash;
            }
        }
    }

}
