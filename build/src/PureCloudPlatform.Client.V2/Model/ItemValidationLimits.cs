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
    /// ItemValidationLimits
    /// </summary>
    [DataContract]
    public partial class ItemValidationLimits :  IEquatable<ItemValidationLimits>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemValidationLimits" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemValidationLimits() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemValidationLimits" /> class.
        /// </summary>
        /// <param name="MinLength">A structure denoting the system-imposed minimum string length (for text-based core types) or numeric values (for number-based) core types.  For example, the validationLimits for a text-based core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schemaauthor on a text field.  Similarly, the maxLength's min/max specifies maximum string length constraint supplied by a schema author for the same field. (required).</param>
        /// <param name="MaxLength">A structure denoting the system-imposed minimum and maximum string length (for text-based core types) or numeric values (for number-based) core types.  For example, the validationLimits for a text-based core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schemaauthor on a text field.  Similarly, the maxLength's min/max specifies maximum string length constraint supplied by a schema author for the same field. (required).</param>
        public ItemValidationLimits(MinLength MinLength = null, MaxLength MaxLength = null)
        {
            this.MinLength = MinLength;
            this.MaxLength = MaxLength;
            
        }
        


        /// <summary>
        /// A structure denoting the system-imposed minimum string length (for text-based core types) or numeric values (for number-based) core types.  For example, the validationLimits for a text-based core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schemaauthor on a text field.  Similarly, the maxLength's min/max specifies maximum string length constraint supplied by a schema author for the same field.
        /// </summary>
        /// <value>A structure denoting the system-imposed minimum string length (for text-based core types) or numeric values (for number-based) core types.  For example, the validationLimits for a text-based core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schemaauthor on a text field.  Similarly, the maxLength's min/max specifies maximum string length constraint supplied by a schema author for the same field.</value>
        [DataMember(Name="minLength", EmitDefaultValue=false)]
        public MinLength MinLength { get; set; }



        /// <summary>
        /// A structure denoting the system-imposed minimum and maximum string length (for text-based core types) or numeric values (for number-based) core types.  For example, the validationLimits for a text-based core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schemaauthor on a text field.  Similarly, the maxLength's min/max specifies maximum string length constraint supplied by a schema author for the same field.
        /// </summary>
        /// <value>A structure denoting the system-imposed minimum and maximum string length (for text-based core types) or numeric values (for number-based) core types.  For example, the validationLimits for a text-based core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schemaauthor on a text field.  Similarly, the maxLength's min/max specifies maximum string length constraint supplied by a schema author for the same field.</value>
        [DataMember(Name="maxLength", EmitDefaultValue=false)]
        public MaxLength MaxLength { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemValidationLimits {\n");

            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
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
            return this.Equals(obj as ItemValidationLimits);
        }

        /// <summary>
        /// Returns true if ItemValidationLimits instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemValidationLimits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemValidationLimits other)
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

                return hash;
            }
        }
    }

}
