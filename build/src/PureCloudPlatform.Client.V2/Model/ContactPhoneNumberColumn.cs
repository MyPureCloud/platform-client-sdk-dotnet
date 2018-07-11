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
    /// ContactPhoneNumberColumn
    /// </summary>
    [DataContract]
    public partial class ContactPhoneNumberColumn :  IEquatable<ContactPhoneNumberColumn>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactPhoneNumberColumn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactPhoneNumberColumn() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactPhoneNumberColumn" /> class.
        /// </summary>
        /// <param name="ColumnName">The name of the phone column. (required).</param>
        /// <param name="Type">Indicates the type of the phone column. For example, &#39;cell&#39; or &#39;home&#39;. (required).</param>
        /// <param name="CallableTimeColumn">A column that indicates the timezone to use for a given contact when checking callable times. Not allowed if &#39;automaticTimeZoneMapping&#39; is set to true..</param>
        public ContactPhoneNumberColumn(string ColumnName = null, string Type = null, string CallableTimeColumn = null)
        {
            this.ColumnName = ColumnName;
            this.Type = Type;
            this.CallableTimeColumn = CallableTimeColumn;
            
        }
        
        
        
        /// <summary>
        /// The name of the phone column.
        /// </summary>
        /// <value>The name of the phone column.</value>
        [DataMember(Name="columnName", EmitDefaultValue=false)]
        public string ColumnName { get; set; }
        
        
        
        /// <summary>
        /// Indicates the type of the phone column. For example, &#39;cell&#39; or &#39;home&#39;.
        /// </summary>
        /// <value>Indicates the type of the phone column. For example, &#39;cell&#39; or &#39;home&#39;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        
        
        
        /// <summary>
        /// A column that indicates the timezone to use for a given contact when checking callable times. Not allowed if &#39;automaticTimeZoneMapping&#39; is set to true.
        /// </summary>
        /// <value>A column that indicates the timezone to use for a given contact when checking callable times. Not allowed if &#39;automaticTimeZoneMapping&#39; is set to true.</value>
        [DataMember(Name="callableTimeColumn", EmitDefaultValue=false)]
        public string CallableTimeColumn { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactPhoneNumberColumn {\n");
            
            sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CallableTimeColumn: ").Append(CallableTimeColumn).Append("\n");
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
            return this.Equals(obj as ContactPhoneNumberColumn);
        }

        /// <summary>
        /// Returns true if ContactPhoneNumberColumn instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactPhoneNumberColumn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactPhoneNumberColumn other)
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
                ) &&
                (
                    this.CallableTimeColumn == other.CallableTimeColumn ||
                    this.CallableTimeColumn != null &&
                    this.CallableTimeColumn.Equals(other.CallableTimeColumn)
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
                
                if (this.CallableTimeColumn != null)
                    hash = hash * 59 + this.CallableTimeColumn.GetHashCode();
                
                return hash;
            }
        }
    }

}
