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
    /// Contains information about the substitutions associated with a response.
    /// </summary>
    [DataContract]
    public partial class ResponseSubstitution :  IEquatable<ResponseSubstitution>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSubstitution" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponseSubstitution() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSubstitution" /> class.
        /// </summary>
        /// <param name="Id">Response substitution identifier. (required).</param>
        /// <param name="Description">Response substitution description..</param>
        /// <param name="DefaultValue">Response substitution default value..</param>
        public ResponseSubstitution(string Id = null, string Description = null, string DefaultValue = null)
        {
            this.Description = Description;
            this.DefaultValue = DefaultValue;
            
        }
        
        
        
        /// <summary>
        /// Response substitution identifier.
        /// </summary>
        /// <value>Response substitution identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Response substitution description.
        /// </summary>
        /// <value>Response substitution description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Response substitution default value.
        /// </summary>
        /// <value>Response substitution default value.</value>
        [DataMember(Name="defaultValue", EmitDefaultValue=false)]
        public string DefaultValue { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseSubstitution {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
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
            return this.Equals(obj as ResponseSubstitution);
        }

        /// <summary>
        /// Returns true if ResponseSubstitution instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseSubstitution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseSubstitution other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.DefaultValue == other.DefaultValue ||
                    this.DefaultValue != null &&
                    this.DefaultValue.Equals(other.DefaultValue)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.DefaultValue != null)
                    hash = hash * 59 + this.DefaultValue.GetHashCode();
                
                return hash;
            }
        }
    }

}
