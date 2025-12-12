using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// EvaluationSettings
	/// </summary>
	[DataContract]
	public partial class EvaluationSettings : IEquatable<EvaluationSettings>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EvaluationSettings" /> class.
		/// </summary>
		/// <param name="RevisionsEnabled">Whether revisions are allowed for evaluations. When enabled, rescoring creates a new version of the evaluation and retracts the existing evaluation version. Does not apply for calibration evaluations..</param>
		/// <param name="DisputesEnabled">Whether disputes are allowed for evaluations. Does not apply for calibration evaluations..</param>
		/// <param name="DisputesAllowedPerEvaluation">The maximum number of disputes allowed for an evaluation..</param>
		/// <param name="DisputesAssignees">A list of assignees responsible for handling each dispute. This list size needs to be equal to disputesAllowedPerEvaluation..</param>
		public EvaluationSettings(bool? RevisionsEnabled = null, bool? DisputesEnabled = null, int? DisputesAllowedPerEvaluation = null, List<EvaluationSettingsAssignee> DisputesAssignees = null)
		{
			this.RevisionsEnabled = RevisionsEnabled;
			this.DisputesEnabled = DisputesEnabled;
			this.DisputesAllowedPerEvaluation = DisputesAllowedPerEvaluation;
			this.DisputesAssignees = DisputesAssignees;

		}



		/// <summary>
		/// Whether revisions are allowed for evaluations. When enabled, rescoring creates a new version of the evaluation and retracts the existing evaluation version. Does not apply for calibration evaluations.
		/// </summary>
		/// <value>Whether revisions are allowed for evaluations. When enabled, rescoring creates a new version of the evaluation and retracts the existing evaluation version. Does not apply for calibration evaluations.</value>
		[DataMember(Name = "revisionsEnabled", EmitDefaultValue = false)]
		public bool? RevisionsEnabled { get; set; }



		/// <summary>
		/// Whether disputes are allowed for evaluations. Does not apply for calibration evaluations.
		/// </summary>
		/// <value>Whether disputes are allowed for evaluations. Does not apply for calibration evaluations.</value>
		[DataMember(Name = "disputesEnabled", EmitDefaultValue = false)]
		public bool? DisputesEnabled { get; set; }



		/// <summary>
		/// The maximum number of disputes allowed for an evaluation.
		/// </summary>
		/// <value>The maximum number of disputes allowed for an evaluation.</value>
		[DataMember(Name = "disputesAllowedPerEvaluation", EmitDefaultValue = false)]
		public int? DisputesAllowedPerEvaluation { get; set; }



		/// <summary>
		/// A list of assignees responsible for handling each dispute. This list size needs to be equal to disputesAllowedPerEvaluation.
		/// </summary>
		/// <value>A list of assignees responsible for handling each dispute. This list size needs to be equal to disputesAllowedPerEvaluation.</value>
		[DataMember(Name = "disputesAssignees", EmitDefaultValue = false)]
		public List<EvaluationSettingsAssignee> DisputesAssignees { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class EvaluationSettings {\n");

			sb.Append("  RevisionsEnabled: ").Append(RevisionsEnabled).Append("\n");
			sb.Append("  DisputesEnabled: ").Append(DisputesEnabled).Append("\n");
			sb.Append("  DisputesAllowedPerEvaluation: ").Append(DisputesAllowedPerEvaluation).Append("\n");
			sb.Append("  DisputesAssignees: ").Append(DisputesAssignees).Append("\n");
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
			return this.Equals(obj as EvaluationSettings);
		}

		/// <summary>
		/// Returns true if EvaluationSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of EvaluationSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(EvaluationSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.RevisionsEnabled == other.RevisionsEnabled ||
					this.RevisionsEnabled != null &&
					this.RevisionsEnabled.Equals(other.RevisionsEnabled)
				) &&
				(
					this.DisputesEnabled == other.DisputesEnabled ||
					this.DisputesEnabled != null &&
					this.DisputesEnabled.Equals(other.DisputesEnabled)
				) &&
				(
					this.DisputesAllowedPerEvaluation == other.DisputesAllowedPerEvaluation ||
					this.DisputesAllowedPerEvaluation != null &&
					this.DisputesAllowedPerEvaluation.Equals(other.DisputesAllowedPerEvaluation)
				) &&
				(
					this.DisputesAssignees == other.DisputesAssignees ||
					this.DisputesAssignees != null &&
					this.DisputesAssignees.SequenceEqual(other.DisputesAssignees)
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
				if (this.RevisionsEnabled != null)
					hash = hash * 59 + this.RevisionsEnabled.GetHashCode();

				if (this.DisputesEnabled != null)
					hash = hash * 59 + this.DisputesEnabled.GetHashCode();

				if (this.DisputesAllowedPerEvaluation != null)
					hash = hash * 59 + this.DisputesAllowedPerEvaluation.GetHashCode();

				if (this.DisputesAssignees != null)
					hash = hash * 59 + this.DisputesAssignees.GetHashCode();

				return hash;
			}
		}
	}

}
