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
    /// StreetAddress
    /// </summary>
    [DataContract]
    public partial class StreetAddress :  IEquatable<StreetAddress>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StreetAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StreetAddress() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StreetAddress" /> class.
        /// </summary>
        /// <param name="Country">2 Letter Country code, like US or GB (required).</param>
        /// <param name="A1">State or Province (required).</param>
        /// <param name="A3">City or township (required).</param>
        /// <param name="RD">Number and street (required).</param>
        /// <param name="HNO">House Number (required).</param>
        /// <param name="LOC">extra location info like suite 300.</param>
        /// <param name="NAM">Name of the customer.</param>
        /// <param name="PC">Postal code (required).</param>
        public StreetAddress(string Country = null, string A1 = null, string A3 = null, string RD = null, string HNO = null, string LOC = null, string NAM = null, string PC = null)
        {
            this.Country = Country;
            this.A1 = A1;
            this.A3 = A3;
            this.RD = RD;
            this.HNO = HNO;
            this.LOC = LOC;
            this.NAM = NAM;
            this.PC = PC;
            
        }
        
        
        
        /// <summary>
        /// 2 Letter Country code, like US or GB
        /// </summary>
        /// <value>2 Letter Country code, like US or GB</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        
        
        
        /// <summary>
        /// State or Province
        /// </summary>
        /// <value>State or Province</value>
        [DataMember(Name="A1", EmitDefaultValue=false)]
        public string A1 { get; set; }
        
        
        
        /// <summary>
        /// City or township
        /// </summary>
        /// <value>City or township</value>
        [DataMember(Name="A3", EmitDefaultValue=false)]
        public string A3 { get; set; }
        
        
        
        /// <summary>
        /// Number and street
        /// </summary>
        /// <value>Number and street</value>
        [DataMember(Name="RD", EmitDefaultValue=false)]
        public string RD { get; set; }
        
        
        
        /// <summary>
        /// House Number
        /// </summary>
        /// <value>House Number</value>
        [DataMember(Name="HNO", EmitDefaultValue=false)]
        public string HNO { get; set; }
        
        
        
        /// <summary>
        /// extra location info like suite 300
        /// </summary>
        /// <value>extra location info like suite 300</value>
        [DataMember(Name="LOC", EmitDefaultValue=false)]
        public string LOC { get; set; }
        
        
        
        /// <summary>
        /// Name of the customer
        /// </summary>
        /// <value>Name of the customer</value>
        [DataMember(Name="NAM", EmitDefaultValue=false)]
        public string NAM { get; set; }
        
        
        
        /// <summary>
        /// Postal code
        /// </summary>
        /// <value>Postal code</value>
        [DataMember(Name="PC", EmitDefaultValue=false)]
        public string PC { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StreetAddress {\n");
            
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  A1: ").Append(A1).Append("\n");
            sb.Append("  A3: ").Append(A3).Append("\n");
            sb.Append("  RD: ").Append(RD).Append("\n");
            sb.Append("  HNO: ").Append(HNO).Append("\n");
            sb.Append("  LOC: ").Append(LOC).Append("\n");
            sb.Append("  NAM: ").Append(NAM).Append("\n");
            sb.Append("  PC: ").Append(PC).Append("\n");
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
            return this.Equals(obj as StreetAddress);
        }

        /// <summary>
        /// Returns true if StreetAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of StreetAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StreetAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) &&
                (
                    this.A1 == other.A1 ||
                    this.A1 != null &&
                    this.A1.Equals(other.A1)
                ) &&
                (
                    this.A3 == other.A3 ||
                    this.A3 != null &&
                    this.A3.Equals(other.A3)
                ) &&
                (
                    this.RD == other.RD ||
                    this.RD != null &&
                    this.RD.Equals(other.RD)
                ) &&
                (
                    this.HNO == other.HNO ||
                    this.HNO != null &&
                    this.HNO.Equals(other.HNO)
                ) &&
                (
                    this.LOC == other.LOC ||
                    this.LOC != null &&
                    this.LOC.Equals(other.LOC)
                ) &&
                (
                    this.NAM == other.NAM ||
                    this.NAM != null &&
                    this.NAM.Equals(other.NAM)
                ) &&
                (
                    this.PC == other.PC ||
                    this.PC != null &&
                    this.PC.Equals(other.PC)
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
                
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                
                if (this.A1 != null)
                    hash = hash * 59 + this.A1.GetHashCode();
                
                if (this.A3 != null)
                    hash = hash * 59 + this.A3.GetHashCode();
                
                if (this.RD != null)
                    hash = hash * 59 + this.RD.GetHashCode();
                
                if (this.HNO != null)
                    hash = hash * 59 + this.HNO.GetHashCode();
                
                if (this.LOC != null)
                    hash = hash * 59 + this.LOC.GetHashCode();
                
                if (this.NAM != null)
                    hash = hash * 59 + this.NAM.GetHashCode();
                
                if (this.PC != null)
                    hash = hash * 59 + this.PC.GetHashCode();
                
                return hash;
            }
        }
    }

}
