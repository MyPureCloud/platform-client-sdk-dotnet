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
    /// CampaignSequence
    /// </summary>
    [DataContract]
    public partial class CampaignSequence :  IEquatable<CampaignSequence>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The current status of the CampaignSequence. A CampaignSequence can be turned 'on' or 'off'.
        /// </summary>
        /// <value>The current status of the CampaignSequence. A CampaignSequence can be turned 'on' or 'off'.</value>
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
        /// The current status of the CampaignSequence. A CampaignSequence can be turned 'on' or 'off'.
        /// </summary>
        /// <value>The current status of the CampaignSequence. A CampaignSequence can be turned 'on' or 'off'.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSequence" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignSequence() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSequence" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        /// <param name="Campaigns">The ordered list of Campaigns that this CampaignSequence will run. (required).</param>
        /// <param name="Status">The current status of the CampaignSequence. A CampaignSequence can be turned &#39;on&#39; or &#39;off&#39;. (required).</param>
        /// <param name="Repeat">Indicates if a sequence should repeat from the beginning after the last campaign completes. Default is false..</param>
        public CampaignSequence(string Name = null, int? Version = null, List<UriReference> Campaigns = null, StatusEnum? Status = null, bool? Repeat = null)
        {
            this.Name = Name;
            this.Version = Version;
            this.Repeat = Repeat;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
        
        
        
        /// <summary>
        /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }
        
        
        
        /// <summary>
        /// Required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>Required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// The ordered list of Campaigns that this CampaignSequence will run.
        /// </summary>
        /// <value>The ordered list of Campaigns that this CampaignSequence will run.</value>
        [DataMember(Name="campaigns", EmitDefaultValue=false)]
        public List<UriReference> Campaigns { get; set; }
        
        
        
        /// <summary>
        /// A zero-based index indicating which Campaign this CampaignSequence is currently on.
        /// </summary>
        /// <value>A zero-based index indicating which Campaign this CampaignSequence is currently on.</value>
        [DataMember(Name="currentCampaign", EmitDefaultValue=false)]
        public int? CurrentCampaign { get; private set; }
        
        
        
        
        
        /// <summary>
        /// A message indicating if and why a CampaignSequence has stopped unexpectedly.
        /// </summary>
        /// <value>A message indicating if and why a CampaignSequence has stopped unexpectedly.</value>
        [DataMember(Name="stopMessage", EmitDefaultValue=false)]
        public string StopMessage { get; private set; }
        
        
        
        /// <summary>
        /// Indicates if a sequence should repeat from the beginning after the last campaign completes. Default is false.
        /// </summary>
        /// <value>Indicates if a sequence should repeat from the beginning after the last campaign completes. Default is false.</value>
        [DataMember(Name="repeat", EmitDefaultValue=false)]
        public bool? Repeat { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignSequence {\n");
            
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
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as CampaignSequence);
        }

        /// <summary>
        /// Returns true if CampaignSequence instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignSequence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignSequence other)
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
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
