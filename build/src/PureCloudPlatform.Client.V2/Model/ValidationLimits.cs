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
    /// ValidationLimits
    /// </summary>
    [DataContract]
    public partial class ValidationLimits :  IEquatable<ValidationLimits>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationLimits" /> class.
        /// </summary>
        /// <param name="MinLength">MinLength.</param>
        /// <param name="MaxLength">MaxLength.</param>
        /// <param name="MinItems">MinItems.</param>
        /// <param name="MaxItems">MaxItems.</param>
        /// <param name="Minimum">Minimum.</param>
        /// <param name="Maximum">Maximum.</param>
        public ValidationLimits(MinLength MinLength = null, MaxLength MaxLength = null, MinLength MinItems = null, MaxLength MaxItems = null, MinLength Minimum = null, MaxLength Maximum = null)
        {
            this.MinLength = MinLength;
            this.MaxLength = MaxLength;
            this.MinItems = MinItems;
            this.MaxItems = MaxItems;
            this.Minimum = Minimum;
            this.Maximum = Maximum;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets MinLength
        /// </summary>
        [DataMember(Name="minLength", EmitDefaultValue=false)]
        public MinLength MinLength { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MaxLength
        /// </summary>
        [DataMember(Name="maxLength", EmitDefaultValue=false)]
        public MaxLength MaxLength { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MinItems
        /// </summary>
        [DataMember(Name="minItems", EmitDefaultValue=false)]
        public MinLength MinItems { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MaxItems
        /// </summary>
        [DataMember(Name="maxItems", EmitDefaultValue=false)]
        public MaxLength MaxItems { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Minimum
        /// </summary>
        [DataMember(Name="minimum", EmitDefaultValue=false)]
        public MinLength Minimum { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Maximum
        /// </summary>
        [DataMember(Name="maximum", EmitDefaultValue=false)]
        public MaxLength Maximum { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidationLimits {\n");
            
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  MinItems: ").Append(MinItems).Append("\n");
            sb.Append("  MaxItems: ").Append(MaxItems).Append("\n");
            sb.Append("  Minimum: ").Append(Minimum).Append("\n");
            sb.Append("  Maximum: ").Append(Maximum).Append("\n");
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
            return this.Equals(obj as ValidationLimits);
        }

        /// <summary>
        /// Returns true if ValidationLimits instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidationLimits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidationLimits other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MinLength == other.MinLength ||
                    this.MinLength != null &&
                    this.MinLength.Equals(other.MinLength)
                ) &&
                (
                    this.MaxLength == other.MaxLength ||
                    this.MaxLength != null &&
                    this.MaxLength.Equals(other.MaxLength)
                ) &&
                (
                    this.MinItems == other.MinItems ||
                    this.MinItems != null &&
                    this.MinItems.Equals(other.MinItems)
                ) &&
                (
                    this.MaxItems == other.MaxItems ||
                    this.MaxItems != null &&
                    this.MaxItems.Equals(other.MaxItems)
                ) &&
                (
                    this.Minimum == other.Minimum ||
                    this.Minimum != null &&
                    this.Minimum.Equals(other.Minimum)
                ) &&
                (
                    this.Maximum == other.Maximum ||
                    this.Maximum != null &&
                    this.Maximum.Equals(other.Maximum)
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
                
                if (this.MinLength != null)
                    hash = hash * 59 + this.MinLength.GetHashCode();
                
                if (this.MaxLength != null)
                    hash = hash * 59 + this.MaxLength.GetHashCode();
                
                if (this.MinItems != null)
                    hash = hash * 59 + this.MinItems.GetHashCode();
                
                if (this.MaxItems != null)
                    hash = hash * 59 + this.MaxItems.GetHashCode();
                
                if (this.Minimum != null)
                    hash = hash * 59 + this.Minimum.GetHashCode();
                
                if (this.Maximum != null)
                    hash = hash * 59 + this.Maximum.GetHashCode();
                
                return hash;
            }
        }
    }

}
