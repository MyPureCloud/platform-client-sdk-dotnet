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
    /// NumericRange
    /// </summary>
    [DataContract]
    public partial class NumericRange :  IEquatable<NumericRange>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NumericRange" /> class.
        /// </summary>
        
        
        /// <param name="Gt">Greater than.</param>
        
        
        
        /// <param name="Gte">Greater than or equal to.</param>
        
        
        
        /// <param name="Lt">Less than.</param>
        
        
        
        /// <param name="Lte">Less than or equal to.</param>
        
        
        public NumericRange(double? Gt = null, double? Gte = null, double? Lt = null, double? Lte = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Gt = Gt;
            
            
            
            
            
            
            
            
this.Gte = Gte;
            
            
            
            
            
            
            
            
this.Lt = Lt;
            
            
            
            
            
            
            
            
this.Lte = Lte;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Greater than
        /// </summary>
        /// <value>Greater than</value>
        [DataMember(Name="gt", EmitDefaultValue=false)]
        public double? Gt { get; set; }
        
        
        
        /// <summary>
        /// Greater than or equal to
        /// </summary>
        /// <value>Greater than or equal to</value>
        [DataMember(Name="gte", EmitDefaultValue=false)]
        public double? Gte { get; set; }
        
        
        
        /// <summary>
        /// Less than
        /// </summary>
        /// <value>Less than</value>
        [DataMember(Name="lt", EmitDefaultValue=false)]
        public double? Lt { get; set; }
        
        
        
        /// <summary>
        /// Less than or equal to
        /// </summary>
        /// <value>Less than or equal to</value>
        [DataMember(Name="lte", EmitDefaultValue=false)]
        public double? Lte { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NumericRange {\n");
            
            sb.Append("  Gt: ").Append(Gt).Append("\n");
            
            sb.Append("  Gte: ").Append(Gte).Append("\n");
            
            sb.Append("  Lt: ").Append(Lt).Append("\n");
            
            sb.Append("  Lte: ").Append(Lte).Append("\n");
            
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
            return this.Equals(obj as NumericRange);
        }

        /// <summary>
        /// Returns true if NumericRange instances are equal
        /// </summary>
        /// <param name="other">Instance of NumericRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumericRange other)
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
                
                return hash;
            }
        }
    }

}
