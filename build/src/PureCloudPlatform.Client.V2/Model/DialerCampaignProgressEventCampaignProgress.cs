using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DialerCampaignProgressEventCampaignProgress
	/// </summary>
	[DataContract]
	public partial class DialerCampaignProgressEventCampaignProgress : IEquatable<DialerCampaignProgressEventCampaignProgress>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DialerCampaignProgressEventCampaignProgress" /> class.
		/// </summary>
		/// <param name="Campaign">Campaign.</param>
		/// <param name="NumberOfContactsCalled">The number of contacts that have been called so far.</param>
		/// <param name="NumberOfContactsMessaged">The number of contacts that have been messaged so far.</param>
		/// <param name="TotalNumberOfContacts">The total number of contacts in the contact list.</param>
		/// <param name="Percentage">numberOfContactsContacted/totalNumberOfContacts*100.</param>
		/// <param name="NumberOfContactsSkipped">A map of skipped reasons and the number of contacts associated with each..</param>
		/// <param name="AdditionalProperties">AdditionalProperties.</param>
		/// <param name="GetAdditionalProperties">GetAdditionalProperties.</param>
		public DialerCampaignProgressEventCampaignProgress(DialerCampaignProgressEventUriReference Campaign = null, double? NumberOfContactsCalled = null, double? NumberOfContactsMessaged = null, double? TotalNumberOfContacts = null, long? Percentage = null, Dictionary<string, long?> NumberOfContactsSkipped = null, Dictionary<string, Object> AdditionalProperties = null, Dictionary<string, Object> GetAdditionalProperties = null)
		{
			this.Campaign = Campaign;
			this.NumberOfContactsCalled = NumberOfContactsCalled;
			this.NumberOfContactsMessaged = NumberOfContactsMessaged;
			this.TotalNumberOfContacts = TotalNumberOfContacts;
			this.Percentage = Percentage;
			this.NumberOfContactsSkipped = NumberOfContactsSkipped;
			this.AdditionalProperties = AdditionalProperties;
			this.GetAdditionalProperties = GetAdditionalProperties;

		}



		/// <summary>
		/// Gets or Sets Campaign
		/// </summary>
		[DataMember(Name = "campaign", EmitDefaultValue = false)]
		public DialerCampaignProgressEventUriReference Campaign { get; set; }



		/// <summary>
		/// The number of contacts that have been called so far
		/// </summary>
		/// <value>The number of contacts that have been called so far</value>
		[DataMember(Name = "numberOfContactsCalled", EmitDefaultValue = false)]
		public double? NumberOfContactsCalled { get; set; }



		/// <summary>
		/// The number of contacts that have been messaged so far
		/// </summary>
		/// <value>The number of contacts that have been messaged so far</value>
		[DataMember(Name = "numberOfContactsMessaged", EmitDefaultValue = false)]
		public double? NumberOfContactsMessaged { get; set; }



		/// <summary>
		/// The total number of contacts in the contact list
		/// </summary>
		/// <value>The total number of contacts in the contact list</value>
		[DataMember(Name = "totalNumberOfContacts", EmitDefaultValue = false)]
		public double? TotalNumberOfContacts { get; set; }



		/// <summary>
		/// numberOfContactsContacted/totalNumberOfContacts*100
		/// </summary>
		/// <value>numberOfContactsContacted/totalNumberOfContacts*100</value>
		[DataMember(Name = "percentage", EmitDefaultValue = false)]
		public long? Percentage { get; set; }



		/// <summary>
		/// A map of skipped reasons and the number of contacts associated with each.
		/// </summary>
		/// <value>A map of skipped reasons and the number of contacts associated with each.</value>
		[DataMember(Name = "numberOfContactsSkipped", EmitDefaultValue = false)]
		public Dictionary<string, long?> NumberOfContactsSkipped { get; set; }



		/// <summary>
		/// Gets or Sets AdditionalProperties
		/// </summary>
		[DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
		public Dictionary<string, Object> AdditionalProperties { get; set; }



		/// <summary>
		/// Gets or Sets GetAdditionalProperties
		/// </summary>
		[DataMember(Name = "getAdditionalProperties", EmitDefaultValue = false)]
		public Dictionary<string, Object> GetAdditionalProperties { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DialerCampaignProgressEventCampaignProgress {\n");

			sb.Append("  Campaign: ").Append(Campaign).Append("\n");
			sb.Append("  NumberOfContactsCalled: ").Append(NumberOfContactsCalled).Append("\n");
			sb.Append("  NumberOfContactsMessaged: ").Append(NumberOfContactsMessaged).Append("\n");
			sb.Append("  TotalNumberOfContacts: ").Append(TotalNumberOfContacts).Append("\n");
			sb.Append("  Percentage: ").Append(Percentage).Append("\n");
			sb.Append("  NumberOfContactsSkipped: ").Append(NumberOfContactsSkipped).Append("\n");
			sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
			sb.Append("  GetAdditionalProperties: ").Append(GetAdditionalProperties).Append("\n");
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
			return this.Equals(obj as DialerCampaignProgressEventCampaignProgress);
		}

		/// <summary>
		/// Returns true if DialerCampaignProgressEventCampaignProgress instances are equal
		/// </summary>
		/// <param name="other">Instance of DialerCampaignProgressEventCampaignProgress to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DialerCampaignProgressEventCampaignProgress other)
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
					this.NumberOfContactsCalled == other.NumberOfContactsCalled ||
					this.NumberOfContactsCalled != null &&
					this.NumberOfContactsCalled.Equals(other.NumberOfContactsCalled)
				) &&
				(
					this.NumberOfContactsMessaged == other.NumberOfContactsMessaged ||
					this.NumberOfContactsMessaged != null &&
					this.NumberOfContactsMessaged.Equals(other.NumberOfContactsMessaged)
				) &&
				(
					this.TotalNumberOfContacts == other.TotalNumberOfContacts ||
					this.TotalNumberOfContacts != null &&
					this.TotalNumberOfContacts.Equals(other.TotalNumberOfContacts)
				) &&
				(
					this.Percentage == other.Percentage ||
					this.Percentage != null &&
					this.Percentage.Equals(other.Percentage)
				) &&
				(
					this.NumberOfContactsSkipped == other.NumberOfContactsSkipped ||
					this.NumberOfContactsSkipped != null &&
					this.NumberOfContactsSkipped.SequenceEqual(other.NumberOfContactsSkipped)
				) &&
				(
					this.AdditionalProperties == other.AdditionalProperties ||
					this.AdditionalProperties != null &&
					this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
				) &&
				(
					this.GetAdditionalProperties == other.GetAdditionalProperties ||
					this.GetAdditionalProperties != null &&
					this.GetAdditionalProperties.SequenceEqual(other.GetAdditionalProperties)
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

				if (this.NumberOfContactsCalled != null)
					hash = hash * 59 + this.NumberOfContactsCalled.GetHashCode();

				if (this.NumberOfContactsMessaged != null)
					hash = hash * 59 + this.NumberOfContactsMessaged.GetHashCode();

				if (this.TotalNumberOfContacts != null)
					hash = hash * 59 + this.TotalNumberOfContacts.GetHashCode();

				if (this.Percentage != null)
					hash = hash * 59 + this.Percentage.GetHashCode();

				if (this.NumberOfContactsSkipped != null)
					hash = hash * 59 + this.NumberOfContactsSkipped.GetHashCode();

				if (this.AdditionalProperties != null)
					hash = hash * 59 + this.AdditionalProperties.GetHashCode();

				if (this.GetAdditionalProperties != null)
					hash = hash * 59 + this.GetAdditionalProperties.GetHashCode();

				return hash;
			}
		}
	}

}
