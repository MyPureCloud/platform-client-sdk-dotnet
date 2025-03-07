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
    /// Defines a SCIM resource type&#39;s schema extension.
    /// </summary>
    [DataContract]
    public partial class ScimConfigResourceTypeSchemaExtension :  IEquatable<ScimConfigResourceTypeSchemaExtension>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimConfigResourceTypeSchemaExtension" /> class.
        /// </summary>
        public ScimConfigResourceTypeSchemaExtension()
        {
            
        }
        


        /// <summary>
        /// The URI of an extended schema, for example, \&quot;urn:edu:2.0:Staff\&quot;. Must be equal to the \&quot;id\&quot; attribute of a schema.
        /// </summary>
        /// <value>The URI of an extended schema, for example, \&quot;urn:edu:2.0:Staff\&quot;. Must be equal to the \&quot;id\&quot; attribute of a schema.</value>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public string Schema { get; private set; }



        /// <summary>
        /// Indicates whether a schema extension is required.
        /// </summary>
        /// <value>Indicates whether a schema extension is required.</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimConfigResourceTypeSchemaExtension {\n");

            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
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
            return this.Equals(obj as ScimConfigResourceTypeSchemaExtension);
        }

        /// <summary>
        /// Returns true if ScimConfigResourceTypeSchemaExtension instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimConfigResourceTypeSchemaExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimConfigResourceTypeSchemaExtension other)
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
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
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

                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();

                return hash;
            }
        }
    }

}
