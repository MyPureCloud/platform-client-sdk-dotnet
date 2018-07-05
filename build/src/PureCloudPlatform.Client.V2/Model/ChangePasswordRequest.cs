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
    /// ChangePasswordRequest
    /// </summary>
    [DataContract]
    public partial class ChangePasswordRequest :  IEquatable<ChangePasswordRequest>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChangePasswordRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordRequest" /> class.
        /// </summary>
        /// <param name="NewPassword">The new password (required).</param>
        public ChangePasswordRequest(string NewPassword = null)
        {
            
        }
        
        
        
        /// <summary>
        /// The new password
        /// </summary>
        /// <value>The new password</value>
        [DataMember(Name="newPassword", EmitDefaultValue=false)]
        public string NewPassword { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangePasswordRequest {\n");
            
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
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
            return this.Equals(obj as ChangePasswordRequest);
        }

        /// <summary>
        /// Returns true if ChangePasswordRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ChangePasswordRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangePasswordRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.NewPassword == other.NewPassword ||
                    this.NewPassword != null &&
                    this.NewPassword.Equals(other.NewPassword)
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
                
                if (this.NewPassword != null)
                    hash = hash * 59 + this.NewPassword.GetHashCode();
                
                return hash;
            }
        }
    }

}
