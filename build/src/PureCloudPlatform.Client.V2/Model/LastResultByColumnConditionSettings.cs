using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LastResultByColumnConditionSettings
	/// </summary>
	[DataContract]
	public partial class LastResultByColumnConditionSettings : IEquatable<LastResultByColumnConditionSettings>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LastResultByColumnConditionSettings" /> class.
		/// </summary>
		/// <param name="EmailColumnName">The name of the contact column to evaluate for Email..</param>
		/// <param name="EmailWrapupCodes">A list of wrapup code identifiers to match for Email..</param>
		/// <param name="SmsColumnName">The name of the contact column to evaluate for SMS..</param>
		/// <param name="SmsWrapupCodes">A list of wrapup code identifiers to match for SMS..</param>
		public LastResultByColumnConditionSettings(string EmailColumnName = null, List<string> EmailWrapupCodes = null, string SmsColumnName = null, List<string> SmsWrapupCodes = null)
		{
			this.EmailColumnName = EmailColumnName;
			this.EmailWrapupCodes = EmailWrapupCodes;
			this.SmsColumnName = SmsColumnName;
			this.SmsWrapupCodes = SmsWrapupCodes;

		}



		/// <summary>
		/// The name of the contact column to evaluate for Email.
		/// </summary>
		/// <value>The name of the contact column to evaluate for Email.</value>
		[DataMember(Name = "emailColumnName", EmitDefaultValue = false)]
		public string EmailColumnName { get; set; }



		/// <summary>
		/// A list of wrapup code identifiers to match for Email.
		/// </summary>
		/// <value>A list of wrapup code identifiers to match for Email.</value>
		[DataMember(Name = "emailWrapupCodes", EmitDefaultValue = false)]
		public List<string> EmailWrapupCodes { get; set; }



		/// <summary>
		/// The name of the contact column to evaluate for SMS.
		/// </summary>
		/// <value>The name of the contact column to evaluate for SMS.</value>
		[DataMember(Name = "smsColumnName", EmitDefaultValue = false)]
		public string SmsColumnName { get; set; }



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
			sb.Append("class LastResultByColumnConditionSettings {\n");

			sb.Append("  EmailColumnName: ").Append(EmailColumnName).Append("\n");
			sb.Append("  EmailWrapupCodes: ").Append(EmailWrapupCodes).Append("\n");
			sb.Append("  SmsColumnName: ").Append(SmsColumnName).Append("\n");
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
			return this.Equals(obj as LastResultByColumnConditionSettings);
		}

		/// <summary>
		/// Returns true if LastResultByColumnConditionSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of LastResultByColumnConditionSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LastResultByColumnConditionSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.EmailColumnName == other.EmailColumnName ||
					this.EmailColumnName != null &&
					this.EmailColumnName.Equals(other.EmailColumnName)
				) &&
				(
					this.EmailWrapupCodes == other.EmailWrapupCodes ||
					this.EmailWrapupCodes != null &&
					this.EmailWrapupCodes.SequenceEqual(other.EmailWrapupCodes)
				) &&
				(
					this.SmsColumnName == other.SmsColumnName ||
					this.SmsColumnName != null &&
					this.SmsColumnName.Equals(other.SmsColumnName)
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
				if (this.EmailColumnName != null)
					hash = hash * 59 + this.EmailColumnName.GetHashCode();

				if (this.EmailWrapupCodes != null)
					hash = hash * 59 + this.EmailWrapupCodes.GetHashCode();

				if (this.SmsColumnName != null)
					hash = hash * 59 + this.SmsColumnName.GetHashCode();

				if (this.SmsWrapupCodes != null)
					hash = hash * 59 + this.SmsWrapupCodes.GetHashCode();

				return hash;
			}
		}
	}

}
