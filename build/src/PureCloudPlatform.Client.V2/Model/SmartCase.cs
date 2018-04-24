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
    /// Represents a suggested use case for an AppFoundry listing
    /// </summary>
    [DataContract]
    public partial class SmartCase :  IEquatable<SmartCase>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SmartCase" /> class.
        /// </summary>
        
        
        /// <param name="Title">Title of the use case.</param>
        
        
        
        /// <param name="Description">Description of how the listing meets the use case.</param>
        
        
        public SmartCase(LocalizedField Title = null, LocalizedField Description = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Title = Title;
            
            
            
            
            
            
            
            
this.Description = Description;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Title of the use case
        /// </summary>
        /// <value>Title of the use case</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public LocalizedField Title { get; set; }
        
        
        
        /// <summary>
        /// Description of how the listing meets the use case
        /// </summary>
        /// <value>Description of how the listing meets the use case</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public LocalizedField Description { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartCase {\n");
            
            sb.Append("  Title: ").Append(Title).Append("\n");
            
            sb.Append("  Description: ").Append(Description).Append("\n");
            
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
            return this.Equals(obj as SmartCase);
        }

        /// <summary>
        /// Returns true if SmartCase instances are equal
        /// </summary>
        /// <param name="other">Instance of SmartCase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmartCase other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                return hash;
            }
        }
    }

}
