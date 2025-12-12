using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// MuAgentsWorkPlansResult
	/// </summary>
	[DataContract]
	public partial class MuAgentsWorkPlansResult : IEquatable<MuAgentsWorkPlansResult>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="MuAgentsWorkPlansResult" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected MuAgentsWorkPlansResult() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="MuAgentsWorkPlansResult" /> class.
		/// </summary>
		/// <param name="Entities">Entities.</param>
		/// <param name="ReferenceStartWeekDate">The reference date in yyyy-MM-dd format rolled back to nearest BU start day of week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
		/// <param name="WorkPlanLookup">Map containing lookup values for agent work plans. The integer keys serves as lookup keys for effective work plan from workPlanLookupKeysPerWeek property (required).</param>
		public MuAgentsWorkPlansResult(List<AgentWorkPlans> Entities = null, String ReferenceStartWeekDate = null, Dictionary<string, WorkPlanReference> WorkPlanLookup = null)
		{
			this.Entities = Entities;
			this.ReferenceStartWeekDate = ReferenceStartWeekDate;
			this.WorkPlanLookup = WorkPlanLookup;

		}



		/// <summary>
		/// Gets or Sets Entities
		/// </summary>
		[DataMember(Name = "entities", EmitDefaultValue = false)]
		public List<AgentWorkPlans> Entities { get; set; }



		/// <summary>
		/// The reference date in yyyy-MM-dd format rolled back to nearest BU start day of week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The reference date in yyyy-MM-dd format rolled back to nearest BU start day of week. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "referenceStartWeekDate", EmitDefaultValue = false)]
		public String ReferenceStartWeekDate { get; set; }



		/// <summary>
		/// Map containing lookup values for agent work plans. The integer keys serves as lookup keys for effective work plan from workPlanLookupKeysPerWeek property
		/// </summary>
		/// <value>Map containing lookup values for agent work plans. The integer keys serves as lookup keys for effective work plan from workPlanLookupKeysPerWeek property</value>
		[DataMember(Name = "workPlanLookup", EmitDefaultValue = false)]
		public Dictionary<string, WorkPlanReference> WorkPlanLookup { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MuAgentsWorkPlansResult {\n");

			sb.Append("  Entities: ").Append(Entities).Append("\n");
			sb.Append("  ReferenceStartWeekDate: ").Append(ReferenceStartWeekDate).Append("\n");
			sb.Append("  WorkPlanLookup: ").Append(WorkPlanLookup).Append("\n");
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
			return this.Equals(obj as MuAgentsWorkPlansResult);
		}

		/// <summary>
		/// Returns true if MuAgentsWorkPlansResult instances are equal
		/// </summary>
		/// <param name="other">Instance of MuAgentsWorkPlansResult to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MuAgentsWorkPlansResult other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Entities == other.Entities ||
					this.Entities != null &&
					this.Entities.SequenceEqual(other.Entities)
				) &&
				(
					this.ReferenceStartWeekDate == other.ReferenceStartWeekDate ||
					this.ReferenceStartWeekDate != null &&
					this.ReferenceStartWeekDate.Equals(other.ReferenceStartWeekDate)
				) &&
				(
					this.WorkPlanLookup == other.WorkPlanLookup ||
					this.WorkPlanLookup != null &&
					this.WorkPlanLookup.SequenceEqual(other.WorkPlanLookup)
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
				if (this.Entities != null)
					hash = hash * 59 + this.Entities.GetHashCode();

				if (this.ReferenceStartWeekDate != null)
					hash = hash * 59 + this.ReferenceStartWeekDate.GetHashCode();

				if (this.WorkPlanLookup != null)
					hash = hash * 59 + this.WorkPlanLookup.GetHashCode();

				return hash;
			}
		}
	}

}
