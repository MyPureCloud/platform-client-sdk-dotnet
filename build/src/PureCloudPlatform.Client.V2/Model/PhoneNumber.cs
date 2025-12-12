using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PhoneNumber
	/// </summary>
	[DataContract]
	public partial class PhoneNumber : IEquatable<PhoneNumber>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PhoneNumber" /> class.
		/// </summary>
		/// <param name="Display">The displayed form of the phone number string. Users should input the phone number in this field, but it will be altered by the API on write. If the phone number can be read as E164, the value will be replaced with international formatted-version of the number. If the number cannot be read as E164, the value will be preserved as-is. In both cases, the provided input string will be copied to the userInput field..</param>
		/// <param name="Extension">An optional extension for the provided phone number..</param>
		/// <param name="AcceptsSMS">Whether this phone number can accept SMS messages..</param>
		/// <param name="NormalizationCountryCode">The country code that will be used for E164 conversion of a provided phone number. If the country code is omitted from the provided phone number, the country code provided in this field will be used during the E164 conversion attempt. If this field is left empty, the default country code for any provided phone number that does not explicitly include a country code is assumed to be +1 (North America)..</param>
		/// <param name="UserInput">The user-inputted phone number string that was provided to the display field on write. This field is not user-writeable and will always be set by the system..</param>
		/// <param name="E164">The E164-formatted form of the provided phone number. This field is not user-writeable and will only be set when the provided phone number could be read as E164..</param>
		/// <param name="CountryCode">The detected country code from the provided phone number. This field is not user-writeable and will only be set when the provided phone number could be read as E164..</param>
		public PhoneNumber(string Display = null, long? Extension = null, bool? AcceptsSMS = null, string NormalizationCountryCode = null, string UserInput = null, string E164 = null, string CountryCode = null)
		{
			this.Display = Display;
			this.Extension = Extension;
			this.AcceptsSMS = AcceptsSMS;
			this.NormalizationCountryCode = NormalizationCountryCode;
			this.UserInput = UserInput;
			this.E164 = E164;
			this.CountryCode = CountryCode;

		}



		/// <summary>
		/// The displayed form of the phone number string. Users should input the phone number in this field, but it will be altered by the API on write. If the phone number can be read as E164, the value will be replaced with international formatted-version of the number. If the number cannot be read as E164, the value will be preserved as-is. In both cases, the provided input string will be copied to the userInput field.
		/// </summary>
		/// <value>The displayed form of the phone number string. Users should input the phone number in this field, but it will be altered by the API on write. If the phone number can be read as E164, the value will be replaced with international formatted-version of the number. If the number cannot be read as E164, the value will be preserved as-is. In both cases, the provided input string will be copied to the userInput field.</value>
		[DataMember(Name = "display", EmitDefaultValue = false)]
		public string Display { get; set; }



		/// <summary>
		/// An optional extension for the provided phone number.
		/// </summary>
		/// <value>An optional extension for the provided phone number.</value>
		[DataMember(Name = "extension", EmitDefaultValue = false)]
		public long? Extension { get; set; }



		/// <summary>
		/// Whether this phone number can accept SMS messages.
		/// </summary>
		/// <value>Whether this phone number can accept SMS messages.</value>
		[DataMember(Name = "acceptsSMS", EmitDefaultValue = false)]
		public bool? AcceptsSMS { get; set; }



		/// <summary>
		/// The country code that will be used for E164 conversion of a provided phone number. If the country code is omitted from the provided phone number, the country code provided in this field will be used during the E164 conversion attempt. If this field is left empty, the default country code for any provided phone number that does not explicitly include a country code is assumed to be +1 (North America).
		/// </summary>
		/// <value>The country code that will be used for E164 conversion of a provided phone number. If the country code is omitted from the provided phone number, the country code provided in this field will be used during the E164 conversion attempt. If this field is left empty, the default country code for any provided phone number that does not explicitly include a country code is assumed to be +1 (North America).</value>
		[DataMember(Name = "normalizationCountryCode", EmitDefaultValue = false)]
		public string NormalizationCountryCode { get; set; }



		/// <summary>
		/// The user-inputted phone number string that was provided to the display field on write. This field is not user-writeable and will always be set by the system.
		/// </summary>
		/// <value>The user-inputted phone number string that was provided to the display field on write. This field is not user-writeable and will always be set by the system.</value>
		[DataMember(Name = "userInput", EmitDefaultValue = false)]
		public string UserInput { get; set; }



		/// <summary>
		/// The E164-formatted form of the provided phone number. This field is not user-writeable and will only be set when the provided phone number could be read as E164.
		/// </summary>
		/// <value>The E164-formatted form of the provided phone number. This field is not user-writeable and will only be set when the provided phone number could be read as E164.</value>
		[DataMember(Name = "e164", EmitDefaultValue = false)]
		public string E164 { get; set; }



		/// <summary>
		/// The detected country code from the provided phone number. This field is not user-writeable and will only be set when the provided phone number could be read as E164.
		/// </summary>
		/// <value>The detected country code from the provided phone number. This field is not user-writeable and will only be set when the provided phone number could be read as E164.</value>
		[DataMember(Name = "countryCode", EmitDefaultValue = false)]
		public string CountryCode { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PhoneNumber {\n");

			sb.Append("  Display: ").Append(Display).Append("\n");
			sb.Append("  Extension: ").Append(Extension).Append("\n");
			sb.Append("  AcceptsSMS: ").Append(AcceptsSMS).Append("\n");
			sb.Append("  NormalizationCountryCode: ").Append(NormalizationCountryCode).Append("\n");
			sb.Append("  UserInput: ").Append(UserInput).Append("\n");
			sb.Append("  E164: ").Append(E164).Append("\n");
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
			return this.Equals(obj as PhoneNumber);
		}

		/// <summary>
		/// Returns true if PhoneNumber instances are equal
		/// </summary>
		/// <param name="other">Instance of PhoneNumber to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PhoneNumber other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Display == other.Display ||
					this.Display != null &&
					this.Display.Equals(other.Display)
				) &&
				(
					this.Extension == other.Extension ||
					this.Extension != null &&
					this.Extension.Equals(other.Extension)
				) &&
				(
					this.AcceptsSMS == other.AcceptsSMS ||
					this.AcceptsSMS != null &&
					this.AcceptsSMS.Equals(other.AcceptsSMS)
				) &&
				(
					this.NormalizationCountryCode == other.NormalizationCountryCode ||
					this.NormalizationCountryCode != null &&
					this.NormalizationCountryCode.Equals(other.NormalizationCountryCode)
				) &&
				(
					this.UserInput == other.UserInput ||
					this.UserInput != null &&
					this.UserInput.Equals(other.UserInput)
				) &&
				(
					this.E164 == other.E164 ||
					this.E164 != null &&
					this.E164.Equals(other.E164)
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
				if (this.Display != null)
					hash = hash * 59 + this.Display.GetHashCode();

				if (this.Extension != null)
					hash = hash * 59 + this.Extension.GetHashCode();

				if (this.AcceptsSMS != null)
					hash = hash * 59 + this.AcceptsSMS.GetHashCode();

				if (this.NormalizationCountryCode != null)
					hash = hash * 59 + this.NormalizationCountryCode.GetHashCode();

				if (this.UserInput != null)
					hash = hash * 59 + this.UserInput.GetHashCode();

				if (this.E164 != null)
					hash = hash * 59 + this.E164.GetHashCode();

				if (this.CountryCode != null)
					hash = hash * 59 + this.CountryCode.GetHashCode();

				return hash;
			}
		}
	}

}
