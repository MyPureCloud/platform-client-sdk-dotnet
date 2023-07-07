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
    /// DocumentBodyTableRowBlock
    /// </summary>
    [DataContract]
    public partial class DocumentBodyTableRowBlock :  IEquatable<DocumentBodyTableRowBlock>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBodyTableRowBlock" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentBodyTableRowBlock() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBodyTableRowBlock" /> class.
        /// </summary>
        /// <param name="Cells">The list of cells for the table. (required).</param>
        /// <param name="Properties">The properties for the table rows..</param>
        public DocumentBodyTableRowBlock(List<DocumentBodyTableCellBlock> Cells = null, DocumentBodyTableRowBlockProperties Properties = null)
        {
            this.Cells = Cells;
            this.Properties = Properties;
            
        }
        


        /// <summary>
        /// The list of cells for the table.
        /// </summary>
        /// <value>The list of cells for the table.</value>
        [DataMember(Name="cells", EmitDefaultValue=false)]
        public List<DocumentBodyTableCellBlock> Cells { get; set; }



        /// <summary>
        /// The properties for the table rows.
        /// </summary>
        /// <value>The properties for the table rows.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public DocumentBodyTableRowBlockProperties Properties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentBodyTableRowBlock {\n");

            sb.Append("  Cells: ").Append(Cells).Append("\n");
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
            return this.Equals(obj as DocumentBodyTableRowBlock);
        }

        /// <summary>
        /// Returns true if DocumentBodyTableRowBlock instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentBodyTableRowBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentBodyTableRowBlock other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Cells == other.Cells ||
                    this.Cells != null &&
                    this.Cells.SequenceEqual(other.Cells)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.Equals(other.Properties)
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
                if (this.Cells != null)
                    hash = hash * 59 + this.Cells.GetHashCode();

                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();

                return hash;
            }
        }
    }

}
