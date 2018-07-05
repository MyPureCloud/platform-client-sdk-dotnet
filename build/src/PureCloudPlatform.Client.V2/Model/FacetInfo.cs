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
    /// FacetInfo
    /// </summary>
    [DataContract]
    public partial class FacetInfo :  IEquatable<FacetInfo>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FacetInfo" /> class.
        /// </summary>
        /// <param name="Name">The name of the field that was faceted on..</param>
        /// <param name="Entries">The entries resulting from this facet..</param>
        public FacetInfo(string Name = null, List<Entry> Entries = null)
        {
            this.Name = Name;
            this.Entries = Entries;
            
        }
        
        
        
        /// <summary>
        /// The name of the field that was faceted on.
        /// </summary>
        /// <value>The name of the field that was faceted on.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The entries resulting from this facet.
        /// </summary>
        /// <value>The entries resulting from this facet.</value>
        [DataMember(Name="entries", EmitDefaultValue=false)]
        public List<Entry> Entries { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FacetInfo {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Entries: ").Append(Entries).Append("\n");
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
            return this.Equals(obj as FacetInfo);
        }

        /// <summary>
        /// Returns true if FacetInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of FacetInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FacetInfo other)
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
                    this.Entries == other.Entries ||
                    this.Entries != null &&
                    this.Entries.SequenceEqual(other.Entries)
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
                
                if (this.Entries != null)
                    hash = hash * 59 + this.Entries.GetHashCode();
                
                return hash;
            }
        }
    }

}
