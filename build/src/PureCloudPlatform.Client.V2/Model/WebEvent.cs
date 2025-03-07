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
    /// WebEvent
    /// </summary>
    [DataContract]
    public partial class WebEvent :  IEquatable<WebEvent>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WebEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebEvent" /> class.
        /// </summary>
        /// <param name="EventName">Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. page_viewed, order_completed, user_registered). (required).</param>
        /// <param name="TotalEventCount">The total count of events performed by the customer across all sessions. (required).</param>
        /// <param name="TotalPageviewCount">The total count of pageviews performed by the customer across all sessions. (required).</param>
        /// <param name="Page">The webpage where the user interaction occurred. (required).</param>
        /// <param name="UserAgentString">HTTP User-Agent string (see https://tools.ietf.org/html/rfc1945#section-10.15). (required).</param>
        /// <param name="Browser">Customer&#39;s browser. (required).</param>
        /// <param name="Device">Customer&#39;s device. (required).</param>
        /// <param name="Geolocation">Customer&#39;s geolocation..</param>
        /// <param name="IpAddress">Customer&#39;s IP address. May be null if the business configures the tracker to not collect IP addresses..</param>
        /// <param name="IpOrganization">Customer&#39;s IP-based organization or ISP name..</param>
        /// <param name="MktCampaign">Marketing / traffic source information..</param>
        /// <param name="Referrer">Identifies the page URL that originally generated the request for the current page being viewed..</param>
        /// <param name="Attributes">User-defined attributes associated with a particular event. (required).</param>
        /// <param name="Traits">User-defined traits associated with a particular event. (required).</param>
        /// <param name="SearchQuery">Represents the keywords in a customer search query..</param>
        /// <param name="Authenticated">Indicates whether the event was produced during an authenticated session. (required).</param>
        public WebEvent(string EventName = null, int? TotalEventCount = null, int? TotalPageviewCount = null, JourneyPage Page = null, string UserAgentString = null, Browser Browser = null, Device Device = null, JourneyGeolocation Geolocation = null, string IpAddress = null, string IpOrganization = null, JourneyCampaign MktCampaign = null, Referrer Referrer = null, Dictionary<string, CustomEventAttribute> Attributes = null, Dictionary<string, CustomEventAttribute> Traits = null, string SearchQuery = null, bool? Authenticated = null)
        {
            this.EventName = EventName;
            this.TotalEventCount = TotalEventCount;
            this.TotalPageviewCount = TotalPageviewCount;
            this.Page = Page;
            this.UserAgentString = UserAgentString;
            this.Browser = Browser;
            this.Device = Device;
            this.Geolocation = Geolocation;
            this.IpAddress = IpAddress;
            this.IpOrganization = IpOrganization;
            this.MktCampaign = MktCampaign;
            this.Referrer = Referrer;
            this.Attributes = Attributes;
            this.Traits = Traits;
            this.SearchQuery = SearchQuery;
            this.Authenticated = Authenticated;
            
        }
        


        /// <summary>
        /// Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. page_viewed, order_completed, user_registered).
        /// </summary>
        /// <value>Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. page_viewed, order_completed, user_registered).</value>
        [DataMember(Name="eventName", EmitDefaultValue=false)]
        public string EventName { get; set; }



        /// <summary>
        /// The total count of events performed by the customer across all sessions.
        /// </summary>
        /// <value>The total count of events performed by the customer across all sessions.</value>
        [DataMember(Name="totalEventCount", EmitDefaultValue=false)]
        public int? TotalEventCount { get; set; }



        /// <summary>
        /// The total count of pageviews performed by the customer across all sessions.
        /// </summary>
        /// <value>The total count of pageviews performed by the customer across all sessions.</value>
        [DataMember(Name="totalPageviewCount", EmitDefaultValue=false)]
        public int? TotalPageviewCount { get; set; }



        /// <summary>
        /// The webpage where the user interaction occurred.
        /// </summary>
        /// <value>The webpage where the user interaction occurred.</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public JourneyPage Page { get; set; }



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
        public Browser Browser { get; set; }



        /// <summary>
        /// Customer&#39;s device.
        /// </summary>
        /// <value>Customer&#39;s device.</value>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public Device Device { get; set; }



        /// <summary>
        /// Customer&#39;s geolocation.
        /// </summary>
        /// <value>Customer&#39;s geolocation.</value>
        [DataMember(Name="geolocation", EmitDefaultValue=false)]
        public JourneyGeolocation Geolocation { get; set; }



        /// <summary>
        /// Customer&#39;s IP address. May be null if the business configures the tracker to not collect IP addresses.
        /// </summary>
        /// <value>Customer&#39;s IP address. May be null if the business configures the tracker to not collect IP addresses.</value>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }



        /// <summary>
        /// Customer&#39;s IP-based organization or ISP name.
        /// </summary>
        /// <value>Customer&#39;s IP-based organization or ISP name.</value>
        [DataMember(Name="ipOrganization", EmitDefaultValue=false)]
        public string IpOrganization { get; set; }



        /// <summary>
        /// Marketing / traffic source information.
        /// </summary>
        /// <value>Marketing / traffic source information.</value>
        [DataMember(Name="mktCampaign", EmitDefaultValue=false)]
        public JourneyCampaign MktCampaign { get; set; }



        /// <summary>
        /// Identifies the page URL that originally generated the request for the current page being viewed.
        /// </summary>
        /// <value>Identifies the page URL that originally generated the request for the current page being viewed.</value>
        [DataMember(Name="referrer", EmitDefaultValue=false)]
        public Referrer Referrer { get; set; }



        /// <summary>
        /// User-defined attributes associated with a particular event.
        /// </summary>
        /// <value>User-defined attributes associated with a particular event.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, CustomEventAttribute> Attributes { get; set; }



        /// <summary>
        /// User-defined traits associated with a particular event.
        /// </summary>
        /// <value>User-defined traits associated with a particular event.</value>
        [DataMember(Name="traits", EmitDefaultValue=false)]
        public Dictionary<string, CustomEventAttribute> Traits { get; set; }



        /// <summary>
        /// Represents the keywords in a customer search query.
        /// </summary>
        /// <value>Represents the keywords in a customer search query.</value>
        [DataMember(Name="searchQuery", EmitDefaultValue=false)]
        public string SearchQuery { get; set; }



        /// <summary>
        /// Indicates whether the event was produced during an authenticated session.
        /// </summary>
        /// <value>Indicates whether the event was produced during an authenticated session.</value>
        [DataMember(Name="authenticated", EmitDefaultValue=false)]
        public bool? Authenticated { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebEvent {\n");

            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  TotalEventCount: ").Append(TotalEventCount).Append("\n");
            sb.Append("  TotalPageviewCount: ").Append(TotalPageviewCount).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
            sb.Append("  Browser: ").Append(Browser).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
            sb.Append("  MktCampaign: ").Append(MktCampaign).Append("\n");
            sb.Append("  Referrer: ").Append(Referrer).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Traits: ").Append(Traits).Append("\n");
            sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
            sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
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
            return this.Equals(obj as WebEvent);
        }

        /// <summary>
        /// Returns true if WebEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of WebEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebEvent other)
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
                    this.Geolocation == other.Geolocation ||
                    this.Geolocation != null &&
                    this.Geolocation.Equals(other.Geolocation)
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
                    this.MktCampaign == other.MktCampaign ||
                    this.MktCampaign != null &&
                    this.MktCampaign.Equals(other.MktCampaign)
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
                    this.SearchQuery == other.SearchQuery ||
                    this.SearchQuery != null &&
                    this.SearchQuery.Equals(other.SearchQuery)
                ) &&
                (
                    this.Authenticated == other.Authenticated ||
                    this.Authenticated != null &&
                    this.Authenticated.Equals(other.Authenticated)
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

                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();

                if (this.UserAgentString != null)
                    hash = hash * 59 + this.UserAgentString.GetHashCode();

                if (this.Browser != null)
                    hash = hash * 59 + this.Browser.GetHashCode();

                if (this.Device != null)
                    hash = hash * 59 + this.Device.GetHashCode();

                if (this.Geolocation != null)
                    hash = hash * 59 + this.Geolocation.GetHashCode();

                if (this.IpAddress != null)
                    hash = hash * 59 + this.IpAddress.GetHashCode();

                if (this.IpOrganization != null)
                    hash = hash * 59 + this.IpOrganization.GetHashCode();

                if (this.MktCampaign != null)
                    hash = hash * 59 + this.MktCampaign.GetHashCode();

                if (this.Referrer != null)
                    hash = hash * 59 + this.Referrer.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                if (this.Traits != null)
                    hash = hash * 59 + this.Traits.GetHashCode();

                if (this.SearchQuery != null)
                    hash = hash * 59 + this.SearchQuery.GetHashCode();

                if (this.Authenticated != null)
                    hash = hash * 59 + this.Authenticated.GetHashCode();

                return hash;
            }
        }
    }

}
