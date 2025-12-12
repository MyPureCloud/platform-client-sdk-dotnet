using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// MediaIceSelectedCandidate
	/// </summary>
	[DataContract]
	public partial class MediaIceSelectedCandidate : IEquatable<MediaIceSelectedCandidate>
	{
		/// <summary>
		/// Type of the selected candidate
		/// </summary>
		/// <value>Type of the selected candidate</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Host for "host"
			/// </summary>
			[EnumMember(Value = "host")]
			Host,

			/// <summary>
			/// Enum Srflx for "srflx"
			/// </summary>
			[EnumMember(Value = "srflx")]
			Srflx,

			/// <summary>
			/// Enum Prflx for "prflx"
			/// </summary>
			[EnumMember(Value = "prflx")]
			Prflx,

			/// <summary>
			/// Enum Relay for "relay"
			/// </summary>
			[EnumMember(Value = "relay")]
			Relay
		}
		/// <summary>
		/// Type of the selected candidate
		/// </summary>
		/// <value>Type of the selected candidate</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="MediaIceSelectedCandidate" /> class.
		/// </summary>
		/// <param name="Address">IP address and port of the candidate.</param>
		/// <param name="Type">Type of the selected candidate.</param>
		public MediaIceSelectedCandidate(string Address = null, TypeEnum? Type = null)
		{
			this.Address = Address;
			this.Type = Type;

		}



		/// <summary>
		/// IP address and port of the candidate
		/// </summary>
		/// <value>IP address and port of the candidate</value>
		[DataMember(Name = "address", EmitDefaultValue = false)]
		public string Address { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MediaIceSelectedCandidate {\n");

			sb.Append("  Address: ").Append(Address).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
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
			return this.Equals(obj as MediaIceSelectedCandidate);
		}

		/// <summary>
		/// Returns true if MediaIceSelectedCandidate instances are equal
		/// </summary>
		/// <param name="other">Instance of MediaIceSelectedCandidate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MediaIceSelectedCandidate other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Address == other.Address ||
					this.Address != null &&
					this.Address.Equals(other.Address)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
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
				if (this.Address != null)
					hash = hash * 59 + this.Address.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				return hash;
			}
		}
	}

}
