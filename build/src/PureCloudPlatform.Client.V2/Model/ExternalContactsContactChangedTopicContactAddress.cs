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
    /// ExternalContactsContactChangedTopicContactAddress
    /// </summary>
    [DataContract]
    public partial class ExternalContactsContactChangedTopicContactAddress :  IEquatable<ExternalContactsContactChangedTopicContactAddress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalContactsContactChangedTopicContactAddress" /> class.
        /// </summary>
        /// <param name="Address1">Address1.</param>
        /// <param name="Address2">Address2.</param>
        /// <param name="City">City.</param>
        /// <param name="State">State.</param>
        /// <param name="PostalCode">PostalCode.</param>
        /// <param name="CountryCode">CountryCode.</param>
        public ExternalContactsContactChangedTopicContactAddress(string Address1 = null, string Address2 = null, string City = null, string State = null, string PostalCode = null, string CountryCode = null)
        {
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.City = City;
            this.State = State;
            this.PostalCode = PostalCode;
            this.CountryCode = CountryCode;
            
        }
        


        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }



        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }



        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }



        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }



        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }



        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalContactsContactChangedTopicContactAddress {\n");

            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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
            return this.Equals(obj as ExternalContactsContactChangedTopicContactAddress);
        }

        /// <summary>
        /// Returns true if ExternalContactsContactChangedTopicContactAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalContactsContactChangedTopicContactAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalContactsContactChangedTopicContactAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) &&
                (
                    this.Address2 == other.Address2 ||
                    this.Address2 != null &&
                    this.Address2.Equals(other.Address2)
                ) &&
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();

                if (this.Address2 != null)
                    hash = hash * 59 + this.Address2.GetHashCode();

                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();

                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();

                return hash;
            }
        }
    }

}
