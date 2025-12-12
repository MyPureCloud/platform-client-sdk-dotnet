using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AgentWorkPlanBiddingPreferenceRequest
	/// </summary>
	[DataContract]
	public partial class AgentWorkPlanBiddingPreferenceRequest : IEquatable<AgentWorkPlanBiddingPreferenceRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="AgentWorkPlanBiddingPreferenceRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AgentWorkPlanBiddingPreferenceRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AgentWorkPlanBiddingPreferenceRequest" /> class.
		/// </summary>
		/// <param name="WorkPlanId">The ID of the work plan that belongs to agent&#39;s bid group (required).</param>
		/// <param name="Priority">The agent&#39;s priority for this work plan, with 1 being the best priority. Null if priority is not set for the work plan.</param>
		public AgentWorkPlanBiddingPreferenceRequest(string WorkPlanId = null, int? Priority = null)
		{
			this.WorkPlanId = WorkPlanId;
			this.Priority = Priority;

		}



		/// <summary>
		/// The ID of the work plan that belongs to agent&#39;s bid group
		/// </summary>
		/// <value>The ID of the work plan that belongs to agent&#39;s bid group</value>
		[DataMember(Name = "workPlanId", EmitDefaultValue = false)]
		public string WorkPlanId { get; set; }



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
			sb.Append("class AgentWorkPlanBiddingPreferenceRequest {\n");

			sb.Append("  WorkPlanId: ").Append(WorkPlanId).Append("\n");
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
			return this.Equals(obj as AgentWorkPlanBiddingPreferenceRequest);
		}

		/// <summary>
		/// Returns true if AgentWorkPlanBiddingPreferenceRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of AgentWorkPlanBiddingPreferenceRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AgentWorkPlanBiddingPreferenceRequest other)
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
				if (this.WorkPlanId != null)
					hash = hash * 59 + this.WorkPlanId.GetHashCode();

				if (this.Priority != null)
					hash = hash * 59 + this.Priority.GetHashCode();

				return hash;
			}
		}
	}

}
