using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Lines distribution information or Campaign&#39;s Edge Group or Site
	/// </summary>
	[DataContract]
	public partial class CampaignOutboundLinesDistribution : IEquatable<CampaignOutboundLinesDistribution>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CampaignOutboundLinesDistribution" /> class.
		/// </summary>
		/// <param name="Campaign">The Campaign for which dialing group distribution information was requested.</param>
		/// <param name="MaxOutboundLineCount">Maximum outbound calls that can be placed for Campaign&#39;s Edge Group or Site.</param>
		/// <param name="MaxLineUtilization">Maximum ratio of dialer calls to Campaign&#39;s Edge Group or Site capacity.</param>
		/// <param name="AvailableOutboundLines">Number of available outbound lines in Campaign&#39;s Edge Group or Site.</param>
		/// <param name="ReservedLines">Number of reserved outbound lines in Campaign&#39;s Edge Group or Site.</param>
		/// <param name="CampaignsWithReservedLines">Information about campaigns with reserving lines in Campaign&#39;s Edge Group or Site.</param>
		/// <param name="CampaignsWithDynamicallyAllocatedLines">Information about campaigns using dynamic lines allocation in Campaign&#39;s Edge Group or Site.</param>
		public CampaignOutboundLinesDistribution(AddressableEntityRef Campaign = null, int? MaxOutboundLineCount = null, double? MaxLineUtilization = null, int? AvailableOutboundLines = null, int? ReservedLines = null, List<CampaignOutboundLinesReservation> CampaignsWithReservedLines = null, List<CampaignOutboundLinesAllocation> CampaignsWithDynamicallyAllocatedLines = null)
		{
			this.Campaign = Campaign;
			this.MaxOutboundLineCount = MaxOutboundLineCount;
			this.MaxLineUtilization = MaxLineUtilization;
			this.AvailableOutboundLines = AvailableOutboundLines;
			this.ReservedLines = ReservedLines;
			this.CampaignsWithReservedLines = CampaignsWithReservedLines;
			this.CampaignsWithDynamicallyAllocatedLines = CampaignsWithDynamicallyAllocatedLines;

		}



		/// <summary>
		/// The Campaign for which dialing group distribution information was requested
		/// </summary>
		/// <value>The Campaign for which dialing group distribution information was requested</value>
		[DataMember(Name = "campaign", EmitDefaultValue = false)]
		public AddressableEntityRef Campaign { get; set; }



		/// <summary>
		/// Maximum outbound calls that can be placed for Campaign&#39;s Edge Group or Site
		/// </summary>
		/// <value>Maximum outbound calls that can be placed for Campaign&#39;s Edge Group or Site</value>
		[DataMember(Name = "maxOutboundLineCount", EmitDefaultValue = false)]
		public int? MaxOutboundLineCount { get; set; }



		/// <summary>
		/// Maximum ratio of dialer calls to Campaign&#39;s Edge Group or Site capacity
		/// </summary>
		/// <value>Maximum ratio of dialer calls to Campaign&#39;s Edge Group or Site capacity</value>
		[DataMember(Name = "maxLineUtilization", EmitDefaultValue = false)]
		public double? MaxLineUtilization { get; set; }



		/// <summary>
		/// Number of available outbound lines in Campaign&#39;s Edge Group or Site
		/// </summary>
		/// <value>Number of available outbound lines in Campaign&#39;s Edge Group or Site</value>
		[DataMember(Name = "availableOutboundLines", EmitDefaultValue = false)]
		public int? AvailableOutboundLines { get; set; }



		/// <summary>
		/// Number of reserved outbound lines in Campaign&#39;s Edge Group or Site
		/// </summary>
		/// <value>Number of reserved outbound lines in Campaign&#39;s Edge Group or Site</value>
		[DataMember(Name = "reservedLines", EmitDefaultValue = false)]
		public int? ReservedLines { get; set; }



		/// <summary>
		/// Information about campaigns with reserving lines in Campaign&#39;s Edge Group or Site
		/// </summary>
		/// <value>Information about campaigns with reserving lines in Campaign&#39;s Edge Group or Site</value>
		[DataMember(Name = "campaignsWithReservedLines", EmitDefaultValue = false)]
		public List<CampaignOutboundLinesReservation> CampaignsWithReservedLines { get; set; }



		/// <summary>
		/// Information about campaigns using dynamic lines allocation in Campaign&#39;s Edge Group or Site
		/// </summary>
		/// <value>Information about campaigns using dynamic lines allocation in Campaign&#39;s Edge Group or Site</value>
		[DataMember(Name = "campaignsWithDynamicallyAllocatedLines", EmitDefaultValue = false)]
		public List<CampaignOutboundLinesAllocation> CampaignsWithDynamicallyAllocatedLines { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CampaignOutboundLinesDistribution {\n");

			sb.Append("  Campaign: ").Append(Campaign).Append("\n");
			sb.Append("  MaxOutboundLineCount: ").Append(MaxOutboundLineCount).Append("\n");
			sb.Append("  MaxLineUtilization: ").Append(MaxLineUtilization).Append("\n");
			sb.Append("  AvailableOutboundLines: ").Append(AvailableOutboundLines).Append("\n");
			sb.Append("  ReservedLines: ").Append(ReservedLines).Append("\n");
			sb.Append("  CampaignsWithReservedLines: ").Append(CampaignsWithReservedLines).Append("\n");
			sb.Append("  CampaignsWithDynamicallyAllocatedLines: ").Append(CampaignsWithDynamicallyAllocatedLines).Append("\n");
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
			return this.Equals(obj as CampaignOutboundLinesDistribution);
		}

		/// <summary>
		/// Returns true if CampaignOutboundLinesDistribution instances are equal
		/// </summary>
		/// <param name="other">Instance of CampaignOutboundLinesDistribution to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CampaignOutboundLinesDistribution other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Campaign == other.Campaign ||
					this.Campaign != null &&
					this.Campaign.Equals(other.Campaign)
				) &&
				(
					this.MaxOutboundLineCount == other.MaxOutboundLineCount ||
					this.MaxOutboundLineCount != null &&
					this.MaxOutboundLineCount.Equals(other.MaxOutboundLineCount)
				) &&
				(
					this.MaxLineUtilization == other.MaxLineUtilization ||
					this.MaxLineUtilization != null &&
					this.MaxLineUtilization.Equals(other.MaxLineUtilization)
				) &&
				(
					this.AvailableOutboundLines == other.AvailableOutboundLines ||
					this.AvailableOutboundLines != null &&
					this.AvailableOutboundLines.Equals(other.AvailableOutboundLines)
				) &&
				(
					this.ReservedLines == other.ReservedLines ||
					this.ReservedLines != null &&
					this.ReservedLines.Equals(other.ReservedLines)
				) &&
				(
					this.CampaignsWithReservedLines == other.CampaignsWithReservedLines ||
					this.CampaignsWithReservedLines != null &&
					this.CampaignsWithReservedLines.SequenceEqual(other.CampaignsWithReservedLines)
				) &&
				(
					this.CampaignsWithDynamicallyAllocatedLines == other.CampaignsWithDynamicallyAllocatedLines ||
					this.CampaignsWithDynamicallyAllocatedLines != null &&
					this.CampaignsWithDynamicallyAllocatedLines.SequenceEqual(other.CampaignsWithDynamicallyAllocatedLines)
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
				if (this.Campaign != null)
					hash = hash * 59 + this.Campaign.GetHashCode();

				if (this.MaxOutboundLineCount != null)
					hash = hash * 59 + this.MaxOutboundLineCount.GetHashCode();

				if (this.MaxLineUtilization != null)
					hash = hash * 59 + this.MaxLineUtilization.GetHashCode();

				if (this.AvailableOutboundLines != null)
					hash = hash * 59 + this.AvailableOutboundLines.GetHashCode();

				if (this.ReservedLines != null)
					hash = hash * 59 + this.ReservedLines.GetHashCode();

				if (this.CampaignsWithReservedLines != null)
					hash = hash * 59 + this.CampaignsWithReservedLines.GetHashCode();

				if (this.CampaignsWithDynamicallyAllocatedLines != null)
					hash = hash * 59 + this.CampaignsWithDynamicallyAllocatedLines.GetHashCode();

				return hash;
			}
		}
	}

}
