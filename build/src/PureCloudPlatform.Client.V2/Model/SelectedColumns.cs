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
    /// SelectedColumns
    /// </summary>
    [DataContract]
    public partial class SelectedColumns :  IEquatable<SelectedColumns>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedColumns" /> class.
        /// </summary>
        /// <param name="ColumnOrder">Indicates the order/position of the selected column.</param>
        /// <param name="ColumnName">Indicates enum name of the column from the export view.</param>
        public SelectedColumns(int? ColumnOrder = null, string ColumnName = null)
        {
            this.ColumnOrder = ColumnOrder;
            this.ColumnName = ColumnName;
            
        }
        


        /// <summary>
        /// Indicates the order/position of the selected column
        /// </summary>
        /// <value>Indicates the order/position of the selected column</value>
        [DataMember(Name="columnOrder", EmitDefaultValue=false)]
        public int? ColumnOrder { get; set; }



        /// <summary>
        /// Indicates enum name of the column from the export view
        /// </summary>
        /// <value>Indicates enum name of the column from the export view</value>
        [DataMember(Name="columnName", EmitDefaultValue=false)]
        public string ColumnName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectedColumns {\n");

            sb.Append("  ColumnOrder: ").Append(ColumnOrder).Append("\n");
            sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
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
            return this.Equals(obj as SelectedColumns);
        }

        /// <summary>
        /// Returns true if SelectedColumns instances are equal
        /// </summary>
        /// <param name="other">Instance of SelectedColumns to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectedColumns other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ColumnOrder == other.ColumnOrder ||
                    this.ColumnOrder != null &&
                    this.ColumnOrder.Equals(other.ColumnOrder)
                ) &&
                (
                    this.ColumnName == other.ColumnName ||
                    this.ColumnName != null &&
                    this.ColumnName.Equals(other.ColumnName)
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
                if (this.ColumnOrder != null)
                    hash = hash * 59 + this.ColumnOrder.GetHashCode();

                if (this.ColumnName != null)
                    hash = hash * 59 + this.ColumnName.GetHashCode();

                return hash;
            }
        }
    }

}
