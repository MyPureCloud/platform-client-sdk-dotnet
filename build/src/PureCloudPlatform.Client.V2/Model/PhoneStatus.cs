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
    /// PhoneStatus
    /// </summary>
    [DataContract]
    public partial class PhoneStatus :  IEquatable<PhoneStatus>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// The Operational Status of this phone
        /// </summary>
        /// <value>The Operational Status of this phone</value>
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
        /// The status of the primary or secondary Edges assigned to the phone lines.
        /// </summary>
        /// <value>The status of the primary or secondary Edges assigned to the phone lines.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EdgesStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum InService for "IN_SERVICE"
            /// </summary>
            [EnumMember(Value = "IN_SERVICE")]
            InService,
            
            /// <summary>
            /// Enum MixedService for "MIXED_SERVICE"
            /// </summary>
            [EnumMember(Value = "MIXED_SERVICE")]
            MixedService,
            
            /// <summary>
            /// Enum OutOfService for "OUT_OF_SERVICE"
            /// </summary>
            [EnumMember(Value = "OUT_OF_SERVICE")]
            OutOfService,
            
            /// <summary>
            /// Enum NoEdges for "NO_EDGES"
            /// </summary>
            [EnumMember(Value = "NO_EDGES")]
            NoEdges
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The phone status's edge assignment type.
        /// </summary>
        /// <value>The phone status's edge assignment type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PhoneAssignmentToEdgeTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Primary for "PRIMARY"
            /// </summary>
            [EnumMember(Value = "PRIMARY")]
            Primary,
            
            /// <summary>
            /// Enum Secondary for "SECONDARY"
            /// </summary>
            [EnumMember(Value = "SECONDARY")]
            Secondary
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The Operational Status of this phone
        /// </summary>
        /// <value>The Operational Status of this phone</value>
        [DataMember(Name="operationalStatus", EmitDefaultValue=false)]
        public OperationalStatusEnum? OperationalStatus { get; set; }
        
        
        
        /// <summary>
        /// The status of the primary or secondary Edges assigned to the phone lines.
        /// </summary>
        /// <value>The status of the primary or secondary Edges assigned to the phone lines.</value>
        [DataMember(Name="edgesStatus", EmitDefaultValue=false)]
        public EdgesStatusEnum? EdgesStatus { get; set; }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The phone status's edge assignment type.
        /// </summary>
        /// <value>The phone status's edge assignment type.</value>
        [DataMember(Name="phoneAssignmentToEdgeType", EmitDefaultValue=false)]
        public PhoneAssignmentToEdgeTypeEnum? PhoneAssignmentToEdgeType { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneStatus" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="OperationalStatus">The Operational Status of this phone.</param>
        /// <param name="EdgesStatus">The status of the primary or secondary Edges assigned to the phone lines..</param>
        /// <param name="EventCreationTime">Event Creation Time represents an ISO-8601 string. For example: UTC, UTC+01:00, or Europe/London.</param>
        /// <param name="Provision">Provision information for this phone.</param>
        /// <param name="LineStatuses">A list of LineStatus information for each of the lines of this phone.</param>
        /// <param name="PhoneAssignmentToEdgeType">The phone status&#39;s edge assignment type..</param>
        /// <param name="Edge">The URI of the edge that provided this status information..</param>
        public PhoneStatus(string Name = null, OperationalStatusEnum? OperationalStatus = null, EdgesStatusEnum? EdgesStatus = null, string EventCreationTime = null, ProvisionInfo Provision = null, List<LineStatus> LineStatuses = null, PhoneAssignmentToEdgeTypeEnum? PhoneAssignmentToEdgeType = null, DomainEntityRef Edge = null)
        {
            this.Name = Name;
            this.OperationalStatus = OperationalStatus;
            this.EdgesStatus = EdgesStatus;
            this.EventCreationTime = EventCreationTime;
            this.Provision = Provision;
            this.LineStatuses = LineStatuses;
            this.PhoneAssignmentToEdgeType = PhoneAssignmentToEdgeType;
            this.Edge = Edge;
            
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
        /// Event Creation Time represents an ISO-8601 string. For example: UTC, UTC+01:00, or Europe/London
        /// </summary>
        /// <value>Event Creation Time represents an ISO-8601 string. For example: UTC, UTC+01:00, or Europe/London</value>
        [DataMember(Name="eventCreationTime", EmitDefaultValue=false)]
        public string EventCreationTime { get; set; }
        
        
        
        /// <summary>
        /// Provision information for this phone
        /// </summary>
        /// <value>Provision information for this phone</value>
        [DataMember(Name="provision", EmitDefaultValue=false)]
        public ProvisionInfo Provision { get; set; }
        
        
        
        /// <summary>
        /// A list of LineStatus information for each of the lines of this phone
        /// </summary>
        /// <value>A list of LineStatus information for each of the lines of this phone</value>
        [DataMember(Name="lineStatuses", EmitDefaultValue=false)]
        public List<LineStatus> LineStatuses { get; set; }
        
        
        
        
        
        /// <summary>
        /// The URI of the edge that provided this status information.
        /// </summary>
        /// <value>The URI of the edge that provided this status information.</value>
        [DataMember(Name="edge", EmitDefaultValue=false)]
        public DomainEntityRef Edge { get; set; }
        
        
        
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
            sb.Append("class PhoneStatus {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OperationalStatus: ").Append(OperationalStatus).Append("\n");
            sb.Append("  EdgesStatus: ").Append(EdgesStatus).Append("\n");
            sb.Append("  EventCreationTime: ").Append(EventCreationTime).Append("\n");
            sb.Append("  Provision: ").Append(Provision).Append("\n");
            sb.Append("  LineStatuses: ").Append(LineStatuses).Append("\n");
            sb.Append("  PhoneAssignmentToEdgeType: ").Append(PhoneAssignmentToEdgeType).Append("\n");
            sb.Append("  Edge: ").Append(Edge).Append("\n");
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
            return this.Equals(obj as PhoneStatus);
        }

        /// <summary>
        /// Returns true if PhoneStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of PhoneStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneStatus other)
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
                    this.OperationalStatus == other.OperationalStatus ||
                    this.OperationalStatus != null &&
                    this.OperationalStatus.Equals(other.OperationalStatus)
                ) &&
                (
                    this.EdgesStatus == other.EdgesStatus ||
                    this.EdgesStatus != null &&
                    this.EdgesStatus.Equals(other.EdgesStatus)
                ) &&
                (
                    this.EventCreationTime == other.EventCreationTime ||
                    this.EventCreationTime != null &&
                    this.EventCreationTime.Equals(other.EventCreationTime)
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
                ) &&
                (
                    this.PhoneAssignmentToEdgeType == other.PhoneAssignmentToEdgeType ||
                    this.PhoneAssignmentToEdgeType != null &&
                    this.PhoneAssignmentToEdgeType.Equals(other.PhoneAssignmentToEdgeType)
                ) &&
                (
                    this.Edge == other.Edge ||
                    this.Edge != null &&
                    this.Edge.Equals(other.Edge)
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
                
                if (this.OperationalStatus != null)
                    hash = hash * 59 + this.OperationalStatus.GetHashCode();
                
                if (this.EdgesStatus != null)
                    hash = hash * 59 + this.EdgesStatus.GetHashCode();
                
                if (this.EventCreationTime != null)
                    hash = hash * 59 + this.EventCreationTime.GetHashCode();
                
                if (this.Provision != null)
                    hash = hash * 59 + this.Provision.GetHashCode();
                
                if (this.LineStatuses != null)
                    hash = hash * 59 + this.LineStatuses.GetHashCode();
                
                if (this.PhoneAssignmentToEdgeType != null)
                    hash = hash * 59 + this.PhoneAssignmentToEdgeType.GetHashCode();
                
                if (this.Edge != null)
                    hash = hash * 59 + this.Edge.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
