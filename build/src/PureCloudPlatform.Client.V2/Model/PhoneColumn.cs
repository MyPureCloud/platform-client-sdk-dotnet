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
    /// PhoneColumn
    /// </summary>
    [DataContract]
    public partial class PhoneColumn :  IEquatable<PhoneColumn>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneColumn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PhoneColumn() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneColumn" /> class.
        /// </summary>
        /// <param name="ColumnName">The name of the phone column. (required).</param>
        /// <param name="Type">The type of the phone column. For example, &#39;cell&#39; or &#39;home&#39;. (required).</param>
        public PhoneColumn(string ColumnName = null, string Type = null)
        {
            
        }
        
        
        
        /// <summary>
        /// The name of the phone column.
        /// </summary>
        /// <value>The name of the phone column.</value>
        [DataMember(Name="columnName", EmitDefaultValue=false)]
        public string ColumnName { get; set; }
        
        
        
        /// <summary>
        /// The type of the phone column. For example, &#39;cell&#39; or &#39;home&#39;.
        /// </summary>
        /// <value>The type of the phone column. For example, &#39;cell&#39; or &#39;home&#39;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneColumn {\n");
            
            sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PhoneColumn);
        }

        /// <summary>
        /// Returns true if PhoneColumn instances are equal
        /// </summary>
        /// <param name="other">Instance of PhoneColumn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneColumn other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                return hash;
            }
        }
    }

}
