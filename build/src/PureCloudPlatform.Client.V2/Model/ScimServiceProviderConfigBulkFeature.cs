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
    /// Defines a \&quot;bulk\&quot; request in the SCIM service provider&#39;s configuration.
    /// </summary>
    [DataContract]
    public partial class ScimServiceProviderConfigBulkFeature :  IEquatable<ScimServiceProviderConfigBulkFeature>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimServiceProviderConfigBulkFeature" /> class.
        /// </summary>
        public ScimServiceProviderConfigBulkFeature()
        {
            
        }
        
        
        
        /// <summary>
        /// Indicates whether configuration options are supported.
        /// </summary>
        /// <value>Indicates whether configuration options are supported.</value>
        [DataMember(Name="supported", EmitDefaultValue=false)]
        public bool? Supported { get; private set; }
        
        
        
        /// <summary>
        /// The maximum number of operations for each bulk request.
        /// </summary>
        /// <value>The maximum number of operations for each bulk request.</value>
        [DataMember(Name="maxOperations", EmitDefaultValue=false)]
        public int? MaxOperations { get; private set; }
        
        
        
        /// <summary>
        /// The maximum payload size.
        /// </summary>
        /// <value>The maximum payload size.</value>
        [DataMember(Name="maxPayloadSize", EmitDefaultValue=false)]
        public int? MaxPayloadSize { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimServiceProviderConfigBulkFeature {\n");
            
            sb.Append("  Supported: ").Append(Supported).Append("\n");
            sb.Append("  MaxOperations: ").Append(MaxOperations).Append("\n");
            sb.Append("  MaxPayloadSize: ").Append(MaxPayloadSize).Append("\n");
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
            return this.Equals(obj as ScimServiceProviderConfigBulkFeature);
        }

        /// <summary>
        /// Returns true if ScimServiceProviderConfigBulkFeature instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimServiceProviderConfigBulkFeature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimServiceProviderConfigBulkFeature other)
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
                    this.MaxOperations == other.MaxOperations ||
                    this.MaxOperations != null &&
                    this.MaxOperations.Equals(other.MaxOperations)
                ) &&
                (
                    this.MaxPayloadSize == other.MaxPayloadSize ||
                    this.MaxPayloadSize != null &&
                    this.MaxPayloadSize.Equals(other.MaxPayloadSize)
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
                
                if (this.MaxOperations != null)
                    hash = hash * 59 + this.MaxOperations.GetHashCode();
                
                if (this.MaxPayloadSize != null)
                    hash = hash * 59 + this.MaxPayloadSize.GetHashCode();
                
                return hash;
            }
        }
    }

}
