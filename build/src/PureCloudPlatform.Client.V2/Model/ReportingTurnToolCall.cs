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
    /// ReportingTurnToolCall
    /// </summary>
    [DataContract]
    public partial class ReportingTurnToolCall :  IEquatable<ReportingTurnToolCall>
    {
        /// <summary>
        /// Represents the type of tool used in the event.
        /// </summary>
        /// <value>Represents the type of tool used in the event.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ToolTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Knowledgesetting for "KnowledgeSetting"
            /// </summary>
            [EnumMember(Value = "KnowledgeSetting")]
            Knowledgesetting,
            
            /// <summary>
            /// Enum Knowledgebase for "KnowledgeBase"
            /// </summary>
            [EnumMember(Value = "KnowledgeBase")]
            Knowledgebase,
            
            /// <summary>
            /// Enum Dataaction for "DataAction"
            /// </summary>
            [EnumMember(Value = "DataAction")]
            Dataaction,
            
            /// <summary>
            /// Enum Externala2aserver for "ExternalA2AServer"
            /// </summary>
            [EnumMember(Value = "ExternalA2AServer")]
            Externala2aserver,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Represents whether the tool call was successful or not.
        /// </summary>
        /// <value>Represents whether the tool call was successful or not.</value>
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
            /// Enum Success for "Success"
            /// </summary>
            [EnumMember(Value = "Success")]
            Success,
            
            /// <summary>
            /// Enum Failure for "Failure"
            /// </summary>
            [EnumMember(Value = "Failure")]
            Failure,
            
            /// <summary>
            /// Enum Timeout for "Timeout"
            /// </summary>
            [EnumMember(Value = "Timeout")]
            Timeout,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Represents the origin of the tool call.
        /// </summary>
        /// <value>Represents the origin of the tool call.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OriginEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Avatool for "AvaTool"
            /// </summary>
            [EnumMember(Value = "AvaTool")]
            Avatool,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Represents the type of tool used in the event.
        /// </summary>
        /// <value>Represents the type of tool used in the event.</value>
        [DataMember(Name="toolType", EmitDefaultValue=false)]
        public ToolTypeEnum? ToolType { get; set; }
        /// <summary>
        /// Represents whether the tool call was successful or not.
        /// </summary>
        /// <value>Represents whether the tool call was successful or not.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Represents the origin of the tool call.
        /// </summary>
        /// <value>Represents the origin of the tool call.</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public OriginEnum? Origin { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingTurnToolCall" /> class.
        /// </summary>
        /// <param name="ToolId">Represents the identifier of the tool called..</param>
        /// <param name="ToolName">Represents the name of the tool used in the event..</param>
        /// <param name="ToolType">Represents the type of tool used in the event..</param>
        /// <param name="TargetId">Represents the identifier of the target that the tool is using..</param>
        /// <param name="Status">Represents whether the tool call was successful or not..</param>
        /// <param name="ErrorText">Represents the error returned by the tool in the event of a failure..</param>
        /// <param name="DateInvoked">Represents the starting time of the tool call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="LatencyMs">Represents the time it took the tool call to execute..</param>
        /// <param name="Origin">Represents the origin of the tool call..</param>
        /// <param name="KnowledgeMetadata">Represents various metadata of knowledge calls used by the tool if the tool is configured to use knowledge..</param>
        public ReportingTurnToolCall(string ToolId = null, string ToolName = null, ToolTypeEnum? ToolType = null, string TargetId = null, StatusEnum? Status = null, string ErrorText = null, DateTime? DateInvoked = null, int? LatencyMs = null, OriginEnum? Origin = null, ReportingTurnKnowledgeMetadata KnowledgeMetadata = null)
        {
            this.ToolId = ToolId;
            this.ToolName = ToolName;
            this.ToolType = ToolType;
            this.TargetId = TargetId;
            this.Status = Status;
            this.ErrorText = ErrorText;
            this.DateInvoked = DateInvoked;
            this.LatencyMs = LatencyMs;
            this.Origin = Origin;
            this.KnowledgeMetadata = KnowledgeMetadata;
            
        }
        


        /// <summary>
        /// Represents the identifier of the tool called.
        /// </summary>
        /// <value>Represents the identifier of the tool called.</value>
        [DataMember(Name="toolId", EmitDefaultValue=false)]
        public string ToolId { get; set; }



        /// <summary>
        /// Represents the name of the tool used in the event.
        /// </summary>
        /// <value>Represents the name of the tool used in the event.</value>
        [DataMember(Name="toolName", EmitDefaultValue=false)]
        public string ToolName { get; set; }





        /// <summary>
        /// Represents the identifier of the target that the tool is using.
        /// </summary>
        /// <value>Represents the identifier of the target that the tool is using.</value>
        [DataMember(Name="targetId", EmitDefaultValue=false)]
        public string TargetId { get; set; }





        /// <summary>
        /// Represents the error returned by the tool in the event of a failure.
        /// </summary>
        /// <value>Represents the error returned by the tool in the event of a failure.</value>
        [DataMember(Name="errorText", EmitDefaultValue=false)]
        public string ErrorText { get; set; }



        /// <summary>
        /// Represents the starting time of the tool call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Represents the starting time of the tool call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateInvoked", EmitDefaultValue=false)]
        public DateTime? DateInvoked { get; set; }



        /// <summary>
        /// Represents the time it took the tool call to execute.
        /// </summary>
        /// <value>Represents the time it took the tool call to execute.</value>
        [DataMember(Name="latencyMs", EmitDefaultValue=false)]
        public int? LatencyMs { get; set; }





        /// <summary>
        /// Represents various metadata of knowledge calls used by the tool if the tool is configured to use knowledge.
        /// </summary>
        /// <value>Represents various metadata of knowledge calls used by the tool if the tool is configured to use knowledge.</value>
        [DataMember(Name="knowledgeMetadata", EmitDefaultValue=false)]
        public ReportingTurnKnowledgeMetadata KnowledgeMetadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingTurnToolCall {\n");

            sb.Append("  ToolId: ").Append(ToolId).Append("\n");
            sb.Append("  ToolName: ").Append(ToolName).Append("\n");
            sb.Append("  ToolType: ").Append(ToolType).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ErrorText: ").Append(ErrorText).Append("\n");
            sb.Append("  DateInvoked: ").Append(DateInvoked).Append("\n");
            sb.Append("  LatencyMs: ").Append(LatencyMs).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  KnowledgeMetadata: ").Append(KnowledgeMetadata).Append("\n");
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
            return this.Equals(obj as ReportingTurnToolCall);
        }

        /// <summary>
        /// Returns true if ReportingTurnToolCall instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingTurnToolCall to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingTurnToolCall other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ToolId == other.ToolId ||
                    this.ToolId != null &&
                    this.ToolId.Equals(other.ToolId)
                ) &&
                (
                    this.ToolName == other.ToolName ||
                    this.ToolName != null &&
                    this.ToolName.Equals(other.ToolName)
                ) &&
                (
                    this.ToolType == other.ToolType ||
                    this.ToolType != null &&
                    this.ToolType.Equals(other.ToolType)
                ) &&
                (
                    this.TargetId == other.TargetId ||
                    this.TargetId != null &&
                    this.TargetId.Equals(other.TargetId)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ErrorText == other.ErrorText ||
                    this.ErrorText != null &&
                    this.ErrorText.Equals(other.ErrorText)
                ) &&
                (
                    this.DateInvoked == other.DateInvoked ||
                    this.DateInvoked != null &&
                    this.DateInvoked.Equals(other.DateInvoked)
                ) &&
                (
                    this.LatencyMs == other.LatencyMs ||
                    this.LatencyMs != null &&
                    this.LatencyMs.Equals(other.LatencyMs)
                ) &&
                (
                    this.Origin == other.Origin ||
                    this.Origin != null &&
                    this.Origin.Equals(other.Origin)
                ) &&
                (
                    this.KnowledgeMetadata == other.KnowledgeMetadata ||
                    this.KnowledgeMetadata != null &&
                    this.KnowledgeMetadata.Equals(other.KnowledgeMetadata)
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
                if (this.ToolId != null)
                    hash = hash * 59 + this.ToolId.GetHashCode();

                if (this.ToolName != null)
                    hash = hash * 59 + this.ToolName.GetHashCode();

                if (this.ToolType != null)
                    hash = hash * 59 + this.ToolType.GetHashCode();

                if (this.TargetId != null)
                    hash = hash * 59 + this.TargetId.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.ErrorText != null)
                    hash = hash * 59 + this.ErrorText.GetHashCode();

                if (this.DateInvoked != null)
                    hash = hash * 59 + this.DateInvoked.GetHashCode();

                if (this.LatencyMs != null)
                    hash = hash * 59 + this.LatencyMs.GetHashCode();

                if (this.Origin != null)
                    hash = hash * 59 + this.Origin.GetHashCode();

                if (this.KnowledgeMetadata != null)
                    hash = hash * 59 + this.KnowledgeMetadata.GetHashCode();

                return hash;
            }
        }
    }

}
