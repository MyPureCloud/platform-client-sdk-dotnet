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
    /// SelectedCustomCalculationColumns
    /// </summary>
    [DataContract]
    public partial class SelectedCustomCalculationColumns :  IEquatable<SelectedCustomCalculationColumns>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedCustomCalculationColumns" /> class.
        /// </summary>
        /// <param name="CustomCalculation">Custom calculation added as a column.</param>
        /// <param name="Restricted">Indicates if selected custom calculation column is deleted or access revoked for the user.</param>
        /// <param name="SoftDeleted">Is selected custom calculation column soft deleted.</param>
        public SelectedCustomCalculationColumns(AddressableEntityRef CustomCalculation = null, bool? Restricted = null, bool? SoftDeleted = null)
        {
            this.CustomCalculation = CustomCalculation;
            this.Restricted = Restricted;
            this.SoftDeleted = SoftDeleted;
            
        }
        


        /// <summary>
        /// Custom calculation added as a column
        /// </summary>
        /// <value>Custom calculation added as a column</value>
        [DataMember(Name="customCalculation", EmitDefaultValue=false)]
        public AddressableEntityRef CustomCalculation { get; set; }



        /// <summary>
        /// Indicates if selected custom calculation column is deleted or access revoked for the user
        /// </summary>
        /// <value>Indicates if selected custom calculation column is deleted or access revoked for the user</value>
        [DataMember(Name="restricted", EmitDefaultValue=false)]
        public bool? Restricted { get; set; }



        /// <summary>
        /// Is selected custom calculation column soft deleted
        /// </summary>
        /// <value>Is selected custom calculation column soft deleted</value>
        [DataMember(Name="softDeleted", EmitDefaultValue=false)]
        public bool? SoftDeleted { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectedCustomCalculationColumns {\n");

            sb.Append("  CustomCalculation: ").Append(CustomCalculation).Append("\n");
            sb.Append("  Restricted: ").Append(Restricted).Append("\n");
            sb.Append("  SoftDeleted: ").Append(SoftDeleted).Append("\n");
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
            return this.Equals(obj as SelectedCustomCalculationColumns);
        }

        /// <summary>
        /// Returns true if SelectedCustomCalculationColumns instances are equal
        /// </summary>
        /// <param name="other">Instance of SelectedCustomCalculationColumns to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectedCustomCalculationColumns other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CustomCalculation == other.CustomCalculation ||
                    this.CustomCalculation != null &&
                    this.CustomCalculation.Equals(other.CustomCalculation)
                ) &&
                (
                    this.Restricted == other.Restricted ||
                    this.Restricted != null &&
                    this.Restricted.Equals(other.Restricted)
                ) &&
                (
                    this.SoftDeleted == other.SoftDeleted ||
                    this.SoftDeleted != null &&
                    this.SoftDeleted.Equals(other.SoftDeleted)
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
                if (this.CustomCalculation != null)
                    hash = hash * 59 + this.CustomCalculation.GetHashCode();

                if (this.Restricted != null)
                    hash = hash * 59 + this.Restricted.GetHashCode();

                if (this.SoftDeleted != null)
                    hash = hash * 59 + this.SoftDeleted.GetHashCode();

                return hash;
            }
        }
    }

}
