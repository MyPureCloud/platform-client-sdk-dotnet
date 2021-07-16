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
    /// EmbeddedIntegration
    /// </summary>
    [DataContract]
    public partial class EmbeddedIntegration :  IEquatable<EmbeddedIntegration>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedIntegration" /> class.
        /// </summary>
        /// <param name="EnableWhitelist">EnableWhitelist.</param>
        /// <param name="DomainWhitelist">DomainWhitelist.</param>
        public EmbeddedIntegration(bool? EnableWhitelist = null, List<string> DomainWhitelist = null)
        {
            this.EnableWhitelist = EnableWhitelist;
            this.DomainWhitelist = DomainWhitelist;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets EnableWhitelist
        /// </summary>
        [DataMember(Name="enableWhitelist", EmitDefaultValue=false)]
        public bool? EnableWhitelist { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DomainWhitelist
        /// </summary>
        [DataMember(Name="domainWhitelist", EmitDefaultValue=false)]
        public List<string> DomainWhitelist { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedIntegration {\n");
            
            sb.Append("  EnableWhitelist: ").Append(EnableWhitelist).Append("\n");
            sb.Append("  DomainWhitelist: ").Append(DomainWhitelist).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as EmbeddedIntegration);
        }

        /// <summary>
        /// Returns true if EmbeddedIntegration instances are equal
        /// </summary>
        /// <param name="other">Instance of EmbeddedIntegration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmbeddedIntegration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EnableWhitelist == other.EnableWhitelist ||
                    this.EnableWhitelist != null &&
                    this.EnableWhitelist.Equals(other.EnableWhitelist)
                ) &&
                (
                    this.DomainWhitelist == other.DomainWhitelist ||
                    this.DomainWhitelist != null &&
                    this.DomainWhitelist.SequenceEqual(other.DomainWhitelist)
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
                
                if (this.EnableWhitelist != null)
                    hash = hash * 59 + this.EnableWhitelist.GetHashCode();
                
                if (this.DomainWhitelist != null)
                    hash = hash * 59 + this.DomainWhitelist.GetHashCode();
                
                return hash;
            }
        }
    }

}
