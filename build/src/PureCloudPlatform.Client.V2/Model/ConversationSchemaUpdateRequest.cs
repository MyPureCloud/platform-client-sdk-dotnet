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
    /// Schema update request.
    /// </summary>
    [DataContract]
    public partial class ConversationSchemaUpdateRequest :  IEquatable<ConversationSchemaUpdateRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSchemaUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationSchemaUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSchemaUpdateRequest" /> class.
        /// </summary>
        /// <param name="Version">The schema&#39;s version, a positive integer. (required).</param>
        /// <param name="Enabled">The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists. (required).</param>
        /// <param name="JsonSchema">A JSON schema defining the extension to the built-in entity type. (required).</param>
        public ConversationSchemaUpdateRequest(int? Version = null, bool? Enabled = null, ConversationJsonSchemaRequest JsonSchema = null)
        {
            this.Version = Version;
            this.Enabled = Enabled;
            this.JsonSchema = JsonSchema;
            
        }
        


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
        /// A JSON schema defining the extension to the built-in entity type.
        /// </summary>
        /// <value>A JSON schema defining the extension to the built-in entity type.</value>
        [DataMember(Name="jsonSchema", EmitDefaultValue=false)]
        public ConversationJsonSchemaRequest JsonSchema { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationSchemaUpdateRequest {\n");

            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  JsonSchema: ").Append(JsonSchema).Append("\n");
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
            return this.Equals(obj as ConversationSchemaUpdateRequest);
        }

        /// <summary>
        /// Returns true if ConversationSchemaUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationSchemaUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationSchemaUpdateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.JsonSchema == other.JsonSchema ||
                    this.JsonSchema != null &&
                    this.JsonSchema.Equals(other.JsonSchema)
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
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.JsonSchema != null)
                    hash = hash * 59 + this.JsonSchema.GetHashCode();

                return hash;
            }
        }
    }

}
