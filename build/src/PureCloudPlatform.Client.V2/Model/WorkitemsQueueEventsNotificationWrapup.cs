using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkitemsQueueEventsNotificationWrapup
	/// </summary>
	[DataContract]
	public partial class WorkitemsQueueEventsNotificationWrapup : IEquatable<WorkitemsQueueEventsNotificationWrapup>
	{
		/// <summary>
		/// Gets or Sets Op
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum OpEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown,

			/// <summary>
			/// Enum Add for "Add"
			/// </summary>
			[EnumMember(Value = "Add")]
			Add,

			/// <summary>
			/// Enum Remove for "Remove"
			/// </summary>
			[EnumMember(Value = "Remove")]
			Remove
		}
		/// <summary>
		/// Gets or Sets Action
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ActionEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown,

			/// <summary>
			/// Enum Add for "Add"
			/// </summary>
			[EnumMember(Value = "Add")]
			Add,

			/// <summary>
			/// Enum Remove for "Remove"
			/// </summary>
			[EnumMember(Value = "Remove")]
			Remove
		}
		/// <summary>
		/// Gets or Sets Op
		/// </summary>
		[DataMember(Name = "op", EmitDefaultValue = false)]
		public OpEnum? Op { get; set; }
		/// <summary>
		/// Gets or Sets Action
		/// </summary>
		[DataMember(Name = "action", EmitDefaultValue = false)]
		public ActionEnum? Action { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkitemsQueueEventsNotificationWrapup" /> class.
		/// </summary>
		/// <param name="Code">Code.</param>
		/// <param name="UserId">UserId.</param>
		/// <param name="Op">Op.</param>
		/// <param name="Action">Action.</param>
		public WorkitemsQueueEventsNotificationWrapup(string Code = null, Guid? UserId = null, OpEnum? Op = null, ActionEnum? Action = null)
		{
			this.Code = Code;
			this.UserId = UserId;
			this.Op = Op;
			this.Action = Action;

		}



		/// <summary>
		/// Gets or Sets Code
		/// </summary>
		[DataMember(Name = "code", EmitDefaultValue = false)]
		public string Code { get; set; }



		/// <summary>
		/// Gets or Sets UserId
		/// </summary>
		[DataMember(Name = "userId", EmitDefaultValue = false)]
		public Guid? UserId { get; set; }






		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkitemsQueueEventsNotificationWrapup {\n");

			sb.Append("  Code: ").Append(Code).Append("\n");
			sb.Append("  UserId: ").Append(UserId).Append("\n");
			sb.Append("  Op: ").Append(Op).Append("\n");
			sb.Append("  Action: ").Append(Action).Append("\n");
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
			return this.Equals(obj as WorkitemsQueueEventsNotificationWrapup);
		}

		/// <summary>
		/// Returns true if WorkitemsQueueEventsNotificationWrapup instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkitemsQueueEventsNotificationWrapup to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkitemsQueueEventsNotificationWrapup other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Code == other.Code ||
					this.Code != null &&
					this.Code.Equals(other.Code)
				) &&
				(
					this.UserId == other.UserId ||
					this.UserId != null &&
					this.UserId.Equals(other.UserId)
				) &&
				(
					this.Op == other.Op ||
					this.Op != null &&
					this.Op.Equals(other.Op)
				) &&
				(
					this.Action == other.Action ||
					this.Action != null &&
					this.Action.Equals(other.Action)
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
				if (this.Code != null)
					hash = hash * 59 + this.Code.GetHashCode();

				if (this.UserId != null)
					hash = hash * 59 + this.UserId.GetHashCode();

				if (this.Op != null)
					hash = hash * 59 + this.Op.GetHashCode();

				if (this.Action != null)
					hash = hash * 59 + this.Action.GetHashCode();

				return hash;
			}
		}
	}

}
