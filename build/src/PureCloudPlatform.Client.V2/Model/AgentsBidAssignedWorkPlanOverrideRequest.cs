using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AgentsBidAssignedWorkPlanOverrideRequest
	/// </summary>
	[DataContract]
	public partial class AgentsBidAssignedWorkPlanOverrideRequest : IEquatable<AgentsBidAssignedWorkPlanOverrideRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="AgentsBidAssignedWorkPlanOverrideRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AgentsBidAssignedWorkPlanOverrideRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AgentsBidAssignedWorkPlanOverrideRequest" /> class.
		/// </summary>
		/// <param name="AgentWorkPlanOverrides">The list of agent work plan overrides (required).</param>
		public AgentsBidAssignedWorkPlanOverrideRequest(List<AgentBidWorkPlanOverrideRequest> AgentWorkPlanOverrides = null)
		{
			this.AgentWorkPlanOverrides = AgentWorkPlanOverrides;

		}



		/// <summary>
		/// The list of agent work plan overrides
		/// </summary>
		/// <value>The list of agent work plan overrides</value>
		[DataMember(Name = "agentWorkPlanOverrides", EmitDefaultValue = false)]
		public List<AgentBidWorkPlanOverrideRequest> AgentWorkPlanOverrides { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AgentsBidAssignedWorkPlanOverrideRequest {\n");

			sb.Append("  AgentWorkPlanOverrides: ").Append(AgentWorkPlanOverrides).Append("\n");
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
			return this.Equals(obj as AgentsBidAssignedWorkPlanOverrideRequest);
		}

		/// <summary>
		/// Returns true if AgentsBidAssignedWorkPlanOverrideRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of AgentsBidAssignedWorkPlanOverrideRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AgentsBidAssignedWorkPlanOverrideRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.AgentWorkPlanOverrides == other.AgentWorkPlanOverrides ||
					this.AgentWorkPlanOverrides != null &&
					this.AgentWorkPlanOverrides.SequenceEqual(other.AgentWorkPlanOverrides)
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
				if (this.AgentWorkPlanOverrides != null)
					hash = hash * 59 + this.AgentWorkPlanOverrides.GetHashCode();

				return hash;
			}
		}
	}

}
