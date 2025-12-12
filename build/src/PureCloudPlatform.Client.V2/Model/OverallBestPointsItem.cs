using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// OverallBestPointsItem
	/// </summary>
	[DataContract]
	public partial class OverallBestPointsItem : IEquatable<OverallBestPointsItem>
	{
		/// <summary>
		/// Best points aggregation interval granularity
		/// </summary>
		/// <value>Best points aggregation interval granularity</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum GranularityTypeEnum
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
			Daily,

			/// <summary>
			/// Enum Weekly for "Weekly"
			/// </summary>
			[EnumMember(Value = "Weekly")]
			Weekly,

			/// <summary>
			/// Enum Monthly for "Monthly"
			/// </summary>
			[EnumMember(Value = "Monthly")]
			Monthly
		}
		/// <summary>
		/// Best points aggregation interval granularity
		/// </summary>
		/// <value>Best points aggregation interval granularity</value>
		[DataMember(Name = "granularityType", EmitDefaultValue = false)]
		public GranularityTypeEnum? GranularityType { get; private set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="OverallBestPointsItem" /> class.
		/// </summary>
		public OverallBestPointsItem()
		{

		}





		/// <summary>
		/// List of associated users with the equal points.
		/// </summary>
		/// <value>List of associated users with the equal points.</value>
		[DataMember(Name = "users", EmitDefaultValue = false)]
		public List<UserReference> Users { get; private set; }



		/// <summary>
		/// The count of the user IDs in the list
		/// </summary>
		/// <value>The count of the user IDs in the list</value>
		[DataMember(Name = "count", EmitDefaultValue = false)]
		public int? Count { get; private set; }



		/// <summary>
		/// Gamification points
		/// </summary>
		/// <value>Gamification points</value>
		[DataMember(Name = "points", EmitDefaultValue = false)]
		public int? Points { get; private set; }



		/// <summary>
		/// Start workday of the best points aggregation interval. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>Start workday of the best points aggregation interval. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateStartWorkday", EmitDefaultValue = false)]
		public String DateStartWorkday { get; private set; }



		/// <summary>
		/// End workday of the best points aggregation interval. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>End workday of the best points aggregation interval. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateEndWorkday", EmitDefaultValue = false)]
		public String DateEndWorkday { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OverallBestPointsItem {\n");

			sb.Append("  GranularityType: ").Append(GranularityType).Append("\n");
			sb.Append("  Users: ").Append(Users).Append("\n");
			sb.Append("  Count: ").Append(Count).Append("\n");
			sb.Append("  Points: ").Append(Points).Append("\n");
			sb.Append("  DateStartWorkday: ").Append(DateStartWorkday).Append("\n");
			sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
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
			return this.Equals(obj as OverallBestPointsItem);
		}

		/// <summary>
		/// Returns true if OverallBestPointsItem instances are equal
		/// </summary>
		/// <param name="other">Instance of OverallBestPointsItem to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OverallBestPointsItem other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.GranularityType == other.GranularityType ||
					this.GranularityType != null &&
					this.GranularityType.Equals(other.GranularityType)
				) &&
				(
					this.Users == other.Users ||
					this.Users != null &&
					this.Users.SequenceEqual(other.Users)
				) &&
				(
					this.Count == other.Count ||
					this.Count != null &&
					this.Count.Equals(other.Count)
				) &&
				(
					this.Points == other.Points ||
					this.Points != null &&
					this.Points.Equals(other.Points)
				) &&
				(
					this.DateStartWorkday == other.DateStartWorkday ||
					this.DateStartWorkday != null &&
					this.DateStartWorkday.Equals(other.DateStartWorkday)
				) &&
				(
					this.DateEndWorkday == other.DateEndWorkday ||
					this.DateEndWorkday != null &&
					this.DateEndWorkday.Equals(other.DateEndWorkday)
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
				if (this.GranularityType != null)
					hash = hash * 59 + this.GranularityType.GetHashCode();

				if (this.Users != null)
					hash = hash * 59 + this.Users.GetHashCode();

				if (this.Count != null)
					hash = hash * 59 + this.Count.GetHashCode();

				if (this.Points != null)
					hash = hash * 59 + this.Points.GetHashCode();

				if (this.DateStartWorkday != null)
					hash = hash * 59 + this.DateStartWorkday.GetHashCode();

				if (this.DateEndWorkday != null)
					hash = hash * 59 + this.DateEndWorkday.GetHashCode();

				return hash;
			}
		}
	}

}
