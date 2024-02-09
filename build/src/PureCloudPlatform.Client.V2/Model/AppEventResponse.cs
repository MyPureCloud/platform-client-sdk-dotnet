using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// AppEventResponse
    /// </summary>
    [DataContract]
    public partial class AppEventResponse :  IEquatable<AppEventResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppEventResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventResponse" /> class.
        /// </summary>
        /// <param name="Id">System-generated UUID for the event. (required).</param>
        /// <param name="CustomerId">Identifier of the customer in the source of the event. (required).</param>
        /// <param name="CustomerIdType">Type of identifier for the customer ID (cookie, email etc.). (required).</param>
        /// <param name="EventName">Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. screen_viewed, order_completed, user_registered). (required).</param>
        /// <param name="ScreenName">The name of the screen in the app that the event took place. (required).</param>
        /// <param name="App">Application that the customer is interacting with. (required).</param>
        /// <param name="Device">Customer's device. (required).</param>
        /// <param name="IpOrganization">Customer's IP-based organization or ISP name..</param>
        /// <param name="Geolocation">Customer's geolocation..</param>
        /// <param name="SdkLibrary">SDK library used to generate the event..</param>
        /// <param name="NetworkConnectivity">Information relating to the device's network connectivity..</param>
        /// <param name="MktCampaign">Marketing / traffic source information..</param>
        /// <param name="Session">The app session the event belongs to. (required).</param>
        /// <param name="SearchQuery">Represents the keywords in a customer search query..</param>
        /// <param name="Attributes">User-defined attributes associated with a particular event. (required).</param>
        /// <param name="Traits">Traits are attributes intrinsic to the customer that may be sent in selected events (e.g. email, name, phone). (required).</param>
        /// <param name="CreatedDate">UTC timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        public AppEventResponse(string Id = null, string CustomerId = null, string CustomerIdType = null, string EventName = null, string ScreenName = null, JourneyApp App = null, Device Device = null, string IpOrganization = null, JourneyGeolocation Geolocation = null, SdkLibrary SdkLibrary = null, NetworkConnectivity NetworkConnectivity = null, JourneyCampaign MktCampaign = null, AppEventResponseSession Session = null, string SearchQuery = null, Dictionary<string, CustomEventAttribute> Attributes = null, Dictionary<string, CustomEventAttribute> Traits = null, DateTime? CreatedDate = null)
        {
            this.Id = Id;
            this.CustomerId = CustomerId;
            this.CustomerIdType = CustomerIdType;
            this.EventName = EventName;
            this.ScreenName = ScreenName;
            this.App = App;
            this.Device = Device;
            this.IpOrganization = IpOrganization;
            this.Geolocation = Geolocation;
            this.SdkLibrary = SdkLibrary;
            this.NetworkConnectivity = NetworkConnectivity;
            this.MktCampaign = MktCampaign;
            this.Session = Session;
            this.SearchQuery = SearchQuery;
            this.Attributes = Attributes;
            this.Traits = Traits;
            this.CreatedDate = CreatedDate;
            
        }
        


        /// <summary>
        /// System-generated UUID for the event.
        /// </summary>
        /// <value>System-generated UUID for the event.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Identifier of the customer in the source of the event.
        /// </summary>
        /// <value>Identifier of the customer in the source of the event.</value>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; set; }



        /// <summary>
        /// Type of identifier for the customer ID (cookie, email etc.).
        /// </summary>
        /// <value>Type of identifier for the customer ID (cookie, email etc.).</value>
        [DataMember(Name="customerIdType", EmitDefaultValue=false)]
        public string CustomerIdType { get; set; }



        /// <summary>
        /// Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. screen_viewed, order_completed, user_registered).
        /// </summary>
        /// <value>Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. screen_viewed, order_completed, user_registered).</value>
        [DataMember(Name="eventName", EmitDefaultValue=false)]
        public string EventName { get; set; }



        /// <summary>
        /// The name of the screen in the app that the event took place.
        /// </summary>
        /// <value>The name of the screen in the app that the event took place.</value>
        [DataMember(Name="screenName", EmitDefaultValue=false)]
        public string ScreenName { get; set; }



        /// <summary>
        /// Application that the customer is interacting with.
        /// </summary>
        /// <value>Application that the customer is interacting with.</value>
        [DataMember(Name="app", EmitDefaultValue=false)]
        public JourneyApp App { get; set; }



        /// <summary>
        /// Customer's device.
        /// </summary>
        /// <value>Customer's device.</value>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public Device Device { get; set; }



        /// <summary>
        /// Customer's IP-based organization or ISP name.
        /// </summary>
        /// <value>Customer's IP-based organization or ISP name.</value>
        [DataMember(Name="ipOrganization", EmitDefaultValue=false)]
        public string IpOrganization { get; set; }



        /// <summary>
        /// Customer's geolocation.
        /// </summary>
        /// <value>Customer's geolocation.</value>
        [DataMember(Name="geolocation", EmitDefaultValue=false)]
        public JourneyGeolocation Geolocation { get; set; }



        /// <summary>
        /// SDK library used to generate the event.
        /// </summary>
        /// <value>SDK library used to generate the event.</value>
        [DataMember(Name="sdkLibrary", EmitDefaultValue=false)]
        public SdkLibrary SdkLibrary { get; set; }



        /// <summary>
        /// Information relating to the device's network connectivity.
        /// </summary>
        /// <value>Information relating to the device's network connectivity.</value>
        [DataMember(Name="networkConnectivity", EmitDefaultValue=false)]
        public NetworkConnectivity NetworkConnectivity { get; set; }



        /// <summary>
        /// Marketing / traffic source information.
        /// </summary>
        /// <value>Marketing / traffic source information.</value>
        [DataMember(Name="mktCampaign", EmitDefaultValue=false)]
        public JourneyCampaign MktCampaign { get; set; }



        /// <summary>
        /// The app session the event belongs to.
        /// </summary>
        /// <value>The app session the event belongs to.</value>
        [DataMember(Name="session", EmitDefaultValue=false)]
        public AppEventResponseSession Session { get; set; }



        /// <summary>
        /// Represents the keywords in a customer search query.
        /// </summary>
        /// <value>Represents the keywords in a customer search query.</value>
        [DataMember(Name="searchQuery", EmitDefaultValue=false)]
        public string SearchQuery { get; set; }



        /// <summary>
        /// User-defined attributes associated with a particular event.
        /// </summary>
        /// <value>User-defined attributes associated with a particular event.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, CustomEventAttribute> Attributes { get; set; }



        /// <summary>
        /// Traits are attributes intrinsic to the customer that may be sent in selected events (e.g. email, name, phone).
        /// </summary>
        /// <value>Traits are attributes intrinsic to the customer that may be sent in selected events (e.g. email, name, phone).</value>
        [DataMember(Name="traits", EmitDefaultValue=false)]
        public Dictionary<string, CustomEventAttribute> Traits { get; set; }



        /// <summary>
        /// UTC timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>UTC timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppEventResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  CustomerIdType: ").Append(CustomerIdType).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  ScreenName: ").Append(ScreenName).Append("\n");
            sb.Append("  App: ").Append(App).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
            sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
            sb.Append("  SdkLibrary: ").Append(SdkLibrary).Append("\n");
            sb.Append("  NetworkConnectivity: ").Append(NetworkConnectivity).Append("\n");
            sb.Append("  MktCampaign: ").Append(MktCampaign).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Traits: ").Append(Traits).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
            return this.Equals(obj as AppEventResponse);
        }

        /// <summary>
        /// Returns true if AppEventResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AppEventResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppEventResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) &&
                (
                    this.CustomerIdType == other.CustomerIdType ||
                    this.CustomerIdType != null &&
                    this.CustomerIdType.Equals(other.CustomerIdType)
                ) &&
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
                    this.Session == other.Session ||
                    this.Session != null &&
                    this.Session.Equals(other.Session)
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
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();

                if (this.CustomerIdType != null)
                    hash = hash * 59 + this.CustomerIdType.GetHashCode();

                if (this.EventName != null)
                    hash = hash * 59 + this.EventName.GetHashCode();

                if (this.ScreenName != null)
                    hash = hash * 59 + this.ScreenName.GetHashCode();

                if (this.App != null)
                    hash = hash * 59 + this.App.GetHashCode();

                if (this.Device != null)
                    hash = hash * 59 + this.Device.GetHashCode();

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

                if (this.Session != null)
                    hash = hash * 59 + this.Session.GetHashCode();

                if (this.SearchQuery != null)
                    hash = hash * 59 + this.SearchQuery.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                if (this.Traits != null)
                    hash = hash * 59 + this.Traits.GetHashCode();

                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();

                return hash;
            }
        }
    }

}
