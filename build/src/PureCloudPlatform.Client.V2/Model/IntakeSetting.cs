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
    /// IntakeSetting
    /// </summary>
    [DataContract]
    public partial class IntakeSetting :  IEquatable<IntakeSetting>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="IntakeSetting" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IntakeSetting() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntakeSetting" /> class.
        /// </summary>
        /// <param name="Property">The property name for this intake setting. (required).</param>
        /// <param name="Required">Defines if this property is required for intake (required).</param>
        /// <param name="DisplayOrder">The order where this property should be displayed (required).</param>
        public IntakeSetting(string Property = null, bool? Required = null, int? DisplayOrder = null)
        {
            this.Property = Property;
            this.Required = Required;
            this.DisplayOrder = DisplayOrder;
            
        }
        


        /// <summary>
        /// The property name for this intake setting.
        /// </summary>
        /// <value>The property name for this intake setting.</value>
        [DataMember(Name="property", EmitDefaultValue=false)]
        public string Property { get; set; }



        /// <summary>
        /// Defines if this property is required for intake
        /// </summary>
        /// <value>Defines if this property is required for intake</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }



        /// <summary>
        /// The order where this property should be displayed
        /// </summary>
        /// <value>The order where this property should be displayed</value>
        [DataMember(Name="displayOrder", EmitDefaultValue=false)]
        public int? DisplayOrder { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntakeSetting {\n");

            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
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
            return this.Equals(obj as IntakeSetting);
        }

        /// <summary>
        /// Returns true if IntakeSetting instances are equal
        /// </summary>
        /// <param name="other">Instance of IntakeSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntakeSetting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Property == other.Property ||
                    this.Property != null &&
                    this.Property.Equals(other.Property)
                ) &&
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) &&
                (
                    this.DisplayOrder == other.DisplayOrder ||
                    this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(other.DisplayOrder)
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
                if (this.Property != null)
                    hash = hash * 59 + this.Property.GetHashCode();

                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();

                if (this.DisplayOrder != null)
                    hash = hash * 59 + this.DisplayOrder.GetHashCode();

                return hash;
            }
        }
    }

}
