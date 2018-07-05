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
    /// Specifies the requirements for a credential that can be provided for configuring an integration
    /// </summary>
    [DataContract]
    public partial class CredentialSpecification :  IEquatable<CredentialSpecification>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialSpecification" /> class.
        /// </summary>
        /// <param name="CredentialTypes">List of acceptable credential types that can be provided for this credential..</param>
        public CredentialSpecification(List<string> CredentialTypes = null)
        {
            this.CredentialTypes = CredentialTypes;
            
        }
        
        
        
        /// <summary>
        /// Indicates if the credential must be provided in order for the integration configuration to be valid.
        /// </summary>
        /// <value>Indicates if the credential must be provided in order for the integration configuration to be valid.</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; private set; }
        
        
        
        /// <summary>
        /// Title describing the usage for this credential.
        /// </summary>
        /// <value>Title describing the usage for this credential.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; private set; }
        
        
        
        /// <summary>
        /// List of acceptable credential types that can be provided for this credential.
        /// </summary>
        /// <value>List of acceptable credential types that can be provided for this credential.</value>
        [DataMember(Name="credentialTypes", EmitDefaultValue=false)]
        public List<string> CredentialTypes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CredentialSpecification {\n");
            
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  CredentialTypes: ").Append(CredentialTypes).Append("\n");
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
            return this.Equals(obj as CredentialSpecification);
        }

        /// <summary>
        /// Returns true if CredentialSpecification instances are equal
        /// </summary>
        /// <param name="other">Instance of CredentialSpecification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CredentialSpecification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.CredentialTypes == other.CredentialTypes ||
                    this.CredentialTypes != null &&
                    this.CredentialTypes.SequenceEqual(other.CredentialTypes)
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
                
                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();
                
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                
                if (this.CredentialTypes != null)
                    hash = hash * 59 + this.CredentialTypes.GetHashCode();
                
                return hash;
            }
        }
    }

}
