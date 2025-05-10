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
    /// OutputValue
    /// </summary>
    [DataContract]
    public partial class OutputValue :  IEquatable<OutputValue>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputValue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OutputValue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputValue" /> class.
        /// </summary>
        /// <param name="SchemaPropertyKey">The contract schema property key that describes the output value of this column. (required).</param>
        /// <param name="Properties">The nested output properties of this column that will be provided by each row, if any..</param>
        public OutputValue(string SchemaPropertyKey = null, List<OutputValue> Properties = null)
        {
            this.SchemaPropertyKey = SchemaPropertyKey;
            this.Properties = Properties;
            
        }
        


        /// <summary>
        /// The contract schema property key that describes the output value of this column.
        /// </summary>
        /// <value>The contract schema property key that describes the output value of this column.</value>
        [DataMember(Name="schemaPropertyKey", EmitDefaultValue=false)]
        public string SchemaPropertyKey { get; set; }



        /// <summary>
        /// The nested output properties of this column that will be provided by each row, if any.
        /// </summary>
        /// <value>The nested output properties of this column that will be provided by each row, if any.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<OutputValue> Properties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputValue {\n");

            sb.Append("  SchemaPropertyKey: ").Append(SchemaPropertyKey).Append("\n");
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
            return this.Equals(obj as OutputValue);
        }

        /// <summary>
        /// Returns true if OutputValue instances are equal
        /// </summary>
        /// <param name="other">Instance of OutputValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutputValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SchemaPropertyKey == other.SchemaPropertyKey ||
                    this.SchemaPropertyKey != null &&
                    this.SchemaPropertyKey.Equals(other.SchemaPropertyKey)
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
                if (this.SchemaPropertyKey != null)
                    hash = hash * 59 + this.SchemaPropertyKey.GetHashCode();

                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();

                return hash;
            }
        }
    }

}
