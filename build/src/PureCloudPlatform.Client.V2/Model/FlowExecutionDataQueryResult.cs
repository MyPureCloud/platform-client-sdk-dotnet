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
    /// This is the metadata of an executionData entry for a flow.
    /// </summary>
    [DataContract]
    public partial class FlowExecutionDataQueryResult :  IEquatable<FlowExecutionDataQueryResult>
    {
        /// <summary>
        /// The type of flow.
        /// </summary>
        /// <value>The type of flow.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FlowTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Bot for "bot"
            /// </summary>
            [EnumMember(Value = "bot")]
            Bot,
            
            /// <summary>
            /// Enum Commonmodule for "commonmodule"
            /// </summary>
            [EnumMember(Value = "commonmodule")]
            Commonmodule,
            
            /// <summary>
            /// Enum Digitalbot for "digitalbot"
            /// </summary>
            [EnumMember(Value = "digitalbot")]
            Digitalbot,
            
            /// <summary>
            /// Enum Inboundcall for "inboundcall"
            /// </summary>
            [EnumMember(Value = "inboundcall")]
            Inboundcall,
            
            /// <summary>
            /// Enum Inboundchat for "inboundchat"
            /// </summary>
            [EnumMember(Value = "inboundchat")]
            Inboundchat,
            
            /// <summary>
            /// Enum Inboundemail for "inboundemail"
            /// </summary>
            [EnumMember(Value = "inboundemail")]
            Inboundemail,
            
            /// <summary>
            /// Enum Inboundshortmessage for "inboundshortmessage"
            /// </summary>
            [EnumMember(Value = "inboundshortmessage")]
            Inboundshortmessage,
            
            /// <summary>
            /// Enum Inqueuecall for "inqueuecall"
            /// </summary>
            [EnumMember(Value = "inqueuecall")]
            Inqueuecall,
            
            /// <summary>
            /// Enum Inqueueshortmessage for "inqueueshortmessage"
            /// </summary>
            [EnumMember(Value = "inqueueshortmessage")]
            Inqueueshortmessage,
            
            /// <summary>
            /// Enum Inqueueemail for "inqueueemail"
            /// </summary>
            [EnumMember(Value = "inqueueemail")]
            Inqueueemail,
            
            /// <summary>
            /// Enum Outboundcall for "outboundcall"
            /// </summary>
            [EnumMember(Value = "outboundcall")]
            Outboundcall,
            
            /// <summary>
            /// Enum Securecall for "securecall"
            /// </summary>
            [EnumMember(Value = "securecall")]
            Securecall,
            
            /// <summary>
            /// Enum Surveyinvite for "surveyinvite"
            /// </summary>
            [EnumMember(Value = "surveyinvite")]
            Surveyinvite,
            
            /// <summary>
            /// Enum Voice for "voice"
            /// </summary>
            [EnumMember(Value = "voice")]
            Voice,
            
            /// <summary>
            /// Enum Voicemail for "voicemail"
            /// </summary>
            [EnumMember(Value = "voicemail")]
            Voicemail,
            
            /// <summary>
            /// Enum Voicesurvey for "voicesurvey"
            /// </summary>
            [EnumMember(Value = "voicesurvey")]
            Voicesurvey,
            
            /// <summary>
            /// Enum Workflow for "workflow"
            /// </summary>
            [EnumMember(Value = "workflow")]
            Workflow,
            
            /// <summary>
            /// Enum Workitem for "workitem"
            /// </summary>
            [EnumMember(Value = "workitem")]
            Workitem
        }
        /// <summary>
        /// The type of flow.
        /// </summary>
        /// <value>The type of flow.</value>
        [DataMember(Name="flowType", EmitDefaultValue=false)]
        public FlowTypeEnum? FlowType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowExecutionDataQueryResult" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="StartDateTime">The start time for the execution of this flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="EndDateTime">The end time for the execution of this flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="FlowId">The id of the flow that was executed..</param>
        /// <param name="FlowVersion">The version of the flow that was executed..</param>
        /// <param name="ConversationId">The id of the conversation that executed this flow..</param>
        /// <param name="FlowType">The type of flow..</param>
        /// <param name="FlowErrorReason">If the flow errored out this is the reason..</param>
        /// <param name="FlowName">The name of the flow..</param>
        public FlowExecutionDataQueryResult(string Name = null, DateTime? StartDateTime = null, DateTime? EndDateTime = null, string FlowId = null, string FlowVersion = null, string ConversationId = null, FlowTypeEnum? FlowType = null, string FlowErrorReason = null, string FlowName = null)
        {
            this.Name = Name;
            this.StartDateTime = StartDateTime;
            this.EndDateTime = EndDateTime;
            this.FlowId = FlowId;
            this.FlowVersion = FlowVersion;
            this.ConversationId = ConversationId;
            this.FlowType = FlowType;
            this.FlowErrorReason = FlowErrorReason;
            this.FlowName = FlowName;
            
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
        /// The start time for the execution of this flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The start time for the execution of this flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="startDateTime", EmitDefaultValue=false)]
        public DateTime? StartDateTime { get; set; }



        /// <summary>
        /// The end time for the execution of this flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The end time for the execution of this flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="endDateTime", EmitDefaultValue=false)]
        public DateTime? EndDateTime { get; set; }



        /// <summary>
        /// The id of the flow that was executed.
        /// </summary>
        /// <value>The id of the flow that was executed.</value>
        [DataMember(Name="flowId", EmitDefaultValue=false)]
        public string FlowId { get; set; }



        /// <summary>
        /// The version of the flow that was executed.
        /// </summary>
        /// <value>The version of the flow that was executed.</value>
        [DataMember(Name="flowVersion", EmitDefaultValue=false)]
        public string FlowVersion { get; set; }



        /// <summary>
        /// The id of the conversation that executed this flow.
        /// </summary>
        /// <value>The id of the conversation that executed this flow.</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }





        /// <summary>
        /// If the flow errored out this is the reason.
        /// </summary>
        /// <value>If the flow errored out this is the reason.</value>
        [DataMember(Name="flowErrorReason", EmitDefaultValue=false)]
        public string FlowErrorReason { get; set; }



        /// <summary>
        /// The name of the flow.
        /// </summary>
        /// <value>The name of the flow.</value>
        [DataMember(Name="flowName", EmitDefaultValue=false)]
        public string FlowName { get; set; }



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
            sb.Append("class FlowExecutionDataQueryResult {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  FlowId: ").Append(FlowId).Append("\n");
            sb.Append("  FlowVersion: ").Append(FlowVersion).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  FlowType: ").Append(FlowType).Append("\n");
            sb.Append("  FlowErrorReason: ").Append(FlowErrorReason).Append("\n");
            sb.Append("  FlowName: ").Append(FlowName).Append("\n");
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
            return this.Equals(obj as FlowExecutionDataQueryResult);
        }

        /// <summary>
        /// Returns true if FlowExecutionDataQueryResult instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowExecutionDataQueryResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowExecutionDataQueryResult other)
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
                    this.StartDateTime == other.StartDateTime ||
                    this.StartDateTime != null &&
                    this.StartDateTime.Equals(other.StartDateTime)
                ) &&
                (
                    this.EndDateTime == other.EndDateTime ||
                    this.EndDateTime != null &&
                    this.EndDateTime.Equals(other.EndDateTime)
                ) &&
                (
                    this.FlowId == other.FlowId ||
                    this.FlowId != null &&
                    this.FlowId.Equals(other.FlowId)
                ) &&
                (
                    this.FlowVersion == other.FlowVersion ||
                    this.FlowVersion != null &&
                    this.FlowVersion.Equals(other.FlowVersion)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.FlowType == other.FlowType ||
                    this.FlowType != null &&
                    this.FlowType.Equals(other.FlowType)
                ) &&
                (
                    this.FlowErrorReason == other.FlowErrorReason ||
                    this.FlowErrorReason != null &&
                    this.FlowErrorReason.Equals(other.FlowErrorReason)
                ) &&
                (
                    this.FlowName == other.FlowName ||
                    this.FlowName != null &&
                    this.FlowName.Equals(other.FlowName)
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

                if (this.StartDateTime != null)
                    hash = hash * 59 + this.StartDateTime.GetHashCode();

                if (this.EndDateTime != null)
                    hash = hash * 59 + this.EndDateTime.GetHashCode();

                if (this.FlowId != null)
                    hash = hash * 59 + this.FlowId.GetHashCode();

                if (this.FlowVersion != null)
                    hash = hash * 59 + this.FlowVersion.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.FlowType != null)
                    hash = hash * 59 + this.FlowType.GetHashCode();

                if (this.FlowErrorReason != null)
                    hash = hash * 59 + this.FlowErrorReason.GetHashCode();

                if (this.FlowName != null)
                    hash = hash * 59 + this.FlowName.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
