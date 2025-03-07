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
    /// WebEventResponse
    /// </summary>
    [DataContract]
    public partial class WebEventResponse :  IEquatable<WebEventResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WebEventResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebEventResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebEventResponse" /> class.
        /// </summary>
        /// <param name="CustomerId">Identifier of the customer in the source of the event. (required).</param>
        /// <param name="EventName">Represents the action the customer performed. Event types are created for each unique event name and can be faceted on in segment and outcome conditions. A valid event name must only contain alphanumeric characters and underscores. A good event name is typically an object followed by the action performed in past tense, e.g. page_viewed, order_completed, user_registered. (required).</param>
        /// <param name="CustomerIdType">Type of identifier for the customer ID (e.g., cookie). (required).</param>
        /// <param name="Page">The webpage where the user interaction occurred. (required).</param>
        /// <param name="UserAgentString">HTTP User-Agent string (see https://tools.ietf.org/html/rfc1945#section-10.15). (required).</param>
        /// <param name="Browser">Customer&#39;s browser. (required).</param>
        /// <param name="Device">Customer&#39;s device. (required).</param>
        /// <param name="SearchQuery">Represents the keywords in a customer search query..</param>
        /// <param name="IpOrganization">Customer&#39;s IP-based organization or ISP name..</param>
        /// <param name="Geolocation">Customer&#39;s geolocation..</param>
        /// <param name="MktCampaign">Urchin Tracking Module (UTM) parameters used to track the effectiveness of online marketing campaigns..</param>
        /// <param name="Session">The session that the event belongs to. (required).</param>
        /// <param name="Referrer">Identifies the web page that originally generated the request for the current page being viewed..</param>
        /// <param name="Attributes">User-defined attributes associated with a particular event. These attributes provide additional context about the event. For example, items_in_cart or subscription_level. (required).</param>
        /// <param name="Traits">Traits are attributes intrinsic to the customer that may be sent in selected events, (e.g. email, lastName, cellPhone). Traits are used to collect information for identity resolution. For example, the same person might be using an application on different devices which might create two sessions with different customerIds. Additional information can be provided as traits to help link those two sessions and customers to a single external contact through common identifiers that were submitted via a form fill, message, or other input in both sessions. (required).</param>
        /// <param name="Authenticated">Indicates whether the event was produced during an authenticated session. (required).</param>
        /// <param name="CreatedDate">UTC timestamp indicating when the event actually took place, events older than an hour will be rejected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        public WebEventResponse(string CustomerId = null, string EventName = null, string CustomerIdType = null, ResponsePage Page = null, string UserAgentString = null, WebEventBrowser Browser = null, WebEventDevice Device = null, string SearchQuery = null, string IpOrganization = null, JourneyGeolocation Geolocation = null, JourneyCampaign MktCampaign = null, WebEventResponseSession Session = null, Referrer Referrer = null, Dictionary<string, CustomEventAttribute> Attributes = null, Dictionary<string, CustomEventAttribute> Traits = null, bool? Authenticated = null, DateTime? CreatedDate = null)
        {
            this.CustomerId = CustomerId;
            this.EventName = EventName;
            this.CustomerIdType = CustomerIdType;
            this.Page = Page;
            this.UserAgentString = UserAgentString;
            this.Browser = Browser;
            this.Device = Device;
            this.SearchQuery = SearchQuery;
            this.IpOrganization = IpOrganization;
            this.Geolocation = Geolocation;
            this.MktCampaign = MktCampaign;
            this.Session = Session;
            this.Referrer = Referrer;
            this.Attributes = Attributes;
            this.Traits = Traits;
            this.Authenticated = Authenticated;
            this.CreatedDate = CreatedDate;
            
        }
        


        /// <summary>
        /// Identifier of the customer in the source of the event.
        /// </summary>
        /// <value>Identifier of the customer in the source of the event.</value>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; set; }



        /// <summary>
        /// Represents the action the customer performed. Event types are created for each unique event name and can be faceted on in segment and outcome conditions. A valid event name must only contain alphanumeric characters and underscores. A good event name is typically an object followed by the action performed in past tense, e.g. page_viewed, order_completed, user_registered.
        /// </summary>
        /// <value>Represents the action the customer performed. Event types are created for each unique event name and can be faceted on in segment and outcome conditions. A valid event name must only contain alphanumeric characters and underscores. A good event name is typically an object followed by the action performed in past tense, e.g. page_viewed, order_completed, user_registered.</value>
        [DataMember(Name="eventName", EmitDefaultValue=false)]
        public string EventName { get; set; }



        /// <summary>
        /// Type of identifier for the customer ID (e.g., cookie).
        /// </summary>
        /// <value>Type of identifier for the customer ID (e.g., cookie).</value>
        [DataMember(Name="customerIdType", EmitDefaultValue=false)]
        public string CustomerIdType { get; set; }



        /// <summary>
        /// The webpage where the user interaction occurred.
        /// </summary>
        /// <value>The webpage where the user interaction occurred.</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public ResponsePage Page { get; set; }



        /// <summary>
        /// HTTP User-Agent string (see https://tools.ietf.org/html/rfc1945#section-10.15).
        /// </summary>
        /// <value>HTTP User-Agent string (see https://tools.ietf.org/html/rfc1945#section-10.15).</value>
        [DataMember(Name="userAgentString", EmitDefaultValue=false)]
        public string UserAgentString { get; set; }



        /// <summary>
        /// Customer&#39;s browser.
        /// </summary>
        /// <value>Customer&#39;s browser.</value>
        [DataMember(Name="browser", EmitDefaultValue=false)]
        public WebEventBrowser Browser { get; set; }



        /// <summary>
        /// Customer&#39;s device.
        /// </summary>
        /// <value>Customer&#39;s device.</value>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public WebEventDevice Device { get; set; }



        /// <summary>
        /// Represents the keywords in a customer search query.
        /// </summary>
        /// <value>Represents the keywords in a customer search query.</value>
        [DataMember(Name="searchQuery", EmitDefaultValue=false)]
        public string SearchQuery { get; set; }



        /// <summary>
        /// Customer&#39;s IP-based organization or ISP name.
        /// </summary>
        /// <value>Customer&#39;s IP-based organization or ISP name.</value>
        [DataMember(Name="ipOrganization", EmitDefaultValue=false)]
        public string IpOrganization { get; set; }



        /// <summary>
        /// Customer&#39;s geolocation.
        /// </summary>
        /// <value>Customer&#39;s geolocation.</value>
        [DataMember(Name="geolocation", EmitDefaultValue=false)]
        public JourneyGeolocation Geolocation { get; set; }



        /// <summary>
        /// Urchin Tracking Module (UTM) parameters used to track the effectiveness of online marketing campaigns.
        /// </summary>
        /// <value>Urchin Tracking Module (UTM) parameters used to track the effectiveness of online marketing campaigns.</value>
        [DataMember(Name="mktCampaign", EmitDefaultValue=false)]
        public JourneyCampaign MktCampaign { get; set; }



        /// <summary>
        /// The session that the event belongs to.
        /// </summary>
        /// <value>The session that the event belongs to.</value>
        [DataMember(Name="session", EmitDefaultValue=false)]
        public WebEventResponseSession Session { get; set; }



        /// <summary>
        /// Identifies the web page that originally generated the request for the current page being viewed.
        /// </summary>
        /// <value>Identifies the web page that originally generated the request for the current page being viewed.</value>
        [DataMember(Name="referrer", EmitDefaultValue=false)]
        public Referrer Referrer { get; set; }



        /// <summary>
        /// User-defined attributes associated with a particular event. These attributes provide additional context about the event. For example, items_in_cart or subscription_level.
        /// </summary>
        /// <value>User-defined attributes associated with a particular event. These attributes provide additional context about the event. For example, items_in_cart or subscription_level.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, CustomEventAttribute> Attributes { get; set; }



        /// <summary>
        /// Traits are attributes intrinsic to the customer that may be sent in selected events, (e.g. email, lastName, cellPhone). Traits are used to collect information for identity resolution. For example, the same person might be using an application on different devices which might create two sessions with different customerIds. Additional information can be provided as traits to help link those two sessions and customers to a single external contact through common identifiers that were submitted via a form fill, message, or other input in both sessions.
        /// </summary>
        /// <value>Traits are attributes intrinsic to the customer that may be sent in selected events, (e.g. email, lastName, cellPhone). Traits are used to collect information for identity resolution. For example, the same person might be using an application on different devices which might create two sessions with different customerIds. Additional information can be provided as traits to help link those two sessions and customers to a single external contact through common identifiers that were submitted via a form fill, message, or other input in both sessions.</value>
        [DataMember(Name="traits", EmitDefaultValue=false)]
        public Dictionary<string, CustomEventAttribute> Traits { get; set; }



        /// <summary>
        /// Indicates whether the event was produced during an authenticated session.
        /// </summary>
        /// <value>Indicates whether the event was produced during an authenticated session.</value>
        [DataMember(Name="authenticated", EmitDefaultValue=false)]
        public bool? Authenticated { get; set; }



        /// <summary>
        /// UTC timestamp indicating when the event actually took place, events older than an hour will be rejected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>UTC timestamp indicating when the event actually took place, events older than an hour will be rejected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebEventResponse {\n");

            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  CustomerIdType: ").Append(CustomerIdType).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
            sb.Append("  Browser: ").Append(Browser).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
            sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
            sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
            sb.Append("  MktCampaign: ").Append(MktCampaign).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  Referrer: ").Append(Referrer).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Traits: ").Append(Traits).Append("\n");
            sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
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
            return this.Equals(obj as WebEventResponse);
        }

        /// <summary>
        /// Returns true if WebEventResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WebEventResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebEventResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) &&
                (
                    this.EventName == other.EventName ||
                    this.EventName != null &&
                    this.EventName.Equals(other.EventName)
                ) &&
                (
                    this.CustomerIdType == other.CustomerIdType ||
                    this.CustomerIdType != null &&
                    this.CustomerIdType.Equals(other.CustomerIdType)
                ) &&
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) &&
                (
                    this.UserAgentString == other.UserAgentString ||
                    this.UserAgentString != null &&
                    this.UserAgentString.Equals(other.UserAgentString)
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
                    this.SearchQuery == other.SearchQuery ||
                    this.SearchQuery != null &&
                    this.SearchQuery.Equals(other.SearchQuery)
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
                ) &&
                (
                    this.Authenticated == other.Authenticated ||
                    this.Authenticated != null &&
                    this.Authenticated.Equals(other.Authenticated)
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
                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();

                if (this.EventName != null)
                    hash = hash * 59 + this.EventName.GetHashCode();

                if (this.CustomerIdType != null)
                    hash = hash * 59 + this.CustomerIdType.GetHashCode();

                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();

                if (this.UserAgentString != null)
                    hash = hash * 59 + this.UserAgentString.GetHashCode();

                if (this.Browser != null)
                    hash = hash * 59 + this.Browser.GetHashCode();

                if (this.Device != null)
                    hash = hash * 59 + this.Device.GetHashCode();

                if (this.SearchQuery != null)
                    hash = hash * 59 + this.SearchQuery.GetHashCode();

                if (this.IpOrganization != null)
                    hash = hash * 59 + this.IpOrganization.GetHashCode();

                if (this.Geolocation != null)
                    hash = hash * 59 + this.Geolocation.GetHashCode();

                if (this.MktCampaign != null)
                    hash = hash * 59 + this.MktCampaign.GetHashCode();

                if (this.Session != null)
                    hash = hash * 59 + this.Session.GetHashCode();

                if (this.Referrer != null)
                    hash = hash * 59 + this.Referrer.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                if (this.Traits != null)
                    hash = hash * 59 + this.Traits.GetHashCode();

                if (this.Authenticated != null)
                    hash = hash * 59 + this.Authenticated.GetHashCode();

                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();

                return hash;
            }
        }
    }

}
