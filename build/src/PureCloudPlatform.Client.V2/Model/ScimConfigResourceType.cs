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
    /// Defines a SCIM resource.
    /// </summary>
    [DataContract]
    public partial class ScimConfigResourceType :  IEquatable<ScimConfigResourceType>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimConfigResourceType" /> class.
        /// </summary>
        /// <param name="Schemas">The list of supported schemas..</param>
        /// <param name="SchemaExtensions">The list of schema extensions for the resource type..</param>
        /// <param name="Meta">The metadata of the SCIM resource. Only location and resourceType are set for ResourceType resources..</param>
        public ScimConfigResourceType(List<string> Schemas = null, List<ScimConfigResourceTypeSchemaExtension> SchemaExtensions = null, ScimMetadata Meta = null)
        {
            this.Schemas = Schemas;
            this.SchemaExtensions = SchemaExtensions;
            this.Meta = Meta;
            
        }
        
        
        
        /// <summary>
        /// The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;returned\&quot; is set to \&quot;always\&quot;.
        /// </summary>
        /// <value>The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;returned\&quot; is set to \&quot;always\&quot;.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The list of supported schemas.
        /// </summary>
        /// <value>The list of supported schemas.</value>
        [DataMember(Name="schemas", EmitDefaultValue=false)]
        public List<string> Schemas { get; set; }
        
        
        
        /// <summary>
        /// The name of the resource type.
        /// </summary>
        /// <value>The name of the resource type.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }
        
        
        
        /// <summary>
        /// The description of the resource type.
        /// </summary>
        /// <value>The description of the resource type.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }
        
        
        
        /// <summary>
        /// The URI of the primary or base schema for the resource type.
        /// </summary>
        /// <value>The URI of the primary or base schema for the resource type.</value>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public string Schema { get; private set; }
        
        
        
        /// <summary>
        /// The list of schema extensions for the resource type.
        /// </summary>
        /// <value>The list of schema extensions for the resource type.</value>
        [DataMember(Name="schemaExtensions", EmitDefaultValue=false)]
        public List<ScimConfigResourceTypeSchemaExtension> SchemaExtensions { get; set; }
        
        
        
        /// <summary>
        /// The HTTP-addressable endpoint of the resource type. Appears after the base URL.
        /// </summary>
        /// <value>The HTTP-addressable endpoint of the resource type. Appears after the base URL.</value>
        [DataMember(Name="endpoint", EmitDefaultValue=false)]
        public string Endpoint { get; private set; }
        
        
        
        /// <summary>
        /// The metadata of the SCIM resource. Only location and resourceType are set for ResourceType resources.
        /// </summary>
        /// <value>The metadata of the SCIM resource. Only location and resourceType are set for ResourceType resources.</value>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public ScimMetadata Meta { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimConfigResourceType {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Schemas: ").Append(Schemas).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  SchemaExtensions: ").Append(SchemaExtensions).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(obj as ScimConfigResourceType);
        }

        /// <summary>
        /// Returns true if ScimConfigResourceType instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimConfigResourceType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimConfigResourceType other)
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
                    this.Schemas == other.Schemas ||
                    this.Schemas != null &&
                    this.Schemas.SequenceEqual(other.Schemas)
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
                    this.Schema == other.Schema ||
                    this.Schema != null &&
                    this.Schema.Equals(other.Schema)
                ) &&
                (
                    this.SchemaExtensions == other.SchemaExtensions ||
                    this.SchemaExtensions != null &&
                    this.SchemaExtensions.SequenceEqual(other.SchemaExtensions)
                ) &&
                (
                    this.Endpoint == other.Endpoint ||
                    this.Endpoint != null &&
                    this.Endpoint.Equals(other.Endpoint)
                ) &&
                (
                    this.Meta == other.Meta ||
                    this.Meta != null &&
                    this.Meta.Equals(other.Meta)
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
                
                if (this.Schemas != null)
                    hash = hash * 59 + this.Schemas.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Schema != null)
                    hash = hash * 59 + this.Schema.GetHashCode();
                
                if (this.SchemaExtensions != null)
                    hash = hash * 59 + this.SchemaExtensions.GetHashCode();
                
                if (this.Endpoint != null)
                    hash = hash * 59 + this.Endpoint.GetHashCode();
                
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
                
                return hash;
            }
        }
    }

}
