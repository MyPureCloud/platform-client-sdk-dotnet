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
    /// LicenseOrgToggle
    /// </summary>
    [DataContract]
    public partial class LicenseOrgToggle :  IEquatable<LicenseOrgToggle>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseOrgToggle" /> class.
        /// </summary>
        
        
        /// <param name="FeatureName">FeatureName.</param>
        
        
        
        /// <param name="Enabled">Enabled.</param>
        
        
        public LicenseOrgToggle(string FeatureName = null, bool? Enabled = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.FeatureName = FeatureName;
            
            
            
            
            
            
            
            
this.Enabled = Enabled;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets FeatureName
        /// </summary>
        [DataMember(Name="featureName", EmitDefaultValue=false)]
        public string FeatureName { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicenseOrgToggle {\n");
            
            sb.Append("  FeatureName: ").Append(FeatureName).Append("\n");
            
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            
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
            return this.Equals(obj as LicenseOrgToggle);
        }

        /// <summary>
        /// Returns true if LicenseOrgToggle instances are equal
        /// </summary>
        /// <param name="other">Instance of LicenseOrgToggle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicenseOrgToggle other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FeatureName == other.FeatureName ||
                    this.FeatureName != null &&
                    this.FeatureName.Equals(other.FeatureName)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
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
                
                if (this.FeatureName != null)
                    hash = hash * 59 + this.FeatureName.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                return hash;
            }
        }
    }

}
