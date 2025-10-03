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
    /// Request to create a new Business Rules Schema
    /// </summary>
    [DataContract]
    public partial class BusinessRulesSchemaCreateRequest :  IEquatable<BusinessRulesSchemaCreateRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessRulesSchemaCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BusinessRulesSchemaCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessRulesSchemaCreateRequest" /> class.
        /// </summary>
        /// <param name="JsonSchema">A JSON schema defining the extension to the built-in entity type. (required).</param>
        public BusinessRulesSchemaCreateRequest(JsonSchemaWithDefinitions JsonSchema = null)
        {
            this.JsonSchema = JsonSchema;
            
        }
        


        /// <summary>
        /// A JSON schema defining the extension to the built-in entity type.
        /// </summary>
        /// <value>A JSON schema defining the extension to the built-in entity type.</value>
        [DataMember(Name="jsonSchema", EmitDefaultValue=false)]
        public JsonSchemaWithDefinitions JsonSchema { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessRulesSchemaCreateRequest {\n");

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
            return this.Equals(obj as BusinessRulesSchemaCreateRequest);
        }

        /// <summary>
        /// Returns true if BusinessRulesSchemaCreateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessRulesSchemaCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessRulesSchemaCreateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                if (this.JsonSchema != null)
                    hash = hash * 59 + this.JsonSchema.GetHashCode();

                return hash;
            }
        }
    }

}
