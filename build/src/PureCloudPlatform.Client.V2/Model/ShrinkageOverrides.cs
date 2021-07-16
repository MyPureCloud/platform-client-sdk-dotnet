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
    /// ShrinkageOverrides
    /// </summary>
    [DataContract]
    public partial class ShrinkageOverrides :  IEquatable<ShrinkageOverrides>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShrinkageOverrides" /> class.
        /// </summary>
        /// <param name="Clear">Set true to clear the shrinkage interval overrides.</param>
        /// <param name="Values">List of interval shrinkage overrides.</param>
        public ShrinkageOverrides(bool? Clear = null, List<ShrinkageOverride> Values = null)
        {
            this.Clear = Clear;
            this.Values = Values;
            
        }
        
        
        
        /// <summary>
        /// Set true to clear the shrinkage interval overrides
        /// </summary>
        /// <value>Set true to clear the shrinkage interval overrides</value>
        [DataMember(Name="clear", EmitDefaultValue=false)]
        public bool? Clear { get; set; }
        
        
        
        /// <summary>
        /// List of interval shrinkage overrides
        /// </summary>
        /// <value>List of interval shrinkage overrides</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<ShrinkageOverride> Values { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShrinkageOverrides {\n");
            
            sb.Append("  Clear: ").Append(Clear).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(obj as ShrinkageOverrides);
        }

        /// <summary>
        /// Returns true if ShrinkageOverrides instances are equal
        /// </summary>
        /// <param name="other">Instance of ShrinkageOverrides to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShrinkageOverrides other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Clear == other.Clear ||
                    this.Clear != null &&
                    this.Clear.Equals(other.Clear)
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
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
                
                if (this.Clear != null)
                    hash = hash * 59 + this.Clear.GetHashCode();
                
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                
                return hash;
            }
        }
    }

}
