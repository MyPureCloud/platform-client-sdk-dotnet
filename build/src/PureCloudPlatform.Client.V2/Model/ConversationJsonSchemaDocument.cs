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
    /// A Conversation Custom Attributes JSON Schema
    /// </summary>
    [DataContract]
    public partial class ConversationJsonSchemaDocument :  IEquatable<ConversationJsonSchemaDocument>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationJsonSchemaDocument" /> class.
        /// </summary>
        /// <param name="Schema">The JSON Schema specification link. The only value currently supported is \&quot;http://json-schema.org/draft-04/schema#\&quot;..</param>
        /// <param name="Title">The title of the schema. Must be unique across all enabled Custom Attributes Schemas..</param>
        /// <param name="Description">The schema description..</param>
        /// <param name="Required">The list of required schema properties. All fields are optional unless listed. New fields added after initial schema creation must be optional before being able to update to required..</param>
        /// <param name="Properties">The map of schema properties and their limits..</param>
        public ConversationJsonSchemaDocument(string Schema = null, string Title = null, string Description = null, List<string> Required = null, Dictionary<string, Object> Properties = null)
        {
            this.Schema = Schema;
            this.Title = Title;
            this.Description = Description;
            this.Required = Required;
            this.Properties = Properties;
            
        }
        


        /// <summary>
        /// The JSON Schema specification link. The only value currently supported is \&quot;http://json-schema.org/draft-04/schema#\&quot;.
        /// </summary>
        /// <value>The JSON Schema specification link. The only value currently supported is \&quot;http://json-schema.org/draft-04/schema#\&quot;.</value>
        [DataMember(Name="$schema", EmitDefaultValue=false)]
        public string Schema { get; set; }



        /// <summary>
        /// The title of the schema. Must be unique across all enabled Custom Attributes Schemas.
        /// </summary>
        /// <value>The title of the schema. Must be unique across all enabled Custom Attributes Schemas.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// The schema description.
        /// </summary>
        /// <value>The schema description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The list of required schema properties. All fields are optional unless listed. New fields added after initial schema creation must be optional before being able to update to required.
        /// </summary>
        /// <value>The list of required schema properties. All fields are optional unless listed. New fields added after initial schema creation must be optional before being able to update to required.</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public List<string> Required { get; set; }



        /// <summary>
        /// The map of schema properties and their limits.
        /// </summary>
        /// <value>The map of schema properties and their limits.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, Object> Properties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationJsonSchemaDocument {\n");

            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(obj as ConversationJsonSchemaDocument);
        }

        /// <summary>
        /// Returns true if ConversationJsonSchemaDocument instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationJsonSchemaDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationJsonSchemaDocument other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Schema == other.Schema ||
                    this.Schema != null &&
                    this.Schema.Equals(other.Schema)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.SequenceEqual(other.Required)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
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
                if (this.Schema != null)
                    hash = hash * 59 + this.Schema.GetHashCode();

                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();

                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();

                return hash;
            }
        }
    }

}
