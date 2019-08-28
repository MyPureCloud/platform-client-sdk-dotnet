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
    /// User&#39;s Manager
    /// </summary>
    [DataContract]
    public partial class Manager :  IEquatable<Manager>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Manager" /> class.
        /// </summary>
        /// <param name="Value">The ID of the manager..</param>
        public Manager(string Value = null)
        {
            this.Value = Value;
            
        }
        
        
        
        /// <summary>
        /// The ID of the manager.
        /// </summary>
        /// <value>The ID of the manager.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        
        
        
        /// <summary>
        /// URI for Manager User record.
        /// </summary>
        /// <value>URI for Manager User record.</value>
        [DataMember(Name="$ref", EmitDefaultValue=false)]
        public string _Ref { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Manager {\n");
            
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  _Ref: ").Append(_Ref).Append("\n");
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
            return this.Equals(obj as Manager);
        }

        /// <summary>
        /// Returns true if Manager instances are equal
        /// </summary>
        /// <param name="other">Instance of Manager to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Manager other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this._Ref == other._Ref ||
                    this._Ref != null &&
                    this._Ref.Equals(other._Ref)
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
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this._Ref != null)
                    hash = hash * 59 + this._Ref.GetHashCode();
                
                return hash;
            }
        }
    }

}
