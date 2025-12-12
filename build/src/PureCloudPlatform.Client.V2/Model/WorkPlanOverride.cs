using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkPlanOverride
	/// </summary>
	[DataContract]
	public partial class WorkPlanOverride : IEquatable<WorkPlanOverride>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="WorkPlanOverride" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected WorkPlanOverride() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkPlanOverride" /> class.
		/// </summary>
		/// <param name="StartDate">The start date in yyyy-MM-dd format of the work plan override. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
		/// <param name="WeekCount">Number of weeks for the work plan override (required).</param>
		/// <param name="WorkPlan">The work plan reference associated with this override (required).</param>
		public WorkPlanOverride(String StartDate = null, int? WeekCount = null, WorkPlanReference WorkPlan = null)
		{
			this.StartDate = StartDate;
			this.WeekCount = WeekCount;
			this.WorkPlan = WorkPlan;

		}



		/// <summary>
		/// The start date in yyyy-MM-dd format of the work plan override. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The start date in yyyy-MM-dd format of the work plan override. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "startDate", EmitDefaultValue = false)]
		public String StartDate { get; set; }



		/// <summary>
		/// Number of weeks for the work plan override
		/// </summary>
		/// <value>Number of weeks for the work plan override</value>
		[DataMember(Name = "weekCount", EmitDefaultValue = false)]
		public int? WeekCount { get; set; }



		/// <summary>
		/// The work plan reference associated with this override
		/// </summary>
		/// <value>The work plan reference associated with this override</value>
		[DataMember(Name = "workPlan", EmitDefaultValue = false)]
		public WorkPlanReference WorkPlan { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkPlanOverride {\n");

			sb.Append("  StartDate: ").Append(StartDate).Append("\n");
			sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
			sb.Append("  WorkPlan: ").Append(WorkPlan).Append("\n");
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
			return this.Equals(obj as WorkPlanOverride);
		}

		/// <summary>
		/// Returns true if WorkPlanOverride instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkPlanOverride to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkPlanOverride other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.StartDate == other.StartDate ||
					this.StartDate != null &&
					this.StartDate.Equals(other.StartDate)
				) &&
				(
					this.WeekCount == other.WeekCount ||
					this.WeekCount != null &&
					this.WeekCount.Equals(other.WeekCount)
				) &&
				(
					this.WorkPlan == other.WorkPlan ||
					this.WorkPlan != null &&
					this.WorkPlan.Equals(other.WorkPlan)
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
				if (this.StartDate != null)
					hash = hash * 59 + this.StartDate.GetHashCode();

				if (this.WeekCount != null)
					hash = hash * 59 + this.WeekCount.GetHashCode();

				if (this.WorkPlan != null)
					hash = hash * 59 + this.WorkPlan.GetHashCode();

				return hash;
			}
		}
	}

}
