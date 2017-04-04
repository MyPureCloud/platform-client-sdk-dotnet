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
    /// GeolocationNotification
    /// </summary>
    [DataContract]
    public partial class GeolocationNotification :  IEquatable<GeolocationNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeolocationNotification" /> class.
        /// </summary>
        /// <param name="UserId">UserId.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Country">Country.</param>
        /// <param name="Region">Region.</param>
        /// <param name="City">City.</param>
        public GeolocationNotification(string UserId = null, string Type = null, string Country = null, string Region = null, string City = null)
        {
            this.UserId = UserId;
            this.Type = Type;
            this.Country = Country;
            this.Region = Region;
            this.City = City;
        }
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeolocationNotification {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
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
            return this.Equals(obj as GeolocationNotification);
        }

        /// <summary>
        /// Returns true if GeolocationNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of GeolocationNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeolocationNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) &&
                (
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
                ) &&
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Region != null)
                    hash = hash * 59 + this.Region.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                return hash;
            }
        }
    }

}
