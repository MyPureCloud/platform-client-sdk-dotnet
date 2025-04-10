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
    /// OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign
    /// </summary>
    [DataContract]
    public partial class OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign :  IEquatable<OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign>
    {
        /// <summary>
        /// Gets or Sets CampaignStatus
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CampaignStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum On for "on"
            /// </summary>
            [EnumMember(Value = "on")]
            On,
            
            /// <summary>
            /// Enum Off for "off"
            /// </summary>
            [EnumMember(Value = "off")]
            Off,
            
            /// <summary>
            /// Enum Complete for "complete"
            /// </summary>
            [EnumMember(Value = "complete")]
            Complete,
            
            /// <summary>
            /// Enum Stopping for "stopping"
            /// </summary>
            [EnumMember(Value = "stopping")]
            Stopping,
            
            /// <summary>
            /// Enum Invalid for "invalid"
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid
        }
        /// <summary>
        /// Gets or Sets CampaignStatus
        /// </summary>
        [DataMember(Name="campaignStatus", EmitDefaultValue=false)]
        public CampaignStatusEnum? CampaignStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign" /> class.
        /// </summary>
        /// <param name="CampaignStatus">CampaignStatus.</param>
        /// <param name="CallableTimeSet">CallableTimeSet.</param>
        /// <param name="ContactList">A UriReference for a resource.</param>
        /// <param name="DncLists">The dnc lists to check before sending a message for this messaging campaign..</param>
        /// <param name="ContactListFilters">The contact list filters to check before sending a message for this messaging campaign..</param>
        /// <param name="AlwaysRunning">Whether this messaging campaign is always running..</param>
        /// <param name="ContactSorts">The order in which to sort contacts for dialing, based on up to four columns..</param>
        /// <param name="MessagesPerMinute">How many messages this messaging campaign will send per minute..</param>
        /// <param name="RuleSets">RuleSets.</param>
        /// <param name="SmsConfig">SmsConfig.</param>
        /// <param name="EmailConfig">EmailConfig.</param>
        /// <param name="WhatsAppConfig">WhatsAppConfig.</param>
        /// <param name="Errors">A list of current error conditions associated with this messaging campaign.</param>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="Name">The UI-visible name of the object.</param>
        /// <param name="DateCreated">Creation time of the entity.</param>
        /// <param name="DateModified">Last modified time of the entity.</param>
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        /// <param name="Division">A UriReference for a resource.</param>
        public OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign(CampaignStatusEnum? CampaignStatus = null, OutboundMessagingMessagingCampaignConfigChangeUriReference CallableTimeSet = null, OutboundMessagingMessagingCampaignConfigChangeUriReference ContactList = null, List<OutboundMessagingMessagingCampaignConfigChangeUriReference> DncLists = null, List<OutboundMessagingMessagingCampaignConfigChangeUriReference> ContactListFilters = null, bool? AlwaysRunning = null, List<OutboundMessagingMessagingCampaignConfigChangeContactSort> ContactSorts = null, long? MessagesPerMinute = null, List<OutboundMessagingMessagingCampaignConfigChangeUriReference> RuleSets = null, OutboundMessagingMessagingCampaignConfigChangeSmsConfig SmsConfig = null, OutboundMessagingMessagingCampaignConfigChangeEmailConfig EmailConfig = null, OutboundMessagingMessagingCampaignConfigChangeWhatsAppConfig WhatsAppConfig = null, List<OutboundMessagingMessagingCampaignConfigChangeErrorDetail> Errors = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null, OutboundMessagingMessagingCampaignConfigChangeUriReference Division = null)
        {
            this.CampaignStatus = CampaignStatus;
            this.CallableTimeSet = CallableTimeSet;
            this.ContactList = ContactList;
            this.DncLists = DncLists;
            this.ContactListFilters = ContactListFilters;
            this.AlwaysRunning = AlwaysRunning;
            this.ContactSorts = ContactSorts;
            this.MessagesPerMinute = MessagesPerMinute;
            this.RuleSets = RuleSets;
            this.SmsConfig = SmsConfig;
            this.EmailConfig = EmailConfig;
            this.WhatsAppConfig = WhatsAppConfig;
            this.Errors = Errors;
            this.Id = Id;
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Version = Version;
            this.Division = Division;
            
        }
        




        /// <summary>
        /// Gets or Sets CallableTimeSet
        /// </summary>
        [DataMember(Name="callableTimeSet", EmitDefaultValue=false)]
        public OutboundMessagingMessagingCampaignConfigChangeUriReference CallableTimeSet { get; set; }



        /// <summary>
        /// A UriReference for a resource
        /// </summary>
        /// <value>A UriReference for a resource</value>
        [DataMember(Name="contactList", EmitDefaultValue=false)]
        public OutboundMessagingMessagingCampaignConfigChangeUriReference ContactList { get; set; }



        /// <summary>
        /// The dnc lists to check before sending a message for this messaging campaign.
        /// </summary>
        /// <value>The dnc lists to check before sending a message for this messaging campaign.</value>
        [DataMember(Name="dncLists", EmitDefaultValue=false)]
        public List<OutboundMessagingMessagingCampaignConfigChangeUriReference> DncLists { get; set; }



        /// <summary>
        /// The contact list filters to check before sending a message for this messaging campaign.
        /// </summary>
        /// <value>The contact list filters to check before sending a message for this messaging campaign.</value>
        [DataMember(Name="contactListFilters", EmitDefaultValue=false)]
        public List<OutboundMessagingMessagingCampaignConfigChangeUriReference> ContactListFilters { get; set; }



        /// <summary>
        /// Whether this messaging campaign is always running.
        /// </summary>
        /// <value>Whether this messaging campaign is always running.</value>
        [DataMember(Name="alwaysRunning", EmitDefaultValue=false)]
        public bool? AlwaysRunning { get; set; }



        /// <summary>
        /// The order in which to sort contacts for dialing, based on up to four columns.
        /// </summary>
        /// <value>The order in which to sort contacts for dialing, based on up to four columns.</value>
        [DataMember(Name="contactSorts", EmitDefaultValue=false)]
        public List<OutboundMessagingMessagingCampaignConfigChangeContactSort> ContactSorts { get; set; }



        /// <summary>
        /// How many messages this messaging campaign will send per minute.
        /// </summary>
        /// <value>How many messages this messaging campaign will send per minute.</value>
        [DataMember(Name="messagesPerMinute", EmitDefaultValue=false)]
        public long? MessagesPerMinute { get; set; }



        /// <summary>
        /// Gets or Sets RuleSets
        /// </summary>
        [DataMember(Name="ruleSets", EmitDefaultValue=false)]
        public List<OutboundMessagingMessagingCampaignConfigChangeUriReference> RuleSets { get; set; }



        /// <summary>
        /// Gets or Sets SmsConfig
        /// </summary>
        [DataMember(Name="smsConfig", EmitDefaultValue=false)]
        public OutboundMessagingMessagingCampaignConfigChangeSmsConfig SmsConfig { get; set; }



        /// <summary>
        /// Gets or Sets EmailConfig
        /// </summary>
        [DataMember(Name="emailConfig", EmitDefaultValue=false)]
        public OutboundMessagingMessagingCampaignConfigChangeEmailConfig EmailConfig { get; set; }



        /// <summary>
        /// Gets or Sets WhatsAppConfig
        /// </summary>
        [DataMember(Name="whatsAppConfig", EmitDefaultValue=false)]
        public OutboundMessagingMessagingCampaignConfigChangeWhatsAppConfig WhatsAppConfig { get; set; }



        /// <summary>
        /// A list of current error conditions associated with this messaging campaign
        /// </summary>
        /// <value>A list of current error conditions associated with this messaging campaign</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<OutboundMessagingMessagingCampaignConfigChangeErrorDetail> Errors { get; set; }



        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The UI-visible name of the object
        /// </summary>
        /// <value>The UI-visible name of the object</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Creation time of the entity
        /// </summary>
        /// <value>Creation time of the entity</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// Last modified time of the entity
        /// </summary>
        /// <value>Last modified time of the entity</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// Required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>Required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }



        /// <summary>
        /// A UriReference for a resource
        /// </summary>
        /// <value>A UriReference for a resource</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public OutboundMessagingMessagingCampaignConfigChangeUriReference Division { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign {\n");

            sb.Append("  CampaignStatus: ").Append(CampaignStatus).Append("\n");
            sb.Append("  CallableTimeSet: ").Append(CallableTimeSet).Append("\n");
            sb.Append("  ContactList: ").Append(ContactList).Append("\n");
            sb.Append("  DncLists: ").Append(DncLists).Append("\n");
            sb.Append("  ContactListFilters: ").Append(ContactListFilters).Append("\n");
            sb.Append("  AlwaysRunning: ").Append(AlwaysRunning).Append("\n");
            sb.Append("  ContactSorts: ").Append(ContactSorts).Append("\n");
            sb.Append("  MessagesPerMinute: ").Append(MessagesPerMinute).Append("\n");
            sb.Append("  RuleSets: ").Append(RuleSets).Append("\n");
            sb.Append("  SmsConfig: ").Append(SmsConfig).Append("\n");
            sb.Append("  EmailConfig: ").Append(EmailConfig).Append("\n");
            sb.Append("  WhatsAppConfig: ").Append(WhatsAppConfig).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
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
            return this.Equals(obj as OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign);
        }

        /// <summary>
        /// Returns true if OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign instances are equal
        /// </summary>
        /// <param name="other">Instance of OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CampaignStatus == other.CampaignStatus ||
                    this.CampaignStatus != null &&
                    this.CampaignStatus.Equals(other.CampaignStatus)
                ) &&
                (
                    this.CallableTimeSet == other.CallableTimeSet ||
                    this.CallableTimeSet != null &&
                    this.CallableTimeSet.Equals(other.CallableTimeSet)
                ) &&
                (
                    this.ContactList == other.ContactList ||
                    this.ContactList != null &&
                    this.ContactList.Equals(other.ContactList)
                ) &&
                (
                    this.DncLists == other.DncLists ||
                    this.DncLists != null &&
                    this.DncLists.SequenceEqual(other.DncLists)
                ) &&
                (
                    this.ContactListFilters == other.ContactListFilters ||
                    this.ContactListFilters != null &&
                    this.ContactListFilters.SequenceEqual(other.ContactListFilters)
                ) &&
                (
                    this.AlwaysRunning == other.AlwaysRunning ||
                    this.AlwaysRunning != null &&
                    this.AlwaysRunning.Equals(other.AlwaysRunning)
                ) &&
                (
                    this.ContactSorts == other.ContactSorts ||
                    this.ContactSorts != null &&
                    this.ContactSorts.SequenceEqual(other.ContactSorts)
                ) &&
                (
                    this.MessagesPerMinute == other.MessagesPerMinute ||
                    this.MessagesPerMinute != null &&
                    this.MessagesPerMinute.Equals(other.MessagesPerMinute)
                ) &&
                (
                    this.RuleSets == other.RuleSets ||
                    this.RuleSets != null &&
                    this.RuleSets.SequenceEqual(other.RuleSets)
                ) &&
                (
                    this.SmsConfig == other.SmsConfig ||
                    this.SmsConfig != null &&
                    this.SmsConfig.Equals(other.SmsConfig)
                ) &&
                (
                    this.EmailConfig == other.EmailConfig ||
                    this.EmailConfig != null &&
                    this.EmailConfig.Equals(other.EmailConfig)
                ) &&
                (
                    this.WhatsAppConfig == other.WhatsAppConfig ||
                    this.WhatsAppConfig != null &&
                    this.WhatsAppConfig.Equals(other.WhatsAppConfig)
                ) &&
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
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
                if (this.CampaignStatus != null)
                    hash = hash * 59 + this.CampaignStatus.GetHashCode();

                if (this.CallableTimeSet != null)
                    hash = hash * 59 + this.CallableTimeSet.GetHashCode();

                if (this.ContactList != null)
                    hash = hash * 59 + this.ContactList.GetHashCode();

                if (this.DncLists != null)
                    hash = hash * 59 + this.DncLists.GetHashCode();

                if (this.ContactListFilters != null)
                    hash = hash * 59 + this.ContactListFilters.GetHashCode();

                if (this.AlwaysRunning != null)
                    hash = hash * 59 + this.AlwaysRunning.GetHashCode();

                if (this.ContactSorts != null)
                    hash = hash * 59 + this.ContactSorts.GetHashCode();

                if (this.MessagesPerMinute != null)
                    hash = hash * 59 + this.MessagesPerMinute.GetHashCode();

                if (this.RuleSets != null)
                    hash = hash * 59 + this.RuleSets.GetHashCode();

                if (this.SmsConfig != null)
                    hash = hash * 59 + this.SmsConfig.GetHashCode();

                if (this.EmailConfig != null)
                    hash = hash * 59 + this.EmailConfig.GetHashCode();

                if (this.WhatsAppConfig != null)
                    hash = hash * 59 + this.WhatsAppConfig.GetHashCode();

                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                return hash;
            }
        }
    }

}
