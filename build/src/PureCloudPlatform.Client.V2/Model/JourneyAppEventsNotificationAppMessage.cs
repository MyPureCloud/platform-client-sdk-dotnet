using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// JourneyAppEventsNotificationAppMessage
	/// </summary>
	[DataContract]
	public partial class JourneyAppEventsNotificationAppMessage : IEquatable<JourneyAppEventsNotificationAppMessage>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="JourneyAppEventsNotificationAppMessage" /> class.
		/// </summary>
		/// <param name="EventName">EventName.</param>
		/// <param name="ScreenName">ScreenName.</param>
		/// <param name="App">App.</param>
		/// <param name="Device">Device.</param>
		/// <param name="IpAddress">IpAddress.</param>
		/// <param name="IpOrganization">IpOrganization.</param>
		/// <param name="Geolocation">Geolocation.</param>
		/// <param name="SdkLibrary">SdkLibrary.</param>
		/// <param name="NetworkConnectivity">NetworkConnectivity.</param>
		/// <param name="MktCampaign">MktCampaign.</param>
		/// <param name="SearchQuery">SearchQuery.</param>
		/// <param name="Attributes">Attributes.</param>
		/// <param name="Traits">Traits.</param>
		public JourneyAppEventsNotificationAppMessage(string EventName = null, string ScreenName = null, JourneyAppEventsNotificationApp App = null, JourneyAppEventsNotificationDevice Device = null, string IpAddress = null, string IpOrganization = null, JourneyAppEventsNotificationGeoLocation Geolocation = null, JourneyAppEventsNotificationSdkLibrary SdkLibrary = null, JourneyAppEventsNotificationNetworkConnectivity NetworkConnectivity = null, JourneyAppEventsNotificationMktCampaign MktCampaign = null, string SearchQuery = null, Dictionary<string, JourneyAppEventsNotificationCustomEventAttribute> Attributes = null, Dictionary<string, JourneyAppEventsNotificationCustomEventAttribute> Traits = null)
		{
			this.EventName = EventName;
			this.ScreenName = ScreenName;
			this.App = App;
			this.Device = Device;
			this.IpAddress = IpAddress;
			this.IpOrganization = IpOrganization;
			this.Geolocation = Geolocation;
			this.SdkLibrary = SdkLibrary;
			this.NetworkConnectivity = NetworkConnectivity;
			this.MktCampaign = MktCampaign;
			this.SearchQuery = SearchQuery;
			this.Attributes = Attributes;
			this.Traits = Traits;

		}



		/// <summary>
		/// Gets or Sets EventName
		/// </summary>
		[DataMember(Name = "eventName", EmitDefaultValue = false)]
		public string EventName { get; set; }



		/// <summary>
		/// Gets or Sets ScreenName
		/// </summary>
		[DataMember(Name = "screenName", EmitDefaultValue = false)]
		public string ScreenName { get; set; }



		/// <summary>
		/// Gets or Sets App
		/// </summary>
		[DataMember(Name = "app", EmitDefaultValue = false)]
		public JourneyAppEventsNotificationApp App { get; set; }



		/// <summary>
		/// Gets or Sets Device
		/// </summary>
		[DataMember(Name = "device", EmitDefaultValue = false)]
		public JourneyAppEventsNotificationDevice Device { get; set; }



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
		/// Gets or Sets Geolocation
		/// </summary>
		[DataMember(Name = "geolocation", EmitDefaultValue = false)]
		public JourneyAppEventsNotificationGeoLocation Geolocation { get; set; }



		/// <summary>
		/// Gets or Sets SdkLibrary
		/// </summary>
		[DataMember(Name = "sdkLibrary", EmitDefaultValue = false)]
		public JourneyAppEventsNotificationSdkLibrary SdkLibrary { get; set; }



		/// <summary>
		/// Gets or Sets NetworkConnectivity
		/// </summary>
		[DataMember(Name = "networkConnectivity", EmitDefaultValue = false)]
		public JourneyAppEventsNotificationNetworkConnectivity NetworkConnectivity { get; set; }



		/// <summary>
		/// Gets or Sets MktCampaign
		/// </summary>
		[DataMember(Name = "mktCampaign", EmitDefaultValue = false)]
		public JourneyAppEventsNotificationMktCampaign MktCampaign { get; set; }



		/// <summary>
		/// Gets or Sets SearchQuery
		/// </summary>
		[DataMember(Name = "searchQuery", EmitDefaultValue = false)]
		public string SearchQuery { get; set; }



		/// <summary>
		/// Gets or Sets Attributes
		/// </summary>
		[DataMember(Name = "attributes", EmitDefaultValue = false)]
		public Dictionary<string, JourneyAppEventsNotificationCustomEventAttribute> Attributes { get; set; }



		/// <summary>
		/// Gets or Sets Traits
		/// </summary>
		[DataMember(Name = "traits", EmitDefaultValue = false)]
		public Dictionary<string, JourneyAppEventsNotificationCustomEventAttribute> Traits { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JourneyAppEventsNotificationAppMessage {\n");

			sb.Append("  EventName: ").Append(EventName).Append("\n");
			sb.Append("  ScreenName: ").Append(ScreenName).Append("\n");
			sb.Append("  App: ").Append(App).Append("\n");
			sb.Append("  Device: ").Append(Device).Append("\n");
			sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
			sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
			sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
			sb.Append("  SdkLibrary: ").Append(SdkLibrary).Append("\n");
			sb.Append("  NetworkConnectivity: ").Append(NetworkConnectivity).Append("\n");
			sb.Append("  MktCampaign: ").Append(MktCampaign).Append("\n");
			sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
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
			return this.Equals(obj as JourneyAppEventsNotificationAppMessage);
		}

		/// <summary>
		/// Returns true if JourneyAppEventsNotificationAppMessage instances are equal
		/// </summary>
		/// <param name="other">Instance of JourneyAppEventsNotificationAppMessage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JourneyAppEventsNotificationAppMessage other)
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
					this.ScreenName == other.ScreenName ||
					this.ScreenName != null &&
					this.ScreenName.Equals(other.ScreenName)
				) &&
				(
					this.App == other.App ||
					this.App != null &&
					this.App.Equals(other.App)
				) &&
				(
					this.Device == other.Device ||
					this.Device != null &&
					this.Device.Equals(other.Device)
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
					this.Geolocation == other.Geolocation ||
					this.Geolocation != null &&
					this.Geolocation.Equals(other.Geolocation)
				) &&
				(
					this.SdkLibrary == other.SdkLibrary ||
					this.SdkLibrary != null &&
					this.SdkLibrary.Equals(other.SdkLibrary)
				) &&
				(
					this.NetworkConnectivity == other.NetworkConnectivity ||
					this.NetworkConnectivity != null &&
					this.NetworkConnectivity.Equals(other.NetworkConnectivity)
				) &&
				(
					this.MktCampaign == other.MktCampaign ||
					this.MktCampaign != null &&
					this.MktCampaign.Equals(other.MktCampaign)
				) &&
				(
					this.SearchQuery == other.SearchQuery ||
					this.SearchQuery != null &&
					this.SearchQuery.Equals(other.SearchQuery)
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

				if (this.ScreenName != null)
					hash = hash * 59 + this.ScreenName.GetHashCode();

				if (this.App != null)
					hash = hash * 59 + this.App.GetHashCode();

				if (this.Device != null)
					hash = hash * 59 + this.Device.GetHashCode();

				if (this.IpAddress != null)
					hash = hash * 59 + this.IpAddress.GetHashCode();

				if (this.IpOrganization != null)
					hash = hash * 59 + this.IpOrganization.GetHashCode();

				if (this.Geolocation != null)
					hash = hash * 59 + this.Geolocation.GetHashCode();

				if (this.SdkLibrary != null)
					hash = hash * 59 + this.SdkLibrary.GetHashCode();

				if (this.NetworkConnectivity != null)
					hash = hash * 59 + this.NetworkConnectivity.GetHashCode();

				if (this.MktCampaign != null)
					hash = hash * 59 + this.MktCampaign.GetHashCode();

				if (this.SearchQuery != null)
					hash = hash * 59 + this.SearchQuery.GetHashCode();

				if (this.Attributes != null)
					hash = hash * 59 + this.Attributes.GetHashCode();

				if (this.Traits != null)
					hash = hash * 59 + this.Traits.GetHashCode();

				return hash;
			}
		}
	}

}
