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
    /// ContactListFilterNotificationRange
    /// </summary>
    [DataContract]
    public partial class ContactListFilterNotificationRange :  IEquatable<ContactListFilterNotificationRange>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListFilterNotificationRange" /> class.
        /// </summary>
        /// <param name="Gt">Gt.</param>
        /// <param name="Gte">Gte.</param>
        /// <param name="Lt">Lt.</param>
        /// <param name="Lte">Lte.</param>
        /// <param name="InSet">InSet.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public ContactListFilterNotificationRange(string Gt = null, string Gte = null, string Lt = null, string Lte = null, List<string> InSet = null, Object AdditionalProperties = null)
        {
            this.Gt = Gt;
            this.Gte = Gte;
            this.Lt = Lt;
            this.Lte = Lte;
            this.InSet = InSet;
            this.AdditionalProperties = AdditionalProperties;
        }
        
        /// <summary>
        /// Gets or Sets Gt
        /// </summary>
        [DataMember(Name="gt", EmitDefaultValue=false)]
        public string Gt { get; set; }
        /// <summary>
        /// Gets or Sets Gte
        /// </summary>
        [DataMember(Name="gte", EmitDefaultValue=false)]
        public string Gte { get; set; }
        /// <summary>
        /// Gets or Sets Lt
        /// </summary>
        [DataMember(Name="lt", EmitDefaultValue=false)]
        public string Lt { get; set; }
        /// <summary>
        /// Gets or Sets Lte
        /// </summary>
        [DataMember(Name="lte", EmitDefaultValue=false)]
        public string Lte { get; set; }
        /// <summary>
        /// Gets or Sets InSet
        /// </summary>
        [DataMember(Name="inSet", EmitDefaultValue=false)]
        public List<string> InSet { get; set; }
        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Object AdditionalProperties { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactListFilterNotificationRange {\n");
            sb.Append("  Gt: ").Append(Gt).Append("\n");
            sb.Append("  Gte: ").Append(Gte).Append("\n");
            sb.Append("  Lt: ").Append(Lt).Append("\n");
            sb.Append("  Lte: ").Append(Lte).Append("\n");
            sb.Append("  InSet: ").Append(InSet).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(obj as ContactListFilterNotificationRange);
        }

        /// <summary>
        /// Returns true if ContactListFilterNotificationRange instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactListFilterNotificationRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactListFilterNotificationRange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Gt == other.Gt ||
                    this.Gt != null &&
                    this.Gt.Equals(other.Gt)
                ) &&
                (
                    this.Gte == other.Gte ||
                    this.Gte != null &&
                    this.Gte.Equals(other.Gte)
                ) &&
                (
                    this.Lt == other.Lt ||
                    this.Lt != null &&
                    this.Lt.Equals(other.Lt)
                ) &&
                (
                    this.Lte == other.Lte ||
                    this.Lte != null &&
                    this.Lte.Equals(other.Lte)
                ) &&
                (
                    this.InSet == other.InSet ||
                    this.InSet != null &&
                    this.InSet.SequenceEqual(other.InSet)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.Equals(other.AdditionalProperties)
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
                if (this.Gt != null)
                    hash = hash * 59 + this.Gt.GetHashCode();
                if (this.Gte != null)
                    hash = hash * 59 + this.Gte.GetHashCode();
                if (this.Lt != null)
                    hash = hash * 59 + this.Lt.GetHashCode();
                if (this.Lte != null)
                    hash = hash * 59 + this.Lte.GetHashCode();
                if (this.InSet != null)
                    hash = hash * 59 + this.InSet.GetHashCode();
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                return hash;
            }
        }
    }

}
