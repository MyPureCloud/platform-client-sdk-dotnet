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
            /// Enum On for "ON"
            /// </summary>
            [EnumMember(Value = "ON")]
            On,
            
            /// <summary>
            /// Enum Off for "OFF"
            /// </summary>
            [EnumMember(Value = "OFF")]
            Off,
            
            /// <summary>
            /// Enum Complete for "COMPLETE"
            /// </summary>
            [EnumMember(Value = "COMPLETE")]
            Complete,
            
            /// <summary>
            /// Enum Stopping for "STOPPING"
            /// </summary>
            [EnumMember(Value = "STOPPING")]
            Stopping,
            
            /// <summary>
            /// Enum Invalid for "INVALID"
            /// </summary>
            [EnumMember(Value = "INVALID")]
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
        /// <param name="Id">Id.</param>
        /// <param name="Division">Division.</param>
        /// <param name="Name">Name.</param>
        /// <param name="DateCreated">DateCreated.</param>
        /// <param name="DateModified">DateModified.</param>
        /// <param name="Version">Version.</param>
        /// <param name="CampaignStatus">CampaignStatus.</param>
        /// <param name="CallableTimeSet">CallableTimeSet.</param>
        /// <param name="ContactList">ContactList.</param>
        /// <param name="DncLists">DncLists.</param>
        /// <param name="ContactListFilters">ContactListFilters.</param>
        /// <param name="AlwaysRunning">AlwaysRunning.</param>
        /// <param name="ContactSorts">ContactSorts.</param>
        /// <param name="MessagesPerMinute">MessagesPerMinute.</param>
        /// <param name="SmsConfig">SmsConfig.</param>
        /// <param name="Errors">Errors.</param>
        public OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign(string Id = null, OutboundMessagingMessagingCampaignConfigChangeUriReference Division = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, int? Version = null, CampaignStatusEnum? CampaignStatus = null, OutboundMessagingMessagingCampaignConfigChangeUriReference CallableTimeSet = null, OutboundMessagingMessagingCampaignConfigChangeUriReference ContactList = null, List<OutboundMessagingMessagingCampaignConfigChangeUriReference> DncLists = null, List<OutboundMessagingMessagingCampaignConfigChangeUriReference> ContactListFilters = null, bool? AlwaysRunning = null, List<OutboundMessagingMessagingCampaignConfigChangeContactSort> ContactSorts = null, int? MessagesPerMinute = null, OutboundMessagingMessagingCampaignConfigChangeSmsConfig SmsConfig = null, List<OutboundMessagingMessagingCampaignConfigChangeErrorDetail> Errors = null)
        {
            this.Id = Id;
            this.Division = Division;
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Version = Version;
            this.CampaignStatus = CampaignStatus;
            this.CallableTimeSet = CallableTimeSet;
            this.ContactList = ContactList;
            this.DncLists = DncLists;
            this.ContactListFilters = ContactListFilters;
            this.AlwaysRunning = AlwaysRunning;
            this.ContactSorts = ContactSorts;
            this.MessagesPerMinute = MessagesPerMinute;
            this.SmsConfig = SmsConfig;
            this.Errors = Errors;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public OutboundMessagingMessagingCampaignConfigChangeUriReference Division { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateModified
        /// </summary>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets CallableTimeSet
        /// </summary>
        [DataMember(Name="callableTimeSet", EmitDefaultValue=false)]
        public OutboundMessagingMessagingCampaignConfigChangeUriReference CallableTimeSet { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ContactList
        /// </summary>
        [DataMember(Name="contactList", EmitDefaultValue=false)]
        public OutboundMessagingMessagingCampaignConfigChangeUriReference ContactList { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DncLists
        /// </summary>
        [DataMember(Name="dncLists", EmitDefaultValue=false)]
        public List<OutboundMessagingMessagingCampaignConfigChangeUriReference> DncLists { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ContactListFilters
        /// </summary>
        [DataMember(Name="contactListFilters", EmitDefaultValue=false)]
        public List<OutboundMessagingMessagingCampaignConfigChangeUriReference> ContactListFilters { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AlwaysRunning
        /// </summary>
        [DataMember(Name="alwaysRunning", EmitDefaultValue=false)]
        public bool? AlwaysRunning { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ContactSorts
        /// </summary>
        [DataMember(Name="contactSorts", EmitDefaultValue=false)]
        public List<OutboundMessagingMessagingCampaignConfigChangeContactSort> ContactSorts { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MessagesPerMinute
        /// </summary>
        [DataMember(Name="messagesPerMinute", EmitDefaultValue=false)]
        public int? MessagesPerMinute { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SmsConfig
        /// </summary>
        [DataMember(Name="smsConfig", EmitDefaultValue=false)]
        public OutboundMessagingMessagingCampaignConfigChangeSmsConfig SmsConfig { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<OutboundMessagingMessagingCampaignConfigChangeErrorDetail> Errors { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  CampaignStatus: ").Append(CampaignStatus).Append("\n");
            sb.Append("  CallableTimeSet: ").Append(CallableTimeSet).Append("\n");
            sb.Append("  ContactList: ").Append(ContactList).Append("\n");
            sb.Append("  DncLists: ").Append(DncLists).Append("\n");
            sb.Append("  ContactListFilters: ").Append(ContactListFilters).Append("\n");
            sb.Append("  AlwaysRunning: ").Append(AlwaysRunning).Append("\n");
            sb.Append("  ContactSorts: ").Append(ContactSorts).Append("\n");
            sb.Append("  MessagesPerMinute: ").Append(MessagesPerMinute).Append("\n");
            sb.Append("  SmsConfig: ").Append(SmsConfig).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
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
                    this.SmsConfig == other.SmsConfig ||
                    this.SmsConfig != null &&
                    this.SmsConfig.Equals(other.SmsConfig)
                ) &&
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
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
                
                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
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
                
                if (this.SmsConfig != null)
                    hash = hash * 59 + this.SmsConfig.GetHashCode();
                
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                
                return hash;
            }
        }
    }

}
