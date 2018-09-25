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
    /// UnscheduledAgentWarning
    /// </summary>
    [DataContract]
    public partial class UnscheduledAgentWarning :  IEquatable<UnscheduledAgentWarning>
    {
        
        
        
        
        
        /// <summary>
        /// The reason this agent was not scheduled
        /// </summary>
        /// <value>The reason this agent was not scheduled</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UnscheduledReasonEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Noworkplan for "NoWorkPlan"
            /// </summary>
            [EnumMember(Value = "NoWorkPlan")]
            Noworkplan,
            
            /// <summary>
            /// Enum Workplannotfound for "WorkPlanNotFound"
            /// </summary>
            [EnumMember(Value = "WorkPlanNotFound")]
            Workplannotfound,
            
            /// <summary>
            /// Enum Unabletoproduceschedule for "UnableToProduceSchedule"
            /// </summary>
            [EnumMember(Value = "UnableToProduceSchedule")]
            Unabletoproduceschedule
        }
        
        
        
        
        
        
        
        /// <summary>
        /// The reason this agent was not scheduled
        /// </summary>
        /// <value>The reason this agent was not scheduled</value>
        [DataMember(Name="unscheduledReason", EmitDefaultValue=false)]
        public UnscheduledReasonEnum? UnscheduledReason { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UnscheduledAgentWarning" /> class.
        /// </summary>
        /// <param name="Agent">The agent for which this warning applies.</param>
        /// <param name="UnscheduledReason">The reason this agent was not scheduled.</param>
        public UnscheduledAgentWarning(UserReference Agent = null, UnscheduledReasonEnum? UnscheduledReason = null)
        {
            this.Agent = Agent;
            this.UnscheduledReason = UnscheduledReason;
            
        }
        
        
        
        /// <summary>
        /// The agent for which this warning applies
        /// </summary>
        /// <value>The agent for which this warning applies</value>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public UserReference Agent { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnscheduledAgentWarning {\n");
            
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  UnscheduledReason: ").Append(UnscheduledReason).Append("\n");
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
            return this.Equals(obj as UnscheduledAgentWarning);
        }

        /// <summary>
        /// Returns true if UnscheduledAgentWarning instances are equal
        /// </summary>
        /// <param name="other">Instance of UnscheduledAgentWarning to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnscheduledAgentWarning other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Agent == other.Agent ||
                    this.Agent != null &&
                    this.Agent.Equals(other.Agent)
                ) &&
                (
                    this.UnscheduledReason == other.UnscheduledReason ||
                    this.UnscheduledReason != null &&
                    this.UnscheduledReason.Equals(other.UnscheduledReason)
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
                
                if (this.Agent != null)
                    hash = hash * 59 + this.Agent.GetHashCode();
                
                if (this.UnscheduledReason != null)
                    hash = hash * 59 + this.UnscheduledReason.GetHashCode();
                
                return hash;
            }
        }
    }

}
