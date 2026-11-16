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
    /// AgentStateWorkitemAssignmentStateCount
    /// </summary>
    [DataContract]
    public partial class AgentStateWorkitemAssignmentStateCount :  IEquatable<AgentStateWorkitemAssignmentStateCount>
    {
        /// <summary>
        /// Workitem assignment state
        /// </summary>
        /// <value>Workitem assignment state</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AssignmentStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Acdstarted for "AcdStarted"
            /// </summary>
            [EnumMember(Value = "AcdStarted")]
            Acdstarted,
            
            /// <summary>
            /// Enum Alerting for "Alerting"
            /// </summary>
            [EnumMember(Value = "Alerting")]
            Alerting,
            
            /// <summary>
            /// Enum Alerttimeout for "AlertTimeout"
            /// </summary>
            [EnumMember(Value = "AlertTimeout")]
            Alerttimeout,
            
            /// <summary>
            /// Enum Acdcancelled for "AcdCancelled"
            /// </summary>
            [EnumMember(Value = "AcdCancelled")]
            Acdcancelled,
            
            /// <summary>
            /// Enum Terminated for "Terminated"
            /// </summary>
            [EnumMember(Value = "Terminated")]
            Terminated,
            
            /// <summary>
            /// Enum Idle for "Idle"
            /// </summary>
            [EnumMember(Value = "Idle")]
            Idle,
            
            /// <summary>
            /// Enum Declined for "Declined"
            /// </summary>
            [EnumMember(Value = "Declined")]
            Declined,
            
            /// <summary>
            /// Enum Connected for "Connected"
            /// </summary>
            [EnumMember(Value = "Connected")]
            Connected,
            
            /// <summary>
            /// Enum Disconnected for "Disconnected"
            /// </summary>
            [EnumMember(Value = "Disconnected")]
            Disconnected,
            
            /// <summary>
            /// Enum Parked for "Parked"
            /// </summary>
            [EnumMember(Value = "Parked")]
            Parked,
            
            /// <summary>
            /// Enum Held for "Held"
            /// </summary>
            [EnumMember(Value = "Held")]
            Held,
            
            /// <summary>
            /// Enum Acdexpired for "AcdExpired"
            /// </summary>
            [EnumMember(Value = "AcdExpired")]
            Acdexpired
        }
        /// <summary>
        /// Workitem assignment state
        /// </summary>
        /// <value>Workitem assignment state</value>
        [DataMember(Name="assignmentState", EmitDefaultValue=false)]
        public AssignmentStateEnum? AssignmentState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStateWorkitemAssignmentStateCount" /> class.
        /// </summary>
        /// <param name="AssignmentState">Workitem assignment state.</param>
        /// <param name="Count">Count of workitems with this assignment state.</param>
        public AgentStateWorkitemAssignmentStateCount(AssignmentStateEnum? AssignmentState = null, int? Count = null)
        {
            this.AssignmentState = AssignmentState;
            this.Count = Count;
            
        }
        




        /// <summary>
        /// Count of workitems with this assignment state
        /// </summary>
        /// <value>Count of workitems with this assignment state</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentStateWorkitemAssignmentStateCount {\n");

            sb.Append("  AssignmentState: ").Append(AssignmentState).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as AgentStateWorkitemAssignmentStateCount);
        }

        /// <summary>
        /// Returns true if AgentStateWorkitemAssignmentStateCount instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentStateWorkitemAssignmentStateCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentStateWorkitemAssignmentStateCount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AssignmentState == other.AssignmentState ||
                    this.AssignmentState != null &&
                    this.AssignmentState.Equals(other.AssignmentState)
                ) &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                if (this.AssignmentState != null)
                    hash = hash * 59 + this.AssignmentState.GetHashCode();

                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                return hash;
            }
        }
    }

}
