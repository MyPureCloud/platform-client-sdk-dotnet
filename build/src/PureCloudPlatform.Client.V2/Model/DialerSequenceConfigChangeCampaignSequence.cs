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
        /// <param name="Campaigns">the ordered list of campaign identifiers.</param>
        /// <param name="CurrentCampaign">the zero-based index of the current campaign in the campaigns list.</param>
        /// <param name="Status">Status.</param>
        /// <param name="StopMessage">if a sequence has unexpectedly stopped, this message provides the reason.</param>
        /// <param name="Repeat">indicates if a sequence is to repeat from the beginning after the last campaign completes; default is false.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="Name">The UI-visible name of the object.</param>
        /// <param name="DateCreated">Creation time of the entity.</param>
        /// <param name="DateModified">Last modified time of the entity.</param>
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        public DialerSequenceConfigChangeCampaignSequence(List<DialerSequenceConfigChangeUriReference> Campaigns = null, int? CurrentCampaign = null, StatusEnum? Status = null, string StopMessage = null, bool? Repeat = null, Dictionary<string, Object> AdditionalProperties = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, int? Version = null)
        {
            this.Campaigns = Campaigns;
            this.CurrentCampaign = CurrentCampaign;
            this.Status = Status;
            this.StopMessage = StopMessage;
            this.Repeat = Repeat;
            this.AdditionalProperties = AdditionalProperties;
            this.Id = Id;
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Version = Version;
            
        }
        


        /// <summary>
        /// the ordered list of campaign identifiers
        /// </summary>
        /// <value>the ordered list of campaign identifiers</value>
        [DataMember(Name="campaigns", EmitDefaultValue=false)]
        public List<DialerSequenceConfigChangeUriReference> Campaigns { get; set; }



        /// <summary>
        /// the zero-based index of the current campaign in the campaigns list
        /// </summary>
        /// <value>the zero-based index of the current campaign in the campaigns list</value>
        [DataMember(Name="currentCampaign", EmitDefaultValue=false)]
        public int? CurrentCampaign { get; set; }





        /// <summary>
        /// if a sequence has unexpectedly stopped, this message provides the reason
        /// </summary>
        /// <value>if a sequence has unexpectedly stopped, this message provides the reason</value>
        [DataMember(Name="stopMessage", EmitDefaultValue=false)]
        public string StopMessage { get; set; }



        /// <summary>
        /// indicates if a sequence is to repeat from the beginning after the last campaign completes; default is false
        /// </summary>
        /// <value>indicates if a sequence is to repeat from the beginning after the last campaign completes; default is false</value>
        [DataMember(Name="repeat", EmitDefaultValue=false)]
        public bool? Repeat { get; set; }



        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, Object> AdditionalProperties { get; set; }



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
        public int? Version { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerSequenceConfigChangeCampaignSequence {\n");

            sb.Append("  Campaigns: ").Append(Campaigns).Append("\n");
            sb.Append("  CurrentCampaign: ").Append(CurrentCampaign).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StopMessage: ").Append(StopMessage).Append("\n");
            sb.Append("  Repeat: ").Append(Repeat).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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

                return hash;
            }
        }
    }

}
