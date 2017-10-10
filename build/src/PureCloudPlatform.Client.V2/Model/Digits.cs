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
    /// Digits
    /// </summary>
    [DataContract]
    public partial class Digits :  IEquatable<Digits>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Digits" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Digits() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Digits" /> class.
        /// </summary>
        
        
        /// <param name="_Digits">A string representing the DTMF tones to play. Valid DTMF values: 1234567890#*ABCD (required).</param>
        
        
        public Digits(string _Digits = null)
        {
            
            
            
            // to ensure "_Digits" is required (not null)
            if (_Digits == null)
            {
                throw new InvalidDataException("_Digits is a required property for Digits and cannot be null");
            }
            else
            {
                this._Digits = _Digits;
            }
            
            
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// A string representing the DTMF tones to play. Valid DTMF values: 1234567890#*ABCD
        /// </summary>
        /// <value>A string representing the DTMF tones to play. Valid DTMF values: 1234567890#*ABCD</value>
        [DataMember(Name="digits", EmitDefaultValue=false)]
        public string _Digits { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Digits {\n");
            
            sb.Append("  _Digits: ").Append(_Digits).Append("\n");
            
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
            return this.Equals(obj as Digits);
        }

        /// <summary>
        /// Returns true if Digits instances are equal
        /// </summary>
        /// <param name="other">Instance of Digits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Digits other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this._Digits == other._Digits ||
                    this._Digits != null &&
                    this._Digits.Equals(other._Digits)
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
                
                if (this._Digits != null)
                    hash = hash * 59 + this._Digits.GetHashCode();
                
                return hash;
            }
        }
    }

}
