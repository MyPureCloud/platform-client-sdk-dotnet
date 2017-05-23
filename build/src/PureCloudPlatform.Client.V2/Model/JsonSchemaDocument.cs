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
    /// A JSON Schema document.
    /// </summary>
    [DataContract]
    public partial class JsonSchemaDocument :  IEquatable<JsonSchemaDocument>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaDocument" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Schema">Schema.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Required">Required.</param>
        /// <param name="Properties">Properties.</param>
        public JsonSchemaDocument(string Id = null, string Schema = null, string Title = null, string Description = null, string Type = null, List<string> Required = null, Dictionary<string, Object> Properties = null)
        {
            this.Id = Id;
            this.Schema = Schema;
            this.Title = Title;
            this.Description = Description;
            this.Type = Type;
            this.Required = Required;
            this.Properties = Properties;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name="$schema", EmitDefaultValue=false)]
        public string Schema { get; set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public List<string> Required { get; set; }
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, Object> Properties { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonSchemaDocument {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as JsonSchemaDocument);
        }

        /// <summary>
        /// Returns true if JsonSchemaDocument instances are equal
        /// </summary>
        /// <param name="other">Instance of JsonSchemaDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonSchemaDocument other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Schema != null)
                    hash = hash * 59 + this.Schema.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                return hash;
            }
        }
    }

}
