using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LastResultOverallConditionSettings
	/// </summary>
	[DataContract]
	public partial class LastResultOverallConditionSettings : IEquatable<LastResultOverallConditionSettings>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LastResultOverallConditionSettings" /> class.
		/// </summary>
		/// <param name="EmailWrapupCodes">A list of wrapup code identifiers to match for Email..</param>
		/// <param name="SmsWrapupCodes">A list of wrapup code identifiers to match for SMS..</param>
		public LastResultOverallConditionSettings(List<string> EmailWrapupCodes = null, List<string> SmsWrapupCodes = null)
		{
			this.EmailWrapupCodes = EmailWrapupCodes;
			this.SmsWrapupCodes = SmsWrapupCodes;

		}



		/// <summary>
		/// A list of wrapup code identifiers to match for Email.
		/// </summary>
		/// <value>A list of wrapup code identifiers to match for Email.</value>
		[DataMember(Name = "emailWrapupCodes", EmitDefaultValue = false)]
		public List<string> EmailWrapupCodes { get; set; }



		/// <summary>
		/// A list of wrapup code identifiers to match for SMS.
		/// </summary>
		/// <value>A list of wrapup code identifiers to match for SMS.</value>
		[DataMember(Name = "smsWrapupCodes", EmitDefaultValue = false)]
		public List<string> SmsWrapupCodes { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LastResultOverallConditionSettings {\n");

			sb.Append("  EmailWrapupCodes: ").Append(EmailWrapupCodes).Append("\n");
			sb.Append("  SmsWrapupCodes: ").Append(SmsWrapupCodes).Append("\n");
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
			return this.Equals(obj as LastResultOverallConditionSettings);
		}

		/// <summary>
		/// Returns true if LastResultOverallConditionSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of LastResultOverallConditionSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LastResultOverallConditionSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.EmailWrapupCodes == other.EmailWrapupCodes ||
					this.EmailWrapupCodes != null &&
					this.EmailWrapupCodes.SequenceEqual(other.EmailWrapupCodes)
				) &&
				(
					this.SmsWrapupCodes == other.SmsWrapupCodes ||
					this.SmsWrapupCodes != null &&
					this.SmsWrapupCodes.SequenceEqual(other.SmsWrapupCodes)
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
				if (this.EmailWrapupCodes != null)
					hash = hash * 59 + this.EmailWrapupCodes.GetHashCode();

				if (this.SmsWrapupCodes != null)
					hash = hash * 59 + this.SmsWrapupCodes.GetHashCode();

				return hash;
			}
		}
	}

}
