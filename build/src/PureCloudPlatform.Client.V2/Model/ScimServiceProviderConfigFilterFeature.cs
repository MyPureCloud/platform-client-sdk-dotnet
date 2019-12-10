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
    /// Defines a \&quot;filter\&quot; request in the SCIM service provider&#39;s configuration.
    /// </summary>
    [DataContract]
    public partial class ScimServiceProviderConfigFilterFeature :  IEquatable<ScimServiceProviderConfigFilterFeature>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimServiceProviderConfigFilterFeature" /> class.
        /// </summary>
        public ScimServiceProviderConfigFilterFeature()
        {
            
        }
        
        
        
        /// <summary>
        /// Indicates whether configuration options are supported.
        /// </summary>
        /// <value>Indicates whether configuration options are supported.</value>
        [DataMember(Name="supported", EmitDefaultValue=false)]
        public bool? Supported { get; private set; }
        
        
        
        /// <summary>
        /// The maximum number of results returned from a filtered query.
        /// </summary>
        /// <value>The maximum number of results returned from a filtered query.</value>
        [DataMember(Name="maxResults", EmitDefaultValue=false)]
        public int? MaxResults { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimServiceProviderConfigFilterFeature {\n");
            
            sb.Append("  Supported: ").Append(Supported).Append("\n");
            sb.Append("  MaxResults: ").Append(MaxResults).Append("\n");
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
            return this.Equals(obj as ScimServiceProviderConfigFilterFeature);
        }

        /// <summary>
        /// Returns true if ScimServiceProviderConfigFilterFeature instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimServiceProviderConfigFilterFeature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimServiceProviderConfigFilterFeature other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Supported == other.Supported ||
                    this.Supported != null &&
                    this.Supported.Equals(other.Supported)
                ) &&
                (
                    this.MaxResults == other.MaxResults ||
                    this.MaxResults != null &&
                    this.MaxResults.Equals(other.MaxResults)
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
                
                if (this.Supported != null)
                    hash = hash * 59 + this.Supported.GetHashCode();
                
                if (this.MaxResults != null)
                    hash = hash * 59 + this.MaxResults.GetHashCode();
                
                return hash;
            }
        }
    }

}
