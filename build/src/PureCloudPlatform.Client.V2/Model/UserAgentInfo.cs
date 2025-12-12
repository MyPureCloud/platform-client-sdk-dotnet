using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UserAgentInfo
	/// </summary>
	[DataContract]
	public partial class UserAgentInfo : IEquatable<UserAgentInfo>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UserAgentInfo" /> class.
		/// </summary>
		/// <param name="FirmwareVersion">The firmware version of the phone..</param>
		/// <param name="Manufacturer">The manufacturer of the phone..</param>
		/// <param name="Model">The model of the phone..</param>
		public UserAgentInfo(string FirmwareVersion = null, string Manufacturer = null, string Model = null)
		{
			this.FirmwareVersion = FirmwareVersion;
			this.Manufacturer = Manufacturer;
			this.Model = Model;

		}



		/// <summary>
		/// The firmware version of the phone.
		/// </summary>
		/// <value>The firmware version of the phone.</value>
		[DataMember(Name = "firmwareVersion", EmitDefaultValue = false)]
		public string FirmwareVersion { get; set; }



		/// <summary>
		/// The manufacturer of the phone.
		/// </summary>
		/// <value>The manufacturer of the phone.</value>
		[DataMember(Name = "manufacturer", EmitDefaultValue = false)]
		public string Manufacturer { get; set; }



		/// <summary>
		/// The model of the phone.
		/// </summary>
		/// <value>The model of the phone.</value>
		[DataMember(Name = "model", EmitDefaultValue = false)]
		public string Model { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserAgentInfo {\n");

			sb.Append("  FirmwareVersion: ").Append(FirmwareVersion).Append("\n");
			sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
			sb.Append("  Model: ").Append(Model).Append("\n");
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
			return this.Equals(obj as UserAgentInfo);
		}

		/// <summary>
		/// Returns true if UserAgentInfo instances are equal
		/// </summary>
		/// <param name="other">Instance of UserAgentInfo to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserAgentInfo other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.FirmwareVersion == other.FirmwareVersion ||
					this.FirmwareVersion != null &&
					this.FirmwareVersion.Equals(other.FirmwareVersion)
				) &&
				(
					this.Manufacturer == other.Manufacturer ||
					this.Manufacturer != null &&
					this.Manufacturer.Equals(other.Manufacturer)
				) &&
				(
					this.Model == other.Model ||
					this.Model != null &&
					this.Model.Equals(other.Model)
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
				if (this.FirmwareVersion != null)
					hash = hash * 59 + this.FirmwareVersion.GetHashCode();

				if (this.Manufacturer != null)
					hash = hash * 59 + this.Manufacturer.GetHashCode();

				if (this.Model != null)
					hash = hash * 59 + this.Model.GetHashCode();

				return hash;
			}
		}
	}

}
