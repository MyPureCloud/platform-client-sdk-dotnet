using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DialerCampaignConfigChangeRestErrorDetail
	/// </summary>
	[DataContract]
	public partial class DialerCampaignConfigChangeRestErrorDetail : IEquatable<DialerCampaignConfigChangeRestErrorDetail>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DialerCampaignConfigChangeRestErrorDetail" /> class.
		/// </summary>
		/// <param name="Error">name of the error.</param>
		/// <param name="Details">additional information regarding the error.</param>
		/// <param name="AdditionalProperties">AdditionalProperties.</param>
		/// <param name="GetAdditionalProperties">GetAdditionalProperties.</param>
		public DialerCampaignConfigChangeRestErrorDetail(string Error = null, string Details = null, Dictionary<string, Object> AdditionalProperties = null, Dictionary<string, Object> GetAdditionalProperties = null)
		{
			this.Error = Error;
			this.Details = Details;
			this.AdditionalProperties = AdditionalProperties;
			this.GetAdditionalProperties = GetAdditionalProperties;

		}



		/// <summary>
		/// name of the error
		/// </summary>
		/// <value>name of the error</value>
		[DataMember(Name = "error", EmitDefaultValue = false)]
		public string Error { get; set; }



		/// <summary>
		/// additional information regarding the error
		/// </summary>
		/// <value>additional information regarding the error</value>
		[DataMember(Name = "details", EmitDefaultValue = false)]
		public string Details { get; set; }



		/// <summary>
		/// Gets or Sets AdditionalProperties
		/// </summary>
		[DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
		public Dictionary<string, Object> AdditionalProperties { get; set; }



		/// <summary>
		/// Gets or Sets GetAdditionalProperties
		/// </summary>
		[DataMember(Name = "getAdditionalProperties", EmitDefaultValue = false)]
		public Dictionary<string, Object> GetAdditionalProperties { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DialerCampaignConfigChangeRestErrorDetail {\n");

			sb.Append("  Error: ").Append(Error).Append("\n");
			sb.Append("  Details: ").Append(Details).Append("\n");
			sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
			sb.Append("  GetAdditionalProperties: ").Append(GetAdditionalProperties).Append("\n");
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
			return this.Equals(obj as DialerCampaignConfigChangeRestErrorDetail);
		}

		/// <summary>
		/// Returns true if DialerCampaignConfigChangeRestErrorDetail instances are equal
		/// </summary>
		/// <param name="other">Instance of DialerCampaignConfigChangeRestErrorDetail to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DialerCampaignConfigChangeRestErrorDetail other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Error == other.Error ||
					this.Error != null &&
					this.Error.Equals(other.Error)
				) &&
				(
					this.Details == other.Details ||
					this.Details != null &&
					this.Details.Equals(other.Details)
				) &&
				(
					this.AdditionalProperties == other.AdditionalProperties ||
					this.AdditionalProperties != null &&
					this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
				) &&
				(
					this.GetAdditionalProperties == other.GetAdditionalProperties ||
					this.GetAdditionalProperties != null &&
					this.GetAdditionalProperties.SequenceEqual(other.GetAdditionalProperties)
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
				if (this.Error != null)
					hash = hash * 59 + this.Error.GetHashCode();

				if (this.Details != null)
					hash = hash * 59 + this.Details.GetHashCode();

				if (this.AdditionalProperties != null)
					hash = hash * 59 + this.AdditionalProperties.GetHashCode();

				if (this.GetAdditionalProperties != null)
					hash = hash * 59 + this.GetAdditionalProperties.GetHashCode();

				return hash;
			}
		}
	}

}
