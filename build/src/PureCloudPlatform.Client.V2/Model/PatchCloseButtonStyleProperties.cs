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
    /// PatchCloseButtonStyleProperties
    /// </summary>
    [DataContract]
    public partial class PatchCloseButtonStyleProperties :  IEquatable<PatchCloseButtonStyleProperties>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCloseButtonStyleProperties" /> class.
        /// </summary>
        /// <param name="Color">Color of button. (eg. #FF0000).</param>
        /// <param name="Opacity">Opacity of button..</param>
        public PatchCloseButtonStyleProperties(string Color = null, float? Opacity = null)
        {
            this.Color = Color;
            this.Opacity = Opacity;
            
        }
        
        
        
        /// <summary>
        /// Color of button. (eg. #FF0000)
        /// </summary>
        /// <value>Color of button. (eg. #FF0000)</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }
        
        
        
        /// <summary>
        /// Opacity of button.
        /// </summary>
        /// <value>Opacity of button.</value>
        [DataMember(Name="opacity", EmitDefaultValue=false)]
        public float? Opacity { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchCloseButtonStyleProperties {\n");
            
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Opacity: ").Append(Opacity).Append("\n");
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
            return this.Equals(obj as PatchCloseButtonStyleProperties);
        }

        /// <summary>
        /// Returns true if PatchCloseButtonStyleProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of PatchCloseButtonStyleProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchCloseButtonStyleProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) &&
                (
                    this.Opacity == other.Opacity ||
                    this.Opacity != null &&
                    this.Opacity.Equals(other.Opacity)
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
                
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                
                if (this.Opacity != null)
                    hash = hash * 59 + this.Opacity.GetHashCode();
                
                return hash;
            }
        }
    }

}
