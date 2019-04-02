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
    /// OutcomeAchievedEvent
    /// </summary>
    [DataContract]
    public partial class OutcomeAchievedEvent :  IEquatable<OutcomeAchievedEvent>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OutcomeAchievedEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OutcomeAchievedEvent() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OutcomeAchievedEvent" /> class.
        /// </summary>
        /// <param name="Outcome">The outcome achieved. (required).</param>
        /// <param name="UserAgentString">HTTP User-Agent string (see https://tools.ietf.org/html/rfc1945#section-10.15)..</param>
        /// <param name="Browser">Customer&#39;s browser..</param>
        /// <param name="Device">Customer&#39;s device..</param>
        /// <param name="Geolocation">Customer&#39;s geolocation..</param>
        /// <param name="IpAddress">Visitor&#39;s IP address..</param>
        /// <param name="IpOrganization">Visitor&#39;s IP-based organization or ISP name..</param>
        /// <param name="MktCampaign">Marketing / traffic source information..</param>
        /// <param name="VisitReferrer">Visit&#39;s referrer..</param>
        /// <param name="VisitCreatedDate">When visit was created (e.g. timestamp of the first event in visit). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        public OutcomeAchievedEvent(Outcome Outcome = null, string UserAgentString = null, Browser Browser = null, Device Device = null, JourneyGeolocation Geolocation = null, string IpAddress = null, string IpOrganization = null, JourneyCampaign MktCampaign = null, Referrer VisitReferrer = null, DateTime? VisitCreatedDate = null)
        {
            this.Outcome = Outcome;
            this.UserAgentString = UserAgentString;
            this.Browser = Browser;
            this.Device = Device;
            this.Geolocation = Geolocation;
            this.IpAddress = IpAddress;
            this.IpOrganization = IpOrganization;
            this.MktCampaign = MktCampaign;
            this.VisitReferrer = VisitReferrer;
            this.VisitCreatedDate = VisitCreatedDate;
            
        }
        
        
        
        /// <summary>
        /// The outcome achieved.
        /// </summary>
        /// <value>The outcome achieved.</value>
        [DataMember(Name="outcome", EmitDefaultValue=false)]
        public Outcome Outcome { get; set; }
        
        
        
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
        /// Visitor&#39;s IP address.
        /// </summary>
        /// <value>Visitor&#39;s IP address.</value>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }
        
        
        
        /// <summary>
        /// Visitor&#39;s IP-based organization or ISP name.
        /// </summary>
        /// <value>Visitor&#39;s IP-based organization or ISP name.</value>
        [DataMember(Name="ipOrganization", EmitDefaultValue=false)]
        public string IpOrganization { get; set; }
        
        
        
        /// <summary>
        /// Marketing / traffic source information.
        /// </summary>
        /// <value>Marketing / traffic source information.</value>
        [DataMember(Name="mktCampaign", EmitDefaultValue=false)]
        public JourneyCampaign MktCampaign { get; set; }
        
        
        
        /// <summary>
        /// Visit&#39;s referrer.
        /// </summary>
        /// <value>Visit&#39;s referrer.</value>
        [DataMember(Name="visitReferrer", EmitDefaultValue=false)]
        public Referrer VisitReferrer { get; set; }
        
        
        
        /// <summary>
        /// When visit was created (e.g. timestamp of the first event in visit). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>When visit was created (e.g. timestamp of the first event in visit). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="visitCreatedDate", EmitDefaultValue=false)]
        public DateTime? VisitCreatedDate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutcomeAchievedEvent {\n");
            
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
            sb.Append("  Browser: ").Append(Browser).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
            sb.Append("  MktCampaign: ").Append(MktCampaign).Append("\n");
            sb.Append("  VisitReferrer: ").Append(VisitReferrer).Append("\n");
            sb.Append("  VisitCreatedDate: ").Append(VisitCreatedDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OutcomeAchievedEvent);
        }

        /// <summary>
        /// Returns true if OutcomeAchievedEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of OutcomeAchievedEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutcomeAchievedEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Outcome == other.Outcome ||
                    this.Outcome != null &&
                    this.Outcome.Equals(other.Outcome)
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
                    this.VisitReferrer == other.VisitReferrer ||
                    this.VisitReferrer != null &&
                    this.VisitReferrer.Equals(other.VisitReferrer)
                ) &&
                (
                    this.VisitCreatedDate == other.VisitCreatedDate ||
                    this.VisitCreatedDate != null &&
                    this.VisitCreatedDate.Equals(other.VisitCreatedDate)
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
                
                if (this.Outcome != null)
                    hash = hash * 59 + this.Outcome.GetHashCode();
                
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
                
                if (this.VisitReferrer != null)
                    hash = hash * 59 + this.VisitReferrer.GetHashCode();
                
                if (this.VisitCreatedDate != null)
                    hash = hash * 59 + this.VisitCreatedDate.GetHashCode();
                
                return hash;
            }
        }
    }

}
