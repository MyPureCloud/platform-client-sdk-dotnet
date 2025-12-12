using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LearningAssignmentRuleRunTopicLearningAssignmentsCreated
	/// </summary>
	[DataContract]
	public partial class LearningAssignmentRuleRunTopicLearningAssignmentsCreated : IEquatable<LearningAssignmentRuleRunTopicLearningAssignmentsCreated>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LearningAssignmentRuleRunTopicLearningAssignmentsCreated" /> class.
		/// </summary>
		/// <param name="Module">Module.</param>
		public LearningAssignmentRuleRunTopicLearningAssignmentsCreated(LearningAssignmentRuleRunTopicLearningModuleReference Module = null)
		{
			this.Module = Module;

		}



		/// <summary>
		/// Gets or Sets Module
		/// </summary>
		[DataMember(Name = "module", EmitDefaultValue = false)]
		public LearningAssignmentRuleRunTopicLearningModuleReference Module { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LearningAssignmentRuleRunTopicLearningAssignmentsCreated {\n");

			sb.Append("  Module: ").Append(Module).Append("\n");
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
			return this.Equals(obj as LearningAssignmentRuleRunTopicLearningAssignmentsCreated);
		}

		/// <summary>
		/// Returns true if LearningAssignmentRuleRunTopicLearningAssignmentsCreated instances are equal
		/// </summary>
		/// <param name="other">Instance of LearningAssignmentRuleRunTopicLearningAssignmentsCreated to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LearningAssignmentRuleRunTopicLearningAssignmentsCreated other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Module == other.Module ||
					this.Module != null &&
					this.Module.Equals(other.Module)
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
				if (this.Module != null)
					hash = hash * 59 + this.Module.GetHashCode();

				return hash;
			}
		}
	}

}
