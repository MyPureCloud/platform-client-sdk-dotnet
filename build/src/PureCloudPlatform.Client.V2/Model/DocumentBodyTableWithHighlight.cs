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
    /// DocumentBodyTableWithHighlight
    /// </summary>
    [DataContract]
    public partial class DocumentBodyTableWithHighlight :  IEquatable<DocumentBodyTableWithHighlight>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBodyTableWithHighlight" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentBodyTableWithHighlight() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBodyTableWithHighlight" /> class.
        /// </summary>
        /// <param name="Properties">The properties for the table..</param>
        /// <param name="Rows">The list of rows for the table. (required).</param>
        public DocumentBodyTableWithHighlight(DocumentBodyTableProperties Properties = null, List<DocumentBodyTableRowBlockWithHighlight> Rows = null)
        {
            this.Properties = Properties;
            this.Rows = Rows;
            
        }
        


        /// <summary>
        /// The properties for the table.
        /// </summary>
        /// <value>The properties for the table.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public DocumentBodyTableProperties Properties { get; set; }



        /// <summary>
        /// The list of rows for the table.
        /// </summary>
        /// <value>The list of rows for the table.</value>
        [DataMember(Name="rows", EmitDefaultValue=false)]
        public List<DocumentBodyTableRowBlockWithHighlight> Rows { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentBodyTableWithHighlight {\n");

            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
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
            return this.Equals(obj as DocumentBodyTableWithHighlight);
        }

        /// <summary>
        /// Returns true if DocumentBodyTableWithHighlight instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentBodyTableWithHighlight to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentBodyTableWithHighlight other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.Equals(other.Properties)
                ) &&
                (
                    this.Rows == other.Rows ||
                    this.Rows != null &&
                    this.Rows.SequenceEqual(other.Rows)
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
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();

                if (this.Rows != null)
                    hash = hash * 59 + this.Rows.GetHashCode();

                return hash;
            }
        }
    }

}
