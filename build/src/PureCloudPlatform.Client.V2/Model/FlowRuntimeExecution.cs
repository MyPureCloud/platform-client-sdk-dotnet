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
    /// Details about the current state of a Flow execution
    /// </summary>
    [DataContract]
    public partial class FlowRuntimeExecution :  IEquatable<FlowRuntimeExecution>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The flow's running status, which indicates whether the flow is running normally or completed, etc.
        /// </summary>
        /// <value>The flow's running status, which indicates whether the flow is running normally or completed, etc.</value>
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
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum Running for "RUNNING"
            /// </summary>
            [EnumMember(Value = "RUNNING")]
            Running,
            
            /// <summary>
            /// Enum Error for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            Error,
            
            /// <summary>
            /// Enum Terminated for "TERMINATED"
            /// </summary>
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            
            /// <summary>
            /// Enum Completed for "COMPLETED"
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            Completed,
            
            /// <summary>
            /// Enum Failed for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            Failed
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The flow's running status, which indicates whether the flow is running normally or completed, etc.
        /// </summary>
        /// <value>The flow's running status, which indicates whether the flow is running normally or completed, etc.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowRuntimeExecution" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlowRuntimeExecution() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowRuntimeExecution" /> class.
        /// </summary>
        /// <param name="Id">The flow execution ID.</param>
        /// <param name="Name">The flow execution name..</param>
        /// <param name="FlowVersion">The Version of the flow definition of the flow execution. (required).</param>
        /// <param name="DateLaunched">The time the flow was launched. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="Status">The flow&#39;s running status, which indicates whether the flow is running normally or completed, etc. (required).</param>
        /// <param name="DateCompleted">The time the flow completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="CompletionReason">The completion reason set at the flow completion time, if applicable..</param>
        /// <param name="FlowErrorInfo">Additional information if the flow is in error.</param>
        /// <param name="OutputData">List of the flow&#39;s output variables, if any. Output variables are only supplied for Completed flows..</param>
        /// <param name="Conversation">The conversation to which this Flow execution is related.</param>
        public FlowRuntimeExecution(string Id = null, string Name = null, FlowVersion FlowVersion = null, DateTime? DateLaunched = null, StatusEnum? Status = null, DateTime? DateCompleted = null, string CompletionReason = null, ErrorBody FlowErrorInfo = null, Dictionary<string, Object> OutputData = null, DomainEntityRef Conversation = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.FlowVersion = FlowVersion;
            this.DateLaunched = DateLaunched;
            this.Status = Status;
            this.DateCompleted = DateCompleted;
            this.CompletionReason = CompletionReason;
            this.FlowErrorInfo = FlowErrorInfo;
            this.OutputData = OutputData;
            this.Conversation = Conversation;
            
        }
        
        
        
        /// <summary>
        /// The flow execution ID
        /// </summary>
        /// <value>The flow execution ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The flow execution name.
        /// </summary>
        /// <value>The flow execution name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The Version of the flow definition of the flow execution.
        /// </summary>
        /// <value>The Version of the flow definition of the flow execution.</value>
        [DataMember(Name="flowVersion", EmitDefaultValue=false)]
        public FlowVersion FlowVersion { get; set; }
        
        
        
        /// <summary>
        /// The time the flow was launched. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time the flow was launched. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateLaunched", EmitDefaultValue=false)]
        public DateTime? DateLaunched { get; set; }
        
        
        
        
        
        /// <summary>
        /// The time the flow completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time the flow completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCompleted", EmitDefaultValue=false)]
        public DateTime? DateCompleted { get; set; }
        
        
        
        /// <summary>
        /// The completion reason set at the flow completion time, if applicable.
        /// </summary>
        /// <value>The completion reason set at the flow completion time, if applicable.</value>
        [DataMember(Name="completionReason", EmitDefaultValue=false)]
        public string CompletionReason { get; set; }
        
        
        
        /// <summary>
        /// Additional information if the flow is in error
        /// </summary>
        /// <value>Additional information if the flow is in error</value>
        [DataMember(Name="flowErrorInfo", EmitDefaultValue=false)]
        public ErrorBody FlowErrorInfo { get; set; }
        
        
        
        /// <summary>
        /// List of the flow&#39;s output variables, if any. Output variables are only supplied for Completed flows.
        /// </summary>
        /// <value>List of the flow&#39;s output variables, if any. Output variables are only supplied for Completed flows.</value>
        [DataMember(Name="outputData", EmitDefaultValue=false)]
        public Dictionary<string, Object> OutputData { get; set; }
        
        
        
        /// <summary>
        /// The conversation to which this Flow execution is related
        /// </summary>
        /// <value>The conversation to which this Flow execution is related</value>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public DomainEntityRef Conversation { get; set; }
        
        
        
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
            sb.Append("class FlowRuntimeExecution {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FlowVersion: ").Append(FlowVersion).Append("\n");
            sb.Append("  DateLaunched: ").Append(DateLaunched).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
            sb.Append("  CompletionReason: ").Append(CompletionReason).Append("\n");
            sb.Append("  FlowErrorInfo: ").Append(FlowErrorInfo).Append("\n");
            sb.Append("  OutputData: ").Append(OutputData).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
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
            return this.Equals(obj as FlowRuntimeExecution);
        }

        /// <summary>
        /// Returns true if FlowRuntimeExecution instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowRuntimeExecution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowRuntimeExecution other)
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
                    this.FlowVersion == other.FlowVersion ||
                    this.FlowVersion != null &&
                    this.FlowVersion.Equals(other.FlowVersion)
                ) &&
                (
                    this.DateLaunched == other.DateLaunched ||
                    this.DateLaunched != null &&
                    this.DateLaunched.Equals(other.DateLaunched)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.DateCompleted == other.DateCompleted ||
                    this.DateCompleted != null &&
                    this.DateCompleted.Equals(other.DateCompleted)
                ) &&
                (
                    this.CompletionReason == other.CompletionReason ||
                    this.CompletionReason != null &&
                    this.CompletionReason.Equals(other.CompletionReason)
                ) &&
                (
                    this.FlowErrorInfo == other.FlowErrorInfo ||
                    this.FlowErrorInfo != null &&
                    this.FlowErrorInfo.Equals(other.FlowErrorInfo)
                ) &&
                (
                    this.OutputData == other.OutputData ||
                    this.OutputData != null &&
                    this.OutputData.SequenceEqual(other.OutputData)
                ) &&
                (
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
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
                
                if (this.FlowVersion != null)
                    hash = hash * 59 + this.FlowVersion.GetHashCode();
                
                if (this.DateLaunched != null)
                    hash = hash * 59 + this.DateLaunched.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.DateCompleted != null)
                    hash = hash * 59 + this.DateCompleted.GetHashCode();
                
                if (this.CompletionReason != null)
                    hash = hash * 59 + this.CompletionReason.GetHashCode();
                
                if (this.FlowErrorInfo != null)
                    hash = hash * 59 + this.FlowErrorInfo.GetHashCode();
                
                if (this.OutputData != null)
                    hash = hash * 59 + this.OutputData.GetHashCode();
                
                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
