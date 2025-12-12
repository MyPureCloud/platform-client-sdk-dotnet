using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Learning module reassign summary data
	/// </summary>
	[DataContract]
	public partial class LearningModuleReassignSummary : IEquatable<LearningModuleReassignSummary>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LearningModuleReassignSummary" /> class.
		/// </summary>
		/// <param name="TotalReassigned">The total number of users for whom assignment is reassigned.</param>
		/// <param name="CompletedCount">The total number of users who have the assignment in Completed state.</param>
		/// <param name="InProgressCount">The total number of users who have the assignment in InProgress state.</param>
		/// <param name="AssignedCount">The total number of users who have the assignment in Assigned state.</param>
		/// <param name="NotCompletedCount">The total number of users who have their assignment overdue.</param>
		public LearningModuleReassignSummary(int? TotalReassigned = null, int? CompletedCount = null, int? InProgressCount = null, int? AssignedCount = null, int? NotCompletedCount = null)
		{
			this.TotalReassigned = TotalReassigned;
			this.CompletedCount = CompletedCount;
			this.InProgressCount = InProgressCount;
			this.AssignedCount = AssignedCount;
			this.NotCompletedCount = NotCompletedCount;

		}



		/// <summary>
		/// The total number of users for whom assignment is reassigned
		/// </summary>
		/// <value>The total number of users for whom assignment is reassigned</value>
		[DataMember(Name = "totalReassigned", EmitDefaultValue = false)]
		public int? TotalReassigned { get; set; }



		/// <summary>
		/// The total number of users who have the assignment in Completed state
		/// </summary>
		/// <value>The total number of users who have the assignment in Completed state</value>
		[DataMember(Name = "completedCount", EmitDefaultValue = false)]
		public int? CompletedCount { get; set; }



		/// <summary>
		/// The total number of users who have the assignment in InProgress state
		/// </summary>
		/// <value>The total number of users who have the assignment in InProgress state</value>
		[DataMember(Name = "inProgressCount", EmitDefaultValue = false)]
		public int? InProgressCount { get; set; }



		/// <summary>
		/// The total number of users who have the assignment in Assigned state
		/// </summary>
		/// <value>The total number of users who have the assignment in Assigned state</value>
		[DataMember(Name = "assignedCount", EmitDefaultValue = false)]
		public int? AssignedCount { get; set; }



		/// <summary>
		/// The total number of users who have their assignment overdue
		/// </summary>
		/// <value>The total number of users who have their assignment overdue</value>
		[DataMember(Name = "notCompletedCount", EmitDefaultValue = false)]
		public int? NotCompletedCount { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LearningModuleReassignSummary {\n");

			sb.Append("  TotalReassigned: ").Append(TotalReassigned).Append("\n");
			sb.Append("  CompletedCount: ").Append(CompletedCount).Append("\n");
			sb.Append("  InProgressCount: ").Append(InProgressCount).Append("\n");
			sb.Append("  AssignedCount: ").Append(AssignedCount).Append("\n");
			sb.Append("  NotCompletedCount: ").Append(NotCompletedCount).Append("\n");
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
			return this.Equals(obj as LearningModuleReassignSummary);
		}

		/// <summary>
		/// Returns true if LearningModuleReassignSummary instances are equal
		/// </summary>
		/// <param name="other">Instance of LearningModuleReassignSummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LearningModuleReassignSummary other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.TotalReassigned == other.TotalReassigned ||
					this.TotalReassigned != null &&
					this.TotalReassigned.Equals(other.TotalReassigned)
				) &&
				(
					this.CompletedCount == other.CompletedCount ||
					this.CompletedCount != null &&
					this.CompletedCount.Equals(other.CompletedCount)
				) &&
				(
					this.InProgressCount == other.InProgressCount ||
					this.InProgressCount != null &&
					this.InProgressCount.Equals(other.InProgressCount)
				) &&
				(
					this.AssignedCount == other.AssignedCount ||
					this.AssignedCount != null &&
					this.AssignedCount.Equals(other.AssignedCount)
				) &&
				(
					this.NotCompletedCount == other.NotCompletedCount ||
					this.NotCompletedCount != null &&
					this.NotCompletedCount.Equals(other.NotCompletedCount)
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
				if (this.TotalReassigned != null)
					hash = hash * 59 + this.TotalReassigned.GetHashCode();

				if (this.CompletedCount != null)
					hash = hash * 59 + this.CompletedCount.GetHashCode();

				if (this.InProgressCount != null)
					hash = hash * 59 + this.InProgressCount.GetHashCode();

				if (this.AssignedCount != null)
					hash = hash * 59 + this.AssignedCount.GetHashCode();

				if (this.NotCompletedCount != null)
					hash = hash * 59 + this.NotCompletedCount.GetHashCode();

				return hash;
			}
		}
	}

}
