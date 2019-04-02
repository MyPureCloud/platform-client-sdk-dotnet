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
    /// CustomEventAttribute
    /// </summary>
    [DataContract]
    public partial class CustomEventAttribute :  IEquatable<CustomEventAttribute>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEventAttribute" /> class.
        /// </summary>
        /// <param name="DataType">The data type of the custom attribute..</param>
        /// <param name="Value">The value of the custom attribute..</param>
        public CustomEventAttribute(string DataType = null, string Value = null)
        {
            this.DataType = DataType;
            this.Value = Value;
            
        }
        
        
        
        /// <summary>
        /// The data type of the custom attribute.
        /// </summary>
        /// <value>The data type of the custom attribute.</value>
        [DataMember(Name="dataType", EmitDefaultValue=false)]
        public string DataType { get; set; }
        
        
        
        /// <summary>
        /// The value of the custom attribute.
        /// </summary>
        /// <value>The value of the custom attribute.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomEventAttribute {\n");
            
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as CustomEventAttribute);
        }

        /// <summary>
        /// Returns true if CustomEventAttribute instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomEventAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomEventAttribute other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DataType == other.DataType ||
                    this.DataType != null &&
                    this.DataType.Equals(other.DataType)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                
                if (this.DataType != null)
                    hash = hash * 59 + this.DataType.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                return hash;
            }
        }
    }

}
