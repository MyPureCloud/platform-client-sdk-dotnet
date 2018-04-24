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
    /// Represents the optional integration registry support for a listing
    /// </summary>
    [DataContract]
    public partial class AppFoundryListingRegistryInfo :  IEquatable<AppFoundryListingRegistryInfo>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AppFoundryListingRegistryInfo" /> class.
        /// </summary>
        
        
        /// <param name="Id">The ID of the integration registry entry that is represented by the listing.</param>
        
        
        
        /// <param name="Regions">Supported regions where the listing may be installed.</param>
        
        
        public AppFoundryListingRegistryInfo(string Id = null, List<string> Regions = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this.Regions = Regions;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The ID of the integration registry entry that is represented by the listing
        /// </summary>
        /// <value>The ID of the integration registry entry that is represented by the listing</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Supported regions where the listing may be installed
        /// </summary>
        /// <value>Supported regions where the listing may be installed</value>
        [DataMember(Name="regions", EmitDefaultValue=false)]
        public List<string> Regions { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppFoundryListingRegistryInfo {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Regions: ").Append(Regions).Append("\n");
            
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
            return this.Equals(obj as AppFoundryListingRegistryInfo);
        }

        /// <summary>
        /// Returns true if AppFoundryListingRegistryInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of AppFoundryListingRegistryInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppFoundryListingRegistryInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Regions == other.Regions ||
                    this.Regions != null &&
                    this.Regions.SequenceEqual(other.Regions)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Regions != null)
                    hash = hash * 59 + this.Regions.GetHashCode();
                
                return hash;
            }
        }
    }

}
