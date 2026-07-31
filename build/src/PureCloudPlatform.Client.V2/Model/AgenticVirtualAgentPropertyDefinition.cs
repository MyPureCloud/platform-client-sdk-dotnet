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
    /// Property definition for an object type.
    /// </summary>
    [DataContract]
    public partial class AgenticVirtualAgentPropertyDefinition :  IEquatable<AgenticVirtualAgentPropertyDefinition>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentPropertyDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgenticVirtualAgentPropertyDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentPropertyDefinition" /> class.
        /// </summary>
        /// <param name="Name">Property name. (required).</param>
        /// <param name="Type">Property type name. The valid type depends on the containing type and related fields. (required).</param>
        /// <param name="Required">Whether this property must be supplied..</param>
        /// <param name="Description">Additional context that helps the virtual agent understand what this property means..</param>
        /// <param name="Items">Type of items in this array property. Applies when type is array..</param>
        /// <param name="Mapping">Path used to extract this output data property from a tool output. Only valid for output data properties. The path starts with a tool output type name, may contain only string property names or integer array indexes, and must resolve to a primitive value..</param>
        public AgenticVirtualAgentPropertyDefinition(string Name = null, string Type = null, bool? Required = null, string Description = null, string Items = null, List<Object> Mapping = null)
        {
            this.Name = Name;
            this.Type = Type;
            this.Required = Required;
            this.Description = Description;
            this.Items = Items;
            this.Mapping = Mapping;
            
        }
        


        /// <summary>
        /// Property name.
        /// </summary>
        /// <value>Property name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Property type name. The valid type depends on the containing type and related fields.
        /// </summary>
        /// <value>Property type name. The valid type depends on the containing type and related fields.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }



        /// <summary>
        /// Whether this property must be supplied.
        /// </summary>
        /// <value>Whether this property must be supplied.</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }



        /// <summary>
        /// Additional context that helps the virtual agent understand what this property means.
        /// </summary>
        /// <value>Additional context that helps the virtual agent understand what this property means.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Type of items in this array property. Applies when type is array.
        /// </summary>
        /// <value>Type of items in this array property. Applies when type is array.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public string Items { get; set; }



        /// <summary>
        /// Path used to extract this output data property from a tool output. Only valid for output data properties. The path starts with a tool output type name, may contain only string property names or integer array indexes, and must resolve to a primitive value.
        /// </summary>
        /// <value>Path used to extract this output data property from a tool output. Only valid for output data properties. The path starts with a tool output type name, may contain only string property names or integer array indexes, and must resolve to a primitive value.</value>
        [DataMember(Name="mapping", EmitDefaultValue=false)]
        public List<Object> Mapping { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgenticVirtualAgentPropertyDefinition {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Mapping: ").Append(Mapping).Append("\n");
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
            return this.Equals(obj as AgenticVirtualAgentPropertyDefinition);
        }

        /// <summary>
        /// Returns true if AgenticVirtualAgentPropertyDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of AgenticVirtualAgentPropertyDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgenticVirtualAgentPropertyDefinition other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.Equals(other.Items)
                ) &&
                (
                    this.Mapping == other.Mapping ||
                    this.Mapping != null &&
                    this.Mapping.SequenceEqual(other.Mapping)
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

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();

                if (this.Mapping != null)
                    hash = hash * 59 + this.Mapping.GetHashCode();

                return hash;
            }
        }
    }

}
