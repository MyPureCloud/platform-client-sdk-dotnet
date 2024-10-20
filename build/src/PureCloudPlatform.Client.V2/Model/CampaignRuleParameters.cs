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
    /// CampaignRuleParameters
    /// </summary>
    [DataContract]
    public partial class CampaignRuleParameters :  IEquatable<CampaignRuleParameters>
    {
        /// <summary>
        /// The operator for comparison. Required for a CampaignRuleCondition.
        /// </summary>
        /// <value>The operator for comparison. Required for a CampaignRuleCondition.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Equals for "equals"
            /// </summary>
            [EnumMember(Value = "equals")]
            Equals,
            
            /// <summary>
            /// Enum Greaterthan for "greaterThan"
            /// </summary>
            [EnumMember(Value = "greaterThan")]
            Greaterthan,
            
            /// <summary>
            /// Enum Greaterthanequalto for "greaterThanEqualTo"
            /// </summary>
            [EnumMember(Value = "greaterThanEqualTo")]
            Greaterthanequalto,
            
            /// <summary>
            /// Enum Lessthan for "lessThan"
            /// </summary>
            [EnumMember(Value = "lessThan")]
            Lessthan,
            
            /// <summary>
            /// Enum Lessthanequalto for "lessThanEqualTo"
            /// </summary>
            [EnumMember(Value = "lessThanEqualTo")]
            Lessthanequalto
        }
        /// <summary>
        /// The priority to set a campaign to. Required for the 'setCampaignPriority' action.
        /// </summary>
        /// <value>The priority to set a campaign to. Required for the 'setCampaignPriority' action.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PriorityEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum _1 for "1"
            /// </summary>
            [EnumMember(Value = "1")]
            _1,
            
            /// <summary>
            /// Enum _2 for "2"
            /// </summary>
            [EnumMember(Value = "2")]
            _2,
            
            /// <summary>
            /// Enum _3 for "3"
            /// </summary>
            [EnumMember(Value = "3")]
            _3,
            
            /// <summary>
            /// Enum _4 for "4"
            /// </summary>
            [EnumMember(Value = "4")]
            _4,
            
            /// <summary>
            /// Enum _5 for "5"
            /// </summary>
            [EnumMember(Value = "5")]
            _5
        }
        /// <summary>
        /// The dialing mode to set a campaign to. Required for the 'setCampaignDialingMode' action.
        /// </summary>
        /// <value>The dialing mode to set a campaign to. Required for the 'setCampaignDialingMode' action.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DialingModeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Agentless for "agentless"
            /// </summary>
            [EnumMember(Value = "agentless")]
            Agentless,
            
            /// <summary>
            /// Enum Preview for "preview"
            /// </summary>
            [EnumMember(Value = "preview")]
            Preview,
            
            /// <summary>
            /// Enum Power for "power"
            /// </summary>
            [EnumMember(Value = "power")]
            Power,
            
            /// <summary>
            /// Enum Predictive for "predictive"
            /// </summary>
            [EnumMember(Value = "predictive")]
            Predictive,
            
            /// <summary>
            /// Enum Progressive for "progressive"
            /// </summary>
            [EnumMember(Value = "progressive")]
            Progressive,
            
            /// <summary>
            /// Enum External for "external"
            /// </summary>
            [EnumMember(Value = "external")]
            External
        }
        /// <summary>
        /// The operator for comparison. Required for a CampaignRuleCondition.
        /// </summary>
        /// <value>The operator for comparison. Required for a CampaignRuleCondition.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// The priority to set a campaign to. Required for the 'setCampaignPriority' action.
        /// </summary>
        /// <value>The priority to set a campaign to. Required for the 'setCampaignPriority' action.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public PriorityEnum? Priority { get; set; }
        /// <summary>
        /// The dialing mode to set a campaign to. Required for the 'setCampaignDialingMode' action.
        /// </summary>
        /// <value>The dialing mode to set a campaign to. Required for the 'setCampaignDialingMode' action.</value>
        [DataMember(Name="dialingMode", EmitDefaultValue=false)]
        public DialingModeEnum? DialingMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleParameters" /> class.
        /// </summary>
        /// <param name="Operator">The operator for comparison. Required for a CampaignRuleCondition..</param>
        /// <param name="Value">The value for comparison. Required for a CampaignRuleCondition..</param>
        /// <param name="Priority">The priority to set a campaign to. Required for the 'setCampaignPriority' action..</param>
        /// <param name="DialingMode">The dialing mode to set a campaign to. Required for the 'setCampaignDialingMode' action..</param>
        /// <param name="AbandonRate">The abandon rate to set a campaign to. Required for the 'setCampaignAbandonRate' action..</param>
        /// <param name="OutboundLineCount">The  number of outbound lines to set a campaign to. Required for the 'setCampaignNumberOfLines' action..</param>
        /// <param name="RelativeWeight">The relative weight to set a campaign to. Required for the 'setCampaignWeight' action..</param>
        /// <param name="MaxCallsPerAgent">The maximum number of calls per agent to set a campaign to. Required for the 'setCampaignMaxCallsPerAgent' action..</param>
        /// <param name="Queue">The queue a campaign to. Required for the 'changeCampaignQueue' action..</param>
        /// <param name="MessagesPerMinute">The number of messages per minute to set a messaging campaign to..</param>
        /// <param name="SmsContentTemplate">The content template to set a SMS campaign to..</param>
        /// <param name="EmailContentTemplate">The content template to set a Email campaign to..</param>
        public CampaignRuleParameters(OperatorEnum? Operator = null, string Value = null, PriorityEnum? Priority = null, DialingModeEnum? DialingMode = null, double? AbandonRate = null, int? OutboundLineCount = null, int? RelativeWeight = null, double? MaxCallsPerAgent = null, DomainEntityRef Queue = null, int? MessagesPerMinute = null, DomainEntityRef SmsContentTemplate = null, DomainEntityRef EmailContentTemplate = null)
        {
            this.Operator = Operator;
            this.Value = Value;
            this.Priority = Priority;
            this.DialingMode = DialingMode;
            this.AbandonRate = AbandonRate;
            this.OutboundLineCount = OutboundLineCount;
            this.RelativeWeight = RelativeWeight;
            this.MaxCallsPerAgent = MaxCallsPerAgent;
            this.Queue = Queue;
            this.MessagesPerMinute = MessagesPerMinute;
            this.SmsContentTemplate = SmsContentTemplate;
            this.EmailContentTemplate = EmailContentTemplate;
            
        }
        




        /// <summary>
        /// The value for comparison. Required for a CampaignRuleCondition.
        /// </summary>
        /// <value>The value for comparison. Required for a CampaignRuleCondition.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }







        /// <summary>
        /// The abandon rate to set a campaign to. Required for the 'setCampaignAbandonRate' action.
        /// </summary>
        /// <value>The abandon rate to set a campaign to. Required for the 'setCampaignAbandonRate' action.</value>
        [DataMember(Name="abandonRate", EmitDefaultValue=false)]
        public double? AbandonRate { get; set; }



        /// <summary>
        /// The  number of outbound lines to set a campaign to. Required for the 'setCampaignNumberOfLines' action.
        /// </summary>
        /// <value>The  number of outbound lines to set a campaign to. Required for the 'setCampaignNumberOfLines' action.</value>
        [DataMember(Name="outboundLineCount", EmitDefaultValue=false)]
        public int? OutboundLineCount { get; set; }



        /// <summary>
        /// The relative weight to set a campaign to. Required for the 'setCampaignWeight' action.
        /// </summary>
        /// <value>The relative weight to set a campaign to. Required for the 'setCampaignWeight' action.</value>
        [DataMember(Name="relativeWeight", EmitDefaultValue=false)]
        public int? RelativeWeight { get; set; }



        /// <summary>
        /// The maximum number of calls per agent to set a campaign to. Required for the 'setCampaignMaxCallsPerAgent' action.
        /// </summary>
        /// <value>The maximum number of calls per agent to set a campaign to. Required for the 'setCampaignMaxCallsPerAgent' action.</value>
        [DataMember(Name="maxCallsPerAgent", EmitDefaultValue=false)]
        public double? MaxCallsPerAgent { get; set; }



        /// <summary>
        /// The queue a campaign to. Required for the 'changeCampaignQueue' action.
        /// </summary>
        /// <value>The queue a campaign to. Required for the 'changeCampaignQueue' action.</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public DomainEntityRef Queue { get; set; }



        /// <summary>
        /// The number of messages per minute to set a messaging campaign to.
        /// </summary>
        /// <value>The number of messages per minute to set a messaging campaign to.</value>
        [DataMember(Name="messagesPerMinute", EmitDefaultValue=false)]
        public int? MessagesPerMinute { get; set; }



        /// <summary>
        /// The content template to set a SMS campaign to.
        /// </summary>
        /// <value>The content template to set a SMS campaign to.</value>
        [DataMember(Name="smsContentTemplate", EmitDefaultValue=false)]
        public DomainEntityRef SmsContentTemplate { get; set; }



        /// <summary>
        /// The content template to set a Email campaign to.
        /// </summary>
        /// <value>The content template to set a Email campaign to.</value>
        [DataMember(Name="emailContentTemplate", EmitDefaultValue=false)]
        public DomainEntityRef EmailContentTemplate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignRuleParameters {\n");

            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  DialingMode: ").Append(DialingMode).Append("\n");
            sb.Append("  AbandonRate: ").Append(AbandonRate).Append("\n");
            sb.Append("  OutboundLineCount: ").Append(OutboundLineCount).Append("\n");
            sb.Append("  RelativeWeight: ").Append(RelativeWeight).Append("\n");
            sb.Append("  MaxCallsPerAgent: ").Append(MaxCallsPerAgent).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  MessagesPerMinute: ").Append(MessagesPerMinute).Append("\n");
            sb.Append("  SmsContentTemplate: ").Append(SmsContentTemplate).Append("\n");
            sb.Append("  EmailContentTemplate: ").Append(EmailContentTemplate).Append("\n");
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
            return this.Equals(obj as CampaignRuleParameters);
        }

        /// <summary>
        /// Returns true if CampaignRuleParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignRuleParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRuleParameters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) &&
                (
                    this.DialingMode == other.DialingMode ||
                    this.DialingMode != null &&
                    this.DialingMode.Equals(other.DialingMode)
                ) &&
                (
                    this.AbandonRate == other.AbandonRate ||
                    this.AbandonRate != null &&
                    this.AbandonRate.Equals(other.AbandonRate)
                ) &&
                (
                    this.OutboundLineCount == other.OutboundLineCount ||
                    this.OutboundLineCount != null &&
                    this.OutboundLineCount.Equals(other.OutboundLineCount)
                ) &&
                (
                    this.RelativeWeight == other.RelativeWeight ||
                    this.RelativeWeight != null &&
                    this.RelativeWeight.Equals(other.RelativeWeight)
                ) &&
                (
                    this.MaxCallsPerAgent == other.MaxCallsPerAgent ||
                    this.MaxCallsPerAgent != null &&
                    this.MaxCallsPerAgent.Equals(other.MaxCallsPerAgent)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.MessagesPerMinute == other.MessagesPerMinute ||
                    this.MessagesPerMinute != null &&
                    this.MessagesPerMinute.Equals(other.MessagesPerMinute)
                ) &&
                (
                    this.SmsContentTemplate == other.SmsContentTemplate ||
                    this.SmsContentTemplate != null &&
                    this.SmsContentTemplate.Equals(other.SmsContentTemplate)
                ) &&
                (
                    this.EmailContentTemplate == other.EmailContentTemplate ||
                    this.EmailContentTemplate != null &&
                    this.EmailContentTemplate.Equals(other.EmailContentTemplate)
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
                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();

                if (this.DialingMode != null)
                    hash = hash * 59 + this.DialingMode.GetHashCode();

                if (this.AbandonRate != null)
                    hash = hash * 59 + this.AbandonRate.GetHashCode();

                if (this.OutboundLineCount != null)
                    hash = hash * 59 + this.OutboundLineCount.GetHashCode();

                if (this.RelativeWeight != null)
                    hash = hash * 59 + this.RelativeWeight.GetHashCode();

                if (this.MaxCallsPerAgent != null)
                    hash = hash * 59 + this.MaxCallsPerAgent.GetHashCode();

                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();

                if (this.MessagesPerMinute != null)
                    hash = hash * 59 + this.MessagesPerMinute.GetHashCode();

                if (this.SmsContentTemplate != null)
                    hash = hash * 59 + this.SmsContentTemplate.GetHashCode();

                if (this.EmailContentTemplate != null)
                    hash = hash * 59 + this.EmailContentTemplate.GetHashCode();

                return hash;
            }
        }
    }

}
