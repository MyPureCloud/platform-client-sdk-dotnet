using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// JourneyWebActionEventsNotificationGeoLocation
	/// </summary>
	[DataContract]
	public partial class JourneyWebActionEventsNotificationGeoLocation : IEquatable<JourneyWebActionEventsNotificationGeoLocation>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="JourneyWebActionEventsNotificationGeoLocation" /> class.
		/// </summary>
		/// <param name="Country">Country.</param>
		/// <param name="CountryName">CountryName.</param>
		/// <param name="Latitude">Latitude.</param>
		/// <param name="Longitude">Longitude.</param>
		/// <param name="Locality">Locality.</param>
		/// <param name="PostalCode">PostalCode.</param>
		/// <param name="Region">Region.</param>
		/// <param name="RegionName">RegionName.</param>
		/// <param name="Timezone">Timezone.</param>
		/// <param name="Source">Source.</param>
		public JourneyWebActionEventsNotificationGeoLocation(string Country = null, string CountryName = null, double? Latitude = null, double? Longitude = null, string Locality = null, string PostalCode = null, string Region = null, string RegionName = null, string Timezone = null, string Source = null)
		{
			this.Country = Country;
			this.CountryName = CountryName;
			this.Latitude = Latitude;
			this.Longitude = Longitude;
			this.Locality = Locality;
			this.PostalCode = PostalCode;
			this.Region = Region;
			this.RegionName = RegionName;
			this.Timezone = Timezone;
			this.Source = Source;

		}



		/// <summary>
		/// Gets or Sets Country
		/// </summary>
		[DataMember(Name = "country", EmitDefaultValue = false)]
		public string Country { get; set; }



		/// <summary>
		/// Gets or Sets CountryName
		/// </summary>
		[DataMember(Name = "countryName", EmitDefaultValue = false)]
		public string CountryName { get; set; }



		/// <summary>
		/// Gets or Sets Latitude
		/// </summary>
		[DataMember(Name = "latitude", EmitDefaultValue = false)]
		public double? Latitude { get; set; }



		/// <summary>
		/// Gets or Sets Longitude
		/// </summary>
		[DataMember(Name = "longitude", EmitDefaultValue = false)]
		public double? Longitude { get; set; }



		/// <summary>
		/// Gets or Sets Locality
		/// </summary>
		[DataMember(Name = "locality", EmitDefaultValue = false)]
		public string Locality { get; set; }



		/// <summary>
		/// Gets or Sets PostalCode
		/// </summary>
		[DataMember(Name = "postalCode", EmitDefaultValue = false)]
		public string PostalCode { get; set; }



		/// <summary>
		/// Gets or Sets Region
		/// </summary>
		[DataMember(Name = "region", EmitDefaultValue = false)]
		public string Region { get; set; }



		/// <summary>
		/// Gets or Sets RegionName
		/// </summary>
		[DataMember(Name = "regionName", EmitDefaultValue = false)]
		public string RegionName { get; set; }



		/// <summary>
		/// Gets or Sets Timezone
		/// </summary>
		[DataMember(Name = "timezone", EmitDefaultValue = false)]
		public string Timezone { get; set; }



		/// <summary>
		/// Gets or Sets Source
		/// </summary>
		[DataMember(Name = "source", EmitDefaultValue = false)]
		public string Source { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JourneyWebActionEventsNotificationGeoLocation {\n");

			sb.Append("  Country: ").Append(Country).Append("\n");
			sb.Append("  CountryName: ").Append(CountryName).Append("\n");
			sb.Append("  Latitude: ").Append(Latitude).Append("\n");
			sb.Append("  Longitude: ").Append(Longitude).Append("\n");
			sb.Append("  Locality: ").Append(Locality).Append("\n");
			sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
			sb.Append("  Region: ").Append(Region).Append("\n");
			sb.Append("  RegionName: ").Append(RegionName).Append("\n");
			sb.Append("  Timezone: ").Append(Timezone).Append("\n");
			sb.Append("  Source: ").Append(Source).Append("\n");
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
			return this.Equals(obj as JourneyWebActionEventsNotificationGeoLocation);
		}

		/// <summary>
		/// Returns true if JourneyWebActionEventsNotificationGeoLocation instances are equal
		/// </summary>
		/// <param name="other">Instance of JourneyWebActionEventsNotificationGeoLocation to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JourneyWebActionEventsNotificationGeoLocation other)
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
					this.Timezone == other.Timezone ||
					this.Timezone != null &&
					this.Timezone.Equals(other.Timezone)
				) &&
				(
					this.Source == other.Source ||
					this.Source != null &&
					this.Source.Equals(other.Source)
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

				if (this.Timezone != null)
					hash = hash * 59 + this.Timezone.GetHashCode();

				if (this.Source != null)
					hash = hash * 59 + this.Source.GetHashCode();

				return hash;
			}
		}
	}

}
