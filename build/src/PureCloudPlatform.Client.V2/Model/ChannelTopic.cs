using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ChannelTopic
	/// </summary>
	[DataContract]
	public partial class ChannelTopic : IEquatable<ChannelTopic>
	{
		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StateEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Permitted for "Permitted"
			/// </summary>
			[EnumMember(Value = "Permitted")]
			Permitted,

			/// <summary>
			/// Enum Rejected for "Rejected"
			/// </summary>
			[EnumMember(Value = "Rejected")]
			Rejected
		}
		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public StateEnum? State { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ChannelTopic" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="State">State.</param>
		/// <param name="RejectionReason">RejectionReason.</param>
		/// <param name="MissingPermissions">MissingPermissions.</param>
		public ChannelTopic(string Id = null, StateEnum? State = null, string RejectionReason = null, List<string> MissingPermissions = null)
		{
			this.Id = Id;
			this.State = State;
			this.RejectionReason = RejectionReason;
			this.MissingPermissions = MissingPermissions;

		}



		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }





		/// <summary>
		/// Gets or Sets RejectionReason
		/// </summary>
		[DataMember(Name = "rejectionReason", EmitDefaultValue = false)]
		public string RejectionReason { get; set; }



		/// <summary>
		/// Gets or Sets MissingPermissions
		/// </summary>
		[DataMember(Name = "missingPermissions", EmitDefaultValue = false)]
		public List<string> MissingPermissions { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ChannelTopic {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  RejectionReason: ").Append(RejectionReason).Append("\n");
			sb.Append("  MissingPermissions: ").Append(MissingPermissions).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as ChannelTopic);
		}

		/// <summary>
		/// Returns true if ChannelTopic instances are equal
		/// </summary>
		/// <param name="other">Instance of ChannelTopic to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ChannelTopic other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.State == other.State ||
					this.State != null &&
					this.State.Equals(other.State)
				) &&
				(
					this.RejectionReason == other.RejectionReason ||
					this.RejectionReason != null &&
					this.RejectionReason.Equals(other.RejectionReason)
				) &&
				(
					this.MissingPermissions == other.MissingPermissions ||
					this.MissingPermissions != null &&
					this.MissingPermissions.SequenceEqual(other.MissingPermissions)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.State != null)
					hash = hash * 59 + this.State.GetHashCode();

				if (this.RejectionReason != null)
					hash = hash * 59 + this.RejectionReason.GetHashCode();

				if (this.MissingPermissions != null)
					hash = hash * 59 + this.MissingPermissions.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
