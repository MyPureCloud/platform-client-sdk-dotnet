using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PlanningPeriodSettings
	/// </summary>
	[DataContract]
	public partial class PlanningPeriodSettings : IEquatable<PlanningPeriodSettings>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="PlanningPeriodSettings" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected PlanningPeriodSettings() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="PlanningPeriodSettings" /> class.
		/// </summary>
		/// <param name="WeekCount">Planning period length in weeks (required).</param>
		/// <param name="StartDate">Start date of the planning period in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
		public PlanningPeriodSettings(int? WeekCount = null, String StartDate = null)
		{
			this.WeekCount = WeekCount;
			this.StartDate = StartDate;

		}



		/// <summary>
		/// Planning period length in weeks
		/// </summary>
		/// <value>Planning period length in weeks</value>
		[DataMember(Name = "weekCount", EmitDefaultValue = false)]
		public int? WeekCount { get; set; }



		/// <summary>
		/// Start date of the planning period in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>Start date of the planning period in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "startDate", EmitDefaultValue = false)]
		public String StartDate { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PlanningPeriodSettings {\n");

			sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
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
			return this.Equals(obj as PlanningPeriodSettings);
		}

		/// <summary>
		/// Returns true if PlanningPeriodSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of PlanningPeriodSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PlanningPeriodSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.WeekCount == other.WeekCount ||
					this.WeekCount != null &&
					this.WeekCount.Equals(other.WeekCount)
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
				if (this.WeekCount != null)
					hash = hash * 59 + this.WeekCount.GetHashCode();

				if (this.StartDate != null)
					hash = hash * 59 + this.StartDate.GetHashCode();

				return hash;
			}
		}
	}

}
