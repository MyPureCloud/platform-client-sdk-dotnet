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
    /// LocationAddress
    /// </summary>
    [DataContract]
    public partial class LocationAddress :  IEquatable<LocationAddress>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationAddress" /> class.
        /// </summary>
        /// <param name="City">City.</param>
        /// <param name="Country">Country.</param>
        /// <param name="CountryName">CountryName.</param>
        /// <param name="State">State.</param>
        /// <param name="Street1">Street1.</param>
        /// <param name="Street2">Street2.</param>
        /// <param name="Zipcode">Zipcode.</param>
        public LocationAddress(string City = null, string Country = null, string CountryName = null, string State = null, string Street1 = null, string Street2 = null, string Zipcode = null)
        {
            this.City = City;
            this.Country = Country;
            this.CountryName = CountryName;
            this.State = State;
            this.Street1 = Street1;
            this.Street2 = Street2;
            this.Zipcode = Zipcode;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CountryName
        /// </summary>
        [DataMember(Name="countryName", EmitDefaultValue=false)]
        public string CountryName { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Street1
        /// </summary>
        [DataMember(Name="street1", EmitDefaultValue=false)]
        public string Street1 { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Street2
        /// </summary>
        [DataMember(Name="street2", EmitDefaultValue=false)]
        public string Street2 { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Zipcode
        /// </summary>
        [DataMember(Name="zipcode", EmitDefaultValue=false)]
        public string Zipcode { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationAddress {\n");
            
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Street1: ").Append(Street1).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  Zipcode: ").Append(Zipcode).Append("\n");
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
            return this.Equals(obj as LocationAddress);
        }

        /// <summary>
        /// Returns true if LocationAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of LocationAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) &&
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) &&
                (
                    this.CountryName == other.CountryName ||
                    this.CountryName != null &&
                    this.CountryName.Equals(other.CountryName)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Street1 == other.Street1 ||
                    this.Street1 != null &&
                    this.Street1.Equals(other.Street1)
                ) &&
                (
                    this.Street2 == other.Street2 ||
                    this.Street2 != null &&
                    this.Street2.Equals(other.Street2)
                ) &&
                (
                    this.Zipcode == other.Zipcode ||
                    this.Zipcode != null &&
                    this.Zipcode.Equals(other.Zipcode)
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
                
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                
                if (this.CountryName != null)
                    hash = hash * 59 + this.CountryName.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.Street1 != null)
                    hash = hash * 59 + this.Street1.GetHashCode();
                
                if (this.Street2 != null)
                    hash = hash * 59 + this.Street2.GetHashCode();
                
                if (this.Zipcode != null)
                    hash = hash * 59 + this.Zipcode.GetHashCode();
                
                return hash;
            }
        }
    }

}
