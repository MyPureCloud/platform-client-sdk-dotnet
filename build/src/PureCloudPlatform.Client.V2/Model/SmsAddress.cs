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
    /// SmsAddress
    /// </summary>
    [DataContract]
    public partial class SmsAddress :  IEquatable<SmsAddress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsAddress" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Street">The number and street address where this address is located..</param>
        /// <param name="City">The city in which this address is in.</param>
        /// <param name="Region">The state or region this address is in.</param>
        /// <param name="PostalCode">The postal code this address is in.</param>
        /// <param name="CountryCode">The ISO country code of this address.</param>
        public SmsAddress(string Name = null, string Street = null, string City = null, string Region = null, string PostalCode = null, string CountryCode = null)
        {
            this.Name = Name;
            this.Street = Street;
            this.City = City;
            this.Region = Region;
            this.PostalCode = PostalCode;
            this.CountryCode = CountryCode;
            
        }
        


        /// <summary>
        /// The id of this address.
        /// </summary>
        /// <value>The id of this address.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
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
        /// In some countries, addresses are validated to comply with local regulation. In those countries, if the address you provide does not pass validation, it will not be accepted as an Address. This value will be true if the Address has been validated, or false for countries that don&#39;t require validation or if the Address is non-compliant.
        /// </summary>
        /// <value>In some countries, addresses are validated to comply with local regulation. In those countries, if the address you provide does not pass validation, it will not be accepted as an Address. This value will be true if the Address has been validated, or false for countries that don&#39;t require validation or if the Address is non-compliant.</value>
        [DataMember(Name="validated", EmitDefaultValue=false)]
        public bool? Validated { get; private set; }



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
            sb.Append("class SmsAddress {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Validated: ").Append(Validated).Append("\n");
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
            return this.Equals(obj as SmsAddress);
        }

        /// <summary>
        /// Returns true if SmsAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of SmsAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsAddress other)
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
                    this.Validated == other.Validated ||
                    this.Validated != null &&
                    this.Validated.Equals(other.Validated)
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

                if (this.Validated != null)
                    hash = hash * 59 + this.Validated.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
