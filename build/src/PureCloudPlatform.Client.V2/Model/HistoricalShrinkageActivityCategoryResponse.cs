using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// HistoricalShrinkageActivityCategoryResponse
	/// </summary>
	[DataContract]
	public partial class HistoricalShrinkageActivityCategoryResponse : IEquatable<HistoricalShrinkageActivityCategoryResponse>
	{
		/// <summary>
		/// Activity category for which shrinkage data is provided
		/// </summary>
		/// <value>Activity category for which shrinkage data is provided</value>
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
		/// Activity category for which shrinkage data is provided
		/// </summary>
		/// <value>Activity category for which shrinkage data is provided</value>
		[DataMember(Name = "activityCategory", EmitDefaultValue = false)]
		public ActivityCategoryEnum? ActivityCategory { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="HistoricalShrinkageActivityCategoryResponse" /> class.
		/// </summary>
		/// <param name="ActivityCategory">Activity category for which shrinkage data is provided.</param>
		/// <param name="ShrinkageForActivityCategory">Aggregated shrinkage data for the activity category.</param>
		/// <param name="ShrinkageForActivityCodes">Shrinkage for the activity codes under this activity category.</param>
		public HistoricalShrinkageActivityCategoryResponse(ActivityCategoryEnum? ActivityCategory = null, HistoricalShrinkageAggregateResponse ShrinkageForActivityCategory = null, List<HistoricalShrinkageActivityCodeResponse> ShrinkageForActivityCodes = null)
		{
			this.ActivityCategory = ActivityCategory;
			this.ShrinkageForActivityCategory = ShrinkageForActivityCategory;
			this.ShrinkageForActivityCodes = ShrinkageForActivityCodes;

		}





		/// <summary>
		/// Aggregated shrinkage data for the activity category
		/// </summary>
		/// <value>Aggregated shrinkage data for the activity category</value>
		[DataMember(Name = "shrinkageForActivityCategory", EmitDefaultValue = false)]
		public HistoricalShrinkageAggregateResponse ShrinkageForActivityCategory { get; set; }



		/// <summary>
		/// Shrinkage for the activity codes under this activity category
		/// </summary>
		/// <value>Shrinkage for the activity codes under this activity category</value>
		[DataMember(Name = "shrinkageForActivityCodes", EmitDefaultValue = false)]
		public List<HistoricalShrinkageActivityCodeResponse> ShrinkageForActivityCodes { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class HistoricalShrinkageActivityCategoryResponse {\n");

			sb.Append("  ActivityCategory: ").Append(ActivityCategory).Append("\n");
			sb.Append("  ShrinkageForActivityCategory: ").Append(ShrinkageForActivityCategory).Append("\n");
			sb.Append("  ShrinkageForActivityCodes: ").Append(ShrinkageForActivityCodes).Append("\n");
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
			return this.Equals(obj as HistoricalShrinkageActivityCategoryResponse);
		}

		/// <summary>
		/// Returns true if HistoricalShrinkageActivityCategoryResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of HistoricalShrinkageActivityCategoryResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(HistoricalShrinkageActivityCategoryResponse other)
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
					this.ShrinkageForActivityCategory == other.ShrinkageForActivityCategory ||
					this.ShrinkageForActivityCategory != null &&
					this.ShrinkageForActivityCategory.Equals(other.ShrinkageForActivityCategory)
				) &&
				(
					this.ShrinkageForActivityCodes == other.ShrinkageForActivityCodes ||
					this.ShrinkageForActivityCodes != null &&
					this.ShrinkageForActivityCodes.SequenceEqual(other.ShrinkageForActivityCodes)
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

				if (this.ShrinkageForActivityCategory != null)
					hash = hash * 59 + this.ShrinkageForActivityCategory.GetHashCode();

				if (this.ShrinkageForActivityCodes != null)
					hash = hash * 59 + this.ShrinkageForActivityCodes.GetHashCode();

				return hash;
			}
		}
	}

}
