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
    /// DialerSequenceConfigChangeCampaignSequence
    /// </summary>
    [DataContract]
    public partial class DialerSequenceConfigChangeCampaignSequence :  IEquatable<DialerSequenceConfigChangeCampaignSequence>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
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
            Complete
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerSequenceConfigChangeCampaignSequence" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="DateCreated">DateCreated.</param>
        /// <param name="DateModified">DateModified.</param>
        /// <param name="Version">Version.</param>
        /// <param name="Campaigns">Campaigns.</param>
        /// <param name="CurrentCampaign">CurrentCampaign.</param>
        /// <param name="Status">Status.</param>
        /// <param name="StopMessage">StopMessage.</param>
        /// <param name="Repeat">Repeat.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public DialerSequenceConfigChangeCampaignSequence(string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, int? Version = null, List<DialerSequenceConfigChangeUriReference> Campaigns = null, int? CurrentCampaign = null, StatusEnum? Status = null, string StopMessage = null, bool? Repeat = null, Object AdditionalProperties = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Version = Version;
            this.Campaigns = Campaigns;
            this.CurrentCampaign = CurrentCampaign;
            this.Status = Status;
            this.StopMessage = StopMessage;
            this.Repeat = Repeat;
            this.AdditionalProperties = AdditionalProperties;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
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
        /// Gets or Sets Campaigns
        /// </summary>
        [DataMember(Name="campaigns", EmitDefaultValue=false)]
        public List<DialerSequenceConfigChangeUriReference> Campaigns { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CurrentCampaign
        /// </summary>
        [DataMember(Name="currentCampaign", EmitDefaultValue=false)]
        public int? CurrentCampaign { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets StopMessage
        /// </summary>
        [DataMember(Name="stopMessage", EmitDefaultValue=false)]
        public string StopMessage { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Repeat
        /// </summary>
        [DataMember(Name="repeat", EmitDefaultValue=false)]
        public bool? Repeat { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Object AdditionalProperties { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerSequenceConfigChangeCampaignSequence {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Campaigns: ").Append(Campaigns).Append("\n");
            sb.Append("  CurrentCampaign: ").Append(CurrentCampaign).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StopMessage: ").Append(StopMessage).Append("\n");
            sb.Append("  Repeat: ").Append(Repeat).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(obj as DialerSequenceConfigChangeCampaignSequence);
        }

        /// <summary>
        /// Returns true if DialerSequenceConfigChangeCampaignSequence instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerSequenceConfigChangeCampaignSequence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerSequenceConfigChangeCampaignSequence other)
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
                    this.Campaigns == other.Campaigns ||
                    this.Campaigns != null &&
                    this.Campaigns.SequenceEqual(other.Campaigns)
                ) &&
                (
                    this.CurrentCampaign == other.CurrentCampaign ||
                    this.CurrentCampaign != null &&
                    this.CurrentCampaign.Equals(other.CurrentCampaign)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.StopMessage == other.StopMessage ||
                    this.StopMessage != null &&
                    this.StopMessage.Equals(other.StopMessage)
                ) &&
                (
                    this.Repeat == other.Repeat ||
                    this.Repeat != null &&
                    this.Repeat.Equals(other.Repeat)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.Equals(other.AdditionalProperties)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.Campaigns != null)
                    hash = hash * 59 + this.Campaigns.GetHashCode();
                
                if (this.CurrentCampaign != null)
                    hash = hash * 59 + this.CurrentCampaign.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.StopMessage != null)
                    hash = hash * 59 + this.StopMessage.GetHashCode();
                
                if (this.Repeat != null)
                    hash = hash * 59 + this.Repeat.GetHashCode();
                
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                
                return hash;
            }
        }
    }

}
