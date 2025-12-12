using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AppEvent
	/// </summary>
	[DataContract]
	public partial class AppEvent : IEquatable<AppEvent>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="AppEvent" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AppEvent() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AppEvent" /> class.
		/// </summary>
		/// <param name="EventName">Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. screen_viewed, order_completed, user_registered). (required).</param>
		/// <param name="ScreenName">The name of the screen in the app that the event took place. (required).</param>
		/// <param name="App">Application that the customer is interacting with. (required).</param>
		/// <param name="Device">Customer&#39;s device. (required).</param>
		/// <param name="IpAddress">Customer&#39;s IP address. May be null if the business configures the tracker to not collect IP addresses..</param>
		/// <param name="IpOrganization">Customer&#39;s IP-based organization or ISP name..</param>
		/// <param name="Geolocation">Customer&#39;s geolocation..</param>
		/// <param name="SdkLibrary">SDK library used to generate the event..</param>
		/// <param name="NetworkConnectivity">Information relating to the device&#39;s network connectivity..</param>
		/// <param name="MktCampaign">Marketing / traffic source information..</param>
		/// <param name="SearchQuery">Represents the keywords in a customer search query..</param>
		/// <param name="Attributes">User-defined attributes associated with a particular event. (required).</param>
		/// <param name="Traits">Traits are attributes intrinsic to the customer that may be sent in selected events. Examples are email, givenName, cellPhone. (required).</param>
		public AppEvent(string EventName = null, string ScreenName = null, JourneyApp App = null, Device Device = null, string IpAddress = null, string IpOrganization = null, JourneyGeolocation Geolocation = null, SdkLibrary SdkLibrary = null, NetworkConnectivity NetworkConnectivity = null, JourneyCampaign MktCampaign = null, string SearchQuery = null, Dictionary<string, CustomEventAttribute> Attributes = null, Dictionary<string, CustomEventAttribute> Traits = null)
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
		/// Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. screen_viewed, order_completed, user_registered).
		/// </summary>
		/// <value>Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. screen_viewed, order_completed, user_registered).</value>
		[DataMember(Name = "eventName", EmitDefaultValue = false)]
		public string EventName { get; set; }



		/// <summary>
		/// The name of the screen in the app that the event took place.
		/// </summary>
		/// <value>The name of the screen in the app that the event took place.</value>
		[DataMember(Name = "screenName", EmitDefaultValue = false)]
		public string ScreenName { get; set; }



		/// <summary>
		/// Application that the customer is interacting with.
		/// </summary>
		/// <value>Application that the customer is interacting with.</value>
		[DataMember(Name = "app", EmitDefaultValue = false)]
		public JourneyApp App { get; set; }



		/// <summary>
		/// Customer&#39;s device.
		/// </summary>
		/// <value>Customer&#39;s device.</value>
		[DataMember(Name = "device", EmitDefaultValue = false)]
		public Device Device { get; set; }



		/// <summary>
		/// Customer&#39;s IP address. May be null if the business configures the tracker to not collect IP addresses.
		/// </summary>
		/// <value>Customer&#39;s IP address. May be null if the business configures the tracker to not collect IP addresses.</value>
		[DataMember(Name = "ipAddress", EmitDefaultValue = false)]
		public string IpAddress { get; set; }



		/// <summary>
		/// Customer&#39;s IP-based organization or ISP name.
		/// </summary>
		/// <value>Customer&#39;s IP-based organization or ISP name.</value>
		[DataMember(Name = "ipOrganization", EmitDefaultValue = false)]
		public string IpOrganization { get; set; }



		/// <summary>
		/// Customer&#39;s geolocation.
		/// </summary>
		/// <value>Customer&#39;s geolocation.</value>
		[DataMember(Name = "geolocation", EmitDefaultValue = false)]
		public JourneyGeolocation Geolocation { get; set; }



		/// <summary>
		/// SDK library used to generate the event.
		/// </summary>
		/// <value>SDK library used to generate the event.</value>
		[DataMember(Name = "sdkLibrary", EmitDefaultValue = false)]
		public SdkLibrary SdkLibrary { get; set; }



		/// <summary>
		/// Information relating to the device&#39;s network connectivity.
		/// </summary>
		/// <value>Information relating to the device&#39;s network connectivity.</value>
		[DataMember(Name = "networkConnectivity", EmitDefaultValue = false)]
		public NetworkConnectivity NetworkConnectivity { get; set; }



		/// <summary>
		/// Marketing / traffic source information.
		/// </summary>
		/// <value>Marketing / traffic source information.</value>
		[DataMember(Name = "mktCampaign", EmitDefaultValue = false)]
		public JourneyCampaign MktCampaign { get; set; }



		/// <summary>
		/// Represents the keywords in a customer search query.
		/// </summary>
		/// <value>Represents the keywords in a customer search query.</value>
		[DataMember(Name = "searchQuery", EmitDefaultValue = false)]
		public string SearchQuery { get; set; }



		/// <summary>
		/// User-defined attributes associated with a particular event.
		/// </summary>
		/// <value>User-defined attributes associated with a particular event.</value>
		[DataMember(Name = "attributes", EmitDefaultValue = false)]
		public Dictionary<string, CustomEventAttribute> Attributes { get; set; }



		/// <summary>
		/// Traits are attributes intrinsic to the customer that may be sent in selected events. Examples are email, givenName, cellPhone.
		/// </summary>
		/// <value>Traits are attributes intrinsic to the customer that may be sent in selected events. Examples are email, givenName, cellPhone.</value>
		[DataMember(Name = "traits", EmitDefaultValue = false)]
		public Dictionary<string, CustomEventAttribute> Traits { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AppEvent {\n");

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
			return this.Equals(obj as AppEvent);
		}

		/// <summary>
		/// Returns true if AppEvent instances are equal
		/// </summary>
		/// <param name="other">Instance of AppEvent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AppEvent other)
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
