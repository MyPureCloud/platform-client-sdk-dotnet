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
    /// AppEventRequest
    /// </summary>
    [DataContract]
    public partial class AppEventRequest :  IEquatable<AppEventRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppEventRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventRequest" /> class.
        /// </summary>
        /// <param name="EventName">Represents the action the customer performed. Event types are created for each unique event name and can be faceted on in segment and outcome conditions. A valid event name must only contain alphanumeric characters and underscores. A good event name is typically an object followed by the action performed in past tense, e.g. screen_viewed, search_performed, user_registered. (required).</param>
        /// <param name="ScreenName">The name of the screen, view, or fragment in the app where the event took place. (required).</param>
        /// <param name="App">Application that the customer is interacting with. (required).</param>
        /// <param name="Device">Customer's device. (required).</param>
        /// <param name="SdkLibrary">SDK library used to generate the event..</param>
        /// <param name="NetworkConnectivity">Information relating to the device's network connectivity..</param>
        /// <param name="ReferrerUrl">The referrer URL of the first event in the app session..</param>
        /// <param name="Session">Contains information about the app session the event belongs to. A session is expected to end once the application is closed or a customer has been idle for more than 30 minutes. Each session is tied to a single customer and a customer can be linked to multiple unique sessions. (required).</param>
        /// <param name="SearchQuery">Represents the keywords in a customer search query..</param>
        /// <param name="Attributes">User-defined attributes associated with a particular event. These attributes provide additional context about the event. For example, items_in_cart or subscription_level..</param>
        /// <param name="Traits">Traits are attributes intrinsic to the customer that may be sent in selected events, (e.g. email, lastName, cellPhone). Traits are used to collect information for identity resolution. For example, the same person might be using an application on different devices which might create two sessions with different customerIds. Additional information can be provided as traits to help link those two sessions and customers to a single external contact through common identifiers that were submitted via a form fill, message, or other input in both sessions..</param>
        /// <param name="CustomerCookieId">Cookie ID of the customer associated with the app event. This is expected to be set per application install or device and can be used to identify a single customer across multiple sessions. This identifier, along with others passed as traits, is used for identity resolution. (required).</param>
        /// <param name="CreatedDate">Timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        public AppEventRequest(string EventName = null, string ScreenName = null, JourneyApp App = null, Device Device = null, SdkLibrary SdkLibrary = null, NetworkConnectivity NetworkConnectivity = null, string ReferrerUrl = null, AppEventRequestSession Session = null, string SearchQuery = null, Dictionary<string, CustomEventAttribute> Attributes = null, Dictionary<string, CustomEventAttribute> Traits = null, string CustomerCookieId = null, DateTime? CreatedDate = null)
        {
            this.EventName = EventName;
            this.ScreenName = ScreenName;
            this.App = App;
            this.Device = Device;
            this.SdkLibrary = SdkLibrary;
            this.NetworkConnectivity = NetworkConnectivity;
            this.ReferrerUrl = ReferrerUrl;
            this.Session = Session;
            this.SearchQuery = SearchQuery;
            this.Attributes = Attributes;
            this.Traits = Traits;
            this.CustomerCookieId = CustomerCookieId;
            this.CreatedDate = CreatedDate;
            
        }
        


        /// <summary>
        /// Represents the action the customer performed. Event types are created for each unique event name and can be faceted on in segment and outcome conditions. A valid event name must only contain alphanumeric characters and underscores. A good event name is typically an object followed by the action performed in past tense, e.g. screen_viewed, search_performed, user_registered.
        /// </summary>
        /// <value>Represents the action the customer performed. Event types are created for each unique event name and can be faceted on in segment and outcome conditions. A valid event name must only contain alphanumeric characters and underscores. A good event name is typically an object followed by the action performed in past tense, e.g. screen_viewed, search_performed, user_registered.</value>
        [DataMember(Name="eventName", EmitDefaultValue=false)]
        public string EventName { get; set; }



        /// <summary>
        /// The name of the screen, view, or fragment in the app where the event took place.
        /// </summary>
        /// <value>The name of the screen, view, or fragment in the app where the event took place.</value>
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
        /// The referrer URL of the first event in the app session.
        /// </summary>
        /// <value>The referrer URL of the first event in the app session.</value>
        [DataMember(Name="referrerUrl", EmitDefaultValue=false)]
        public string ReferrerUrl { get; set; }



        /// <summary>
        /// Contains information about the app session the event belongs to. A session is expected to end once the application is closed or a customer has been idle for more than 30 minutes. Each session is tied to a single customer and a customer can be linked to multiple unique sessions.
        /// </summary>
        /// <value>Contains information about the app session the event belongs to. A session is expected to end once the application is closed or a customer has been idle for more than 30 minutes. Each session is tied to a single customer and a customer can be linked to multiple unique sessions.</value>
        [DataMember(Name="session", EmitDefaultValue=false)]
        public AppEventRequestSession Session { get; set; }



        /// <summary>
        /// Represents the keywords in a customer search query.
        /// </summary>
        /// <value>Represents the keywords in a customer search query.</value>
        [DataMember(Name="searchQuery", EmitDefaultValue=false)]
        public string SearchQuery { get; set; }



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
        /// Cookie ID of the customer associated with the app event. This is expected to be set per application install or device and can be used to identify a single customer across multiple sessions. This identifier, along with others passed as traits, is used for identity resolution.
        /// </summary>
        /// <value>Cookie ID of the customer associated with the app event. This is expected to be set per application install or device and can be used to identify a single customer across multiple sessions. This identifier, along with others passed as traits, is used for identity resolution.</value>
        [DataMember(Name="customerCookieId", EmitDefaultValue=false)]
        public string CustomerCookieId { get; set; }



        /// <summary>
        /// Timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppEventRequest {\n");

            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  ScreenName: ").Append(ScreenName).Append("\n");
            sb.Append("  App: ").Append(App).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  SdkLibrary: ").Append(SdkLibrary).Append("\n");
            sb.Append("  NetworkConnectivity: ").Append(NetworkConnectivity).Append("\n");
            sb.Append("  ReferrerUrl: ").Append(ReferrerUrl).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Traits: ").Append(Traits).Append("\n");
            sb.Append("  CustomerCookieId: ").Append(CustomerCookieId).Append("\n");
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
            return this.Equals(obj as AppEventRequest);
        }

        /// <summary>
        /// Returns true if AppEventRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AppEventRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppEventRequest other)
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
                    this.ReferrerUrl == other.ReferrerUrl ||
                    this.ReferrerUrl != null &&
                    this.ReferrerUrl.Equals(other.ReferrerUrl)
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
                    this.CustomerCookieId == other.CustomerCookieId ||
                    this.CustomerCookieId != null &&
                    this.CustomerCookieId.Equals(other.CustomerCookieId)
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
                if (this.EventName != null)
                    hash = hash * 59 + this.EventName.GetHashCode();

                if (this.ScreenName != null)
                    hash = hash * 59 + this.ScreenName.GetHashCode();

                if (this.App != null)
                    hash = hash * 59 + this.App.GetHashCode();

                if (this.Device != null)
                    hash = hash * 59 + this.Device.GetHashCode();

                if (this.SdkLibrary != null)
                    hash = hash * 59 + this.SdkLibrary.GetHashCode();

                if (this.NetworkConnectivity != null)
                    hash = hash * 59 + this.NetworkConnectivity.GetHashCode();

                if (this.ReferrerUrl != null)
                    hash = hash * 59 + this.ReferrerUrl.GetHashCode();

                if (this.Session != null)
                    hash = hash * 59 + this.Session.GetHashCode();

                if (this.SearchQuery != null)
                    hash = hash * 59 + this.SearchQuery.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                if (this.Traits != null)
                    hash = hash * 59 + this.Traits.GetHashCode();

                if (this.CustomerCookieId != null)
                    hash = hash * 59 + this.CustomerCookieId.GetHashCode();

                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();

                return hash;
            }
        }
    }

}
