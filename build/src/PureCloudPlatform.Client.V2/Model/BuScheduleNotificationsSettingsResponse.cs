using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BuScheduleNotificationsSettingsResponse
	/// </summary>
	[DataContract]
	public partial class BuScheduleNotificationsSettingsResponse : IEquatable<BuScheduleNotificationsSettingsResponse>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="BuScheduleNotificationsSettingsResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected BuScheduleNotificationsSettingsResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="BuScheduleNotificationsSettingsResponse" /> class.
		/// </summary>
		/// <param name="EarlyReminderMinutes">The number of minutes prior to the scheduled event to display an early reminder notification (required).</param>
		/// <param name="ActivityCategorySettings">List of activity category notification settings (required).</param>
		public BuScheduleNotificationsSettingsResponse(int? EarlyReminderMinutes = null, List<BuScheduleNotificationsCategorySettings> ActivityCategorySettings = null)
		{
			this.EarlyReminderMinutes = EarlyReminderMinutes;
			this.ActivityCategorySettings = ActivityCategorySettings;

		}



		/// <summary>
		/// The number of minutes prior to the scheduled event to display an early reminder notification
		/// </summary>
		/// <value>The number of minutes prior to the scheduled event to display an early reminder notification</value>
		[DataMember(Name = "earlyReminderMinutes", EmitDefaultValue = false)]
		public int? EarlyReminderMinutes { get; set; }



		/// <summary>
		/// List of activity category notification settings
		/// </summary>
		/// <value>List of activity category notification settings</value>
		[DataMember(Name = "activityCategorySettings", EmitDefaultValue = false)]
		public List<BuScheduleNotificationsCategorySettings> ActivityCategorySettings { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BuScheduleNotificationsSettingsResponse {\n");

			sb.Append("  EarlyReminderMinutes: ").Append(EarlyReminderMinutes).Append("\n");
			sb.Append("  ActivityCategorySettings: ").Append(ActivityCategorySettings).Append("\n");
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
			return this.Equals(obj as BuScheduleNotificationsSettingsResponse);
		}

		/// <summary>
		/// Returns true if BuScheduleNotificationsSettingsResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of BuScheduleNotificationsSettingsResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BuScheduleNotificationsSettingsResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.EarlyReminderMinutes == other.EarlyReminderMinutes ||
					this.EarlyReminderMinutes != null &&
					this.EarlyReminderMinutes.Equals(other.EarlyReminderMinutes)
				) &&
				(
					this.ActivityCategorySettings == other.ActivityCategorySettings ||
					this.ActivityCategorySettings != null &&
					this.ActivityCategorySettings.SequenceEqual(other.ActivityCategorySettings)
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
				if (this.EarlyReminderMinutes != null)
					hash = hash * 59 + this.EarlyReminderMinutes.GetHashCode();

				if (this.ActivityCategorySettings != null)
					hash = hash * 59 + this.ActivityCategorySettings.GetHashCode();

				return hash;
			}
		}
	}

}
