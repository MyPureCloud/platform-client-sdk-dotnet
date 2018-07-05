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
    /// Effective Configuration for an ClientApp. This is comprised of the integration specific configuration along with overrides specified in the integration type.
    /// </summary>
    [DataContract]
    public partial class EffectiveConfiguration :  IEquatable<EffectiveConfiguration>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EffectiveConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EffectiveConfiguration() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EffectiveConfiguration" /> class.
        /// </summary>
        /// <param name="Properties">Key-value configuration settings described by the schema in the propertiesSchemaUri field. (required).</param>
        /// <param name="Advanced">Advanced configuration described by the schema in the advancedSchemaUri field. (required).</param>
        /// <param name="Name">The name of the integration, used to distinguish this integration from others of the same type. (required).</param>
        /// <param name="Notes">Notes about the integration. (required).</param>
        /// <param name="Credentials">Credentials required by the integration. The required keys are indicated in the credentials property of the Integration Type (required).</param>
        public EffectiveConfiguration(Dictionary<string, Object> Properties = null, Dictionary<string, Object> Advanced = null, string Name = null, string Notes = null, Dictionary<string, CredentialInfo> Credentials = null)
        {
            
        }
        
        
        
        /// <summary>
        /// Key-value configuration settings described by the schema in the propertiesSchemaUri field.
        /// </summary>
        /// <value>Key-value configuration settings described by the schema in the propertiesSchemaUri field.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, Object> Properties { get; set; }
        
        
        
        /// <summary>
        /// Advanced configuration described by the schema in the advancedSchemaUri field.
        /// </summary>
        /// <value>Advanced configuration described by the schema in the advancedSchemaUri field.</value>
        [DataMember(Name="advanced", EmitDefaultValue=false)]
        public Dictionary<string, Object> Advanced { get; set; }
        
        
        
        /// <summary>
        /// The name of the integration, used to distinguish this integration from others of the same type.
        /// </summary>
        /// <value>The name of the integration, used to distinguish this integration from others of the same type.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Notes about the integration.
        /// </summary>
        /// <value>Notes about the integration.</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }
        
        
        
        /// <summary>
        /// Credentials required by the integration. The required keys are indicated in the credentials property of the Integration Type
        /// </summary>
        /// <value>Credentials required by the integration. The required keys are indicated in the credentials property of the Integration Type</value>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public Dictionary<string, CredentialInfo> Credentials { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EffectiveConfiguration {\n");
            
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Advanced: ").Append(Advanced).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
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
            return this.Equals(obj as EffectiveConfiguration);
        }

        /// <summary>
        /// Returns true if EffectiveConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of EffectiveConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EffectiveConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
                ) &&
                (
                    this.Advanced == other.Advanced ||
                    this.Advanced != null &&
                    this.Advanced.SequenceEqual(other.Advanced)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) &&
                (
                    this.Credentials == other.Credentials ||
                    this.Credentials != null &&
                    this.Credentials.SequenceEqual(other.Credentials)
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
                
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                
                if (this.Advanced != null)
                    hash = hash * 59 + this.Advanced.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                
                if (this.Credentials != null)
                    hash = hash * 59 + this.Credentials.GetHashCode();
                
                return hash;
            }
        }
    }

}
