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
    /// External Identifiers of user. The external identifier must be unique within the organization and the &#39;authority&#39;
    /// </summary>
    [DataContract]
    public partial class ScimGenesysUserExternalId :  IEquatable<ScimGenesysUserExternalId>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimGenesysUserExternalId" /> class.
        /// </summary>
        /// <param name="Authority">Authority, or scope, of \&quot;externalId\&quot;. Allows multiple external identifiers to be defined. Represents the source of the external identifier..</param>
        /// <param name="Value">Identifier of the user in an external system..</param>
        public ScimGenesysUserExternalId(string Authority = null, string Value = null)
        {
            this.Authority = Authority;
            this.Value = Value;
            
        }
        
        
        
        /// <summary>
        /// Authority, or scope, of \&quot;externalId\&quot;. Allows multiple external identifiers to be defined. Represents the source of the external identifier.
        /// </summary>
        /// <value>Authority, or scope, of \&quot;externalId\&quot;. Allows multiple external identifiers to be defined. Represents the source of the external identifier.</value>
        [DataMember(Name="authority", EmitDefaultValue=false)]
        public string Authority { get; set; }
        
        
        
        /// <summary>
        /// Identifier of the user in an external system.
        /// </summary>
        /// <value>Identifier of the user in an external system.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimGenesysUserExternalId {\n");
            
            sb.Append("  Authority: ").Append(Authority).Append("\n");
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
            return this.Equals(obj as ScimGenesysUserExternalId);
        }

        /// <summary>
        /// Returns true if ScimGenesysUserExternalId instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimGenesysUserExternalId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimGenesysUserExternalId other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Authority == other.Authority ||
                    this.Authority != null &&
                    this.Authority.Equals(other.Authority)
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
                
                if (this.Authority != null)
                    hash = hash * 59 + this.Authority.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                return hash;
            }
        }
    }

}
