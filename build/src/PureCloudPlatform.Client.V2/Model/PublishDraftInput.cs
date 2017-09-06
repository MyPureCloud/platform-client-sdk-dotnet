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
    /// Draft to be published
    /// </summary>
    [DataContract]
    public partial class PublishDraftInput :  IEquatable<PublishDraftInput>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishDraftInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PublishDraftInput() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishDraftInput" /> class.
        /// </summary>
        
        
        /// <param name="Version">The current draft version. (required).</param>
        
        
        public PublishDraftInput(int? Version = null)
        {
            
            
            
            // to ensure "Version" is required (not null)
            if (Version == null)
            {
                throw new InvalidDataException("Version is a required property for PublishDraftInput and cannot be null");
            }
            else
            {
                this.Version = Version;
            }
            
            
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The current draft version.
        /// </summary>
        /// <value>The current draft version.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublishDraftInput {\n");
            
            sb.Append("  Version: ").Append(Version).Append("\n");
            
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
            return this.Equals(obj as PublishDraftInput);
        }

        /// <summary>
        /// Returns true if PublishDraftInput instances are equal
        /// </summary>
        /// <param name="other">Instance of PublishDraftInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublishDraftInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                return hash;
            }
        }
    }

}
