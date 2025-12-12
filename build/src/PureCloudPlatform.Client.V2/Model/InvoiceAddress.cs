using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// InvoiceAddress
	/// </summary>
	[DataContract]
	public partial class InvoiceAddress : IEquatable<InvoiceAddress>
	{
		/// <summary>
		/// The type of address.
		/// </summary>
		/// <value>The type of address.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum AddressTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Billto for "BillTo"
			/// </summary>
			[EnumMember(Value = "BillTo")]
			Billto,

			/// <summary>
			/// Enum Shipto for "ShipTo"
			/// </summary>
			[EnumMember(Value = "ShipTo")]
			Shipto,

			/// <summary>
			/// Enum Enduser for "EndUser"
			/// </summary>
			[EnumMember(Value = "EndUser")]
			Enduser,

			/// <summary>
			/// Enum Soldto for "SoldTo"
			/// </summary>
			[EnumMember(Value = "SoldTo")]
			Soldto
		}
		/// <summary>
		/// The type of address.
		/// </summary>
		/// <value>The type of address.</value>
		[DataMember(Name = "addressType", EmitDefaultValue = false)]
		public AddressTypeEnum? AddressType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="InvoiceAddress" /> class.
		/// </summary>
		/// <param name="DateEffective">The date when the Address became effective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="AddressType">The type of address..</param>
		/// <param name="CurrencyIsoCode">Contains the ISO code for any currency allowed by the organization..</param>
		/// <param name="Line1">The first line of the Address..</param>
		/// <param name="Line2">The second line of the Address..</param>
		/// <param name="Line3">The third line of the Address..</param>
		/// <param name="CityName">The city name..</param>
		/// <param name="PostalCode">The Postal or Zip Code..</param>
		/// <param name="StateCode">The code that reflects the geographic state for the Address..</param>
		/// <param name="CountryCode">The code representing the country for the Address (ISO_3166)..</param>
		/// <param name="CitySubdivision1">The primary subdivision within a city (e.g., district, neighborhood)..</param>
		/// <param name="RegionSubdivision1">The primary administrative division within a region (e.g., state, province)..</param>
		/// <param name="RegionSubdivision2">A secondary subdivision within the primary region subdivision (e.g., county, district)..</param>
		/// <param name="Country">Stores the name of the country in which the address is situated..</param>
		public InvoiceAddress(String DateEffective = null, AddressTypeEnum? AddressType = null, string CurrencyIsoCode = null, string Line1 = null, string Line2 = null, string Line3 = null, string CityName = null, string PostalCode = null, string StateCode = null, string CountryCode = null, string CitySubdivision1 = null, string RegionSubdivision1 = null, string RegionSubdivision2 = null, string Country = null)
		{
			this.DateEffective = DateEffective;
			this.AddressType = AddressType;
			this.CurrencyIsoCode = CurrencyIsoCode;
			this.Line1 = Line1;
			this.Line2 = Line2;
			this.Line3 = Line3;
			this.CityName = CityName;
			this.PostalCode = PostalCode;
			this.StateCode = StateCode;
			this.CountryCode = CountryCode;
			this.CitySubdivision1 = CitySubdivision1;
			this.RegionSubdivision1 = RegionSubdivision1;
			this.RegionSubdivision2 = RegionSubdivision2;
			this.Country = Country;

		}



		/// <summary>
		/// The date when the Address became effective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The date when the Address became effective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateEffective", EmitDefaultValue = false)]
		public String DateEffective { get; set; }





		/// <summary>
		/// Contains the ISO code for any currency allowed by the organization.
		/// </summary>
		/// <value>Contains the ISO code for any currency allowed by the organization.</value>
		[DataMember(Name = "currencyIsoCode", EmitDefaultValue = false)]
		public string CurrencyIsoCode { get; set; }



		/// <summary>
		/// The first line of the Address.
		/// </summary>
		/// <value>The first line of the Address.</value>
		[DataMember(Name = "line1", EmitDefaultValue = false)]
		public string Line1 { get; set; }



		/// <summary>
		/// The second line of the Address.
		/// </summary>
		/// <value>The second line of the Address.</value>
		[DataMember(Name = "line2", EmitDefaultValue = false)]
		public string Line2 { get; set; }



		/// <summary>
		/// The third line of the Address.
		/// </summary>
		/// <value>The third line of the Address.</value>
		[DataMember(Name = "line3", EmitDefaultValue = false)]
		public string Line3 { get; set; }



		/// <summary>
		/// The city name.
		/// </summary>
		/// <value>The city name.</value>
		[DataMember(Name = "cityName", EmitDefaultValue = false)]
		public string CityName { get; set; }



		/// <summary>
		/// The Postal or Zip Code.
		/// </summary>
		/// <value>The Postal or Zip Code.</value>
		[DataMember(Name = "postalCode", EmitDefaultValue = false)]
		public string PostalCode { get; set; }



		/// <summary>
		/// The code that reflects the geographic state for the Address.
		/// </summary>
		/// <value>The code that reflects the geographic state for the Address.</value>
		[DataMember(Name = "stateCode", EmitDefaultValue = false)]
		public string StateCode { get; set; }



		/// <summary>
		/// The code representing the country for the Address (ISO_3166).
		/// </summary>
		/// <value>The code representing the country for the Address (ISO_3166).</value>
		[DataMember(Name = "countryCode", EmitDefaultValue = false)]
		public string CountryCode { get; set; }



		/// <summary>
		/// The primary subdivision within a city (e.g., district, neighborhood).
		/// </summary>
		/// <value>The primary subdivision within a city (e.g., district, neighborhood).</value>
		[DataMember(Name = "citySubdivision1", EmitDefaultValue = false)]
		public string CitySubdivision1 { get; set; }



		/// <summary>
		/// The primary administrative division within a region (e.g., state, province).
		/// </summary>
		/// <value>The primary administrative division within a region (e.g., state, province).</value>
		[DataMember(Name = "regionSubdivision1", EmitDefaultValue = false)]
		public string RegionSubdivision1 { get; set; }



		/// <summary>
		/// A secondary subdivision within the primary region subdivision (e.g., county, district).
		/// </summary>
		/// <value>A secondary subdivision within the primary region subdivision (e.g., county, district).</value>
		[DataMember(Name = "regionSubdivision2", EmitDefaultValue = false)]
		public string RegionSubdivision2 { get; set; }



		/// <summary>
		/// Stores the name of the country in which the address is situated.
		/// </summary>
		/// <value>Stores the name of the country in which the address is situated.</value>
		[DataMember(Name = "country", EmitDefaultValue = false)]
		public string Country { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InvoiceAddress {\n");

			sb.Append("  DateEffective: ").Append(DateEffective).Append("\n");
			sb.Append("  AddressType: ").Append(AddressType).Append("\n");
			sb.Append("  CurrencyIsoCode: ").Append(CurrencyIsoCode).Append("\n");
			sb.Append("  Line1: ").Append(Line1).Append("\n");
			sb.Append("  Line2: ").Append(Line2).Append("\n");
			sb.Append("  Line3: ").Append(Line3).Append("\n");
			sb.Append("  CityName: ").Append(CityName).Append("\n");
			sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
			sb.Append("  StateCode: ").Append(StateCode).Append("\n");
			sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
			sb.Append("  CitySubdivision1: ").Append(CitySubdivision1).Append("\n");
			sb.Append("  RegionSubdivision1: ").Append(RegionSubdivision1).Append("\n");
			sb.Append("  RegionSubdivision2: ").Append(RegionSubdivision2).Append("\n");
			sb.Append("  Country: ").Append(Country).Append("\n");
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
			return this.Equals(obj as InvoiceAddress);
		}

		/// <summary>
		/// Returns true if InvoiceAddress instances are equal
		/// </summary>
		/// <param name="other">Instance of InvoiceAddress to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(InvoiceAddress other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DateEffective == other.DateEffective ||
					this.DateEffective != null &&
					this.DateEffective.Equals(other.DateEffective)
				) &&
				(
					this.AddressType == other.AddressType ||
					this.AddressType != null &&
					this.AddressType.Equals(other.AddressType)
				) &&
				(
					this.CurrencyIsoCode == other.CurrencyIsoCode ||
					this.CurrencyIsoCode != null &&
					this.CurrencyIsoCode.Equals(other.CurrencyIsoCode)
				) &&
				(
					this.Line1 == other.Line1 ||
					this.Line1 != null &&
					this.Line1.Equals(other.Line1)
				) &&
				(
					this.Line2 == other.Line2 ||
					this.Line2 != null &&
					this.Line2.Equals(other.Line2)
				) &&
				(
					this.Line3 == other.Line3 ||
					this.Line3 != null &&
					this.Line3.Equals(other.Line3)
				) &&
				(
					this.CityName == other.CityName ||
					this.CityName != null &&
					this.CityName.Equals(other.CityName)
				) &&
				(
					this.PostalCode == other.PostalCode ||
					this.PostalCode != null &&
					this.PostalCode.Equals(other.PostalCode)
				) &&
				(
					this.StateCode == other.StateCode ||
					this.StateCode != null &&
					this.StateCode.Equals(other.StateCode)
				) &&
				(
					this.CountryCode == other.CountryCode ||
					this.CountryCode != null &&
					this.CountryCode.Equals(other.CountryCode)
				) &&
				(
					this.CitySubdivision1 == other.CitySubdivision1 ||
					this.CitySubdivision1 != null &&
					this.CitySubdivision1.Equals(other.CitySubdivision1)
				) &&
				(
					this.RegionSubdivision1 == other.RegionSubdivision1 ||
					this.RegionSubdivision1 != null &&
					this.RegionSubdivision1.Equals(other.RegionSubdivision1)
				) &&
				(
					this.RegionSubdivision2 == other.RegionSubdivision2 ||
					this.RegionSubdivision2 != null &&
					this.RegionSubdivision2.Equals(other.RegionSubdivision2)
				) &&
				(
					this.Country == other.Country ||
					this.Country != null &&
					this.Country.Equals(other.Country)
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
				if (this.DateEffective != null)
					hash = hash * 59 + this.DateEffective.GetHashCode();

				if (this.AddressType != null)
					hash = hash * 59 + this.AddressType.GetHashCode();

				if (this.CurrencyIsoCode != null)
					hash = hash * 59 + this.CurrencyIsoCode.GetHashCode();

				if (this.Line1 != null)
					hash = hash * 59 + this.Line1.GetHashCode();

				if (this.Line2 != null)
					hash = hash * 59 + this.Line2.GetHashCode();

				if (this.Line3 != null)
					hash = hash * 59 + this.Line3.GetHashCode();

				if (this.CityName != null)
					hash = hash * 59 + this.CityName.GetHashCode();

				if (this.PostalCode != null)
					hash = hash * 59 + this.PostalCode.GetHashCode();

				if (this.StateCode != null)
					hash = hash * 59 + this.StateCode.GetHashCode();

				if (this.CountryCode != null)
					hash = hash * 59 + this.CountryCode.GetHashCode();

				if (this.CitySubdivision1 != null)
					hash = hash * 59 + this.CitySubdivision1.GetHashCode();

				if (this.RegionSubdivision1 != null)
					hash = hash * 59 + this.RegionSubdivision1.GetHashCode();

				if (this.RegionSubdivision2 != null)
					hash = hash * 59 + this.RegionSubdivision2.GetHashCode();

				if (this.Country != null)
					hash = hash * 59 + this.Country.GetHashCode();

				return hash;
			}
		}
	}

}
