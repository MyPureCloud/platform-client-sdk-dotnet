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
    /// AnalyticsFlow
    /// </summary>
    [DataContract]
    public partial class AnalyticsFlow :  IEquatable<AnalyticsFlow>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of this flow
        /// </summary>
        /// <value>The type of this flow</value>
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
            /// Enum Bot for "BOT"
            /// </summary>
            [EnumMember(Value = "BOT")]
            Bot,
            
            /// <summary>
            /// Enum Commonmodule for "COMMONMODULE"
            /// </summary>
            [EnumMember(Value = "COMMONMODULE")]
            Commonmodule,
            
            /// <summary>
            /// Enum Inboundcall for "INBOUNDCALL"
            /// </summary>
            [EnumMember(Value = "INBOUNDCALL")]
            Inboundcall,
            
            /// <summary>
            /// Enum Inboundchat for "INBOUNDCHAT"
            /// </summary>
            [EnumMember(Value = "INBOUNDCHAT")]
            Inboundchat,
            
            /// <summary>
            /// Enum Inboundemail for "INBOUNDEMAIL"
            /// </summary>
            [EnumMember(Value = "INBOUNDEMAIL")]
            Inboundemail,
            
            /// <summary>
            /// Enum Inboundshortmessage for "INBOUNDSHORTMESSAGE"
            /// </summary>
            [EnumMember(Value = "INBOUNDSHORTMESSAGE")]
            Inboundshortmessage,
            
            /// <summary>
            /// Enum Inqueuecall for "INQUEUECALL"
            /// </summary>
            [EnumMember(Value = "INQUEUECALL")]
            Inqueuecall,
            
            /// <summary>
            /// Enum Outboundcall for "OUTBOUNDCALL"
            /// </summary>
            [EnumMember(Value = "OUTBOUNDCALL")]
            Outboundcall,
            
            /// <summary>
            /// Enum Securecall for "SECURECALL"
            /// </summary>
            [EnumMember(Value = "SECURECALL")]
            Securecall,
            
            /// <summary>
            /// Enum Speech for "SPEECH"
            /// </summary>
            [EnumMember(Value = "SPEECH")]
            Speech,
            
            /// <summary>
            /// Enum Surveyinvite for "SURVEYINVITE"
            /// </summary>
            [EnumMember(Value = "SURVEYINVITE")]
            Surveyinvite,
            
            /// <summary>
            /// Enum Workflow for "WORKFLOW"
            /// </summary>
            [EnumMember(Value = "WORKFLOW")]
            Workflow
        }
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The entry type for this flow
        /// </summary>
        /// <value>The entry type for this flow</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EntryTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Dnis for "dnis"
            /// </summary>
            [EnumMember(Value = "dnis")]
            Dnis,
            
            /// <summary>
            /// Enum Direct for "direct"
            /// </summary>
            [EnumMember(Value = "direct")]
            Direct,
            
            /// <summary>
            /// Enum Flow for "flow"
            /// </summary>
            [EnumMember(Value = "flow")]
            Flow,
            
            /// <summary>
            /// Enum Agent for "agent"
            /// </summary>
            [EnumMember(Value = "agent")]
            Agent,
            
            /// <summary>
            /// Enum Outbound for "outbound"
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of this flow
        /// </summary>
        /// <value>The type of this flow</value>
        [DataMember(Name="flowType", EmitDefaultValue=false)]
        public FlowTypeEnum? FlowType { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// The entry type for this flow
        /// </summary>
        /// <value>The entry type for this flow</value>
        [DataMember(Name="entryType", EmitDefaultValue=false)]
        public EntryTypeEnum? EntryType { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsFlow" /> class.
        /// </summary>
        /// <param name="FlowId">The unique identifier of this flow.</param>
        /// <param name="FlowName">The name of this flow.</param>
        /// <param name="FlowVersion">The version of this flow.</param>
        /// <param name="FlowType">The type of this flow.</param>
        /// <param name="ExitReason">The exit reason for this flow, e.g. DISCONNECT.</param>
        /// <param name="EntryReason">The particular entry reason for this flow, e.g. an address, userId, or flowId.</param>
        /// <param name="EntryType">The entry type for this flow.</param>
        /// <param name="TransferType">The type of transfer for flows that ended with a transfer.</param>
        /// <param name="TransferTargetName">The name of a transfer target.</param>
        /// <param name="TransferTargetAddress">The address of a transfer target.</param>
        /// <param name="IssuedCallback">Flag indicating whether the flow issued a callback.</param>
        /// <param name="StartingLanguage">Flow starting language, e.g. en-us.</param>
        /// <param name="EndingLanguage">Flow ending language, e.g. en-us.</param>
        /// <param name="Outcomes">Flow outcomes.</param>
        public AnalyticsFlow(string FlowId = null, string FlowName = null, string FlowVersion = null, FlowTypeEnum? FlowType = null, string ExitReason = null, string EntryReason = null, EntryTypeEnum? EntryType = null, string TransferType = null, string TransferTargetName = null, string TransferTargetAddress = null, bool? IssuedCallback = null, string StartingLanguage = null, string EndingLanguage = null, List<AnalyticsFlowOutcome> Outcomes = null)
        {
            this.FlowId = FlowId;
            this.FlowName = FlowName;
            this.FlowVersion = FlowVersion;
            this.FlowType = FlowType;
            this.ExitReason = ExitReason;
            this.EntryReason = EntryReason;
            this.EntryType = EntryType;
            this.TransferType = TransferType;
            this.TransferTargetName = TransferTargetName;
            this.TransferTargetAddress = TransferTargetAddress;
            this.IssuedCallback = IssuedCallback;
            this.StartingLanguage = StartingLanguage;
            this.EndingLanguage = EndingLanguage;
            this.Outcomes = Outcomes;
            
        }
        
        
        
        /// <summary>
        /// The unique identifier of this flow
        /// </summary>
        /// <value>The unique identifier of this flow</value>
        [DataMember(Name="flowId", EmitDefaultValue=false)]
        public string FlowId { get; set; }
        
        
        
        /// <summary>
        /// The name of this flow
        /// </summary>
        /// <value>The name of this flow</value>
        [DataMember(Name="flowName", EmitDefaultValue=false)]
        public string FlowName { get; set; }
        
        
        
        /// <summary>
        /// The version of this flow
        /// </summary>
        /// <value>The version of this flow</value>
        [DataMember(Name="flowVersion", EmitDefaultValue=false)]
        public string FlowVersion { get; set; }
        
        
        
        
        
        /// <summary>
        /// The exit reason for this flow, e.g. DISCONNECT
        /// </summary>
        /// <value>The exit reason for this flow, e.g. DISCONNECT</value>
        [DataMember(Name="exitReason", EmitDefaultValue=false)]
        public string ExitReason { get; set; }
        
        
        
        /// <summary>
        /// The particular entry reason for this flow, e.g. an address, userId, or flowId
        /// </summary>
        /// <value>The particular entry reason for this flow, e.g. an address, userId, or flowId</value>
        [DataMember(Name="entryReason", EmitDefaultValue=false)]
        public string EntryReason { get; set; }
        
        
        
        
        
        /// <summary>
        /// The type of transfer for flows that ended with a transfer
        /// </summary>
        /// <value>The type of transfer for flows that ended with a transfer</value>
        [DataMember(Name="transferType", EmitDefaultValue=false)]
        public string TransferType { get; set; }
        
        
        
        /// <summary>
        /// The name of a transfer target
        /// </summary>
        /// <value>The name of a transfer target</value>
        [DataMember(Name="transferTargetName", EmitDefaultValue=false)]
        public string TransferTargetName { get; set; }
        
        
        
        /// <summary>
        /// The address of a transfer target
        /// </summary>
        /// <value>The address of a transfer target</value>
        [DataMember(Name="transferTargetAddress", EmitDefaultValue=false)]
        public string TransferTargetAddress { get; set; }
        
        
        
        /// <summary>
        /// Flag indicating whether the flow issued a callback
        /// </summary>
        /// <value>Flag indicating whether the flow issued a callback</value>
        [DataMember(Name="issuedCallback", EmitDefaultValue=false)]
        public bool? IssuedCallback { get; set; }
        
        
        
        /// <summary>
        /// Flow starting language, e.g. en-us
        /// </summary>
        /// <value>Flow starting language, e.g. en-us</value>
        [DataMember(Name="startingLanguage", EmitDefaultValue=false)]
        public string StartingLanguage { get; set; }
        
        
        
        /// <summary>
        /// Flow ending language, e.g. en-us
        /// </summary>
        /// <value>Flow ending language, e.g. en-us</value>
        [DataMember(Name="endingLanguage", EmitDefaultValue=false)]
        public string EndingLanguage { get; set; }
        
        
        
        /// <summary>
        /// Flow outcomes
        /// </summary>
        /// <value>Flow outcomes</value>
        [DataMember(Name="outcomes", EmitDefaultValue=false)]
        public List<AnalyticsFlowOutcome> Outcomes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsFlow {\n");
            
            sb.Append("  FlowId: ").Append(FlowId).Append("\n");
            sb.Append("  FlowName: ").Append(FlowName).Append("\n");
            sb.Append("  FlowVersion: ").Append(FlowVersion).Append("\n");
            sb.Append("  FlowType: ").Append(FlowType).Append("\n");
            sb.Append("  ExitReason: ").Append(ExitReason).Append("\n");
            sb.Append("  EntryReason: ").Append(EntryReason).Append("\n");
            sb.Append("  EntryType: ").Append(EntryType).Append("\n");
            sb.Append("  TransferType: ").Append(TransferType).Append("\n");
            sb.Append("  TransferTargetName: ").Append(TransferTargetName).Append("\n");
            sb.Append("  TransferTargetAddress: ").Append(TransferTargetAddress).Append("\n");
            sb.Append("  IssuedCallback: ").Append(IssuedCallback).Append("\n");
            sb.Append("  StartingLanguage: ").Append(StartingLanguage).Append("\n");
            sb.Append("  EndingLanguage: ").Append(EndingLanguage).Append("\n");
            sb.Append("  Outcomes: ").Append(Outcomes).Append("\n");
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
            return this.Equals(obj as AnalyticsFlow);
        }

        /// <summary>
        /// Returns true if AnalyticsFlow instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsFlow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsFlow other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FlowId == other.FlowId ||
                    this.FlowId != null &&
                    this.FlowId.Equals(other.FlowId)
                ) &&
                (
                    this.FlowName == other.FlowName ||
                    this.FlowName != null &&
                    this.FlowName.Equals(other.FlowName)
                ) &&
                (
                    this.FlowVersion == other.FlowVersion ||
                    this.FlowVersion != null &&
                    this.FlowVersion.Equals(other.FlowVersion)
                ) &&
                (
                    this.FlowType == other.FlowType ||
                    this.FlowType != null &&
                    this.FlowType.Equals(other.FlowType)
                ) &&
                (
                    this.ExitReason == other.ExitReason ||
                    this.ExitReason != null &&
                    this.ExitReason.Equals(other.ExitReason)
                ) &&
                (
                    this.EntryReason == other.EntryReason ||
                    this.EntryReason != null &&
                    this.EntryReason.Equals(other.EntryReason)
                ) &&
                (
                    this.EntryType == other.EntryType ||
                    this.EntryType != null &&
                    this.EntryType.Equals(other.EntryType)
                ) &&
                (
                    this.TransferType == other.TransferType ||
                    this.TransferType != null &&
                    this.TransferType.Equals(other.TransferType)
                ) &&
                (
                    this.TransferTargetName == other.TransferTargetName ||
                    this.TransferTargetName != null &&
                    this.TransferTargetName.Equals(other.TransferTargetName)
                ) &&
                (
                    this.TransferTargetAddress == other.TransferTargetAddress ||
                    this.TransferTargetAddress != null &&
                    this.TransferTargetAddress.Equals(other.TransferTargetAddress)
                ) &&
                (
                    this.IssuedCallback == other.IssuedCallback ||
                    this.IssuedCallback != null &&
                    this.IssuedCallback.Equals(other.IssuedCallback)
                ) &&
                (
                    this.StartingLanguage == other.StartingLanguage ||
                    this.StartingLanguage != null &&
                    this.StartingLanguage.Equals(other.StartingLanguage)
                ) &&
                (
                    this.EndingLanguage == other.EndingLanguage ||
                    this.EndingLanguage != null &&
                    this.EndingLanguage.Equals(other.EndingLanguage)
                ) &&
                (
                    this.Outcomes == other.Outcomes ||
                    this.Outcomes != null &&
                    this.Outcomes.SequenceEqual(other.Outcomes)
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
                
                if (this.FlowId != null)
                    hash = hash * 59 + this.FlowId.GetHashCode();
                
                if (this.FlowName != null)
                    hash = hash * 59 + this.FlowName.GetHashCode();
                
                if (this.FlowVersion != null)
                    hash = hash * 59 + this.FlowVersion.GetHashCode();
                
                if (this.FlowType != null)
                    hash = hash * 59 + this.FlowType.GetHashCode();
                
                if (this.ExitReason != null)
                    hash = hash * 59 + this.ExitReason.GetHashCode();
                
                if (this.EntryReason != null)
                    hash = hash * 59 + this.EntryReason.GetHashCode();
                
                if (this.EntryType != null)
                    hash = hash * 59 + this.EntryType.GetHashCode();
                
                if (this.TransferType != null)
                    hash = hash * 59 + this.TransferType.GetHashCode();
                
                if (this.TransferTargetName != null)
                    hash = hash * 59 + this.TransferTargetName.GetHashCode();
                
                if (this.TransferTargetAddress != null)
                    hash = hash * 59 + this.TransferTargetAddress.GetHashCode();
                
                if (this.IssuedCallback != null)
                    hash = hash * 59 + this.IssuedCallback.GetHashCode();
                
                if (this.StartingLanguage != null)
                    hash = hash * 59 + this.StartingLanguage.GetHashCode();
                
                if (this.EndingLanguage != null)
                    hash = hash * 59 + this.EndingLanguage.GetHashCode();
                
                if (this.Outcomes != null)
                    hash = hash * 59 + this.Outcomes.GetHashCode();
                
                return hash;
            }
        }
    }

}
