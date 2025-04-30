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
    /// DataSchemaRef
    /// </summary>
    [DataContract]
    public partial class DataSchemaRef :  IEquatable<DataSchemaRef>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSchemaRef" /> class.
        /// </summary>
        /// <param name="Ref">Ref.</param>
        public DataSchemaRef(string Ref = null)
        {
            this.Ref = Ref;
            
        }
        


        /// <summary>
        /// Gets or Sets Ref
        /// </summary>
        [DataMember(Name="$ref", EmitDefaultValue=false)]
        public string Ref { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataSchemaRef {\n");

            sb.Append("  Ref: ").Append(Ref).Append("\n");
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
            return this.Equals(obj as DataSchemaRef);
        }

        /// <summary>
        /// Returns true if DataSchemaRef instances are equal
        /// </summary>
        /// <param name="other">Instance of DataSchemaRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSchemaRef other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Ref == other.Ref ||
                    this.Ref != null &&
                    this.Ref.Equals(other.Ref)
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
                if (this.Ref != null)
                    hash = hash * 59 + this.Ref.GetHashCode();

                return hash;
            }
        }
    }

}
