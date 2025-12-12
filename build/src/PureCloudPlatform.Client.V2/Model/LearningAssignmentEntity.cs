using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LearningAssignmentEntity
	/// </summary>
	[DataContract]
	public partial class LearningAssignmentEntity : IEquatable<LearningAssignmentEntity>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LearningAssignmentEntity" /> class.
		/// </summary>
		/// <param name="AssignmentId">AssignmentId.</param>
		public LearningAssignmentEntity(string AssignmentId = null)
		{
			this.AssignmentId = AssignmentId;

		}



		/// <summary>
		/// Gets or Sets AssignmentId
		/// </summary>
		[DataMember(Name = "assignmentId", EmitDefaultValue = false)]
		public string AssignmentId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LearningAssignmentEntity {\n");

			sb.Append("  AssignmentId: ").Append(AssignmentId).Append("\n");
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
			return this.Equals(obj as LearningAssignmentEntity);
		}

		/// <summary>
		/// Returns true if LearningAssignmentEntity instances are equal
		/// </summary>
		/// <param name="other">Instance of LearningAssignmentEntity to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LearningAssignmentEntity other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.AssignmentId == other.AssignmentId ||
					this.AssignmentId != null &&
					this.AssignmentId.Equals(other.AssignmentId)
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
				if (this.AssignmentId != null)
					hash = hash * 59 + this.AssignmentId.GetHashCode();

				return hash;
			}
		}
	}

}
