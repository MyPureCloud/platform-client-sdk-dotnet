using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// NluOrganization
	/// </summary>
	[DataContract]
	public partial class NluOrganization : IEquatable<NluOrganization>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="NluOrganization" /> class.
		/// </summary>
		/// <param name="Limits">The NLU limits defined for this Organization.</param>
		/// <param name="SupportedLanguagesInfo">The list of Supported features for each languages for this Organization.</param>
		public NluOrganization(Dictionary<string, int?> Limits = null, List<SupportedLanguagesInfoDefinition> SupportedLanguagesInfo = null)
		{
			this.Limits = Limits;
			this.SupportedLanguagesInfo = SupportedLanguagesInfo;

		}



		/// <summary>
		/// The NLU limits defined for this Organization
		/// </summary>
		/// <value>The NLU limits defined for this Organization</value>
		[DataMember(Name = "limits", EmitDefaultValue = false)]
		public Dictionary<string, int?> Limits { get; set; }



		/// <summary>
		/// The list of Supported features for each languages for this Organization
		/// </summary>
		/// <value>The list of Supported features for each languages for this Organization</value>
		[DataMember(Name = "supportedLanguagesInfo", EmitDefaultValue = false)]
		public List<SupportedLanguagesInfoDefinition> SupportedLanguagesInfo { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NluOrganization {\n");

			sb.Append("  Limits: ").Append(Limits).Append("\n");
			sb.Append("  SupportedLanguagesInfo: ").Append(SupportedLanguagesInfo).Append("\n");
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
			return this.Equals(obj as NluOrganization);
		}

		/// <summary>
		/// Returns true if NluOrganization instances are equal
		/// </summary>
		/// <param name="other">Instance of NluOrganization to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(NluOrganization other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Limits == other.Limits ||
					this.Limits != null &&
					this.Limits.SequenceEqual(other.Limits)
				) &&
				(
					this.SupportedLanguagesInfo == other.SupportedLanguagesInfo ||
					this.SupportedLanguagesInfo != null &&
					this.SupportedLanguagesInfo.SequenceEqual(other.SupportedLanguagesInfo)
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
				if (this.Limits != null)
					hash = hash * 59 + this.Limits.GetHashCode();

				if (this.SupportedLanguagesInfo != null)
					hash = hash * 59 + this.SupportedLanguagesInfo.GetHashCode();

				return hash;
			}
		}
	}

}
