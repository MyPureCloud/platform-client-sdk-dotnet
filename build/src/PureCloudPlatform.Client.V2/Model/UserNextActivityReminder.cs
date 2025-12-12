using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UserNextActivityReminder
	/// </summary>
	[DataContract]
	public partial class UserNextActivityReminder : IEquatable<UserNextActivityReminder>
	{
		/// <summary>
		/// Upcoming activity for which the user is scheduled
		/// </summary>
		/// <value>Upcoming activity for which the user is scheduled</value>
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
			Unavailable,

			/// <summary>
			/// Enum Unscheduled for "Unscheduled"
			/// </summary>
			[EnumMember(Value = "Unscheduled")]
			Unscheduled
		}
		/// <summary>
		/// Upcoming activity for which the user is scheduled
		/// </summary>
		/// <value>Upcoming activity for which the user is scheduled</value>
		[DataMember(Name = "activityCategory", EmitDefaultValue = false)]
		public ActivityCategoryEnum? ActivityCategory { get; private set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="UserNextActivityReminder" /> class.
		/// </summary>
		public UserNextActivityReminder()
		{

		}





		/// <summary>
		/// The start timestamp of the scheduled activity in ISO-8601 format
		/// </summary>
		/// <value>The start timestamp of the scheduled activity in ISO-8601 format</value>
		[DataMember(Name = "startDate", EmitDefaultValue = false)]
		public DateTime? StartDate { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserNextActivityReminder {\n");

			sb.Append("  ActivityCategory: ").Append(ActivityCategory).Append("\n");
			sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
			return this.Equals(obj as UserNextActivityReminder);
		}

		/// <summary>
		/// Returns true if UserNextActivityReminder instances are equal
		/// </summary>
		/// <param name="other">Instance of UserNextActivityReminder to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserNextActivityReminder other)
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
					this.StartDate == other.StartDate ||
					this.StartDate != null &&
					this.StartDate.Equals(other.StartDate)
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

				if (this.StartDate != null)
					hash = hash * 59 + this.StartDate.GetHashCode();

				return hash;
			}
		}
	}

}
