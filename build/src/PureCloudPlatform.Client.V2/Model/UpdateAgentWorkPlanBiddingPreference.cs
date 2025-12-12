using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UpdateAgentWorkPlanBiddingPreference
	/// </summary>
	[DataContract]
	public partial class UpdateAgentWorkPlanBiddingPreference : IEquatable<UpdateAgentWorkPlanBiddingPreference>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateAgentWorkPlanBiddingPreference" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UpdateAgentWorkPlanBiddingPreference() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateAgentWorkPlanBiddingPreference" /> class.
		/// </summary>
		/// <param name="Submitted">Whether the preference is submitted (required).</param>
		/// <param name="AgentWorkPlanBidPreferences">The list of work plan bidding preferences (required).</param>
		public UpdateAgentWorkPlanBiddingPreference(bool? Submitted = null, List<AgentWorkPlanBiddingPreferenceRequest> AgentWorkPlanBidPreferences = null)
		{
			this.Submitted = Submitted;
			this.AgentWorkPlanBidPreferences = AgentWorkPlanBidPreferences;

		}



		/// <summary>
		/// Whether the preference is submitted
		/// </summary>
		/// <value>Whether the preference is submitted</value>
		[DataMember(Name = "submitted", EmitDefaultValue = false)]
		public bool? Submitted { get; set; }



		/// <summary>
		/// The list of work plan bidding preferences
		/// </summary>
		/// <value>The list of work plan bidding preferences</value>
		[DataMember(Name = "agentWorkPlanBidPreferences", EmitDefaultValue = false)]
		public List<AgentWorkPlanBiddingPreferenceRequest> AgentWorkPlanBidPreferences { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateAgentWorkPlanBiddingPreference {\n");

			sb.Append("  Submitted: ").Append(Submitted).Append("\n");
			sb.Append("  AgentWorkPlanBidPreferences: ").Append(AgentWorkPlanBidPreferences).Append("\n");
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
			return this.Equals(obj as UpdateAgentWorkPlanBiddingPreference);
		}

		/// <summary>
		/// Returns true if UpdateAgentWorkPlanBiddingPreference instances are equal
		/// </summary>
		/// <param name="other">Instance of UpdateAgentWorkPlanBiddingPreference to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UpdateAgentWorkPlanBiddingPreference other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Submitted == other.Submitted ||
					this.Submitted != null &&
					this.Submitted.Equals(other.Submitted)
				) &&
				(
					this.AgentWorkPlanBidPreferences == other.AgentWorkPlanBidPreferences ||
					this.AgentWorkPlanBidPreferences != null &&
					this.AgentWorkPlanBidPreferences.SequenceEqual(other.AgentWorkPlanBidPreferences)
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
				if (this.Submitted != null)
					hash = hash * 59 + this.Submitted.GetHashCode();

				if (this.AgentWorkPlanBidPreferences != null)
					hash = hash * 59 + this.AgentWorkPlanBidPreferences.GetHashCode();

				return hash;
			}
		}
	}

}
