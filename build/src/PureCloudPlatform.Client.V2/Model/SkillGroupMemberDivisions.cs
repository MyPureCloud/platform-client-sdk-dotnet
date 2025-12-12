using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SkillGroupMemberDivisions
	/// </summary>
	[DataContract]
	public partial class SkillGroupMemberDivisions : IEquatable<SkillGroupMemberDivisions>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SkillGroupMemberDivisions" /> class.
		/// </summary>
		/// <param name="AddDivisionIds">AddDivisionIds.</param>
		/// <param name="RemoveDivisionIds">RemoveDivisionIds.</param>
		public SkillGroupMemberDivisions(List<string> AddDivisionIds = null, List<string> RemoveDivisionIds = null)
		{
			this.AddDivisionIds = AddDivisionIds;
			this.RemoveDivisionIds = RemoveDivisionIds;

		}



		/// <summary>
		/// Gets or Sets AddDivisionIds
		/// </summary>
		[DataMember(Name = "addDivisionIds", EmitDefaultValue = false)]
		public List<string> AddDivisionIds { get; set; }



		/// <summary>
		/// Gets or Sets RemoveDivisionIds
		/// </summary>
		[DataMember(Name = "removeDivisionIds", EmitDefaultValue = false)]
		public List<string> RemoveDivisionIds { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SkillGroupMemberDivisions {\n");

			sb.Append("  AddDivisionIds: ").Append(AddDivisionIds).Append("\n");
			sb.Append("  RemoveDivisionIds: ").Append(RemoveDivisionIds).Append("\n");
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
			return this.Equals(obj as SkillGroupMemberDivisions);
		}

		/// <summary>
		/// Returns true if SkillGroupMemberDivisions instances are equal
		/// </summary>
		/// <param name="other">Instance of SkillGroupMemberDivisions to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SkillGroupMemberDivisions other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.AddDivisionIds == other.AddDivisionIds ||
					this.AddDivisionIds != null &&
					this.AddDivisionIds.SequenceEqual(other.AddDivisionIds)
				) &&
				(
					this.RemoveDivisionIds == other.RemoveDivisionIds ||
					this.RemoveDivisionIds != null &&
					this.RemoveDivisionIds.SequenceEqual(other.RemoveDivisionIds)
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
				if (this.AddDivisionIds != null)
					hash = hash * 59 + this.AddDivisionIds.GetHashCode();

				if (this.RemoveDivisionIds != null)
					hash = hash * 59 + this.RemoveDivisionIds.GetHashCode();

				return hash;
			}
		}
	}

}
