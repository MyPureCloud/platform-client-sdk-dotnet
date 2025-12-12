using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SingleWorkdayAverageValues
	/// </summary>
	[DataContract]
	public partial class SingleWorkdayAverageValues : IEquatable<SingleWorkdayAverageValues>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SingleWorkdayAverageValues" /> class.
		/// </summary>
		public SingleWorkdayAverageValues()
		{

		}



		/// <summary>
		/// The targeted workday for average value query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The targeted workday for average value query. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateWorkday", EmitDefaultValue = false)]
		public String DateWorkday { get; private set; }



		/// <summary>
		/// The targeted division for the metrics
		/// </summary>
		/// <value>The targeted division for the metrics</value>
		[DataMember(Name = "division", EmitDefaultValue = false)]
		public Division Division { get; private set; }



		/// <summary>
		/// The targeted user for the metrics
		/// </summary>
		/// <value>The targeted user for the metrics</value>
		[DataMember(Name = "user", EmitDefaultValue = false)]
		public UserReference User { get; private set; }



		/// <summary>
		/// The time zone used for aggregating metric values
		/// </summary>
		/// <value>The time zone used for aggregating metric values</value>
		[DataMember(Name = "timezone", EmitDefaultValue = false)]
		public string Timezone { get; private set; }



		/// <summary>
		/// The metric value averages
		/// </summary>
		/// <value>The metric value averages</value>
		[DataMember(Name = "results", EmitDefaultValue = false)]
		public List<WorkdayValuesMetricItem> Results { get; private set; }



		/// <summary>
		/// The targeted performance profile for the average points
		/// </summary>
		/// <value>The targeted performance profile for the average points</value>
		[DataMember(Name = "performanceProfile", EmitDefaultValue = false)]
		public AddressableEntityRef PerformanceProfile { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SingleWorkdayAverageValues {\n");

			sb.Append("  DateWorkday: ").Append(DateWorkday).Append("\n");
			sb.Append("  Division: ").Append(Division).Append("\n");
			sb.Append("  User: ").Append(User).Append("\n");
			sb.Append("  Timezone: ").Append(Timezone).Append("\n");
			sb.Append("  Results: ").Append(Results).Append("\n");
			sb.Append("  PerformanceProfile: ").Append(PerformanceProfile).Append("\n");
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
			return this.Equals(obj as SingleWorkdayAverageValues);
		}

		/// <summary>
		/// Returns true if SingleWorkdayAverageValues instances are equal
		/// </summary>
		/// <param name="other">Instance of SingleWorkdayAverageValues to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SingleWorkdayAverageValues other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DateWorkday == other.DateWorkday ||
					this.DateWorkday != null &&
					this.DateWorkday.Equals(other.DateWorkday)
				) &&
				(
					this.Division == other.Division ||
					this.Division != null &&
					this.Division.Equals(other.Division)
				) &&
				(
					this.User == other.User ||
					this.User != null &&
					this.User.Equals(other.User)
				) &&
				(
					this.Timezone == other.Timezone ||
					this.Timezone != null &&
					this.Timezone.Equals(other.Timezone)
				) &&
				(
					this.Results == other.Results ||
					this.Results != null &&
					this.Results.SequenceEqual(other.Results)
				) &&
				(
					this.PerformanceProfile == other.PerformanceProfile ||
					this.PerformanceProfile != null &&
					this.PerformanceProfile.Equals(other.PerformanceProfile)
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
				if (this.DateWorkday != null)
					hash = hash * 59 + this.DateWorkday.GetHashCode();

				if (this.Division != null)
					hash = hash * 59 + this.Division.GetHashCode();

				if (this.User != null)
					hash = hash * 59 + this.User.GetHashCode();

				if (this.Timezone != null)
					hash = hash * 59 + this.Timezone.GetHashCode();

				if (this.Results != null)
					hash = hash * 59 + this.Results.GetHashCode();

				if (this.PerformanceProfile != null)
					hash = hash * 59 + this.PerformanceProfile.GetHashCode();

				return hash;
			}
		}
	}

}
