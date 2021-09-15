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
    /// Settings concerning cobrowse
    /// </summary>
    [DataContract]
    public partial class CobrowseSettings :  IEquatable<CobrowseSettings>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CobrowseSettings" /> class.
        /// </summary>
        /// <param name="Enabled">Whether or not cobrowse is enabled.</param>
        /// <param name="AllowAgentControl">Whether the viewer should have option to request control.</param>
        /// <param name="MaskSelectors">Mask patterns that will apply to pages being shared.</param>
        public CobrowseSettings(bool? Enabled = null, bool? AllowAgentControl = null, List<string> MaskSelectors = null)
        {
            this.Enabled = Enabled;
            this.AllowAgentControl = AllowAgentControl;
            this.MaskSelectors = MaskSelectors;
            
        }
        
        
        
        /// <summary>
        /// Whether or not cobrowse is enabled
        /// </summary>
        /// <value>Whether or not cobrowse is enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        
        /// <summary>
        /// Whether the viewer should have option to request control
        /// </summary>
        /// <value>Whether the viewer should have option to request control</value>
        [DataMember(Name="allowAgentControl", EmitDefaultValue=false)]
        public bool? AllowAgentControl { get; set; }
        
        
        
        /// <summary>
        /// Mask patterns that will apply to pages being shared
        /// </summary>
        /// <value>Mask patterns that will apply to pages being shared</value>
        [DataMember(Name="maskSelectors", EmitDefaultValue=false)]
        public List<string> MaskSelectors { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CobrowseSettings {\n");
            
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  AllowAgentControl: ").Append(AllowAgentControl).Append("\n");
            sb.Append("  MaskSelectors: ").Append(MaskSelectors).Append("\n");
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
            return this.Equals(obj as CobrowseSettings);
        }

        /// <summary>
        /// Returns true if CobrowseSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of CobrowseSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CobrowseSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.AllowAgentControl == other.AllowAgentControl ||
                    this.AllowAgentControl != null &&
                    this.AllowAgentControl.Equals(other.AllowAgentControl)
                ) &&
                (
                    this.MaskSelectors == other.MaskSelectors ||
                    this.MaskSelectors != null &&
                    this.MaskSelectors.SequenceEqual(other.MaskSelectors)
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
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.AllowAgentControl != null)
                    hash = hash * 59 + this.AllowAgentControl.GetHashCode();
                
                if (this.MaskSelectors != null)
                    hash = hash * 59 + this.MaskSelectors.GetHashCode();
                
                return hash;
            }
        }
    }

}
