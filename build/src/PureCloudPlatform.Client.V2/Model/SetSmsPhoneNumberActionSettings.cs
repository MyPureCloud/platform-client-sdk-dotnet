using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SetSmsPhoneNumberActionSettings
	/// </summary>
	[DataContract]
	public partial class SetSmsPhoneNumberActionSettings : IEquatable<SetSmsPhoneNumberActionSettings>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="SetSmsPhoneNumberActionSettings" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected SetSmsPhoneNumberActionSettings() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="SetSmsPhoneNumberActionSettings" /> class.
		/// </summary>
		/// <param name="SenderSmsPhoneNumber">The string address for the sms phone number. (required).</param>
		public SetSmsPhoneNumberActionSettings(string SenderSmsPhoneNumber = null)
		{
			this.SenderSmsPhoneNumber = SenderSmsPhoneNumber;

		}



		/// <summary>
		/// The string address for the sms phone number.
		/// </summary>
		/// <value>The string address for the sms phone number.</value>
		[DataMember(Name = "senderSmsPhoneNumber", EmitDefaultValue = false)]
		public string SenderSmsPhoneNumber { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SetSmsPhoneNumberActionSettings {\n");

			sb.Append("  SenderSmsPhoneNumber: ").Append(SenderSmsPhoneNumber).Append("\n");
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
			return this.Equals(obj as SetSmsPhoneNumberActionSettings);
		}

		/// <summary>
		/// Returns true if SetSmsPhoneNumberActionSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of SetSmsPhoneNumberActionSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SetSmsPhoneNumberActionSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SenderSmsPhoneNumber == other.SenderSmsPhoneNumber ||
					this.SenderSmsPhoneNumber != null &&
					this.SenderSmsPhoneNumber.Equals(other.SenderSmsPhoneNumber)
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
				if (this.SenderSmsPhoneNumber != null)
					hash = hash * 59 + this.SenderSmsPhoneNumber.GetHashCode();

				return hash;
			}
		}
	}

}
