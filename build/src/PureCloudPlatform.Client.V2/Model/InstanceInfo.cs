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
    /// InstanceInfo
    /// </summary>
    [DataContract]
    public partial class InstanceInfo :  IEquatable<InstanceInfo>
    {
        
        
        
        
        
        /// <summary>
        /// State of the instance in AWS
        /// </summary>
        /// <value>State of the instance in AWS</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Rebooting for "rebooting"
            /// </summary>
            [EnumMember(Value = "rebooting")]
            Rebooting,
            
            /// <summary>
            /// Enum Pending for "pending"
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending,
            
            /// <summary>
            /// Enum Running for "running"
            /// </summary>
            [EnumMember(Value = "running")]
            Running,
            
            /// <summary>
            /// Enum Terminated for "terminated"
            /// </summary>
            [EnumMember(Value = "terminated")]
            Terminated,
            
            /// <summary>
            /// Enum Stopping for "stopping"
            /// </summary>
            [EnumMember(Value = "stopping")]
            Stopping,
            
            /// <summary>
            /// Enum Stopped for "stopped"
            /// </summary>
            [EnumMember(Value = "stopped")]
            Stopped
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// State of the instance in AWS
        /// </summary>
        /// <value>State of the instance in AWS</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceInfo" /> class.
        /// </summary>
        /// <param name="Id">Id of the ec2 instance..</param>
        /// <param name="State">State of the instance in AWS.</param>
        /// <param name="Edge">Edge object that the instance is associated with..</param>
        /// <param name="AssignedPhoneCount">Number of phones assigned to the edge..</param>
        /// <param name="Ami">The image id of the instance..</param>
        public InstanceInfo(string Id = null, StateEnum? State = null, Edge Edge = null, int? AssignedPhoneCount = null, string Ami = null)
        {
            this.Id = Id;
            this.State = State;
            this.Edge = Edge;
            this.AssignedPhoneCount = AssignedPhoneCount;
            this.Ami = Ami;
            
        }
        
        
        
        /// <summary>
        /// Id of the ec2 instance.
        /// </summary>
        /// <value>Id of the ec2 instance.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        
        
        /// <summary>
        /// Edge object that the instance is associated with.
        /// </summary>
        /// <value>Edge object that the instance is associated with.</value>
        [DataMember(Name="edge", EmitDefaultValue=false)]
        public Edge Edge { get; set; }
        
        
        
        /// <summary>
        /// Number of phones assigned to the edge.
        /// </summary>
        /// <value>Number of phones assigned to the edge.</value>
        [DataMember(Name="assignedPhoneCount", EmitDefaultValue=false)]
        public int? AssignedPhoneCount { get; set; }
        
        
        
        /// <summary>
        /// The image id of the instance.
        /// </summary>
        /// <value>The image id of the instance.</value>
        [DataMember(Name="ami", EmitDefaultValue=false)]
        public string Ami { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceInfo {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Edge: ").Append(Edge).Append("\n");
            sb.Append("  AssignedPhoneCount: ").Append(AssignedPhoneCount).Append("\n");
            sb.Append("  Ami: ").Append(Ami).Append("\n");
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
            return this.Equals(obj as InstanceInfo);
        }

        /// <summary>
        /// Returns true if InstanceInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of InstanceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstanceInfo other)
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
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Edge == other.Edge ||
                    this.Edge != null &&
                    this.Edge.Equals(other.Edge)
                ) &&
                (
                    this.AssignedPhoneCount == other.AssignedPhoneCount ||
                    this.AssignedPhoneCount != null &&
                    this.AssignedPhoneCount.Equals(other.AssignedPhoneCount)
                ) &&
                (
                    this.Ami == other.Ami ||
                    this.Ami != null &&
                    this.Ami.Equals(other.Ami)
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
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.Edge != null)
                    hash = hash * 59 + this.Edge.GetHashCode();
                
                if (this.AssignedPhoneCount != null)
                    hash = hash * 59 + this.AssignedPhoneCount.GetHashCode();
                
                if (this.Ami != null)
                    hash = hash * 59 + this.Ami.GetHashCode();
                
                return hash;
            }
        }
    }

}
