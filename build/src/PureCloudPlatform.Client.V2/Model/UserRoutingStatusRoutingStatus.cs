using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UserRoutingStatusRoutingStatus
	/// </summary>
	[DataContract]
	public partial class UserRoutingStatusRoutingStatus : IEquatable<UserRoutingStatusRoutingStatus>
	{
		/// <summary>
		/// Indicates the Routing State of the agent.
		/// </summary>
		/// <value>Indicates the Routing State of the agent.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum OffQueue for "OFF_QUEUE"
			/// </summary>
			[EnumMember(Value = "OFF_QUEUE")]
			OffQueue,

			/// <summary>
			/// Enum Idle for "IDLE"
			/// </summary>
			[EnumMember(Value = "IDLE")]
			Idle,

			/// <summary>
			/// Enum Interacting for "INTERACTING"
			/// </summary>
			[EnumMember(Value = "INTERACTING")]
			Interacting,

			/// <summary>
			/// Enum NotResponding for "NOT_RESPONDING"
			/// </summary>
			[EnumMember(Value = "NOT_RESPONDING")]
			NotResponding,

			/// <summary>
			/// Enum Communicating for "COMMUNICATING"
			/// </summary>
			[EnumMember(Value = "COMMUNICATING")]
			Communicating
		}
		/// <summary>
		/// Indicates the Routing State of the agent.
		/// </summary>
		/// <value>Indicates the Routing State of the agent.</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="UserRoutingStatusRoutingStatus" /> class.
		/// </summary>
		/// <param name="Status">Indicates the Routing State of the agent..</param>
		/// <param name="StartTime">The timestamp when the agent went into this state..</param>
		public UserRoutingStatusRoutingStatus(StatusEnum? Status = null, DateTime? StartTime = null)
		{
			this.Status = Status;
			this.StartTime = StartTime;

		}





		/// <summary>
		/// The timestamp when the agent went into this state.
		/// </summary>
		/// <value>The timestamp when the agent went into this state.</value>
		[DataMember(Name = "startTime", EmitDefaultValue = false)]
		public DateTime? StartTime { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserRoutingStatusRoutingStatus {\n");

			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
			return this.Equals(obj as UserRoutingStatusRoutingStatus);
		}

		/// <summary>
		/// Returns true if UserRoutingStatusRoutingStatus instances are equal
		/// </summary>
		/// <param name="other">Instance of UserRoutingStatusRoutingStatus to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserRoutingStatusRoutingStatus other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.StartTime == other.StartTime ||
					this.StartTime != null &&
					this.StartTime.Equals(other.StartTime)
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
				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.StartTime != null)
					hash = hash * 59 + this.StartTime.GetHashCode();

				return hash;
			}
		}
	}

}
