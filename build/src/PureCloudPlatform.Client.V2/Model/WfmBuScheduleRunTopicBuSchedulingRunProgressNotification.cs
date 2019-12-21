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
    /// WfmBuScheduleRunTopicBuSchedulingRunProgressNotification
    /// </summary>
    [DataContract]
    public partial class WfmBuScheduleRunTopicBuSchedulingRunProgressNotification :  IEquatable<WfmBuScheduleRunTopicBuSchedulingRunProgressNotification>
    {
        
        
        
        
        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
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
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Queued for "Queued"
            /// </summary>
            [EnumMember(Value = "Queued")]
            Queued,
            
            /// <summary>
            /// Enum Scheduling for "Scheduling"
            /// </summary>
            [EnumMember(Value = "Scheduling")]
            Scheduling,
            
            /// <summary>
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmBuScheduleRunTopicBuSchedulingRunProgressNotification" /> class.
        /// </summary>
        /// <param name="OperationId">OperationId.</param>
        /// <param name="State">State.</param>
        /// <param name="PercentComplete">PercentComplete.</param>
        /// <param name="IntradayRescheduling">IntradayRescheduling.</param>
        /// <param name="Run">Run.</param>
        public WfmBuScheduleRunTopicBuSchedulingRunProgressNotification(string OperationId = null, StateEnum? State = null, double? PercentComplete = null, bool? IntradayRescheduling = null, WfmBuScheduleRunTopicBuScheduleRun Run = null)
        {
            this.OperationId = OperationId;
            this.State = State;
            this.PercentComplete = PercentComplete;
            this.IntradayRescheduling = IntradayRescheduling;
            this.Run = Run;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets OperationId
        /// </summary>
        [DataMember(Name="operationId", EmitDefaultValue=false)]
        public string OperationId { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets PercentComplete
        /// </summary>
        [DataMember(Name="percentComplete", EmitDefaultValue=false)]
        public double? PercentComplete { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets IntradayRescheduling
        /// </summary>
        [DataMember(Name="intradayRescheduling", EmitDefaultValue=false)]
        public bool? IntradayRescheduling { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Run
        /// </summary>
        [DataMember(Name="run", EmitDefaultValue=false)]
        public WfmBuScheduleRunTopicBuScheduleRun Run { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmBuScheduleRunTopicBuSchedulingRunProgressNotification {\n");
            
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PercentComplete: ").Append(PercentComplete).Append("\n");
            sb.Append("  IntradayRescheduling: ").Append(IntradayRescheduling).Append("\n");
            sb.Append("  Run: ").Append(Run).Append("\n");
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
            return this.Equals(obj as WfmBuScheduleRunTopicBuSchedulingRunProgressNotification);
        }

        /// <summary>
        /// Returns true if WfmBuScheduleRunTopicBuSchedulingRunProgressNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmBuScheduleRunTopicBuSchedulingRunProgressNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmBuScheduleRunTopicBuSchedulingRunProgressNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OperationId == other.OperationId ||
                    this.OperationId != null &&
                    this.OperationId.Equals(other.OperationId)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.PercentComplete == other.PercentComplete ||
                    this.PercentComplete != null &&
                    this.PercentComplete.Equals(other.PercentComplete)
                ) &&
                (
                    this.IntradayRescheduling == other.IntradayRescheduling ||
                    this.IntradayRescheduling != null &&
                    this.IntradayRescheduling.Equals(other.IntradayRescheduling)
                ) &&
                (
                    this.Run == other.Run ||
                    this.Run != null &&
                    this.Run.Equals(other.Run)
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
                
                if (this.OperationId != null)
                    hash = hash * 59 + this.OperationId.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.PercentComplete != null)
                    hash = hash * 59 + this.PercentComplete.GetHashCode();
                
                if (this.IntradayRescheduling != null)
                    hash = hash * 59 + this.IntradayRescheduling.GetHashCode();
                
                if (this.Run != null)
                    hash = hash * 59 + this.Run.GetHashCode();
                
                return hash;
            }
        }
    }

}
