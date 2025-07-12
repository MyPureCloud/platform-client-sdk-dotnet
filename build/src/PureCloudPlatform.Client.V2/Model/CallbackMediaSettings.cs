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
    /// CallbackMediaSettings
    /// </summary>
    [DataContract]
    public partial class CallbackMediaSettings :  IEquatable<CallbackMediaSettings>
    {
        /// <summary>
        /// The mode callbacks will use on this queue.
        /// </summary>
        /// <value>The mode callbacks will use on this queue.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Agentfirst for "AgentFirst"
            /// </summary>
            [EnumMember(Value = "AgentFirst")]
            Agentfirst,
            
            /// <summary>
            /// Enum Customerfirst for "CustomerFirst"
            /// </summary>
            [EnumMember(Value = "CustomerFirst")]
            Customerfirst
        }
        /// <summary>
        /// The action to take if a live voice is detected during the outbound call of a customer first callback.
        /// </summary>
        /// <value>The action to take if a live voice is detected during the outbound call of a customer first callback.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum LiveVoiceReactionTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Hangup for "HangUp"
            /// </summary>
            [EnumMember(Value = "HangUp")]
            Hangup,
            
            /// <summary>
            /// Enum Transfertoqueue for "TransferToQueue"
            /// </summary>
            [EnumMember(Value = "TransferToQueue")]
            Transfertoqueue,
            
            /// <summary>
            /// Enum Transfertoflow for "TransferToFlow"
            /// </summary>
            [EnumMember(Value = "TransferToFlow")]
            Transfertoflow
        }
        /// <summary>
        /// The action to take if an answering machine is detected during the outbound call of a customer first callback.
        /// </summary>
        /// <value>The action to take if an answering machine is detected during the outbound call of a customer first callback.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AnsweringMachineReactionTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Hangup for "HangUp"
            /// </summary>
            [EnumMember(Value = "HangUp")]
            Hangup,
            
            /// <summary>
            /// Enum Transfertoqueue for "TransferToQueue"
            /// </summary>
            [EnumMember(Value = "TransferToQueue")]
            Transfertoqueue,
            
            /// <summary>
            /// Enum Transfertoflow for "TransferToFlow"
            /// </summary>
            [EnumMember(Value = "TransferToFlow")]
            Transfertoflow
        }
        /// <summary>
        /// The mode callbacks will use on this queue.
        /// </summary>
        /// <value>The mode callbacks will use on this queue.</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// The action to take if a live voice is detected during the outbound call of a customer first callback.
        /// </summary>
        /// <value>The action to take if a live voice is detected during the outbound call of a customer first callback.</value>
        [DataMember(Name="liveVoiceReactionType", EmitDefaultValue=false)]
        public LiveVoiceReactionTypeEnum? LiveVoiceReactionType { get; set; }
        /// <summary>
        /// The action to take if an answering machine is detected during the outbound call of a customer first callback.
        /// </summary>
        /// <value>The action to take if an answering machine is detected during the outbound call of a customer first callback.</value>
        [DataMember(Name="answeringMachineReactionType", EmitDefaultValue=false)]
        public AnsweringMachineReactionTypeEnum? AnsweringMachineReactionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackMediaSettings" /> class.
        /// </summary>
        /// <param name="EnableAutoAnswer">Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings..</param>
        /// <param name="AlertingTimeoutSeconds">The alerting timeout for the media type, in seconds.</param>
        /// <param name="ServiceLevel">The targeted service level for the media type.</param>
        /// <param name="AutoAnswerAlertToneSeconds">How long to play the alerting tone for an auto-answer interaction.</param>
        /// <param name="ManualAnswerAlertToneSeconds">How long to play the alerting tone for a manual-answer interaction.</param>
        /// <param name="SubTypeSettings">Map of media subtype to media subtype specific settings..</param>
        /// <param name="Mode">The mode callbacks will use on this queue..</param>
        /// <param name="EnableAutoDialAndEnd">Flag to enable Auto-Dial and Auto-End automation for callbacks on this queue..</param>
        /// <param name="AutoDialDelaySeconds">Time in seconds after agent connects to callback before outgoing call is auto-dialed. Allowable values in range 0 - 1200 seconds. Defaults to 300 seconds..</param>
        /// <param name="AutoEndDelaySeconds">Time in seconds after agent disconnects from the outgoing call before the encasing callback is auto-ended. Allowable values in range 0 - 1200 seconds. Defaults to 300 seconds..</param>
        /// <param name="PacingModifier">Controls the maximum number of outbound calls at one time when mode is CustomerFirst..</param>
        /// <param name="MaxRetryCount">Maximum number of retries that should be attempted to try and connect a customer first callback to a customer when the initial callback attempt did not connect..</param>
        /// <param name="RetryDelaySeconds">Delay in seconds between each retry of a customer first callback..</param>
        /// <param name="LiveVoiceReactionType">The action to take if a live voice is detected during the outbound call of a customer first callback..</param>
        /// <param name="LiveVoiceFlow">The inbound flow to transfer to if a live voice is detected during the outbound call of a customer first callback..</param>
        /// <param name="AnsweringMachineReactionType">The action to take if an answering machine is detected during the outbound call of a customer first callback..</param>
        /// <param name="AnsweringMachineFlow">The inbound flow to transfer to if an answering machine is detected during the outbound call of a customer first callback when answeringMachineReactionType is set to TransferToFlow..</param>
        public CallbackMediaSettings(bool? EnableAutoAnswer = null, int? AlertingTimeoutSeconds = null, ServiceLevel ServiceLevel = null, double? AutoAnswerAlertToneSeconds = null, double? ManualAnswerAlertToneSeconds = null, Dictionary<string, BaseMediaSettings> SubTypeSettings = null, ModeEnum? Mode = null, bool? EnableAutoDialAndEnd = null, int? AutoDialDelaySeconds = null, int? AutoEndDelaySeconds = null, double? PacingModifier = null, int? MaxRetryCount = null, int? RetryDelaySeconds = null, LiveVoiceReactionTypeEnum? LiveVoiceReactionType = null, DomainEntityRef LiveVoiceFlow = null, AnsweringMachineReactionTypeEnum? AnsweringMachineReactionType = null, DomainEntityRef AnsweringMachineFlow = null)
        {
            this.EnableAutoAnswer = EnableAutoAnswer;
            this.AlertingTimeoutSeconds = AlertingTimeoutSeconds;
            this.ServiceLevel = ServiceLevel;
            this.AutoAnswerAlertToneSeconds = AutoAnswerAlertToneSeconds;
            this.ManualAnswerAlertToneSeconds = ManualAnswerAlertToneSeconds;
            this.SubTypeSettings = SubTypeSettings;
            this.Mode = Mode;
            this.EnableAutoDialAndEnd = EnableAutoDialAndEnd;
            this.AutoDialDelaySeconds = AutoDialDelaySeconds;
            this.AutoEndDelaySeconds = AutoEndDelaySeconds;
            this.PacingModifier = PacingModifier;
            this.MaxRetryCount = MaxRetryCount;
            this.RetryDelaySeconds = RetryDelaySeconds;
            this.LiveVoiceReactionType = LiveVoiceReactionType;
            this.LiveVoiceFlow = LiveVoiceFlow;
            this.AnsweringMachineReactionType = AnsweringMachineReactionType;
            this.AnsweringMachineFlow = AnsweringMachineFlow;
            
        }
        


        /// <summary>
        /// Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings.
        /// </summary>
        /// <value>Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings.</value>
        [DataMember(Name="enableAutoAnswer", EmitDefaultValue=false)]
        public bool? EnableAutoAnswer { get; set; }



        /// <summary>
        /// The alerting timeout for the media type, in seconds
        /// </summary>
        /// <value>The alerting timeout for the media type, in seconds</value>
        [DataMember(Name="alertingTimeoutSeconds", EmitDefaultValue=false)]
        public int? AlertingTimeoutSeconds { get; set; }



        /// <summary>
        /// The targeted service level for the media type
        /// </summary>
        /// <value>The targeted service level for the media type</value>
        [DataMember(Name="serviceLevel", EmitDefaultValue=false)]
        public ServiceLevel ServiceLevel { get; set; }



        /// <summary>
        /// How long to play the alerting tone for an auto-answer interaction
        /// </summary>
        /// <value>How long to play the alerting tone for an auto-answer interaction</value>
        [DataMember(Name="autoAnswerAlertToneSeconds", EmitDefaultValue=false)]
        public double? AutoAnswerAlertToneSeconds { get; set; }



        /// <summary>
        /// How long to play the alerting tone for a manual-answer interaction
        /// </summary>
        /// <value>How long to play the alerting tone for a manual-answer interaction</value>
        [DataMember(Name="manualAnswerAlertToneSeconds", EmitDefaultValue=false)]
        public double? ManualAnswerAlertToneSeconds { get; set; }



        /// <summary>
        /// Map of media subtype to media subtype specific settings.
        /// </summary>
        /// <value>Map of media subtype to media subtype specific settings.</value>
        [DataMember(Name="subTypeSettings", EmitDefaultValue=false)]
        public Dictionary<string, BaseMediaSettings> SubTypeSettings { get; set; }





        /// <summary>
        /// Flag to enable Auto-Dial and Auto-End automation for callbacks on this queue.
        /// </summary>
        /// <value>Flag to enable Auto-Dial and Auto-End automation for callbacks on this queue.</value>
        [DataMember(Name="enableAutoDialAndEnd", EmitDefaultValue=false)]
        public bool? EnableAutoDialAndEnd { get; set; }



        /// <summary>
        /// Time in seconds after agent connects to callback before outgoing call is auto-dialed. Allowable values in range 0 - 1200 seconds. Defaults to 300 seconds.
        /// </summary>
        /// <value>Time in seconds after agent connects to callback before outgoing call is auto-dialed. Allowable values in range 0 - 1200 seconds. Defaults to 300 seconds.</value>
        [DataMember(Name="autoDialDelaySeconds", EmitDefaultValue=false)]
        public int? AutoDialDelaySeconds { get; set; }



        /// <summary>
        /// Time in seconds after agent disconnects from the outgoing call before the encasing callback is auto-ended. Allowable values in range 0 - 1200 seconds. Defaults to 300 seconds.
        /// </summary>
        /// <value>Time in seconds after agent disconnects from the outgoing call before the encasing callback is auto-ended. Allowable values in range 0 - 1200 seconds. Defaults to 300 seconds.</value>
        [DataMember(Name="autoEndDelaySeconds", EmitDefaultValue=false)]
        public int? AutoEndDelaySeconds { get; set; }



        /// <summary>
        /// Controls the maximum number of outbound calls at one time when mode is CustomerFirst.
        /// </summary>
        /// <value>Controls the maximum number of outbound calls at one time when mode is CustomerFirst.</value>
        [DataMember(Name="pacingModifier", EmitDefaultValue=false)]
        public double? PacingModifier { get; set; }



        /// <summary>
        /// Maximum number of retries that should be attempted to try and connect a customer first callback to a customer when the initial callback attempt did not connect.
        /// </summary>
        /// <value>Maximum number of retries that should be attempted to try and connect a customer first callback to a customer when the initial callback attempt did not connect.</value>
        [DataMember(Name="maxRetryCount", EmitDefaultValue=false)]
        public int? MaxRetryCount { get; set; }



        /// <summary>
        /// Delay in seconds between each retry of a customer first callback.
        /// </summary>
        /// <value>Delay in seconds between each retry of a customer first callback.</value>
        [DataMember(Name="retryDelaySeconds", EmitDefaultValue=false)]
        public int? RetryDelaySeconds { get; set; }





        /// <summary>
        /// The inbound flow to transfer to if a live voice is detected during the outbound call of a customer first callback.
        /// </summary>
        /// <value>The inbound flow to transfer to if a live voice is detected during the outbound call of a customer first callback.</value>
        [DataMember(Name="liveVoiceFlow", EmitDefaultValue=false)]
        public DomainEntityRef LiveVoiceFlow { get; set; }





        /// <summary>
        /// The inbound flow to transfer to if an answering machine is detected during the outbound call of a customer first callback when answeringMachineReactionType is set to TransferToFlow.
        /// </summary>
        /// <value>The inbound flow to transfer to if an answering machine is detected during the outbound call of a customer first callback when answeringMachineReactionType is set to TransferToFlow.</value>
        [DataMember(Name="answeringMachineFlow", EmitDefaultValue=false)]
        public DomainEntityRef AnsweringMachineFlow { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallbackMediaSettings {\n");

            sb.Append("  EnableAutoAnswer: ").Append(EnableAutoAnswer).Append("\n");
            sb.Append("  AlertingTimeoutSeconds: ").Append(AlertingTimeoutSeconds).Append("\n");
            sb.Append("  ServiceLevel: ").Append(ServiceLevel).Append("\n");
            sb.Append("  AutoAnswerAlertToneSeconds: ").Append(AutoAnswerAlertToneSeconds).Append("\n");
            sb.Append("  ManualAnswerAlertToneSeconds: ").Append(ManualAnswerAlertToneSeconds).Append("\n");
            sb.Append("  SubTypeSettings: ").Append(SubTypeSettings).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  EnableAutoDialAndEnd: ").Append(EnableAutoDialAndEnd).Append("\n");
            sb.Append("  AutoDialDelaySeconds: ").Append(AutoDialDelaySeconds).Append("\n");
            sb.Append("  AutoEndDelaySeconds: ").Append(AutoEndDelaySeconds).Append("\n");
            sb.Append("  PacingModifier: ").Append(PacingModifier).Append("\n");
            sb.Append("  MaxRetryCount: ").Append(MaxRetryCount).Append("\n");
            sb.Append("  RetryDelaySeconds: ").Append(RetryDelaySeconds).Append("\n");
            sb.Append("  LiveVoiceReactionType: ").Append(LiveVoiceReactionType).Append("\n");
            sb.Append("  LiveVoiceFlow: ").Append(LiveVoiceFlow).Append("\n");
            sb.Append("  AnsweringMachineReactionType: ").Append(AnsweringMachineReactionType).Append("\n");
            sb.Append("  AnsweringMachineFlow: ").Append(AnsweringMachineFlow).Append("\n");
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
            return this.Equals(obj as CallbackMediaSettings);
        }

        /// <summary>
        /// Returns true if CallbackMediaSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of CallbackMediaSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallbackMediaSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EnableAutoAnswer == other.EnableAutoAnswer ||
                    this.EnableAutoAnswer != null &&
                    this.EnableAutoAnswer.Equals(other.EnableAutoAnswer)
                ) &&
                (
                    this.AlertingTimeoutSeconds == other.AlertingTimeoutSeconds ||
                    this.AlertingTimeoutSeconds != null &&
                    this.AlertingTimeoutSeconds.Equals(other.AlertingTimeoutSeconds)
                ) &&
                (
                    this.ServiceLevel == other.ServiceLevel ||
                    this.ServiceLevel != null &&
                    this.ServiceLevel.Equals(other.ServiceLevel)
                ) &&
                (
                    this.AutoAnswerAlertToneSeconds == other.AutoAnswerAlertToneSeconds ||
                    this.AutoAnswerAlertToneSeconds != null &&
                    this.AutoAnswerAlertToneSeconds.Equals(other.AutoAnswerAlertToneSeconds)
                ) &&
                (
                    this.ManualAnswerAlertToneSeconds == other.ManualAnswerAlertToneSeconds ||
                    this.ManualAnswerAlertToneSeconds != null &&
                    this.ManualAnswerAlertToneSeconds.Equals(other.ManualAnswerAlertToneSeconds)
                ) &&
                (
                    this.SubTypeSettings == other.SubTypeSettings ||
                    this.SubTypeSettings != null &&
                    this.SubTypeSettings.SequenceEqual(other.SubTypeSettings)
                ) &&
                (
                    this.Mode == other.Mode ||
                    this.Mode != null &&
                    this.Mode.Equals(other.Mode)
                ) &&
                (
                    this.EnableAutoDialAndEnd == other.EnableAutoDialAndEnd ||
                    this.EnableAutoDialAndEnd != null &&
                    this.EnableAutoDialAndEnd.Equals(other.EnableAutoDialAndEnd)
                ) &&
                (
                    this.AutoDialDelaySeconds == other.AutoDialDelaySeconds ||
                    this.AutoDialDelaySeconds != null &&
                    this.AutoDialDelaySeconds.Equals(other.AutoDialDelaySeconds)
                ) &&
                (
                    this.AutoEndDelaySeconds == other.AutoEndDelaySeconds ||
                    this.AutoEndDelaySeconds != null &&
                    this.AutoEndDelaySeconds.Equals(other.AutoEndDelaySeconds)
                ) &&
                (
                    this.PacingModifier == other.PacingModifier ||
                    this.PacingModifier != null &&
                    this.PacingModifier.Equals(other.PacingModifier)
                ) &&
                (
                    this.MaxRetryCount == other.MaxRetryCount ||
                    this.MaxRetryCount != null &&
                    this.MaxRetryCount.Equals(other.MaxRetryCount)
                ) &&
                (
                    this.RetryDelaySeconds == other.RetryDelaySeconds ||
                    this.RetryDelaySeconds != null &&
                    this.RetryDelaySeconds.Equals(other.RetryDelaySeconds)
                ) &&
                (
                    this.LiveVoiceReactionType == other.LiveVoiceReactionType ||
                    this.LiveVoiceReactionType != null &&
                    this.LiveVoiceReactionType.Equals(other.LiveVoiceReactionType)
                ) &&
                (
                    this.LiveVoiceFlow == other.LiveVoiceFlow ||
                    this.LiveVoiceFlow != null &&
                    this.LiveVoiceFlow.Equals(other.LiveVoiceFlow)
                ) &&
                (
                    this.AnsweringMachineReactionType == other.AnsweringMachineReactionType ||
                    this.AnsweringMachineReactionType != null &&
                    this.AnsweringMachineReactionType.Equals(other.AnsweringMachineReactionType)
                ) &&
                (
                    this.AnsweringMachineFlow == other.AnsweringMachineFlow ||
                    this.AnsweringMachineFlow != null &&
                    this.AnsweringMachineFlow.Equals(other.AnsweringMachineFlow)
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
                if (this.EnableAutoAnswer != null)
                    hash = hash * 59 + this.EnableAutoAnswer.GetHashCode();

                if (this.AlertingTimeoutSeconds != null)
                    hash = hash * 59 + this.AlertingTimeoutSeconds.GetHashCode();

                if (this.ServiceLevel != null)
                    hash = hash * 59 + this.ServiceLevel.GetHashCode();

                if (this.AutoAnswerAlertToneSeconds != null)
                    hash = hash * 59 + this.AutoAnswerAlertToneSeconds.GetHashCode();

                if (this.ManualAnswerAlertToneSeconds != null)
                    hash = hash * 59 + this.ManualAnswerAlertToneSeconds.GetHashCode();

                if (this.SubTypeSettings != null)
                    hash = hash * 59 + this.SubTypeSettings.GetHashCode();

                if (this.Mode != null)
                    hash = hash * 59 + this.Mode.GetHashCode();

                if (this.EnableAutoDialAndEnd != null)
                    hash = hash * 59 + this.EnableAutoDialAndEnd.GetHashCode();

                if (this.AutoDialDelaySeconds != null)
                    hash = hash * 59 + this.AutoDialDelaySeconds.GetHashCode();

                if (this.AutoEndDelaySeconds != null)
                    hash = hash * 59 + this.AutoEndDelaySeconds.GetHashCode();

                if (this.PacingModifier != null)
                    hash = hash * 59 + this.PacingModifier.GetHashCode();

                if (this.MaxRetryCount != null)
                    hash = hash * 59 + this.MaxRetryCount.GetHashCode();

                if (this.RetryDelaySeconds != null)
                    hash = hash * 59 + this.RetryDelaySeconds.GetHashCode();

                if (this.LiveVoiceReactionType != null)
                    hash = hash * 59 + this.LiveVoiceReactionType.GetHashCode();

                if (this.LiveVoiceFlow != null)
                    hash = hash * 59 + this.LiveVoiceFlow.GetHashCode();

                if (this.AnsweringMachineReactionType != null)
                    hash = hash * 59 + this.AnsweringMachineReactionType.GetHashCode();

                if (this.AnsweringMachineFlow != null)
                    hash = hash * 59 + this.AnsweringMachineFlow.GetHashCode();

                return hash;
            }
        }
    }

}
