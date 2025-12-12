using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CampaignRuleActionEntities
	/// </summary>
	[DataContract]
	public partial class CampaignRuleActionEntities : IEquatable<CampaignRuleActionEntities>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CampaignRuleActionEntities" /> class.
		/// </summary>
		/// <param name="Campaigns">The list of campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a campaign..</param>
		/// <param name="Sequences">The list of sequences for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a sequence..</param>
		/// <param name="EmailCampaigns">The list of Email campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a Email campaign..</param>
		/// <param name="SmsCampaigns">The list of SMS campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a SMS campaign..</param>
		/// <param name="UseTriggeringEntity">If true, the CampaignRuleAction will apply to the same entity that triggered the CampaignRuleCondition..</param>
		public CampaignRuleActionEntities(List<DomainEntityRef> Campaigns = null, List<DomainEntityRef> Sequences = null, List<DomainEntityRef> EmailCampaigns = null, List<DomainEntityRef> SmsCampaigns = null, bool? UseTriggeringEntity = null)
		{
			this.Campaigns = Campaigns;
			this.Sequences = Sequences;
			this.EmailCampaigns = EmailCampaigns;
			this.SmsCampaigns = SmsCampaigns;
			this.UseTriggeringEntity = UseTriggeringEntity;

		}



		/// <summary>
		/// The list of campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a campaign.
		/// </summary>
		/// <value>The list of campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a campaign.</value>
		[DataMember(Name = "campaigns", EmitDefaultValue = false)]
		public List<DomainEntityRef> Campaigns { get; set; }



		/// <summary>
		/// The list of sequences for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a sequence.
		/// </summary>
		/// <value>The list of sequences for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a sequence.</value>
		[DataMember(Name = "sequences", EmitDefaultValue = false)]
		public List<DomainEntityRef> Sequences { get; set; }



		/// <summary>
		/// The list of Email campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a Email campaign.
		/// </summary>
		/// <value>The list of Email campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a Email campaign.</value>
		[DataMember(Name = "emailCampaigns", EmitDefaultValue = false)]
		public List<DomainEntityRef> EmailCampaigns { get; set; }



		/// <summary>
		/// The list of SMS campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a SMS campaign.
		/// </summary>
		/// <value>The list of SMS campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a SMS campaign.</value>
		[DataMember(Name = "smsCampaigns", EmitDefaultValue = false)]
		public List<DomainEntityRef> SmsCampaigns { get; set; }



		/// <summary>
		/// If true, the CampaignRuleAction will apply to the same entity that triggered the CampaignRuleCondition.
		/// </summary>
		/// <value>If true, the CampaignRuleAction will apply to the same entity that triggered the CampaignRuleCondition.</value>
		[DataMember(Name = "useTriggeringEntity", EmitDefaultValue = false)]
		public bool? UseTriggeringEntity { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CampaignRuleActionEntities {\n");

			sb.Append("  Campaigns: ").Append(Campaigns).Append("\n");
			sb.Append("  Sequences: ").Append(Sequences).Append("\n");
			sb.Append("  EmailCampaigns: ").Append(EmailCampaigns).Append("\n");
			sb.Append("  SmsCampaigns: ").Append(SmsCampaigns).Append("\n");
			sb.Append("  UseTriggeringEntity: ").Append(UseTriggeringEntity).Append("\n");
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
			return this.Equals(obj as CampaignRuleActionEntities);
		}

		/// <summary>
		/// Returns true if CampaignRuleActionEntities instances are equal
		/// </summary>
		/// <param name="other">Instance of CampaignRuleActionEntities to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CampaignRuleActionEntities other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Campaigns == other.Campaigns ||
					this.Campaigns != null &&
					this.Campaigns.SequenceEqual(other.Campaigns)
				) &&
				(
					this.Sequences == other.Sequences ||
					this.Sequences != null &&
					this.Sequences.SequenceEqual(other.Sequences)
				) &&
				(
					this.EmailCampaigns == other.EmailCampaigns ||
					this.EmailCampaigns != null &&
					this.EmailCampaigns.SequenceEqual(other.EmailCampaigns)
				) &&
				(
					this.SmsCampaigns == other.SmsCampaigns ||
					this.SmsCampaigns != null &&
					this.SmsCampaigns.SequenceEqual(other.SmsCampaigns)
				) &&
				(
					this.UseTriggeringEntity == other.UseTriggeringEntity ||
					this.UseTriggeringEntity != null &&
					this.UseTriggeringEntity.Equals(other.UseTriggeringEntity)
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
				if (this.Campaigns != null)
					hash = hash * 59 + this.Campaigns.GetHashCode();

				if (this.Sequences != null)
					hash = hash * 59 + this.Sequences.GetHashCode();

				if (this.EmailCampaigns != null)
					hash = hash * 59 + this.EmailCampaigns.GetHashCode();

				if (this.SmsCampaigns != null)
					hash = hash * 59 + this.SmsCampaigns.GetHashCode();

				if (this.UseTriggeringEntity != null)
					hash = hash * 59 + this.UseTriggeringEntity.GetHashCode();

				return hash;
			}
		}
	}

}
