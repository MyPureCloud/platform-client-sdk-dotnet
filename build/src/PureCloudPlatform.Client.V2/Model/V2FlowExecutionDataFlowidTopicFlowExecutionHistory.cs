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
    /// V2FlowExecutionDataFlowidTopicFlowExecutionHistory
    /// </summary>
    [DataContract]
    public partial class V2FlowExecutionDataFlowidTopicFlowExecutionHistory :  IEquatable<V2FlowExecutionDataFlowidTopicFlowExecutionHistory>
    {
        /// <summary>
        /// If applicable, the type of message platform from which the message originated.
        /// </summary>
        /// <value>If applicable, the type of message platform from which the message originated.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MessageTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "unknown"
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Sms for "sms"
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms,
            
            /// <summary>
            /// Enum Twitter for "twitter"
            /// </summary>
            [EnumMember(Value = "twitter")]
            Twitter,
            
            /// <summary>
            /// Enum Facebook for "facebook"
            /// </summary>
            [EnumMember(Value = "facebook")]
            Facebook,
            
            /// <summary>
            /// Enum Instagram for "instagram"
            /// </summary>
            [EnumMember(Value = "instagram")]
            Instagram,
            
            /// <summary>
            /// Enum Line for "line"
            /// </summary>
            [EnumMember(Value = "line")]
            Line,
            
            /// <summary>
            /// Enum Whatsapp for "whatsapp"
            /// </summary>
            [EnumMember(Value = "whatsapp")]
            Whatsapp,
            
            /// <summary>
            /// Enum Webmessaging for "webmessaging"
            /// </summary>
            [EnumMember(Value = "webmessaging")]
            Webmessaging,
            
            /// <summary>
            /// Enum Open for "open"
            /// </summary>
            [EnumMember(Value = "open")]
            Open
        }
        /// <summary>
        /// If applicable, the type of message platform from which the message originated.
        /// </summary>
        /// <value>If applicable, the type of message platform from which the message originated.</value>
        [DataMember(Name="messageType", EmitDefaultValue=false)]
        public MessageTypeEnum? MessageType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2FlowExecutionDataFlowidTopicFlowExecutionHistory" /> class.
        /// </summary>
        /// <param name="ExecutionId">The execution identifier which represents this unique instance of the flow that ran..</param>
        /// <param name="ConversationId">The Genesys Cloud conversation identifier associated with this flow instance execution data..</param>
        /// <param name="DivisionId">The division identifier for the division associated with the flow for this flow instance..</param>
        /// <param name="EndDateTime">The end date time for this flow instance execution data..</param>
        /// <param name="Endpoint">The public endpoint a user can use to retrieve the full historical log from the service..</param>
        /// <param name="Errors">If the flow invoked error handling, an array of errors..</param>
        /// <param name="Execution">An array of execution items that describe what happened when an Architect flow action container ran such as a flow, task, state or bot..</param>
        /// <param name="FlowExitReason">Provides information about why a flow ended..</param>
        /// <param name="FlowId">The flow identifier for this flow instance execution data.  This is the identifier of the flow configuration that users load up in Architect..</param>
        /// <param name="FlowIsDebug">Whether the flow that ran for this flow instance execution data was in debug mode..</param>
        /// <param name="ExecutionItemsTruncated">If true, the execution items in this event have been truncated to be deliverable..</param>
        /// <param name="FlowType">The flow type of the Architect flow that was run..</param>
        /// <param name="FlowVersion">The version of the flow for this flow instance execution data. Typically this is a numeric value like 1.0 represented as a string but can also be 'debug'.</param>
        /// <param name="MessageType">If applicable, the type of message platform from which the message originated..</param>
        /// <param name="InvokingContext">InvokingContext.</param>
        /// <param name="StartDateTime">The start date time for this flow instance execution data..</param>
        /// <param name="Warnings">If the flow encountered a warning during execution, this is an array of the warnings..</param>
        public V2FlowExecutionDataFlowidTopicFlowExecutionHistory(string ExecutionId = null, string ConversationId = null, string DivisionId = null, DateTime? EndDateTime = null, string Endpoint = null, List<V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo> Errors = null, List<V2FlowExecutionDataFlowidTopicExecution> Execution = null, string FlowExitReason = null, string FlowId = null, bool? FlowIsDebug = null, bool? ExecutionItemsTruncated = null, string FlowType = null, string FlowVersion = null, MessageTypeEnum? MessageType = null, V2FlowExecutionDataFlowidTopicInvokingContext InvokingContext = null, DateTime? StartDateTime = null, List<V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo> Warnings = null)
        {
            this.ExecutionId = ExecutionId;
            this.ConversationId = ConversationId;
            this.DivisionId = DivisionId;
            this.EndDateTime = EndDateTime;
            this.Endpoint = Endpoint;
            this.Errors = Errors;
            this.Execution = Execution;
            this.FlowExitReason = FlowExitReason;
            this.FlowId = FlowId;
            this.FlowIsDebug = FlowIsDebug;
            this.ExecutionItemsTruncated = ExecutionItemsTruncated;
            this.FlowType = FlowType;
            this.FlowVersion = FlowVersion;
            this.MessageType = MessageType;
            this.InvokingContext = InvokingContext;
            this.StartDateTime = StartDateTime;
            this.Warnings = Warnings;
            
        }
        


        /// <summary>
        /// The execution identifier which represents this unique instance of the flow that ran.
        /// </summary>
        /// <value>The execution identifier which represents this unique instance of the flow that ran.</value>
        [DataMember(Name="executionId", EmitDefaultValue=false)]
        public string ExecutionId { get; set; }



        /// <summary>
        /// The Genesys Cloud conversation identifier associated with this flow instance execution data.
        /// </summary>
        /// <value>The Genesys Cloud conversation identifier associated with this flow instance execution data.</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// The division identifier for the division associated with the flow for this flow instance.
        /// </summary>
        /// <value>The division identifier for the division associated with the flow for this flow instance.</value>
        [DataMember(Name="divisionId", EmitDefaultValue=false)]
        public string DivisionId { get; set; }



        /// <summary>
        /// The end date time for this flow instance execution data.
        /// </summary>
        /// <value>The end date time for this flow instance execution data.</value>
        [DataMember(Name="endDateTime", EmitDefaultValue=false)]
        public DateTime? EndDateTime { get; set; }



        /// <summary>
        /// The public endpoint a user can use to retrieve the full historical log from the service.
        /// </summary>
        /// <value>The public endpoint a user can use to retrieve the full historical log from the service.</value>
        [DataMember(Name="endpoint", EmitDefaultValue=false)]
        public string Endpoint { get; set; }



        /// <summary>
        /// If the flow invoked error handling, an array of errors.
        /// </summary>
        /// <value>If the flow invoked error handling, an array of errors.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo> Errors { get; set; }



        /// <summary>
        /// An array of execution items that describe what happened when an Architect flow action container ran such as a flow, task, state or bot.
        /// </summary>
        /// <value>An array of execution items that describe what happened when an Architect flow action container ran such as a flow, task, state or bot.</value>
        [DataMember(Name="execution", EmitDefaultValue=false)]
        public List<V2FlowExecutionDataFlowidTopicExecution> Execution { get; set; }



        /// <summary>
        /// Provides information about why a flow ended.
        /// </summary>
        /// <value>Provides information about why a flow ended.</value>
        [DataMember(Name="flowExitReason", EmitDefaultValue=false)]
        public string FlowExitReason { get; set; }



        /// <summary>
        /// The flow identifier for this flow instance execution data.  This is the identifier of the flow configuration that users load up in Architect.
        /// </summary>
        /// <value>The flow identifier for this flow instance execution data.  This is the identifier of the flow configuration that users load up in Architect.</value>
        [DataMember(Name="flowId", EmitDefaultValue=false)]
        public string FlowId { get; set; }



        /// <summary>
        /// Whether the flow that ran for this flow instance execution data was in debug mode.
        /// </summary>
        /// <value>Whether the flow that ran for this flow instance execution data was in debug mode.</value>
        [DataMember(Name="flowIsDebug", EmitDefaultValue=false)]
        public bool? FlowIsDebug { get; set; }



        /// <summary>
        /// If true, the execution items in this event have been truncated to be deliverable.
        /// </summary>
        /// <value>If true, the execution items in this event have been truncated to be deliverable.</value>
        [DataMember(Name="executionItemsTruncated", EmitDefaultValue=false)]
        public bool? ExecutionItemsTruncated { get; set; }



        /// <summary>
        /// The flow type of the Architect flow that was run.
        /// </summary>
        /// <value>The flow type of the Architect flow that was run.</value>
        [DataMember(Name="flowType", EmitDefaultValue=false)]
        public string FlowType { get; set; }



        /// <summary>
        /// The version of the flow for this flow instance execution data. Typically this is a numeric value like 1.0 represented as a string but can also be 'debug'
        /// </summary>
        /// <value>The version of the flow for this flow instance execution data. Typically this is a numeric value like 1.0 represented as a string but can also be 'debug'</value>
        [DataMember(Name="flowVersion", EmitDefaultValue=false)]
        public string FlowVersion { get; set; }





        /// <summary>
        /// Gets or Sets InvokingContext
        /// </summary>
        [DataMember(Name="invokingContext", EmitDefaultValue=false)]
        public V2FlowExecutionDataFlowidTopicInvokingContext InvokingContext { get; set; }



        /// <summary>
        /// The start date time for this flow instance execution data.
        /// </summary>
        /// <value>The start date time for this flow instance execution data.</value>
        [DataMember(Name="startDateTime", EmitDefaultValue=false)]
        public DateTime? StartDateTime { get; set; }



        /// <summary>
        /// If the flow encountered a warning during execution, this is an array of the warnings.
        /// </summary>
        /// <value>If the flow encountered a warning during execution, this is an array of the warnings.</value>
        [DataMember(Name="warnings", EmitDefaultValue=false)]
        public List<V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo> Warnings { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2FlowExecutionDataFlowidTopicFlowExecutionHistory {\n");

            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Execution: ").Append(Execution).Append("\n");
            sb.Append("  FlowExitReason: ").Append(FlowExitReason).Append("\n");
            sb.Append("  FlowId: ").Append(FlowId).Append("\n");
            sb.Append("  FlowIsDebug: ").Append(FlowIsDebug).Append("\n");
            sb.Append("  ExecutionItemsTruncated: ").Append(ExecutionItemsTruncated).Append("\n");
            sb.Append("  FlowType: ").Append(FlowType).Append("\n");
            sb.Append("  FlowVersion: ").Append(FlowVersion).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  InvokingContext: ").Append(InvokingContext).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return this.Equals(obj as V2FlowExecutionDataFlowidTopicFlowExecutionHistory);
        }

        /// <summary>
        /// Returns true if V2FlowExecutionDataFlowidTopicFlowExecutionHistory instances are equal
        /// </summary>
        /// <param name="other">Instance of V2FlowExecutionDataFlowidTopicFlowExecutionHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2FlowExecutionDataFlowidTopicFlowExecutionHistory other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ExecutionId == other.ExecutionId ||
                    this.ExecutionId != null &&
                    this.ExecutionId.Equals(other.ExecutionId)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.DivisionId == other.DivisionId ||
                    this.DivisionId != null &&
                    this.DivisionId.Equals(other.DivisionId)
                ) &&
                (
                    this.EndDateTime == other.EndDateTime ||
                    this.EndDateTime != null &&
                    this.EndDateTime.Equals(other.EndDateTime)
                ) &&
                (
                    this.Endpoint == other.Endpoint ||
                    this.Endpoint != null &&
                    this.Endpoint.Equals(other.Endpoint)
                ) &&
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) &&
                (
                    this.Execution == other.Execution ||
                    this.Execution != null &&
                    this.Execution.SequenceEqual(other.Execution)
                ) &&
                (
                    this.FlowExitReason == other.FlowExitReason ||
                    this.FlowExitReason != null &&
                    this.FlowExitReason.Equals(other.FlowExitReason)
                ) &&
                (
                    this.FlowId == other.FlowId ||
                    this.FlowId != null &&
                    this.FlowId.Equals(other.FlowId)
                ) &&
                (
                    this.FlowIsDebug == other.FlowIsDebug ||
                    this.FlowIsDebug != null &&
                    this.FlowIsDebug.Equals(other.FlowIsDebug)
                ) &&
                (
                    this.ExecutionItemsTruncated == other.ExecutionItemsTruncated ||
                    this.ExecutionItemsTruncated != null &&
                    this.ExecutionItemsTruncated.Equals(other.ExecutionItemsTruncated)
                ) &&
                (
                    this.FlowType == other.FlowType ||
                    this.FlowType != null &&
                    this.FlowType.Equals(other.FlowType)
                ) &&
                (
                    this.FlowVersion == other.FlowVersion ||
                    this.FlowVersion != null &&
                    this.FlowVersion.Equals(other.FlowVersion)
                ) &&
                (
                    this.MessageType == other.MessageType ||
                    this.MessageType != null &&
                    this.MessageType.Equals(other.MessageType)
                ) &&
                (
                    this.InvokingContext == other.InvokingContext ||
                    this.InvokingContext != null &&
                    this.InvokingContext.Equals(other.InvokingContext)
                ) &&
                (
                    this.StartDateTime == other.StartDateTime ||
                    this.StartDateTime != null &&
                    this.StartDateTime.Equals(other.StartDateTime)
                ) &&
                (
                    this.Warnings == other.Warnings ||
                    this.Warnings != null &&
                    this.Warnings.SequenceEqual(other.Warnings)
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
                if (this.ExecutionId != null)
                    hash = hash * 59 + this.ExecutionId.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.DivisionId != null)
                    hash = hash * 59 + this.DivisionId.GetHashCode();

                if (this.EndDateTime != null)
                    hash = hash * 59 + this.EndDateTime.GetHashCode();

                if (this.Endpoint != null)
                    hash = hash * 59 + this.Endpoint.GetHashCode();

                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();

                if (this.Execution != null)
                    hash = hash * 59 + this.Execution.GetHashCode();

                if (this.FlowExitReason != null)
                    hash = hash * 59 + this.FlowExitReason.GetHashCode();

                if (this.FlowId != null)
                    hash = hash * 59 + this.FlowId.GetHashCode();

                if (this.FlowIsDebug != null)
                    hash = hash * 59 + this.FlowIsDebug.GetHashCode();

                if (this.ExecutionItemsTruncated != null)
                    hash = hash * 59 + this.ExecutionItemsTruncated.GetHashCode();

                if (this.FlowType != null)
                    hash = hash * 59 + this.FlowType.GetHashCode();

                if (this.FlowVersion != null)
                    hash = hash * 59 + this.FlowVersion.GetHashCode();

                if (this.MessageType != null)
                    hash = hash * 59 + this.MessageType.GetHashCode();

                if (this.InvokingContext != null)
                    hash = hash * 59 + this.InvokingContext.GetHashCode();

                if (this.StartDateTime != null)
                    hash = hash * 59 + this.StartDateTime.GetHashCode();

                if (this.Warnings != null)
                    hash = hash * 59 + this.Warnings.GetHashCode();

                return hash;
            }
        }
    }

}
