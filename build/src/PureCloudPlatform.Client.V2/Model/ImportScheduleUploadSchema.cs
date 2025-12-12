using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ImportScheduleUploadSchema
	/// </summary>
	[DataContract]
	public partial class ImportScheduleUploadSchema : IEquatable<ImportScheduleUploadSchema>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ImportScheduleUploadSchema" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ImportScheduleUploadSchema() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ImportScheduleUploadSchema" /> class.
		/// </summary>
		/// <param name="Description">The description for the imported schedule (required).</param>
		/// <param name="WeekCount">The number of weeks the imported schedule will cover (required).</param>
		/// <param name="Published">Whether the imported schedule should be immediately published.</param>
		/// <param name="ShortTermForecast">The short term forecast to associate with the imported schedule.</param>
		/// <param name="HeadcountForecast">The headcount forecast to associate with the imported schedule.</param>
		/// <param name="AgentSchedules">Individual agent schedules.</param>
		public ImportScheduleUploadSchema(string Description = null, int? WeekCount = null, bool? Published = null, BuShortTermForecastReference ShortTermForecast = null, BuHeadcountForecastBuPlanningGroupHeadcountForecastUploadSchema HeadcountForecast = null, List<BuImportAgentScheduleUploadSchema> AgentSchedules = null)
		{
			this.Description = Description;
			this.WeekCount = WeekCount;
			this.Published = Published;
			this.ShortTermForecast = ShortTermForecast;
			this.HeadcountForecast = HeadcountForecast;
			this.AgentSchedules = AgentSchedules;

		}



		/// <summary>
		/// The description for the imported schedule
		/// </summary>
		/// <value>The description for the imported schedule</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// The number of weeks the imported schedule will cover
		/// </summary>
		/// <value>The number of weeks the imported schedule will cover</value>
		[DataMember(Name = "weekCount", EmitDefaultValue = false)]
		public int? WeekCount { get; set; }



		/// <summary>
		/// Whether the imported schedule should be immediately published
		/// </summary>
		/// <value>Whether the imported schedule should be immediately published</value>
		[DataMember(Name = "published", EmitDefaultValue = false)]
		public bool? Published { get; set; }



		/// <summary>
		/// The short term forecast to associate with the imported schedule
		/// </summary>
		/// <value>The short term forecast to associate with the imported schedule</value>
		[DataMember(Name = "shortTermForecast", EmitDefaultValue = false)]
		public BuShortTermForecastReference ShortTermForecast { get; set; }



		/// <summary>
		/// The headcount forecast to associate with the imported schedule
		/// </summary>
		/// <value>The headcount forecast to associate with the imported schedule</value>
		[DataMember(Name = "headcountForecast", EmitDefaultValue = false)]
		public BuHeadcountForecastBuPlanningGroupHeadcountForecastUploadSchema HeadcountForecast { get; set; }



		/// <summary>
		/// Individual agent schedules
		/// </summary>
		/// <value>Individual agent schedules</value>
		[DataMember(Name = "agentSchedules", EmitDefaultValue = false)]
		public List<BuImportAgentScheduleUploadSchema> AgentSchedules { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ImportScheduleUploadSchema {\n");

			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
			sb.Append("  Published: ").Append(Published).Append("\n");
			sb.Append("  ShortTermForecast: ").Append(ShortTermForecast).Append("\n");
			sb.Append("  HeadcountForecast: ").Append(HeadcountForecast).Append("\n");
			sb.Append("  AgentSchedules: ").Append(AgentSchedules).Append("\n");
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
			return this.Equals(obj as ImportScheduleUploadSchema);
		}

		/// <summary>
		/// Returns true if ImportScheduleUploadSchema instances are equal
		/// </summary>
		/// <param name="other">Instance of ImportScheduleUploadSchema to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ImportScheduleUploadSchema other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.WeekCount == other.WeekCount ||
					this.WeekCount != null &&
					this.WeekCount.Equals(other.WeekCount)
				) &&
				(
					this.Published == other.Published ||
					this.Published != null &&
					this.Published.Equals(other.Published)
				) &&
				(
					this.ShortTermForecast == other.ShortTermForecast ||
					this.ShortTermForecast != null &&
					this.ShortTermForecast.Equals(other.ShortTermForecast)
				) &&
				(
					this.HeadcountForecast == other.HeadcountForecast ||
					this.HeadcountForecast != null &&
					this.HeadcountForecast.Equals(other.HeadcountForecast)
				) &&
				(
					this.AgentSchedules == other.AgentSchedules ||
					this.AgentSchedules != null &&
					this.AgentSchedules.SequenceEqual(other.AgentSchedules)
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
				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.WeekCount != null)
					hash = hash * 59 + this.WeekCount.GetHashCode();

				if (this.Published != null)
					hash = hash * 59 + this.Published.GetHashCode();

				if (this.ShortTermForecast != null)
					hash = hash * 59 + this.ShortTermForecast.GetHashCode();

				if (this.HeadcountForecast != null)
					hash = hash * 59 + this.HeadcountForecast.GetHashCode();

				if (this.AgentSchedules != null)
					hash = hash * 59 + this.AgentSchedules.GetHashCode();

				return hash;
			}
		}
	}

}
