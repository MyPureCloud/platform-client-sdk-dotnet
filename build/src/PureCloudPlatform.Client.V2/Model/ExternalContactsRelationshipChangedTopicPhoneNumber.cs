using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ExternalContactsRelationshipChangedTopicPhoneNumber
	/// </summary>
	[DataContract]
	public partial class ExternalContactsRelationshipChangedTopicPhoneNumber : IEquatable<ExternalContactsRelationshipChangedTopicPhoneNumber>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ExternalContactsRelationshipChangedTopicPhoneNumber" /> class.
		/// </summary>
		/// <param name="Display">Display.</param>
		/// <param name="Extension">Extension.</param>
		/// <param name="AcceptsSMS">AcceptsSMS.</param>
		/// <param name="UserInput">UserInput.</param>
		/// <param name="E164">E164.</param>
		/// <param name="CountryCode">CountryCode.</param>
		/// <param name="NormalizationCountryCode">NormalizationCountryCode.</param>
		public ExternalContactsRelationshipChangedTopicPhoneNumber(string Display = null, long? Extension = null, bool? AcceptsSMS = null, string UserInput = null, string E164 = null, string CountryCode = null, string NormalizationCountryCode = null)
		{
			this.Display = Display;
			this.Extension = Extension;
			this.AcceptsSMS = AcceptsSMS;
			this.UserInput = UserInput;
			this.E164 = E164;
			this.CountryCode = CountryCode;
			this.NormalizationCountryCode = NormalizationCountryCode;

		}



		/// <summary>
		/// Gets or Sets Display
		/// </summary>
		[DataMember(Name = "display", EmitDefaultValue = false)]
		public string Display { get; set; }



		/// <summary>
		/// Gets or Sets Extension
		/// </summary>
		[DataMember(Name = "extension", EmitDefaultValue = false)]
		public long? Extension { get; set; }



		/// <summary>
		/// Gets or Sets AcceptsSMS
		/// </summary>
		[DataMember(Name = "acceptsSMS", EmitDefaultValue = false)]
		public bool? AcceptsSMS { get; set; }



		/// <summary>
		/// Gets or Sets UserInput
		/// </summary>
		[DataMember(Name = "userInput", EmitDefaultValue = false)]
		public string UserInput { get; set; }



		/// <summary>
		/// Gets or Sets E164
		/// </summary>
		[DataMember(Name = "e164", EmitDefaultValue = false)]
		public string E164 { get; set; }



		/// <summary>
		/// Gets or Sets CountryCode
		/// </summary>
		[DataMember(Name = "countryCode", EmitDefaultValue = false)]
		public string CountryCode { get; set; }



		/// <summary>
		/// Gets or Sets NormalizationCountryCode
		/// </summary>
		[DataMember(Name = "normalizationCountryCode", EmitDefaultValue = false)]
		public string NormalizationCountryCode { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ExternalContactsRelationshipChangedTopicPhoneNumber {\n");

			sb.Append("  Display: ").Append(Display).Append("\n");
			sb.Append("  Extension: ").Append(Extension).Append("\n");
			sb.Append("  AcceptsSMS: ").Append(AcceptsSMS).Append("\n");
			sb.Append("  UserInput: ").Append(UserInput).Append("\n");
			sb.Append("  E164: ").Append(E164).Append("\n");
			sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
			sb.Append("  NormalizationCountryCode: ").Append(NormalizationCountryCode).Append("\n");
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
			return this.Equals(obj as ExternalContactsRelationshipChangedTopicPhoneNumber);
		}

		/// <summary>
		/// Returns true if ExternalContactsRelationshipChangedTopicPhoneNumber instances are equal
		/// </summary>
		/// <param name="other">Instance of ExternalContactsRelationshipChangedTopicPhoneNumber to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ExternalContactsRelationshipChangedTopicPhoneNumber other)
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
				) &&
				(
					this.NormalizationCountryCode == other.NormalizationCountryCode ||
					this.NormalizationCountryCode != null &&
					this.NormalizationCountryCode.Equals(other.NormalizationCountryCode)
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

				if (this.UserInput != null)
					hash = hash * 59 + this.UserInput.GetHashCode();

				if (this.E164 != null)
					hash = hash * 59 + this.E164.GetHashCode();

				if (this.CountryCode != null)
					hash = hash * 59 + this.CountryCode.GetHashCode();

				if (this.NormalizationCountryCode != null)
					hash = hash * 59 + this.NormalizationCountryCode.GetHashCode();

				return hash;
			}
		}
	}

}
