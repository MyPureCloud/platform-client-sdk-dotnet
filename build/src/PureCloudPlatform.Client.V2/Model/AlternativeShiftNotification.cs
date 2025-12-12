using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AlternativeShiftNotification
	/// </summary>
	[DataContract]
	public partial class AlternativeShiftNotification : IEquatable<AlternativeShiftNotification>
	{
		/// <summary>
		/// The granularity of alternative shifts to be traded
		/// </summary>
		/// <value>The granularity of alternative shifts to be traded</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum GranularityEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Daily for "Daily"
			/// </summary>
			[EnumMember(Value = "Daily")]
			Daily
		}
		/// <summary>
		/// The new state of the alternative shift trade, null if there was no change
		/// </summary>
		/// <value>The new state of the alternative shift trade, null if there was no change</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum NewStateEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Canceled for "Canceled"
			/// </summary>
			[EnumMember(Value = "Canceled")]
			Canceled,

			/// <summary>
			/// Enum Denied for "Denied"
			/// </summary>
			[EnumMember(Value = "Denied")]
			Denied,

			/// <summary>
			/// Enum Expired for "Expired"
			/// </summary>
			[EnumMember(Value = "Expired")]
			Expired,

			/// <summary>
			/// Enum Submitted for "Submitted"
			/// </summary>
			[EnumMember(Value = "Submitted")]
			Submitted,

			/// <summary>
			/// Enum Approved for "Approved"
			/// </summary>
			[EnumMember(Value = "Approved")]
			Approved
		}
		/// <summary>
		/// The granularity of alternative shifts to be traded
		/// </summary>
		/// <value>The granularity of alternative shifts to be traded</value>
		[DataMember(Name = "granularity", EmitDefaultValue = false)]
		public GranularityEnum? Granularity { get; set; }
		/// <summary>
		/// The new state of the alternative shift trade, null if there was no change
		/// </summary>
		/// <value>The new state of the alternative shift trade, null if there was no change</value>
		[DataMember(Name = "newState", EmitDefaultValue = false)]
		public NewStateEnum? NewState { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="AlternativeShiftNotification" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AlternativeShiftNotification() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AlternativeShiftNotification" /> class.
		/// </summary>
		/// <param name="WeekDate">The start date of the schedule with which this trade is associated. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
		/// <param name="Granularity">The granularity of alternative shifts to be traded (required).</param>
		/// <param name="NewState">The new state of the alternative shift trade, null if there was no change.</param>
		/// <param name="InitiatingUser">The user who initiated the alternative shift trade (required).</param>
		/// <param name="InitiatingShiftDate">The start date and time of the initiating shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		/// <param name="ReceivingUser">The user on the receiving side of this alternative shift trade.</param>
		/// <param name="ReceivingShiftDate">The start date and time of the receiving alternative shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		public AlternativeShiftNotification(String WeekDate = null, GranularityEnum? Granularity = null, NewStateEnum? NewState = null, UserReference InitiatingUser = null, DateTime? InitiatingShiftDate = null, UserReference ReceivingUser = null, DateTime? ReceivingShiftDate = null)
		{
			this.WeekDate = WeekDate;
			this.Granularity = Granularity;
			this.NewState = NewState;
			this.InitiatingUser = InitiatingUser;
			this.InitiatingShiftDate = InitiatingShiftDate;
			this.ReceivingUser = ReceivingUser;
			this.ReceivingShiftDate = ReceivingShiftDate;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The start date of the schedule with which this trade is associated. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The start date of the schedule with which this trade is associated. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "weekDate", EmitDefaultValue = false)]
		public String WeekDate { get; set; }







		/// <summary>
		/// The user who initiated the alternative shift trade
		/// </summary>
		/// <value>The user who initiated the alternative shift trade</value>
		[DataMember(Name = "initiatingUser", EmitDefaultValue = false)]
		public UserReference InitiatingUser { get; set; }



		/// <summary>
		/// The start date and time of the initiating shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The start date and time of the initiating shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "initiatingShiftDate", EmitDefaultValue = false)]
		public DateTime? InitiatingShiftDate { get; set; }



		/// <summary>
		/// The user on the receiving side of this alternative shift trade
		/// </summary>
		/// <value>The user on the receiving side of this alternative shift trade</value>
		[DataMember(Name = "receivingUser", EmitDefaultValue = false)]
		public UserReference ReceivingUser { get; set; }



		/// <summary>
		/// The start date and time of the receiving alternative shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The start date and time of the receiving alternative shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "receivingShiftDate", EmitDefaultValue = false)]
		public DateTime? ReceivingShiftDate { get; set; }



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
			sb.Append("class AlternativeShiftNotification {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
			sb.Append("  Granularity: ").Append(Granularity).Append("\n");
			sb.Append("  NewState: ").Append(NewState).Append("\n");
			sb.Append("  InitiatingUser: ").Append(InitiatingUser).Append("\n");
			sb.Append("  InitiatingShiftDate: ").Append(InitiatingShiftDate).Append("\n");
			sb.Append("  ReceivingUser: ").Append(ReceivingUser).Append("\n");
			sb.Append("  ReceivingShiftDate: ").Append(ReceivingShiftDate).Append("\n");
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
			return this.Equals(obj as AlternativeShiftNotification);
		}

		/// <summary>
		/// Returns true if AlternativeShiftNotification instances are equal
		/// </summary>
		/// <param name="other">Instance of AlternativeShiftNotification to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AlternativeShiftNotification other)
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
					this.WeekDate == other.WeekDate ||
					this.WeekDate != null &&
					this.WeekDate.Equals(other.WeekDate)
				) &&
				(
					this.Granularity == other.Granularity ||
					this.Granularity != null &&
					this.Granularity.Equals(other.Granularity)
				) &&
				(
					this.NewState == other.NewState ||
					this.NewState != null &&
					this.NewState.Equals(other.NewState)
				) &&
				(
					this.InitiatingUser == other.InitiatingUser ||
					this.InitiatingUser != null &&
					this.InitiatingUser.Equals(other.InitiatingUser)
				) &&
				(
					this.InitiatingShiftDate == other.InitiatingShiftDate ||
					this.InitiatingShiftDate != null &&
					this.InitiatingShiftDate.Equals(other.InitiatingShiftDate)
				) &&
				(
					this.ReceivingUser == other.ReceivingUser ||
					this.ReceivingUser != null &&
					this.ReceivingUser.Equals(other.ReceivingUser)
				) &&
				(
					this.ReceivingShiftDate == other.ReceivingShiftDate ||
					this.ReceivingShiftDate != null &&
					this.ReceivingShiftDate.Equals(other.ReceivingShiftDate)
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

				if (this.WeekDate != null)
					hash = hash * 59 + this.WeekDate.GetHashCode();

				if (this.Granularity != null)
					hash = hash * 59 + this.Granularity.GetHashCode();

				if (this.NewState != null)
					hash = hash * 59 + this.NewState.GetHashCode();

				if (this.InitiatingUser != null)
					hash = hash * 59 + this.InitiatingUser.GetHashCode();

				if (this.InitiatingShiftDate != null)
					hash = hash * 59 + this.InitiatingShiftDate.GetHashCode();

				if (this.ReceivingUser != null)
					hash = hash * 59 + this.ReceivingUser.GetHashCode();

				if (this.ReceivingShiftDate != null)
					hash = hash * 59 + this.ReceivingShiftDate.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
