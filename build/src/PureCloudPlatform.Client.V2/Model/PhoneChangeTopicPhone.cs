using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PhoneChangeTopicPhone
	/// </summary>
	[DataContract]
	public partial class PhoneChangeTopicPhone : IEquatable<PhoneChangeTopicPhone>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PhoneChangeTopicPhone" /> class.
		/// </summary>
		/// <param name="UserAgentInfo">UserAgentInfo.</param>
		/// <param name="Id">Id.</param>
		/// <param name="Status">Status.</param>
		/// <param name="SecondaryStatus">SecondaryStatus.</param>
		public PhoneChangeTopicPhone(PhoneChangeTopicUserAgentInfo UserAgentInfo = null, string Id = null, PhoneChangeTopicPhoneStatus Status = null, PhoneChangeTopicPhoneStatus SecondaryStatus = null)
		{
			this.UserAgentInfo = UserAgentInfo;
			this.Id = Id;
			this.Status = Status;
			this.SecondaryStatus = SecondaryStatus;

		}



		/// <summary>
		/// Gets or Sets UserAgentInfo
		/// </summary>
		[DataMember(Name = "userAgentInfo", EmitDefaultValue = false)]
		public PhoneChangeTopicUserAgentInfo UserAgentInfo { get; set; }



		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public PhoneChangeTopicPhoneStatus Status { get; set; }



		/// <summary>
		/// Gets or Sets SecondaryStatus
		/// </summary>
		[DataMember(Name = "secondaryStatus", EmitDefaultValue = false)]
		public PhoneChangeTopicPhoneStatus SecondaryStatus { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PhoneChangeTopicPhone {\n");

			sb.Append("  UserAgentInfo: ").Append(UserAgentInfo).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  SecondaryStatus: ").Append(SecondaryStatus).Append("\n");
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
			return this.Equals(obj as PhoneChangeTopicPhone);
		}

		/// <summary>
		/// Returns true if PhoneChangeTopicPhone instances are equal
		/// </summary>
		/// <param name="other">Instance of PhoneChangeTopicPhone to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PhoneChangeTopicPhone other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.UserAgentInfo == other.UserAgentInfo ||
					this.UserAgentInfo != null &&
					this.UserAgentInfo.Equals(other.UserAgentInfo)
				) &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.SecondaryStatus == other.SecondaryStatus ||
					this.SecondaryStatus != null &&
					this.SecondaryStatus.Equals(other.SecondaryStatus)
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
				if (this.UserAgentInfo != null)
					hash = hash * 59 + this.UserAgentInfo.GetHashCode();

				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.SecondaryStatus != null)
					hash = hash * 59 + this.SecondaryStatus.GetHashCode();

				return hash;
			}
		}
	}

}
