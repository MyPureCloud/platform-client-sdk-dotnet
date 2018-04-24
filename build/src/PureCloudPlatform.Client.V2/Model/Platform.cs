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
    /// Represents the supported platforms for an AppFoundry listing
    /// </summary>
    [DataContract]
    public partial class Platform :  IEquatable<Platform>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Platform" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Platform() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Platform" /> class.
        /// </summary>
        
        
        /// <param name="Name">Name of the platform (required).</param>
        
        
        
        /// <param name="Subcategories">Platform subcategories, eg, on-prem or cloud.</param>
        
        
        public Platform(string Name = null, List<string> Subcategories = null)
        {
            
            
            
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Platform and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Subcategories = Subcategories;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Name of the platform
        /// </summary>
        /// <value>Name of the platform</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Platform subcategories, eg, on-prem or cloud
        /// </summary>
        /// <value>Platform subcategories, eg, on-prem or cloud</value>
        [DataMember(Name="subcategories", EmitDefaultValue=false)]
        public List<string> Subcategories { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Platform {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  Subcategories: ").Append(Subcategories).Append("\n");
            
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
            return this.Equals(obj as Platform);
        }

        /// <summary>
        /// Returns true if Platform instances are equal
        /// </summary>
        /// <param name="other">Instance of Platform to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Platform other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Subcategories == other.Subcategories ||
                    this.Subcategories != null &&
                    this.Subcategories.SequenceEqual(other.Subcategories)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Subcategories != null)
                    hash = hash * 59 + this.Subcategories.GetHashCode();
                
                return hash;
            }
        }
    }

}
