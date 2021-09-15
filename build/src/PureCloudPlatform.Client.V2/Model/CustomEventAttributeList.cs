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
    /// CustomEventAttributeList
    /// </summary>
    [DataContract]
    public partial class CustomEventAttributeList :  IEquatable<CustomEventAttributeList>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEventAttributeList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomEventAttributeList() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEventAttributeList" /> class.
        /// </summary>
        /// <param name="DataType">The data type of the custom attributes. (required).</param>
        /// <param name="Values">The list of custom event attribute values. (required).</param>
        public CustomEventAttributeList(string DataType = null, List<string> Values = null)
        {
            this.DataType = DataType;
            this.Values = Values;
            
        }
        
        
        
        /// <summary>
        /// The data type of the custom attributes.
        /// </summary>
        /// <value>The data type of the custom attributes.</value>
        [DataMember(Name="dataType", EmitDefaultValue=false)]
        public string DataType { get; set; }
        
        
        
        /// <summary>
        /// The list of custom event attribute values.
        /// </summary>
        /// <value>The list of custom event attribute values.</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomEventAttributeList {\n");
            
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(obj as CustomEventAttributeList);
        }

        /// <summary>
        /// Returns true if CustomEventAttributeList instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomEventAttributeList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomEventAttributeList other)
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
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
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
                
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                
                return hash;
            }
        }
    }

}
