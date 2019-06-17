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
    /// ScimServiceProviderConfig
    /// </summary>
    [DataContract]
    public partial class ScimServiceProviderConfig :  IEquatable<ScimServiceProviderConfig>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimServiceProviderConfig" /> class.
        /// </summary>
        /// <param name="Meta">Configuration SCIM meta data.</param>
        public ScimServiceProviderConfig(ScimMetadata Meta = null)
        {
            this.Meta = Meta;
            
        }
        
        
        
        /// <summary>
        /// Documentation
        /// </summary>
        /// <value>Documentation</value>
        [DataMember(Name="documentationUri", EmitDefaultValue=false)]
        public string DocumentationUri { get; private set; }
        
        
        
        /// <summary>
        /// Configuration SCIM meta data
        /// </summary>
        /// <value>Configuration SCIM meta data</value>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public ScimMetadata Meta { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimServiceProviderConfig {\n");
            
            sb.Append("  DocumentationUri: ").Append(DocumentationUri).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(obj as ScimServiceProviderConfig);
        }

        /// <summary>
        /// Returns true if ScimServiceProviderConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimServiceProviderConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimServiceProviderConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DocumentationUri == other.DocumentationUri ||
                    this.DocumentationUri != null &&
                    this.DocumentationUri.Equals(other.DocumentationUri)
                ) &&
                (
                    this.Meta == other.Meta ||
                    this.Meta != null &&
                    this.Meta.Equals(other.Meta)
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
                
                if (this.DocumentationUri != null)
                    hash = hash * 59 + this.DocumentationUri.GetHashCode();
                
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
                
                return hash;
            }
        }
    }

}
