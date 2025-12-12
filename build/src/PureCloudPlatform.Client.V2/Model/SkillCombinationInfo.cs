using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SkillCombinationInfo
	/// </summary>
	[DataContract]
	public partial class SkillCombinationInfo : IEquatable<SkillCombinationInfo>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SkillCombinationInfo" /> class.
		/// </summary>
		/// <param name="SkillCombination">A skill combination in the contact queue.</param>
		public SkillCombinationInfo(List<string> SkillCombination = null)
		{
			this.SkillCombination = SkillCombination;

		}



		/// <summary>
		/// A skill combination in the contact queue
		/// </summary>
		/// <value>A skill combination in the contact queue</value>
		[DataMember(Name = "skillCombination", EmitDefaultValue = false)]
		public List<string> SkillCombination { get; set; }



		/// <summary>
		/// Number of total contacts in the contact queue for this skill combination
		/// </summary>
		/// <value>Number of total contacts in the contact queue for this skill combination</value>
		[DataMember(Name = "totalCount", EmitDefaultValue = false)]
		public long? TotalCount { get; private set; }



		/// <summary>
		/// Number of remaining contacts in the contact queue for this skill combination
		/// </summary>
		/// <value>Number of remaining contacts in the contact queue for this skill combination</value>
		[DataMember(Name = "remainingCount", EmitDefaultValue = false)]
		public long? RemainingCount { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SkillCombinationInfo {\n");

			sb.Append("  SkillCombination: ").Append(SkillCombination).Append("\n");
			sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
			sb.Append("  RemainingCount: ").Append(RemainingCount).Append("\n");
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
			return this.Equals(obj as SkillCombinationInfo);
		}

		/// <summary>
		/// Returns true if SkillCombinationInfo instances are equal
		/// </summary>
		/// <param name="other">Instance of SkillCombinationInfo to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SkillCombinationInfo other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SkillCombination == other.SkillCombination ||
					this.SkillCombination != null &&
					this.SkillCombination.SequenceEqual(other.SkillCombination)
				) &&
				(
					this.TotalCount == other.TotalCount ||
					this.TotalCount != null &&
					this.TotalCount.Equals(other.TotalCount)
				) &&
				(
					this.RemainingCount == other.RemainingCount ||
					this.RemainingCount != null &&
					this.RemainingCount.Equals(other.RemainingCount)
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
				if (this.SkillCombination != null)
					hash = hash * 59 + this.SkillCombination.GetHashCode();

				if (this.TotalCount != null)
					hash = hash * 59 + this.TotalCount.GetHashCode();

				if (this.RemainingCount != null)
					hash = hash * 59 + this.RemainingCount.GetHashCode();

				return hash;
			}
		}
	}

}
