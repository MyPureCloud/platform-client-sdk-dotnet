using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// JourneyWebEventsNotificationWebMessage
	/// </summary>
	[DataContract]
	public partial class JourneyWebEventsNotificationWebMessage : IEquatable<JourneyWebEventsNotificationWebMessage>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="JourneyWebEventsNotificationWebMessage" /> class.
		/// </summary>
		/// <param name="EventName">EventName.</param>
		/// <param name="TotalEventCount">TotalEventCount.</param>
		/// <param name="TotalPageviewCount">TotalPageviewCount.</param>
		/// <param name="UserAgentString">UserAgentString.</param>
		/// <param name="IpAddress">IpAddress.</param>
		/// <param name="IpOrganization">IpOrganization.</param>
		/// <param name="SearchQuery">SearchQuery.</param>
		/// <param name="Authenticated">Authenticated.</param>
		/// <param name="Browser">Browser.</param>
		/// <param name="Device">Device.</param>
		/// <param name="Geolocation">Geolocation.</param>
		/// <param name="MktCampaign">MktCampaign.</param>
		/// <param name="Page">Page.</param>
		/// <param name="Referrer">Referrer.</param>
		/// <param name="Attributes">Attributes.</param>
		/// <param name="Traits">Traits.</param>
		public JourneyWebEventsNotificationWebMessage(string EventName = null, long? TotalEventCount = null, long? TotalPageviewCount = null, string UserAgentString = null, string IpAddress = null, string IpOrganization = null, string SearchQuery = null, bool? Authenticated = null, JourneyWebEventsNotificationBrowser Browser = null, JourneyWebEventsNotificationDevice Device = null, JourneyWebEventsNotificationGeoLocation Geolocation = null, JourneyWebEventsNotificationMktCampaign MktCampaign = null, JourneyWebEventsNotificationPage Page = null, JourneyWebEventsNotificationReferrer Referrer = null, Dictionary<string, JourneyWebEventsNotificationCustomEventAttribute> Attributes = null, Dictionary<string, JourneyWebEventsNotificationCustomEventAttribute> Traits = null)
		{
			this.EventName = EventName;
			this.TotalEventCount = TotalEventCount;
			this.TotalPageviewCount = TotalPageviewCount;
			this.UserAgentString = UserAgentString;
			this.IpAddress = IpAddress;
			this.IpOrganization = IpOrganization;
			this.SearchQuery = SearchQuery;
			this.Authenticated = Authenticated;
			this.Browser = Browser;
			this.Device = Device;
			this.Geolocation = Geolocation;
			this.MktCampaign = MktCampaign;
			this.Page = Page;
			this.Referrer = Referrer;
			this.Attributes = Attributes;
			this.Traits = Traits;

		}



		/// <summary>
		/// Gets or Sets EventName
		/// </summary>
		[DataMember(Name = "eventName", EmitDefaultValue = false)]
		public string EventName { get; set; }



		/// <summary>
		/// Gets or Sets TotalEventCount
		/// </summary>
		[DataMember(Name = "totalEventCount", EmitDefaultValue = false)]
		public long? TotalEventCount { get; set; }



		/// <summary>
		/// Gets or Sets TotalPageviewCount
		/// </summary>
		[DataMember(Name = "totalPageviewCount", EmitDefaultValue = false)]
		public long? TotalPageviewCount { get; set; }



		/// <summary>
		/// Gets or Sets UserAgentString
		/// </summary>
		[DataMember(Name = "userAgentString", EmitDefaultValue = false)]
		public string UserAgentString { get; set; }



		/// <summary>
		/// Gets or Sets IpAddress
		/// </summary>
		[DataMember(Name = "ipAddress", EmitDefaultValue = false)]
		public string IpAddress { get; set; }



		/// <summary>
		/// Gets or Sets IpOrganization
		/// </summary>
		[DataMember(Name = "ipOrganization", EmitDefaultValue = false)]
		public string IpOrganization { get; set; }



		/// <summary>
		/// Gets or Sets SearchQuery
		/// </summary>
		[DataMember(Name = "searchQuery", EmitDefaultValue = false)]
		public string SearchQuery { get; set; }



		/// <summary>
		/// Gets or Sets Authenticated
		/// </summary>
		[DataMember(Name = "authenticated", EmitDefaultValue = false)]
		public bool? Authenticated { get; set; }



		/// <summary>
		/// Gets or Sets Browser
		/// </summary>
		[DataMember(Name = "browser", EmitDefaultValue = false)]
		public JourneyWebEventsNotificationBrowser Browser { get; set; }



		/// <summary>
		/// Gets or Sets Device
		/// </summary>
		[DataMember(Name = "device", EmitDefaultValue = false)]
		public JourneyWebEventsNotificationDevice Device { get; set; }



		/// <summary>
		/// Gets or Sets Geolocation
		/// </summary>
		[DataMember(Name = "geolocation", EmitDefaultValue = false)]
		public JourneyWebEventsNotificationGeoLocation Geolocation { get; set; }



		/// <summary>
		/// Gets or Sets MktCampaign
		/// </summary>
		[DataMember(Name = "mktCampaign", EmitDefaultValue = false)]
		public JourneyWebEventsNotificationMktCampaign MktCampaign { get; set; }



		/// <summary>
		/// Gets or Sets Page
		/// </summary>
		[DataMember(Name = "page", EmitDefaultValue = false)]
		public JourneyWebEventsNotificationPage Page { get; set; }



		/// <summary>
		/// Gets or Sets Referrer
		/// </summary>
		[DataMember(Name = "referrer", EmitDefaultValue = false)]
		public JourneyWebEventsNotificationReferrer Referrer { get; set; }



		/// <summary>
		/// Gets or Sets Attributes
		/// </summary>
		[DataMember(Name = "attributes", EmitDefaultValue = false)]
		public Dictionary<string, JourneyWebEventsNotificationCustomEventAttribute> Attributes { get; set; }



		/// <summary>
		/// Gets or Sets Traits
		/// </summary>
		[DataMember(Name = "traits", EmitDefaultValue = false)]
		public Dictionary<string, JourneyWebEventsNotificationCustomEventAttribute> Traits { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JourneyWebEventsNotificationWebMessage {\n");

			sb.Append("  EventName: ").Append(EventName).Append("\n");
			sb.Append("  TotalEventCount: ").Append(TotalEventCount).Append("\n");
			sb.Append("  TotalPageviewCount: ").Append(TotalPageviewCount).Append("\n");
			sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
			sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
			sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
			sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
			sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
			sb.Append("  Browser: ").Append(Browser).Append("\n");
			sb.Append("  Device: ").Append(Device).Append("\n");
			sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
			sb.Append("  MktCampaign: ").Append(MktCampaign).Append("\n");
			sb.Append("  Page: ").Append(Page).Append("\n");
			sb.Append("  Referrer: ").Append(Referrer).Append("\n");
			sb.Append("  Attributes: ").Append(Attributes).Append("\n");
			sb.Append("  Traits: ").Append(Traits).Append("\n");
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
			return this.Equals(obj as JourneyWebEventsNotificationWebMessage);
		}

		/// <summary>
		/// Returns true if JourneyWebEventsNotificationWebMessage instances are equal
		/// </summary>
		/// <param name="other">Instance of JourneyWebEventsNotificationWebMessage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JourneyWebEventsNotificationWebMessage other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.EventName == other.EventName ||
					this.EventName != null &&
					this.EventName.Equals(other.EventName)
				) &&
				(
					this.TotalEventCount == other.TotalEventCount ||
					this.TotalEventCount != null &&
					this.TotalEventCount.Equals(other.TotalEventCount)
				) &&
				(
					this.TotalPageviewCount == other.TotalPageviewCount ||
					this.TotalPageviewCount != null &&
					this.TotalPageviewCount.Equals(other.TotalPageviewCount)
				) &&
				(
					this.UserAgentString == other.UserAgentString ||
					this.UserAgentString != null &&
					this.UserAgentString.Equals(other.UserAgentString)
				) &&
				(
					this.IpAddress == other.IpAddress ||
					this.IpAddress != null &&
					this.IpAddress.Equals(other.IpAddress)
				) &&
				(
					this.IpOrganization == other.IpOrganization ||
					this.IpOrganization != null &&
					this.IpOrganization.Equals(other.IpOrganization)
				) &&
				(
					this.SearchQuery == other.SearchQuery ||
					this.SearchQuery != null &&
					this.SearchQuery.Equals(other.SearchQuery)
				) &&
				(
					this.Authenticated == other.Authenticated ||
					this.Authenticated != null &&
					this.Authenticated.Equals(other.Authenticated)
				) &&
				(
					this.Browser == other.Browser ||
					this.Browser != null &&
					this.Browser.Equals(other.Browser)
				) &&
				(
					this.Device == other.Device ||
					this.Device != null &&
					this.Device.Equals(other.Device)
				) &&
				(
					this.Geolocation == other.Geolocation ||
					this.Geolocation != null &&
					this.Geolocation.Equals(other.Geolocation)
				) &&
				(
					this.MktCampaign == other.MktCampaign ||
					this.MktCampaign != null &&
					this.MktCampaign.Equals(other.MktCampaign)
				) &&
				(
					this.Page == other.Page ||
					this.Page != null &&
					this.Page.Equals(other.Page)
				) &&
				(
					this.Referrer == other.Referrer ||
					this.Referrer != null &&
					this.Referrer.Equals(other.Referrer)
				) &&
				(
					this.Attributes == other.Attributes ||
					this.Attributes != null &&
					this.Attributes.SequenceEqual(other.Attributes)
				) &&
				(
					this.Traits == other.Traits ||
					this.Traits != null &&
					this.Traits.SequenceEqual(other.Traits)
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
				if (this.EventName != null)
					hash = hash * 59 + this.EventName.GetHashCode();

				if (this.TotalEventCount != null)
					hash = hash * 59 + this.TotalEventCount.GetHashCode();

				if (this.TotalPageviewCount != null)
					hash = hash * 59 + this.TotalPageviewCount.GetHashCode();

				if (this.UserAgentString != null)
					hash = hash * 59 + this.UserAgentString.GetHashCode();

				if (this.IpAddress != null)
					hash = hash * 59 + this.IpAddress.GetHashCode();

				if (this.IpOrganization != null)
					hash = hash * 59 + this.IpOrganization.GetHashCode();

				if (this.SearchQuery != null)
					hash = hash * 59 + this.SearchQuery.GetHashCode();

				if (this.Authenticated != null)
					hash = hash * 59 + this.Authenticated.GetHashCode();

				if (this.Browser != null)
					hash = hash * 59 + this.Browser.GetHashCode();

				if (this.Device != null)
					hash = hash * 59 + this.Device.GetHashCode();

				if (this.Geolocation != null)
					hash = hash * 59 + this.Geolocation.GetHashCode();

				if (this.MktCampaign != null)
					hash = hash * 59 + this.MktCampaign.GetHashCode();

				if (this.Page != null)
					hash = hash * 59 + this.Page.GetHashCode();

				if (this.Referrer != null)
					hash = hash * 59 + this.Referrer.GetHashCode();

				if (this.Attributes != null)
					hash = hash * 59 + this.Attributes.GetHashCode();

				if (this.Traits != null)
					hash = hash * 59 + this.Traits.GetHashCode();

				return hash;
			}
		}
	}

}
