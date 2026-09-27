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
    /// A2A agent card skill.
    /// </summary>
    [DataContract]
    public partial class AgenticVirtualAgentAgentCardSkill :  IEquatable<AgenticVirtualAgentAgentCardSkill>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentAgentCardSkill" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgenticVirtualAgentAgentCardSkill() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentAgentCardSkill" /> class.
        /// </summary>
        /// <param name="Id">Unique identifier for the skill. (required).</param>
        /// <param name="Name">Human-readable name of the skill. (required).</param>
        /// <param name="Description">Detailed explanation of what the skill does. (required).</param>
        /// <param name="Tags">Keywords for categorization and discovery. (required).</param>
        /// <param name="Examples">Sample prompts or use cases..</param>
        /// <param name="InputModes">Supported input media types..</param>
        /// <param name="OutputModes">Supported output media types..</param>
        public AgenticVirtualAgentAgentCardSkill(string Id = null, string Name = null, string Description = null, List<string> Tags = null, List<string> Examples = null, List<string> InputModes = null, List<string> OutputModes = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Tags = Tags;
            this.Examples = Examples;
            this.InputModes = InputModes;
            this.OutputModes = OutputModes;
            
        }
        


        /// <summary>
        /// Unique identifier for the skill.
        /// </summary>
        /// <value>Unique identifier for the skill.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Human-readable name of the skill.
        /// </summary>
        /// <value>Human-readable name of the skill.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Detailed explanation of what the skill does.
        /// </summary>
        /// <value>Detailed explanation of what the skill does.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Keywords for categorization and discovery.
        /// </summary>
        /// <value>Keywords for categorization and discovery.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }



        /// <summary>
        /// Sample prompts or use cases.
        /// </summary>
        /// <value>Sample prompts or use cases.</value>
        [DataMember(Name="examples", EmitDefaultValue=false)]
        public List<string> Examples { get; set; }



        /// <summary>
        /// Supported input media types.
        /// </summary>
        /// <value>Supported input media types.</value>
        [DataMember(Name="inputModes", EmitDefaultValue=false)]
        public List<string> InputModes { get; set; }



        /// <summary>
        /// Supported output media types.
        /// </summary>
        /// <value>Supported output media types.</value>
        [DataMember(Name="outputModes", EmitDefaultValue=false)]
        public List<string> OutputModes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgenticVirtualAgentAgentCardSkill {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Examples: ").Append(Examples).Append("\n");
            sb.Append("  InputModes: ").Append(InputModes).Append("\n");
            sb.Append("  OutputModes: ").Append(OutputModes).Append("\n");
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
            return this.Equals(obj as AgenticVirtualAgentAgentCardSkill);
        }

        /// <summary>
        /// Returns true if AgenticVirtualAgentAgentCardSkill instances are equal
        /// </summary>
        /// <param name="other">Instance of AgenticVirtualAgentAgentCardSkill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgenticVirtualAgentAgentCardSkill other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
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
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) &&
                (
                    this.Examples == other.Examples ||
                    this.Examples != null &&
                    this.Examples.SequenceEqual(other.Examples)
                ) &&
                (
                    this.InputModes == other.InputModes ||
                    this.InputModes != null &&
                    this.InputModes.SequenceEqual(other.InputModes)
                ) &&
                (
                    this.OutputModes == other.OutputModes ||
                    this.OutputModes != null &&
                    this.OutputModes.SequenceEqual(other.OutputModes)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();

                if (this.Examples != null)
                    hash = hash * 59 + this.Examples.GetHashCode();

                if (this.InputModes != null)
                    hash = hash * 59 + this.InputModes.GetHashCode();

                if (this.OutputModes != null)
                    hash = hash * 59 + this.OutputModes.GetHashCode();

                return hash;
            }
        }
    }

}
