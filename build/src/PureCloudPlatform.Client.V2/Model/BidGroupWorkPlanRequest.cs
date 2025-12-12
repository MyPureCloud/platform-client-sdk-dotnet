using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BidGroupWorkPlanRequest
	/// </summary>
	[DataContract]
	public partial class BidGroupWorkPlanRequest : IEquatable<BidGroupWorkPlanRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="BidGroupWorkPlanRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected BidGroupWorkPlanRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="BidGroupWorkPlanRequest" /> class.
		/// </summary>
		/// <param name="WorkPlanId">The ID of the work plan used in the bid group (required).</param>
		/// <param name="OverrideAgentCount">The modified agent count for this work plan.</param>
		public BidGroupWorkPlanRequest(string WorkPlanId = null, int? OverrideAgentCount = null)
		{
			this.WorkPlanId = WorkPlanId;
			this.OverrideAgentCount = OverrideAgentCount;

		}



		/// <summary>
		/// The ID of the work plan used in the bid group
		/// </summary>
		/// <value>The ID of the work plan used in the bid group</value>
		[DataMember(Name = "workPlanId", EmitDefaultValue = false)]
		public string WorkPlanId { get; set; }



		/// <summary>
		/// The modified agent count for this work plan
		/// </summary>
		/// <value>The modified agent count for this work plan</value>
		[DataMember(Name = "overrideAgentCount", EmitDefaultValue = false)]
		public int? OverrideAgentCount { get; set; }



		/// <summary>
		/// The number of agents needed for this work plan to produce the optimal schedule
		/// </summary>
		/// <value>The number of agents needed for this work plan to produce the optimal schedule</value>
		[DataMember(Name = "suggestedAgentCount", EmitDefaultValue = false)]
		public int? SuggestedAgentCount { get; private set; }



		/// <summary>
		/// The range of agent slot count per work plan. The suggested slot count must be in agent count range
		/// </summary>
		/// <value>The range of agent slot count per work plan. The suggested slot count must be in agent count range</value>
		[DataMember(Name = "agentCountRange", EmitDefaultValue = false)]
		public AgentCountRange AgentCountRange { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BidGroupWorkPlanRequest {\n");

			sb.Append("  WorkPlanId: ").Append(WorkPlanId).Append("\n");
			sb.Append("  OverrideAgentCount: ").Append(OverrideAgentCount).Append("\n");
			sb.Append("  SuggestedAgentCount: ").Append(SuggestedAgentCount).Append("\n");
			sb.Append("  AgentCountRange: ").Append(AgentCountRange).Append("\n");
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
			return this.Equals(obj as BidGroupWorkPlanRequest);
		}

		/// <summary>
		/// Returns true if BidGroupWorkPlanRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of BidGroupWorkPlanRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BidGroupWorkPlanRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.WorkPlanId == other.WorkPlanId ||
					this.WorkPlanId != null &&
					this.WorkPlanId.Equals(other.WorkPlanId)
				) &&
				(
					this.OverrideAgentCount == other.OverrideAgentCount ||
					this.OverrideAgentCount != null &&
					this.OverrideAgentCount.Equals(other.OverrideAgentCount)
				) &&
				(
					this.SuggestedAgentCount == other.SuggestedAgentCount ||
					this.SuggestedAgentCount != null &&
					this.SuggestedAgentCount.Equals(other.SuggestedAgentCount)
				) &&
				(
					this.AgentCountRange == other.AgentCountRange ||
					this.AgentCountRange != null &&
					this.AgentCountRange.Equals(other.AgentCountRange)
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
				if (this.WorkPlanId != null)
					hash = hash * 59 + this.WorkPlanId.GetHashCode();

				if (this.OverrideAgentCount != null)
					hash = hash * 59 + this.OverrideAgentCount.GetHashCode();

				if (this.SuggestedAgentCount != null)
					hash = hash * 59 + this.SuggestedAgentCount.GetHashCode();

				if (this.AgentCountRange != null)
					hash = hash * 59 + this.AgentCountRange.GetHashCode();

				return hash;
			}
		}
	}

}
