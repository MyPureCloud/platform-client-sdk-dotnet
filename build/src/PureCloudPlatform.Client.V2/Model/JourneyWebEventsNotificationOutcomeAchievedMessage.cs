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
    /// JourneyWebEventsNotificationOutcomeAchievedMessage
    /// </summary>
    [DataContract]
    public partial class JourneyWebEventsNotificationOutcomeAchievedMessage :  IEquatable<JourneyWebEventsNotificationOutcomeAchievedMessage>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyWebEventsNotificationOutcomeAchievedMessage" /> class.
        /// </summary>
        /// <param name="Outcome">Outcome.</param>
        /// <param name="Browser">Browser.</param>
        /// <param name="VisitCreatedDate">VisitCreatedDate.</param>
        /// <param name="IpAddress">IpAddress.</param>
        /// <param name="IpOrganization">IpOrganization.</param>
        /// <param name="UserAgentString">UserAgentString.</param>
        /// <param name="Device">Device.</param>
        /// <param name="Geolocation">Geolocation.</param>
        /// <param name="MktCampaign">MktCampaign.</param>
        /// <param name="VisitReferrer">VisitReferrer.</param>
        public JourneyWebEventsNotificationOutcomeAchievedMessage(JourneyWebEventsNotificationOutcome Outcome = null, JourneyWebEventsNotificationBrowser Browser = null, DateTime? VisitCreatedDate = null, string IpAddress = null, string IpOrganization = null, string UserAgentString = null, JourneyWebEventsNotificationDevice Device = null, JourneyWebEventsNotificationGeoLocation Geolocation = null, JourneyWebEventsNotificationMktCampaign MktCampaign = null, JourneyWebEventsNotificationReferrer VisitReferrer = null)
        {
            this.Outcome = Outcome;
            this.Browser = Browser;
            this.VisitCreatedDate = VisitCreatedDate;
            this.IpAddress = IpAddress;
            this.IpOrganization = IpOrganization;
            this.UserAgentString = UserAgentString;
            this.Device = Device;
            this.Geolocation = Geolocation;
            this.MktCampaign = MktCampaign;
            this.VisitReferrer = VisitReferrer;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Outcome
        /// </summary>
        [DataMember(Name="outcome", EmitDefaultValue=false)]
        public JourneyWebEventsNotificationOutcome Outcome { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Browser
        /// </summary>
        [DataMember(Name="browser", EmitDefaultValue=false)]
        public JourneyWebEventsNotificationBrowser Browser { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets VisitCreatedDate
        /// </summary>
        [DataMember(Name="visitCreatedDate", EmitDefaultValue=false)]
        public DateTime? VisitCreatedDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets IpOrganization
        /// </summary>
        [DataMember(Name="ipOrganization", EmitDefaultValue=false)]
        public string IpOrganization { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets UserAgentString
        /// </summary>
        [DataMember(Name="userAgentString", EmitDefaultValue=false)]
        public string UserAgentString { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public JourneyWebEventsNotificationDevice Device { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Geolocation
        /// </summary>
        [DataMember(Name="geolocation", EmitDefaultValue=false)]
        public JourneyWebEventsNotificationGeoLocation Geolocation { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MktCampaign
        /// </summary>
        [DataMember(Name="mktCampaign", EmitDefaultValue=false)]
        public JourneyWebEventsNotificationMktCampaign MktCampaign { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets VisitReferrer
        /// </summary>
        [DataMember(Name="visitReferrer", EmitDefaultValue=false)]
        public JourneyWebEventsNotificationReferrer VisitReferrer { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyWebEventsNotificationOutcomeAchievedMessage {\n");
            
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  Browser: ").Append(Browser).Append("\n");
            sb.Append("  VisitCreatedDate: ").Append(VisitCreatedDate).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
            sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
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
            return this.Equals(obj as JourneyWebEventsNotificationOutcomeAchievedMessage);
        }

        /// <summary>
        /// Returns true if JourneyWebEventsNotificationOutcomeAchievedMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyWebEventsNotificationOutcomeAchievedMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyWebEventsNotificationOutcomeAchievedMessage other)
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
                    this.Browser == other.Browser ||
                    this.Browser != null &&
                    this.Browser.Equals(other.Browser)
                ) &&
                (
                    this.VisitCreatedDate == other.VisitCreatedDate ||
                    this.VisitCreatedDate != null &&
                    this.VisitCreatedDate.Equals(other.VisitCreatedDate)
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
                    this.UserAgentString == other.UserAgentString ||
                    this.UserAgentString != null &&
                    this.UserAgentString.Equals(other.UserAgentString)
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
                
                if (this.Outcome != null)
                    hash = hash * 59 + this.Outcome.GetHashCode();
                
                if (this.Browser != null)
                    hash = hash * 59 + this.Browser.GetHashCode();
                
                if (this.VisitCreatedDate != null)
                    hash = hash * 59 + this.VisitCreatedDate.GetHashCode();
                
                if (this.IpAddress != null)
                    hash = hash * 59 + this.IpAddress.GetHashCode();
                
                if (this.IpOrganization != null)
                    hash = hash * 59 + this.IpOrganization.GetHashCode();
                
                if (this.UserAgentString != null)
                    hash = hash * 59 + this.UserAgentString.GetHashCode();
                
                if (this.Device != null)
                    hash = hash * 59 + this.Device.GetHashCode();
                
                if (this.Geolocation != null)
                    hash = hash * 59 + this.Geolocation.GetHashCode();
                
                if (this.MktCampaign != null)
                    hash = hash * 59 + this.MktCampaign.GetHashCode();
                
                if (this.VisitReferrer != null)
                    hash = hash * 59 + this.VisitReferrer.GetHashCode();
                
                return hash;
            }
        }
    }

}
