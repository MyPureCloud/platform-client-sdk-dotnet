using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BuScheduleNotificationsCategorySettings
	/// </summary>
	[DataContract]
	public partial class BuScheduleNotificationsCategorySettings : IEquatable<BuScheduleNotificationsCategorySettings>
	{
		/// <summary>
		/// The activity category
		/// </summary>
		/// <value>The activity category</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ActivityCategoryEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Onqueuework for "OnQueueWork"
			/// </summary>
			[EnumMember(Value = "OnQueueWork")]
			Onqueuework,

			/// <summary>
			/// Enum Break for "Break"
			/// </summary>
			[EnumMember(Value = "Break")]
			Break,

			/// <summary>
			/// Enum Meal for "Meal"
			/// </summary>
			[EnumMember(Value = "Meal")]
			Meal,

			/// <summary>
			/// Enum Meeting for "Meeting"
			/// </summary>
			[EnumMember(Value = "Meeting")]
			Meeting,

			/// <summary>
			/// Enum Offqueuework for "OffQueueWork"
			/// </summary>
			[EnumMember(Value = "OffQueueWork")]
			Offqueuework,

			/// <summary>
			/// Enum Timeoff for "TimeOff"
			/// </summary>
			[EnumMember(Value = "TimeOff")]
			Timeoff,

			/// <summary>
			/// Enum Training for "Training"
			/// </summary>
			[EnumMember(Value = "Training")]
			Training,

			/// <summary>
			/// Enum Unavailable for "Unavailable"
			/// </summary>
			[EnumMember(Value = "Unavailable")]
			Unavailable
		}
		/// <summary>
		/// The activity category
		/// </summary>
		/// <value>The activity category</value>
		[DataMember(Name = "activityCategory", EmitDefaultValue = false)]
		public ActivityCategoryEnum? ActivityCategory { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="BuScheduleNotificationsCategorySettings" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected BuScheduleNotificationsCategorySettings() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="BuScheduleNotificationsCategorySettings" /> class.
		/// </summary>
		/// <param name="ActivityCategory">The activity category (required).</param>
		/// <param name="EarlyReminderEnabled">Indicates if agents should receive early schedule reminder notifications. (required).</param>
		/// <param name="OnTimeReminderEnabled">Indicates if agents should receive out of adherence notifications. (required).</param>
		public BuScheduleNotificationsCategorySettings(ActivityCategoryEnum? ActivityCategory = null, bool? EarlyReminderEnabled = null, bool? OnTimeReminderEnabled = null)
		{
			this.ActivityCategory = ActivityCategory;
			this.EarlyReminderEnabled = EarlyReminderEnabled;
			this.OnTimeReminderEnabled = OnTimeReminderEnabled;

		}





		/// <summary>
		/// Indicates if agents should receive early schedule reminder notifications.
		/// </summary>
		/// <value>Indicates if agents should receive early schedule reminder notifications.</value>
		[DataMember(Name = "earlyReminderEnabled", EmitDefaultValue = false)]
		public bool? EarlyReminderEnabled { get; set; }



		/// <summary>
		/// Indicates if agents should receive out of adherence notifications.
		/// </summary>
		/// <value>Indicates if agents should receive out of adherence notifications.</value>
		[DataMember(Name = "onTimeReminderEnabled", EmitDefaultValue = false)]
		public bool? OnTimeReminderEnabled { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BuScheduleNotificationsCategorySettings {\n");

			sb.Append("  ActivityCategory: ").Append(ActivityCategory).Append("\n");
			sb.Append("  EarlyReminderEnabled: ").Append(EarlyReminderEnabled).Append("\n");
			sb.Append("  OnTimeReminderEnabled: ").Append(OnTimeReminderEnabled).Append("\n");
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
			return this.Equals(obj as BuScheduleNotificationsCategorySettings);
		}

		/// <summary>
		/// Returns true if BuScheduleNotificationsCategorySettings instances are equal
		/// </summary>
		/// <param name="other">Instance of BuScheduleNotificationsCategorySettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BuScheduleNotificationsCategorySettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ActivityCategory == other.ActivityCategory ||
					this.ActivityCategory != null &&
					this.ActivityCategory.Equals(other.ActivityCategory)
				) &&
				(
					this.EarlyReminderEnabled == other.EarlyReminderEnabled ||
					this.EarlyReminderEnabled != null &&
					this.EarlyReminderEnabled.Equals(other.EarlyReminderEnabled)
				) &&
				(
					this.OnTimeReminderEnabled == other.OnTimeReminderEnabled ||
					this.OnTimeReminderEnabled != null &&
					this.OnTimeReminderEnabled.Equals(other.OnTimeReminderEnabled)
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
				if (this.ActivityCategory != null)
					hash = hash * 59 + this.ActivityCategory.GetHashCode();

				if (this.EarlyReminderEnabled != null)
					hash = hash * 59 + this.EarlyReminderEnabled.GetHashCode();

				if (this.OnTimeReminderEnabled != null)
					hash = hash * 59 + this.OnTimeReminderEnabled.GetHashCode();

				return hash;
			}
		}
	}

}
