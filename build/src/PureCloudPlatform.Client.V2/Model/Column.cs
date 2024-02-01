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
    /// Column
    /// </summary>
    [DataContract]
    public partial class Column :  IEquatable<Column>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Column" /> class.
        /// </summary>
        /// <param name="ColumnName">Column name. Mandatory for Fixed position/length file format..</param>
        /// <param name="ColumnNumber">0 based column number in delimited file format.</param>
        /// <param name="StartPosition">Zero-based position of the first column's character. Mandatory for Fixed position/length file format..</param>
        /// <param name="Length">Column width. Mandatory for Fixed position/length file format..</param>
        public Column(string ColumnName = null, int? ColumnNumber = null, int? StartPosition = null, int? Length = null)
        {
            this.ColumnName = ColumnName;
            this.ColumnNumber = ColumnNumber;
            this.StartPosition = StartPosition;
            this.Length = Length;
            
        }
        


        /// <summary>
        /// Column name. Mandatory for Fixed position/length file format.
        /// </summary>
        /// <value>Column name. Mandatory for Fixed position/length file format.</value>
        [DataMember(Name="columnName", EmitDefaultValue=false)]
        public string ColumnName { get; set; }



        /// <summary>
        /// 0 based column number in delimited file format
        /// </summary>
        /// <value>0 based column number in delimited file format</value>
        [DataMember(Name="columnNumber", EmitDefaultValue=false)]
        public int? ColumnNumber { get; set; }



        /// <summary>
        /// Zero-based position of the first column's character. Mandatory for Fixed position/length file format.
        /// </summary>
        /// <value>Zero-based position of the first column's character. Mandatory for Fixed position/length file format.</value>
        [DataMember(Name="startPosition", EmitDefaultValue=false)]
        public int? StartPosition { get; set; }



        /// <summary>
        /// Column width. Mandatory for Fixed position/length file format.
        /// </summary>
        /// <value>Column width. Mandatory for Fixed position/length file format.</value>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public int? Length { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Column {\n");

            sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
            sb.Append("  ColumnNumber: ").Append(ColumnNumber).Append("\n");
            sb.Append("  StartPosition: ").Append(StartPosition).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
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
            return this.Equals(obj as Column);
        }

        /// <summary>
        /// Returns true if Column instances are equal
        /// </summary>
        /// <param name="other">Instance of Column to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Column other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ColumnName == other.ColumnName ||
                    this.ColumnName != null &&
                    this.ColumnName.Equals(other.ColumnName)
                ) &&
                (
                    this.ColumnNumber == other.ColumnNumber ||
                    this.ColumnNumber != null &&
                    this.ColumnNumber.Equals(other.ColumnNumber)
                ) &&
                (
                    this.StartPosition == other.StartPosition ||
                    this.StartPosition != null &&
                    this.StartPosition.Equals(other.StartPosition)
                ) &&
                (
                    this.Length == other.Length ||
                    this.Length != null &&
                    this.Length.Equals(other.Length)
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
                if (this.ColumnName != null)
                    hash = hash * 59 + this.ColumnName.GetHashCode();

                if (this.ColumnNumber != null)
                    hash = hash * 59 + this.ColumnNumber.GetHashCode();

                if (this.StartPosition != null)
                    hash = hash * 59 + this.StartPosition.GetHashCode();

                if (this.Length != null)
                    hash = hash * 59 + this.Length.GetHashCode();

                return hash;
            }
        }
    }

}
