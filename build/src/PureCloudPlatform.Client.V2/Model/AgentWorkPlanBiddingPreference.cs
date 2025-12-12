using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AgentWorkPlanBiddingPreference
	/// </summary>
	[DataContract]
	public partial class AgentWorkPlanBiddingPreference : IEquatable<AgentWorkPlanBiddingPreference>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="AgentWorkPlanBiddingPreference" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AgentWorkPlanBiddingPreference() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AgentWorkPlanBiddingPreference" /> class.
		/// </summary>
		/// <param name="WorkPlan">The work plan that belongs to the agent&#39;s bid group (required).</param>
		/// <param name="Priority">The agent&#39;s priority for this work plan, with 1 being the best priority. Null if priority is not set for the work plan.</param>
		public AgentWorkPlanBiddingPreference(WorkPlanReference WorkPlan = null, int? Priority = null)
		{
			this.WorkPlan = WorkPlan;
			this.Priority = Priority;

		}



		/// <summary>
		/// The work plan that belongs to the agent&#39;s bid group
		/// </summary>
		/// <value>The work plan that belongs to the agent&#39;s bid group</value>
		[DataMember(Name = "workPlan", EmitDefaultValue = false)]
		public WorkPlanReference WorkPlan { get; set; }



		/// <summary>
		/// The agent&#39;s priority for this work plan, with 1 being the best priority. Null if priority is not set for the work plan
		/// </summary>
		/// <value>The agent&#39;s priority for this work plan, with 1 being the best priority. Null if priority is not set for the work plan</value>
		[DataMember(Name = "priority", EmitDefaultValue = false)]
		public int? Priority { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AgentWorkPlanBiddingPreference {\n");

			sb.Append("  WorkPlan: ").Append(WorkPlan).Append("\n");
			sb.Append("  Priority: ").Append(Priority).Append("\n");
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
			return this.Equals(obj as AgentWorkPlanBiddingPreference);
		}

		/// <summary>
		/// Returns true if AgentWorkPlanBiddingPreference instances are equal
		/// </summary>
		/// <param name="other">Instance of AgentWorkPlanBiddingPreference to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AgentWorkPlanBiddingPreference other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.WorkPlan == other.WorkPlan ||
					this.WorkPlan != null &&
					this.WorkPlan.Equals(other.WorkPlan)
				) &&
				(
					this.Priority == other.Priority ||
					this.Priority != null &&
					this.Priority.Equals(other.Priority)
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
				if (this.WorkPlan != null)
					hash = hash * 59 + this.WorkPlan.GetHashCode();

				if (this.Priority != null)
					hash = hash * 59 + this.Priority.GetHashCode();

				return hash;
			}
		}
	}

}
