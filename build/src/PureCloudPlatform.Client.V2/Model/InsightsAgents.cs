using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// InsightsAgents
	/// </summary>
	[DataContract]
	public partial class InsightsAgents : IEquatable<InsightsAgents>
	{
		/// <summary>
		/// Granularity
		/// </summary>
		/// <value>Granularity</value>
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
		/// Granularity
		/// </summary>
		/// <value>Granularity</value>
		[DataMember(Name = "granularity", EmitDefaultValue = false)]
		public GranularityEnum? Granularity { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="InsightsAgents" /> class.
		/// </summary>
		/// <param name="PerformanceProfile">The performance profile.</param>
		/// <param name="Division">The division.</param>
		/// <param name="Granularity">Granularity.</param>
		/// <param name="DateStartWorkday">Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="DateEndWorkday">End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="Entities">The list of insights agents.</param>
		public InsightsAgents(AddressableEntityRef PerformanceProfile = null, DivisionReference Division = null, GranularityEnum? Granularity = null, String DateStartWorkday = null, String DateEndWorkday = null, List<InsightsAgentItem> Entities = null)
		{
			this.PerformanceProfile = PerformanceProfile;
			this.Division = Division;
			this.Granularity = Granularity;
			this.DateStartWorkday = DateStartWorkday;
			this.DateEndWorkday = DateEndWorkday;
			this.Entities = Entities;

		}



		/// <summary>
		/// The performance profile
		/// </summary>
		/// <value>The performance profile</value>
		[DataMember(Name = "performanceProfile", EmitDefaultValue = false)]
		public AddressableEntityRef PerformanceProfile { get; set; }



		/// <summary>
		/// The division
		/// </summary>
		/// <value>The division</value>
		[DataMember(Name = "division", EmitDefaultValue = false)]
		public DivisionReference Division { get; set; }





		/// <summary>
		/// Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateStartWorkday", EmitDefaultValue = false)]
		public String DateStartWorkday { get; set; }



		/// <summary>
		/// End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateEndWorkday", EmitDefaultValue = false)]
		public String DateEndWorkday { get; set; }



		/// <summary>
		/// The list of insights agents
		/// </summary>
		/// <value>The list of insights agents</value>
		[DataMember(Name = "entities", EmitDefaultValue = false)]
		public List<InsightsAgentItem> Entities { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InsightsAgents {\n");

			sb.Append("  PerformanceProfile: ").Append(PerformanceProfile).Append("\n");
			sb.Append("  Division: ").Append(Division).Append("\n");
			sb.Append("  Granularity: ").Append(Granularity).Append("\n");
			sb.Append("  DateStartWorkday: ").Append(DateStartWorkday).Append("\n");
			sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
			sb.Append("  Entities: ").Append(Entities).Append("\n");
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
			return this.Equals(obj as InsightsAgents);
		}

		/// <summary>
		/// Returns true if InsightsAgents instances are equal
		/// </summary>
		/// <param name="other">Instance of InsightsAgents to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(InsightsAgents other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.PerformanceProfile == other.PerformanceProfile ||
					this.PerformanceProfile != null &&
					this.PerformanceProfile.Equals(other.PerformanceProfile)
				) &&
				(
					this.Division == other.Division ||
					this.Division != null &&
					this.Division.Equals(other.Division)
				) &&
				(
					this.Granularity == other.Granularity ||
					this.Granularity != null &&
					this.Granularity.Equals(other.Granularity)
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
				) &&
				(
					this.Entities == other.Entities ||
					this.Entities != null &&
					this.Entities.SequenceEqual(other.Entities)
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
				if (this.PerformanceProfile != null)
					hash = hash * 59 + this.PerformanceProfile.GetHashCode();

				if (this.Division != null)
					hash = hash * 59 + this.Division.GetHashCode();

				if (this.Granularity != null)
					hash = hash * 59 + this.Granularity.GetHashCode();

				if (this.DateStartWorkday != null)
					hash = hash * 59 + this.DateStartWorkday.GetHashCode();

				if (this.DateEndWorkday != null)
					hash = hash * 59 + this.DateEndWorkday.GetHashCode();

				if (this.Entities != null)
					hash = hash * 59 + this.Entities.GetHashCode();

				return hash;
			}
		}
	}

}
