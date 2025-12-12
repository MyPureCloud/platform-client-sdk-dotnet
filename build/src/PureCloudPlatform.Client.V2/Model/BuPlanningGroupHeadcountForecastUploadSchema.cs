using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BuPlanningGroupHeadcountForecastUploadSchema
	/// </summary>
	[DataContract]
	public partial class BuPlanningGroupHeadcountForecastUploadSchema : IEquatable<BuPlanningGroupHeadcountForecastUploadSchema>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="BuPlanningGroupHeadcountForecastUploadSchema" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected BuPlanningGroupHeadcountForecastUploadSchema() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="BuPlanningGroupHeadcountForecastUploadSchema" /> class.
		/// </summary>
		/// <param name="RequiredPerInterval">Required headcount per interval, referenced against the reference start date.</param>
		/// <param name="RequiredWithoutShrinkagePerInterval">Required headcount per interval without accounting for shrinkage, referenced against the reference start date.</param>
		/// <param name="PlanningGroupId">The ID of the planning group to which this portion of the headcount forecast applies (required).</param>
		public BuPlanningGroupHeadcountForecastUploadSchema(List<double?> RequiredPerInterval = null, List<double?> RequiredWithoutShrinkagePerInterval = null, string PlanningGroupId = null)
		{
			this.RequiredPerInterval = RequiredPerInterval;
			this.RequiredWithoutShrinkagePerInterval = RequiredWithoutShrinkagePerInterval;
			this.PlanningGroupId = PlanningGroupId;

		}



		/// <summary>
		/// Required headcount per interval, referenced against the reference start date
		/// </summary>
		/// <value>Required headcount per interval, referenced against the reference start date</value>
		[DataMember(Name = "requiredPerInterval", EmitDefaultValue = false)]
		public List<double?> RequiredPerInterval { get; set; }



		/// <summary>
		/// Required headcount per interval without accounting for shrinkage, referenced against the reference start date
		/// </summary>
		/// <value>Required headcount per interval without accounting for shrinkage, referenced against the reference start date</value>
		[DataMember(Name = "requiredWithoutShrinkagePerInterval", EmitDefaultValue = false)]
		public List<double?> RequiredWithoutShrinkagePerInterval { get; set; }



		/// <summary>
		/// The ID of the planning group to which this portion of the headcount forecast applies
		/// </summary>
		/// <value>The ID of the planning group to which this portion of the headcount forecast applies</value>
		[DataMember(Name = "planningGroupId", EmitDefaultValue = false)]
		public string PlanningGroupId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BuPlanningGroupHeadcountForecastUploadSchema {\n");

			sb.Append("  RequiredPerInterval: ").Append(RequiredPerInterval).Append("\n");
			sb.Append("  RequiredWithoutShrinkagePerInterval: ").Append(RequiredWithoutShrinkagePerInterval).Append("\n");
			sb.Append("  PlanningGroupId: ").Append(PlanningGroupId).Append("\n");
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
			return this.Equals(obj as BuPlanningGroupHeadcountForecastUploadSchema);
		}

		/// <summary>
		/// Returns true if BuPlanningGroupHeadcountForecastUploadSchema instances are equal
		/// </summary>
		/// <param name="other">Instance of BuPlanningGroupHeadcountForecastUploadSchema to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BuPlanningGroupHeadcountForecastUploadSchema other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.RequiredPerInterval == other.RequiredPerInterval ||
					this.RequiredPerInterval != null &&
					this.RequiredPerInterval.SequenceEqual(other.RequiredPerInterval)
				) &&
				(
					this.RequiredWithoutShrinkagePerInterval == other.RequiredWithoutShrinkagePerInterval ||
					this.RequiredWithoutShrinkagePerInterval != null &&
					this.RequiredWithoutShrinkagePerInterval.SequenceEqual(other.RequiredWithoutShrinkagePerInterval)
				) &&
				(
					this.PlanningGroupId == other.PlanningGroupId ||
					this.PlanningGroupId != null &&
					this.PlanningGroupId.Equals(other.PlanningGroupId)
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
				if (this.RequiredPerInterval != null)
					hash = hash * 59 + this.RequiredPerInterval.GetHashCode();

				if (this.RequiredWithoutShrinkagePerInterval != null)
					hash = hash * 59 + this.RequiredWithoutShrinkagePerInterval.GetHashCode();

				if (this.PlanningGroupId != null)
					hash = hash * 59 + this.PlanningGroupId.GetHashCode();

				return hash;
			}
		}
	}

}
