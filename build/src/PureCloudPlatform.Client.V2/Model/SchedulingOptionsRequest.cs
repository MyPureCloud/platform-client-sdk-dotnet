using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SchedulingOptionsRequest
	/// </summary>
	[DataContract]
	public partial class SchedulingOptionsRequest : IEquatable<SchedulingOptionsRequest>
	{
		/// <summary>
		/// Overrides the default BU level activity smoothing type for this schedule generation
		/// </summary>
		/// <value>Overrides the default BU level activity smoothing type for this schedule generation</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ActivitySmoothingTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Reduceconcurrentactivitiesacrossbu for "ReduceConcurrentActivitiesAcrossBu"
			/// </summary>
			[EnumMember(Value = "ReduceConcurrentActivitiesAcrossBu")]
			Reduceconcurrentactivitiesacrossbu,

			/// <summary>
			/// Enum Reduceconcurrentactivitiesacrossmu for "ReduceConcurrentActivitiesAcrossMu"
			/// </summary>
			[EnumMember(Value = "ReduceConcurrentActivitiesAcrossMu")]
			Reduceconcurrentactivitiesacrossmu,

			/// <summary>
			/// Enum Consistentservicelevel for "ConsistentServiceLevel"
			/// </summary>
			[EnumMember(Value = "ConsistentServiceLevel")]
			Consistentservicelevel
		}
		/// <summary>
		/// Overrides the default BU level activity smoothing type for this schedule generation
		/// </summary>
		/// <value>Overrides the default BU level activity smoothing type for this schedule generation</value>
		[DataMember(Name = "activitySmoothingType", EmitDefaultValue = false)]
		public ActivitySmoothingTypeEnum? ActivitySmoothingType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="SchedulingOptionsRequest" /> class.
		/// </summary>
		/// <param name="NoForecastOptions">Schedule generation options to apply if no forecast is supplied.</param>
		/// <param name="ActivitySmoothingType">Overrides the default BU level activity smoothing type for this schedule generation.</param>
		/// <param name="InduceScheduleVariability">Overrides the default BU level induce schedule variability setting for this schedule generation.</param>
		public SchedulingOptionsRequest(SchedulingNoForecastOptionsRequest NoForecastOptions = null, ActivitySmoothingTypeEnum? ActivitySmoothingType = null, bool? InduceScheduleVariability = null)
		{
			this.NoForecastOptions = NoForecastOptions;
			this.ActivitySmoothingType = ActivitySmoothingType;
			this.InduceScheduleVariability = InduceScheduleVariability;

		}



		/// <summary>
		/// Schedule generation options to apply if no forecast is supplied
		/// </summary>
		/// <value>Schedule generation options to apply if no forecast is supplied</value>
		[DataMember(Name = "noForecastOptions", EmitDefaultValue = false)]
		public SchedulingNoForecastOptionsRequest NoForecastOptions { get; set; }





		/// <summary>
		/// Overrides the default BU level induce schedule variability setting for this schedule generation
		/// </summary>
		/// <value>Overrides the default BU level induce schedule variability setting for this schedule generation</value>
		[DataMember(Name = "induceScheduleVariability", EmitDefaultValue = false)]
		public bool? InduceScheduleVariability { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SchedulingOptionsRequest {\n");

			sb.Append("  NoForecastOptions: ").Append(NoForecastOptions).Append("\n");
			sb.Append("  ActivitySmoothingType: ").Append(ActivitySmoothingType).Append("\n");
			sb.Append("  InduceScheduleVariability: ").Append(InduceScheduleVariability).Append("\n");
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
			return this.Equals(obj as SchedulingOptionsRequest);
		}

		/// <summary>
		/// Returns true if SchedulingOptionsRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of SchedulingOptionsRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SchedulingOptionsRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.NoForecastOptions == other.NoForecastOptions ||
					this.NoForecastOptions != null &&
					this.NoForecastOptions.Equals(other.NoForecastOptions)
				) &&
				(
					this.ActivitySmoothingType == other.ActivitySmoothingType ||
					this.ActivitySmoothingType != null &&
					this.ActivitySmoothingType.Equals(other.ActivitySmoothingType)
				) &&
				(
					this.InduceScheduleVariability == other.InduceScheduleVariability ||
					this.InduceScheduleVariability != null &&
					this.InduceScheduleVariability.Equals(other.InduceScheduleVariability)
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
				if (this.NoForecastOptions != null)
					hash = hash * 59 + this.NoForecastOptions.GetHashCode();

				if (this.ActivitySmoothingType != null)
					hash = hash * 59 + this.ActivitySmoothingType.GetHashCode();

				if (this.InduceScheduleVariability != null)
					hash = hash * 59 + this.InduceScheduleVariability.GetHashCode();

				return hash;
			}
		}
	}

}
