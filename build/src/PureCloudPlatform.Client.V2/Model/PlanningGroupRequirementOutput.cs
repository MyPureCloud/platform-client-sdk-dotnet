using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PlanningGroupRequirementOutput
	/// </summary>
	[DataContract]
	public partial class PlanningGroupRequirementOutput : IEquatable<PlanningGroupRequirementOutput>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="PlanningGroupRequirementOutput" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected PlanningGroupRequirementOutput() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="PlanningGroupRequirementOutput" /> class.
		/// </summary>
		/// <param name="Id">The ID of the planning group to which this output applies (required).</param>
		/// <param name="Intervals">List of interval values that correspond with the requirements granularity that was requested.</param>
		/// <param name="ErrorDetails">Error details if the intervals cannot be provided for this planning group because of missing data or internal error.</param>
		/// <param name="ServiceGoalDetails">The service goal details used to generate the requirements.</param>
		public PlanningGroupRequirementOutput(string Id = null, List<int?> Intervals = null, List<LongTermRequirementsErrorDetail> ErrorDetails = null, LongTermRequirementsServiceGoalDetail ServiceGoalDetails = null)
		{
			this.Id = Id;
			this.Intervals = Intervals;
			this.ErrorDetails = ErrorDetails;
			this.ServiceGoalDetails = ServiceGoalDetails;

		}



		/// <summary>
		/// The ID of the planning group to which this output applies
		/// </summary>
		/// <value>The ID of the planning group to which this output applies</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// List of interval values that correspond with the requirements granularity that was requested
		/// </summary>
		/// <value>List of interval values that correspond with the requirements granularity that was requested</value>
		[DataMember(Name = "intervals", EmitDefaultValue = false)]
		public List<int?> Intervals { get; set; }



		/// <summary>
		/// Error details if the intervals cannot be provided for this planning group because of missing data or internal error
		/// </summary>
		/// <value>Error details if the intervals cannot be provided for this planning group because of missing data or internal error</value>
		[DataMember(Name = "errorDetails", EmitDefaultValue = false)]
		public List<LongTermRequirementsErrorDetail> ErrorDetails { get; set; }



		/// <summary>
		/// The service goal details used to generate the requirements
		/// </summary>
		/// <value>The service goal details used to generate the requirements</value>
		[DataMember(Name = "serviceGoalDetails", EmitDefaultValue = false)]
		public LongTermRequirementsServiceGoalDetail ServiceGoalDetails { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PlanningGroupRequirementOutput {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Intervals: ").Append(Intervals).Append("\n");
			sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
			sb.Append("  ServiceGoalDetails: ").Append(ServiceGoalDetails).Append("\n");
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
			return this.Equals(obj as PlanningGroupRequirementOutput);
		}

		/// <summary>
		/// Returns true if PlanningGroupRequirementOutput instances are equal
		/// </summary>
		/// <param name="other">Instance of PlanningGroupRequirementOutput to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PlanningGroupRequirementOutput other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Intervals == other.Intervals ||
					this.Intervals != null &&
					this.Intervals.SequenceEqual(other.Intervals)
				) &&
				(
					this.ErrorDetails == other.ErrorDetails ||
					this.ErrorDetails != null &&
					this.ErrorDetails.SequenceEqual(other.ErrorDetails)
				) &&
				(
					this.ServiceGoalDetails == other.ServiceGoalDetails ||
					this.ServiceGoalDetails != null &&
					this.ServiceGoalDetails.Equals(other.ServiceGoalDetails)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Intervals != null)
					hash = hash * 59 + this.Intervals.GetHashCode();

				if (this.ErrorDetails != null)
					hash = hash * 59 + this.ErrorDetails.GetHashCode();

				if (this.ServiceGoalDetails != null)
					hash = hash * 59 + this.ServiceGoalDetails.GetHashCode();

				return hash;
			}
		}
	}

}
