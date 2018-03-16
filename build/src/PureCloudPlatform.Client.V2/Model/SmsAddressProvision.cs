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
    /// SmsAddressProvision
    /// </summary>
    [DataContract]
    public partial class SmsAddressProvision :  IEquatable<SmsAddressProvision>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsAddressProvision" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SmsAddressProvision() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsAddressProvision" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Name">Name associated with this address (required).</param>
        
        
        
        /// <param name="Street">The number and street address where this address is located. (required).</param>
        
        
        
        /// <param name="City">The city in which this address is in (required).</param>
        
        
        
        /// <param name="Region">The state or region this address is in (required).</param>
        
        
        
        /// <param name="PostalCode">The postal code this address is in (required).</param>
        
        
        
        /// <param name="CountryCode">The ISO country code of this address (required).</param>
        
        
        
        /// <param name="AutoCorrectAddress">This is used when the address is created. If the value is not set or true, then the system will, if necessary, auto-correct the address you provide. Set this value to false if the system should not auto-correct the address..</param>
        
        
        
        
        public SmsAddressProvision(string Name = null, string Street = null, string City = null, string Region = null, string PostalCode = null, string CountryCode = null, bool? AutoCorrectAddress = null)
        {
            
            
            
            
            
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for SmsAddressProvision and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            
            
            
            
            
            // to ensure "Street" is required (not null)
            if (Street == null)
            {
                throw new InvalidDataException("Street is a required property for SmsAddressProvision and cannot be null");
            }
            else
            {
                this.Street = Street;
            }
            
            
            
            
            
            // to ensure "City" is required (not null)
            if (City == null)
            {
                throw new InvalidDataException("City is a required property for SmsAddressProvision and cannot be null");
            }
            else
            {
                this.City = City;
            }
            
            
            
            
            
            // to ensure "Region" is required (not null)
            if (Region == null)
            {
                throw new InvalidDataException("Region is a required property for SmsAddressProvision and cannot be null");
            }
            else
            {
                this.Region = Region;
            }
            
            
            
            
            
            // to ensure "PostalCode" is required (not null)
            if (PostalCode == null)
            {
                throw new InvalidDataException("PostalCode is a required property for SmsAddressProvision and cannot be null");
            }
            else
            {
                this.PostalCode = PostalCode;
            }
            
            
            
            
            
            // to ensure "CountryCode" is required (not null)
            if (CountryCode == null)
            {
                throw new InvalidDataException("CountryCode is a required property for SmsAddressProvision and cannot be null");
            }
            else
            {
                this.CountryCode = CountryCode;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.AutoCorrectAddress = AutoCorrectAddress;
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Name associated with this address
        /// </summary>
        /// <value>Name associated with this address</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The number and street address where this address is located.
        /// </summary>
        /// <value>The number and street address where this address is located.</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }
        
        
        
        /// <summary>
        /// The city in which this address is in
        /// </summary>
        /// <value>The city in which this address is in</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        
        
        
        /// <summary>
        /// The state or region this address is in
        /// </summary>
        /// <value>The state or region this address is in</value>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }
        
        
        
        /// <summary>
        /// The postal code this address is in
        /// </summary>
        /// <value>The postal code this address is in</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
        
        
        
        /// <summary>
        /// The ISO country code of this address
        /// </summary>
        /// <value>The ISO country code of this address</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        
        
        
        /// <summary>
        /// This is used when the address is created. If the value is not set or true, then the system will, if necessary, auto-correct the address you provide. Set this value to false if the system should not auto-correct the address.
        /// </summary>
        /// <value>This is used when the address is created. If the value is not set or true, then the system will, if necessary, auto-correct the address you provide. Set this value to false if the system should not auto-correct the address.</value>
        [DataMember(Name="autoCorrectAddress", EmitDefaultValue=false)]
        public bool? AutoCorrectAddress { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsAddressProvision {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  Street: ").Append(Street).Append("\n");
            
            sb.Append("  City: ").Append(City).Append("\n");
            
            sb.Append("  Region: ").Append(Region).Append("\n");
            
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            
            sb.Append("  AutoCorrectAddress: ").Append(AutoCorrectAddress).Append("\n");
            
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            
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
            return this.Equals(obj as SmsAddressProvision);
        }

        /// <summary>
        /// Returns true if SmsAddressProvision instances are equal
        /// </summary>
        /// <param name="other">Instance of SmsAddressProvision to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsAddressProvision other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Street == other.Street ||
                    this.Street != null &&
                    this.Street.Equals(other.Street)
                ) &&
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) &&
                (
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
                ) &&
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) &&
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) &&
                (
                    this.AutoCorrectAddress == other.AutoCorrectAddress ||
                    this.AutoCorrectAddress != null &&
                    this.AutoCorrectAddress.Equals(other.AutoCorrectAddress)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Street != null)
                    hash = hash * 59 + this.Street.GetHashCode();
                
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                
                if (this.Region != null)
                    hash = hash * 59 + this.Region.GetHashCode();
                
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                
                if (this.AutoCorrectAddress != null)
                    hash = hash * 59 + this.AutoCorrectAddress.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
