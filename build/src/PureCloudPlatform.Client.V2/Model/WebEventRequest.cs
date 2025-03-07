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
    /// WebEventRequest
    /// </summary>
    [DataContract]
    public partial class WebEventRequest :  IEquatable<WebEventRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WebEventRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebEventRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebEventRequest" /> class.
        /// </summary>
        /// <param name="CustomerCookieId">A UUID representing the customer making the request. (required).</param>
        /// <param name="EventName">Represents the action the customer performed. Event types are created for each unique event name and can be faceted on in segment and outcome conditions. A valid event name must only contain alphanumeric characters and underscores. A good event name is typically an object followed by the action performed in past tense, e.g. page_viewed, order_completed, user_registered. (required).</param>
        /// <param name="Page">The webpage where the user interaction occurred. (required).</param>
        /// <param name="UserAgentString">Override for HTTP User-Agent string from request header (see https://tools.ietf.org/html/rfc1945#section-10.15)..</param>
        /// <param name="Browser">Customer&#39;s browser..</param>
        /// <param name="Device">Customer&#39;s device..</param>
        /// <param name="SearchQuery">Represents the keywords in a customer search query..</param>
        /// <param name="IpAddress">Customer&#39;s IP address..</param>
        /// <param name="ReferrerUrl">Identifies the referrer URL that originally generated the request for the current page being viewed..</param>
        /// <param name="Attributes">User-defined attributes associated with a particular event. These attributes provide additional context about the event. For example, items_in_cart or subscription_level..</param>
        /// <param name="Traits">Traits are attributes intrinsic to the customer that may be sent in selected events, e.g. email, lastName, cellPhone. Traits are used to collect information for identity resolution. For example, the same person might be using an application on different devices which might create two sessions with different customerIds. Additional information can be provided as traits to help link those two sessions and customers to a single external contact through common identifiers that were submitted via a form fill, message, or other input in both sessions..</param>
        /// <param name="CreatedDate">UTC timestamp indicating when the event actually took place, events older than an hour will be rejected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        public WebEventRequest(string CustomerCookieId = null, string EventName = null, RequestPage Page = null, string UserAgentString = null, WebEventBrowser Browser = null, WebEventDevice Device = null, string SearchQuery = null, string IpAddress = null, string ReferrerUrl = null, Dictionary<string, CustomEventAttribute> Attributes = null, Dictionary<string, CustomEventAttribute> Traits = null, DateTime? CreatedDate = null)
        {
            this.CustomerCookieId = CustomerCookieId;
            this.EventName = EventName;
            this.Page = Page;
            this.UserAgentString = UserAgentString;
            this.Browser = Browser;
            this.Device = Device;
            this.SearchQuery = SearchQuery;
            this.IpAddress = IpAddress;
            this.ReferrerUrl = ReferrerUrl;
            this.Attributes = Attributes;
            this.Traits = Traits;
            this.CreatedDate = CreatedDate;
            
        }
        


        /// <summary>
        /// A UUID representing the customer making the request.
        /// </summary>
        /// <value>A UUID representing the customer making the request.</value>
        [DataMember(Name="customerCookieId", EmitDefaultValue=false)]
        public string CustomerCookieId { get; set; }



        /// <summary>
        /// Represents the action the customer performed. Event types are created for each unique event name and can be faceted on in segment and outcome conditions. A valid event name must only contain alphanumeric characters and underscores. A good event name is typically an object followed by the action performed in past tense, e.g. page_viewed, order_completed, user_registered.
        /// </summary>
        /// <value>Represents the action the customer performed. Event types are created for each unique event name and can be faceted on in segment and outcome conditions. A valid event name must only contain alphanumeric characters and underscores. A good event name is typically an object followed by the action performed in past tense, e.g. page_viewed, order_completed, user_registered.</value>
        [DataMember(Name="eventName", EmitDefaultValue=false)]
        public string EventName { get; set; }



        /// <summary>
        /// The webpage where the user interaction occurred.
        /// </summary>
        /// <value>The webpage where the user interaction occurred.</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public RequestPage Page { get; set; }



        /// <summary>
        /// Override for HTTP User-Agent string from request header (see https://tools.ietf.org/html/rfc1945#section-10.15).
        /// </summary>
        /// <value>Override for HTTP User-Agent string from request header (see https://tools.ietf.org/html/rfc1945#section-10.15).</value>
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
        /// Customer&#39;s IP address.
        /// </summary>
        /// <value>Customer&#39;s IP address.</value>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }



        /// <summary>
        /// Identifies the referrer URL that originally generated the request for the current page being viewed.
        /// </summary>
        /// <value>Identifies the referrer URL that originally generated the request for the current page being viewed.</value>
        [DataMember(Name="referrerUrl", EmitDefaultValue=false)]
        public string ReferrerUrl { get; set; }



        /// <summary>
        /// User-defined attributes associated with a particular event. These attributes provide additional context about the event. For example, items_in_cart or subscription_level.
        /// </summary>
        /// <value>User-defined attributes associated with a particular event. These attributes provide additional context about the event. For example, items_in_cart or subscription_level.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, CustomEventAttribute> Attributes { get; set; }



        /// <summary>
        /// Traits are attributes intrinsic to the customer that may be sent in selected events, e.g. email, lastName, cellPhone. Traits are used to collect information for identity resolution. For example, the same person might be using an application on different devices which might create two sessions with different customerIds. Additional information can be provided as traits to help link those two sessions and customers to a single external contact through common identifiers that were submitted via a form fill, message, or other input in both sessions.
        /// </summary>
        /// <value>Traits are attributes intrinsic to the customer that may be sent in selected events, e.g. email, lastName, cellPhone. Traits are used to collect information for identity resolution. For example, the same person might be using an application on different devices which might create two sessions with different customerIds. Additional information can be provided as traits to help link those two sessions and customers to a single external contact through common identifiers that were submitted via a form fill, message, or other input in both sessions.</value>
        [DataMember(Name="traits", EmitDefaultValue=false)]
        public Dictionary<string, CustomEventAttribute> Traits { get; set; }



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
            sb.Append("class WebEventRequest {\n");

            sb.Append("  CustomerCookieId: ").Append(CustomerCookieId).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
            sb.Append("  Browser: ").Append(Browser).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  ReferrerUrl: ").Append(ReferrerUrl).Append("\n");
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
            return this.Equals(obj as WebEventRequest);
        }

        /// <summary>
        /// Returns true if WebEventRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of WebEventRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebEventRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CustomerCookieId == other.CustomerCookieId ||
                    this.CustomerCookieId != null &&
                    this.CustomerCookieId.Equals(other.CustomerCookieId)
                ) &&
                (
                    this.EventName == other.EventName ||
                    this.EventName != null &&
                    this.EventName.Equals(other.EventName)
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
                    this.IpAddress == other.IpAddress ||
                    this.IpAddress != null &&
                    this.IpAddress.Equals(other.IpAddress)
                ) &&
                (
                    this.ReferrerUrl == other.ReferrerUrl ||
                    this.ReferrerUrl != null &&
                    this.ReferrerUrl.Equals(other.ReferrerUrl)
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
                if (this.CustomerCookieId != null)
                    hash = hash * 59 + this.CustomerCookieId.GetHashCode();

                if (this.EventName != null)
                    hash = hash * 59 + this.EventName.GetHashCode();

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

                if (this.IpAddress != null)
                    hash = hash * 59 + this.IpAddress.GetHashCode();

                if (this.ReferrerUrl != null)
                    hash = hash * 59 + this.ReferrerUrl.GetHashCode();

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
