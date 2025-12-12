using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// MetaData
	/// </summary>
	[DataContract]
	public partial class MetaData : IEquatable<MetaData>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MetaData" /> class.
		/// </summary>
		/// <param name="PairingToken">PairingToken.</param>
		/// <param name="PairingTrust">PairingTrust.</param>
		/// <param name="PairingUrl">PairingUrl.</param>
		public MetaData(string PairingToken = null, List<string> PairingTrust = null, string PairingUrl = null)
		{
			this.PairingToken = PairingToken;
			this.PairingTrust = PairingTrust;
			this.PairingUrl = PairingUrl;

		}



		/// <summary>
		/// Gets or Sets PairingToken
		/// </summary>
		[DataMember(Name = "pairing-token", EmitDefaultValue = false)]
		public string PairingToken { get; set; }



		/// <summary>
		/// Gets or Sets PairingTrust
		/// </summary>
		[DataMember(Name = "pairing-trust", EmitDefaultValue = false)]
		public List<string> PairingTrust { get; set; }



		/// <summary>
		/// Gets or Sets PairingUrl
		/// </summary>
		[DataMember(Name = "pairing-url", EmitDefaultValue = false)]
		public string PairingUrl { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MetaData {\n");

			sb.Append("  PairingToken: ").Append(PairingToken).Append("\n");
			sb.Append("  PairingTrust: ").Append(PairingTrust).Append("\n");
			sb.Append("  PairingUrl: ").Append(PairingUrl).Append("\n");
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
			return this.Equals(obj as MetaData);
		}

		/// <summary>
		/// Returns true if MetaData instances are equal
		/// </summary>
		/// <param name="other">Instance of MetaData to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MetaData other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.PairingToken == other.PairingToken ||
					this.PairingToken != null &&
					this.PairingToken.Equals(other.PairingToken)
				) &&
				(
					this.PairingTrust == other.PairingTrust ||
					this.PairingTrust != null &&
					this.PairingTrust.SequenceEqual(other.PairingTrust)
				) &&
				(
					this.PairingUrl == other.PairingUrl ||
					this.PairingUrl != null &&
					this.PairingUrl.Equals(other.PairingUrl)
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
				if (this.PairingToken != null)
					hash = hash * 59 + this.PairingToken.GetHashCode();

				if (this.PairingTrust != null)
					hash = hash * 59 + this.PairingTrust.GetHashCode();

				if (this.PairingUrl != null)
					hash = hash * 59 + this.PairingUrl.GetHashCode();

				return hash;
			}
		}
	}

}
