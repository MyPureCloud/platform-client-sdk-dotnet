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
    /// SignedData
    /// </summary>
    [DataContract]
    public partial class SignedData :  IEquatable<SignedData>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SignedData" /> class.
        /// </summary>
        
        
        /// <param name="Jwt">Jwt.</param>
        
        
        public SignedData(string Jwt = null)
        {
            
            
            
            
            
            
            
            
            
            
this.Jwt = Jwt;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Jwt
        /// </summary>
        [DataMember(Name="jwt", EmitDefaultValue=false)]
        public string Jwt { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignedData {\n");
            
            sb.Append("  Jwt: ").Append(Jwt).Append("\n");
            
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
            return this.Equals(obj as SignedData);
        }

        /// <summary>
        /// Returns true if SignedData instances are equal
        /// </summary>
        /// <param name="other">Instance of SignedData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignedData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Jwt == other.Jwt ||
                    this.Jwt != null &&
                    this.Jwt.Equals(other.Jwt)
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
                
                if (this.Jwt != null)
                    hash = hash * 59 + this.Jwt.GetHashCode();
                
                return hash;
            }
        }
    }

}
