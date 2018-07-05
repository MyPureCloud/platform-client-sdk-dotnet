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
    /// ContentSortItem
    /// </summary>
    [DataContract]
    public partial class ContentSortItem :  IEquatable<ContentSortItem>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentSortItem" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Ascending">Ascending.</param>
        public ContentSortItem(string Name = null, bool? Ascending = null)
        {
            this.Name = Name;
            this.Ascending = Ascending;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Ascending
        /// </summary>
        [DataMember(Name="ascending", EmitDefaultValue=false)]
        public bool? Ascending { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentSortItem {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ascending: ").Append(Ascending).Append("\n");
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
            return this.Equals(obj as ContentSortItem);
        }

        /// <summary>
        /// Returns true if ContentSortItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentSortItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentSortItem other)
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
                    this.Ascending == other.Ascending ||
                    this.Ascending != null &&
                    this.Ascending.Equals(other.Ascending)
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
                
                if (this.Ascending != null)
                    hash = hash * 59 + this.Ascending.GetHashCode();
                
                return hash;
            }
        }
    }

}
