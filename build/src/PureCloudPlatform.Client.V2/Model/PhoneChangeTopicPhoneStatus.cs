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
    /// PhoneChangeTopicPhoneStatus
    /// </summary>
    [DataContract]
    public partial class PhoneChangeTopicPhoneStatus :  IEquatable<PhoneChangeTopicPhoneStatus>
    {
        
        
        
        
        
        /// <summary>
        /// Gets or Sets OperationalStatus
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperationalStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Operational for "OPERATIONAL"
            /// </summary>
            [EnumMember(Value = "OPERATIONAL")]
            Operational,
            
            /// <summary>
            /// Enum Degraded for "DEGRADED"
            /// </summary>
            [EnumMember(Value = "DEGRADED")]
            Degraded,
            
            /// <summary>
            /// Enum Offline for "OFFLINE"
            /// </summary>
            [EnumMember(Value = "OFFLINE")]
            Offline
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets OperationalStatus
        /// </summary>
        [DataMember(Name="operationalStatus", EmitDefaultValue=false)]
        public OperationalStatusEnum? OperationalStatus { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneChangeTopicPhoneStatus" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="OperationalStatus">OperationalStatus.</param>
        /// <param name="Edge">Edge.</param>
        /// <param name="Provision">Provision.</param>
        /// <param name="LineStatuses">LineStatuses.</param>
        public PhoneChangeTopicPhoneStatus(string Id = null, OperationalStatusEnum? OperationalStatus = null, PhoneChangeTopicEdgeReference Edge = null, PhoneChangeTopicProvisionInfo Provision = null, List<PhoneChangeTopicLineStatus> LineStatuses = null)
        {
            this.Id = Id;
            this.OperationalStatus = OperationalStatus;
            this.Edge = Edge;
            this.Provision = Provision;
            this.LineStatuses = LineStatuses;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Edge
        /// </summary>
        [DataMember(Name="edge", EmitDefaultValue=false)]
        public PhoneChangeTopicEdgeReference Edge { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Provision
        /// </summary>
        [DataMember(Name="provision", EmitDefaultValue=false)]
        public PhoneChangeTopicProvisionInfo Provision { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets LineStatuses
        /// </summary>
        [DataMember(Name="lineStatuses", EmitDefaultValue=false)]
        public List<PhoneChangeTopicLineStatus> LineStatuses { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneChangeTopicPhoneStatus {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OperationalStatus: ").Append(OperationalStatus).Append("\n");
            sb.Append("  Edge: ").Append(Edge).Append("\n");
            sb.Append("  Provision: ").Append(Provision).Append("\n");
            sb.Append("  LineStatuses: ").Append(LineStatuses).Append("\n");
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
            return this.Equals(obj as PhoneChangeTopicPhoneStatus);
        }

        /// <summary>
        /// Returns true if PhoneChangeTopicPhoneStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of PhoneChangeTopicPhoneStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneChangeTopicPhoneStatus other)
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
                    this.OperationalStatus == other.OperationalStatus ||
                    this.OperationalStatus != null &&
                    this.OperationalStatus.Equals(other.OperationalStatus)
                ) &&
                (
                    this.Edge == other.Edge ||
                    this.Edge != null &&
                    this.Edge.Equals(other.Edge)
                ) &&
                (
                    this.Provision == other.Provision ||
                    this.Provision != null &&
                    this.Provision.Equals(other.Provision)
                ) &&
                (
                    this.LineStatuses == other.LineStatuses ||
                    this.LineStatuses != null &&
                    this.LineStatuses.SequenceEqual(other.LineStatuses)
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
                
                if (this.OperationalStatus != null)
                    hash = hash * 59 + this.OperationalStatus.GetHashCode();
                
                if (this.Edge != null)
                    hash = hash * 59 + this.Edge.GetHashCode();
                
                if (this.Provision != null)
                    hash = hash * 59 + this.Provision.GetHashCode();
                
                if (this.LineStatuses != null)
                    hash = hash * 59 + this.LineStatuses.GetHashCode();
                
                return hash;
            }
        }
    }

}
