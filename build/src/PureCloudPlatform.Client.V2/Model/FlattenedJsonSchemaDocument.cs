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
    /// JSON schema that defines the transformed result that will be sent back to the caller. The schema is transformed based on Architect&#39;s flattened format. If the &#39;flatten&#39; query parameter is supplied as true, this field will be returned.
    /// </summary>
    [DataContract]
    public partial class FlattenedJsonSchemaDocument :  IEquatable<FlattenedJsonSchemaDocument>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedJsonSchemaDocument" /> class.
        /// </summary>
        /// <param name="Schema">Schema.</param>
        /// <param name="ArrayProperties">Properties in the original document that were arrays.</param>
        public FlattenedJsonSchemaDocument(JsonSchemaDocument Schema = null, List<string> ArrayProperties = null)
        {
            this.Schema = Schema;
            this.ArrayProperties = ArrayProperties;
            
        }
        


        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public JsonSchemaDocument Schema { get; set; }



        /// <summary>
        /// Properties in the original document that were arrays
        /// </summary>
        /// <value>Properties in the original document that were arrays</value>
        [DataMember(Name="arrayProperties", EmitDefaultValue=false)]
        public List<string> ArrayProperties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlattenedJsonSchemaDocument {\n");

            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  ArrayProperties: ").Append(ArrayProperties).Append("\n");
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
            return this.Equals(obj as FlattenedJsonSchemaDocument);
        }

        /// <summary>
        /// Returns true if FlattenedJsonSchemaDocument instances are equal
        /// </summary>
        /// <param name="other">Instance of FlattenedJsonSchemaDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlattenedJsonSchemaDocument other)
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
                    this.ArrayProperties == other.ArrayProperties ||
                    this.ArrayProperties != null &&
                    this.ArrayProperties.SequenceEqual(other.ArrayProperties)
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

                if (this.ArrayProperties != null)
                    hash = hash * 59 + this.ArrayProperties.GetHashCode();

                return hash;
            }
        }
    }

}
