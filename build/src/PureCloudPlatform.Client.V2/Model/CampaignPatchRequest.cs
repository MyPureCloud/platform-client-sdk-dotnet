using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Campaign patch request
	/// </summary>
	[DataContract]
	public partial class CampaignPatchRequest : IEquatable<CampaignPatchRequest>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CampaignPatchRequest" /> class.
		/// </summary>
		/// <param name="OutboundLineCount">The number of outbound lines to be concurrently dialed..</param>
		/// <param name="AbandonRate">The targeted compliance abandon rate percentage.</param>
		/// <param name="MaxCallsPerAgent">The maximum number of calls that can be placed per agent on this campaign.</param>
		/// <param name="DynamicLineBalancingSettings">Dynamic line balancing settings.</param>
		/// <param name="Queue">The Queue for this Campaign to route calls to..</param>
		public CampaignPatchRequest(int? OutboundLineCount = null, double? AbandonRate = null, double? MaxCallsPerAgent = null, DynamicLineBalancingSettingsPatchRequest DynamicLineBalancingSettings = null, AddressableEntityRef Queue = null)
		{
			this.OutboundLineCount = OutboundLineCount;
			this.AbandonRate = AbandonRate;
			this.MaxCallsPerAgent = MaxCallsPerAgent;
			this.DynamicLineBalancingSettings = DynamicLineBalancingSettings;
			this.Queue = Queue;

		}



		/// <summary>
		/// The number of outbound lines to be concurrently dialed.
		/// </summary>
		/// <value>The number of outbound lines to be concurrently dialed.</value>
		[DataMember(Name = "outboundLineCount", EmitDefaultValue = false)]
		public int? OutboundLineCount { get; set; }



		/// <summary>
		/// The targeted compliance abandon rate percentage
		/// </summary>
		/// <value>The targeted compliance abandon rate percentage</value>
		[DataMember(Name = "abandonRate", EmitDefaultValue = false)]
		public double? AbandonRate { get; set; }



		/// <summary>
		/// The maximum number of calls that can be placed per agent on this campaign
		/// </summary>
		/// <value>The maximum number of calls that can be placed per agent on this campaign</value>
		[DataMember(Name = "maxCallsPerAgent", EmitDefaultValue = false)]
		public double? MaxCallsPerAgent { get; set; }



		/// <summary>
		/// Dynamic line balancing settings
		/// </summary>
		/// <value>Dynamic line balancing settings</value>
		[DataMember(Name = "dynamicLineBalancingSettings", EmitDefaultValue = false)]
		public DynamicLineBalancingSettingsPatchRequest DynamicLineBalancingSettings { get; set; }



		/// <summary>
		/// The Queue for this Campaign to route calls to.
		/// </summary>
		/// <value>The Queue for this Campaign to route calls to.</value>
		[DataMember(Name = "queue", EmitDefaultValue = false)]
		public AddressableEntityRef Queue { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CampaignPatchRequest {\n");

			sb.Append("  OutboundLineCount: ").Append(OutboundLineCount).Append("\n");
			sb.Append("  AbandonRate: ").Append(AbandonRate).Append("\n");
			sb.Append("  MaxCallsPerAgent: ").Append(MaxCallsPerAgent).Append("\n");
			sb.Append("  DynamicLineBalancingSettings: ").Append(DynamicLineBalancingSettings).Append("\n");
			sb.Append("  Queue: ").Append(Queue).Append("\n");
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
			return this.Equals(obj as CampaignPatchRequest);
		}

		/// <summary>
		/// Returns true if CampaignPatchRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of CampaignPatchRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CampaignPatchRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.OutboundLineCount == other.OutboundLineCount ||
					this.OutboundLineCount != null &&
					this.OutboundLineCount.Equals(other.OutboundLineCount)
				) &&
				(
					this.AbandonRate == other.AbandonRate ||
					this.AbandonRate != null &&
					this.AbandonRate.Equals(other.AbandonRate)
				) &&
				(
					this.MaxCallsPerAgent == other.MaxCallsPerAgent ||
					this.MaxCallsPerAgent != null &&
					this.MaxCallsPerAgent.Equals(other.MaxCallsPerAgent)
				) &&
				(
					this.DynamicLineBalancingSettings == other.DynamicLineBalancingSettings ||
					this.DynamicLineBalancingSettings != null &&
					this.DynamicLineBalancingSettings.Equals(other.DynamicLineBalancingSettings)
				) &&
				(
					this.Queue == other.Queue ||
					this.Queue != null &&
					this.Queue.Equals(other.Queue)
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
				if (this.OutboundLineCount != null)
					hash = hash * 59 + this.OutboundLineCount.GetHashCode();

				if (this.AbandonRate != null)
					hash = hash * 59 + this.AbandonRate.GetHashCode();

				if (this.MaxCallsPerAgent != null)
					hash = hash * 59 + this.MaxCallsPerAgent.GetHashCode();

				if (this.DynamicLineBalancingSettings != null)
					hash = hash * 59 + this.DynamicLineBalancingSettings.GetHashCode();

				if (this.Queue != null)
					hash = hash * 59 + this.Queue.GetHashCode();

				return hash;
			}
		}
	}

}
