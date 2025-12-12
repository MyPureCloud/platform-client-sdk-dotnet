using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UpdateMuAgentWorkPlanRequest
	/// </summary>
	[DataContract]
	public partial class UpdateMuAgentWorkPlanRequest : IEquatable<UpdateMuAgentWorkPlanRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateMuAgentWorkPlanRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UpdateMuAgentWorkPlanRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateMuAgentWorkPlanRequest" /> class.
		/// </summary>
		/// <param name="UserId">The agent id for whom the work plan is updated (required).</param>
		/// <param name="WorkPlanId">The current work plan ID for the agent.</param>
		/// <param name="WorkPlanOverrides">The list of work plan overrides for the agent.</param>
		public UpdateMuAgentWorkPlanRequest(string UserId = null, ValueWrapperString WorkPlanId = null, WorkPlanOverrideListWrapperWorkPlanOverrideRequest WorkPlanOverrides = null)
		{
			this.UserId = UserId;
			this.WorkPlanId = WorkPlanId;
			this.WorkPlanOverrides = WorkPlanOverrides;

		}



		/// <summary>
		/// The agent id for whom the work plan is updated
		/// </summary>
		/// <value>The agent id for whom the work plan is updated</value>
		[DataMember(Name = "userId", EmitDefaultValue = false)]
		public string UserId { get; set; }



		/// <summary>
		/// The current work plan ID for the agent
		/// </summary>
		/// <value>The current work plan ID for the agent</value>
		[DataMember(Name = "workPlanId", EmitDefaultValue = false)]
		public ValueWrapperString WorkPlanId { get; set; }



		/// <summary>
		/// The list of work plan overrides for the agent
		/// </summary>
		/// <value>The list of work plan overrides for the agent</value>
		[DataMember(Name = "workPlanOverrides", EmitDefaultValue = false)]
		public WorkPlanOverrideListWrapperWorkPlanOverrideRequest WorkPlanOverrides { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateMuAgentWorkPlanRequest {\n");

			sb.Append("  UserId: ").Append(UserId).Append("\n");
			sb.Append("  WorkPlanId: ").Append(WorkPlanId).Append("\n");
			sb.Append("  WorkPlanOverrides: ").Append(WorkPlanOverrides).Append("\n");
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
			return this.Equals(obj as UpdateMuAgentWorkPlanRequest);
		}

		/// <summary>
		/// Returns true if UpdateMuAgentWorkPlanRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of UpdateMuAgentWorkPlanRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UpdateMuAgentWorkPlanRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.UserId == other.UserId ||
					this.UserId != null &&
					this.UserId.Equals(other.UserId)
				) &&
				(
					this.WorkPlanId == other.WorkPlanId ||
					this.WorkPlanId != null &&
					this.WorkPlanId.Equals(other.WorkPlanId)
				) &&
				(
					this.WorkPlanOverrides == other.WorkPlanOverrides ||
					this.WorkPlanOverrides != null &&
					this.WorkPlanOverrides.Equals(other.WorkPlanOverrides)
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
				if (this.UserId != null)
					hash = hash * 59 + this.UserId.GetHashCode();

				if (this.WorkPlanId != null)
					hash = hash * 59 + this.WorkPlanId.GetHashCode();

				if (this.WorkPlanOverrides != null)
					hash = hash * 59 + this.WorkPlanOverrides.GetHashCode();

				return hash;
			}
		}
	}

}
