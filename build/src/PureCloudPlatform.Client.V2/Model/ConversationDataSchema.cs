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
    /// ConversationDataSchema
    /// </summary>
    [DataContract]
    public partial class ConversationDataSchema :  IEquatable<ConversationDataSchema>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationDataSchema" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the schema..</param>
        /// <param name="Version">The schema&#39;s version, a positive integer..</param>
        /// <param name="Enabled">The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists..</param>
        /// <param name="JsonSchema">A JSON schema defining the extension to the built-in entity type..</param>
        public ConversationDataSchema(string Id = null, int? Version = null, bool? Enabled = null, ConversationJsonSchemaDocument JsonSchema = null)
        {
            this.Id = Id;
            this.Version = Version;
            this.Enabled = Enabled;
            this.JsonSchema = JsonSchema;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the schema.
        /// </summary>
        /// <value>The globally unique identifier for the schema.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The schema&#39;s version, a positive integer.
        /// </summary>
        /// <value>The schema&#39;s version, a positive integer.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



        /// <summary>
        /// The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists.
        /// </summary>
        /// <value>The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// The date and time this schema version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date and time this schema version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// The URI of the user that created this schema.
        /// </summary>
        /// <value>The URI of the user that created this schema.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public DomainEntityRef CreatedBy { get; private set; }



        /// <summary>
        /// A JSON schema defining the extension to the built-in entity type.
        /// </summary>
        /// <value>A JSON schema defining the extension to the built-in entity type.</value>
        [DataMember(Name="jsonSchema", EmitDefaultValue=false)]
        public ConversationJsonSchemaDocument JsonSchema { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationDataSchema {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  JsonSchema: ").Append(JsonSchema).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as ConversationDataSchema);
        }

        /// <summary>
        /// Returns true if ConversationDataSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationDataSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationDataSchema other)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.JsonSchema == other.JsonSchema ||
                    this.JsonSchema != null &&
                    this.JsonSchema.Equals(other.JsonSchema)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.JsonSchema != null)
                    hash = hash * 59 + this.JsonSchema.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
