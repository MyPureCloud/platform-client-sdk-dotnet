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
    /// JourneyGeolocation
    /// </summary>
    [DataContract]
    public partial class JourneyGeolocation :  IEquatable<JourneyGeolocation>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyGeolocation" /> class.
        /// </summary>
        /// <param name="Country">Geolocation&#39;s ISO 3166-1 alpha-2 country code..</param>
        /// <param name="CountryName">Geolocation&#39;s country name..</param>
        /// <param name="Latitude">Geolocation&#39;s latitude..</param>
        /// <param name="Longitude">Geolocation&#39;s longitude..</param>
        /// <param name="Locality">Geolocation&#39;s locality or city..</param>
        /// <param name="PostalCode">Geolocation&#39;s postal code or ZIP code..</param>
        /// <param name="Region">Geolocation&#39;s ISO-3166-2 region code..</param>
        /// <param name="RegionName">Geolocation&#39;s region name..</param>
        /// <param name="Source">The source that was used to determine the geolocation information..</param>
        /// <param name="Timezone">Geolocation&#39;s timezone..</param>
        public JourneyGeolocation(string Country = null, string CountryName = null, double? Latitude = null, double? Longitude = null, string Locality = null, string PostalCode = null, string Region = null, string RegionName = null, string Source = null, string Timezone = null)
        {
            this.Country = Country;
            this.CountryName = CountryName;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.Locality = Locality;
            this.PostalCode = PostalCode;
            this.Region = Region;
            this.RegionName = RegionName;
            this.Source = Source;
            this.Timezone = Timezone;
            
        }
        
        
        
        /// <summary>
        /// Geolocation&#39;s ISO 3166-1 alpha-2 country code.
        /// </summary>
        /// <value>Geolocation&#39;s ISO 3166-1 alpha-2 country code.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        
        
        
        /// <summary>
        /// Geolocation&#39;s country name.
        /// </summary>
        /// <value>Geolocation&#39;s country name.</value>
        [DataMember(Name="countryName", EmitDefaultValue=false)]
        public string CountryName { get; set; }
        
        
        
        /// <summary>
        /// Geolocation&#39;s latitude.
        /// </summary>
        /// <value>Geolocation&#39;s latitude.</value>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public double? Latitude { get; set; }
        
        
        
        /// <summary>
        /// Geolocation&#39;s longitude.
        /// </summary>
        /// <value>Geolocation&#39;s longitude.</value>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public double? Longitude { get; set; }
        
        
        
        /// <summary>
        /// Geolocation&#39;s locality or city.
        /// </summary>
        /// <value>Geolocation&#39;s locality or city.</value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }
        
        
        
        /// <summary>
        /// Geolocation&#39;s postal code or ZIP code.
        /// </summary>
        /// <value>Geolocation&#39;s postal code or ZIP code.</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
        
        
        
        /// <summary>
        /// Geolocation&#39;s ISO-3166-2 region code.
        /// </summary>
        /// <value>Geolocation&#39;s ISO-3166-2 region code.</value>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }
        
        
        
        /// <summary>
        /// Geolocation&#39;s region name.
        /// </summary>
        /// <value>Geolocation&#39;s region name.</value>
        [DataMember(Name="regionName", EmitDefaultValue=false)]
        public string RegionName { get; set; }
        
        
        
        /// <summary>
        /// The source that was used to determine the geolocation information.
        /// </summary>
        /// <value>The source that was used to determine the geolocation information.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }
        
        
        
        /// <summary>
        /// Geolocation&#39;s timezone.
        /// </summary>
        /// <value>Geolocation&#39;s timezone.</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyGeolocation {\n");
            
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  RegionName: ").Append(RegionName).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
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
            return this.Equals(obj as JourneyGeolocation);
        }

        /// <summary>
        /// Returns true if JourneyGeolocation instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyGeolocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyGeolocation other)
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
                    this.CountryName == other.CountryName ||
                    this.CountryName != null &&
                    this.CountryName.Equals(other.CountryName)
                ) &&
                (
                    this.Latitude == other.Latitude ||
                    this.Latitude != null &&
                    this.Latitude.Equals(other.Latitude)
                ) &&
                (
                    this.Longitude == other.Longitude ||
                    this.Longitude != null &&
                    this.Longitude.Equals(other.Longitude)
                ) &&
                (
                    this.Locality == other.Locality ||
                    this.Locality != null &&
                    this.Locality.Equals(other.Locality)
                ) &&
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) &&
                (
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
                ) &&
                (
                    this.RegionName == other.RegionName ||
                    this.RegionName != null &&
                    this.RegionName.Equals(other.RegionName)
                ) &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) &&
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
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
                
                if (this.CountryName != null)
                    hash = hash * 59 + this.CountryName.GetHashCode();
                
                if (this.Latitude != null)
                    hash = hash * 59 + this.Latitude.GetHashCode();
                
                if (this.Longitude != null)
                    hash = hash * 59 + this.Longitude.GetHashCode();
                
                if (this.Locality != null)
                    hash = hash * 59 + this.Locality.GetHashCode();
                
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                
                if (this.Region != null)
                    hash = hash * 59 + this.Region.GetHashCode();
                
                if (this.RegionName != null)
                    hash = hash * 59 + this.RegionName.GetHashCode();
                
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                
                return hash;
            }
        }
    }

}
