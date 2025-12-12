using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LearningAssessmentScoringRequest
	/// </summary>
	[DataContract]
	public partial class LearningAssessmentScoringRequest : IEquatable<LearningAssessmentScoringRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="LearningAssessmentScoringRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected LearningAssessmentScoringRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="LearningAssessmentScoringRequest" /> class.
		/// </summary>
		/// <param name="AssessmentForm">The assessment form to score against (required).</param>
		/// <param name="Answers">The answers to score (required).</param>
		public LearningAssessmentScoringRequest(AssessmentForm AssessmentForm = null, AssessmentScoringSet Answers = null)
		{
			this.AssessmentForm = AssessmentForm;
			this.Answers = Answers;

		}



		/// <summary>
		/// The assessment form to score against
		/// </summary>
		/// <value>The assessment form to score against</value>
		[DataMember(Name = "assessmentForm", EmitDefaultValue = false)]
		public AssessmentForm AssessmentForm { get; set; }



		/// <summary>
		/// The answers to score
		/// </summary>
		/// <value>The answers to score</value>
		[DataMember(Name = "answers", EmitDefaultValue = false)]
		public AssessmentScoringSet Answers { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LearningAssessmentScoringRequest {\n");

			sb.Append("  AssessmentForm: ").Append(AssessmentForm).Append("\n");
			sb.Append("  Answers: ").Append(Answers).Append("\n");
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
			return this.Equals(obj as LearningAssessmentScoringRequest);
		}

		/// <summary>
		/// Returns true if LearningAssessmentScoringRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of LearningAssessmentScoringRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LearningAssessmentScoringRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.AssessmentForm == other.AssessmentForm ||
					this.AssessmentForm != null &&
					this.AssessmentForm.Equals(other.AssessmentForm)
				) &&
				(
					this.Answers == other.Answers ||
					this.Answers != null &&
					this.Answers.Equals(other.Answers)
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
				if (this.AssessmentForm != null)
					hash = hash * 59 + this.AssessmentForm.GetHashCode();

				if (this.Answers != null)
					hash = hash * 59 + this.Answers.GetHashCode();

				return hash;
			}
		}
	}

}
