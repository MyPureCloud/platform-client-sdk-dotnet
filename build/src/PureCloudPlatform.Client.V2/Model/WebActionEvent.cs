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
    /// WebActionEvent
    /// </summary>
    [DataContract]
    public partial class WebActionEvent :  IEquatable<WebActionEvent>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebActionEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebActionEvent() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebActionEvent" /> class.
        /// </summary>
        /// <param name="Action">The action that triggered the event. (required).</param>
        /// <param name="ActionMap">The action map that triggered the action..</param>
        /// <param name="ActionTarget">The target for engagement actions..</param>
        /// <param name="TimeToDisposition">Milliseconds elapsed until the action is disposed..</param>
        /// <param name="ErrorCode">Code of the error returned when the action fails..</param>
        /// <param name="ErrorMessage">Message of the error returned when the action fails..</param>
        /// <param name="UserAgentString">HTTP User-Agent string (see https://tools.ietf.org/html/rfc1945#section-10.15)..</param>
        /// <param name="Browser">Customer&#39;s browser..</param>
        /// <param name="Device">Customer&#39;s device..</param>
        /// <param name="Geolocation">Customer&#39;s geolocation..</param>
        /// <param name="IpAddress">Visitor&#39;s IP address..</param>
        /// <param name="IpOrganization">Visitor&#39;s IP-based organization or ISP name..</param>
        /// <param name="MktCampaign">Marketing / traffic source information..</param>
        /// <param name="VisitReferrer">Visit&#39;s referrer..</param>
        public WebActionEvent(EventAction Action = null, ActionMap ActionMap = null, ActionTarget ActionTarget = null, long? TimeToDisposition = null, string ErrorCode = null, string ErrorMessage = null, string UserAgentString = null, Browser Browser = null, Device Device = null, JourneyGeolocation Geolocation = null, string IpAddress = null, string IpOrganization = null, JourneyCampaign MktCampaign = null, Referrer VisitReferrer = null)
        {
            this.Action = Action;
            this.ActionMap = ActionMap;
            this.ActionTarget = ActionTarget;
            this.TimeToDisposition = TimeToDisposition;
            this.ErrorCode = ErrorCode;
            this.ErrorMessage = ErrorMessage;
            this.UserAgentString = UserAgentString;
            this.Browser = Browser;
            this.Device = Device;
            this.Geolocation = Geolocation;
            this.IpAddress = IpAddress;
            this.IpOrganization = IpOrganization;
            this.MktCampaign = MktCampaign;
            this.VisitReferrer = VisitReferrer;
            
        }
        
        
        
        /// <summary>
        /// The action that triggered the event.
        /// </summary>
        /// <value>The action that triggered the event.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public EventAction Action { get; set; }
        
        
        
        /// <summary>
        /// The action map that triggered the action.
        /// </summary>
        /// <value>The action map that triggered the action.</value>
        [DataMember(Name="actionMap", EmitDefaultValue=false)]
        public ActionMap ActionMap { get; set; }
        
        
        
        /// <summary>
        /// The target for engagement actions.
        /// </summary>
        /// <value>The target for engagement actions.</value>
        [DataMember(Name="actionTarget", EmitDefaultValue=false)]
        public ActionTarget ActionTarget { get; set; }
        
        
        
        /// <summary>
        /// Milliseconds elapsed until the action is disposed.
        /// </summary>
        /// <value>Milliseconds elapsed until the action is disposed.</value>
        [DataMember(Name="timeToDisposition", EmitDefaultValue=false)]
        public long? TimeToDisposition { get; set; }
        
        
        
        /// <summary>
        /// Code of the error returned when the action fails.
        /// </summary>
        /// <value>Code of the error returned when the action fails.</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }
        
        
        
        /// <summary>
        /// Message of the error returned when the action fails.
        /// </summary>
        /// <value>Message of the error returned when the action fails.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
        
        
        
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebActionEvent {\n");
            
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ActionMap: ").Append(ActionMap).Append("\n");
            sb.Append("  ActionTarget: ").Append(ActionTarget).Append("\n");
            sb.Append("  TimeToDisposition: ").Append(TimeToDisposition).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
            sb.Append("  Browser: ").Append(Browser).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
            sb.Append("  MktCampaign: ").Append(MktCampaign).Append("\n");
            sb.Append("  VisitReferrer: ").Append(VisitReferrer).Append("\n");
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
            return this.Equals(obj as WebActionEvent);
        }

        /// <summary>
        /// Returns true if WebActionEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of WebActionEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebActionEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.ActionMap == other.ActionMap ||
                    this.ActionMap != null &&
                    this.ActionMap.Equals(other.ActionMap)
                ) &&
                (
                    this.ActionTarget == other.ActionTarget ||
                    this.ActionTarget != null &&
                    this.ActionTarget.Equals(other.ActionTarget)
                ) &&
                (
                    this.TimeToDisposition == other.TimeToDisposition ||
                    this.TimeToDisposition != null &&
                    this.TimeToDisposition.Equals(other.TimeToDisposition)
                ) &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
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
                
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                
                if (this.ActionMap != null)
                    hash = hash * 59 + this.ActionMap.GetHashCode();
                
                if (this.ActionTarget != null)
                    hash = hash * 59 + this.ActionTarget.GetHashCode();
                
                if (this.TimeToDisposition != null)
                    hash = hash * 59 + this.TimeToDisposition.GetHashCode();
                
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                
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
                
                return hash;
            }
        }
    }

}
