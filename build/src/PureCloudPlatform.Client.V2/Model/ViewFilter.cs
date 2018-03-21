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
    /// ViewFilter
    /// </summary>
    [DataContract]
    public partial class ViewFilter :  IEquatable<ViewFilter>
    {
        
        
        
        
        /// <summary>
        /// Gets or Sets MediaTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Voice for "voice"
            /// </summary>
            [EnumMember(Value = "voice")]
            Voice,
            
            /// <summary>
            /// Enum Chat for "chat"
            /// </summary>
            [EnumMember(Value = "chat")]
            Chat,
            
            /// <summary>
            /// Enum Email for "email"
            /// </summary>
            [EnumMember(Value = "email")]
            Email,
            
            /// <summary>
            /// Enum Callback for "callback"
            /// </summary>
            [EnumMember(Value = "callback")]
            Callback,
            
            /// <summary>
            /// Enum Cobrowse for "cobrowse"
            /// </summary>
            [EnumMember(Value = "cobrowse")]
            Cobrowse,
            
            /// <summary>
            /// Enum Video for "video"
            /// </summary>
            [EnumMember(Value = "video")]
            Video,
            
            /// <summary>
            /// Enum Screenshare for "screenshare"
            /// </summary>
            [EnumMember(Value = "screenshare")]
            Screenshare,
            
            /// <summary>
            /// Enum Message for "message"
            /// </summary>
            [EnumMember(Value = "message")]
            Message
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Directions
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DirectionsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Inbound for "inbound"
            /// </summary>
            [EnumMember(Value = "inbound")]
            Inbound,
            
            /// <summary>
            /// Enum Outbound for "outbound"
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewFilter" /> class.
        /// </summary>
        
        
        /// <param name="MediaTypes">The media types used to filter the data export request.</param>
        
        
        
        /// <param name="QueueIds">The queue ids used to filter the data export request.</param>
        
        
        
        /// <param name="SkillIds">The skill ids used to filter the data export request.</param>
        
        
        
        /// <param name="LanguageIds">The language ids used to filter the data export request.</param>
        
        
        
        /// <param name="Directions">The directions used to filter the data export request.</param>
        
        
        
        /// <param name="WrapUpCodes">The wrap up codes used to filter the data export request.</param>
        
        
        
        /// <param name="DnisList">The dnis list used to filter the data export request.</param>
        
        
        
        /// <param name="UserIds">The user ids used to filter the data export request.</param>
        
        
        
        /// <param name="AddressTos">The address To values used to filter the data export request.</param>
        
        
        
        /// <param name="OutboundCampaignIds">The outbound campaign ids used to filter the data export request.</param>
        
        
        
        /// <param name="OutboundContactListIds">The outbound contact list ids used to filter the data export request.</param>
        
        
        public ViewFilter(List<MediaTypesEnum> MediaTypes = null, List<Guid?> QueueIds = null, List<Guid?> SkillIds = null, List<Guid?> LanguageIds = null, List<DirectionsEnum> Directions = null, List<string> WrapUpCodes = null, List<string> DnisList = null, List<Guid?> UserIds = null, List<string> AddressTos = null, List<Guid?> OutboundCampaignIds = null, List<Guid?> OutboundContactListIds = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.MediaTypes = MediaTypes;
            
            
            
            
            
            
            
            
this.QueueIds = QueueIds;
            
            
            
            
            
            
            
            
this.SkillIds = SkillIds;
            
            
            
            
            
            
            
            
this.LanguageIds = LanguageIds;
            
            
            
            
            
            
            
            
this.Directions = Directions;
            
            
            
            
            
            
            
            
this.WrapUpCodes = WrapUpCodes;
            
            
            
            
            
            
            
            
this.DnisList = DnisList;
            
            
            
            
            
            
            
            
this.UserIds = UserIds;
            
            
            
            
            
            
            
            
this.AddressTos = AddressTos;
            
            
            
            
            
            
            
            
this.OutboundCampaignIds = OutboundCampaignIds;
            
            
            
            
            
            
            
            
this.OutboundContactListIds = OutboundContactListIds;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The media types used to filter the data export request
        /// </summary>
        /// <value>The media types used to filter the data export request</value>
        [DataMember(Name="mediaTypes", EmitDefaultValue=false)]
        public List<MediaTypesEnum> MediaTypes { get; set; }
        
        
        
        /// <summary>
        /// The queue ids used to filter the data export request
        /// </summary>
        /// <value>The queue ids used to filter the data export request</value>
        [DataMember(Name="queueIds", EmitDefaultValue=false)]
        public List<Guid?> QueueIds { get; set; }
        
        
        
        /// <summary>
        /// The skill ids used to filter the data export request
        /// </summary>
        /// <value>The skill ids used to filter the data export request</value>
        [DataMember(Name="skillIds", EmitDefaultValue=false)]
        public List<Guid?> SkillIds { get; set; }
        
        
        
        /// <summary>
        /// The language ids used to filter the data export request
        /// </summary>
        /// <value>The language ids used to filter the data export request</value>
        [DataMember(Name="languageIds", EmitDefaultValue=false)]
        public List<Guid?> LanguageIds { get; set; }
        
        
        
        /// <summary>
        /// The directions used to filter the data export request
        /// </summary>
        /// <value>The directions used to filter the data export request</value>
        [DataMember(Name="directions", EmitDefaultValue=false)]
        public List<DirectionsEnum> Directions { get; set; }
        
        
        
        /// <summary>
        /// The wrap up codes used to filter the data export request
        /// </summary>
        /// <value>The wrap up codes used to filter the data export request</value>
        [DataMember(Name="wrapUpCodes", EmitDefaultValue=false)]
        public List<string> WrapUpCodes { get; set; }
        
        
        
        /// <summary>
        /// The dnis list used to filter the data export request
        /// </summary>
        /// <value>The dnis list used to filter the data export request</value>
        [DataMember(Name="dnisList", EmitDefaultValue=false)]
        public List<string> DnisList { get; set; }
        
        
        
        /// <summary>
        /// The user ids used to filter the data export request
        /// </summary>
        /// <value>The user ids used to filter the data export request</value>
        [DataMember(Name="userIds", EmitDefaultValue=false)]
        public List<Guid?> UserIds { get; set; }
        
        
        
        /// <summary>
        /// The address To values used to filter the data export request
        /// </summary>
        /// <value>The address To values used to filter the data export request</value>
        [DataMember(Name="addressTos", EmitDefaultValue=false)]
        public List<string> AddressTos { get; set; }
        
        
        
        /// <summary>
        /// The outbound campaign ids used to filter the data export request
        /// </summary>
        /// <value>The outbound campaign ids used to filter the data export request</value>
        [DataMember(Name="outboundCampaignIds", EmitDefaultValue=false)]
        public List<Guid?> OutboundCampaignIds { get; set; }
        
        
        
        /// <summary>
        /// The outbound contact list ids used to filter the data export request
        /// </summary>
        /// <value>The outbound contact list ids used to filter the data export request</value>
        [DataMember(Name="outboundContactListIds", EmitDefaultValue=false)]
        public List<Guid?> OutboundContactListIds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViewFilter {\n");
            
            sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
            
            sb.Append("  QueueIds: ").Append(QueueIds).Append("\n");
            
            sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
            
            sb.Append("  LanguageIds: ").Append(LanguageIds).Append("\n");
            
            sb.Append("  Directions: ").Append(Directions).Append("\n");
            
            sb.Append("  WrapUpCodes: ").Append(WrapUpCodes).Append("\n");
            
            sb.Append("  DnisList: ").Append(DnisList).Append("\n");
            
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
            
            sb.Append("  AddressTos: ").Append(AddressTos).Append("\n");
            
            sb.Append("  OutboundCampaignIds: ").Append(OutboundCampaignIds).Append("\n");
            
            sb.Append("  OutboundContactListIds: ").Append(OutboundContactListIds).Append("\n");
            
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
            return this.Equals(obj as ViewFilter);
        }

        /// <summary>
        /// Returns true if ViewFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of ViewFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MediaTypes == other.MediaTypes ||
                    this.MediaTypes != null &&
                    this.MediaTypes.SequenceEqual(other.MediaTypes)
                ) &&
                (
                    this.QueueIds == other.QueueIds ||
                    this.QueueIds != null &&
                    this.QueueIds.SequenceEqual(other.QueueIds)
                ) &&
                (
                    this.SkillIds == other.SkillIds ||
                    this.SkillIds != null &&
                    this.SkillIds.SequenceEqual(other.SkillIds)
                ) &&
                (
                    this.LanguageIds == other.LanguageIds ||
                    this.LanguageIds != null &&
                    this.LanguageIds.SequenceEqual(other.LanguageIds)
                ) &&
                (
                    this.Directions == other.Directions ||
                    this.Directions != null &&
                    this.Directions.SequenceEqual(other.Directions)
                ) &&
                (
                    this.WrapUpCodes == other.WrapUpCodes ||
                    this.WrapUpCodes != null &&
                    this.WrapUpCodes.SequenceEqual(other.WrapUpCodes)
                ) &&
                (
                    this.DnisList == other.DnisList ||
                    this.DnisList != null &&
                    this.DnisList.SequenceEqual(other.DnisList)
                ) &&
                (
                    this.UserIds == other.UserIds ||
                    this.UserIds != null &&
                    this.UserIds.SequenceEqual(other.UserIds)
                ) &&
                (
                    this.AddressTos == other.AddressTos ||
                    this.AddressTos != null &&
                    this.AddressTos.SequenceEqual(other.AddressTos)
                ) &&
                (
                    this.OutboundCampaignIds == other.OutboundCampaignIds ||
                    this.OutboundCampaignIds != null &&
                    this.OutboundCampaignIds.SequenceEqual(other.OutboundCampaignIds)
                ) &&
                (
                    this.OutboundContactListIds == other.OutboundContactListIds ||
                    this.OutboundContactListIds != null &&
                    this.OutboundContactListIds.SequenceEqual(other.OutboundContactListIds)
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
                
                if (this.MediaTypes != null)
                    hash = hash * 59 + this.MediaTypes.GetHashCode();
                
                if (this.QueueIds != null)
                    hash = hash * 59 + this.QueueIds.GetHashCode();
                
                if (this.SkillIds != null)
                    hash = hash * 59 + this.SkillIds.GetHashCode();
                
                if (this.LanguageIds != null)
                    hash = hash * 59 + this.LanguageIds.GetHashCode();
                
                if (this.Directions != null)
                    hash = hash * 59 + this.Directions.GetHashCode();
                
                if (this.WrapUpCodes != null)
                    hash = hash * 59 + this.WrapUpCodes.GetHashCode();
                
                if (this.DnisList != null)
                    hash = hash * 59 + this.DnisList.GetHashCode();
                
                if (this.UserIds != null)
                    hash = hash * 59 + this.UserIds.GetHashCode();
                
                if (this.AddressTos != null)
                    hash = hash * 59 + this.AddressTos.GetHashCode();
                
                if (this.OutboundCampaignIds != null)
                    hash = hash * 59 + this.OutboundCampaignIds.GetHashCode();
                
                if (this.OutboundContactListIds != null)
                    hash = hash * 59 + this.OutboundContactListIds.GetHashCode();
                
                return hash;
            }
        }
    }

}
