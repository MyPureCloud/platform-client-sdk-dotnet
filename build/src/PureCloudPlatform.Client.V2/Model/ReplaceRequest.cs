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
    /// ReplaceRequest
    /// </summary>
    [DataContract]
    public partial class ReplaceRequest :  IEquatable<ReplaceRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceRequest" /> class.
        /// </summary>
        
        
        /// <param name="ChangeNumber">ChangeNumber.</param>
        
        
        
        /// <param name="Name">Name.</param>
        
        
        
        /// <param name="AuthToken">AuthToken.</param>
        
        
        public ReplaceRequest(int? ChangeNumber = null, string Name = null, string AuthToken = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.ChangeNumber = ChangeNumber;
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
this.AuthToken = AuthToken;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets ChangeNumber
        /// </summary>
        [DataMember(Name="changeNumber", EmitDefaultValue=false)]
        public int? ChangeNumber { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AuthToken
        /// </summary>
        [DataMember(Name="authToken", EmitDefaultValue=false)]
        public string AuthToken { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplaceRequest {\n");
            
            sb.Append("  ChangeNumber: ").Append(ChangeNumber).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  AuthToken: ").Append(AuthToken).Append("\n");
            
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
            return this.Equals(obj as ReplaceRequest);
        }

        /// <summary>
        /// Returns true if ReplaceRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ReplaceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplaceRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ChangeNumber == other.ChangeNumber ||
                    this.ChangeNumber != null &&
                    this.ChangeNumber.Equals(other.ChangeNumber)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.AuthToken == other.AuthToken ||
                    this.AuthToken != null &&
                    this.AuthToken.Equals(other.AuthToken)
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
                
                if (this.ChangeNumber != null)
                    hash = hash * 59 + this.ChangeNumber.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.AuthToken != null)
                    hash = hash * 59 + this.AuthToken.GetHashCode();
                
                return hash;
            }
        }
    }

}
