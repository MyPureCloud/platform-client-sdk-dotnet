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
    /// Represents a category used to filter listings within the AppFoundry
    /// </summary>
    [DataContract]
    public partial class AppFoundryListingCategory :  IEquatable<AppFoundryListingCategory>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AppFoundryListingCategory" /> class.
        /// </summary>
        
        
        /// <param name="Name">Name of the category.</param>
        
        
        
        /// <param name="SubCategories">Subcategories under this category.</param>
        
        
        public AppFoundryListingCategory(string Name = null, List<string> SubCategories = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
this.SubCategories = SubCategories;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Name of the category
        /// </summary>
        /// <value>Name of the category</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Subcategories under this category
        /// </summary>
        /// <value>Subcategories under this category</value>
        [DataMember(Name="subCategories", EmitDefaultValue=false)]
        public List<string> SubCategories { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppFoundryListingCategory {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  SubCategories: ").Append(SubCategories).Append("\n");
            
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
            return this.Equals(obj as AppFoundryListingCategory);
        }

        /// <summary>
        /// Returns true if AppFoundryListingCategory instances are equal
        /// </summary>
        /// <param name="other">Instance of AppFoundryListingCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppFoundryListingCategory other)
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
                    this.SubCategories == other.SubCategories ||
                    this.SubCategories != null &&
                    this.SubCategories.SequenceEqual(other.SubCategories)
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
                
                if (this.SubCategories != null)
                    hash = hash * 59 + this.SubCategories.GetHashCode();
                
                return hash;
            }
        }
    }

}
